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

    public partial class ModuleSelectorControl : UserControl
    {

        private readonly List<string> moduleNames = new() { "None", "UT30", "UT50", "UT144", "UT220", "UT440", "UT1200", "UT2400" };

        public ModuleSelectorControl()
        {
            InitializeComponent();
            comboBoxModuleType.Items.Clear();
            comboBoxModuleType.Items.AddRange(moduleNames.ToArray());
        }

        private bool _canHaveUT220Module = true;
        public bool CanHaveUT220Module
        {
            get { return _canHaveUT220Module; }
            set { _canHaveUT220Module = value; RebuildList(); }
        }


        private bool _canHaveUT2400Module = true;
        public bool CanHaveUT2400Module
        {
            get { return _canHaveUT2400Module; }
            set { _canHaveUT2400Module = value; RebuildList(); }
        }

        private int FindModuleIndex(string moduleType)
        {
            var moduleName = moduleType.Replace("e", "").Replace("j", "");
            int index = 0;
            foreach (var item in comboBoxModuleType.Items)
            {
                if (item.Equals(moduleName))
                    return index;
                index++;
            }

            return -1;
        }

        private void RebuildList()
        {
            //            var selectedModuleIndex = comboBoxModuleType.SelectedIndex;
            var selectedItem = Convert.ToString(comboBoxModuleType.SelectedItem);
            comboBoxModuleType.Items.Clear();
            foreach (var moduleName in moduleNames)
            {
                if (moduleName == "UT220")
                {
                    if (CanHaveUT220Module)
                    {
                        comboBoxModuleType.Items.Add(moduleName);
                        if (selectedItem == moduleName)
                        {
                            selectedItem = "None";
                        }
                    }
                }
                else if (moduleName == "UT2400")
                {
                    if (CanHaveUT2400Module)
                    {
                        comboBoxModuleType.Items.Add(moduleName);
                        if (selectedItem == moduleName)
                        {
                            selectedItem = "None";
                        }
                    }
                }
                else
                {
                    comboBoxModuleType.Items.Add(moduleName);
                }

                SetModuleType(selectedItem);
            }
        }

        /// <summary>
        /// find the moduleName in the current list.  If found, select it,
        /// otherwise select "None" (index 0)
        /// </summary>
        /// <param name="moduleType"></param>
        /// <returns>true if found in list, false otherwise</returns>
        public bool SetModuleType (string moduleType)
        {
            var index = FindModuleIndex(moduleType.Replace("e", "").Replace("j", ""));
            comboBoxModuleType.SelectedIndex = index == -1 ? 0 : index;

            return index != -1;
        }

        public bool SetModuleTypeFromDisplayName(string displayName)
        {
            var moduleType = displayName.Replace("UT ", "UT").Replace("No Module Installed", "None");
            var index = FindModuleIndex(moduleType);
            comboBoxModuleType.SelectedIndex = index == -1 ? 0 : index;

            return index != -1;
        }

        public string GetModuleDisplayName()
        {
            if (comboBoxModuleType.SelectedIndex > 0)
            {
                return comboBoxModuleType.SelectedItem.ToString().Replace("UT", "UT ");
            }
            return "No Module Installed";
        }

        private void comboBoxModuleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // determine which was chosen, and act accordingly
            //            var selectedModuleIndex = comboBoxModuleType.SelectedIndex;
            //            var selectedItem = comboBoxModuleType.SelectedItem;
            //            var selectedItemName = Convert.ToString(selectedItem);
        }
    }
}
