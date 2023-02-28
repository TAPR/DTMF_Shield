
namespace Radio
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable IDE1006

    partial class ChannelListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenChannelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveChannelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.moduleLayoutPanelTab1 = new Radio.ModuleChannelList();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.moduleLayoutPanelTab2 = new Radio.ModuleChannelList();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.moduleLayoutPanelTab3 = new Radio.ModuleChannelList();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSerialCommands = new System.Windows.Forms.TextBox();
            this.StopProgramButton = new System.Windows.Forms.Button();
            this.UsbRcvdLabel = new System.Windows.Forms.Label();
            this.Label72 = new System.Windows.Forms.Label();
            this.UsbCmdLabel = new System.Windows.Forms.Label();
            this.Label66 = new System.Windows.Forms.Label();
            this.ComPortTextBox = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.ProgramRadioButton = new System.Windows.Forms.Button();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MenuStrip.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1465, 33);
            this.MenuStrip.TabIndex = 18;
            this.MenuStrip.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenChannelFileToolStripMenuItem,
            this.SaveChannelFileToolStripMenuItem});
            this.FileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // OpenChannelFileToolStripMenuItem
            // 
            this.OpenChannelFileToolStripMenuItem.Name = "OpenChannelFileToolStripMenuItem";
            this.OpenChannelFileToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.OpenChannelFileToolStripMenuItem.Text = "Open Channel File";
            this.OpenChannelFileToolStripMenuItem.Click += new System.EventHandler(this.OpenChannelFileToolStripMenuItem_Click);
            // 
            // SaveChannelFileToolStripMenuItem
            // 
            this.SaveChannelFileToolStripMenuItem.Name = "SaveChannelFileToolStripMenuItem";
            this.SaveChannelFileToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.SaveChannelFileToolStripMenuItem.Text = "Save Channel File";
            this.SaveChannelFileToolStripMenuItem.Click += new System.EventHandler(this.SaveChannelFileToolStripMenuItem_Click);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabControl.Controls.Add(this.TabPage1);
            this.TabControl.Controls.Add(this.TabPage2);
            this.TabControl.Controls.Add(this.TabPage3);
            this.TabControl.Location = new System.Drawing.Point(2, 44);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1463, 564);
            this.TabControl.TabIndex = 19;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.moduleLayoutPanelTab1);
            this.TabPage1.Location = new System.Drawing.Point(4, 29);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1455, 531);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Module 1";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // moduleLayoutPanelTab1
            // 
            this.moduleLayoutPanelTab1.channelUpdateClicked = false;
            this.moduleLayoutPanelTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleLayoutPanelTab1.Location = new System.Drawing.Point(3, 3);
            this.moduleLayoutPanelTab1.moduleSelectorControl = null;
            this.moduleLayoutPanelTab1.Name = "moduleLayoutPanelTab1";
            this.moduleLayoutPanelTab1.Size = new System.Drawing.Size(1449, 525);
            this.moduleLayoutPanelTab1.TabIndex = 0;
            this.moduleLayoutPanelTab1.UserSelectedChannel = false;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.moduleLayoutPanelTab2);
            this.TabPage2.Location = new System.Drawing.Point(4, 29);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(1455, 531);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Module 2";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // moduleLayoutPanelTab2
            // 
            this.moduleLayoutPanelTab2.channelUpdateClicked = false;
            this.moduleLayoutPanelTab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleLayoutPanelTab2.Location = new System.Drawing.Point(3, 3);
            this.moduleLayoutPanelTab2.moduleSelectorControl = null;
            this.moduleLayoutPanelTab2.Name = "moduleLayoutPanelTab2";
            this.moduleLayoutPanelTab2.Size = new System.Drawing.Size(1449, 525);
            this.moduleLayoutPanelTab2.TabIndex = 0;
            this.moduleLayoutPanelTab2.UserSelectedChannel = false;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.moduleLayoutPanelTab3);
            this.TabPage3.Location = new System.Drawing.Point(4, 29);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(1455, 531);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Module 3";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // moduleLayoutPanelTab3
            // 
            this.moduleLayoutPanelTab3.channelUpdateClicked = false;
            this.moduleLayoutPanelTab3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleLayoutPanelTab3.Location = new System.Drawing.Point(3, 3);
            this.moduleLayoutPanelTab3.moduleSelectorControl = null;
            this.moduleLayoutPanelTab3.Name = "moduleLayoutPanelTab3";
            this.moduleLayoutPanelTab3.Size = new System.Drawing.Size(1449, 525);
            this.moduleLayoutPanelTab3.TabIndex = 1;
            this.moduleLayoutPanelTab3.UserSelectedChannel = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 706);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 240);
            this.panel1.TabIndex = 21;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Silver;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel2.Controls.Add(this.label2);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Controls.Add(this.textBoxSerialCommands);
            this.Panel2.Controls.Add(this.StopProgramButton);
            this.Panel2.Controls.Add(this.UsbRcvdLabel);
            this.Panel2.Controls.Add(this.Label72);
            this.Panel2.Controls.Add(this.UsbCmdLabel);
            this.Panel2.Controls.Add(this.Label66);
            this.Panel2.Controls.Add(this.ComPortTextBox);
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.ProgressBar1);
            this.Panel2.Controls.Add(this.ProgramRadioButton);
            this.Panel2.Location = new System.Drawing.Point(0, 614);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1462, 335);
            this.Panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Serial DTMF_Shield Command History";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Progress";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSerialCommands
            // 
            this.textBoxSerialCommands.Location = new System.Drawing.Point(1, 204);
            this.textBoxSerialCommands.Multiline = true;
            this.textBoxSerialCommands.Name = "textBoxSerialCommands";
            this.textBoxSerialCommands.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSerialCommands.Size = new System.Drawing.Size(1450, 123);
            this.textBoxSerialCommands.TabIndex = 27;
            // 
            // StopProgramButton
            // 
            this.StopProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopProgramButton.Location = new System.Drawing.Point(700, 11);
            this.StopProgramButton.Name = "StopProgramButton";
            this.StopProgramButton.Size = new System.Drawing.Size(245, 80);
            this.StopProgramButton.TabIndex = 24;
            this.StopProgramButton.Text = "Stop Programming";
            this.StopProgramButton.UseVisualStyleBackColor = true;
            this.StopProgramButton.Click += new System.EventHandler(this.StopProgramButton_Click);
            // 
            // UsbRcvdLabel
            // 
            this.UsbRcvdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UsbRcvdLabel.Location = new System.Drawing.Point(543, 143);
            this.UsbRcvdLabel.Name = "UsbRcvdLabel";
            this.UsbRcvdLabel.Size = new System.Drawing.Size(124, 25);
            this.UsbRcvdLabel.TabIndex = 23;
            this.UsbRcvdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsbRcvdLabel.Click += new System.EventHandler(this.UsbRcvdLabel_Click);
            // 
            // Label72
            // 
            this.Label72.AutoSize = true;
            this.Label72.Location = new System.Drawing.Point(469, 145);
            this.Label72.Name = "Label72";
            this.Label72.Size = new System.Drawing.Size(68, 20);
            this.Label72.TabIndex = 22;
            this.Label72.Text = "received";
            // 
            // UsbCmdLabel
            // 
            this.UsbCmdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UsbCmdLabel.Location = new System.Drawing.Point(276, 143);
            this.UsbCmdLabel.Name = "UsbCmdLabel";
            this.UsbCmdLabel.Size = new System.Drawing.Size(170, 25);
            this.UsbCmdLabel.TabIndex = 21;
            this.UsbCmdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label66
            // 
            this.Label66.Location = new System.Drawing.Point(91, 143);
            this.Label66.Name = "Label66";
            this.Label66.Size = new System.Drawing.Size(179, 25);
            this.Label66.TabIndex = 20;
            this.Label66.Text = "Serial command sent";
            this.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComPortTextBox
            // 
            this.ComPortTextBox.Enabled = false;
            this.ComPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComPortTextBox.Location = new System.Drawing.Point(1218, 10);
            this.ComPortTextBox.Multiline = true;
            this.ComPortTextBox.Name = "ComPortTextBox";
            this.ComPortTextBox.Size = new System.Drawing.Size(221, 80);
            this.ComPortTextBox.TabIndex = 19;
            this.ComPortTextBox.Text = "test1";
            this.ComPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ComPortTextBox.Visible = false;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(10, 10);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(320, 37);
            this.Label7.TabIndex = 11;
            this.Label7.Text = "Radio Programming";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(134, 86);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(547, 28);
            this.ProgressBar1.TabIndex = 1;
            // 
            // ProgramRadioButton
            // 
            this.ProgramRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramRadioButton.Location = new System.Drawing.Point(956, 11);
            this.ProgramRadioButton.Name = "ProgramRadioButton";
            this.ProgramRadioButton.Size = new System.Drawing.Size(200, 80);
            this.ProgramRadioButton.TabIndex = 0;
            this.ProgramRadioButton.Text = "Program Radio Channels";
            this.ProgramRadioButton.UseVisualStyleBackColor = true;
            this.ProgramRadioButton.Click += new System.EventHandler(this.ProgramRadioButton_Click);
            // 
            // SerialPort1
            // 
            this.SerialPort1.PortName = "COM3";
            this.SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            this.OpenFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(186, 25);
            this.ToolStripStatusLabel.Text = "ToolStripStatusLabel";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 968);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(1465, 32);
            this.StatusStrip1.TabIndex = 20;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ChannelListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 1000);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.MenuStrip);
            this.Name = "ChannelListForm";
            this.Text = "Channel List Editor / Programmer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChannelListForm_FormClosing);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OpenChannelFileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SaveChannelFileToolStripMenuItem;
        public System.Windows.Forms.TabControl TabControl;
        public System.Windows.Forms.TabPage TabPage1;
        public System.Windows.Forms.TabPage TabPage2;
        public System.Windows.Forms.TabPage TabPage3;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.TextBox textBoxSerialCommands;
        internal System.Windows.Forms.Button StopProgramButton;
        internal System.Windows.Forms.Label UsbRcvdLabel;
        internal System.Windows.Forms.Label Label72;
        internal System.Windows.Forms.Label UsbCmdLabel;
        internal System.Windows.Forms.Label Label66;
        internal System.Windows.Forms.TextBox ComPortTextBox;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.Button ProgramRadioButton;
        public ModuleChannelList moduleLayoutPanelTab1;
        public ModuleChannelList moduleLayoutPanelTab2;
        public ModuleChannelList moduleLayoutPanelTab3;
        internal System.Windows.Forms.Timer Timer2;
        internal System.IO.Ports.SerialPort SerialPort1;
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.Timer Timer1;
        public System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
        public System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}