using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable IDE1006

    public partial class ModuleChannelList : UserControl
    {
        public ModuleChannelList()
        {
            InitializeComponent();
        }

        RadioConfig radioConfig;
        ChannelListForm channelListForm;
        UTModule utModule;

        private ChannelListManager channelListManager;

        int tabNumber;

        public ModuleSelectorControl moduleSelectorControl { get; set; }

        public bool channelUpdateClicked { get; set; }

        public bool UserSelectedChannel { get; set; }

        public void initializeTab(RadioConfig radioConfig, int tabNumber, ChannelListForm channelListForm, UTModule utModule, ModuleSelectorControl moduleSelectorControl, string stepSize)
        {
            this.tabNumber = tabNumber;     // 0, 1, or 2
            this.moduleSelectorControl = moduleSelectorControl;
            this.channelListForm = channelListForm;
            this.radioConfig = radioConfig;
            this.utModule = utModule;
            channelListManager = new(utModule, ChannelListView, radioConfig);

            KhzSpacingComboBox.Text = 5.ToString();

            channelListManager.clearList();

            UserSelectedChannel = false;

            if (!SetStepSize(stepSize))
            {
                KhzSpacingComboBox.Text = Convert.ToString(KhzSpacingComboBox.Items[0]);
                if (moduleSelectorControl.GetModuleDisplayName().Contains("144e"))
                {
                    KhzSpacingComboBox.Text = Convert.ToString(KhzSpacingComboBox.Items[1]);
                }
                else if (moduleSelectorControl.GetModuleDisplayName().Contains("144"))
                {
                    KhzSpacingComboBox.Text = Convert.ToString(KhzSpacingComboBox.Items[2]);
                }
                else if (moduleSelectorControl.GetModuleDisplayName().Contains("440"))
                {
                    KhzSpacingComboBox.Text = Convert.ToString(KhzSpacingComboBox.Items[1]);
                }
                else if (moduleSelectorControl.GetModuleDisplayName().Contains("1200") || moduleSelectorControl.GetModuleDisplayName().Contains("2400"))
                {
                    KhzSpacingComboBox.Text = Convert.ToString(KhzSpacingComboBox.Items[3]);
                }
            }

            CtcssOffRadioButton.Checked = true;

            ToneComboBox.Text = "OFF";
            ToneComboBox.Enabled = false;

            MHzComboBox.Text = Convert.ToString(MHzComboBox.Items[0]);

            ChannelListView.Items[0].SubItems[1].Text = Convert.ToString(MHzComboBox.Items[0]);
        }

        public bool SetStepSize(string stepSizeStr)
        {
            // this is missing 20 and 15 KHz.  It is a list that is hardCoded into the ComboBox
            if (stepSizeStr.Equals("10"))
            {
                KhzSpacingComboBox.SelectedIndex = 0;
            }
            else if (stepSizeStr.Equals("12.5"))
            {
                KhzSpacingComboBox.SelectedIndex = 1;
            }
            else if (stepSizeStr.Equals("5"))
            {
                KhzSpacingComboBox.SelectedIndex = 2;
            }
            else if (stepSizeStr.Equals("25"))
            {
                KhzSpacingComboBox.SelectedIndex = 3;
            }
            else if (stepSizeStr.Equals("20"))
            {
                KhzSpacingComboBox.SelectedIndex = 4;
            }
            else if (stepSizeStr.Equals("15"))
            {
                KhzSpacingComboBox.SelectedIndex = 5;
            }
            else
            {
                return false;
            }

            return true;
        }

        private void SetChannelButton_Click(object sender, EventArgs e)
        {
            SetChannel();
        }

        private void SetChannel()
        {
            channelUpdateClicked = true;

            if (!(MHzComboBox.Text == "BLANK"))
            {
                if (!MHzComboBox.Items.Contains(MHzComboBox.Text))
                {
                    Interaction.MsgBox("MHz selected is not a valid choice.", MsgBoxStyle.Critical, "Set Channel Error Message");
                    return;
                }

                if (!(Convert.ToDecimal(KHzComboBox.Text, System.Globalization.CultureInfo.InvariantCulture) * 10000m % 12.5m == 0m
                    || Convert.ToDecimal(KHzComboBox.Text, System.Globalization.CultureInfo.InvariantCulture) * 10000m % 5m == 0m))
                {
                    Interaction.MsgBox("KHz selected is not a valid choice.", MsgBoxStyle.Critical, "Set Channel Error Message");
                    return;
                }

                if (!RepeaterModeComboBox.Items.Contains(RepeaterModeComboBox.Text))
                {
                    Interaction.MsgBox("Repeater value selected is not a valid choice.", MsgBoxStyle.Critical, "Set Channel Error Message");
                    return;
                }

                if (!ToneComboBox.Items.Contains(ToneComboBox.Text))
                {
                    Interaction.MsgBox("Tone frequency selected is not a valid choice.", MsgBoxStyle.Critical, "Set Channel Error Message");
                    return;
                }
            }

            int selectedIndex = ChannelListView.SelectedItems[0].Index;
            ChannelListView.Items[selectedIndex].SubItems[1].Text = MHzComboBox.Text;

            if (!MHzComboBox.Text.Equals("BLANK"))
            {
                decimal khz = Convert.ToDecimal(KHzComboBox.Text, System.Globalization.CultureInfo.InvariantCulture);
                decimal test = Convert.ToDecimal(MHzComboBox.Text, System.Globalization.CultureInfo.InvariantCulture)
                    + (khz * 0.001m);
                var freqString = string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:F4}", test);
                ChannelListView.Items[selectedIndex].SubItems[1].Text = freqString;
                ChannelListView.Items[selectedIndex].SubItems[2].Text = RepeaterModeComboBox.Text;
                ChannelListView.Items[selectedIndex].SubItems[3].Text = ToneComboBox.Text;
                if (CtcssXmitRadioButton.Checked)
                {
                    ChannelListView.Items[selectedIndex].SubItems[4].Text = CtcssXmitRadioButton.Text;
                }
                else if (CtcssXmitRecRadioButton.Checked == true)
                {
                    ChannelListView.Items[selectedIndex].SubItems[4].Text = CtcssXmitRecRadioButton.Text;
                }
                else
                {
                    ChannelListView.Items[selectedIndex].SubItems[4].Text = "OFF";
                }
            }
            else
            {
                ChannelListView.Items[selectedIndex].SubItems[2].Text = "";
                ChannelListView.Items[selectedIndex].SubItems[3].Text = "";
                ChannelListView.Items[selectedIndex].SubItems[4].Text = "";
            }

            ChannelListView.Items[selectedIndex].SubItems[5].Text =
                Convert.ToString(numericUpDownCustomOffsetMHz.Value, System.Globalization.CultureInfo.InvariantCulture);
            ChannelListView.Items[selectedIndex].SubItems[6].Text = ChannelNotes.Text.Trim();

            if (selectedIndex == ChannelListView.Items.Count - 1)
            {
                ChannelListView.Items[selectedIndex].Selected = false;
                selectedIndex += 1;
                ChannelListView.Items.Add(selectedIndex.ToString());

                channelListManager.setBlankRow(selectedIndex, (selectedIndex + 1).ToString());

                ChannelListView.Items[selectedIndex].Selected = true;
                ChannelListView.Items[selectedIndex].Checked = true;

                ChannelListView.Items[selectedIndex].EnsureVisible();
                ChannelListView.Items[selectedIndex].Selected = true;
                ChannelListView.Select();
                UserSelectedChannel = false;

                if (ChannelListView.Items.Count > 101)
                {
                    Interaction.MsgBox("The number of channels in the list has exceeded 100.  Unexpected results may occur if the radio does not support this feature", MsgBoxStyle.Information, "Channel count warning message");
                }
            }
        }

        public string getRepeaterVal(string mHz, string kHz)
        {
            bool moduleIsUT144 = moduleSelectorControl.GetCurrentModuleName() == "UT144";
            bool moduleIsUT220 = moduleSelectorControl.GetCurrentModuleName() == "UT220";
            string getRepeaterValRet;

            if (string.IsNullOrEmpty(mHz) | string.IsNullOrEmpty(kHz) | mHz == "BLANK")
            {
                return "SIMPLEX";
            }

            decimal frequency = Convert.ToDecimal(mHz, System.Globalization.CultureInfo.InvariantCulture)
                + Convert.ToDecimal(kHz, System.Globalization.CultureInfo.InvariantCulture) / 1000.0m;

            if (moduleIsUT144)
            {
                if (!radioConfig.EType)
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
            else if (moduleIsUT220 && !radioConfig.EType)
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

        private void MHzComboBox_SelectedIndexChanged()
        {
            if (ChannelListView.SelectedItems.Count > 0)
            {
                if (UserSelectedChannel == false || ChannelListView.SelectedItems[0].Index == ChannelListView.Items.Count - 1)
                {
                    if (MHzComboBox.Text != "BLANK" && !string.IsNullOrEmpty(MHzComboBox.Text))
                    {
                        RepeaterModeComboBox.Text = "SIMPLEX";
                        if (CtcssOffRadioButton.Checked)
                        {
                            ToneComboBox.Text = "OFF";
                        }
                        else
                        {
                            ToneComboBox.Text = "88.5";  // this text always has a period for decimal separator
                        }

                        // the user chose an MHz value.  Cause the KHz combo box to drop down to make a choice
                        KHzComboBox.DroppedDown = true;
                    }
                }
            }

            RepeaterModeComboBox.Text = getRepeaterVal(MHzComboBox.Text, KHzComboBox.Text);

            if (MHzComboBox.Text == "BLANK" || string.IsNullOrEmpty(MHzComboBox.Text))
            {
                RepeaterModeComboBox.Text = "";
                ToneComboBox.Text = "OFF";
                KHzComboBox.Text = "";
                CtcssOffRadioButton.Checked = true;
            }
        }

        public void LoadChannelList(string fileName)
        {
            channelListManager.LoadChannelList(fileName);

            channelUpdateClicked = false;
        }

        public void LoadChannelListXml(string fileName)
        {
            channelListManager.LoadChannelListXml(fileName);

            channelUpdateClicked = false;
        }

        public void SaveChannelListXml(string fileName)
        {
            channelListManager.SaveChannelListXml(fileName);

            channelUpdateClicked = false;
        }

        public void initTabPage(RadioConfig radioConfig, ModuleSelectorControl moduleSelector)
        {
            this.radioConfig = radioConfig;

            var currentModule = moduleSelector.GetCurrentModuleName();

            RepeaterModeComboBox.Items.Clear();
            if (radioConfig.AllowCustomOffset)
            {
                RepeaterModeComboBox.Items.Add("CUSTOM");
            }
            RepeaterModeComboBox.Items.Add("SIMPLEX");
            RepeaterModeComboBox.Items.Add("PLUS");
            RepeaterModeComboBox.Items.Add("MINUS");

            // (430 band in European band plan) or (1200 band NOT in European band plan) has double-minus
            if (((currentModule == "UT440") && radioConfig.EType) || ((currentModule == "UT1200") && !radioConfig.EType))
            {
                RepeaterModeComboBox.Items.Add("DBL MINUS");
            }

            var startVal = Convert.ToInt32(utModule.txMinFrequencyMHz);
            var stopVal = Convert.ToInt32(Math.Truncate(utModule.txMaxFrequencyMHz));

            // populate MHz combo box
            MHzComboBox.Items.Clear();
            MHzComboBox.Items.Add("BLANK");
            while (startVal <= stopVal)
            {
                MHzComboBox.Items.Add(Convert.ToString(startVal));
                startVal += 1;
            }

            ChannelListView.Text = "BLANK";

            CtcssXmitRecRadioButton.Visible = radioConfig.Tsu7Installed;
            CtcssXmitRecRadioButton.Update();
        }

        private void ChannelListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChannelListView_SelectedIndexChanged();
        }

        private void ChannelListView_SelectedIndexChanged()
        {
            if (ChannelListView.SelectedItems.Count > 0)
            {
                UserSelectedChannel = true;
                ChannelTextBox.Text = ChannelListView.SelectedItems[0].Text;

                if (!string.IsNullOrEmpty(ChannelListView.SelectedItems[0].SubItems[1].Text) && (ChannelListView.SelectedItems[0].SubItems[1].Text != "BLANK"))
                {
                    decimal frequency = Convert.ToDecimal(ChannelListView.SelectedItems[0].SubItems[1].Text, System.Globalization.CultureInfo.InvariantCulture);
                    MHzComboBox.Text = Convert.ToInt32(frequency - frequency % 1m).ToString();
                    decimal kHzVal = Convert.ToDecimal(Math.Round(frequency % 1m * 1000m, 1));
                    string kHzString = Convert.ToString(kHzVal, System.Globalization.CultureInfo.InvariantCulture);
                    if (kHzVal < 10.0m)
                    {
                        kHzString = "00" + kHzString;
                    }
                    else if (kHzVal < 100.0m)
                    {
                        kHzString = "0" + kHzString;
                    }
                    KHzComboBox.Text = kHzString; // Convert.ToInt32((frequency Mod 1) * 1000)
                    RepeaterModeComboBox.Text = ChannelListView.SelectedItems[0].SubItems[2].Text;
                    ToneComboBox.Text = ChannelListView.SelectedItems[0].SubItems[3].Text;
                    if (ChannelListView.SelectedItems[0].SubItems[3].Text == "OFF")
                    {
                        CtcssOffRadioButton.Checked = true;
                        ToneComboBox.Enabled = false;
                    }
                    else if (ChannelListView.SelectedItems[0].SubItems[4].Text == "Xmit")
                    {
                        CtcssXmitRadioButton.Checked = true;
                        ToneComboBox.Enabled = true;
                    }
                    else if (ChannelListView.SelectedItems[0].SubItems[4].Text == "Xmit/Rec")
                    {
                        CtcssXmitRadioButton.Checked = true;
                        ToneComboBox.Enabled = true;
                    }

                    var offset = ChannelListView.SelectedItems[0].SubItems[5].Text;
                    if (offset == "")
                    {
                        offset = "0";
                    }
                    numericUpDownCustomOffsetMHz.Value = Convert.ToDecimal(offset, System.Globalization.CultureInfo.InvariantCulture);
                }
                else if (ChannelListView.SelectedItems[0].SubItems[1].Text == "BLANK")
                {
                    MHzComboBox.Text = "BLANK";
                    KHzComboBox.Text = "";
                    RepeaterModeComboBox.Text = "";
                    ToneComboBox.Text = "OFF";
                    CtcssOffRadioButton.Checked = true;
                    ToneComboBox.Enabled = false;
                    numericUpDownCustomOffsetMHz.Value = 0;

                }
                ChannelNotes.Text = ChannelListView.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void KhzSpacingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillKHzComboBox(KhzSpacingComboBox, KHzComboBox);

            if (!KhzSpacingComboBox.Text.Equals(radioConfig.getTab1StepSize()))
            {
                radioConfig.UpdateModuleStepSize(tabNumber, KhzSpacingComboBox.Text);
            }
        }

        private void FillKHzComboBox(ComboBox ToolStripComboBoxObj, ComboBox KHzComboBoxObj)
        {
            KHzComboBoxObj.Items.Clear();
            decimal KhzStepSize = Convert.ToDecimal(ToolStripComboBoxObj.Text, System.Globalization.CultureInfo.InvariantCulture);
            for (decimal kHzVal = 0.0m; kHzVal < 1000m; kHzVal += KhzStepSize)
            {
                var kHzString = Convert.ToString(kHzVal, System.Globalization.CultureInfo.InvariantCulture);
                if (kHzVal < 10.0m)
                {
                    kHzString = "00" + kHzString;
                }
                else if (kHzVal < 100.0m)
                {
                    kHzString = "0" + kHzString;
                }

                KHzComboBoxObj.Items.Add(kHzString);
            }
        }

        private bool displaySaveMessage()
        {
            var msgResult = Interaction.MsgBox("Would you like to save changes to your Channel List file before continuing?",
                (MsgBoxStyle)((int)MsgBoxStyle.YesNo + (int)MsgBoxStyle.Critical + (int)MsgBoxStyle.DefaultButton2),
                "Save query message");
            if (msgResult == MsgBoxResult.Yes)
            {
                channelListForm.SaveChannelFileDialog();
            }

            return true;
        }

        public void saveTabOnLeavingIfDirty(TabControlCancelEventArgs e)
        {
            if (ChannelListView.Items.Count > 1 && (channelUpdateClicked == true))
            {
                if (displaySaveMessage() == false)
                {
                    e.Cancel = true;
                    return;
                }
            }

            channelUpdateClicked = false;
        }

        public void saveTabOnLeavingIfDirty()
        {
            if (ChannelListView.Items.Count > 1 && (channelUpdateClicked == true))
            {
                if (displaySaveMessage() == false)
                {
                    return;
                }
            }

            channelUpdateClicked = false;
        }

        private void CtcssXmit_CheckedChanged(object sender, EventArgs e)
        {
            if (CtcssXmitRadioButton.Checked == true)
            {
                ToneComboBox.Enabled = true;
                ToneComboBox.DroppedDown = true;
            }
        }

        private void CtcssXmitRec_CheckedChanged(object sender, EventArgs e)
        {
            if (CtcssXmitRecRadioButton.Checked == true)
            {
                ToneComboBox.Enabled = true;
                ToneComboBox.DroppedDown = true;
            }
        }

        private void CtcssOffRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CtcssOffRadioButton.Checked)
            {
                CtcssXmitRadioButton.Checked = false;
                CtcssXmitRecRadioButton.Checked = false;
                ToneComboBox.Text = "OFF";
                ToneComboBox.Enabled = false;
            }
        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            channelUpdateClicked = channelListManager.DeleteRow();
        }

        private void InsertRowButton_Click(object sender, EventArgs e)
        {
            channelUpdateClicked = channelListManager.InsertBlankRow();
        }

        private void ToneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ToneComboBox.Text == "OFF")
            {
                CtcssXmitRadioButton.Checked = false;
                CtcssXmitRecRadioButton.Checked = false;
                CtcssOffRadioButton.Checked = true;
                ToneComboBox.Enabled = false;
            }
        }

        private void KHzCombBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RepeaterModeComboBox.Text = getRepeaterVal(MHzComboBox.Text, KHzComboBox.Text);
        }

        private void MHzComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MHzComboBox_SelectedIndexChanged();
        }

        private void clearChannelList()
        {
            int response = (int)Interaction.MsgBox("Are you sure you want to clear the channel list?", MsgBoxStyle.YesNo, "Channel list clear verification");
            if (response == (int)Constants.vbYes)
            {
                channelListManager.clearList();

                CtcssOffRadioButton.Checked = true;
                UserSelectedChannel = false;

                channelListForm.ToolStripStatusLabel.Text = "";
            }
        }

        private void ClearChannelListButton_Click(object sender, EventArgs e)
        {
            clearChannelList();
        }
    }
}
