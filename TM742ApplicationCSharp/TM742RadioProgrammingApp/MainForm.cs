using System;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;

namespace Radio
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable IDE1006
    public partial class MainForm
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
        public bool xmlConfigFileDirty = false;
        //private ChannelListsForm channelListsForm = null;

        public MainForm()
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

        private void MainForm_Load(object sender, EventArgs e)
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

        public void UpdateUSBComPort(int value)
        {
            updateSingleEntity(xmlFile, "TM742/usbPort", Convert.ToString(value));
            radioConfig.usbPort = value;
        }

        public void UpdateModuleStepSize(int moduleNumber, string value)
        {
            // tabs are numbered by their index, so 0, 1, and 2.  The modules are numbered using sequence, so 1, 2, and 3.
            updateSingleEntity(xmlFile, String.Format("TM742/Module{0}/StepSize", moduleNumber + 1), value);
            radioConfig.tab1StepSize = value;
        }

        public void UpdateModule1StepSize(string value)
        {
            updateSingleEntity(xmlFile, "TM742/Module1/StepSize", value);
            radioConfig.tab1StepSize = value;
        }

        public void UpdateModule2StepSize(string value)
        {
            updateSingleEntity(xmlFile, "TM742/Module2/StepSize", value);
            radioConfig.tab2StepSize = value;
        }

        public void UpdateModule3StepSize(string value)
        {
            updateSingleEntity(xmlFile, "TM742/Module3/StepSize", value);
            radioConfig.tab3StepSize = value;
        }

        private void loadConfigFile(string xmlFile)
        {
            module1SelectorControl.SetModuleType("None");
            module2SelectorControl.SetModuleType("None");
            module3SelectorControl.SetModuleType("None");


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

            radioConfig.tab1Mod = testXml.SelectSingleNode("TM742/Module1/Type").InnerText;
            radioConfig.tab1StepSize = testXml.SelectSingleNode("TM742/Module1/StepSize").InnerText;
            radioConfig.tab1Filename = testXml.SelectSingleNode("TM742/Module1/Filename").InnerText;
            radioConfig.tab2Mod = testXml.SelectSingleNode("TM742/Module2/Type").InnerText;
            radioConfig.tab2StepSize = testXml.SelectSingleNode("TM742/Module2/StepSize").InnerText;
            radioConfig.tab2Filename = testXml.SelectSingleNode("TM742/Module2/Filename").InnerText;
            radioConfig.tab3Mod = testXml.SelectSingleNode("TM742/Module3/Type").InnerText;
            radioConfig.tab3StepSize = testXml.SelectSingleNode("TM742/Module3/StepSize").InnerText;
            radioConfig.tab3Filename = testXml.SelectSingleNode("TM742/Module3/Filename").InnerText;

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

            chooseModuleType(radioConfig.tab1Mod, module1SelectorControl);
            chooseModuleType(radioConfig.tab2Mod, module2SelectorControl);
            chooseModuleType(radioConfig.tab3Mod, module3SelectorControl);
        }

        public void saveConfigFile(string xmlFile)
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

            testXml.Save(xmlFile);
            xmlConfigFileDirty = false;

            return;
        }

        private void chooseModuleType(string moduleType, ModuleSelectorControl moduleSelector)
        {
            switch (moduleType ?? "")
            {
                case "UT30":
                    moduleSelector.SetModuleType(moduleType);
                    break;
                case "UT50":
                    moduleSelector.SetModuleType(moduleType);
                    break;
                case "UT144":
                case "UT144e":
                    moduleSelector.SetModuleType(moduleType);
                    break;
                case "UT220":
                    if (moduleSelector.CanHaveUT220Module)
                    {
                        moduleSelector.SetModuleType(moduleType);
                    }
                    break;
                case "UT440":
                case "UT440e":
                    moduleSelector.SetModuleType(moduleType);
                    break;
                case "UT1200":
                case "UT1200e":
                    moduleSelector.SetModuleType(moduleType);
                    break;

                case "UT2400":
                    if (moduleSelector.CanHaveUT2400Module)
                    {
                        moduleSelector.SetModuleType(moduleType);
                    }
                    break;

                default:
                    moduleSelector.SetModuleType("None");
                    break;
            }
        }

        private string getModuleName(string moduleNoneName, TabPage selectedTab, ModuleSelectorControl moduleSelector)
        {
            var text = moduleSelector.GetModuleDisplayName();
            var name = moduleSelector.GetCurrentModuleName();
            if ((name == "UT144") || (name == "UT440") || (name == "UT1200"))
            {
                if (eTypeRadioCheckBox.Checked)
                    text += "e";
            }

            if (name == "None")
            {
                text = moduleNoneName;
            }
            else
            {
            }

            selectedTab.Text = text;
            return text;
        }

        private void initTabPage(TabPage tabPage, ComboBox repeaterComboBoxObj, ComboBox mhzComboBoxObj, RadioButton ctcssXmitRecObj,
            ListView channelListViewObj, ModuleSelectorControl moduleSelector)
        {
            var startVal = default(int);
            var stopVal = default(int);
            var currentModule = moduleSelector.GetCurrentModuleName();
//            var currentModuleDisplayName = moduleSelector.GetModuleDisplayName();

            channelListViewObj.Items.Clear();

            repeaterComboBoxObj.Items.Clear();
            if (checkBoxAllowOddOffset.Checked)
            {
                repeaterComboBoxObj.Items.Add("CUSTOM");
            }
            repeaterComboBoxObj.Items.Add("SIMPLEX");
            repeaterComboBoxObj.Items.Add("PLUS");
            repeaterComboBoxObj.Items.Add("MINUS");

            // (430 band in European band plan) or (1200 band NOT in European band plan) has double-minus
            if (((currentModule == "UT440") && eTypeRadioCheckBox.Checked) || ((currentModule == "UT1200") && !eTypeRadioCheckBox.Checked))               
            {
                repeaterComboBoxObj.Items.Add("DBL MINUS");
            }

            string moduleName = tabPage.Text;
            if (moduleName != "")
            {
                if (currentModule == "UT30")
                {
                    // UT30
                    if (wideBandCheckBox.Checked)
                    {
                        startVal = 26;
                        stopVal = 45;
                    }
                    else
                    {
                        startVal = 28;
                        stopVal = 29;
                    }
                }
                else if (currentModule == "UT50")
                {
                    // UT50
                    if (wideBandCheckBox.Checked)
                    {
                        startVal = 46;
                        stopVal = 76;
                    }
                    else
                    {
                        startVal = 50;
                        stopVal = 53;
                    }
                }
                else if (currentModule == "UT144")
                {
                    // UT144, either European-band-plan or not (with 'e' suffix...)
                    if (wideBandCheckBox.Checked)
                    {
                        startVal = 136;
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
                else if (currentModule == "UT220")
                {
                    // UT220
                    if (wideBandCheckBox.Checked)
                    {
                        startVal = 215;
                        stopVal = 235;
                    }
                    else
                    {
                        startVal = 220;
                        stopVal = 224;
                    }
                }
                else if (currentModule == "UT440")
                {
                    // UT440, either European-band-plan or not (with 'e' suffix...)
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
                else if (currentModule == "UT1200")
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
                else if (currentModule == "UT2400")
                {
                    if (wideBandCheckBox.Checked)
                    {
                        startVal = 2400;
                        stopVal = 2449;
                    }
                    else
                    {
                        startVal = 2400;
                        stopVal = 2449;
                    }
                }
                else if (currentModule == "None")
                {
                    startVal = 0;
                    stopVal = 0;
                }
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

        public void updateSingleEntity(string xmlFile, string nodeName, string value)
        {
            var testXml = new XmlDocument();
            testXml.Load(xmlFile);
            testXml.SelectSingleNode(nodeName).InnerText = value;
            testXml.Save(xmlFile);
        }

        private void ShowChannelLists_Click(object sender, EventArgs e)
        {
            ShowChannelLists();
        }
        
        private void ShowChannelLists()
        {
            var channelListsForm = new ChannelListsForm(this);

            if ((module1SelectorControl.GetCurrentModuleName() == "None") && (module2SelectorControl.GetCurrentModuleName() == "None") && (module3SelectorControl.GetCurrentModuleName() == "None"))
            {
                Interaction.MsgBox("At least one module must be selected to continue.", MsgBoxStyle.Critical, "Module selection check");
                return;
            }

            initializing = true;

            //initialize 3rd tab
            string installedModuleName = getModuleName("Mod3 Not Installed", channelListsForm.TabPage3, module3SelectorControl);

            if (!radioConfig.tab3Filename.Contains(channelListsForm.TabPage3.Text))
            {
                tabHasChanged[2] = true;

                if (!installedModuleName.Contains("Not Installed"))
                {
                    // the radio buttons like Mod1UT30 have for text: "UT 30".  So the band module type starts at position 4 of the string
                    string tmpStr = "UT" + Strings.Mid(installedModuleName, 4);
                    updateSingleEntity(xmlFile, "TM742/Module3/Type", tmpStr);
                }
                else
                {
                    updateSingleEntity(xmlFile, "TM742/Module3/Type", "NULL");
                }
            }

            // initialize tab 2
            installedModuleName = getModuleName("Mod2 Not Installed", channelListsForm.TabPage2, module2SelectorControl);
            if (!radioConfig.tab2Filename.Contains(channelListsForm.TabPage2.Text))
            {
                tabHasChanged[1] = true;

                if (!installedModuleName.Contains("Not Installed"))
                {
                    string tmpStr = "UT" + Strings.Mid(installedModuleName, 4);
                    updateSingleEntity(xmlFile, "TM742/Module2/Type", tmpStr);
                }
                else
                {
                    updateSingleEntity(xmlFile, "TM742/Module2/Type", "NULL");
                }
            }

            // initialize 1st tab (index 0)
            installedModuleName = getModuleName("Mod1 Not Installed", channelListsForm.TabPage1, module1SelectorControl);

            if (!radioConfig.tab1Filename.Contains(channelListsForm.TabPage1.Text))
            {
                tabHasChanged[0] = true;

                if (!installedModuleName.Contains("Not Installed"))
                {
                    string tmpStr = "UT" + Strings.Mid(installedModuleName, 4);
                    updateSingleEntity(xmlFile, "TM742/Module1/Type", tmpStr);
                }
                else
                {
                    updateSingleEntity(xmlFile, "TM742/Module1/Type", "NULL");
                }
            }

            initTabPage(channelListsForm.TabPage3, channelListsForm.Tab3RepeaterComboBox, channelListsForm.Tab3MHzComboBox, channelListsForm.Tab3CtcssXmitRec, channelListsForm.Tab3ChannelListView,
                module3SelectorControl);

            initTabPage(channelListsForm.TabPage2, channelListsForm.Tab2RepeaterComboBox, channelListsForm.Tab2MHzComboBox, channelListsForm.Tab2CtcssXmitRec, channelListsForm.Tab2ChannelListView,
                module2SelectorControl);

            initTabPage(channelListsForm.TabPage1, channelListsForm.Tab1RepeaterComboBox, channelListsForm.Tab1MHzComboBox, channelListsForm.Tab1CtcssXmitRec, channelListsForm.Tab1ChannelListView,
                module1SelectorControl);

            // end initialize all tab pages

            channelListsForm.initializeForm();
            channelListsForm.Visible = true;

            initializing = false;

            saveConfigFile(xmlFile);

            // should select the first module that is chosen as 'present'
            int firstModuleIndex = (module1SelectorControl.GetCurrentModuleName() != "None") ? 0 : (module2SelectorControl.GetCurrentModuleName() != "None") ? 1 : (module3SelectorControl.GetCurrentModuleName() != "None") ? 2 : 0;
            channelListsForm.TabControl.SelectedIndex = firstModuleIndex;

            Enabled = false;    // disable input on main form (and focus)
        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xmlConfigFileDirty)
            {
                saveConfigFile(xmlFile);
            }
        }

        private void eTypeRadioCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (eTypeRadioCheckBox.Checked)
            {
                var ut220_1 = module1SelectorControl.GetCurrentModuleName() == "UT220";
                module1SelectorControl.CanHaveUT220Module = false;
                var ut220_2 = module1SelectorControl.GetCurrentModuleName() == "UT220";
                module2SelectorControl.CanHaveUT220Module = false;
                var ut220_3 = module1SelectorControl.GetCurrentModuleName() == "UT220";
                module3SelectorControl.CanHaveUT220Module = false;


                if (ut220_1 || ut220_2 || ut220_3)
                {
                    Interaction.MsgBox("UT220 module is not a valid selection with an 'E' type radio.  It has been de-selected.");
                }
            }
            else
            {
                module1SelectorControl.CanHaveUT220Module = true;
                module2SelectorControl.CanHaveUT220Module = true;
                module3SelectorControl.CanHaveUT220Module = true;
            }

            xmlConfigFileDirty = true;
        }

        private void Tsu7CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            xmlConfigFileDirty = true;
        }

        private void wideBandCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            xmlConfigFileDirty = true;
        }

        private void AROcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            xmlConfigFileDirty = true;
        }

        private void normalRadioTimingButton_CheckedChanged(object sender, EventArgs e)
        {
            xmlConfigFileDirty = true;
        }

        private void slowRadioTimingButton_CheckedChanged(object sender, EventArgs e)
        {
            xmlConfigFileDirty = true;
        }

        private void debugRadioTimingButton_CheckedChanged(object sender, EventArgs e)
        {
            xmlConfigFileDirty = true;
        }

        private void checkBoxAllowOddOffset_CheckedChanged(object sender, EventArgs e)
        {
            // show message box with information on this feature.  Get confirmation from user.
            if (checkBoxAllowOddOffset.Checked)
            {
                MsgBoxResult result = Interaction.MsgBox("To use this, you need to have the latest DTMF_Shield sketch installed."
                    + Environment.NewLine + "AND have the CALL key on the microphone programmed to the 'MHz' button on the front panel."
                    + Environment.NewLine + "(this is covered on page 54 of the TM-742A/E User Manual.)"
                     + Environment.NewLine + "(You likely have to re-configure the CALL key if you do a full reset on your radio (MR pressed then power-on.)"
                   + Environment.NewLine + Environment.NewLine + "Do you affirm that your programmer and radio are properly set up?",
                    MsgBoxStyle.Critical | MsgBoxStyle.YesNo, "Custom/Odd/Non-standard Repeater Offset selection confirmation");

                if (result == MsgBoxResult.No)
                {
                    checkBoxAllowOddOffset.Checked = false;
                }
            }
        }
    }
}