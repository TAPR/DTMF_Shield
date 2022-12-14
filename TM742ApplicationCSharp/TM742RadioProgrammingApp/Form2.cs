using System;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;

namespace Radio
{

    public partial class Form2
    {
       public struct radioConfigStruct
        {
            public int usbPort;
            public bool eType;
            public bool tsu7Installed;
            public bool wideBand;
            public bool ARO;
            public int timingMode;
            public string tab1Mod;
            public string tab1Filename;
            public string tab1StepSize;
            public string tab2Mod;
            public string tab2StepSize;
            public string tab2Filename;
            public string tab3Mod;
            public string tab3StepSize;
            public string tab3Filename;
        }

        public bool initializing = false;
        public bool[] tabHasChanged = new bool[3];
        public string[] tabFilename = new string[3];
        public radioConfigStruct radioConfig;
        public string applicationPath;
        public string xmlFile;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            applicationPath = Application.StartupPath;
            xmlFile = applicationPath;
            xmlFile = string.Concat(xmlFile, @"\Tm742Configuration.xml");

            ToolTip1.AutoPopDelay = 32000;
            ToolTip1.InitialDelay = 1000;
            ToolTip1.ReshowDelay = 500;
            ToolTip1.SetToolTip(GroupBox5, "These radio buttons control the DTMF tone and button press duration for programming" + Constants.vbCrLf + Strings.Chr(149) + "The normal selection uses an 80 millisecond duration" + Constants.vbCrLf + Strings.Chr(149) + "The slow selection uses a 250 millisecond duration" + Constants.vbCrLf + Strings.Chr(149) + "The debug selection uses a 1 second duration (this is slow enough that one can follow the actual commands being sent to the radio" + Constants.vbCrLf + "These selections are useful for different radio models/firmware.  If the normal (default) duration does not work properly, try the slow setting");

            Mod1None.Checked = true;
            Mod2None.Checked = true;
            Mod3None.Checked = true;

            for (int x = 0, loopTo = tabHasChanged.Length - 1; x <= loopTo; x++)
            {
                tabHasChanged[x] = false;
                tabFilename[x] = "";
            }

            var testXml = new XmlDocument();
            testXml.Load(xmlFile);
            radioConfig.usbPort = Convert.ToInt32(testXml.SelectSingleNode("TM742/usbPort").InnerText);
            radioConfig.eType = Convert.ToBoolean(testXml.SelectSingleNode("TM742/eType").InnerText);
            radioConfig.tsu7Installed = Convert.ToBoolean(testXml.SelectSingleNode("TM742/tsu7Installed").InnerText);
            radioConfig.wideBand = Convert.ToBoolean(testXml.SelectSingleNode("TM742/wideBand").InnerText);
            radioConfig.ARO = Convert.ToBoolean(testXml.SelectSingleNode("TM742/ARO").InnerText);
            // radioConfig.timingMode = Convert.ToBoolean(testXml.SelectSingleNode("TM742/timingMode").InnerText)
            radioConfig.tab1Mod = Convert.ToString(testXml.SelectSingleNode("TM742/tab1Mod").InnerText);
            radioConfig.tab1StepSize = Convert.ToString(testXml.SelectSingleNode("TM742/tab1StepSize").InnerText);
            radioConfig.tab1Filename = Convert.ToString(testXml.SelectSingleNode("TM742/tab1Filename").InnerText);
            radioConfig.tab2Mod = Convert.ToString(testXml.SelectSingleNode("TM742/tab2Mod").InnerText);
            radioConfig.tab2StepSize = Convert.ToString(testXml.SelectSingleNode("TM742/tab2StepSize").InnerText);
            radioConfig.tab2Filename = Convert.ToString(testXml.SelectSingleNode("TM742/tab2Filename").InnerText);
            radioConfig.tab3Mod = Convert.ToString(testXml.SelectSingleNode("TM742/tab3Mod").InnerText);
            radioConfig.tab3StepSize = Convert.ToString(testXml.SelectSingleNode("TM742/tab3StepSize").InnerText);
            radioConfig.tab3Filename = Convert.ToString(testXml.SelectSingleNode("TM742/tab3Filename").InnerText);

            if (radioConfig.eType == true)
            {
                eTypeRadioCheckBox.Checked = true;
            }
            if (radioConfig.tsu7Installed == true)
            {
                Tsu7CheckBox.Checked = true;
            }
            if (radioConfig.wideBand == true)
            {
                wideBandCheckBox.Checked = true;
            }
            if (radioConfig.ARO == true)
            {
                AROcheckBox.Checked = true;
            }
            if (radioConfig.timingMode == 0)
            {
                normalRadioTimingButton.Checked = true;
            }
            else if (radioConfig.timingMode == 1)
            {
                slowRadioTimingButton.Checked = true;
            }
            else
            {
                debugRadioTimingButton.Checked = true;
            }

            switch (radioConfig.tab1Mod ?? "")
            {
                case "Mod1UT30":
                    {
                        Mod1UT30.Checked = true;
                        break;
                    }
                case "Mod1UT50":
                    {
                        Mod1UT50.Checked = true;
                        break;
                    }
                case "Mod1UT144":
                case "Mod1UT144e":
                    {
                        Mod1UT144.Checked = true;
                        break;
                    }
                case "Mod1UT220":
                    {
                        Mod1UT220.Checked = true;
                        break;
                    }
                case "Mod1UT440":
                case "Mod1UT440e":
                    {
                        Mod1UT440.Checked = true;
                        break;
                    }
                case "Mod1UT1200":
                case "Mod1UT1200e":
                    {
                        Mod1UT1200.Checked = true;
                        break;
                    }

                default:
                    {
                        break;
                    }
                    // do nothing
            }

            switch (radioConfig.tab2Mod ?? "")
            {
                case "Mod2UT30":
                    {
                        Mod2UT30.Checked = true;
                        break;
                    }
                case "Mod2UT50":
                    {
                        Mod2UT50.Checked = true;
                        break;
                    }
                case "Mod2UT144":
                case "Mod2UT144e":
                    {
                        Mod2UT144.Checked = true;
                        break;
                    }
                case "Mod2UT220":
                    {
                        Mod2UT220.Checked = true;
                        break;
                    }
                case "Mod2UT440":
                case "Mod2UT440e":
                    {
                        Mod2UT440.Checked = true;
                        break;
                    }
                case "Mod2UT1200":
                case "Mod2UT1200e":
                    {
                        Mod2UT1200.Checked = true;
                        break;
                    }

                default:
                    {
                        break;
                    }
                    // do nothing
            }

            switch (radioConfig.tab3Mod ?? "")
            {
                case "Mod3UT30":
                    {
                        Mod3UT30.Checked = true;
                        break;
                    }
                case "Mod3UT50":
                    {
                        Mod3UT50.Checked = true;
                        break;
                    }
                case "Mod3UT144":
                case "Mod3UT144e":
                    {
                        Mod3UT144.Checked = true;
                        break;
                    }
                case "Mod3UT220":
                    {
                        Mod3UT220.Checked = true;
                        break;
                    }
                case "Mod3UT440":
                case "Mod3UT440e":
                    {
                        Mod3UT440.Checked = true;
                        break;
                    }
                case "Mod3UT1200":
                case "Mod3UT1200e":
                    {
                        Mod3UT1200.Checked = true;
                        break;
                    }

                default:
                    {
                        break;
                    }
                    // do nothing
            }
        }

        private void ChannelLists_Click(object sender, EventArgs e)
        {
            if (Mod1None.Checked == true & Mod2None.Checked == true & Mod3None.Checked == true)
            {
                Interaction.MsgBox("At least one module must be selected to continue.", MsgBoxStyle.Critical, "Module selection check");
                return;
            }

            // Me.Visible = False
            int y;

            initializing = true;

            y = 2;
            My.MyProject.Forms.Form1.TabControl.SelectedIndex = y;
            if (Mod3UT30.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod3UT30.Text;
            }
            else if (Mod3UT50.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod3UT50.Text;
            }
            else if (Mod3UT144.Checked & eTypeRadioCheckBox.Checked)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod1UT144.Text + "e";
            }
            else if (Mod3UT144.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod3UT144.Text;
            }
            else if (Mod3UT220.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod3UT220.Text;
            }
            else if (Mod3UT440.Checked & eTypeRadioCheckBox.Checked)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod3UT440.Text + "e";
            }
            else if (Mod3UT440.Checked)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod3UT440.Text;
            }
            else if (Mod3UT1200.Checked & eTypeRadioCheckBox.Checked)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod3UT1200.Text + "e";
            }
            else if (Mod3UT1200.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod3UT1200.Text;
            }
            if (Mod3None.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = "Mod3 Not Installed";
                My.MyProject.Forms.Form1.Panel20.Enabled = false;
                My.MyProject.Forms.Form1.Panel22.Enabled = false;
                My.MyProject.Forms.Form1.Panel23.Enabled = false;
            }
            else
            {
                My.MyProject.Forms.Form1.Panel20.Enabled = true;
                My.MyProject.Forms.Form1.Panel22.Enabled = true;
                My.MyProject.Forms.Form1.Panel23.Enabled = true;
            }

            if (!radioConfig.tab3Filename.Contains(My.MyProject.Forms.Form1.TabControl.SelectedTab.Text))
            {
                tabHasChanged[2] = true;
            }

            y = 1;
            My.MyProject.Forms.Form1.TabControl.SelectedIndex = y;
            if (Mod2UT30.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod2UT30.Text;
            }
            else if (Mod2UT50.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod2UT50.Text;
            }
            else if (Mod2UT144.Checked & eTypeRadioCheckBox.Checked)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod1UT144.Text + "e";
            }
            else if (Mod2UT144.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod2UT144.Text;
            }
            else if (Mod2UT220.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod2UT220.Text;
            }
            else if (Mod2UT440.Checked & eTypeRadioCheckBox.Checked)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod2UT440.Text + "e";
            }
            else if (Mod2UT440.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod2UT440.Text;
            }
            else if (Mod2UT1200.Checked & eTypeRadioCheckBox.Checked)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod2UT1200.Text + "e";
            }
            else if (Mod2UT1200.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod2UT1200.Text;
            }
            if (Mod2None.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = "Mod2 Not Installed";
                My.MyProject.Forms.Form1.Panel11.Enabled = false;
                My.MyProject.Forms.Form1.Panel12.Enabled = false;
                My.MyProject.Forms.Form1.Panel15.Enabled = false;
            }
            else
            {
                My.MyProject.Forms.Form1.Panel11.Enabled = true;
                My.MyProject.Forms.Form1.Panel12.Enabled = true;
                My.MyProject.Forms.Form1.Panel15.Enabled = true;
            }

            if (!radioConfig.tab2Filename.Contains(My.MyProject.Forms.Form1.TabControl.SelectedTab.Text))
            {
                tabHasChanged[1] = true;
            }

            y = 0;
            My.MyProject.Forms.Form1.TabControl.SelectedIndex = y;
            if (Mod1UT30.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod1UT30.Text;
            }
            else if (Mod1UT50.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod1UT50.Text;
            }
            else if (Mod1UT144.Checked & eTypeRadioCheckBox.Checked)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod1UT144.Text + "e";
            }
            else if (Mod1UT144.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod1UT144.Text;
            }
            else if (Mod1UT220.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod1UT220.Text;
            }
            else if (Mod1UT440.Checked & eTypeRadioCheckBox.Checked)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod1UT440.Text + "e";
            }
            else if (Mod1UT440.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod1UT440.Text;
            }
            else if (Mod1UT1200.Checked & eTypeRadioCheckBox.Checked)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod1UT1200.Text + "e";
            }
            else if (Mod1UT1200.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = Mod1UT1200.Text;
            }
            if (Mod1None.Checked == true)
            {
                My.MyProject.Forms.Form1.TabControl.SelectedTab.Text = "Mod1 Not Installed";
                My.MyProject.Forms.Form1.Panel1.Enabled = false;
                My.MyProject.Forms.Form1.Panel2.Enabled = false;
                My.MyProject.Forms.Form1.Panel3.Enabled = false;
            }
            else
            {
                My.MyProject.Forms.Form1.Panel1.Enabled = true;
                My.MyProject.Forms.Form1.Panel2.Enabled = true;
                My.MyProject.Forms.Form1.Panel3.Enabled = true;
            }

            if (!radioConfig.tab1Filename.Contains(My.MyProject.Forms.Form1.TabControl.SelectedTab.Text))
            {
                tabHasChanged[0] = true;
            }

            // Dim test As String
            // Dim MhzComboBoxObj As Object
            var startVal = default(int);
            var stopVal = default(int);
            bool addDoubleMinus = false;
            ComboBox repeaterComboBoxObj;
            string tabString;
            ComboBox mhzComboBoxObj;
            ListView listViewObj;
            RadioButton ctcssXmitRecObj;
            ListView channelListViewObj;

            for (int x = 0; x <= 2; x++)
            {

                if (x == 0)
                {
                    channelListViewObj = My.MyProject.Forms.Form1.Tab1ChannelListView;
                    ctcssXmitRecObj = My.MyProject.Forms.Form1.Tab1CtcssXmitRec;
                    listViewObj = My.MyProject.Forms.Form1.Tab1ChannelListView;
                    mhzComboBoxObj = My.MyProject.Forms.Form1.Tab1MHzComboBox;
                    repeaterComboBoxObj = My.MyProject.Forms.Form1.Tab1RepeaterComboBox;
                    My.MyProject.Forms.Form1.TabControl.SelectedIndex = x;
                    tabString = My.MyProject.Forms.Form1.TabControl.SelectedTab.Text;
                }
                else if (x == 1)
                {
                    channelListViewObj = My.MyProject.Forms.Form1.Tab2ChannelListView;
                    ctcssXmitRecObj = My.MyProject.Forms.Form1.Tab2CtcssXmitRec;
                    listViewObj = My.MyProject.Forms.Form1.Tab2ChannelListView;
                    mhzComboBoxObj = My.MyProject.Forms.Form1.Tab2MHzComboBox;
                    repeaterComboBoxObj = My.MyProject.Forms.Form1.Tab2RepeaterComboBox;
                    My.MyProject.Forms.Form1.TabControl.SelectedIndex = x;
                    tabString = My.MyProject.Forms.Form1.TabControl.SelectedTab.Text;
                }
                else
                {
                    channelListViewObj = My.MyProject.Forms.Form1.Tab3ChannelListView;
                    ctcssXmitRecObj = My.MyProject.Forms.Form1.Tab3CtcssXmitRec;
                    listViewObj = My.MyProject.Forms.Form1.Tab3ChannelListView;
                    mhzComboBoxObj = My.MyProject.Forms.Form1.Tab3MHzComboBox;
                    repeaterComboBoxObj = My.MyProject.Forms.Form1.Tab3RepeaterComboBox;
                    My.MyProject.Forms.Form1.TabControl.SelectedIndex = x;
                    tabString = My.MyProject.Forms.Form1.TabControl.SelectedTab.Text;
                }

                channelListViewObj.Items.Clear();

                repeaterComboBoxObj.Items.Clear();
                repeaterComboBoxObj.Items.Add("SIMPLEX");
                repeaterComboBoxObj.Items.Add("PLUS");
                repeaterComboBoxObj.Items.Add("MINUS");

                if (x == 0 & (Mod1UT440.Checked & eTypeRadioCheckBox.Checked | Mod1UT1200.Checked & !eTypeRadioCheckBox.Checked) | x == 1 & (Mod2UT440.Checked & eTypeRadioCheckBox.Checked | Mod2UT1200.Checked & !eTypeRadioCheckBox.Checked) | x == 2 & (Mod3UT440.Checked & eTypeRadioCheckBox.Checked | Mod3UT1200.Checked & !eTypeRadioCheckBox.Checked))
                {
                    repeaterComboBoxObj.Items.Add("DBL MINUS");
                }

                My.MyProject.Forms.Form1.TabControl.SelectedIndex = x;
                if ((My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod1UT30.Text ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod2UT30.Text ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod3UT30.Text ?? ""))
                {
                    startVal = 28;
                    stopVal = 29;
                }
                else if ((My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod1UT50.Text ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod2UT50.Text ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod3UT50.Text ?? ""))
                {
                    startVal = 50;
                    stopVal = 53;
                }
                else if ((My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod1UT144.Text ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod1UT144.Text + "e" ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod2UT144.Text ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod2UT144.Text + "e" ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod3UT144.Text ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod3UT144.Text + "e" ?? ""))
                {
                    startVal = 118;
                    stopVal = 174;
                }
                else if ((My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod1UT220.Text ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod2UT220.Text ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod3UT220.Text ?? ""))
                {
                    startVal = 220;
                    stopVal = 224;
                }
                else if ((My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod1UT440.Text ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod1UT440.Text + "e" ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod2UT440.Text ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod2UT440.Text + "e" ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod3UT440.Text ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod3UT440.Text + "e" ?? ""))
                {
                    startVal = 410;
                    stopVal = 470;
                }
                else if ((My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod1UT1200.Text ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod1UT1200.Text + "e" ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod2UT1200.Text ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod2UT1200.Text + "e" ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod3UT1200.Text ?? "") | (My.MyProject.Forms.Form1.TabControl.SelectedTab.Text ?? "") == (Mod3UT1200.Text + "e" ?? ""))
                {
                    startVal = 1240;
                    stopVal = 1299;
                    if (wideBandCheckBox.Checked)
                    {
                        startVal = 1100;
                        stopVal = 1399;
                    }
                }

                mhzComboBoxObj.Items.Clear();
                mhzComboBoxObj.Items.Add("BLANK");
                while (startVal <= stopVal)
                {
                    mhzComboBoxObj.Items.Add(Convert.ToString(startVal));
                    startVal += 1;
                }

                listViewObj.Text = "BLANK";
                if (Tsu7CheckBox.Checked)
                {
                    ctcssXmitRecObj.Visible = true;
                    ctcssXmitRecObj.Update();
                }
                else
                {
                    ctcssXmitRecObj.Visible = false;
                    ctcssXmitRecObj.Update();
                }
            }

            My.MyProject.Forms.Form1.initializeForm();
            My.MyProject.Forms.Form1.Visible = true;

            initializing = false;

            var testXml = new XmlDocument();
            testXml.Load(xmlFile);
            testXml.SelectSingleNode("TM742/eType").InnerText = Convert.ToString(eTypeRadioCheckBox.Checked);
            testXml.SelectSingleNode("TM742/tsu7Installed").InnerText = Convert.ToString(Tsu7CheckBox.Checked);
            testXml.SelectSingleNode("TM742/wideBand").InnerText = Convert.ToString(wideBandCheckBox.Checked);
            testXml.SelectSingleNode("TM742/ARO").InnerText = Convert.ToString(AROcheckBox.Checked);
            if (normalRadioTimingButton.Checked)
            {
                testXml.SelectSingleNode("TM742/timingMode").InnerText = Convert.ToString("0");
            }
            else if (slowRadioTimingButton.Checked)
            {
                testXml.SelectSingleNode("TM742/timingMode").InnerText = Convert.ToString("1");
            }
            else
            {
                testXml.SelectSingleNode("TM742/timingMode").InnerText = Convert.ToString("2");
            }

            My.MyProject.Forms.Form1.TabControl.SelectedIndex = 0;
            if (!My.MyProject.Forms.Form1.TabControl.SelectedTab.Text.Contains("Installed"))
            {
                string tmpStr = Strings.Mid(My.MyProject.Forms.Form1.TabControl.SelectedTab.Text, 4, My.MyProject.Forms.Form1.TabControl.SelectedTab.Text.Length);
                testXml.SelectSingleNode("TM742/tab1Mod").InnerText = "Mod1UT" + tmpStr;
            }
            else
            {
                testXml.SelectSingleNode("TM742/tab1Mod").InnerText = "NULL";
            }

            My.MyProject.Forms.Form1.TabControl.SelectedIndex = 1;
            if (!My.MyProject.Forms.Form1.TabControl.SelectedTab.Text.StartsWith("Installed"))
            {
                string tmpStr = Strings.Mid(My.MyProject.Forms.Form1.TabControl.SelectedTab.Text, 4, My.MyProject.Forms.Form1.TabControl.SelectedTab.Text.Length);
                testXml.SelectSingleNode("TM742/tab2Mod").InnerText = "Mod2UT" + tmpStr;
            }
            else
            {
                testXml.SelectSingleNode("TM742/tab2Mod").InnerText = "NULL";
            }

            My.MyProject.Forms.Form1.TabControl.SelectedIndex = 2;
            if (!My.MyProject.Forms.Form1.TabControl.SelectedTab.Text.StartsWith("Installed"))
            {
                string tmpStr = Strings.Mid(My.MyProject.Forms.Form1.TabControl.SelectedTab.Text, 4, My.MyProject.Forms.Form1.TabControl.SelectedTab.Text.Length);
                testXml.SelectSingleNode("TM742/tab3Mod").InnerText = "Mod3UT" + tmpStr;
            }
            else
            {
                testXml.SelectSingleNode("TM742/tab3Mod").InnerText = "NULL";
            }

            testXml.Save(xmlFile);

            My.MyProject.Forms.Form1.TabControl.SelectedIndex = 0;
            Enabled = false;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // just exit
        }

        private void eTypeRadioCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool ut220Checked = false;
            if (eTypeRadioCheckBox.Checked)
            {
                if (Mod1UT220.Checked)
                {
                    Mod1UT220.Checked = false;
                    Mod1None.Checked = true;
                    ut220Checked = true;
                }
                if (Mod2UT220.Checked)
                {
                    Mod2UT220.Checked = false;
                    Mod2None.Checked = true;
                    ut220Checked = true;
                }
                if (Mod3UT220.Checked)
                {
                    Mod3UT220.Checked = false;
                    Mod3None.Checked = true;
                    ut220Checked = true;
                }

                Mod1UT220.Enabled = false;
                Mod2UT220.Enabled = false;
                Mod3UT220.Enabled = false;

                if (ut220Checked == true)
                {
                    var msgResult = Interaction.MsgBox("UT220 module is not a valid selection with an 'E' type radio.");
                }
            }
            else
            {
                Mod1UT220.Enabled = true;
                Mod2UT220.Enabled = true;
                Mod3UT220.Enabled = true;
            }
        }
    }
}