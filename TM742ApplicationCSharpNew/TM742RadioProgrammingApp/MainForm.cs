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
        public bool initializing = false;

        public RadioConfig radioConfig;

        public string applicationPath;
        public string xmlFile;

        public bool xmlConfigFileDirty = false;

        public bool suppressChangeDetection = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            applicationPath = Application.StartupPath;
            xmlFile = applicationPath;
            xmlFile = string.Concat(xmlFile, @"\Tm742Configuration.xml");

            radioConfig = new RadioConfig(xmlFile);

            ToolTip1.AutoPopDelay = 32000;
            ToolTip1.InitialDelay = 1000;
            ToolTip1.ReshowDelay = 500;
            ToolTip1.SetToolTip(GroupBox5, "These radio buttons control the DTMF tone and button press duration for programming"
                + Constants.vbCrLf + Strings.Chr(149) + "The normal selection uses an 100 millisecond duration"
                + Constants.vbCrLf + Strings.Chr(149) + "The slow selection uses a 250 millisecond duration"
                + Constants.vbCrLf + Strings.Chr(149)
                + "The debug selection uses a 500 millisecond second duration (this is slow enough that one can follow the commands being sent to the radio)"
                + Constants.vbCrLf
                + "A 1 second duration would be too long, as it risks triggering various 'long press' actions, inadvertently."
                + Constants.vbCrLf
                + "These selections are useful for different radio models/firmware."
                + Constants.vbCrLf
                + "If the normal (default) duration does not work properly, try the slow setting");

            loadConfigFile();
        }

        private void loadConfigFile()
        {
            module1SelectorControl.SetModuleType("None");
            module2SelectorControl.SetModuleType("None");
            module3SelectorControl.SetModuleType("None");

            radioConfig.loadConfigFile();

            suppressChangeDetection = true;

            eTypeRadioCheckBox.Checked = radioConfig.EType;

            Tsu7CheckBox.Checked = radioConfig.Tsu7Installed;

            wideBandCheckBox.Checked = radioConfig.WideBand;

            AROcheckBox.Checked = radioConfig.ARO;

            if (radioConfig.TimingMode == 0)
            {
                normalRadioTimingButton.Checked = true;
            }
            else if (radioConfig.TimingMode == 1)
            {
                slowRadioTimingButton.Checked = true;
            }
            else if (radioConfig.TimingMode == 2)
            {
                debugRadioTimingButton.Checked = true;
            }
            else
            {
                radioConfig.TimingMode = 0;
                normalRadioTimingButton.Checked = true;
            }

            checkBoxAllowOddOffset.Checked = radioConfig.AllowCustomOffset;

            suppressChangeDetection = false;

            chooseModuleType(radioConfig.Tab1Mod, module1SelectorControl);
            chooseModuleType(radioConfig.Tab2Mod, module2SelectorControl);
            chooseModuleType(radioConfig.Tab3Mod, module3SelectorControl);
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

        private void ShowChannelLists_Click(object sender, EventArgs e)
        {
            ShowChannelLists();
        }       
      
        private void ShowChannelLists()
        {
            var channelListsForm = new ChannelListForm(this);

            if ((module1SelectorControl.GetCurrentModuleName() == "None") && (module2SelectorControl.GetCurrentModuleName() == "None") && (module3SelectorControl.GetCurrentModuleName() == "None"))
            {
                Interaction.MsgBox("At least one module must be selected to continue.", MsgBoxStyle.Critical, "Module selection check");
                return;
            }

            initializing = true;

            //initialize 3rd tab
            string installedModuleName = getModuleName("Mod3 Not Installed", channelListsForm.TabPage3, module3SelectorControl);

            if (!radioConfig.Tab3Filename.Contains(channelListsForm.TabPage3.Text))
            {
                string moduleType = !installedModuleName.Contains("Not Installed") ? "UT" + Strings.Mid(installedModuleName, 4) : "NULL";
                radioConfig.UpdateModule3Type(moduleType);
            }

            // initialize tab 2
            installedModuleName = getModuleName("Mod2 Not Installed", channelListsForm.TabPage2, module2SelectorControl);
            if (!radioConfig.Tab2Filename.Contains(channelListsForm.TabPage2.Text))
            {
                string moduleType = !installedModuleName.Contains("Not Installed") ? "UT" + Strings.Mid(installedModuleName, 4) : "NULL";
                radioConfig.UpdateModule2Type(moduleType);
            }

            // initialize 1st tab (index 0)
            installedModuleName = getModuleName("Mod1 Not Installed", channelListsForm.TabPage1, module1SelectorControl);

            if (!radioConfig.Tab1Filename.Contains(channelListsForm.TabPage1.Text))
            {
                string moduleType = !installedModuleName.Contains("Not Installed") ? "UT" + Strings.Mid(installedModuleName, 4) : "NULL";
                radioConfig.UpdateModule1Type(moduleType);
            }

            channelListsForm.initializeForm();

            channelListsForm.moduleLayoutPanelTab3.initTabPage(this, module3SelectorControl);

            channelListsForm.moduleLayoutPanelTab2.initTabPage(this, module2SelectorControl);

            channelListsForm.moduleLayoutPanelTab1.initTabPage(this, module1SelectorControl);

            // end initialize all tab pages

            channelListsForm.Visible = true;

            initializing = false;

            radioConfig.saveConfigFile();

            xmlConfigFileDirty = false;

            // should select the first module that is chosen as 'present'
            int firstModuleIndex = (module1SelectorControl.GetCurrentModuleName() != "None") ? 0 : (module2SelectorControl.GetCurrentModuleName() != "None") ? 1 : (module3SelectorControl.GetCurrentModuleName() != "None") ? 2 : 0;
            channelListsForm.TabControl.SelectedIndex = firstModuleIndex;

            Enabled = false;    // disable input on main form (and focus)
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xmlConfigFileDirty)
            {
                radioConfig.saveConfigFile();

                xmlConfigFileDirty = false;
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

            if (!suppressChangeDetection)
            {
                xmlConfigFileDirty = true;
                radioConfig.EType = eTypeRadioCheckBox.Checked;
            }
        }

        private void Tsu7CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!suppressChangeDetection)
            {
                xmlConfigFileDirty = true;
                radioConfig.Tsu7Installed = Tsu7CheckBox.Checked;
            }
        }

        private void wideBandCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!suppressChangeDetection)
            {
                xmlConfigFileDirty = true;
                radioConfig.WideBand = wideBandCheckBox.Checked;
            }
        }

        private void AROcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!suppressChangeDetection)
            {
                xmlConfigFileDirty = true;
                radioConfig.ARO = AROcheckBox.Checked;
            }
                radioConfig.ARO = AROcheckBox.Checked;
        }

        private void normalRadioTimingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!suppressChangeDetection)
            {
                xmlConfigFileDirty = true;
                radioConfig.TimingMode = 0;
            }
        }

        private void slowRadioTimingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!suppressChangeDetection)
            {
                xmlConfigFileDirty = true;
                radioConfig.TimingMode = 1;
            }
        }

        private void debugRadioTimingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!suppressChangeDetection)
            {
                xmlConfigFileDirty = true;
                radioConfig.TimingMode = 2;
            }
        }

        private void checkBoxAllowOddOffset_CheckedChanged(object sender, EventArgs e)
        {
            // show message box with information on this feature.  Get confirmation from user.
            if (!suppressChangeDetection && checkBoxAllowOddOffset.Checked)
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

            radioConfig.AllowCustomOffset = checkBoxAllowOddOffset.Checked;

            if (!suppressChangeDetection)
            {
                xmlConfigFileDirty = true;
            }
        }
    }
}