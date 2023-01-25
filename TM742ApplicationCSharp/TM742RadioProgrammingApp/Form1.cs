﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.MyServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Radio
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable IDE1006

    public partial class Form1
    {
        public Form1(Form2 parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        [DllImport("kernel32")]
        private static extern void Sleep(long dwMilliseconds);

        private readonly bool[] channelUpdateClicked = new bool[3];
        private string recvdData = "";
        private bool UserSelectedChannel;
        private bool stopProgrammingRequested;
        public  bool DEBUG = false;
        private const int NORMAL_RADIO_TIMING = 80;
        private const int SLOW_RADIO_TIMING = 250;
        private const int DEBUG_RADIO_TIMING = 500;
        private readonly Form2 parentForm = null;
        
        public bool SetStepSize(ToolStripComboBox KhzToolStripComboBoxObj, string stepSizeStr)
        {
            if (stepSizeStr.Equals("10"))
            {
                KhzToolStripComboBoxObj.SelectedIndex = 0;
            }
            else if (stepSizeStr.Equals("12.5"))
            {
                KhzToolStripComboBoxObj.SelectedIndex = 1;
            }
            else if (stepSizeStr.Equals("5"))
            {
                KhzToolStripComboBoxObj.SelectedIndex = 2;
            }
            else if (stepSizeStr.Equals("25"))
            {
                KhzToolStripComboBoxObj.SelectedIndex = 3;
            }
            else
            {
                return false;
            }

            return true;
        }

        private void initializeTab(int tabIndex, string stepSize, ListView ChannelListViewObj,
            ToolStripComboBox KhzToolStripComboBoxObj, ToolStripStatusLabel ToolStripStatusLabelObj,
            RadioButton XmitButton, RadioButton XmitRecButton, RadioButton CtcssOffButton, ComboBox ToneComboBox, ComboBox MhzComboBox)
        {
            TabControl.SelectedIndex = tabIndex;
            KhzToolStripComboBoxObj.Text = 5.ToString();
            ChannelListViewObj.Items.Add(0.ToString());
            ChannelListViewObj.Items[0].SubItems.Add("");
            ChannelListViewObj.Items[0].Text = "1";
            ChannelListViewObj.Items[0].SubItems.Add("");
            ChannelListViewObj.Items[0].SubItems.Add("");
            ChannelListViewObj.Items[0].SubItems.Add("");
            ChannelListViewObj.Items[0].SubItems.Add("");
            ChannelListViewObj.Text = 0.ToString();
            ChannelListViewObj.Items[0].Selected = true;
            ChannelListViewObj.HideSelection = false;
            UserSelectedChannel = false;
            if (!SetStepSize(KhzToolStripComboBoxObj, stepSize))
            {
                KhzToolStripComboBoxObj.Text = Conversions.ToString(KhzToolStripComboBoxObj.Items[0]);
                if (TabControl.SelectedTab.Text.Contains("144e"))
                {
                    KhzToolStripComboBoxObj.Text = Conversions.ToString(KhzToolStripComboBoxObj.Items[1]);
                }
                else if (TabControl.SelectedTab.Text.Contains("144"))
                {
                    KhzToolStripComboBoxObj.Text = Conversions.ToString(KhzToolStripComboBoxObj.Items[2]);
                }
                else if (TabControl.SelectedTab.Text.Contains("440"))
                {
                    KhzToolStripComboBoxObj.Text = Conversions.ToString(KhzToolStripComboBoxObj.Items[1]);
                }
                else if (TabControl.SelectedTab.Text.Contains("1200"))
                {
                    KhzToolStripComboBoxObj.Text = Conversions.ToString(KhzToolStripComboBoxObj.Items[3]);
                }
            }

            ToolStripStatusLabelObj.Text = "";
            XmitButton.Checked = false;
            XmitRecButton.Checked = false;
            CtcssOffButton.Checked = true;
            ToneComboBox.Text = Conversions.ToString(ToneComboBox.Items[0]);
            ToneComboBox.Enabled = false;
            MhzComboBox.Text = Conversions.ToString(MhzComboBox.Items[0]);
            ChannelListViewObj.Items[0].SubItems[1].Text = Conversions.ToString(MhzComboBox.Items[0]);
        }

        public bool initializeForm()
        {
            for (int x = 0; x <= 2; x++)
            {
                channelUpdateClicked[x] = false;
            }

            Tab1UsbRcvdLabel.Text = "";
            Tab2UsbRcvdLabel.Text = "";
            Tab3UsbRcvdLabel.Text = "";

            stopProgrammingRequested = false;

            // tab index 0, number 1
            initializeTab(0, parentForm.getTab1StepSize(), Tab1ChannelListView, Tab1KHzToolStripComboBox, Tab1ToolStripStatusLabel,
                Tab1CtcssXmit, Tab1CtcssXmitRec, Tab1CtcssOff, Tab1ToneComboBox, Tab1MHzComboBox);

            // tab index 1, number 2
            initializeTab(1, parentForm.getTab2StepSize(), Tab2ChannelListView, Tab2KHzToolStripComboBox, Tab2ToolStripStatusLabel,
                Tab2CtcssXmit, Tab2CtcssXmitRec, Tab2CtcssOff, Tab2ToneComboBox, Tab2MHzComboBox);

            // tab index 2, number 3
            initializeTab(2, parentForm.getTab3StepSize(), Tab3ChannelListView, Tab3KHzToolStripComboBox, Tab3ToolStripStatusLabel,
                Tab3CtcssXmit, Tab3CtcssXmitRec, Tab3CtcssOff, Tab3ToneComboBox, Tab3MHzComboBox);

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
                string portString = parentForm.getUsbPortName();
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
                    string message = String.Format("Found Arduino on on COM port: {0}", parentForm.getUsbPortNumber());
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

                    updateSingleEntity(parentForm.xmlFile, "TM742/usbPort", Convert.ToString(x));
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

        public void updateSingleEntity(string xmlFile, string nodeName, string value)
        {
            var testXml = new XmlDocument();
            testXml.Load(xmlFile);
            testXml.SelectSingleNode(nodeName).InnerText = value;
            testXml.Save(xmlFile);
        }

        private void Tab1SetChannelButton_Click(object sender, EventArgs e)
        {
            SetChannelButton(0, Tab1ChannelListView, Tab1MHzComboBox, Tab1KHzCombBox, Tab1RepeaterComboBox, Tab1ToneComboBox, Tab1CtcssXmitRec, Tab1CtcssXmit, Tab1ChannelNotes);
        }

        private void Tab2SetChannelButton_Click(object sender, EventArgs e)
        {
            SetChannelButton(1, Tab2ChannelListView, Tab2MHzComboBox, Tab2KHzCombBox, Tab2RepeaterComboBox, Tab2ToneComboBox, Tab2CtcssXmitRec, Tab2CtcssXmit, Tab2ChannelNotes);
        }

        private void Tab3SetChannelButton_Click(object sender, EventArgs e)
        {
            SetChannelButton(2, Tab3ChannelListView, Tab3MHzComboBox, Tab3KHzCombBox, Tab3RepeaterComboBox, Tab3ToneComboBox, Tab3CtcssXmitRec, Tab3CtcssXmit, Tab3ChannelNotes);
        }

        private void SetChannelButton(int tabIndex, ListView ChannelListViewObj, ComboBox MHzComboBoxObj, ComboBox KHzComboBoxObj, ComboBox RepeaterComboBoxObj,
            ComboBox ToneComboBoxObj, RadioButton CtcssRadioButtonObj, RadioButton ToneRadioButtonObj, TextBox NotesObj)
        {
            int selectedIndex;

            channelUpdateClicked[tabIndex] = true;

            if (!(MHzComboBoxObj.Text == "BLANK"))
            {
                if (!MHzComboBoxObj.Items.Contains(MHzComboBoxObj.Text))
                {
                    Interaction.MsgBox("MHz selected is not a valid choice.", MsgBoxStyle.Critical, "Set Channel Error Message");
                    return;
                }
                if (!(Convert.ToDecimal(KHzComboBoxObj.Text, System.Globalization.CultureInfo.InvariantCulture) * 10000m % 12.5m == 0m
                    || Convert.ToDecimal(KHzComboBoxObj.Text, System.Globalization.CultureInfo.InvariantCulture) * 10000m % 5m == 0m))
                {
                    Interaction.MsgBox("KHz selected is not a valid choice.", MsgBoxStyle.Critical, "Set Channel Error Message");
                    return;
                }
                if (!RepeaterComboBoxObj.Items.Contains(RepeaterComboBoxObj.Text))
                {
                    Interaction.MsgBox("Repeater value selected is not a valid choice.", MsgBoxStyle.Critical, "Set Channel Error Message");
                    return;
                }
                if (!ToneComboBoxObj.Items.Contains(ToneComboBoxObj.Text))
                {
                    Interaction.MsgBox("Tone frequency selected is not a valid choice.", MsgBoxStyle.Critical, "Set Channel Error Message");
                    return;
                }
            }

            selectedIndex = ChannelListViewObj.SelectedItems[0].Index;
            ChannelListViewObj.Items[selectedIndex].SubItems[1].Text = MHzComboBoxObj.Text;

            if (!MHzComboBoxObj.Text.Equals("BLANK"))
            {
                decimal test = Convert.ToDecimal(MHzComboBoxObj.Text, System.Globalization.CultureInfo.InvariantCulture)
                    + Convert.ToDecimal(KHzComboBoxObj.Text, System.Globalization.CultureInfo.InvariantCulture) * 0.001m;
                ChannelListViewObj.Items[selectedIndex].SubItems[1].Text = string.Format("{0:F4}", test);
                ChannelListViewObj.Items[selectedIndex].SubItems[2].Text = RepeaterComboBoxObj.Text;
                ChannelListViewObj.Items[selectedIndex].SubItems[3].Text = ToneComboBoxObj.Text;
                if (ToneRadioButtonObj.Checked)
                {
                    ChannelListViewObj.Items[selectedIndex].SubItems[4].Text = ToneRadioButtonObj.Text;
                }
                else if (CtcssRadioButtonObj.Checked == true)
                {
                    ChannelListViewObj.Items[selectedIndex].SubItems[4].Text = CtcssRadioButtonObj.Text;
                }
                else
                {
                    ChannelListViewObj.Items[selectedIndex].SubItems[4].Text = "OFF";
                }
            }
            else
            {
                ChannelListViewObj.Items[selectedIndex].SubItems[2].Text = "";
                ChannelListViewObj.Items[selectedIndex].SubItems[3].Text = "";
                ChannelListViewObj.Items[selectedIndex].SubItems[4].Text = "";
            }

            ChannelListViewObj.Items[selectedIndex].SubItems[5].Text = NotesObj.Text;

            if (selectedIndex == ChannelListViewObj.Items.Count - 1)
            {
                ChannelListViewObj.Items[selectedIndex].Selected = false;
                selectedIndex += 1;
                ChannelListViewObj.Items.Add(selectedIndex.ToString());
                ChannelListViewObj.Items[selectedIndex].SubItems.Add("");
                if (selectedIndex == 1)
                {
                }
                ChannelListViewObj.Items[selectedIndex].Text = (selectedIndex + 1).ToString();
                ChannelListViewObj.Items[selectedIndex].SubItems.Add(""); // (1).Text = MHzComboBoxObj.Items(0)
                ChannelListViewObj.Items[selectedIndex].SubItems.Add("");
                ChannelListViewObj.Items[selectedIndex].SubItems.Add("");
                ChannelListViewObj.Items[selectedIndex].SubItems.Add("");
                ChannelListViewObj.Items[selectedIndex].Selected = true;
                ChannelListViewObj.Items[selectedIndex].Checked = true;
                ChannelListViewObj.Items[selectedIndex].EnsureVisible();
                ChannelListViewObj.Items[selectedIndex].Selected = true;
                ChannelListViewObj.Select();
                UserSelectedChannel = false;

                if (ChannelListViewObj.Items.Count > 101)
                {
                    Interaction.MsgBox("The number of channels in the list has exceeded 100.  Unexpected results may occur if the radio does not support this feature", MsgBoxStyle.Information, "Channel count warning message");
                }
            }
        }

        private void Tab1ChannelListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChannelListView_SelectedIndexChanged(Tab1ChannelListView, Tab1MHzComboBox, Tab1KHzCombBox, Tab1RepeaterComboBox, Tab1ToneComboBox, Tab1ChannelTextBox,
                Tab1CtcssXmitRec, Tab1CtcssXmit, Tab1ChannelNotes);
        }

        private void Tab2ChannelListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChannelListView_SelectedIndexChanged(Tab2ChannelListView, Tab2MHzComboBox, Tab2KHzCombBox, Tab2RepeaterComboBox, Tab2ToneComboBox, Tab2ChannelTextBox,
                Tab2CtcssXmitRec, Tab2CtcssXmit, Tab2ChannelNotes);
        }

        private void Tab3ChannelListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChannelListView_SelectedIndexChanged(Tab3ChannelListView, Tab3MHzComboBox, Tab3KHzCombBox, Tab3RepeaterComboBox, Tab3ToneComboBox, Tab3ChannelTextBox,
                Tab3CtcssXmitRec, Tab3CtcssXmit, Tab3ChannelNotes);
        }

        private void ChannelListView_SelectedIndexChanged(ListView ChannelListViewObj, ComboBox MHzComboBoxObj, ComboBox KHzComboBoxObj, ComboBox RepeaterComboBoxObj,
            ComboBox ToneComboBoxObj, TextBox ChannelTextBoxObj, RadioButton CtcssRadioButtonObj, RadioButton ToneRadioButtonObj, TextBox NotesObj)
        {
            if (ChannelListViewObj.SelectedItems.Count > 0)
            {
                UserSelectedChannel = true;
                ChannelTextBoxObj.Text = ChannelListViewObj.SelectedItems[0].Text;
//                int channelIndex = Convert.ToInt32(ChannelListViewObj.SelectedItems[0].Text);
                decimal frequency;
                if (!string.IsNullOrEmpty(ChannelListViewObj.SelectedItems[0].SubItems[1].Text) && (ChannelListViewObj.SelectedItems[0].SubItems[1].Text != "BLANK"))
                {
                    frequency = Convert.ToDecimal(ChannelListViewObj.SelectedItems[0].SubItems[1].Text, System.Globalization.CultureInfo.InvariantCulture);
                    MHzComboBoxObj.Text = Convert.ToInt32(frequency - frequency % 1m).ToString();
                    decimal kHzVal = Convert.ToDecimal(Math.Round(frequency % 1m * 1000m, 1));
                    string kHzString = Convert.ToString(kHzVal);
                    if (kHzVal < 10.0m)
                    {
                        kHzString = "00" + kHzString;
                    }
                    else if (kHzVal < 100.0m)
                    {
                        kHzString = "0" + kHzString;
                    }
                    KHzComboBoxObj.Text = kHzString; // Convert.ToInt32((frequency Mod 1) * 1000)
                    RepeaterComboBoxObj.Text = ChannelListViewObj.SelectedItems[0].SubItems[2].Text;
                    ToneComboBoxObj.Text = ChannelListViewObj.SelectedItems[0].SubItems[3].Text;
                    if (ChannelListViewObj.SelectedItems[0].SubItems[3].Text == "OFF")
                    {
                        CtcssRadioButtonObj.Checked = false;
                        ToneRadioButtonObj.Checked = false;
                        ToneComboBoxObj.Enabled = false;
                    }
                    else if (ChannelListViewObj.SelectedItems[0].SubItems[4].Text == "Xmit")
                    {
                        ToneRadioButtonObj.Checked = true;
                        ToneComboBoxObj.Enabled = true;
                    }
                    else if (ChannelListViewObj.SelectedItems[0].SubItems[4].Text == "Xmit/Rec")
                    {
                        CtcssRadioButtonObj.Checked = true;
                        ToneComboBoxObj.Enabled = true;
                    }
                }
                else if (ChannelListViewObj.SelectedItems[0].SubItems[1].Text == "BLANK")
                {
                    MHzComboBoxObj.Text = "BLANK";
                    KHzComboBoxObj.Text = "";
                    RepeaterComboBoxObj.Text = "";
                    ToneComboBoxObj.Text = "";
                    ToneComboBoxObj.Enabled = false;
                    ToneComboBoxObj.Text = Conversions.ToString(ToneComboBoxObj.Items[0]);
                    CtcssRadioButtonObj.Checked = false;
                    ToneRadioButtonObj.Checked = false;
                }
                NotesObj.Text = ChannelListViewObj.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void Tab1MHzComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MHzComboBox_SelectedIndexChanged(Tab1ChannelListView, Tab1MHzComboBox, Tab1KHzCombBox, Tab1KHzToolStripComboBox, Tab1RepeaterComboBox, Tab1ToneComboBox,
                Tab1ChannelTextBox, Tab1CtcssXmitRec, Tab1CtcssXmit, Tab1ChannelNotes, parentForm.Mod1UT144.Checked, parentForm.Mod1UT220.Checked);
        }

        private void Tab2MHzComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MHzComboBox_SelectedIndexChanged(Tab2ChannelListView, Tab2MHzComboBox, Tab2KHzCombBox, Tab2KHzToolStripComboBox, Tab2RepeaterComboBox, Tab2ToneComboBox,
                Tab2ChannelTextBox, Tab2CtcssXmitRec, Tab2CtcssXmit, Tab2ChannelNotes, parentForm.Mod2UT144.Checked, parentForm.Mod2UT220.Checked);
        }

        private void Tab3MHzComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MHzComboBox_SelectedIndexChanged(Tab3ChannelListView, Tab3MHzComboBox, Tab3KHzCombBox, Tab3KHzToolStripComboBox, Tab3RepeaterComboBox, Tab3ToneComboBox,
                Tab3ChannelTextBox, Tab3CtcssXmitRec, Tab3CtcssXmit, Tab3ChannelNotes, parentForm.Mod3UT144.Checked, parentForm.Mod3UT220.Checked);
        }

#pragma warning disable IDE0060
        private void MHzComboBox_SelectedIndexChanged(ListView ChannelListViewObj, ComboBox MHzComboBoxObj, ComboBox KHzComboBoxObj, ToolStripComboBox KhzStepSizeObj,
            ComboBox RepeaterComboBoxObj, ComboBox ToneComboBoxObj, TextBox ChannelTextBoxObj, RadioButton CtcssRadioButtonObj, RadioButton ToneRadioButtonObj, TextBox NotesObj,
            bool moduleIsUT144, bool moduleIsUT220)
        {
            decimal KhzStepSize = Conversions.ToDecimal(KhzStepSizeObj.Text);
            // this should be based on whether a 'type E' radio (really 'use European band plan').  It was: what is the decimal separator
            // was:             if (KhzStepSizeObj.Text.StartsWith("12") && decimalSeparator == ",")
            if (KhzStepSizeObj.Text.StartsWith("12") && parentForm.eTypeRadioCheckBox.Checked)
            {
                // is this if statement necessary?  what other khzStepSize could it be?
                KhzStepSize = 12.5m;
            }

            if (ChannelListViewObj.SelectedItems.Count > 0)
            {
                if (UserSelectedChannel == false || ChannelListViewObj.SelectedItems[0].Index == ChannelListViewObj.Items.Count - 1)
                {
                    if (MHzComboBoxObj.Text != "BLANK" && !string.IsNullOrEmpty(MHzComboBoxObj.Text))
                    {
                        RepeaterComboBoxObj.Text = "SIMPLEX";
                        if (ToneRadioButtonObj.Checked == true)
                        {
                            ToneComboBoxObj.Text = "88.5";  // this text always has a period for decimal separator
                        }
                        else
                        {
                            ToneComboBoxObj.Text = "OFF";
                        }

                        // clear and write KHz ComboBox items
                        KHzComboBoxObj.Items.Clear();
                        decimal x = 0.0m;
                        while (x < 1000m)
                        {
                            if (x < 10m)
                            {
                                KHzComboBoxObj.Items.Add(string.Concat("00", Convert.ToString(x)));
                            }
                            else if (x < 100m)
                            {
                                KHzComboBoxObj.Items.Add(string.Concat("0", Convert.ToString(x)));
                            }
                            else
                            {
                                KHzComboBoxObj.Items.Add(Convert.ToString(x));
                            }
                            x += KhzStepSize;
                        }

                        KHzComboBoxObj.DroppedDown = true;
                    }
                }
            }

            RepeaterComboBoxObj.Text = getRepeaterVal(MHzComboBoxObj.Text, KHzComboBoxObj.Text, moduleIsUT144, moduleIsUT220);

            if (MHzComboBoxObj.Text == "BLANK" | string.IsNullOrEmpty(MHzComboBoxObj.Text))
            {
                RepeaterComboBoxObj.Text = "";
                ToneComboBoxObj.Text = "";
                KHzComboBoxObj.Text = "";
                CtcssRadioButtonObj.Checked = false;
                ToneRadioButtonObj.Checked = false;
            }
        }
#pragma warning restore IDE0060

        private int repeaterModeCurrentIndex;
        private int repeaterElements;

        private readonly List<string> repeaterModes = new() { "SIMPLEX", "PLUS", "MINUS", "DBL MINUS" };

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

        private readonly string[] CTCSSModeList = new string[] { "OFF", "XMIT", "XMIT/REC" };
        private int CTCSSModeList_NumElementsToUse = 2; // so the indexes are 0 thru CTCSSModeList_NumElementsToUse-1

        public int getCtcssModeIndex(string str)
        {
            int count = 0;
            if (parentForm.Tsu7CheckBox.Checked)
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
        private readonly decimal[] CTCSSToneFrequencyList = new decimal[] { 67.0m, 71.9m, 74.4m, 77.0m, 79.7m, 82.5m, 85.4m, 88.5m, 91.5m, 94.8m, 97.4m, 100.0m, 103.5m, 107.2m, 110.9m, 114.8m, 118.8m, 123.0m, 127.3m, 131.8m, 136.5m, 141.3m, 146.2m, 151.4m, 156.7m, 162.2m, 167.9m, 173.8m, 179.9m, 186.2m, 192.8m, 203.5m, 210.7m, 218.1m, 225.7m, 233.6m, 241.8m, 250.3m };

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

        private void ButtonProgramBandModule1_Click(object sender, EventArgs e)
        {
            ProgramBandModule(0, Tab1ProgressBar1,Tab1ChannelListView, Tab1ToolStripStatusLabel, Tab1KHzToolStripComboBox, Tab1UsbCmdLabel, Tab1ComPortTextBox, Tab1SaveChannelFileToolStripMenuItem, parentForm.Mod1UT144.Checked, parentForm.Mod1UT220.Checked);

            // ensure serial port is closed.
            closeSerialPort();
        }

        private void ButtonProgramBandModule2_Click(object sender, EventArgs e)
        {
            ProgramBandModule(1, Tab2ProgressBar1, Tab2ChannelListView, Tab2ToolStripStatusLabel, Tab2KHzToolStripComboBox, Tab2UsbCmdLabel, Tab2ComPortTextBox, Tab2SaveChannelFileToolStripMenuItem, parentForm.Mod2UT144.Checked, parentForm.Mod2UT220.Checked);

            // ensure serial port is closed.
            closeSerialPort();
        }

        private void ButtonProgramBandModule3_Click(object sender, EventArgs e)
        {
            ProgramBandModule(2, Tab3ProgressBar1, Tab3ChannelListView, Tab3ToolStripStatusLabel, Tab3KHzToolStripComboBox, Tab3UsbCmdLabel, Tab3ComPortTextBox, Tab3SaveChannelFileToolStripMenuItem, parentForm.Mod3UT144.Checked, parentForm.Mod3UT220.Checked);

            // ensure serial port is closed.
            closeSerialPort();
        }


        private void ProgramBandModule(int tabIndex, ProgressBar ProgressBarObj, ListView ChannelListViewObj, ToolStripStatusLabel ToolStripStatusLabelObj,
            ToolStripComboBox ToolStripComboBoxObj, Label commandLabel, TextBox ComPortTextBox, ToolStripMenuItem saveFile, bool moduleIsUT144, bool moduleIsUT220)
        {
            int blankChannelCount = 0;
            bool firstChannelComplete = false;

            textBoxSerialCommands.Text = "";

            stopProgrammingRequested = false;

            if (channelUpdateClicked[tabIndex] == true)
            {
                displaySaveMessage(saveFile);
            }
            channelUpdateClicked[tabIndex] = false;

            if (openSerialPort( ComPortTextBox) != true)
            {
                MessageBox.Show("Could not determine Arduino COM port.  Ensure USB cable is plugged in.");
                return;
            }

            repeaterModeCurrentIndex = 0;
            CTCSSToneFrequencyIndex = 7;
            ctcssModeCurrentIndex = 0;

            ToolStripStatusLabelObj.Text = "";

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

            if (ChannelListViewObj.Items.Count - 2 < 0)
            {
                Interaction.MsgBox("Error.  At least 1 channel must be set for programming.", MsgBoxStyle.Critical, "Programming error message");
                return;
            }

            ProgressBarObj.Maximum = ChannelListViewObj.Items.Count - 2;
            string mhzLabel = TabControl.SelectedTab.Text;

            var msgResult = Interaction.MsgBox("1. Reset Band in radio." + Constants.vbCrLf + "   " + Strings.Chr(149) + " Hold 'F' and Band select while turning on radio." + Constants.vbCrLf + "2. Put radio in 'RC' mode." + Constants.vbCrLf + "3. Select " + Strings.Mid(mhzLabel, 3, mhzLabel.Length - 2) + " MHz band on radio." + Constants.vbCrLf + "4. Ensure that both the radio and the tabbed channel list frequency step size are correct." + Constants.vbCrLf + "   " + Strings.Chr(149) + " Step size is selectable per tab under the Options menu", (MsgBoxStyle)((int)MsgBoxStyle.OkCancel + (int)MsgBoxStyle.Critical + (int)MsgBoxStyle.DefaultButton2), "Programming setup message");

            if (msgResult == MsgBoxResult.Cancel)
            {
                return;
            }

            Timer1.Enabled = true;

            int toneAndButtonOnTime;
            if (parentForm.normalRadioTimingButton.Checked)
            {
                toneAndButtonOnTime = NORMAL_RADIO_TIMING;
            }
            else if (parentForm.slowRadioTimingButton.Checked)
            {
                toneAndButtonOnTime = SLOW_RADIO_TIMING;
            }
            else
            {
                toneAndButtonOnTime = DEBUG_RADIO_TIMING;
            }

            string timeString;
            timeString = "SET_TONE_TIME:";
            bool serialStatus = SendString(timeString);
            if (serialStatus != true)
            {
                return;
            }
            timeString = Convert.ToString(toneAndButtonOnTime);
            serialStatus = SendString(timeString);
            if (serialStatus != true)
            {
                return;
            }

            timeString = "SET_BUTTON_TIME:";
            serialStatus = SendString(timeString);
            if (serialStatus != true)
            {
                return;
            }
            timeString = Convert.ToString(toneAndButtonOnTime);
            serialStatus = SendString(timeString);
            if (serialStatus != true)
            {
                return;
            }

            serialStatus = SendString("VFO");
            if (serialStatus != true)
            {
                return;
            }
            textBoxSerialCommands.AppendText(Environment.NewLine);

            for (int channelIndex = 0, loopTo = ChannelListViewObj.Items.Count - 2; channelIndex <= loopTo; channelIndex++)
            {
                // change the color of the channel list item for visual programming progress
                ChannelListViewObj.EnsureVisible(channelIndex);
                ProgressBarObj.Value = channelIndex;
                ChannelListViewObj.Items[channelIndex].BackColor = Color.LightGreen;
                ChannelListViewObj.Update();

                if (ChannelListViewObj.Items[channelIndex].SubItems[1].Text == "BLANK" || string.IsNullOrEmpty(ChannelListViewObj.Items[channelIndex].SubItems[1].Text))
                {
                    blankChannelCount++;
                }
                else
                {
                    // send freq digits
                    string freq = ChannelListViewObj.Items[channelIndex].SubItems[1].Text;
                    decimal decFrequency;

                    int decimalPointLocation = freq.IndexOf(".");
                    if (decimalPointLocation == -1)
                    {
                        // this handles 'European' data with comma as decimal separator (the 'decimal point')
                        decimalPointLocation = freq.IndexOf(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                        if(decimalPointLocation != -1)
                        {
                            decFrequency = Convert.ToDecimal(freq, System.Globalization.CultureInfo.CurrentCulture);
                        }
                        else
                        {
                            // no decimal separator! is that reason to panic? maybe not; just convert as there won't be an issue.
                            // it's just MHz with no KHz somehow.
                            decFrequency = Convert.ToDecimal(freq, System.Globalization.CultureInfo.InvariantCulture);
                        }
                    }
                    else
                    {
                        // ensure conversion based on period '.' is the decimal separator
                        decFrequency = Convert.ToDecimal(freq, System.Globalization.CultureInfo.InvariantCulture);
                    }

                    string mhzVal = decimalPointLocation != -1 ? Strings.Mid(freq, 1, decimalPointLocation) : freq;
                    string kHzVal = decimalPointLocation != -1 ? Strings.Mid(freq, decimalPointLocation + 2) : "000";

                    int numOfKhzChars = 3;
                    if ((Convert.ToDecimal(Conversions.ToString(ToolStripComboBoxObj.SelectedItem)) == 12.5m)
                        || Operators.ConditionalCompareObjectEqual(ToolStripComboBoxObj.SelectedItem, 25.0m, false))
                    {
                        numOfKhzChars = 2;
                    }

                    SendString("A");        // ENTER key. See page 61 of User Manual.

                    if (parentForm.wideBandCheckBox.Checked && TabControl.SelectedTab.Text.Contains("1200"))
                    {
                        SendString(Conversions.ToString(mhzVal[mhzVal.Length - 3]));    // hundreds of MHz
                    }

                    if (parentForm.wideBandCheckBox.Checked || !TabControl.SelectedTab.Text.Contains("e") || TabControl.SelectedTab.Text.Contains("1200"))
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

                    if (parentForm.AROcheckBox.Checked)
                    {
                        // only the UT144 and UT220 have 'Automatic Receiver Offset' feature, it seems
                        if (moduleIsUT144)
                        {
                            // it's a 2m module
                            if (!parentForm.eTypeRadioCheckBox.Checked)
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
                        else if (moduleIsUT220 && !parentForm.eTypeRadioCheckBox.Checked)
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
                    int repeaterCount = getRepeaterIncrement(ChannelListViewObj.Items[channelIndex].SubItems[2].Text);
                    if (repeaterCount > 0)
                    {
                        textBoxSerialCommands.AppendText(" (Mode) ");
                        for (int loopVar = 0; loopVar <= (repeaterCount - 1); loopVar++)
                            SendString("1");
                    }

                    // send CTCSS mode
                    int ctcssCount = getCtcssModeIndex(ChannelListViewObj.Items[channelIndex].SubItems[4].Text);
                    if (ctcssCount > 0)
                    {
                        textBoxSerialCommands.AppendText(" (CTCSS) ");
                        for (int loopVar = 0; loopVar <= (ctcssCount - 1); loopVar++)
                            SendString("2");
                    }

                    // send tone increment/decrement
                    if (ChannelListViewObj.Items[channelIndex].SubItems[4].Text.ToUpper() != "OFF")
                    {
                        string direction = "";
                        int toneCount = getCTCSSToneFrequencyIndex(ChannelListViewObj.Items[channelIndex].SubItems[3].Text, ref direction);
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
                    SendString("MR");
                    SendString("PAUSE: ");

                    textBoxSerialCommands.AppendText(Environment.NewLine);
                }

                ChannelListViewObj.Items[channelIndex].BackColor = Color.White;
                ChannelListViewObj.Update();

                Application.DoEvents();

                if (stopProgrammingRequested)
                {
                    break;
                }
            }

            ProgressBarObj.Value = ChannelListViewObj.Items.Count - 2;
            ChannelListViewObj.Items[ChannelListViewObj.Items.Count - 2].BackColor = Color.White;
            Timer1.Enabled = false;
            ToolStripStatusLabelObj.Text = "Programming complete.";
            commandLabel.Text = "";

            Tab1UsbRcvdLabel.Text = "";
            Tab2UsbRcvdLabel.Text = "";
            Tab3UsbRcvdLabel.Text = "";
        }

        private int _Timer1_Tick_cntr = 0;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ToolStripStatusLabel ToolStripStatusLabelObj;

            // why is SelectedIndex values of 1 and 2 not handled differently?
            if (TabControl.SelectedIndex == 0)
            {
                ToolStripStatusLabelObj = Tab1ToolStripStatusLabel;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                ToolStripStatusLabelObj = Tab2ToolStripStatusLabel;
            }
            else
            {
                ToolStripStatusLabelObj = Tab3ToolStripStatusLabel;
            }

            if (!ToolStripStatusLabelObj.Text.Contains("Programming"))
            {
                _Timer1_Tick_cntr = 0;
            }

            if (_Timer1_Tick_cntr % 3 == 0)
            {
                ToolStripStatusLabelObj.Text = "Programming the radio.";
            }
            else
            {
                ToolStripStatusLabelObj.Text += " .";
            }

            _Timer1_Tick_cntr++;
        }

        private void Tab1KHzStepSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tab1KHzToolStripComboBox.DroppedDown = true;
        }

        private void Tab2KHzStepSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tab2KHzToolStripComboBox.DroppedDown = true;
        }

        private void Tab3KHzStepSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tab3KHzToolStripComboBox.DroppedDown = true;
        }

        private void Tab1KHzToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillKHzComboBox(Tab1MenuStrip, Tab1KHzToolStripComboBox, Tab1ToolStripStepSize, Tab1KHzCombBox);

            if (!Tab1KHzToolStripComboBox.Text.Equals(parentForm.getTab1StepSize()))
            {
                updateSingleEntity(parentForm.xmlFile, "TM742/tab1StepSize", Convert.ToString(Tab1KHzToolStripComboBox.Text));
            }
        }
        private void Tab2KHzToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillKHzComboBox(Tab2MenuStrip, Tab2KHzToolStripComboBox, Tab2ToolStripStepSize, Tab2KHzCombBox);

            if (!Tab2KHzToolStripComboBox.Text.Equals(parentForm.getTab2StepSize()))
            {
                updateSingleEntity(parentForm.xmlFile, "TM742/tab2StepSize", Convert.ToString(Tab2KHzToolStripComboBox.Text));
            }
        }
        private void Tab3KHzToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillKHzComboBox(Tab3MenuStrip, Tab3KHzToolStripComboBox, Tab3ToolStripStepSize, Tab3KHzCombBox);

            if (!Tab3KHzToolStripComboBox.Text.Equals(parentForm.getTab3StepSize()))
            {
                updateSingleEntity(parentForm.xmlFile, "TM742/tab3StepSize", Convert.ToString(Tab3KHzToolStripComboBox.Text));
            }
        }

        private void FillKHzComboBox(MenuStrip MenuStripObj, ToolStripComboBox ToolStripComboBoxObj, ToolStripLabel ToolStripLabelObj, ComboBox KHzComboBoxObj)
        {
            MenuStripObj.Items[0].Select();
            ToolStripLabelObj.Text = "KHz Step Size: " + ToolStripComboBoxObj.Text;

            KHzComboBoxObj.Items.Clear();
            decimal x = 0.0m;
            decimal KhzStepSize = Convert.ToDecimal(ToolStripComboBoxObj.Text, System.Globalization.CultureInfo.InvariantCulture);
            while (x < 1000m)
            {
                if (x < 10m)
                {
                    KHzComboBoxObj.Items.Add(string.Concat("00", Convert.ToString(x)));
                }
                else if (x < 100m)
                {
                    KHzComboBoxObj.Items.Add(string.Concat("0", Convert.ToString(x)));
                }
                else
                {
                    KHzComboBoxObj.Items.Add(Convert.ToString(x));
                }
                x += KhzStepSize;
            }
        }

        private void Tab1BackToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tab1ChannelListView.Items.Count > 1 && channelUpdateClicked[0] == true)
            {
                displaySaveMessage(Tab1SaveChannelFileToolStripMenuItem);
            }

            channelUpdateClicked[0] = false;

            Tab1MHzComboBox.Text = "BLANK";

            Visible = false;
            parentForm.Enabled = true;
        }

        private void Tab2BackToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tab2ChannelListView.Items.Count > 1 && channelUpdateClicked[1] == true)
            {
                displaySaveMessage(Tab2SaveChannelFileToolStripMenuItem);
            }

            channelUpdateClicked[1] = false;

            Tab2MHzComboBox.Text = "BLANK";

            Visible = false;
            parentForm.Enabled = true;
        }

        private void Tab3BackToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tab3ChannelListView.Items.Count > 1 && channelUpdateClicked[2] == true)
            {
                displaySaveMessage(Tab3SaveChannelFileToolStripMenuItem);
            }

            channelUpdateClicked[2] = false;

            Tab3MHzComboBox.Text = "BLANK";

            Visible = false;
            parentForm.Enabled = true;
        }

        private void ButtonClearChannelList1_Click(object sender, EventArgs e)
        {
            clearChannelList(Tab1ChannelListView, Tab1ToolStripStatusLabel, Tab1CtcssXmit, Tab1CtcssXmitRec);
        }

        private void ButtonClearChannelList2_Click(object sender, EventArgs e)
        {
            clearChannelList(Tab2ChannelListView, Tab2ToolStripStatusLabel, Tab2CtcssXmit, Tab2CtcssXmitRec);
        }

        private void ButtonClearChannelList3_Click(object sender, EventArgs e)
        {
            clearChannelList(Tab3ChannelListView, Tab3ToolStripStatusLabel, Tab3CtcssXmit, Tab3CtcssXmitRec);
        }

        private void clearChannelList(ListView ChannelListViewObj, ToolStripLabel ToolStripStatusLabelObj, RadioButton CtssXmitToneObj, RadioButton CtcssXmitRecToneObj)
        { 
            int response = (int)Interaction.MsgBox("Are you sure you want to clear the channel list?", MsgBoxStyle.YesNo, "Channel list clear verification");
            if (response == (int)Constants.vbYes)
            {
                ChannelListViewObj.Items.Clear();
                ChannelListViewObj.Items.Add(0.ToString());
                ChannelListViewObj.Items[0].SubItems.Add("");
                ChannelListViewObj.Items[0].Text = "1";
                ChannelListViewObj.Items[0].SubItems.Add("");
                ChannelListViewObj.Items[0].SubItems.Add("");
                ChannelListViewObj.Items[0].SubItems.Add("");
                ChannelListViewObj.Items[0].SubItems.Add("");
                ChannelListViewObj.Text = "BLANK";
                CtssXmitToneObj.Checked = false;
                CtcssXmitRecToneObj.Checked = false;
                ChannelListViewObj.Items[0].Selected = true;
                ChannelListViewObj.HideSelection = false;
                UserSelectedChannel = false;
                // KhzToolStripComboBoxObj.Text = KhzToolStripComboBoxObj.Items(0)
                ToolStripStatusLabelObj.Text = "";
            }
        }

        private void Tab1CtcssXmit_MouseDown(object sender, MouseEventArgs e)
        {
            handleMouseDown(Tab1ToneComboBox, Tab1CtcssXmit, Tab1CtcssXmitRec);
        }

        private void Tab2CtcssXmit_MouseDown(object sender, MouseEventArgs e)
        {
            handleMouseDown(Tab2ToneComboBox, Tab2CtcssXmit, Tab2CtcssXmitRec);
        }

        private void Tab3CtcssXmit_MouseDown(object sender, MouseEventArgs e)
        {
            handleMouseDown(Tab3ToneComboBox, Tab3CtcssXmit, Tab3CtcssXmitRec);
        }

        private void handleMouseDown(ComboBox ToneObj, RadioButton CtcssXmitObj, RadioButton CtcssXmitRecObj)
        { 
            if (CtcssXmitObj.Checked == false && CtcssXmitRecObj.Checked == false)
            {
                if (CtcssXmitObj.Focused)
                { 
                    CtcssXmitObj.Checked = true;
                }
                else if (CtcssXmitRecObj.Focused)
                {
                    CtcssXmitRecObj.Checked = true;
                }
                ToneObj.Enabled = true;
                ToneObj.DroppedDown = true;
            }
        }

        private void Tab1ToneComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (Tab1ToneComboBox.SelectedIndex == 0)
            {
                Tab1CtcssXmit.Checked = false;
                Tab1CtcssXmitRec.Checked = false;
                Tab1ToneComboBox.Enabled = false;
            }
        }

        private void Tab2ToneComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (Tab2ToneComboBox.SelectedIndex == 0)
            {
                Tab2CtcssXmit.Checked = false;
                Tab2CtcssXmitRec.Checked = false;
                Tab2ToneComboBox.Enabled = false;
            }
        }

        private void Tab3ToneComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (Tab3ToneComboBox.SelectedIndex == 0)
            {
                Tab3CtcssXmit.Checked = false;
                Tab3CtcssXmitRec.Checked = false;
                Tab3ToneComboBox.Enabled = false;
            }
        }

        private void Tab1ToneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tab1ToneComboBox.Text == "OFF")
            {
                Tab1CtcssXmit.Checked = false;
                Tab1CtcssXmitRec.Checked = false;
                Tab1CtcssOff.Checked = true;
                Tab1ToneComboBox.Enabled = false;
            }
        }

        private void Tab2ToneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tab2ToneComboBox.Text == "OFF")
            {
                Tab2CtcssXmit.Checked = false;
                Tab2CtcssXmitRec.Checked = false;
                Tab2CtcssOff.Checked = true;
                Tab2ToneComboBox.Enabled = false;
            }
        }

        private void Tab3ToneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tab3ToneComboBox.Text == "OFF")
            {
                Tab3CtcssXmit.Checked = false;
                Tab3CtcssXmitRec.Checked = false;
                Tab3CtcssOff.Checked = true;
                Tab3ToneComboBox.Enabled = false;
            }
        }

        private void Tab1SaveChannelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog1.AddExtension = true;
            SaveFileDialog1.DefaultExt = "csv";

            SaveFileDialog1.ShowDialog();
        }

        private void SaveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var myWriter = My.MyProject.Computer.FileSystem.OpenTextFileWriter(SaveFileDialog1.FileName, false);

            int index;
            ListView channelListView;

            if (TabControl.SelectedIndex == 0)
            {
                channelListView = Tab1ChannelListView;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                channelListView = Tab2ChannelListView;
            }
            else
            {
                channelListView = Tab3ChannelListView;
            }

            var loopTo = channelListView.Items.Count - 2;
            for (index = 0; index <= loopTo; index++)
            {
                // initialize a string list, and give it its first entry on this line
                List<string> newLine = new (){ channelListView.Items[index].SubItems[0].Text };

                // make sure that the string has a period for a decimal separator
                string mhzLcl = Convert.ToString(Convert.ToDecimal(channelListView.Items[index].SubItems[1].Text), System.Globalization.CultureInfo.InvariantCulture);
                newLine.Add(mhzLcl);
                newLine.Add(channelListView.Items[index].SubItems[2].Text);
                newLine.Add(channelListView.Items[index].SubItems[3].Text);
                newLine.Add(channelListView.Items[index].SubItems[4].Text);
                newLine.Add(channelListView.Items[index].SubItems[5].Text);

                // all values on the line are emitted, with a comma as a separator
                string line = string.Join(",", newLine.ToArray());
                myWriter.WriteLine(line);
            }

            myWriter.Close();

            channelUpdateClicked[TabControl.SelectedIndex] = false;
        }

        private void Tab1OpenChannelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var myParser = My.MyProject.Computer.FileSystem.OpenTextFieldParser(OpenFileDialog1.FileName);
            myParser.SetDelimiters(",");

            int indexLcl = 0;
            ListView channelListView;
            ComboBox mhzComboBox;
//            ComboBox khzComboBox;
            ComboBox repeaterComboBox;
            ComboBox toneComboBox;
//            TextBox notesTextObj;

            if (TabControl.SelectedIndex == 0)
            {
                channelListView = Tab1ChannelListView;
                mhzComboBox = Tab1MHzComboBox;
//                khzComboBox = Tab1KHzCombBox;
                repeaterComboBox = Tab1RepeaterComboBox;
                toneComboBox = Tab1ToneComboBox;
//                notesTextObj = Tab1ChannelNotes;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                channelListView = Tab2ChannelListView;
                mhzComboBox = Tab2MHzComboBox;
//                khzComboBox = Tab2KHzCombBox;
                repeaterComboBox = Tab2RepeaterComboBox;
                toneComboBox = Tab2ToneComboBox;
//                notesTextObj = Tab2ChannelNotes;
            }
            else
            {
                channelListView = Tab3ChannelListView;
                mhzComboBox = Tab3MHzComboBox;
//                khzComboBox = Tab3KHzCombBox;
                repeaterComboBox = Tab3RepeaterComboBox;
                toneComboBox = Tab3ToneComboBox;
//                notesTextObj = Tab3ChannelNotes;
            }

            channelListView.Items.Clear();

            while (!myParser.EndOfData)
            {
                var testAry = myParser.ReadFields();
                channelListView.Items.Add(indexLcl.ToString());
                channelListView.Items[indexLcl].Text = (indexLcl + 1).ToString();
                if (testAry[1] == "BLANK")
                {
                    channelListView.Items[indexLcl].SubItems.Add("BLANK");
                    channelListView.Items[indexLcl].SubItems.Add("");
                    channelListView.Items[indexLcl].SubItems.Add("");
                    channelListView.Items[indexLcl].SubItems.Add("");
                    channelListView.Items[indexLcl].SubItems.Add("");
                    if (testAry.Length == 6)
                    {
                        channelListView.Items[indexLcl].SubItems[5].Text = testAry[5];
                    }
                }
                else
                {
                    // InvariantCulture uses a period as a decimal separator.  CUrrentCulture MAY use a comma.
                    decimal testVal = Convert.ToDecimal(testAry[1], System.Globalization.CultureInfo.InvariantCulture);
                    // Dim freqStr As String = testAry(1)
                    // Dim decimalPointLocation = freqStr.IndexOf(".")
                    // If decimalPointLocation = -1 Then
                    // decimalPointLocation = freqStr.IndexOf(",")
                    // End If
                    // Dim mhzVal As String = Convert.ToString(Mid(freqStr, 1, decimalPointLocation))
                    // Dim kHzVal As String = Convert.ToString(Mid(freqStr, decimalPointLocation + 2))
                    // Dim testVal As Decimal = Convert.ToDecimal(mhzVal) + (Convert.ToDecimal(kHzVal) * 0.001m)
                    if (mhzComboBox.Items.Contains(Convert.ToString(Math.Truncate(testVal)))
                        && ((Math.Round(testVal * 10000m, 0) % 12.5m == 0m) || (Math.Round(testVal * 1000m, 0) % 5m == 0m)))
                    {
                        channelListView.Items[indexLcl].SubItems.Add(testAry[1]);
                    }
                    else
                    {
                        Interaction.MsgBox("Channel frequency in file is not valid for this module selection !", MsgBoxStyle.Critical, "Programming setup message");
                        clearList();
                        return;
                    }

                    if (repeaterComboBox.Items.Contains(testAry[2]))
                    {
                        channelListView.Items[indexLcl].SubItems.Add(testAry[2]);
                    }
                    else
                    {
                        Interaction.MsgBox("Repeater value in file is not valid for this module selection !", MsgBoxStyle.Critical, "Programming setup message");
                        clearList();
                        return;
                    }

                    if (toneComboBox.Items.Contains(testAry[3]))
                    {
                        channelListView.Items[indexLcl].SubItems.Add(testAry[3]);
                    }
                    else
                    {
                        Interaction.MsgBox("Tone value in file is not valid for this module selection !", MsgBoxStyle.Critical, "Programming setup message");
                        clearList();
                        return;
                    }

                    if (!(parentForm.Tsu7CheckBox.Checked == false && testAry[4] == "Xmit/Rec"))
                    {
                        channelListView.Items[indexLcl].SubItems.Add(testAry[4]);
                    }
                    else
                    {
                        Interaction.MsgBox("CTCSS value in file is not valid for this module selection - defaulting to Xmit only  !", MsgBoxStyle.Critical, "Programming setup message");
                        channelListView.Items[indexLcl].SubItems.Add("Xmit");
                    }

                    if (testAry.Length == 6)
                    {
                        channelListView.Items[indexLcl].SubItems.Add(testAry[5]);
                    }
                    else
                    {
                        channelListView.Items[indexLcl].SubItems.Add("");
                    }
                }

                channelListView.Items[indexLcl].EnsureVisible();
                indexLcl += 1;
            }

            channelListView.Items.Add(indexLcl.ToString());
            channelListView.Items[indexLcl].Text = (indexLcl + 1).ToString();
            channelListView.Items[indexLcl].SubItems.Add("BLANK");
            channelListView.Items[indexLcl].SubItems.Add("");
            channelListView.Items[indexLcl].SubItems.Add("");
            channelListView.Items[indexLcl].SubItems.Add("");
            channelListView.Items[indexLcl].SubItems.Add("");
            channelListView.Items[indexLcl].Selected = true;

            myParser.Close();

            channelUpdateClicked[TabControl.SelectedIndex] = false;
        }

        private void clearList()
        {
            ListView ChannelListViewObj;
            ToolStripLabel ToolStripStatusLabelObj;
            RadioButton CtssToneObj;

            if (TabControl.SelectedIndex == 0)
            {
                ChannelListViewObj = Tab1ChannelListView;
                ToolStripStatusLabelObj = Tab1ToolStripStatusLabel;
                CtssToneObj = Tab1CtcssXmit;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                ChannelListViewObj = Tab2ChannelListView;
                ToolStripStatusLabelObj = Tab2ToolStripStatusLabel;
                CtssToneObj = Tab2CtcssXmit;
            }
            else
            {
                ChannelListViewObj = Tab3ChannelListView;
                ToolStripStatusLabelObj = Tab3ToolStripStatusLabel;
                CtssToneObj = Tab3CtcssXmit;
            }

            ChannelListViewObj.Items.Clear();
            ChannelListViewObj.Items.Add(0.ToString());
            ChannelListViewObj.Items[0].Text = "1";
            ChannelListViewObj.Items[0].SubItems.Add("");
            ChannelListViewObj.Items[0].SubItems.Add("");
            ChannelListViewObj.Items[0].SubItems.Add("");
            ChannelListViewObj.Items[0].SubItems.Add("");
            ChannelListViewObj.Items[0].SubItems.Add("");
            ChannelListViewObj.Text = 0.ToString();
            ChannelListViewObj.Text = "BLANK";
            CtssToneObj.Checked = true;
            ChannelListViewObj.Items[0].Selected = true;
            ChannelListViewObj.HideSelection = false;
            UserSelectedChannel = false;
            ToolStripStatusLabelObj.Text = "";
        }

        public bool SendString(string strLcl)
        {
            Label commandLabel;
            // Dim cmdRcvdObj As Label

            if (TabControl.SelectedIndex == 0)
            {
                commandLabel = Tab1UsbCmdLabel;
            }
            // cmdRcvdObj = Tab1UsbRcvdLabel
            else if (TabControl.SelectedIndex == 1)
            {
                commandLabel = Tab2UsbCmdLabel;
            }
            // cmdRcvdObj = Tab2UsbRcvdLabel
            else
            {
                commandLabel = Tab3UsbCmdLabel;
                // cmdRcvdObj = Tab3UsbRcvdLabel
            }

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

            Label cmdRcvdObj;

            if (TabControl.SelectedIndex == 0)
            {
                cmdRcvdObj = Tab1UsbRcvdLabel;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                cmdRcvdObj = Tab2UsbRcvdLabel;
            }
            else
            {
                cmdRcvdObj = Tab3UsbRcvdLabel;
            }

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

        private void Tab1KHzCombBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tab1RepeaterComboBox.Text = getRepeaterVal(Tab1MHzComboBox.Text, Tab1KHzCombBox.Text, parentForm.Mod1UT144.Checked, parentForm.Mod1UT220.Checked);
        }

        private void Tab2KHzCombBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tab2RepeaterComboBox.Text = getRepeaterVal(Tab2MHzComboBox.Text, Tab2KHzCombBox.Text, parentForm.Mod2UT144.Checked, parentForm.Mod2UT220.Checked);
        }

        private void Tab3KHzCombBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tab3RepeaterComboBox.Text = getRepeaterVal(Tab3MHzComboBox.Text, Tab3KHzCombBox.Text, parentForm.Mod3UT144.Checked, parentForm.Mod3UT220.Checked);
        }

        public string getRepeaterVal(string mHz, string kHz, bool moduleIsUT144, bool moduleIsUT220)
        {
            string getRepeaterValRet;

            if (string.IsNullOrEmpty(mHz) | string.IsNullOrEmpty(kHz) | mHz == "BLANK")
            {
                return "SIMPLEX";
            }

            decimal frequency;
            frequency = Convert.ToDecimal(mHz, System.Globalization.CultureInfo.InvariantCulture)
                + Convert.ToDecimal(kHz, System.Globalization.CultureInfo.InvariantCulture) / 1000.0m;

            if (moduleIsUT144)
            {
                if (!parentForm.eTypeRadioCheckBox.Checked)
                {
                    if (frequency < 145.1m)
                    {
                        getRepeaterValRet = "SIMPLEX";
                    }
                    else if (frequency < 145.5m)
                    {
                        getRepeaterValRet = "MINUS";
                    }
                    else if (frequency < 146.0m)
                    {
                        getRepeaterValRet = "SIMPLEX";
                    }
                    else if (frequency < 146.4m)
                    {
                        getRepeaterValRet = "PLUS";
                    }
                    else if (frequency < 146.6m)
                    {
                        getRepeaterValRet = "SIMPLEX";
                    }
                    else if (frequency < 147.0m)
                    {
                        getRepeaterValRet = "MINUS";
                    }
                    else if (frequency < 147.4m)
                    {
                        getRepeaterValRet = "PLUS";
                    }
                    else if (frequency < 147.6m)
                    {
                        getRepeaterValRet = "SIMPLEX";
                    }
                    else if (frequency < 148.0m)
                    {
                        getRepeaterValRet = "MINUS";
                    }
                    else
                    {
                        getRepeaterValRet = "SIMPLEX";
                    }
                }
                else if (frequency < 145.6m)
                {
                    getRepeaterValRet = "SIMPLEX";
                }
                else if (frequency < 145.8m)
                {
                    getRepeaterValRet = "MINUS";
                }
                else
                {
                    getRepeaterValRet = "SIMPLEX";
                }
            }
            else if (moduleIsUT220 && !parentForm.eTypeRadioCheckBox.Checked) 
            {
                if (frequency < 223.92m)
                {
                    getRepeaterValRet = "SIMPLEX";
                }
                else if (frequency < 225.0m)
                {
                    getRepeaterValRet = "MINUS";
                }
                else
                {
                    getRepeaterValRet = "SIMPLEX";
                }
            }
            else
            {
                getRepeaterValRet = "SIMPLEX";
            }

            return getRepeaterValRet;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            ListView channelListObj;
            ToolStripMenuItem menuItemObj;

            if (TabControl.SelectedIndex == 0)
            {
                channelListObj = Tab1ChannelListView;
                menuItemObj = Tab1SaveChannelFileToolStripMenuItem;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                channelListObj = Tab2ChannelListView;
                menuItemObj = Tab2SaveChannelFileToolStripMenuItem;
            }
            else
            {
                channelListObj = Tab3ChannelListView;
                menuItemObj = Tab3SaveChannelFileToolStripMenuItem;
            }

            SerialPort1.Close();

            if (channelListObj.Items.Count > 1 && channelUpdateClicked[TabControl.SelectedIndex] == true)
            {
                displaySaveMessage(menuItemObj);
            }

            channelUpdateClicked[TabControl.SelectedIndex] = false;

            parentForm.Enabled = true;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            ListView ChannelListViewObj;

            if (TabControl.SelectedIndex == 0)
            {
                ChannelListViewObj = Tab1ChannelListView;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                ChannelListViewObj = Tab2ChannelListView;
            }
            else
            {
                ChannelListViewObj = Tab3ChannelListView;
            }

            int numOfChannels = ChannelListViewObj.Items.Count;

            try
            {

                int channelIndex = Convert.ToInt32(ChannelListViewObj.SelectedItems[0].Text);

                if (channelIndex < numOfChannels)
                {
                    ChannelListViewObj.Items.Insert(channelIndex, "");
                    ChannelListViewObj.Items[channelIndex].SubItems.Add("BLANK");
                    ChannelListViewObj.Items[channelIndex].SubItems.Add("");
                    ChannelListViewObj.Items[channelIndex].SubItems.Add("");
                    ChannelListViewObj.Items[channelIndex].SubItems.Add("");
                    ChannelListViewObj.Items[channelIndex].SubItems.Add("");

                    for (int x = 0, loopTo = numOfChannels; x <= loopTo; x++)
                        ChannelListViewObj.Items[x].SubItems[0].Text = (x + 1).ToString();

                    ChannelListViewObj.Items[channelIndex].Selected = true;
                    ChannelListViewObj.Select();

                    if (ChannelListViewObj.Items.Count > 101)
                    {
                        Interaction.MsgBox("The number of channels in the list has exceeded 100.  Unexpected results may occur if the radio does not support this feature", MsgBoxStyle.Information, "Channel count warning message");
                    }

                    channelUpdateClicked[TabControl.SelectedIndex] = true;
                }
            }
            catch
            {
            }
        }

        private void StopProgramButton_Click(object sender, EventArgs e)
        {
            stopProgrammingRequested = true;
        }

        public bool displaySaveMessage(ToolStripMenuItem saveFile)
        {
            var msgResult = Interaction.MsgBox("Would you like to save changes to your Channel List file before continuing?", (MsgBoxStyle)((int)MsgBoxStyle.YesNo + (int)MsgBoxStyle.Critical + (int)MsgBoxStyle.DefaultButton2), "Save query message");
            if (msgResult == MsgBoxResult.Yes)
            {
                saveFile.PerformClick();
            }

            return true;
        }

        private void TabControl_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {
                saveTabOnLeavingIfDirty(0, Tab1ChannelListView, Tab1SaveChannelFileToolStripMenuItem, e);
            }
            else if (TabControl.SelectedIndex == 1)
            {
                saveTabOnLeavingIfDirty(1, Tab2ChannelListView, Tab2SaveChannelFileToolStripMenuItem, e);
            }
            else if (TabControl.SelectedIndex == 2)
            {
                saveTabOnLeavingIfDirty(2, Tab3ChannelListView, Tab3SaveChannelFileToolStripMenuItem, e);
            }

        }

        private void saveTabOnLeavingIfDirty(int tabIndexLeaving, ListView channelListObj, ToolStripMenuItem saveFile, TabControlCancelEventArgs e)
        {
            if (channelListObj.Items.Count > 1 && !parentForm.initializing && channelUpdateClicked[tabIndexLeaving] == true)
            {
                if (displaySaveMessage(saveFile) == false)
                {
                    e.Cancel = true;
                    return;
                }
            }

            channelUpdateClicked[tabIndexLeaving] = false;
        }

        private void Tab1DeleteRowButton_Click(object sender, EventArgs e)
        {
            DeleteRow(0, Tab1ChannelListView);
        }

        private void Tab2DeleteRowButton_Click(object sender, EventArgs e)
        {
            DeleteRow(1, Tab2ChannelListView);
        }

        private void Tab3DeleteRowButton_Click(object sender, EventArgs e)
        {
            DeleteRow(2, Tab3ChannelListView);
        }

        private void DeleteRow(int selectedIndex, ListView ChannelListViewObj)
        {
            int numOfChannels = ChannelListViewObj.Items.Count;

            try
            {
                int channelIndex = Convert.ToInt32(ChannelListViewObj.SelectedItems[0].Text);

                if (channelIndex > 1 && channelIndex < numOfChannels)
                {
                    ChannelListViewObj.Items.RemoveAt(channelIndex - 1);

                    for (int x = 0, loopTo = numOfChannels - 2; x <= loopTo; x++)
                        ChannelListViewObj.Items[x].SubItems[0].Text = (x + 1).ToString();

                    ChannelListViewObj.Items[channelIndex - 1].Selected = true;
                    ChannelListViewObj.Select();

                    channelUpdateClicked[selectedIndex] = true;
                }
            }
            catch
            {
            }
        }

        private void Tab1CtcssOff_CheckedChanged(object sender, EventArgs e)
        {
            CtcssOffChange(Tab1ToneComboBox, Tab1CtcssXmit, Tab1CtcssXmitRec, Tab1CtcssOff);
        }

        private void Tab2CtcssOff_CheckedChanged(object sender, EventArgs e)
        {
            CtcssOffChange(Tab2ToneComboBox, Tab2CtcssXmit, Tab2CtcssXmitRec, Tab2CtcssOff);
        }

        private void Tab3CtcssOff_CheckedChanged(object sender, EventArgs e)
        {
            CtcssOffChange(Tab3ToneComboBox, Tab3CtcssXmit, Tab3CtcssXmitRec, Tab3CtcssOff);
        }

        private void CtcssOffChange(ComboBox ToneObj, RadioButton CtcssXmitObj, RadioButton CtcssXmitRecObj, RadioButton CtcssOffObj)
        { 
            if (CtcssOffObj.Checked)
            {
                CtcssXmitObj.Checked = false;
                CtcssXmitRecObj.Checked = false;
                CtcssOffObj.Checked = true;
                ToneObj.Text = Conversions.ToString(ToneObj.Items[0]);
                ToneObj.Enabled = false;
            }
        }
    }
}