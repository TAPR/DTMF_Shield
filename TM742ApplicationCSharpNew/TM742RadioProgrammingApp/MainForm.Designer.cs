using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Radio
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public partial class MainForm : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.debugRadioTimingButton = new System.Windows.Forms.RadioButton();
            this.slowRadioTimingButton = new System.Windows.Forms.RadioButton();
            this.normalRadioTimingButton = new System.Windows.Forms.RadioButton();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxAllowOddOffset = new System.Windows.Forms.CheckBox();
            this.AROcheckBox = new System.Windows.Forms.CheckBox();
            this.wideBandCheckBox = new System.Windows.Forms.CheckBox();
            this.eTypeRadioCheckBox = new System.Windows.Forms.CheckBox();
            this.Tsu7CheckBox = new System.Windows.Forms.CheckBox();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.ChannelLists = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.module2SelectorControl = new Radio.ModuleSelectorControl();
            this.module1SelectorControl = new Radio.ModuleSelectorControl();
            this.module3SelectorControl = new Radio.ModuleSelectorControl();
            this.TableLayoutPanel1.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.TableLayoutPanel3.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 1);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.79431F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.20569F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(641, 457);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.ColumnCount = 3;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.17544F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.82456F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.TableLayoutPanel2.Controls.Add(this.Panel2, 1, 0);
            this.TableLayoutPanel2.Controls.Add(this.Panel3, 0, 0);
            this.TableLayoutPanel2.Controls.Add(this.Panel1, 2, 0);
            this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel2.Location = new System.Drawing.Point(4, 5);
            this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 1;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(633, 181);
            this.TableLayoutPanel2.TabIndex = 0;
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel2.Controls.Add(this.GroupBox1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(202, 5);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(189, 171);
            this.Panel2.TabIndex = 1;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.module2SelectorControl);
            this.GroupBox1.Location = new System.Drawing.Point(20, 21);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Size = new System.Drawing.Size(168, 122);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Module 2";
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel3.Controls.Add(this.GroupBox2);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(4, 5);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(190, 171);
            this.Panel3.TabIndex = 2;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.module1SelectorControl);
            this.GroupBox2.Location = new System.Drawing.Point(14, 20);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Size = new System.Drawing.Size(167, 123);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Module 1";
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.GroupBox3);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(399, 5);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(230, 171);
            this.Panel1.TabIndex = 3;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.module3SelectorControl);
            this.GroupBox3.Location = new System.Drawing.Point(26, 21);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox3.Size = new System.Drawing.Size(169, 122);
            this.GroupBox3.TabIndex = 3;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Module 3";
            // 
            // TableLayoutPanel3
            // 
            this.TableLayoutPanel3.ColumnCount = 2;
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.13902F));
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.86098F));
            this.TableLayoutPanel3.Controls.Add(this.Panel5, 0, 0);
            this.TableLayoutPanel3.Controls.Add(this.Panel6, 1, 0);
            this.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel3.Location = new System.Drawing.Point(4, 196);
            this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 1;
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel3.Size = new System.Drawing.Size(633, 256);
            this.TableLayoutPanel3.TabIndex = 1;
            // 
            // Panel5
            // 
            this.Panel5.Controls.Add(this.GroupBox5);
            this.Panel5.Controls.Add(this.GroupBox4);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel5.Location = new System.Drawing.Point(4, 5);
            this.Panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(398, 246);
            this.Panel5.TabIndex = 0;
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.debugRadioTimingButton);
            this.GroupBox5.Controls.Add(this.slowRadioTimingButton);
            this.GroupBox5.Controls.Add(this.normalRadioTimingButton);
            this.GroupBox5.Location = new System.Drawing.Point(204, 11);
            this.GroupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox5.Size = new System.Drawing.Size(138, 154);
            this.GroupBox5.TabIndex = 1;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Radio Timing";
            // 
            // debugRadioTimingButton
            // 
            this.debugRadioTimingButton.AutoSize = true;
            this.debugRadioTimingButton.Location = new System.Drawing.Point(15, 102);
            this.debugRadioTimingButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.debugRadioTimingButton.Name = "debugRadioTimingButton";
            this.debugRadioTimingButton.Size = new System.Drawing.Size(82, 24);
            this.debugRadioTimingButton.TabIndex = 2;
            this.debugRadioTimingButton.TabStop = true;
            this.debugRadioTimingButton.Text = "Debug";
            this.ToolTip1.SetToolTip(this.debugRadioTimingButton, "500 ms");
            this.debugRadioTimingButton.UseVisualStyleBackColor = true;
            this.debugRadioTimingButton.CheckedChanged += new System.EventHandler(this.debugRadioTimingButton_CheckedChanged);
            // 
            // slowRadioTimingButton
            // 
            this.slowRadioTimingButton.AutoSize = true;
            this.slowRadioTimingButton.Location = new System.Drawing.Point(15, 66);
            this.slowRadioTimingButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.slowRadioTimingButton.Name = "slowRadioTimingButton";
            this.slowRadioTimingButton.Size = new System.Drawing.Size(68, 24);
            this.slowRadioTimingButton.TabIndex = 1;
            this.slowRadioTimingButton.TabStop = true;
            this.slowRadioTimingButton.Text = "Slow";
            this.ToolTip1.SetToolTip(this.slowRadioTimingButton, "250 ms");
            this.slowRadioTimingButton.UseVisualStyleBackColor = true;
            this.slowRadioTimingButton.CheckedChanged += new System.EventHandler(this.slowRadioTimingButton_CheckedChanged);
            // 
            // normalRadioTimingButton
            // 
            this.normalRadioTimingButton.AutoSize = true;
            this.normalRadioTimingButton.Checked = true;
            this.normalRadioTimingButton.Location = new System.Drawing.Point(15, 31);
            this.normalRadioTimingButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.normalRadioTimingButton.Name = "normalRadioTimingButton";
            this.normalRadioTimingButton.Size = new System.Drawing.Size(84, 24);
            this.normalRadioTimingButton.TabIndex = 0;
            this.normalRadioTimingButton.TabStop = true;
            this.normalRadioTimingButton.Text = "Normal";
            this.ToolTip1.SetToolTip(this.normalRadioTimingButton, "100 ms or less");
            this.normalRadioTimingButton.UseVisualStyleBackColor = true;
            this.normalRadioTimingButton.CheckedChanged += new System.EventHandler(this.normalRadioTimingButton_CheckedChanged);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.checkBoxAllowOddOffset);
            this.GroupBox4.Controls.Add(this.AROcheckBox);
            this.GroupBox4.Controls.Add(this.wideBandCheckBox);
            this.GroupBox4.Controls.Add(this.eTypeRadioCheckBox);
            this.GroupBox4.Controls.Add(this.Tsu7CheckBox);
            this.GroupBox4.Location = new System.Drawing.Point(9, 11);
            this.GroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox4.Size = new System.Drawing.Size(175, 230);
            this.GroupBox4.TabIndex = 0;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Radio Options";
            // 
            // checkBoxAllowOddOffset
            // 
            this.checkBoxAllowOddOffset.AutoSize = true;
            this.checkBoxAllowOddOffset.Location = new System.Drawing.Point(10, 192);
            this.checkBoxAllowOddOffset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxAllowOddOffset.Name = "checkBoxAllowOddOffset";
            this.checkBoxAllowOddOffset.Size = new System.Drawing.Size(154, 24);
            this.checkBoxAllowOddOffset.TabIndex = 5;
            this.checkBoxAllowOddOffset.Text = "Allow Odd Offset";
            this.ToolTip1.SetToolTip(this.checkBoxAllowOddOffset, "Allow Custom/Odd/Non-standard split  See page 26 of user manual.");
            this.checkBoxAllowOddOffset.UseVisualStyleBackColor = true;
            this.checkBoxAllowOddOffset.CheckedChanged += new System.EventHandler(this.checkBoxAllowOddOffset_CheckedChanged);
            // 
            // AROcheckBox
            // 
            this.AROcheckBox.Location = new System.Drawing.Point(10, 136);
            this.AROcheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AROcheckBox.Name = "AROcheckBox";
            this.AROcheckBox.Size = new System.Drawing.Size(156, 48);
            this.AROcheckBox.TabIndex = 4;
            this.AROcheckBox.Text = "Automatic Repeater Offset";
            this.ToolTip1.SetToolTip(this.AROcheckBox, "Implements ARO for both USA/Canada and European radios");
            this.AROcheckBox.UseVisualStyleBackColor = true;
            this.AROcheckBox.CheckedChanged += new System.EventHandler(this.AROcheckBox_CheckedChanged);
            // 
            // wideBandCheckBox
            // 
            this.wideBandCheckBox.AutoSize = true;
            this.wideBandCheckBox.Location = new System.Drawing.Point(10, 111);
            this.wideBandCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wideBandCheckBox.Name = "wideBandCheckBox";
            this.wideBandCheckBox.Size = new System.Drawing.Size(113, 24);
            this.wideBandCheckBox.TabIndex = 3;
            this.wideBandCheckBox.Text = "Wide Band";
            this.ToolTip1.SetToolTip(this.wideBandCheckBox, "If resistor mods have been made on your chassis, select this.  It allows correct " +
        "digits to be sent.");
            this.wideBandCheckBox.UseVisualStyleBackColor = true;
            this.wideBandCheckBox.CheckedChanged += new System.EventHandler(this.wideBandCheckBox_CheckedChanged);
            // 
            // eTypeRadioCheckBox
            // 
            this.eTypeRadioCheckBox.AutoSize = true;
            this.eTypeRadioCheckBox.Location = new System.Drawing.Point(10, 78);
            this.eTypeRadioCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eTypeRadioCheckBox.Name = "eTypeRadioCheckBox";
            this.eTypeRadioCheckBox.Size = new System.Drawing.Size(136, 24);
            this.eTypeRadioCheckBox.TabIndex = 2;
            this.eTypeRadioCheckBox.Text = "\'E\' Type Radio";
            this.ToolTip1.SetToolTip(this.eTypeRadioCheckBox, "If checked, selects European band plans, repeater offsets, and such.  Prohibits U" +
        "T220 usage.");
            this.eTypeRadioCheckBox.UseVisualStyleBackColor = true;
            this.eTypeRadioCheckBox.CheckedChanged += new System.EventHandler(this.eTypeRadioCheckBox_CheckedChanged);
            // 
            // Tsu7CheckBox
            // 
            this.Tsu7CheckBox.AutoSize = true;
            this.Tsu7CheckBox.Location = new System.Drawing.Point(10, 45);
            this.Tsu7CheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tsu7CheckBox.Name = "Tsu7CheckBox";
            this.Tsu7CheckBox.Size = new System.Drawing.Size(145, 24);
            this.Tsu7CheckBox.TabIndex = 0;
            this.Tsu7CheckBox.Text = "TSU-7 Installed";
            this.ToolTip1.SetToolTip(this.Tsu7CheckBox, "This must match the radio.  Otherwise, CTCSS settings will be wrong.");
            this.Tsu7CheckBox.UseVisualStyleBackColor = true;
            this.Tsu7CheckBox.CheckedChanged += new System.EventHandler(this.Tsu7CheckBox_CheckedChanged);
            // 
            // Panel6
            // 
            this.Panel6.Controls.Add(this.Panel4);
            this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel6.Location = new System.Drawing.Point(410, 5);
            this.Panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(219, 246);
            this.Panel6.TabIndex = 1;
            // 
            // Panel4
            // 
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel4.Controls.Add(this.ChannelLists);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel4.Location = new System.Drawing.Point(0, 0);
            this.Panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(219, 246);
            this.Panel4.TabIndex = 1;
            // 
            // ChannelLists
            // 
            this.ChannelLists.Location = new System.Drawing.Point(45, 88);
            this.ChannelLists.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChannelLists.Name = "ChannelLists";
            this.ChannelLists.Size = new System.Drawing.Size(117, 60);
            this.ChannelLists.TabIndex = 2;
            this.ChannelLists.Text = "Go To Channel Lists";
            this.ChannelLists.UseVisualStyleBackColor = true;
            this.ChannelLists.Click += new System.EventHandler(this.ShowChannelLists_Click);
            // 
            // module2SelectorControl
            // 
            this.module2SelectorControl.CanHaveUT220Module = true;
            this.module2SelectorControl.CanHaveUT2400Module = true;
            this.module2SelectorControl.Location = new System.Drawing.Point(7, 49);
            this.module2SelectorControl.Name = "module2SelectorControl";
            this.module2SelectorControl.Size = new System.Drawing.Size(142, 32);
            this.module2SelectorControl.TabIndex = 1;
            // 
            // module1SelectorControl
            // 
            this.module1SelectorControl.CanHaveUT220Module = true;
            this.module1SelectorControl.CanHaveUT2400Module = true;
            this.module1SelectorControl.Location = new System.Drawing.Point(10, 50);
            this.module1SelectorControl.Name = "module1SelectorControl";
            this.module1SelectorControl.Size = new System.Drawing.Size(138, 32);
            this.module1SelectorControl.TabIndex = 2;
            // 
            // module3SelectorControl
            // 
            this.module3SelectorControl.CanHaveUT220Module = true;
            this.module3SelectorControl.CanHaveUT2400Module = false;
            this.module3SelectorControl.Location = new System.Drawing.Point(7, 49);
            this.module3SelectorControl.Name = "module3SelectorControl";
            this.module3SelectorControl.Size = new System.Drawing.Size(152, 32);
            this.module3SelectorControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 457);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Radio Configuration (Version 1.6)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel2.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.TableLayoutPanel3.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.Panel6.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal TableLayoutPanel TableLayoutPanel1;
        internal TableLayoutPanel TableLayoutPanel2;
        internal Panel Panel2;
        internal Panel Panel3;
        internal Panel Panel4;
        internal GroupBox GroupBox2;
        internal GroupBox GroupBox1;
        internal Panel Panel1;
        internal Button ChannelLists;
        internal TableLayoutPanel TableLayoutPanel3;
        internal Panel Panel5;
        internal Panel Panel6;
        internal GroupBox GroupBox4;
        internal CheckBox Tsu7CheckBox;
        internal CheckBox eTypeRadioCheckBox;
        internal CheckBox wideBandCheckBox;
        internal GroupBox GroupBox5;
        internal RadioButton debugRadioTimingButton;
        internal RadioButton slowRadioTimingButton;
        internal RadioButton normalRadioTimingButton;
        internal ToolTip ToolTip1;
        internal CheckBox AROcheckBox;
        internal GroupBox GroupBox3;
        public ModuleSelectorControl module2SelectorControl;
        public ModuleSelectorControl module3SelectorControl;
        public ModuleSelectorControl module1SelectorControl;
        internal CheckBox checkBoxAllowOddOffset;
    }
}