using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable IDE1006

    public partial class ChannelListForm : Form
    {
        public ChannelListForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.radioConfig = mainForm.radioConfig;

            InitializeComponent();
        }

        [DllImport("kernel32")]
        private static extern void Sleep(long dwMilliseconds);

        private string recvdData = "";
        private bool stopProgrammingRequested;
        public bool DEBUG = false;
        private const int NORMAL_RADIO_TIMING = 100;    // 80;
        private const int SLOW_RADIO_TIMING = 250;
        private const int DEBUG_RADIO_TIMING = 500;
        private readonly MainForm mainForm = null;
        private readonly RadioConfig radioConfig = null;

        public bool initializeForm()
        {
            moduleLayoutPanelTab1.channelUpdateClicked = false;
            moduleLayoutPanelTab2.channelUpdateClicked = false;
            moduleLayoutPanelTab3.channelUpdateClicked = false;

            UsbRcvdLabel.Text = "";
            TabPage1.Text = mainForm.module1SelectorControl.GetModuleDisplayName();
            TabPage2.Text = mainForm.module2SelectorControl.GetModuleDisplayName();
            TabPage3.Text = mainForm.module3SelectorControl.GetModuleDisplayName();

            stopProgrammingRequested = false;

            UTModule utm;
            // tab index 0, number 1
            utm = UTModule.findBestModule(mainForm.module1SelectorControl.GetCurrentModuleName(),
                radioConfig.EType ? UTModule.BandPlanOption.EUROPEAN_BAND_PLAN : UTModule.BandPlanOption.NORTHAMERICAN_BAND_PLAN,
                radioConfig.WideBand ? UTModule.WidebandOption.WIDEBAND : UTModule.WidebandOption.NORMAL);
            moduleLayoutPanelTab1.initializeTab(mainForm, 0, this, utm, mainForm.module1SelectorControl, mainForm.radioConfig.getTab1StepSize());

            // tab index 1, number 2
            utm = UTModule.findBestModule(mainForm.module2SelectorControl.GetCurrentModuleName(),
                           radioConfig.EType ? UTModule.BandPlanOption.EUROPEAN_BAND_PLAN : UTModule.BandPlanOption.NORTHAMERICAN_BAND_PLAN,
                           radioConfig.WideBand ? UTModule.WidebandOption.WIDEBAND : UTModule.WidebandOption.NORMAL);
            moduleLayoutPanelTab2.initializeTab(mainForm, 1, this, utm, mainForm.module2SelectorControl, mainForm.radioConfig.getTab2StepSize());

            // tab index 2, number 3
            utm = UTModule.findBestModule(mainForm.module3SelectorControl.GetCurrentModuleName(),
                           radioConfig.EType ? UTModule.BandPlanOption.EUROPEAN_BAND_PLAN : UTModule.BandPlanOption.NORTHAMERICAN_BAND_PLAN,
                           radioConfig.WideBand ? UTModule.WidebandOption.WIDEBAND : UTModule.WidebandOption.NORMAL);
            moduleLayoutPanelTab3.initializeTab(mainForm, 2, this, utm, mainForm.module3SelectorControl, mainForm.radioConfig.getTab3StepSize());
            
            ToolStripStatusLabel.Text = "";

            // set current tab to index 0 (Tab1)
            TabControl.SelectedIndex = 0;

            return true;
        }

        private void closeSerialPort()
        {
            if (SerialPort1.IsOpen)
            {
                SerialPort1.Close();
            }
        }

        private bool openSerialPort(TextBox ComPortTextBox)
        {
            if (DEBUG)
            {
                return true;
            }

            if (SerialPort1.IsOpen)
            {
                return true;
            }

            bool tryDefaultPort = false;
            try
            {
                string portString = mainForm.radioConfig.getUsbPortName();
                SerialPort1.PortName = portString;
                SerialPort1.Open();
                Sleep(3000L);
                tryDefaultPort = true;
            }
            catch (Exception)
            {
                Sleep(500L);
            }

            if (tryDefaultPort)
            {
                bool testMsg = SendString(" ");
                if (testMsg)
                {
                    string message = String.Format("Found Arduino on on COM port: {0}", mainForm.radioConfig.getUsbPortNumber());
                    MessageBox.Show(message);
                    return true;
                }
                else
                {
                    SerialPort1.Close();
                    Sleep(500L);
                }
            }

            ComPortTextBox.Visible = true;
            for (int x = 1; x <= 20; x++)
            {
                ComPortTextBox.Text = "Searching for Arduino on COM Port: " + x;
                ComPortTextBox.Update();

                try
                {
                    string portString = "COM";
                    portString += Convert.ToString(x);
                    SerialPort1.PortName = portString;
                    SerialPort1.Open();
                    Sleep(3000L);
                }
                catch (Exception)
                {
                    Sleep(500L);
                    continue;
                }
                bool testMsg = SendString(" ");
                if (testMsg)
                {
                    string message = "Found Arduino on on COM port: ";
                    message += Convert.ToString(x);
                    MessageBox.Show(message);

                    mainForm.radioConfig.UpdateUSBComPort(x);

                    ComPortTextBox.Visible = false;

                    return true;
                }
                else
                {
                    SerialPort1.Close();
                    Sleep(500L);
                    continue;
                }
            }

            ComPortTextBox.Visible = false;
            return false;
        }


        private int repeaterModeCurrentIndex;
        private int repeaterElements;

        public static readonly List<string> repeaterModes = new() { "SIMPLEX", "PLUS", "MINUS", "DBL MINUS" };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int getRepeaterIncrement(string str)
        {
            int count = 0;
            var toFind = str.ToUpper() ?? "";
            var foundAt = repeaterModes.IndexOf(toFind);

            if (foundAt != repeaterModeCurrentIndex)
            {
                if (foundAt > repeaterModeCurrentIndex)
                {
                    count = foundAt - repeaterModeCurrentIndex;
                }
                else
                {
                    count = (repeaterElements - repeaterModeCurrentIndex) + foundAt;
                }
                repeaterModeCurrentIndex = foundAt;
            }

            return count;
        }

        private int ctcssModeCurrentIndex;

        public static readonly string[] CTCSSModeList = new string[] { "OFF", "XMIT", "XMIT/REC" };
        private int CTCSSModeList_NumElementsToUse = 2; // so the indexes are 0 thru CTCSSModeList_NumElementsToUse-1

        public int getCtcssModeIndex(string str)
        {
            int count = 0;
            if (mainForm.Tsu7CheckBox.Checked)
            {
                CTCSSModeList_NumElementsToUse = 3;
            }
            else
            {
                CTCSSModeList_NumElementsToUse = 2;
            }

            while ((str.ToUpper() ?? "") != (CTCSSModeList[ctcssModeCurrentIndex] ?? ""))
            {
                ctcssModeCurrentIndex++;
                if (ctcssModeCurrentIndex > CTCSSModeList_NumElementsToUse - 1)
                {
                    ctcssModeCurrentIndex = 0;
                }
                count++;
                // todo check for overflow
            }

            return count;
        }

        private int CTCSSToneFrequencyIndex;

        // where these show in each tab's drop-down list, they are all shown with periods for decimal separator.
        public static readonly decimal[] CTCSSToneFrequencyList = new decimal[] { 67.0m, 71.9m, 74.4m, 77.0m, 79.7m, 82.5m, 85.4m, 88.5m, 91.5m, 94.8m, 97.4m,
            100.0m, 103.5m, 107.2m, 110.9m, 114.8m, 118.8m, 123.0m, 127.3m, 131.8m, 136.5m, 141.3m, 146.2m, 151.4m, 156.7m, 162.2m, 167.9m,
            173.8m, 179.9m, 186.2m, 192.8m, 203.5m, 210.7m, 218.1m, 225.7m, 233.6m, 241.8m, 250.3m };

        public int getCTCSSToneFrequencyIndex(string str, ref string command)
        {
            int count = 0;
            decimal toFind = Convert.ToDecimal(str, System.Globalization.CultureInfo.InvariantCulture);
            if (toFind <= CTCSSToneFrequencyList[CTCSSToneFrequencyIndex])
            {
                command = "DOWN";
                while (toFind != CTCSSToneFrequencyList[CTCSSToneFrequencyIndex])
                {
                    CTCSSToneFrequencyIndex--;
                    if (CTCSSToneFrequencyIndex == -1)
                    {
                        // publish an error
                    }
                    count++;
                }
            }
            else
            {
                command = "UP";
                while (toFind != CTCSSToneFrequencyList[CTCSSToneFrequencyIndex])
                {
                    CTCSSToneFrequencyIndex++;
                    if (CTCSSToneFrequencyIndex == CTCSSToneFrequencyList.Length)
                    {
                        // publish an error
                    }
                    count++;
                }
            }

            return count;
        }

        private void ProgramRadioButton_Click(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {
                ProgramBandModule(mainForm.module1SelectorControl, moduleLayoutPanelTab1);
            }
            else if (TabControl.SelectedIndex == 1)
            {
                ProgramBandModule(mainForm.module2SelectorControl, moduleLayoutPanelTab2);
            }
            else if (TabControl.SelectedIndex == 2)
            {
                ProgramBandModule(mainForm.module3SelectorControl, moduleLayoutPanelTab3);
            }

            // ensure serial port is closed.
            closeSerialPort();
        }

        private int toneAndButtonOnTime;

        private bool SetToneTime(int toneTimeMs)
        {
            bool serialStatus = SendString("SET_TONE_TIME:");
            if (serialStatus != true)
            {
                return false;
            }
            serialStatus = SendString(Convert.ToString(toneTimeMs));
            if (serialStatus != true)
            {
                return false;
            }

            return true;
        }

        private bool SetButtonTime(int toneTimeMs)
        {
            bool serialStatus = SendString("SET_BUTTON_TIME:");
            if (serialStatus != true)
            {
                return false;
            }
            serialStatus = SendString(Convert.ToString(toneTimeMs));
            if (serialStatus != true)
            {
                return false;
            }

            return true;
        }

        private void ProgramBandModule( ModuleSelectorControl moduleSelectorControl, ModuleChannelList moduleLayoutPanel)
        {
            ListView ChannelListView = moduleLayoutPanel.ChannelListView;
            bool moduleIsUT144 = moduleSelectorControl.GetCurrentModuleName() == "UT144";
            bool moduleIsUT220 = moduleSelectorControl.GetCurrentModuleName() == "UT220";

            int blankChannelCount = 0;
            bool firstChannelComplete = false;

            textBoxSerialCommands.Text = "";

            stopProgrammingRequested = false;

            moduleLayoutPanel.saveTabOnLeavingIfDirty();

            if (openSerialPort(ComPortTextBox) != true)
            {
                MessageBox.Show("Could not determine Arduino COM port.  Ensure USB cable is plugged in.");
                return;
            }

            repeaterModeCurrentIndex = 0;
            CTCSSToneFrequencyIndex = 7;
            ctcssModeCurrentIndex = 0;

            ToolStripStatusLabel.Text = "";

            string modLabel = TabControl.SelectedTab.Text;
            if (modLabel.EndsWith("440e") | modLabel.EndsWith("1200"))
            {
                // allow "DBL MINUS"
                repeaterElements = 4;
            }
            else
            {
                // disallow "DBL MINUS"
                repeaterElements = 3;
            }

            if (ChannelListView.Items.Count - 2 < 0)
            {
                Interaction.MsgBox("Error.  At least 1 channel must be set for programming.", MsgBoxStyle.Critical, "Programming error message");
                return;
            }

            ProgressBar1.Maximum = ChannelListView.Items.Count - 2;
            string mhzLabel = TabControl.SelectedTab.Text;

            var msgResult = Interaction.MsgBox("1. Reset Band in radio." + Constants.vbCrLf + "   " + Strings.Chr(149) + " Hold 'F' and Band select while turning on radio." + Constants.vbCrLf + "2. Put radio in 'RC' mode." + Constants.vbCrLf + "3. Select " + Strings.Mid(mhzLabel, 3, mhzLabel.Length - 2) + " MHz band on radio." + Constants.vbCrLf + "4. Ensure that both the radio and the tabbed channel list frequency step size are correct." + Constants.vbCrLf + "   " + Strings.Chr(149) + " Step size is selectable per tab under the Options menu", (MsgBoxStyle)((int)MsgBoxStyle.OkCancel + (int)MsgBoxStyle.Critical + (int)MsgBoxStyle.DefaultButton2), "Programming setup message");

            if (msgResult == MsgBoxResult.Cancel)
            {
                return;
            }

            Timer1.Enabled = true;

            if (mainForm.normalRadioTimingButton.Checked)
            {
                toneAndButtonOnTime = NORMAL_RADIO_TIMING;
            }
            else if (mainForm.slowRadioTimingButton.Checked)
            {
                toneAndButtonOnTime = SLOW_RADIO_TIMING;
            }
            else
            {
                toneAndButtonOnTime = DEBUG_RADIO_TIMING;
            }

            var serialStatus = SetToneTime(toneAndButtonOnTime);
            if (serialStatus != true)
            {
                return;
            }

            serialStatus = SetButtonTime(toneAndButtonOnTime);
            if (serialStatus != true)
            {
                return;
            }

            // initiate programming of channels, now that timing is set as desired
            serialStatus = SendString("VFO");
            if (serialStatus != true)
            {
                return;
            }
            textBoxSerialCommands.AppendText(Environment.NewLine);

            for (int channelIndex = 0, loopTo = ChannelListView.Items.Count - 2; channelIndex <= loopTo; channelIndex++)
            {
                // change the color of the channel list item for visual programming progress
                ChannelListView.EnsureVisible(channelIndex);
                ProgressBar1.Value = channelIndex;
                ChannelListView.Items[channelIndex].BackColor = Color.LightGreen;
                ChannelListView.Update();

                if (ChannelListView.Items[channelIndex].SubItems[1].Text == "BLANK" || string.IsNullOrEmpty(ChannelListView.Items[channelIndex].SubItems[1].Text))
                {
                    blankChannelCount++;
                }
                else
                {
                    // send freq digits
                    string freq = ChannelListView.Items[channelIndex].SubItems[1].Text;
                    // ensure conversion based on period '.' is the decimal separator
                    decimal decFrequency = Convert.ToDecimal(freq, System.Globalization.CultureInfo.InvariantCulture); ;

                    int decimalPointLocation = freq.IndexOf(".");

                    string mhzVal = decimalPointLocation != -1 ? Strings.Mid(freq, 1, decimalPointLocation) : freq;
                    string kHzVal = decimalPointLocation != -1 ? Strings.Mid(freq, decimalPointLocation + 2) : "000";

                    int numOfKhzChars = 3;
                    decimal stepSize = Convert.ToDecimal(Conversions.ToString(moduleLayoutPanel.KhzSpacingComboBox.SelectedItem), System.Globalization.CultureInfo.InvariantCulture);
                    if ((stepSize == 12.5m) || (stepSize == 25.0m))
                    {
                        numOfKhzChars = 2;
                    }

                    SendString("A");        // ENTER key. See page 61 of User Manual.

                    if (mainForm.wideBandCheckBox.Checked && TabControl.SelectedTab.Text.Contains("1200"))
                    {
                        SendString(Conversions.ToString(mhzVal[mhzVal.Length - 3]));    // hundreds of MHz
                    }

                    if (mainForm.wideBandCheckBox.Checked
                        || !TabControl.SelectedTab.Text.Contains("e")
                        || TabControl.SelectedTab.Text.Contains("1200")
                        || TabControl.SelectedTab.Text.Contains("2400"))
                    {
                        SendString(Conversions.ToString(mhzVal[mhzVal.Length - 2]));    // tens of MHz
                    }

                    SendString(Conversions.ToString(mhzVal[mhzVal.Length - 1]));    // units of MHz

                    // now send the KHz characters needed
                    int freqCharIndex = 0;
                    for (int loopVar = 0; loopVar <= (numOfKhzChars - 1); loopVar++)
                    {
                        SendString(Conversions.ToString(kHzVal[freqCharIndex]));
                        freqCharIndex++;
                    }

                    if (mainForm.AROcheckBox.Checked)
                    {
                        // only the UT144 and UT220 have 'Automatic Receiver Offset' feature, it seems
                        if (moduleIsUT144)
                        {
                            // it's a 2m module
                            if (!mainForm.eTypeRadioCheckBox.Checked)
                            {
                                // USA band plan for 2m, based on 'Type E' check box being not checked
                                if (decFrequency < 145.1m)
                                {
                                    getRepeaterIncrement("SIMPLEX");
                                }
                                else if (decFrequency < 145.5m)
                                {
                                    getRepeaterIncrement("MINUS");
                                }
                                else if (decFrequency < 146.0m)
                                {
                                    getRepeaterIncrement("SIMPLEX");
                                }
                                else if (decFrequency < 146.4m)
                                {
                                    getRepeaterIncrement("PLUS");
                                }
                                else if (decFrequency < 146.6m)
                                {
                                    getRepeaterIncrement("SIMPLEX");
                                }
                                else if (decFrequency < 147.0m)
                                {
                                    getRepeaterIncrement("MINUS");
                                }
                                else if (decFrequency < 147.4m)
                                {
                                    getRepeaterIncrement("PLUS");
                                }
                                else if (decFrequency < 147.6m)
                                {
                                    getRepeaterIncrement("SIMPLEX");
                                }
                                else if (decFrequency < 148.0m)
                                {
                                    getRepeaterIncrement("MINUS");
                                }
                                else
                                {
                                    getRepeaterIncrement("SIMPLEX");
                                }
                            }
                            else
                            {
                                // European band plan for 2m, based on 'Type E' checkbox being checked
                                if (decFrequency < 145.6m)
                                {
                                    getRepeaterIncrement("SIMPLEX");
                                }
                                else if (decFrequency < 145.8m)
                                {
                                    getRepeaterIncrement("MINUS");
                                }
                                else
                                {
                                    getRepeaterIncrement("SIMPLEX");
                                }
                            }
                        }
                        else if (moduleIsUT220 && !mainForm.eTypeRadioCheckBox.Checked)
                        {
                            // it's a 220 MHz module.  Cannot be used in an 'e-type' radio (not legal in Europe)
                            if (decFrequency < 223.92m)
                            {
                                getRepeaterIncrement("SIMPLEX");
                            }
                            else if (decFrequency < 225.0m)
                            {
                                getRepeaterIncrement("MINUS");
                            }
                            else
                            {
                                getRepeaterIncrement("SIMPLEX");
                            }
                        }
                    } // end ARO handling

                    // get how many steps are needed from 'current' increment to what was chosen.  Code above in ARO accounts for some choices
                    // being automatic based on the frequency chosen.
                    var repeaterSplitMode = ChannelListView.Items[channelIndex].SubItems[2].Text;
                    var offsetMHz = Convert.ToInt32(ChannelListView.Items[channelIndex].SubItems[5].Text, System.Globalization.CultureInfo.InvariantCulture);
                    var isOddSplit = repeaterSplitMode.Equals("CUSTOM") && (offsetMHz != 0);

                    int repeaterCount = getRepeaterIncrement(isOddSplit ? "SIMPLEX" : repeaterSplitMode);
                    if (repeaterCount > 0)
                    {
                        textBoxSerialCommands.AppendText(" (Mode) ");
                        for (int loopVar = 0; loopVar <= (repeaterCount - 1); loopVar++)
                            SendString("1");
                    }

                    // send CTCSS mode
                    int ctcssCount = getCtcssModeIndex(ChannelListView.Items[channelIndex].SubItems[4].Text);
                    if (ctcssCount > 0)
                    {
                        textBoxSerialCommands.AppendText(" (CTCSS) ");
                        for (int loopVar = 0; loopVar <= (ctcssCount - 1); loopVar++)
                            SendString("2");
                    }

                    // send tone increment/decrement
                    if (ChannelListView.Items[channelIndex].SubItems[4].Text.ToUpper() != "OFF")
                    {
                        string direction = "";
                        int toneCount = getCTCSSToneFrequencyIndex(ChannelListView.Items[channelIndex].SubItems[3].Text, ref direction);
                        if (toneCount > 0)
                        {
                            textBoxSerialCommands.AppendText(" (CTCSS Freq) ");
                            SendString("D");
                            SendString("2");
                            for (int loopVar = 0; loopVar <= (toneCount - 1); loopVar++)
                                SendString(direction);
                            SendString("2");
                            SendString("PAUSE: ");
                        }
                    }

                    // send memory store and increment
                    SendString("D");        // F key. See page 61 of User Manual.

                    if (!firstChannelComplete)
                    {
                        for (int y = 0; y <= (blankChannelCount - 1); y++)
                            SendString("UP");
                        firstChannelComplete = true;
                    }
                    else
                    {
                        for (int y = 0; y <= blankChannelCount; y++)
                            SendString("UP");
                    }
                    blankChannelCount = 0;

                    // it is after this point that the 'custom offset' would be set.  See Pg 26 of User Manual
                    if (isOddSplit)
                    {
                        textBoxSerialCommands.AppendText(" (Custom/Odd Split) ");
                        SendString("LONG_MR");

                        SendString("CALL");       // CALL key must be programmed to be 'MHz' button on radio front panel

                        // send the UP button the number of times of a +MHz shift (5 times for a +5 MHz shift)
                        // or DOWN button the number of times of a -MHz shift (5 times for a -5 MHz shift)
                        if (offsetMHz > 0)
                        {
                            for (int y = 0; y < offsetMHz; y++)
                                SendString("UP");
                        }
                        else if (offsetMHz < 0)
                        {
                            for (int y = 0; y < Math.Abs(offsetMHz); y++)
                                SendString("DOWN");
                        }

                        SendString("PAUSE: ");
                        SendString("MR");
                        SendString("PAUSE: ");
                    }

                    SendString("MR");
                    SendString("PAUSE: ");

                    textBoxSerialCommands.AppendText(Environment.NewLine);
                }

                ChannelListView.Items[channelIndex].BackColor = Color.White;
                ChannelListView.Update();

                Application.DoEvents();

                if (stopProgrammingRequested)
                {
                    break;
                }
            }

            ProgressBar1.Value = ChannelListView.Items.Count - 2;
            ChannelListView.Items[ChannelListView.Items.Count - 2].BackColor = Color.White;
            Timer1.Enabled = false;
            ToolStripStatusLabel.Text = "Programming complete.";
            UsbCmdLabel.Text = "";

            UsbRcvdLabel.Text = "";
        }

        private int _Timer1_Tick_cntr = 0;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!ToolStripStatusLabel.Text.Contains("Programming"))
            {
                _Timer1_Tick_cntr = 0;
            }

            if (_Timer1_Tick_cntr % 3 == 0)
            {
                ToolStripStatusLabel.Text = "Programming the radio.";
            }
            else
            {
                ToolStripStatusLabel.Text += " .";
            }

            _Timer1_Tick_cntr++;
        }

        private void SaveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {
                //SaveChannelList(Tab1ChannelListView, SaveFileDialog1.FileName);
                moduleLayoutPanelTab1.SaveChannelListXml(SaveFileDialog1.FileName);
            }
            else if (TabControl.SelectedIndex == 1)
            {
                //SaveChannelList(Tab2ChannelListView, SaveFileDialog1.FileName);
                moduleLayoutPanelTab2.SaveChannelListXml(SaveFileDialog1.FileName);
            }
            else if (TabControl.SelectedIndex == 2)
            {
                //SaveChannelList(Tab3ChannelListView, SaveFileDialog1.FileName);
                moduleLayoutPanelTab3.SaveChannelListXml(SaveFileDialog1.FileName);
            }
        }

        private void OpenFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var fileName = OpenFileDialog1.FileName;
            if (TabControl.SelectedIndex == 0)
            {
                if (fileName.EndsWith(".csv"))
                {
                    moduleLayoutPanelTab1.LoadChannelList(fileName);
                }
                else if (fileName.EndsWith(".xml"))
                {
                    moduleLayoutPanelTab1.LoadChannelListXml(fileName);
                }
            }
            else if (TabControl.SelectedIndex == 1)
            {
                if (fileName.EndsWith(".csv"))
                {
                    moduleLayoutPanelTab2.LoadChannelList(fileName);
                }
                else if (fileName.EndsWith(".xml"))
                {
                    moduleLayoutPanelTab2.LoadChannelListXml(fileName);
                }
            }
            else if (TabControl.SelectedIndex == 2)
            {
                if (fileName.EndsWith(".csv"))
                {
                    moduleLayoutPanelTab3.LoadChannelList(fileName);
                }
                else if (fileName.EndsWith(".xml"))
                {
                    moduleLayoutPanelTab3.LoadChannelListXml(fileName);
                }
            }
        }

        public bool SendString(string strLcl)
        {
            Label commandLabel = UsbCmdLabel;
            // Label cmdRcvdObj = Tab1UsbRcvdLabel;

            // cmdRcvdObj.Text = ""
            // cmdRcvdObj.Update()
            commandLabel.Text = strLcl;
            commandLabel.Update();

            textBoxSerialCommands.AppendText(strLcl + ", ");

            if (!DEBUG)
            {
                SerialPort1.WriteLine(strLcl + Conversions.ToString('\r'));
                return WaitForReady();
            }
            else
            {
                Sleep(200L);
                return true;
            }
        }

        private bool newDataAvailable = false;

        /// <summary>
        /// 
        /// </summary>
        public bool WaitForReady()
        {
            int cntrLcl = 0;

            Label cmdRcvdObj = UsbRcvdLabel;

            do
            {
                Sleep(200L);
                Application.DoEvents();

                if (newDataAvailable)
                {
                    cmdRcvdObj.Text = recvdData;
                    cmdRcvdObj.Update();
                }

                if (newDataAvailable && recvdData.Contains("READY"))
                {
                    newDataAvailable = false;
                    return true;
                }
                else
                {
                    cntrLcl++;
                }
            } while (cntrLcl != 10);

            newDataAvailable = false;
            return false;
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            recvdData = SerialPort1.ReadLine();
            newDataAvailable = true;
        }

        private void ChannelListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerialPort1.Close();

            if (TabControl.SelectedIndex == 0)
            {
                moduleLayoutPanelTab1.saveTabOnLeavingIfDirty();
            }
            else if (TabControl.SelectedIndex == 1)
            {
                 moduleLayoutPanelTab2.saveTabOnLeavingIfDirty();
            }
            else
            {
                moduleLayoutPanelTab3.saveTabOnLeavingIfDirty();
            }

            mainForm.Enabled = true;
        }


        private void StopProgramButton_Click(object sender, EventArgs e)
        {
            stopProgrammingRequested = true;
        }

        private void tabControl1_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {
                moduleLayoutPanelTab1.saveTabOnLeavingIfDirty( e);
            }
            else if (TabControl.SelectedIndex == 1)
            {
                moduleLayoutPanelTab2.saveTabOnLeavingIfDirty( e);
            }
            else if (TabControl.SelectedIndex == 2)
            {
                moduleLayoutPanelTab3.saveTabOnLeavingIfDirty( e);
            }
        }

        private void UsbRcvdLabel_Click(object sender, EventArgs e)
        {

        }

        private void OpenChannelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.ShowDialog();
        }

        private void SaveChannelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveChannelFileDialog();
        }

        public void SaveChannelFileDialog()
        {
            SaveFileDialog1.AddExtension = true;
            SaveFileDialog1.DefaultExt = "xml";

            SaveFileDialog1.ShowDialog();
        }
    }
}
