using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Radio
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable IDE1006

    public partial class Form1
    {
        public Form1()
        {
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
        private string decimalSeparator = "";
        
        public bool SetStepSize(string stepSizeStr)
        {
            ToolStripComboBox KhzToolStripComboBoxObj;

            if (TabControl.SelectedIndex == 0)
            {
                KhzToolStripComboBoxObj = Tab1KHzToolStripComboBox;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                KhzToolStripComboBoxObj = Tab2KHzToolStripComboBox;
            }
            else
            {
                KhzToolStripComboBoxObj = Tab3KHzToolStripComboBox;
            }

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

        public bool initializeForm()
        {
            ListView ChannelListViewObj;
            ToolStripComboBox KhzToolStripComboBoxObj;
            ToolStripStatusLabel ToolStripStatusLabelObj;
            RadioButton XmitButton;
            RadioButton XmitRecButton;
            RadioButton CtcssOffButton;
            ComboBox ToneComboBox;
            ComboBox MhzComboBox;

            decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;

            for (int x = 0; x <= 2; x++)
            {
                channelUpdateClicked[x] = false;
            }

            Tab1UsbRcvdLabel.Text = "";
            Tab2UsbRcvdLabel.Text = "";
            Tab3UsbRcvdLabel.Text = "";

            stopProgrammingRequested = false;

            ChannelListViewObj = Tab1ChannelListView;
            KhzToolStripComboBoxObj = Tab1KHzToolStripComboBox;
            ToolStripStatusLabelObj = Tab1ToolStripStatusLabel;
            XmitButton = Tab1CtcssXmit;
            XmitRecButton = Tab1CtcssXmitRec;
            CtcssOffButton = Tab1CtcssOff;
            ToneComboBox = Tab1ToneComboBox;
            MhzComboBox = Tab1MHzComboBox;

            TabControl.SelectedIndex = 0;
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
            if (!SetStepSize(My.MyProject.Forms.Form2.getTab1StepSize()))
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

            ChannelListViewObj = Tab2ChannelListView;
            KhzToolStripComboBoxObj = Tab2KHzToolStripComboBox;
            ToolStripStatusLabelObj = Tab2ToolStripStatusLabel;
            XmitButton = Tab2CtcssXmit;
            XmitRecButton = Tab2CtcssXmitRec;
            CtcssOffButton = Tab2CtcssOff;
            ToneComboBox = Tab2ToneComboBox;
            MhzComboBox = Tab2MHzComboBox;

            TabControl.SelectedIndex = 1;
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
            if (!SetStepSize(My.MyProject.Forms.Form2.getTab2StepSize()))
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

            ChannelListViewObj = Tab3ChannelListView;
            KhzToolStripComboBoxObj = Tab3KHzToolStripComboBox;
            ToolStripStatusLabelObj = Tab3ToolStripStatusLabel;
            XmitButton = Tab3CtcssXmit;
            XmitRecButton = Tab3CtcssXmitRec;
            CtcssOffButton = Tab3CtcssOff;
            ToneComboBox = Tab3ToneComboBox;
            MhzComboBox = Tab3MHzComboBox;

            TabControl.SelectedIndex = 2;
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
            if (!SetStepSize(My.MyProject.Forms.Form2.getTab3StepSize()))
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

            TabControl.SelectedIndex = 0;

            return true;
        }

        private bool openSerialPort()
        {
            if (DEBUG)
            {
                return true;
            }

            if (SerialPort1.IsOpen)
            {
                return true;
            }

            TextBox textBoxObj;

            if (TabControl.SelectedIndex == 0)
            {
                textBoxObj = Tab1ComPortTextBox;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                textBoxObj = Tab2ComPortTextBox;
            }
            else
            {
                textBoxObj = Tab3ComPortTextBox;
            }

            bool tryDefaultPort = false;
            try
            {
                string portString = My.MyProject.Forms.Form2.getUsbPortName();
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
                    string message = String.Format("Found Arduino on on COM port: {0}", My.MyProject.Forms.Form2.getUsbPortNumber());
                    MessageBox.Show(message);
                    return true;
                }
                else
                {
                    SerialPort1.Close();
                    Sleep(500L);
                }
            }

            textBoxObj.Visible = true;
            for (int x = 1; x <= 20; x++)
            {
                textBoxObj.Text = "Searching for Arduino on COM Port: " + x;
                textBoxObj.Update();

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

                    var testXml = new XmlDocument();
                    testXml.Load(My.MyProject.Forms.Form2.xmlFile);
                    testXml.SelectSingleNode("TM742/usbPort").InnerText = Convert.ToString(x);
                    testXml.Save(My.MyProject.Forms.Form2.xmlFile);
                    textBoxObj.Visible = false;

                    return true;
                }
                else
                {
                    SerialPort1.Close();
                    Sleep(500L);
                    continue;
                }
            }

            textBoxObj.Visible = false;
            return false;
        }

        private void SetChannelButtone_Click(object sender, EventArgs e)
        {
            ListView ChannelListViewObj;
            ComboBox MHzComboBoxObj;
            ComboBox KHzComboBoxObj;
            ComboBox RepeaterComboBoxObj;
            ComboBox ToneComboBoxObj;
            RadioButton CtcssRadioButtonObj;
            RadioButton ToneRadioButtonObj;
            int selectedIndex;
            TextBox NotesObj;

            if (TabControl.SelectedIndex == 0)
            {
                ChannelListViewObj = Tab1ChannelListView;
                MHzComboBoxObj = Tab1MHzComboBox;
                KHzComboBoxObj = Tab1KHzCombBox;
                RepeaterComboBoxObj = Tab1RepeaterComboBox;
                ToneComboBoxObj = Tab1ToneComboBox;
                CtcssRadioButtonObj = Tab1CtcssXmitRec;
                ToneRadioButtonObj = Tab1CtcssXmit;
                NotesObj = Tab1ChannelNotes;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                ChannelListViewObj = Tab2ChannelListView;
                MHzComboBoxObj = Tab2MHzComboBox;
                KHzComboBoxObj = Tab2KHzCombBox;
                RepeaterComboBoxObj = Tab2RepeaterComboBox;
                ToneComboBoxObj = Tab2ToneComboBox;
                CtcssRadioButtonObj = Tab2CtcssXmitRec;
                ToneRadioButtonObj = Tab2CtcssXmit;
                NotesObj = Tab2ChannelNotes;
            }
            else
            {
                ChannelListViewObj = Tab3ChannelListView;
                MHzComboBoxObj = Tab3MHzComboBox;
                KHzComboBoxObj = Tab3KHzCombBox;
                RepeaterComboBoxObj = Tab3RepeaterComboBox;
                ToneComboBoxObj = Tab3ToneComboBox;
                CtcssRadioButtonObj = Tab3CtcssXmitRec;
                ToneRadioButtonObj = Tab3CtcssXmit;
                NotesObj = Tab3ChannelNotes;
            }

            channelUpdateClicked[TabControl.SelectedIndex] = true;

            if (!(MHzComboBoxObj.Text == "BLANK"))
            {
                if (!MHzComboBoxObj.Items.Contains(MHzComboBoxObj.Text))
                {
                    Interaction.MsgBox("Mhz selected is not a valid choice.", MsgBoxStyle.Critical, "Set Channel Error Message");
                    return;
                }
                if (!(Convert.ToDouble(fixDecimalSeparator(KHzComboBoxObj.Text)) * 10000d % 12.5d == 0d | Convert.ToDouble(fixDecimalSeparator(KHzComboBoxObj.Text)) * 10000d % 5d == 0d))
                {
                    Interaction.MsgBox("Khz selected is not a valid choice.", MsgBoxStyle.Critical, "Set Channel Error Message");
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
                double test = Convert.ToDouble(fixDecimalSeparator(MHzComboBoxObj.Text)) + Convert.ToDouble(fixDecimalSeparator(KHzComboBoxObj.Text)) * 0.001d;
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

        private void ChannelListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView ChannelListViewObj;
            ComboBox MHzComboBoxObj;
            ComboBox KHzComboBoxObj;
            ComboBox RepeaterComboBoxObj;
            ComboBox ToneComboBoxObj;
            TextBox ChannelTextBoxObj;
            RadioButton CtcssRadioButtonObj;
            RadioButton ToneRadioButtonObj;
            TextBox NotesTextObj;

            if (TabControl.SelectedIndex == 0)
            {
                ChannelListViewObj = Tab1ChannelListView;
                MHzComboBoxObj = Tab1MHzComboBox;
                KHzComboBoxObj = Tab1KHzCombBox;
                RepeaterComboBoxObj = Tab1RepeaterComboBox;
                ToneComboBoxObj = Tab1ToneComboBox;
                ChannelTextBoxObj = Tab1ChannelTextBox;
                CtcssRadioButtonObj = Tab1CtcssXmitRec;
                ToneRadioButtonObj = Tab1CtcssXmit;
                NotesTextObj = Tab1ChannelNotes;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                ChannelListViewObj = Tab2ChannelListView;
                MHzComboBoxObj = Tab2MHzComboBox;
                KHzComboBoxObj = Tab2KHzCombBox;
                RepeaterComboBoxObj = Tab2RepeaterComboBox;
                ToneComboBoxObj = Tab2ToneComboBox;
                ChannelTextBoxObj = Tab2ChannelTextBox;
                CtcssRadioButtonObj = Tab2CtcssXmitRec;
                ToneRadioButtonObj = Tab2CtcssXmit;
                NotesTextObj = Tab2ChannelNotes;
            }
            else
            {
                ChannelListViewObj = Tab3ChannelListView;
                MHzComboBoxObj = Tab3MHzComboBox;
                KHzComboBoxObj = Tab3KHzCombBox;
                RepeaterComboBoxObj = Tab3RepeaterComboBox;
                ToneComboBoxObj = Tab3ToneComboBox;
                ChannelTextBoxObj = Tab3ChannelTextBox;
                CtcssRadioButtonObj = Tab3CtcssXmitRec;
                ToneRadioButtonObj = Tab3CtcssXmit;
                NotesTextObj = Tab3ChannelNotes;
            }

            if (ChannelListViewObj.SelectedItems.Count > 0)
            {
                UserSelectedChannel = true;
                ChannelTextBoxObj.Text = ChannelListViewObj.SelectedItems[0].Text;
//                int channelIndex = Convert.ToInt32(ChannelListViewObj.SelectedItems[0].Text);
                double frequency;
                if (!string.IsNullOrEmpty(ChannelListViewObj.SelectedItems[0].SubItems[1].Text) & ChannelListViewObj.SelectedItems[0].SubItems[1].Text != "BLANK")
                {
                    frequency = Convert.ToDouble(fixDecimalSeparator(ChannelListViewObj.SelectedItems[0].SubItems[1].Text));
                    MHzComboBoxObj.Text = Convert.ToInt32(frequency - frequency % 1d).ToString();
                    double kHzVal = Convert.ToDouble(Math.Round(frequency % 1d * 1000d, 1));
                    string kHzString = Convert.ToString(kHzVal);
                    if (kHzVal < 10d)
                    {
                        kHzString = "00" + kHzString;
                    }
                    else if (kHzVal < 100d)
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
                NotesTextObj.Text = ChannelListViewObj.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void MHzComboBox_DropDown(object sender, EventArgs e)
        {
            // Dim MHzComboBoxObject As ComboBox

            // MHzComboBoxObject = Tab1MHzComboBox
            // Dim itemSelect As Integer = MHzComboBoxObject.Items.Count / 2
            // Dim test As System.IntPtr = Tab1MHzComboBox.Handle
            // test->Events
            // Tab1MHzComboBox.Enabled = False
            // Tab1MHzComboBox.SelectedIndex = 2 'itemSelect

            // 'MHzComboBoxObject.DroppedDown = True

        }

        private void MHzComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListView ChannelListViewObj;
            ComboBox MHzComboBoxObj;
            ComboBox KHzComboBoxObj;
            ComboBox RepeaterComboBoxObj;
            ComboBox ToneComboBoxObj;
//            TextBox ChannelTextBoxObj;
            ToolStripComboBox KhzStepSizeObj;
            RadioButton CtcssRadioButtonObj;
            RadioButton ToneRadioButtonObj;

            if (TabControl.SelectedIndex == 0)
            {
                ChannelListViewObj = Tab1ChannelListView;
                MHzComboBoxObj = Tab1MHzComboBox;
                KHzComboBoxObj = Tab1KHzCombBox;
                RepeaterComboBoxObj = Tab1RepeaterComboBox;
                ToneComboBoxObj = Tab1ToneComboBox;
//                ChannelTextBoxObj = Tab1ChannelTextBox;
                KhzStepSizeObj = Tab1KHzToolStripComboBox;
                CtcssRadioButtonObj = Tab1CtcssXmitRec;
                ToneRadioButtonObj = Tab1CtcssXmit;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                ChannelListViewObj = Tab2ChannelListView;
                MHzComboBoxObj = Tab2MHzComboBox;
                KHzComboBoxObj = Tab2KHzCombBox;
                RepeaterComboBoxObj = Tab2RepeaterComboBox;
                ToneComboBoxObj = Tab2ToneComboBox;
//                ChannelTextBoxObj = Tab2ChannelTextBox;
                KhzStepSizeObj = Tab2KHzToolStripComboBox;
                CtcssRadioButtonObj = Tab2CtcssXmitRec;
                ToneRadioButtonObj = Tab2CtcssXmit;
            }
            else
            {
                ChannelListViewObj = Tab3ChannelListView;
                MHzComboBoxObj = Tab3MHzComboBox;
                KHzComboBoxObj = Tab3KHzCombBox;
                RepeaterComboBoxObj = Tab3RepeaterComboBox;
                ToneComboBoxObj = Tab3ToneComboBox;
//                ChannelTextBoxObj = Tab3ChannelTextBox;
                KhzStepSizeObj = Tab3KHzToolStripComboBox;
                CtcssRadioButtonObj = Tab3CtcssXmitRec;
                ToneRadioButtonObj = Tab3CtcssXmit;
            }

            double KhzStepSize = Conversions.ToDouble(KhzStepSizeObj.Text);
            if (KhzStepSizeObj.Text.StartsWith("12") & decimalSeparator == ",")
            {
                KhzStepSize = 12.5d;
            }

            if (ChannelListViewObj.SelectedItems.Count > 0)
            {
                if (UserSelectedChannel == false | ChannelListViewObj.SelectedItems[0].Index == ChannelListViewObj.Items.Count - 1)
                {
                    if (MHzComboBoxObj.Text != "BLANK" & !string.IsNullOrEmpty(MHzComboBoxObj.Text))
                    {
                        RepeaterComboBoxObj.Text = "SIMPLEX";
                        if (ToneRadioButtonObj.Checked == true)
                        {
                            ToneComboBoxObj.Text = "88.5";
                        }
                        else
                        {
                            ToneComboBoxObj.Text = "OFF";
                        }

                        KHzComboBoxObj.Items.Clear();
                        double x;
                        x = 0.0d;
                        while (x < 1000d)
                        {
                            if (x < 10d)
                            {
                                KHzComboBoxObj.Items.Add(string.Concat("00", Convert.ToString(x)));
                            }
                            else if (x < 100d)
                            {
                                KHzComboBoxObj.Items.Add(string.Concat("0", Convert.ToString(x)));
                            }
                            else
                            {
                                KHzComboBoxObj.Items.Add(Convert.ToString(x));
                            }
                            x += KhzStepSize;
                        }

                        // Tab1KHzCombBox.SelectionStart = 100
                        // Tab1KHzCombBox.SelectedIndex = 50
                        KHzComboBoxObj.DroppedDown = true;
                    }
                }
            }

            RepeaterComboBoxObj.Text = getRepeaterVal(MHzComboBoxObj.Text, KHzComboBoxObj.Text, TabControl.SelectedIndex);

            if (MHzComboBoxObj.Text == "BLANK" | string.IsNullOrEmpty(MHzComboBoxObj.Text))
            {
                RepeaterComboBoxObj.Text = "";
                ToneComboBoxObj.Text = "";
                KHzComboBoxObj.Text = "";
                CtcssRadioButtonObj.Checked = false;
                ToneRadioButtonObj.Checked = false;

            }
        }

        private int repeaterAryIndex;
        private int repeaterElements;

        private readonly string[] _getRepeaterIncrement_repeaterAry = new string[] { "SIMPLEX", "PLUS", "MINUS", "DBL MINUS" };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int getRepeaterIncrement(string str)
        {
            int count = 0;

            while ((str.ToUpper() ?? "") != (_getRepeaterIncrement_repeaterAry[repeaterAryIndex] ?? ""))
            {
                repeaterAryIndex++;
                if (repeaterAryIndex >= repeaterElements)
                {
                    repeaterAryIndex = 0;
                }
                count++;
                // todo check for overflow
            }

            return count;

        }

        private int ctcssAryIndex;

        private readonly string[] _getCtcssIncrement_ctcssAry = new string[] { "OFF", "XMIT", "XMIT/REC" };
        private int _getCtcssIncrement_ctcssElements = 2;

        public int getCtcssIncrement(string str)
        {
            int count = 0;
            if (My.MyProject.Forms.Form2.Tsu7CheckBox.Checked)
            {
                _getCtcssIncrement_ctcssElements = 3;
            }
            else
            {
                _getCtcssIncrement_ctcssElements = 2;
            }

            while ((str.ToUpper() ?? "") != (_getCtcssIncrement_ctcssAry[ctcssAryIndex] ?? ""))
            {
                ctcssAryIndex++;
                if (ctcssAryIndex > _getCtcssIncrement_ctcssElements - 1)
                {
                    ctcssAryIndex = 0;
                }
                count++;
                // todo check for overflow
            }

            return count;

        }

        private int toneAryIndex;

        private readonly double[] _getToneIncrement_toneAry = new double[] { 67.0d, 71.9d, 74.4d, 77.0d, 79.7d, 82.5d, 85.4d, 88.5d, 91.5d, 94.8d, 97.4d, 100.0d, 103.5d, 107.2d, 110.9d, 114.8d, 118.8d, 123.0d, 127.3d, 131.8d, 136.5d, 141.3d, 146.2d, 151.4d, 156.7d, 162.2d, 167.9d, 173.8d, 179.9d, 186.2d, 192.8d, 203.5d, 210.7d, 218.1d, 225.7d, 233.6d, 241.8d, 250.3d };

        public int getToneIncrement(string str, ref string command)
        {
            int count = 0;

            if (Convert.ToDouble(fixDecimalSeparator(str)) <= _getToneIncrement_toneAry[toneAryIndex])
            {
                command = "DOWN";
                while (Convert.ToDouble(fixDecimalSeparator(str)) != _getToneIncrement_toneAry[toneAryIndex])
                {
                    toneAryIndex--;
                    if (toneAryIndex == -1)
                    {
                        // publish an error
                    }
                    count++;
                }
                return count;
            }
            else
            {
                command = "UP";
                while (Convert.ToDouble(fixDecimalSeparator(str)) != _getToneIncrement_toneAry[toneAryIndex])
                {
                    toneAryIndex++;
                    if (toneAryIndex == _getToneIncrement_toneAry.Length)
                    {
                        // publish an error
                    }
                    count++;
                }
            }
            return count;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ProgressBar ProgressBarObj;
            ListView ChannelListViewObj;
            ToolStripStatusLabel ToolStripStatusLabel;
            ToolStripComboBox ToolStripComboBoxObj;
            int blankChannelCount = 0;
            bool firstChannelComplete = false;
            Label commandLabel;

            stopProgrammingRequested = false;

            if (channelUpdateClicked[TabControl.SelectedIndex] == true)
            {
                displaySaveMessage();
            }
            channelUpdateClicked[TabControl.SelectedIndex] = false;

            if (openSerialPort() != true)
            {
                MessageBox.Show("Could not determine Arduino COM port.  Ensure USB cable is plugged in.");
                return;
            }

            if (TabControl.SelectedIndex == 0)
            {
                ProgressBarObj = Tab1ProgressBar1;
                ChannelListViewObj = Tab1ChannelListView;
                ToolStripStatusLabel = Tab1ToolStripStatusLabel;
                ToolStripComboBoxObj = Tab1KHzToolStripComboBox;
                commandLabel = Tab1UsbCmdLabel;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                ProgressBarObj = Tab2ProgressBar1;
                ChannelListViewObj = Tab2ChannelListView;
                ToolStripStatusLabel = Tab2ToolStripStatusLabel;
                ToolStripComboBoxObj = Tab2KHzToolStripComboBox;
                commandLabel = Tab2UsbCmdLabel;
            }
            else
            {
                ProgressBarObj = Tab3ProgressBar1;
                ChannelListViewObj = Tab3ChannelListView;
                ToolStripStatusLabel = Tab3ToolStripStatusLabel;
                ToolStripComboBoxObj = Tab3KHzToolStripComboBox;
                commandLabel = Tab3UsbCmdLabel;
            }

            repeaterAryIndex = 0;
            toneAryIndex = 7;
            ctcssAryIndex = 0;
            repeaterElements = 3;

            ToolStripStatusLabel.Text = "";

            string modLabel = TabControl.SelectedTab.Text;
            if (modLabel.EndsWith("440e") | modLabel.EndsWith("1200"))
            {
                repeaterElements = 4;
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
            if (My.MyProject.Forms.Form2.normalRadioTimingButton.Checked)
            {
                toneAndButtonOnTime = NORMAL_RADIO_TIMING;
            }
            else if (My.MyProject.Forms.Form2.slowRadioTimingButton.Checked)
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

            for (int channelIndex = 0, loopTo = ChannelListViewObj.Items.Count - 2; channelIndex <= loopTo; channelIndex++)
            {
                // change the color of the channel list item for visual programming progress
                ChannelListViewObj.EnsureVisible(channelIndex);
                ProgressBarObj.Value = channelIndex;
                ChannelListViewObj.Items[channelIndex].BackColor = Color.LightGreen;
                ChannelListViewObj.Update();

                if (ChannelListViewObj.Items[channelIndex].SubItems[1].Text == "BLANK" | string.IsNullOrEmpty(ChannelListViewObj.Items[channelIndex].SubItems[1].Text))
                {
                    blankChannelCount++;
                }
                else
                {
                    // send freq digits
                    string freq;
                    freq = ChannelListViewObj.Items[channelIndex].SubItems[1].Text;

                    int decimalPointLocation = freq.IndexOf(".");
                    if (decimalPointLocation == -1)
                    {
                        decimalPointLocation = freq.IndexOf(",");
                    }
                    string mhzVal = Convert.ToString(Strings.Mid(freq, 1, decimalPointLocation));
                    string kHzVal = Convert.ToString(Strings.Mid(freq, decimalPointLocation + 2));
                    int numOfKhzChars = 3;
                    if (Conversions.ToBoolean(Operators.OrObject(Convert.ToDouble(fixDecimalSeparator(Conversions.ToString(ToolStripComboBoxObj.SelectedItem))) == 12.5d, Operators.ConditionalCompareObjectEqual(ToolStripComboBoxObj.SelectedItem, 25, false))))
                    {
                        numOfKhzChars = 2;
                    }

                    SendString("A");

                    if (My.MyProject.Forms.Form2.wideBandCheckBox.Checked && TabControl.SelectedTab.Text.Contains("1200"))
                    {
                        SendString(Conversions.ToString(mhzVal[mhzVal.Length - 3]));
                    }

                    if (!TabControl.SelectedTab.Text.Contains("e") || TabControl.SelectedTab.Text.Contains("1200"))
                    {
                        SendString(Conversions.ToString(mhzVal[mhzVal.Length - 2]));
                    }
                    SendString(Conversions.ToString(mhzVal[mhzVal.Length - 1]));

                    int freqCharIndex = 0;
                    for (int loopVar = 0, loopTo1 = numOfKhzChars - 1; loopVar <= loopTo1; loopVar++)
                    {
                        SendString(Conversions.ToString(kHzVal[freqCharIndex]));
                        freqCharIndex++;
                    }

                    if (My.MyProject.Forms.Form2.AROcheckBox.Checked)
                    {
                        if (TabControl.SelectedIndex == 0 & My.MyProject.Forms.Form2.Mod1UT144.Checked | TabControl.SelectedIndex == 1 & My.MyProject.Forms.Form2.Mod2UT144.Checked | TabControl.SelectedIndex == 2 & My.MyProject.Forms.Form2.Mod3UT144.Checked)

                        {
                            if (!My.MyProject.Forms.Form2.eTypeRadioCheckBox.Checked)
                            {
                                if (Convert.ToDouble(fixDecimalSeparator(freq)) < 145.1d)
                                {
                                    getRepeaterIncrement("SIMPLEX");
                                }
                                else if (Convert.ToDouble(fixDecimalSeparator(freq)) < 145.5d)
                                {
                                    getRepeaterIncrement("MINUS");
                                }
                                else if (Convert.ToDouble(fixDecimalSeparator(freq)) < 146.0d)
                                {
                                    getRepeaterIncrement("SIMPLEX");
                                }
                                else if (Convert.ToDouble(fixDecimalSeparator(freq)) < 146.4d)
                                {
                                    getRepeaterIncrement("PLUS");
                                }
                                else if (Convert.ToDouble(fixDecimalSeparator(freq)) < 146.6d)
                                {
                                    getRepeaterIncrement("SIMPLEX");
                                }
                                else if (Convert.ToDouble(fixDecimalSeparator(freq)) < 147.0d)
                                {
                                    getRepeaterIncrement("MINUS");
                                }
                                else if (Convert.ToDouble(fixDecimalSeparator(freq)) < 147.4d)
                                {
                                    getRepeaterIncrement("PLUS");
                                }
                                else if (Convert.ToDouble(fixDecimalSeparator(freq)) < 147.6d)
                                {
                                    getRepeaterIncrement("SIMPLEX");
                                }
                                else if (Convert.ToDouble(fixDecimalSeparator(freq)) < 148.0d)
                                {
                                    getRepeaterIncrement("MINUS");
                                }
                                else
                                {
                                    getRepeaterIncrement("SIMPLEX");
                                }
                            }
                            else if (Convert.ToDouble(fixDecimalSeparator(freq)) < 145.6d)
                            {
                                getRepeaterIncrement("SIMPLEX");
                            }
                            else if (Convert.ToDouble(fixDecimalSeparator(freq)) < 145.8d)
                            {
                                getRepeaterIncrement("MINUS");
                            }
                            else
                            {
                                getRepeaterIncrement("SIMPLEX");
                            }
                        }
                        else if (TabControl.SelectedIndex == 0 & My.MyProject.Forms.Form2.Mod1UT220.Checked & !My.MyProject.Forms.Form2.eTypeRadioCheckBox.Checked | TabControl.SelectedIndex == 1 & My.MyProject.Forms.Form2.Mod2UT220.Checked & !My.MyProject.Forms.Form2.eTypeRadioCheckBox.Checked | TabControl.SelectedIndex == 2 & My.MyProject.Forms.Form2.Mod3UT220.Checked & !My.MyProject.Forms.Form2.eTypeRadioCheckBox.Checked)

                        {
                            if (Convert.ToDouble(fixDecimalSeparator(freq)) < 223.92d)
                            {
                                getRepeaterIncrement("SIMPLEX");
                            }
                            else if (Convert.ToDouble(fixDecimalSeparator(freq)) < 225.0d)
                            {
                                getRepeaterIncrement("MINUS");
                            }
                            else
                            {
                                getRepeaterIncrement("SIMPLEX");
                            }
                        }
                    }

                    int repeaterCount = getRepeaterIncrement(ChannelListViewObj.Items[channelIndex].SubItems[2].Text);
                    if (repeaterCount > 0)
                    {
                        for (int loopVar = 0, loopTo2 = repeaterCount - 1; loopVar <= loopTo2; loopVar++)
                            SendString("1");
                    }

                    // send ctcss mode
                    int ctcssCount = getCtcssIncrement(ChannelListViewObj.Items[channelIndex].SubItems[4].Text);
                    if (ctcssCount > 0)
                    {
                        for (int loopVar = 0, loopTo3 = ctcssCount - 1; loopVar <= loopTo3; loopVar++)
                            SendString("2");
                    }

                    // send tone increment/decrement
                    if (ChannelListViewObj.Items[channelIndex].SubItems[4].Text.ToUpper() != "OFF")
                    {
                        string direction = "";
                        int toneCount = getToneIncrement(ChannelListViewObj.Items[channelIndex].SubItems[3].Text, ref direction);
                        if (toneCount > 0)
                        {
                            SendString("D");
                            SendString("2");
                            for (int loopVar = 0, loopTo4 = toneCount - 1; loopVar <= loopTo4; loopVar++)
                                SendString(direction);
                            SendString("2");
                            SendString("PAUSE: ");
                        }
                    }

                    // send memory store and increment
                    SendString("D");
                    if (!firstChannelComplete)
                    {
                        for (int y = 0, loopTo5 = blankChannelCount - 1; y <= loopTo5; y++)
                            SendString("UP");
                        firstChannelComplete = true;
                    }
                    else
                    {
                        for (int y = 0, loopTo6 = blankChannelCount; y <= loopTo6; y++)
                            SendString("UP");
                    }
                    blankChannelCount = 0;
                    SendString("MR");
                    SendString("PAUSE: ");

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
            ToolStripStatusLabel.Text = "Programming complete.";
            commandLabel.Text = "";
            Tab1UsbRcvdLabel.Text = "";
            Tab2UsbRcvdLabel.Text = "";
            Tab3UsbRcvdLabel.Text = "";

        }
        private int _Timer1_Tick_cntr = 0;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ToolStripStatusLabel ToolStripStatusLabel;

            if (TabControl.SelectedIndex == 0)
            {
                ToolStripStatusLabel = Tab1ToolStripStatusLabel;
            }
            else
            {
                ToolStripStatusLabel = Tab2ToolStripStatusLabel;
            }

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

            _Timer1_Tick_cntr += 1;
        }

        private void KHzStepSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripComboBox KhzToolStripComboBoxObj;

            if (TabControl.SelectedIndex == 0)
            {
                KhzToolStripComboBoxObj = Tab1KHzToolStripComboBox;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                KhzToolStripComboBoxObj = Tab2KHzToolStripComboBox;
            }
            else
            {
                KhzToolStripComboBoxObj = Tab3KHzToolStripComboBox;
            }

            KhzToolStripComboBoxObj.DroppedDown = true;
        }


        private void Tab1KHzToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuStrip MenuStripObj;
            ToolStripComboBox ToolStripComboBoxObj;
            ToolStripLabel ToolStripLabelObj;
            ComboBox KHzComboBoxObj;

            if (TabControl.SelectedIndex == 0)
            {
                MenuStripObj = Tab1MenuStrip;
                ToolStripComboBoxObj = Tab1KHzToolStripComboBox;
                ToolStripLabelObj = Tab1ToolStripStepSize;
                KHzComboBoxObj = Tab1KHzCombBox;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                MenuStripObj = Tab2MenuStrip;
                ToolStripComboBoxObj = Tab2KHzToolStripComboBox;
                ToolStripLabelObj = Tab2ToolStripStepSize;
                KHzComboBoxObj = Tab2KHzCombBox;
            }
            else
            {
                MenuStripObj = Tab3MenuStrip;
                ToolStripComboBoxObj = Tab3KHzToolStripComboBox;
                ToolStripLabelObj = Tab3ToolStripStepSize;
                KHzComboBoxObj = Tab3KHzCombBox;
            }

            MenuStripObj.Items[0].Select();
            ToolStripLabelObj.Text = "kHz Step Size: " + ToolStripComboBoxObj.Text;

            KHzComboBoxObj.Items.Clear();
            double x = 0.0d;
            double KhzStepSize = Convert.ToDouble(fixDecimalSeparator(ToolStripComboBoxObj.Text));
            while (x < 1000d)
            {
                if (x < 10d)
                {
                    KHzComboBoxObj.Items.Add(string.Concat("00", Convert.ToString(x)));
                }
                else if (x < 100d)
                {
                    KHzComboBoxObj.Items.Add(string.Concat("0", Convert.ToString(x)));
                }
                else
                {
                    KHzComboBoxObj.Items.Add(Convert.ToString(x));
                }
                x += KhzStepSize;
            }

            var testXml = new XmlDocument();
            testXml.Load(My.MyProject.Forms.Form2.xmlFile);
            if (TabControl.SelectedIndex == 0)
            {
                if (!ToolStripComboBoxObj.Text.Equals(My.MyProject.Forms.Form2.getTab1StepSize()))
                {
                    testXml.SelectSingleNode("TM742/tab1StepSize").InnerText = Convert.ToString(ToolStripComboBoxObj.Text);
                }
            }
            else if (TabControl.SelectedIndex == 1)
            {
                if (!ToolStripComboBoxObj.Text.Equals(My.MyProject.Forms.Form2.getTab2StepSize()))
                {
                    testXml.SelectSingleNode("TM742/tab2StepSize").InnerText = Convert.ToString(ToolStripComboBoxObj.Text);
                }
            }
            else if (!ToolStripComboBoxObj.Text.Equals(My.MyProject.Forms.Form2.getTab3StepSize()))
            {
                testXml.SelectSingleNode("TM742/tab3StepSize").InnerText = Convert.ToString(ToolStripComboBoxObj.Text);
            }
            testXml.Save(My.MyProject.Forms.Form2.xmlFile);
        }

        private void Tab1BackToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComboBox MhzComboBoxObj;
            ListView channelListObj;

            if (TabControl.SelectedIndex == 0)
            {
                MhzComboBoxObj = Tab1MHzComboBox;
                channelListObj = Tab1ChannelListView;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                MhzComboBoxObj = Tab2MHzComboBox;
                channelListObj = Tab2ChannelListView;
            }
            else
            {
                MhzComboBoxObj = Tab3MHzComboBox;
                channelListObj = Tab3ChannelListView;
            }

            if (channelListObj.Items.Count > 1 & channelUpdateClicked[TabControl.SelectedIndex] == true)
            {
                displaySaveMessage();
            }

            channelUpdateClicked[TabControl.SelectedIndex] = false;

            MhzComboBoxObj.Text = "BLANK";
            Visible = false;
            // Form2.Visible = True
            My.MyProject.Forms.Form2.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ListView ChannelListViewObj;
            // Dim KhzToolStripComboBoxObj As ToolStripComboBox
            ToolStripLabel ToolStripStatusLabelObj;
            RadioButton CtssXmitToneObj;
            RadioButton CtcssXmitRecToneObj;


            if (TabControl.SelectedIndex == 0)
            {
                ChannelListViewObj = Tab1ChannelListView;
                // KhzToolStripComboBoxObj = Tab1KHzToolStripComboBox
                ToolStripStatusLabelObj = Tab1ToolStripStatusLabel;
                CtssXmitToneObj = Tab1CtcssXmit;
                CtcssXmitRecToneObj = Tab1CtcssXmitRec;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                ChannelListViewObj = Tab2ChannelListView;
                // KhzToolStripComboBoxObj = Tab2KHzToolStripComboBox
                ToolStripStatusLabelObj = Tab2ToolStripStatusLabel;
                CtssXmitToneObj = Tab2CtcssXmit;
                CtcssXmitRecToneObj = Tab2CtcssXmitRec;
            }
            else
            {
                ChannelListViewObj = Tab3ChannelListView;
                // KhzToolStripComboBoxObj = Tab3KHzToolStripComboBox
                ToolStripStatusLabelObj = Tab3ToolStripStatusLabel;
                CtssXmitToneObj = Tab3CtcssXmit;
                CtcssXmitRecToneObj = Tab3CtcssXmitRec;
            }

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
            ComboBox ToneObj;
            RadioButton CtcssXmitObj;
            RadioButton CtcssXmitRecObj;

            if (TabControl.SelectedIndex == 0)
            {
                ToneObj = Tab1ToneComboBox;
                CtcssXmitObj = Tab1CtcssXmit;
                CtcssXmitRecObj = Tab1CtcssXmitRec;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                ToneObj = Tab2ToneComboBox;
                CtcssXmitObj = Tab2CtcssXmit;
                CtcssXmitRecObj = Tab2CtcssXmitRec;
            }
            else
            {
                ToneObj = Tab3ToneComboBox;
                CtcssXmitObj = Tab3CtcssXmit;
                CtcssXmitRecObj = Tab3CtcssXmitRec;
            }

            if (CtcssXmitObj.Checked == false & CtcssXmitRecObj.Checked == false)
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
            ComboBox ToneObj;
            RadioButton CtcssXmitObj;
            RadioButton CtcssXmitRecObj;

            if (TabControl.SelectedIndex == 0)
            {
                ToneObj = Tab1ToneComboBox;
                CtcssXmitObj = Tab1CtcssXmit;
                CtcssXmitRecObj = Tab1CtcssXmitRec;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                ToneObj = Tab2ToneComboBox;
                CtcssXmitObj = Tab2CtcssXmit;
                CtcssXmitRecObj = Tab2CtcssXmitRec;
            }
            else
            {
                ToneObj = Tab3ToneComboBox;
                CtcssXmitObj = Tab3CtcssXmit;
                CtcssXmitRecObj = Tab3CtcssXmitRec;
            }

            if (ToneObj.SelectedIndex == 0)
            {
                CtcssXmitObj.Checked = false;
                CtcssXmitRecObj.Checked = false;
                ToneObj.Enabled = false;
            }
        }

        private void Tab1ToneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox ToneObj;
            RadioButton CtcssXmitObj;
            RadioButton CtcssXmitRecObj;
            RadioButton CtcssOffObj;

            if (TabControl.SelectedIndex == 0)
            {
                ToneObj = Tab1ToneComboBox;
                CtcssXmitObj = Tab1CtcssXmit;
                CtcssXmitRecObj = Tab1CtcssXmitRec;
                CtcssOffObj = Tab1CtcssOff;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                ToneObj = Tab2ToneComboBox;
                CtcssXmitObj = Tab2CtcssXmit;
                CtcssXmitRecObj = Tab2CtcssXmitRec;
                CtcssOffObj = Tab2CtcssOff;
            }
            else
            {
                ToneObj = Tab3ToneComboBox;
                CtcssXmitObj = Tab3CtcssXmit;
                CtcssXmitRecObj = Tab3CtcssXmitRec;
                CtcssOffObj = Tab3CtcssOff;
            }

            if (ToneObj.Text == "OFF")
            {
                CtcssXmitObj.Checked = false;
                CtcssXmitRecObj.Checked = false;
                CtcssOffObj.Checked = true;
                ToneObj.Enabled = false;
            }
        }

        private void Tab1SaveChannelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog1.AddExtension = true;
            SaveFileDialog1.DefaultExt = "csv";

            // If TabControl.SelectedIndex = 0 Then
            // If Not tab1ChannelFileName.Equals("") Then
            // SaveFileDialog1.FileName = tab1ChannelFileName.Text
            // End If
            // ElseIf TabControl.SelectedIndex = 1 Then
            // If Not tab2ChannelFileName.Equals("") Then
            // SaveFileDialog1.FileName = tab2ChannelFileName.Text
            // End If
            // ElseIf TabControl.SelectedIndex = 2 Then
            // If Not tab3ChannelFileName.Equals("") Then
            // SaveFileDialog1.FileName = tab3ChannelFileName.Text
            // End If
            // End If

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
                string newLine = channelListView.Items[index].SubItems[0].Text + ",";
                string mhzLcl = channelListView.Items[index].SubItems[1].Text;
                if (decimalSeparator == ",")
                {
                    mhzLcl = mhzLcl.Replace(",", ".");
                }
                newLine += mhzLcl + ",";
                newLine += channelListView.Items[index].SubItems[2].Text + ",";
                newLine += channelListView.Items[index].SubItems[3].Text + ",";
                newLine += channelListView.Items[index].SubItems[4].Text + ",";
                newLine += channelListView.Items[index].SubItems[5].Text;

                myWriter.WriteLine(newLine);
            }

            myWriter.Close();

            channelUpdateClicked[TabControl.SelectedIndex] = false;

        }

        private void Tab1OpenChannelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // If TabControl.SelectedIndex = 0 Then
            // If Not tab1ChannelFileName.Equals("") Then
            // OpenFileDialog1.FileName = tab1ChannelFileName.Text
            // End If
            // ElseIf TabControl.SelectedIndex = 1 Then
            // If Not tab2ChannelFileName.Equals("") Then
            // OpenFileDialog1.FileName = tab2ChannelFileName.Text
            // End If
            // ElseIf TabControl.SelectedIndex = 2 Then
            // If Not tab3ChannelFileName.Equals("") Then
            // OpenFileDialog1.FileName = tab3ChannelFileName.Text
            // End If
            // End If
            // OpenFileDialog1.ShowHelp = True
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
                    double testVal = Convert.ToDouble(fixDecimalSeparator(testAry[1]));
                    // Dim freqStr As String = testAry(1)
                    // Dim decimalPointLocation = freqStr.IndexOf(".")
                    // If decimalPointLocation = -1 Then
                    // decimalPointLocation = freqStr.IndexOf(",")
                    // End If
                    // Dim mhzVal As String = Convert.ToString(Mid(freqStr, 1, decimalPointLocation))
                    // Dim kHzVal As String = Convert.ToString(Mid(freqStr, decimalPointLocation + 2))
                    // Dim testVal As Double = Convert.ToDouble(mhzVal) + (Convert.ToDouble(kHzVal) * 0.001)
                    if (mhzComboBox.Items.Contains(Convert.ToString(Math.Truncate(testVal))) & (Math.Round(testVal * 10000d, 0) % 12.5d == 0d | Math.Round(testVal * 1000d, 0) % 5d == 0d))
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

                    if (!(My.MyProject.Forms.Form2.Tsu7CheckBox.Checked == false & testAry[4] == "Xmit/Rec"))
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

                if (newDataAvailable & recvdData.Contains("READY"))
                {
                    newDataAvailable = false;
                    return true;
                }
                else
                {
                    cntrLcl++;
                }
            }
            while (cntrLcl != 10);
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

            ComboBox MhzComboBox;
            ComboBox KhzComboBox;
            ComboBox RepeaterComboBox;

            if (TabControl.SelectedIndex == 0)
            {
                MhzComboBox = Tab1MHzComboBox;
                KhzComboBox = Tab1KHzCombBox;
                RepeaterComboBox = Tab1RepeaterComboBox;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                MhzComboBox = Tab2MHzComboBox;
                KhzComboBox = Tab2KHzCombBox;
                RepeaterComboBox = Tab2RepeaterComboBox;
            }
            else
            {
                MhzComboBox = Tab3MHzComboBox;
                KhzComboBox = Tab3KHzCombBox;
                RepeaterComboBox = Tab3RepeaterComboBox;
            }

            RepeaterComboBox.Text = getRepeaterVal(MhzComboBox.Text, KhzComboBox.Text, TabControl.SelectedIndex);

        }

        public string getRepeaterVal(string mHz, string kHz, int tabIndex)
        {
            string getRepeaterValRet;

            if (string.IsNullOrEmpty(mHz) | string.IsNullOrEmpty(kHz) | mHz == "BLANK")
            {
                return "SIMPLEX";
            }

            double frequency;
            frequency = Convert.ToDouble(fixDecimalSeparator(mHz)) + Convert.ToDouble(fixDecimalSeparator(kHz)) / 1000.0d;

            if (tabIndex == 0 & My.MyProject.Forms.Form2.Mod1UT144.Checked | tabIndex == 1 & My.MyProject.Forms.Form2.Mod2UT144.Checked | tabIndex == 2 & My.MyProject.Forms.Form2.Mod3UT144.Checked)

            {
                if (!My.MyProject.Forms.Form2.eTypeRadioCheckBox.Checked)
                {
                    if (frequency < 145.1d)
                    {
                        getRepeaterValRet = "SIMPLEX";
                    }
                    else if (frequency < 145.5d)
                    {
                        getRepeaterValRet = "MINUS";
                    }
                    else if (frequency < 146.0d)
                    {
                        getRepeaterValRet = "SIMPLEX";
                    }
                    else if (frequency < 146.4d)
                    {
                        getRepeaterValRet = "PLUS";
                    }
                    else if (frequency < 146.6d)
                    {
                        getRepeaterValRet = "SIMPLEX";
                    }
                    else if (frequency < 147.0d)
                    {
                        getRepeaterValRet = "MINUS";
                    }
                    else if (frequency < 147.4d)
                    {
                        getRepeaterValRet = "PLUS";
                    }
                    else if (frequency < 147.6d)
                    {
                        getRepeaterValRet = "SIMPLEX";
                    }
                    else if (frequency < 148.0d)
                    {
                        getRepeaterValRet = "MINUS";
                    }
                    else
                    {
                        getRepeaterValRet = "SIMPLEX";
                    }
                }
                else if (frequency < 145.6d)
                {
                    getRepeaterValRet = "SIMPLEX";
                }
                else if (frequency < 145.8d)
                {
                    getRepeaterValRet = "MINUS";
                }
                else
                {
                    getRepeaterValRet = "SIMPLEX";
                }
            }
            else if (tabIndex == 0 & My.MyProject.Forms.Form2.Mod1UT220.Checked & !My.MyProject.Forms.Form2.eTypeRadioCheckBox.Checked | tabIndex == 1 & My.MyProject.Forms.Form2.Mod2UT220.Checked & !My.MyProject.Forms.Form2.eTypeRadioCheckBox.Checked | tabIndex == 2 & My.MyProject.Forms.Form2.Mod3UT220.Checked & !My.MyProject.Forms.Form2.eTypeRadioCheckBox.Checked)

            {
                if (frequency < 223.92d)
                {
                    getRepeaterValRet = "SIMPLEX";
                }
                else if (frequency < 225.0d)
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

            if (TabControl.SelectedIndex == 0)
            {
                channelListObj = Tab1ChannelListView;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                channelListObj = Tab2ChannelListView;
            }
            else
            {
                channelListObj = Tab3ChannelListView;
            }
            SerialPort1.Close();

            if (channelListObj.Items.Count > 1 & channelUpdateClicked[TabControl.SelectedIndex] == true)
            {
                displaySaveMessage();
            }

            channelUpdateClicked[TabControl.SelectedIndex] = false;

            My.MyProject.Forms.Form2.Enabled = true;
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

        public bool displaySaveMessage()
        {
            ToolStripMenuItem saveFile;

            if (TabControl.SelectedIndex == 0)
            {
                saveFile = Tab1SaveChannelFileToolStripMenuItem;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                saveFile = Tab2SaveChannelFileToolStripMenuItem;
            }
            else
            {
                saveFile = Tab3SaveChannelFileToolStripMenuItem;
            }

            var msgResult = Interaction.MsgBox("Would you like to save changes to your Channel List file before continuing?", (MsgBoxStyle)((int)MsgBoxStyle.YesNo + (int)MsgBoxStyle.Critical + (int)MsgBoxStyle.DefaultButton2), "Save query message");
            if (msgResult == MsgBoxResult.Yes)
            {
                saveFile.PerformClick();
                // displaySaveMessage = False
            }

            return true;

            // Tab1SaveChannelFileToolStripMenuItem.PerformClick()

        }

        private void TabControl_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            ListView channelListObj;


            if (TabControl.SelectedIndex == 0)
            {
                channelListObj = Tab1ChannelListView;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                channelListObj = Tab2ChannelListView;
            }
            else
            {
                channelListObj = Tab3ChannelListView;
            }

            if (channelListObj.Items.Count > 1 & !My.MyProject.Forms.Form2.initializing & channelUpdateClicked[TabControl.SelectedIndex] == true)
            {
                if (displaySaveMessage() == false)
                {
                    e.Cancel = true;
                    return;
                }
            }

            channelUpdateClicked[TabControl.SelectedIndex] = false;
        }

        private void Tab1DeleteRowButton_Click(object sender, EventArgs e)
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

                if (channelIndex > 1 & channelIndex < numOfChannels)
                {
                    ChannelListViewObj.Items.RemoveAt(channelIndex - 1);

                    for (int x = 0, loopTo = numOfChannels - 2; x <= loopTo; x++)
                        ChannelListViewObj.Items[x].SubItems[0].Text = (x + 1).ToString();

                    ChannelListViewObj.Items[channelIndex - 1].Selected = true;
                    ChannelListViewObj.Select();

                    channelUpdateClicked[TabControl.SelectedIndex] = true;

                }
            }
            catch
            {
            }
        }

        public string fixDecimalSeparator(string inputStr)
        {
            string fixDecimalSeparatorRet = inputStr;
            if (decimalSeparator == ",")
            {
                fixDecimalSeparatorRet = inputStr.Replace(".", ",");
            }

            return fixDecimalSeparatorRet;
        }


        private void Tab2CtcssOff_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox ToneObj;
            RadioButton CtcssXmitObj;
            RadioButton CtcssXmitRecObj;
            RadioButton CtcssOffObj;

            if (TabControl.SelectedIndex == 0)
            {
                ToneObj = Tab1ToneComboBox;
                CtcssXmitObj = Tab1CtcssXmit;
                CtcssXmitRecObj = Tab1CtcssXmitRec;
                CtcssOffObj = Tab1CtcssOff;
            }
            else if (TabControl.SelectedIndex == 1)
            {
                ToneObj = Tab2ToneComboBox;
                CtcssXmitObj = Tab2CtcssXmit;
                CtcssXmitRecObj = Tab2CtcssXmitRec;
                CtcssOffObj = Tab2CtcssOff;
            }
            else
            {
                ToneObj = Tab3ToneComboBox;
                CtcssXmitObj = Tab3CtcssXmit;
                CtcssXmitRecObj = Tab3CtcssXmitRec;
                CtcssOffObj = Tab3CtcssOff;
            }

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