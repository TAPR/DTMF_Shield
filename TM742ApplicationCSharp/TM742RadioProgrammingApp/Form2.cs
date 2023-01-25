using System;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;

namespace Radio
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable IDE1006
    public partial class Form2
    {
        public struct RadioConfigStruct
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
        public RadioConfigStruct radioConfig;
        public string applicationPath;
        public string xmlFile;
        private Form1 moduleForm = null;

        public Form2()
        {
            InitializeComponent();
        }

        public string getUsbPortName()
        {
            return String.Format("COM{0}", radioConfig.usbPort);
        }

        public int getUsbPortNumber()
        {
            return radioConfig.usbPort;
        }

        public string getTab1StepSize()
        {
            return radioConfig.tab1StepSize;
        }

        public string getTab2StepSize()
        {
            return radioConfig.tab2StepSize;
        }

        public string getTab3StepSize()
        {
            return radioConfig.tab3StepSize;
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

            loadConfigFile(xmlFile);
        }

        private void loadConfigFile(string xmlFile)
        {
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
            else if (radioConfig.timingMode == 2)
            {
                debugRadioTimingButton.Checked = true;
            }
            else
            {
                radioConfig.timingMode = 0;
                normalRadioTimingButton.Checked = true;
            }

            chooseModuleType(radioConfig.tab1Mod, Mod1None, Mod1UT30, Mod1UT50, Mod1UT144, Mod1UT220, Mod1UT440, Mod1UT1200);
            chooseModuleType(radioConfig.tab2Mod, Mod2None, Mod2UT30, Mod2UT50, Mod2UT144, Mod2UT220, Mod2UT440, Mod2UT1200);
            chooseModuleType(radioConfig.tab3Mod, Mod3None, Mod3UT30, Mod3UT50, Mod3UT144, Mod3UT220, Mod3UT440, Mod3UT1200);
        }

        private void chooseModuleType(string moduleType,
            RadioButton moduleNone, RadioButton moduleUT30, RadioButton moduleUT50, RadioButton moduleUT144, RadioButton moduleUT220, RadioButton moduleUT440, RadioButton moduleUT1200)
        {
            switch (moduleType ?? "")
            {
                case "UT30":
                    moduleUT30.Checked = true;
                    break;
                case "UT50":
                    moduleUT50.Checked = true;
                    break;
                case "UT144":
                case "UT144e":
                    moduleUT144.Checked = true;
                    break;
                case "UT220":
                    moduleUT220.Checked = true;
                    break;
                case "UT440":
                case "UT440e":
                    moduleUT440.Checked = true;
                    break;
                case "UT1200":
                case "UT1200e":
                    moduleUT1200.Checked = true;
                    break;

                default:
                    moduleNone.Checked = true;
                    break;
            }
        }

        private void getModuleName(string moduleNoneName, TabPage selectedTab,
            RadioButton moduleNone, RadioButton moduleUT30, RadioButton moduleUT50, RadioButton moduleUT144, RadioButton moduleUT220, RadioButton moduleUT440, RadioButton moduleUT1200)
        {
            if (moduleUT30.Checked == true)
            {
                selectedTab.Text = moduleUT30.Text;
            }
            else if (moduleUT50.Checked == true)
            {
                selectedTab.Text = moduleUT50.Text;
            }
           else if (moduleUT144.Checked == true)
            {
                selectedTab.Text = moduleUT144.Text;
                if (eTypeRadioCheckBox.Checked)
                    selectedTab.Text += "e";
            }
            else if (moduleUT220.Checked == true & !eTypeRadioCheckBox.Checked)
            {
                selectedTab.Text = moduleUT220.Text;
            }
            else if (moduleUT440.Checked)
            {
                selectedTab.Text = moduleUT440.Text;
                if (eTypeRadioCheckBox.Checked)
                    selectedTab.Text += "e";
            }
            else if (moduleUT1200.Checked == true)
            {
                selectedTab.Text = moduleUT1200.Text;
                if (eTypeRadioCheckBox.Checked)
                    selectedTab.Text += "e";
            }

            if (moduleNone.Checked == true)
            {
                selectedTab.Text = moduleNoneName;

                moduleForm.Panel20.Enabled = false;
                moduleForm.Panel22.Enabled = false;
                moduleForm.Panel23.Enabled = false;
            }
            else
            {
                moduleForm.Panel20.Enabled = true;
                moduleForm.Panel22.Enabled = true;
                moduleForm.Panel23.Enabled = true;
            }
        }

        private void initTabPage(int tabIndex, TabPage tabPage, ComboBox repeaterComboBoxObj, ComboBox mhzComboBoxObj, RadioButton ctcssXmitRecObj, ListView channelListViewObj,
            RadioButton moduleNone, RadioButton moduleUT30, RadioButton moduleUT50, RadioButton moduleUT144, RadioButton moduleUT220, RadioButton moduleUT440, RadioButton moduleUT1200)
        {
            moduleForm.TabControl.SelectedIndex = tabIndex;
            var startVal = default(int);
            var stopVal = default(int);

            channelListViewObj.Items.Clear();

            repeaterComboBoxObj.Items.Clear();
            repeaterComboBoxObj.Items.Add("SIMPLEX");
            repeaterComboBoxObj.Items.Add("PLUS");
            repeaterComboBoxObj.Items.Add("MINUS");

            // (430 band in European band plan) or (1200 band NOT in European band plan) has double-minus
            if ((moduleUT144.Checked && eTypeRadioCheckBox.Checked) || (moduleUT1200.Checked && !eTypeRadioCheckBox.Checked))               
            {
                repeaterComboBoxObj.Items.Add("DBL MINUS");
            }

            string moduleName = tabPage.Text;

            if ((moduleName ?? "") == (moduleUT30.Text ?? ""))
            {
                // UT30
                if (wideBandCheckBox.Checked)
                {
                    startVal = 18;
                    stopVal = 54;
                }
                else
                {
                    startVal = 28;
                    stopVal = 29;
                }
            }
            else if ((moduleName ?? "") == (moduleUT50.Text ?? ""))
            {
                // UT50
                if (wideBandCheckBox.Checked)
                {
                    startVal = 40;
                    stopVal = 90;
                }
                else
                {
                    startVal = 50;
                    stopVal = 53;
                }
            }
            else if ((moduleName ?? "") == (moduleUT144.Text ?? "") || (moduleName ?? "") == (moduleUT144.Text + "e" ?? ""))
            {
                // UT144, either euro-band-plan or not (with 'e' suffix...)
                if (wideBandCheckBox.Checked)
                {
                    startVal = 118;
                    stopVal = 174;
                }
                else if (moduleName.Contains("e"))
                {
                    startVal = 144;
                    stopVal = 146;
                }
                else
                {
                    startVal = 144;
                    stopVal = 148;
                }
            }
            else if ((moduleName ?? "") == (moduleUT220.Text ?? ""))
            {
                // UT220
                if (wideBandCheckBox.Checked)
                {
                    startVal = 215;
                    stopVal = 260;
                }
                else
                {
                    startVal = 220;
                    stopVal = 224;
                }
            }
            else if ((moduleName ?? "") == (moduleUT440.Text ?? "") || (moduleName ?? "") == (moduleUT440.Text + "e" ?? ""))
            {
                // UT440, either euro-band-plan or not (with 'e' suffix...)
                if (wideBandCheckBox.Checked)
                {
                    startVal = 410;
                    stopVal = 470;
                }
                else if (moduleName.Contains("e"))
                {
                    startVal = 430;
                    stopVal = 440;
                }
                else
                {
                    startVal = 430;
                    stopVal = 450;
                }
            }
            else if ((moduleName ?? "") == (moduleUT1200.Text ?? "") || (moduleName ?? "") == (moduleUT1200.Text + "e" ?? ""))
            {
                if (wideBandCheckBox.Checked)
                {
                    startVal = 1100;
                    stopVal = 1399;
                }
                else
                {
                    startVal = 1240;
                    stopVal = 1299;
                }
            }
            else if ((moduleName ?? "") == (moduleNone.Text ?? ""))
            {
                startVal = 0;
                stopVal = 0;
            }

            // populate MHz combo box
            mhzComboBoxObj.Items.Clear();
            mhzComboBoxObj.Items.Add("BLANK");
            while (startVal <= stopVal)
            {
                mhzComboBoxObj.Items.Add(Convert.ToString(startVal));
                startVal += 1;
            }

            channelListViewObj.Text = "BLANK";

            ctcssXmitRecObj.Visible = Tsu7CheckBox.Checked;
            ctcssXmitRecObj.Update();
        }

        private void ShowChannelLists_Click(object sender, EventArgs e)
        {
            moduleForm = new Form1(this);

            if (Mod1None.Checked == true & Mod2None.Checked == true & Mod3None.Checked == true)
            {
                Interaction.MsgBox("At least one module must be selected to continue.", MsgBoxStyle.Critical, "Module selection check");
                return;
            }

            // Me.Visible = False
            initializing = true;

            //select 3rd tab
            moduleForm.TabControl.SelectedIndex = 2;
            getModuleName("Mod3 Not Installed", moduleForm.TabPage3, Mod3None, Mod3UT30, Mod3UT50, Mod3UT144, Mod3UT220, Mod3UT440, Mod3UT1200);

            if (!radioConfig.tab3Filename.Contains(moduleForm.TabPage3.Text))
            {
                tabHasChanged[2] = true;
            }

            // select tab 2
            moduleForm.TabControl.SelectedIndex = 1;
            getModuleName("Mod2 Not Installed", moduleForm.TabPage2, Mod2None, Mod2UT30, Mod2UT50, Mod2UT144, Mod2UT220, Mod2UT440, Mod2UT1200);
            if (!radioConfig.tab2Filename.Contains(moduleForm.TabPage2.Text))
            {
                tabHasChanged[1] = true;
            }

            // select 1st tab (index 0)
            moduleForm.TabControl.SelectedIndex = 0;
            getModuleName("Mod1 Not Installed", moduleForm.TabPage1, Mod1None, Mod1UT30, Mod1UT50, Mod1UT144, Mod1UT220, Mod1UT440, Mod1UT1200);

            if (!radioConfig.tab1Filename.Contains(moduleForm.TabPage1.Text))
            {
                tabHasChanged[0] = true;
            }

            initTabPage(2, moduleForm.TabPage3, moduleForm.Tab3RepeaterComboBox, moduleForm.Tab3MHzComboBox, moduleForm.Tab3CtcssXmitRec, moduleForm.Tab3ChannelListView,
                Mod3None, Mod3UT30, Mod3UT50, Mod3UT144, Mod3UT220, Mod3UT440, Mod3UT1200);

            initTabPage(1, moduleForm.TabPage2, moduleForm.Tab2RepeaterComboBox, moduleForm.Tab2MHzComboBox, moduleForm.Tab2CtcssXmitRec, moduleForm.Tab2ChannelListView,
                Mod2None, Mod2UT30, Mod2UT50, Mod2UT144, Mod2UT220, Mod2UT440, Mod2UT1200);

            initTabPage(0, moduleForm.TabPage1, moduleForm.Tab1RepeaterComboBox, moduleForm.Tab1MHzComboBox, moduleForm.Tab1CtcssXmitRec, moduleForm.Tab1ChannelListView,
                Mod1None, Mod1UT30, Mod1UT50, Mod1UT144, Mod1UT220, Mod1UT440, Mod1UT1200);

           // end initialize all tab pages

            moduleForm.initializeForm();
            moduleForm.Visible = true;

            initializing = false;

            var firstInstalledModule = saveConfigFile(xmlFile);

            moduleForm.TabControl.SelectedIndex = firstInstalledModule < 0 ? 0 : firstInstalledModule;
            Enabled = false;
        }

        public int saveConfigFile(string xmlFile)
        { 
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

            var firstInstalledModuleIndex = -1;
            moduleForm.TabControl.SelectedIndex = 0;
            if (!moduleForm.TabControl.SelectedTab.Text.Contains("Not Installed"))
            {
                firstInstalledModuleIndex = 0;
                string tmpStr = Strings.Mid(moduleForm.TabControl.SelectedTab.Text, 4, moduleForm.TabControl.SelectedTab.Text.Length);
                testXml.SelectSingleNode("TM742/tab1Mod").InnerText = "UT" + tmpStr;
            }
            else
            {
                testXml.SelectSingleNode("TM742/tab1Mod").InnerText = "NULL";
            }

            moduleForm.TabControl.SelectedIndex = 1;
            if (!moduleForm.TabControl.SelectedTab.Text.StartsWith("Not Installed"))
            {
                if (firstInstalledModuleIndex == -1)
                {
                    firstInstalledModuleIndex = 1;
                }
                string tmpStr = Strings.Mid(moduleForm.TabControl.SelectedTab.Text, 4, moduleForm.TabControl.SelectedTab.Text.Length);
                testXml.SelectSingleNode("TM742/tab2Mod").InnerText = "UT" + tmpStr;
            }
            else
            {
                testXml.SelectSingleNode("TM742/tab2Mod").InnerText = "NULL";
            }

            moduleForm.TabControl.SelectedIndex = 2;
            if (!moduleForm.TabControl.SelectedTab.Text.StartsWith("Not Installed"))
            {
                if (firstInstalledModuleIndex == -1)
                {
                    firstInstalledModuleIndex = 2;
                }
                string tmpStr = Strings.Mid(moduleForm.TabControl.SelectedTab.Text, 4, moduleForm.TabControl.SelectedTab.Text.Length);
                testXml.SelectSingleNode("TM742/tab3Mod").InnerText = "UT" + tmpStr;
            }
            else
            {
                testXml.SelectSingleNode("TM742/tab3Mod").InnerText = "NULL";
            }

            testXml.Save(xmlFile);

            return firstInstalledModuleIndex;
       }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveConfigFile(xmlFile);
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
                    Interaction.MsgBox("UT220 module is not a valid selection with an 'E' type radio.");
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