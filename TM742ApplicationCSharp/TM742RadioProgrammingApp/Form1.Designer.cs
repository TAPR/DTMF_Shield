using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Radio
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(OpenFileDialog1_FileOk);
            SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(SaveFileDialog1_FileOk);
            TabControl = new TabControl();
            TabControl.Deselecting += new TabControlCancelEventHandler(TabControl_Deselecting);
            TabPage1 = new TabPage();
            Tab1TableLayoutPanel1 = new TableLayoutPanel();
            TableLayoutPanel2 = new TableLayoutPanel();
            Panel1 = new Panel();
            Tab1DeleteRowButton = new Button();
            Tab1DeleteRowButton.Click += new EventHandler(Tab1DeleteRowButton_Click);
            Tab1InsertRowButton = new Button();
            Tab1InsertRowButton.Click += new EventHandler(Button11_Click);
            Label67 = new Label();
            Tab1ChannelNotes = new TextBox();
            Tab1CtcssPanel = new Panel();
            Tab1CtcssOff = new RadioButton();
            Tab1CtcssOff.CheckedChanged += new EventHandler(Tab2CtcssOff_CheckedChanged);
            Tab1CtcssXmit = new RadioButton();
            Tab1CtcssXmit.MouseDown += new MouseEventHandler(Tab1CtcssXmit_MouseDown);
            Tab1CtcssXmitRec = new RadioButton();
            Tab1CtcssXmitRec.MouseDown += new MouseEventHandler(Tab1CtcssXmit_MouseDown);
            Tab1CtcssLabel = new Label();
            Tab1SetChannelButtone = new Button();
            Tab1SetChannelButtone.Click += new EventHandler(SetChannelButtone_Click);
            Label6 = new Label();
            Label5 = new Label();
            Tab1ClearChannelList = new Button();
            Tab1ClearChannelList.Click += new EventHandler(Button1_Click);
            Label4 = new Label();
            Label3 = new Label();
            Tab1ChannelTextBox = new TextBox();
            Label2 = new Label();
            Label1 = new Label();
            Tab1ToneComboBox = new ComboBox();
            Tab1ToneComboBox.DropDownClosed += new EventHandler(Tab1ToneComboBox_DropDownClosed);
            Tab1ToneComboBox.SelectedIndexChanged += new EventHandler(Tab1ToneComboBox_SelectedIndexChanged);
            Tab1RepeaterComboBox = new ComboBox();
            Tab1KHzCombBox = new ComboBox();
            Tab1KHzCombBox.SelectedIndexChanged += new EventHandler(Tab1KHzCombBox_SelectedIndexChanged);
            Tab1MHzComboBox = new ComboBox();
            Tab1MHzComboBox.DropDown += new EventHandler(MHzComboBox_DropDown);
            Tab1MHzComboBox.SelectedIndexChanged += new EventHandler(MHzComboBox_SelectedIndexChanged);
            Tab1MenuStrip = new MenuStrip();
            Tab1FileToolStripMenuItem = new ToolStripMenuItem();
            Tab1OpenChannelFileToolStripMenuItem = new ToolStripMenuItem();
            Tab1OpenChannelFileToolStripMenuItem.Click += new EventHandler(Tab1OpenChannelFileToolStripMenuItem_Click);
            Tab1SaveChannelFileToolStripMenuItem = new ToolStripMenuItem();
            Tab1SaveChannelFileToolStripMenuItem.Click += new EventHandler(Tab1SaveChannelFileToolStripMenuItem_Click);
            Tab1SettingsToolStripMenuItem = new ToolStripMenuItem();
            Tab1BackToMainMenuToolStripMenuItem = new ToolStripMenuItem();
            Tab1BackToMainMenuToolStripMenuItem.Click += new EventHandler(Tab1BackToMainMenuToolStripMenuItem_Click);
            Tab1KHzStepSizeToolStripMenuItem = new ToolStripMenuItem();
            Tab1KHzStepSizeToolStripMenuItem.Click += new EventHandler(KHzStepSizeToolStripMenuItem_Click);
            Tab1KHzToolStripComboBox = new ToolStripComboBox();
            Tab1KHzToolStripComboBox.SelectedIndexChanged += new EventHandler(Tab1KHzToolStripComboBox_SelectedIndexChanged);
            Panel2 = new Panel();
            tab1ChannelFileName = new Label();
            Label9 = new Label();
            Tab1StopProgramButton = new Button();
            Tab1StopProgramButton.Click += new EventHandler(stopProgramButton_Click);
            Tab1UsbRcvdLabel = new Label();
            Label72 = new Label();
            Tab1UsbCmdLabel = new Label();
            Label66 = new Label();
            Tab1ComPortTextBox = new TextBox();
            Label7 = new Label();
            Tab1ProgressBar1 = new ProgressBar();
            Tab1ProgramButton = new Button();
            Tab1ProgramButton.Click += new EventHandler(Button2_Click);
            Tab1StatusStrip1 = new StatusStrip();
            Tab1ToolStripStepSize = new ToolStripStatusLabel();
            Tab1ToolStripStatusLabel = new ToolStripStatusLabel();
            Panel3 = new Panel();
            Tab1ChannelListView = new ListView();
            Tab1ChannelListView.SelectedIndexChanged += new EventHandler(ChannelListView_SelectedIndexChanged);
            Channel = new ColumnHeader();
            Frequency = new ColumnHeader();
            Repeater = new ColumnHeader();
            Tone = new ColumnHeader();
            CTSS = new ColumnHeader();
            Notes = new ColumnHeader();
            Label8 = new Label();
            TabPage2 = new TabPage();
            TableLayoutPanel7 = new TableLayoutPanel();
            TableLayoutPanel4 = new TableLayoutPanel();
            Panel11 = new Panel();
            Tab2DeleteRowButton = new Button();
            Tab2DeleteRowButton.Click += new EventHandler(Tab1DeleteRowButton_Click);
            Tab2InsertRowButton = new Button();
            Tab2InsertRowButton.Click += new EventHandler(Button11_Click);
            Label70 = new Label();
            Tab2ChannelNotes = new TextBox();
            Panel8 = new Panel();
            Tab2CtcssOff = new RadioButton();
            Tab2CtcssOff.CheckedChanged += new EventHandler(Tab2CtcssOff_CheckedChanged);
            Tab2CtcssXmit = new RadioButton();
            Tab2CtcssXmit.MouseDown += new MouseEventHandler(Tab1CtcssXmit_MouseDown);
            Tab2CtcssXmitRec = new RadioButton();
            Tab2CtcssXmitRec.MouseDown += new MouseEventHandler(Tab1CtcssXmit_MouseDown);
            Label22 = new Label();
            Tab2SetChannelButtone = new Button();
            Tab2SetChannelButtone.Click += new EventHandler(SetChannelButtone_Click);
            Label23 = new Label();
            Label24 = new Label();
            Tab2ClearChannelList = new Button();
            Tab2ClearChannelList.Click += new EventHandler(Button1_Click);
            Label25 = new Label();
            Label33 = new Label();
            Tab2ChannelTextBox = new TextBox();
            Label34 = new Label();
            Label35 = new Label();
            Tab2ToneComboBox = new ComboBox();
            Tab2ToneComboBox.SelectedIndexChanged += new EventHandler(Tab1ToneComboBox_SelectedIndexChanged);
            Tab2RepeaterComboBox = new ComboBox();
            Tab2KHzCombBox = new ComboBox();
            Tab2KHzCombBox.SelectedIndexChanged += new EventHandler(Tab1KHzCombBox_SelectedIndexChanged);
            Tab2MHzComboBox = new ComboBox();
            Tab2MHzComboBox.DropDown += new EventHandler(MHzComboBox_DropDown);
            Tab2MHzComboBox.SelectedIndexChanged += new EventHandler(MHzComboBox_SelectedIndexChanged);
            Tab2MenuStrip = new MenuStrip();
            Tab2FileToolStripMenuItem = new ToolStripMenuItem();
            Tab2OpenChannelFileToolStripMenuItem = new ToolStripMenuItem();
            Tab2OpenChannelFileToolStripMenuItem.Click += new EventHandler(Tab1OpenChannelFileToolStripMenuItem_Click);
            Tab2SaveChannelFileToolStripMenuItem = new ToolStripMenuItem();
            Tab2SaveChannelFileToolStripMenuItem.Click += new EventHandler(Tab1SaveChannelFileToolStripMenuItem_Click);
            Tab2SettingsToolStripMenuItem = new ToolStripMenuItem();
            Tab2BackToMainMenuToolStripMenuItem = new ToolStripMenuItem();
            Tab2BackToMainMenuToolStripMenuItem.Click += new EventHandler(Tab1BackToMainMenuToolStripMenuItem_Click);
            Tab2KHzStepSizeToolStripMenuItem = new ToolStripMenuItem();
            Tab2KHzStepSizeToolStripMenuItem.Click += new EventHandler(KHzStepSizeToolStripMenuItem_Click);
            Tab2KHzToolStripComboBox = new ToolStripComboBox();
            Tab2KHzToolStripComboBox.SelectedIndexChanged += new EventHandler(Tab1KHzToolStripComboBox_SelectedIndexChanged);
            Panel12 = new Panel();
            tab2ChannelFileName = new Label();
            Label10 = new Label();
            Tab2StopProgramButton = new Button();
            Tab2StopProgramButton.Click += new EventHandler(stopProgramButton_Click);
            Tab2UsbRcvdLabel = new Label();
            Label73 = new Label();
            Tab2UsbCmdLabel = new Label();
            Label68 = new Label();
            Tab2ComPortTextBox = new TextBox();
            Label38 = new Label();
            Tab2ProgressBar1 = new ProgressBar();
            Tab2ProgramButton = new Button();
            Tab2ProgramButton.Click += new EventHandler(Button2_Click);
            Tab2StatusStrip = new StatusStrip();
            Tab2ToolStripStepSize = new ToolStripStatusLabel();
            Tab2ToolStripStatusLabel = new ToolStripStatusLabel();
            Panel15 = new Panel();
            Tab2ChannelListView = new ListView();
            Tab2ChannelListView.SelectedIndexChanged += new EventHandler(ChannelListView_SelectedIndexChanged);
            ColumnHeader8 = new ColumnHeader();
            ColumnHeader7 = new ColumnHeader();
            ColumnHeader6 = new ColumnHeader();
            ColumnHeader15 = new ColumnHeader();
            ColumnHeader14 = new ColumnHeader();
            ColumnHeader27 = new ColumnHeader();
            Label43 = new Label();
            TabPage3 = new TabPage();
            TableLayoutPanel8 = new TableLayoutPanel();
            TableLayoutPanel10 = new TableLayoutPanel();
            Panel20 = new Panel();
            Tab3DeleteRowButton = new Button();
            Tab3DeleteRowButton.Click += new EventHandler(Tab1DeleteRowButton_Click);
            Tab3InsertRowButton = new Button();
            Tab3InsertRowButton.Click += new EventHandler(Button11_Click);
            Label71 = new Label();
            Tab3ChannelNotes = new TextBox();
            Panel21 = new Panel();
            Tab3CtcssOff = new RadioButton();
            Tab3CtcssOff.CheckedChanged += new EventHandler(Tab2CtcssOff_CheckedChanged);
            Tab3CtcssXmit = new RadioButton();
            Tab3CtcssXmit.MouseDown += new MouseEventHandler(Tab1CtcssXmit_MouseDown);
            Tab3CtcssXmitRec = new RadioButton();
            Tab3CtcssXmitRec.MouseDown += new MouseEventHandler(Tab1CtcssXmit_MouseDown);
            Label55 = new Label();
            Tab3SetChannelButtone = new Button();
            Tab3SetChannelButtone.Click += new EventHandler(SetChannelButtone_Click);
            Label56 = new Label();
            Label57 = new Label();
            Tab3ClearChannelList = new Button();
            Tab3ClearChannelList.Click += new EventHandler(Button1_Click);
            Label58 = new Label();
            Label59 = new Label();
            Tab3ChannelTextBox = new TextBox();
            Label60 = new Label();
            Label61 = new Label();
            Tab3ToneComboBox = new ComboBox();
            Tab3ToneComboBox.SelectedIndexChanged += new EventHandler(Tab1ToneComboBox_SelectedIndexChanged);
            Tab3RepeaterComboBox = new ComboBox();
            Tab3KHzCombBox = new ComboBox();
            Tab3KHzCombBox.SelectedIndexChanged += new EventHandler(Tab1KHzCombBox_SelectedIndexChanged);
            Tab3MHzComboBox = new ComboBox();
            Tab3MHzComboBox.DropDown += new EventHandler(MHzComboBox_DropDown);
            Tab3MHzComboBox.SelectedIndexChanged += new EventHandler(MHzComboBox_SelectedIndexChanged);
            Tab3MenuStrip = new MenuStrip();
            Tab3FileToolStripMenuItem = new ToolStripMenuItem();
            Tab3OpenChannelFileToolStripMenuItem = new ToolStripMenuItem();
            Tab3OpenChannelFileToolStripMenuItem.Click += new EventHandler(Tab1OpenChannelFileToolStripMenuItem_Click);
            Tab3SaveChannelFileToolStripMenuItem = new ToolStripMenuItem();
            Tab3SaveChannelFileToolStripMenuItem.Click += new EventHandler(Tab1SaveChannelFileToolStripMenuItem_Click);
            Tab3SettingsToolStripMenuItem = new ToolStripMenuItem();
            Tab3BackToMainMenuToolStripMenuItem = new ToolStripMenuItem();
            Tab3BackToMainMenuToolStripMenuItem.Click += new EventHandler(Tab1BackToMainMenuToolStripMenuItem_Click);
            Tab3KHzStepSizeToolStripMenuItem = new ToolStripMenuItem();
            Tab3KHzStepSizeToolStripMenuItem.Click += new EventHandler(KHzStepSizeToolStripMenuItem_Click);
            Tab3KHzToolStripComboBox = new ToolStripComboBox();
            Tab3KHzToolStripComboBox.SelectedIndexChanged += new EventHandler(Tab1KHzToolStripComboBox_SelectedIndexChanged);
            Panel22 = new Panel();
            tab3ChannelFileName = new Label();
            Label36 = new Label();
            Tab3StopProgramButton = new Button();
            Tab3StopProgramButton.Click += new EventHandler(stopProgramButton_Click);
            Tab3UsbRcvdLabel = new Label();
            Label74 = new Label();
            Tab3UsbCmdLabel = new Label();
            Label69 = new Label();
            Tab3ComPortTextBox = new TextBox();
            Label64 = new Label();
            Tab3ProgressBar1 = new ProgressBar();
            Tab3ProgramButton = new Button();
            Tab3ProgramButton.Click += new EventHandler(Button2_Click);
            Tab3StatusStrip = new StatusStrip();
            Tab3ToolStripStepSize = new ToolStripStatusLabel();
            Tab3ToolStripStatusLabel = new ToolStripStatusLabel();
            Panel23 = new Panel();
            Tab3ChannelListView = new ListView();
            Tab3ChannelListView.SelectedIndexChanged += new EventHandler(ChannelListView_SelectedIndexChanged);
            ColumnHeader21 = new ColumnHeader();
            ColumnHeader22 = new ColumnHeader();
            ColumnHeader23 = new ColumnHeader();
            ColumnHeader24 = new ColumnHeader();
            ColumnHeader25 = new ColumnHeader();
            ColumnHeader28 = new ColumnHeader();
            Label65 = new Label();
            SerialPort1 = new System.IO.Ports.SerialPort(components);
            SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SerialPort1_DataReceived);
            Timer2 = new Timer(components);
            TableLayoutPanel1 = new TableLayoutPanel();
            TableLayoutPanel3 = new TableLayoutPanel();
            Panel4 = new Panel();
            Panel5 = new Panel();
            RadioButton1 = new RadioButton();
            RadioButton2 = new RadioButton();
            Label11 = new Label();
            Button1 = new Button();
            Label12 = new Label();
            Label13 = new Label();
            Label14 = new Label();
            Label15 = new Label();
            TextBox1 = new TextBox();
            Label16 = new Label();
            Label17 = new Label();
            ComboBox1 = new ComboBox();
            ComboBox2 = new ComboBox();
            ComboBox3 = new ComboBox();
            ComboBox4 = new ComboBox();
            Panel6 = new Panel();
            Label18 = new Label();
            NumericUpDown1 = new NumericUpDown();
            Label19 = new Label();
            NumericUpDown2 = new NumericUpDown();
            Button2 = new Button();
            Label20 = new Label();
            ProgressBar1 = new ProgressBar();
            Button3 = new Button();
            Panel7 = new Panel();
            ListView1 = new ListView();
            ColumnHeader1 = new ColumnHeader();
            ColumnHeader2 = new ColumnHeader();
            ColumnHeader3 = new ColumnHeader();
            ColumnHeader4 = new ColumnHeader();
            ColumnHeader5 = new ColumnHeader();
            Label21 = new Label();
            Panel9 = new Panel();
            Panel10 = new Panel();
            RadioButton5 = new RadioButton();
            RadioButton6 = new RadioButton();
            Label26 = new Label();
            Button5 = new Button();
            Label27 = new Label();
            Label28 = new Label();
            Label29 = new Label();
            Label30 = new Label();
            TextBox2 = new TextBox();
            Label31 = new Label();
            Label32 = new Label();
            ComboBox5 = new ComboBox();
            ComboBox6 = new ComboBox();
            ComboBox7 = new ComboBox();
            ComboBox8 = new ComboBox();
            TableLayoutPanel5 = new TableLayoutPanel();
            TableLayoutPanel6 = new TableLayoutPanel();
            Panel13 = new Panel();
            Label39 = new Label();
            NumericUpDown5 = new NumericUpDown();
            Label40 = new Label();
            NumericUpDown6 = new NumericUpDown();
            Button8 = new Button();
            Label41 = new Label();
            ProgressBar3 = new ProgressBar();
            Button9 = new Button();
            Panel14 = new Panel();
            ListView2 = new ListView();
            ColumnHeader9 = new ColumnHeader();
            ColumnHeader10 = new ColumnHeader();
            ColumnHeader11 = new ColumnHeader();
            ColumnHeader12 = new ColumnHeader();
            ColumnHeader13 = new ColumnHeader();
            Label42 = new Label();
            TableLayoutPanel9 = new TableLayoutPanel();
            Panel16 = new Panel();
            Panel17 = new Panel();
            RadioButton3 = new RadioButton();
            RadioButton4 = new RadioButton();
            Label44 = new Label();
            Button4 = new Button();
            Label45 = new Label();
            Label46 = new Label();
            Label47 = new Label();
            Label48 = new Label();
            TextBox3 = new TextBox();
            Label49 = new Label();
            Label50 = new Label();
            ComboBox9 = new ComboBox();
            ComboBox10 = new ComboBox();
            ComboBox11 = new ComboBox();
            ComboBox12 = new ComboBox();
            deleteMenuStrip1 = new MenuStrip();
            ToolStripMenuItem1 = new ToolStripMenuItem();
            ToolStripMenuItem2 = new ToolStripMenuItem();
            ToolStripMenuItem3 = new ToolStripMenuItem();
            ToolStripMenuItem4 = new ToolStripMenuItem();
            ToolStripMenuItem5 = new ToolStripMenuItem();
            ToolStripMenuItem6 = new ToolStripMenuItem();
            ToolStripComboBox1 = new ToolStripComboBox();
            Panel18 = new Panel();
            Label51 = new Label();
            NumericUpDown3 = new NumericUpDown();
            Label52 = new Label();
            NumericUpDown4 = new NumericUpDown();
            Button6 = new Button();
            Label53 = new Label();
            ProgressBar2 = new ProgressBar();
            Button7 = new Button();
            deleteStatusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            Panel19 = new Panel();
            ListView3 = new ListView();
            ColumnHeader16 = new ColumnHeader();
            ColumnHeader17 = new ColumnHeader();
            ColumnHeader18 = new ColumnHeader();
            ColumnHeader19 = new ColumnHeader();
            ColumnHeader20 = new ColumnHeader();
            Label54 = new Label();
            TabControl.SuspendLayout();
            TabPage1.SuspendLayout();
            Tab1TableLayoutPanel1.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            Panel1.SuspendLayout();
            Tab1CtcssPanel.SuspendLayout();
            Tab1MenuStrip.SuspendLayout();
            Panel2.SuspendLayout();
            Tab1StatusStrip1.SuspendLayout();
            Panel3.SuspendLayout();
            TabPage2.SuspendLayout();
            TableLayoutPanel7.SuspendLayout();
            TableLayoutPanel4.SuspendLayout();
            Panel11.SuspendLayout();
            Panel8.SuspendLayout();
            Tab2MenuStrip.SuspendLayout();
            Panel12.SuspendLayout();
            Tab2StatusStrip.SuspendLayout();
            Panel15.SuspendLayout();
            TabPage3.SuspendLayout();
            TableLayoutPanel8.SuspendLayout();
            TableLayoutPanel10.SuspendLayout();
            Panel20.SuspendLayout();
            Panel21.SuspendLayout();
            Tab3MenuStrip.SuspendLayout();
            Panel22.SuspendLayout();
            Tab3StatusStrip.SuspendLayout();
            Panel23.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            Panel4.SuspendLayout();
            Panel5.SuspendLayout();
            Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown2).BeginInit();
            Panel7.SuspendLayout();
            Panel9.SuspendLayout();
            Panel10.SuspendLayout();
            TableLayoutPanel5.SuspendLayout();
            TableLayoutPanel6.SuspendLayout();
            Panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown6).BeginInit();
            Panel14.SuspendLayout();
            TableLayoutPanel9.SuspendLayout();
            Panel16.SuspendLayout();
            Panel17.SuspendLayout();
            deleteMenuStrip1.SuspendLayout();
            Panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown4).BeginInit();
            deleteStatusStrip1.SuspendLayout();
            Panel19.SuspendLayout();
            SuspendLayout();
            // 
            // Timer1
            // 
            Timer1.Interval = 1000;
            // 
            // OpenFileDialog1
            // 
            OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // SaveFileDialog1
            // 
            // 
            // TabControl
            // 
            TabControl.Controls.Add(TabPage1);
            TabControl.Controls.Add(TabPage2);
            TabControl.Controls.Add(TabPage3);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1014, 568);
            TabControl.SizeMode = TabSizeMode.Fixed;
            TabControl.TabIndex = 0;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(Tab1TableLayoutPanel1);
            TabPage1.Location = new Point(4, 34);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(1006, 530);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "TabPage1";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // Tab1TableLayoutPanel1
            // 
            Tab1TableLayoutPanel1.ColumnCount = 2;
            Tab1TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.78069f));
            Tab1TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.21931f));
            Tab1TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0);
            Tab1TableLayoutPanel1.Controls.Add(Panel3, 1, 0);
            Tab1TableLayoutPanel1.Dock = DockStyle.Fill;
            Tab1TableLayoutPanel1.Location = new Point(3, 3);
            Tab1TableLayoutPanel1.Name = "Tab1TableLayoutPanel1";
            Tab1TableLayoutPanel1.RowCount = 1;
            Tab1TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            Tab1TableLayoutPanel1.Size = new Size(1000, 524);
            Tab1TableLayoutPanel1.TabIndex = 1;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.ColumnCount = 1;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel2.Controls.Add(Panel1, 0, 0);
            TableLayoutPanel2.Controls.Add(Panel2, 0, 1);
            TableLayoutPanel2.Controls.Add(Tab1StatusStrip1, 0, 2);
            TableLayoutPanel2.Dock = DockStyle.Fill;
            TableLayoutPanel2.Location = new Point(3, 3);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 3;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 57.14286f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 42.85714f));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22.0f));
            TableLayoutPanel2.Size = new Size(461, 518);
            TableLayoutPanel2.TabIndex = 0;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.Silver;
            Panel1.BorderStyle = BorderStyle.Fixed3D;
            Panel1.Controls.Add(Tab1DeleteRowButton);
            Panel1.Controls.Add(Tab1InsertRowButton);
            Panel1.Controls.Add(Label67);
            Panel1.Controls.Add(Tab1ChannelNotes);
            Panel1.Controls.Add(Tab1CtcssPanel);
            Panel1.Controls.Add(Tab1CtcssLabel);
            Panel1.Controls.Add(Tab1SetChannelButtone);
            Panel1.Controls.Add(Label6);
            Panel1.Controls.Add(Label5);
            Panel1.Controls.Add(Tab1ClearChannelList);
            Panel1.Controls.Add(Label4);
            Panel1.Controls.Add(Label3);
            Panel1.Controls.Add(Tab1ChannelTextBox);
            Panel1.Controls.Add(Label2);
            Panel1.Controls.Add(Label1);
            Panel1.Controls.Add(Tab1ToneComboBox);
            Panel1.Controls.Add(Tab1RepeaterComboBox);
            Panel1.Controls.Add(Tab1KHzCombBox);
            Panel1.Controls.Add(Tab1MHzComboBox);
            Panel1.Controls.Add(Tab1MenuStrip);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(3, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(455, 277);
            Panel1.TabIndex = 0;
            // 
            // Tab1DeleteRowButton
            // 
            Tab1DeleteRowButton.Location = new Point(268, 243);
            Tab1DeleteRowButton.Name = "Tab1DeleteRowButton";
            Tab1DeleteRowButton.Size = new Size(139, 23);
            Tab1DeleteRowButton.TabIndex = 24;
            Tab1DeleteRowButton.Text = "Delete Row";
            Tab1DeleteRowButton.UseVisualStyleBackColor = true;
            // 
            // Tab1InsertRowButton
            // 
            Tab1InsertRowButton.Location = new Point(268, 214);
            Tab1InsertRowButton.Name = "Tab1InsertRowButton";
            Tab1InsertRowButton.Size = new Size(140, 23);
            Tab1InsertRowButton.TabIndex = 22;
            Tab1InsertRowButton.Text = "Insert Row";
            Tab1InsertRowButton.UseVisualStyleBackColor = true;
            // 
            // Label67
            // 
            Label67.AutoSize = true;
            Label67.Location = new Point(7, 103);
            Label67.Name = "Label67";
            Label67.Size = new Size(155, 25);
            Label67.TabIndex = 19;
            Label67.Text = "Channel Notes";
            // 
            // Tab1ChannelNotes
            // 
            Tab1ChannelNotes.Location = new Point(7, 122);
            Tab1ChannelNotes.MaxLength = 25;
            Tab1ChannelNotes.Name = "Tab1ChannelNotes";
            Tab1ChannelNotes.Size = new Size(335, 30);
            Tab1ChannelNotes.TabIndex = 18;
            // 
            // Tab1CtcssPanel
            // 
            Tab1CtcssPanel.Controls.Add(Tab1CtcssOff);
            Tab1CtcssPanel.Controls.Add(Tab1CtcssXmit);
            Tab1CtcssPanel.Controls.Add(Tab1CtcssXmitRec);
            Tab1CtcssPanel.Location = new Point(348, 76);
            Tab1CtcssPanel.Name = "Tab1CtcssPanel";
            Tab1CtcssPanel.Size = new Size(100, 72);
            Tab1CtcssPanel.TabIndex = 16;
            // 
            // Tab1CtcssOff
            // 
            Tab1CtcssOff.AutoSize = true;
            Tab1CtcssOff.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab1CtcssOff.Location = new Point(9, 46);
            Tab1CtcssOff.Name = "Tab1CtcssOff";
            Tab1CtcssOff.Size = new Size(66, 29);
            Tab1CtcssOff.TabIndex = 16;
            Tab1CtcssOff.TabStop = true;
            Tab1CtcssOff.Text = "Off";
            Tab1CtcssOff.UseVisualStyleBackColor = true;
            // 
            // Tab1CtcssXmit
            // 
            Tab1CtcssXmit.AutoSize = true;
            Tab1CtcssXmit.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab1CtcssXmit.Location = new Point(9, 5);
            Tab1CtcssXmit.Name = "Tab1CtcssXmit";
            Tab1CtcssXmit.Size = new Size(80, 29);
            Tab1CtcssXmit.TabIndex = 14;
            Tab1CtcssXmit.TabStop = true;
            Tab1CtcssXmit.Text = "Xmit";
            Tab1CtcssXmit.UseVisualStyleBackColor = true;
            // 
            // Tab1CtcssXmitRec
            // 
            Tab1CtcssXmitRec.AutoSize = true;
            Tab1CtcssXmitRec.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab1CtcssXmitRec.Location = new Point(9, 26);
            Tab1CtcssXmitRec.Name = "Tab1CtcssXmitRec";
            Tab1CtcssXmitRec.Size = new Size(124, 29);
            Tab1CtcssXmitRec.TabIndex = 15;
            Tab1CtcssXmitRec.TabStop = true;
            Tab1CtcssXmitRec.Text = "Xmit/Rec";
            Tab1CtcssXmitRec.UseVisualStyleBackColor = true;
            // 
            // Tab1CtcssLabel
            // 
            Tab1CtcssLabel.AutoSize = true;
            Tab1CtcssLabel.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab1CtcssLabel.Location = new Point(359, 60);
            Tab1CtcssLabel.Name = "Tab1CtcssLabel";
            Tab1CtcssLabel.Size = new Size(88, 25);
            Tab1CtcssLabel.TabIndex = 13;
            Tab1CtcssLabel.Text = "CTCSS";
            // 
            // Tab1SetChannelButtone
            // 
            Tab1SetChannelButtone.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab1SetChannelButtone.Location = new Point(268, 154);
            Tab1SetChannelButtone.Name = "Tab1SetChannelButtone";
            Tab1SetChannelButtone.Size = new Size(140, 48);
            Tab1SetChannelButtone.TabIndex = 11;
            Tab1SetChannelButtone.Text = "Set/Update Channel";
            Tab1SetChannelButtone.UseVisualStyleBackColor = true;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(115, 24);
            Label6.Name = "Label6";
            Label6.Size = new Size(276, 37);
            Label6.TabIndex = 10;
            Label6.Text = "Channel Settings";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(294, 60);
            Label5.Name = "Label5";
            Label5.Size = new Size(62, 25);
            Label5.TabIndex = 9;
            Label5.Text = "Tone";
            // 
            // Tab1ClearChannelList
            // 
            Tab1ClearChannelList.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab1ClearChannelList.Location = new Point(138, 209);
            Tab1ClearChannelList.Name = "Tab1ClearChannelList";
            Tab1ClearChannelList.Size = new Size(111, 43);
            Tab1ClearChannelList.TabIndex = 12;
            Tab1ClearChannelList.Text = "Clear Channel List";
            Tab1ClearChannelList.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.Location = new Point(207, 60);
            Label4.Name = "Label4";
            Label4.Size = new Size(99, 25);
            Label4.TabIndex = 8;
            Label4.Text = "Repeater";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(146, 60);
            Label3.Name = "Label3";
            Label3.Size = new Size(53, 25);
            Label3.TabIndex = 7;
            Label3.Text = "KHz";
            // 
            // Tab1ChannelTextBox
            // 
            Tab1ChannelTextBox.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab1ChannelTextBox.Location = new Point(7, 77);
            Tab1ChannelTextBox.Name = "Tab1ChannelTextBox";
            Tab1ChannelTextBox.ReadOnly = true;
            Tab1ChannelTextBox.Size = new Size(46, 28);
            Tab1ChannelTextBox.TabIndex = 6;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(7, 61);
            Label2.Name = "Label2";
            Label2.Size = new Size(61, 25);
            Label2.TabIndex = 5;
            Label2.Text = "CH #";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(75, 60);
            Label1.Name = "Label1";
            Label1.Size = new Size(56, 25);
            Label1.TabIndex = 4;
            Label1.Text = "MHz";
            // 
            // Tab1ToneComboBox
            // 
            Tab1ToneComboBox.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab1ToneComboBox.FormattingEnabled = true;
            Tab1ToneComboBox.Items.AddRange(new object[] { "OFF", "67.0", "71.9", "74.4", "77.0", "79.7", "82.5", "85.4", "88.5", "91.5", "94.8", "97.4", "100.0", "103.5", "107.2", "110.9", "114.8", "118.8", "123.0", "127.3", "131.8", "136.5", "141.3", "146.2", "151.4", "156.7", "162.2", "167.9", "173.8", "179.9", "186.2", "192.8", "203.5", "210.7", "218.1", "225.7", "233.6", "241.8", "250.3" });
            Tab1ToneComboBox.Location = new Point(291, 76);
            Tab1ToneComboBox.Name = "Tab1ToneComboBox";
            Tab1ToneComboBox.Size = new Size(58, 30);
            Tab1ToneComboBox.TabIndex = 3;
            // 
            // Tab1RepeaterComboBox
            // 
            Tab1RepeaterComboBox.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab1RepeaterComboBox.FormattingEnabled = true;
            Tab1RepeaterComboBox.Items.AddRange(new object[] { "PLUS", "MINUS", "SIMPLEX" });
            Tab1RepeaterComboBox.Location = new Point(204, 76);
            Tab1RepeaterComboBox.Name = "Tab1RepeaterComboBox";
            Tab1RepeaterComboBox.Size = new Size(83, 30);
            Tab1RepeaterComboBox.TabIndex = 2;
            // 
            // Tab1KHzCombBox
            // 
            Tab1KHzCombBox.DropDownWidth = 43;
            Tab1KHzCombBox.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab1KHzCombBox.FormattingEnabled = true;
            Tab1KHzCombBox.Items.AddRange(new object[] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "110", "120", "130", "140", "150", "160", "170", "180", "190", "200", "210", "220", "230", "240", "250", "260", "270", "280", "290", "300", "310", "320", "330", "340", "350", "360", "370", "380", "390", "400", "410", "420", "430", "440", "450", "460", "470", "480", "490", "500", "510", "520", "530", "540", "550", "560", "570", "580", "590", "600", "610", "620", "630", "640", "650", "660", "670", "680", "690", "700", "710", "720", "730", "740", "750", "760", "770", "780", "790", "800", "810", "820", "830", "840", "850", "860", "870", "880", "890", "900", "910", "920", "930", "940", "950", "960", "970", "980", "990" });
            Tab1KHzCombBox.Location = new Point(134, 76);
            Tab1KHzCombBox.MaxDropDownItems = 10;
            Tab1KHzCombBox.Name = "Tab1KHzCombBox";
            Tab1KHzCombBox.Size = new Size(66, 30);
            Tab1KHzCombBox.TabIndex = 1;
            // 
            // Tab1MHzComboBox
            // 
            Tab1MHzComboBox.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab1MHzComboBox.FormattingEnabled = true;
            Tab1MHzComboBox.Items.AddRange(new object[] { "BLANK", "146", "147", "148", "149", "150" });
            Tab1MHzComboBox.Location = new Point(60, 76);
            Tab1MHzComboBox.Name = "Tab1MHzComboBox";
            Tab1MHzComboBox.Size = new Size(70, 30);
            Tab1MHzComboBox.TabIndex = 0;
            // 
            // Tab1MenuStrip
            // 
            Tab1MenuStrip.GripMargin = new Padding(2, 2, 0, 2);
            Tab1MenuStrip.ImageScalingSize = new Size(24, 24);
            Tab1MenuStrip.Items.AddRange(new ToolStripItem[] { Tab1FileToolStripMenuItem, Tab1SettingsToolStripMenuItem });
            Tab1MenuStrip.Location = new Point(0, 0);
            Tab1MenuStrip.Name = "Tab1MenuStrip";
            Tab1MenuStrip.Size = new Size(451, 33);
            Tab1MenuStrip.TabIndex = 17;
            Tab1MenuStrip.Text = "MenuStrip1";
            // 
            // Tab1FileToolStripMenuItem
            // 
            Tab1FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Tab1OpenChannelFileToolStripMenuItem, Tab1SaveChannelFileToolStripMenuItem });
            Tab1FileToolStripMenuItem.Font = new Font("Segoe UI", 9.0f, FontStyle.Bold);
            Tab1FileToolStripMenuItem.Name = "Tab1FileToolStripMenuItem";
            Tab1FileToolStripMenuItem.Size = new Size(57, 29);
            Tab1FileToolStripMenuItem.Text = "File";
            // 
            // Tab1OpenChannelFileToolStripMenuItem
            // 
            Tab1OpenChannelFileToolStripMenuItem.Name = "Tab1OpenChannelFileToolStripMenuItem";
            Tab1OpenChannelFileToolStripMenuItem.Size = new Size(268, 34);
            Tab1OpenChannelFileToolStripMenuItem.Text = "Open Channel File";
            // 
            // Tab1SaveChannelFileToolStripMenuItem
            // 
            Tab1SaveChannelFileToolStripMenuItem.Name = "Tab1SaveChannelFileToolStripMenuItem";
            Tab1SaveChannelFileToolStripMenuItem.Size = new Size(268, 34);
            Tab1SaveChannelFileToolStripMenuItem.Text = "Save Channel File";
            // 
            // Tab1SettingsToolStripMenuItem
            // 
            Tab1SettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Tab1BackToMainMenuToolStripMenuItem, Tab1KHzStepSizeToolStripMenuItem });
            Tab1SettingsToolStripMenuItem.Font = new Font("Segoe UI", 9.0f, FontStyle.Bold);
            Tab1SettingsToolStripMenuItem.Name = "Tab1SettingsToolStripMenuItem";
            Tab1SettingsToolStripMenuItem.Size = new Size(95, 29);
            Tab1SettingsToolStripMenuItem.Text = "Options";
            // 
            // Tab1BackToMainMenuToolStripMenuItem
            // 
            Tab1BackToMainMenuToolStripMenuItem.Name = "Tab1BackToMainMenuToolStripMenuItem";
            Tab1BackToMainMenuToolStripMenuItem.Size = new Size(280, 34);
            Tab1BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu";
            // 
            // Tab1KHzStepSizeToolStripMenuItem
            // 
            Tab1KHzStepSizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Tab1KHzToolStripComboBox });
            Tab1KHzStepSizeToolStripMenuItem.Name = "Tab1KHzStepSizeToolStripMenuItem";
            Tab1KHzStepSizeToolStripMenuItem.Size = new Size(280, 34);
            Tab1KHzStepSizeToolStripMenuItem.Text = "kHz Step Size";
            // 
            // Tab1KHzToolStripComboBox
            // 
            Tab1KHzToolStripComboBox.Font = new Font("Segoe UI", 9.0f, FontStyle.Bold);
            Tab1KHzToolStripComboBox.Items.AddRange(new object[] { "10", "12.5", "5", "25" });
            Tab1KHzToolStripComboBox.Name = "Tab1KHzToolStripComboBox";
            Tab1KHzToolStripComboBox.Size = new Size(121, 33);
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.Silver;
            Panel2.BorderStyle = BorderStyle.Fixed3D;
            Panel2.Controls.Add(tab1ChannelFileName);
            Panel2.Controls.Add(Label9);
            Panel2.Controls.Add(Tab1StopProgramButton);
            Panel2.Controls.Add(Tab1UsbRcvdLabel);
            Panel2.Controls.Add(Label72);
            Panel2.Controls.Add(Tab1UsbCmdLabel);
            Panel2.Controls.Add(Label66);
            Panel2.Controls.Add(Tab1ComPortTextBox);
            Panel2.Controls.Add(Label7);
            Panel2.Controls.Add(Tab1ProgressBar1);
            Panel2.Controls.Add(Tab1ProgramButton);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(3, 286);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(455, 206);
            Panel2.TabIndex = 1;
            // 
            // tab1ChannelFileName
            // 
            tab1ChannelFileName.BorderStyle = BorderStyle.Fixed3D;
            tab1ChannelFileName.Font = new Font("Microsoft Sans Serif", 8.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            tab1ChannelFileName.Location = new Point(149, 173);
            tab1ChannelFileName.Name = "tab1ChannelFileName";
            tab1ChannelFileName.Size = new Size(298, 25);
            tab1ChannelFileName.TabIndex = 26;
            tab1ChannelFileName.TextAlign = ContentAlignment.MiddleLeft;
            tab1ChannelFileName.Visible = false;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(11, 177);
            Label9.Name = "Label9";
            Label9.Size = new Size(187, 25);
            Label9.TabIndex = 25;
            Label9.Text = "Channel Filename";
            Label9.Visible = false;
            // 
            // Tab1StopProgramButton
            // 
            Tab1StopProgramButton.Location = new Point(45, 50);
            Tab1StopProgramButton.Name = "Tab1StopProgramButton";
            Tab1StopProgramButton.Size = new Size(117, 44);
            Tab1StopProgramButton.TabIndex = 24;
            Tab1StopProgramButton.Text = "Stop Programming";
            Tab1StopProgramButton.UseVisualStyleBackColor = true;
            // 
            // Tab1UsbRcvdLabel
            // 
            Tab1UsbRcvdLabel.BorderStyle = BorderStyle.Fixed3D;
            Tab1UsbRcvdLabel.Location = new Point(352, 134);
            Tab1UsbRcvdLabel.Name = "Tab1UsbRcvdLabel";
            Tab1UsbRcvdLabel.Size = new Size(96, 25);
            Tab1UsbRcvdLabel.TabIndex = 23;
            Tab1UsbRcvdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label72
            // 
            Label72.AutoSize = true;
            Label72.Location = new Point(277, 138);
            Label72.Name = "Label72";
            Label72.Size = new Size(94, 25);
            Label72.TabIndex = 22;
            Label72.Text = "received";
            // 
            // Tab1UsbCmdLabel
            // 
            Tab1UsbCmdLabel.BorderStyle = BorderStyle.Fixed3D;
            Tab1UsbCmdLabel.Location = new Point(168, 134);
            Tab1UsbCmdLabel.Name = "Tab1UsbCmdLabel";
            Tab1UsbCmdLabel.Size = new Size(96, 25);
            Tab1UsbCmdLabel.TabIndex = 21;
            Tab1UsbCmdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label66
            // 
            Label66.Location = new Point(10, 134);
            Label66.Name = "Label66";
            Label66.Size = new Size(179, 25);
            Label66.TabIndex = 20;
            Label66.Text = "Serial command sent";
            Label66.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab1ComPortTextBox
            // 
            Tab1ComPortTextBox.Enabled = false;
            Tab1ComPortTextBox.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab1ComPortTextBox.Location = new Point(347, 13);
            Tab1ComPortTextBox.Multiline = true;
            Tab1ComPortTextBox.Name = "Tab1ComPortTextBox";
            Tab1ComPortTextBox.Size = new Size(87, 80);
            Tab1ComPortTextBox.TabIndex = 19;
            Tab1ComPortTextBox.Text = "test1";
            Tab1ComPortTextBox.TextAlign = HorizontalAlignment.Center;
            Tab1ComPortTextBox.Visible = false;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(80, 10);
            Label7.Name = "Label7";
            Label7.Size = new Size(320, 37);
            Label7.TabIndex = 11;
            Label7.Text = "Radio Programming";
            // 
            // Tab1ProgressBar1
            // 
            Tab1ProgressBar1.Location = new Point(53, 108);
            Tab1ProgressBar1.Name = "Tab1ProgressBar1";
            Tab1ProgressBar1.Size = new Size(335, 16);
            Tab1ProgressBar1.TabIndex = 1;
            // 
            // Tab1ProgramButton
            // 
            Tab1ProgramButton.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab1ProgramButton.Location = new Point(215, 50);
            Tab1ProgramButton.Name = "Tab1ProgramButton";
            Tab1ProgramButton.Size = new Size(98, 44);
            Tab1ProgramButton.TabIndex = 0;
            Tab1ProgramButton.Text = "Program Radio Channels";
            Tab1ProgramButton.UseVisualStyleBackColor = true;
            // 
            // Tab1StatusStrip1
            // 
            Tab1StatusStrip1.ImageScalingSize = new Size(24, 24);
            Tab1StatusStrip1.Items.AddRange(new ToolStripItem[] { Tab1ToolStripStepSize, Tab1ToolStripStatusLabel });
            Tab1StatusStrip1.Location = new Point(0, 495);
            Tab1StatusStrip1.Name = "Tab1StatusStrip1";
            Tab1StatusStrip1.Size = new Size(461, 23);
            Tab1StatusStrip1.TabIndex = 2;
            Tab1StatusStrip1.Text = "StatusStrip1";
            // 
            // Tab1ToolStripStepSize
            // 
            Tab1ToolStripStepSize.Name = "Tab1ToolStripStepSize";
            Tab1ToolStripStepSize.Size = new Size(180, 16);
            Tab1ToolStripStepSize.Text = "ToolStripStatusLabel1";
            // 
            // Tab1ToolStripStatusLabel
            // 
            Tab1ToolStripStatusLabel.Font = new Font("Segoe UI", 9.0f, FontStyle.Bold);
            Tab1ToolStripStatusLabel.Name = "Tab1ToolStripStatusLabel";
            Tab1ToolStripStatusLabel.Size = new Size(196, 16);
            Tab1ToolStripStatusLabel.Text = "ToolStripStatusLabel2";
            // 
            // Panel3
            // 
            Panel3.AutoSize = true;
            Panel3.BackColor = Color.Silver;
            Panel3.BorderStyle = BorderStyle.Fixed3D;
            Panel3.Controls.Add(Tab1ChannelListView);
            Panel3.Controls.Add(Label8);
            Panel3.Dock = DockStyle.Fill;
            Panel3.Location = new Point(470, 3);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(527, 518);
            Panel3.TabIndex = 1;
            // 
            // Tab1ChannelListView
            // 
            Tab1ChannelListView.Columns.AddRange(new ColumnHeader[] { Channel, Frequency, Repeater, Tone, CTSS, Notes });
            Tab1ChannelListView.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab1ChannelListView.FullRowSelect = true;
            Tab1ChannelListView.GridLines = true;
            Tab1ChannelListView.HideSelection = false;
            Tab1ChannelListView.LabelWrap = false;
            Tab1ChannelListView.Location = new Point(0, 34);
            Tab1ChannelListView.MultiSelect = false;
            Tab1ChannelListView.Name = "Tab1ChannelListView";
            Tab1ChannelListView.Size = new Size(523, 463);
            Tab1ChannelListView.TabIndex = 12;
            Tab1ChannelListView.UseCompatibleStateImageBehavior = false;
            Tab1ChannelListView.View = View.Details;
            // 
            // Channel
            // 
            Channel.Text = "CH#";
            Channel.Width = 42;
            // 
            // Frequency
            // 
            Frequency.Text = "Frequency";
            Frequency.TextAlign = HorizontalAlignment.Center;
            Frequency.Width = 91;
            // 
            // Repeater
            // 
            Repeater.Text = "Repeater";
            Repeater.TextAlign = HorizontalAlignment.Center;
            Repeater.Width = 81;
            // 
            // Tone
            // 
            Tone.Text = "Tone";
            Tone.TextAlign = HorizontalAlignment.Center;
            Tone.Width = 50;
            // 
            // CTSS
            // 
            CTSS.Text = " CTCSS";
            CTSS.TextAlign = HorizontalAlignment.Center;
            CTSS.Width = 80;
            // 
            // Notes
            // 
            Notes.Text = "Notes";
            Notes.Width = 375;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label8.Location = new Point(176, 10);
            Label8.Name = "Label8";
            Label8.Size = new Size(207, 37);
            Label8.TabIndex = 11;
            Label8.Text = "Channel List";
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(TableLayoutPanel7);
            TabPage2.Location = new Point(4, 34);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(1006, 530);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "TabPage2";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel7
            // 
            TableLayoutPanel7.ColumnCount = 2;
            TableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.7f));
            TableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.3f));
            TableLayoutPanel7.Controls.Add(TableLayoutPanel4, 0, 0);
            TableLayoutPanel7.Controls.Add(Panel15, 1, 0);
            TableLayoutPanel7.Dock = DockStyle.Fill;
            TableLayoutPanel7.Location = new Point(3, 3);
            TableLayoutPanel7.Name = "TableLayoutPanel7";
            TableLayoutPanel7.RowCount = 1;
            TableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel7.Size = new Size(1000, 524);
            TableLayoutPanel7.TabIndex = 2;
            // 
            // TableLayoutPanel4
            // 
            TableLayoutPanel4.ColumnCount = 1;
            TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel4.Controls.Add(Panel11, 0, 0);
            TableLayoutPanel4.Controls.Add(Panel12, 0, 1);
            TableLayoutPanel4.Controls.Add(Tab2StatusStrip, 0, 2);
            TableLayoutPanel4.Dock = DockStyle.Fill;
            TableLayoutPanel4.Location = new Point(3, 3);
            TableLayoutPanel4.Name = "TableLayoutPanel4";
            TableLayoutPanel4.RowCount = 3;
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 57.14286f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 42.85714f));
            TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 22.0f));
            TableLayoutPanel4.Size = new Size(461, 518);
            TableLayoutPanel4.TabIndex = 0;
            // 
            // Panel11
            // 
            Panel11.BackColor = Color.Silver;
            Panel11.BorderStyle = BorderStyle.Fixed3D;
            Panel11.Controls.Add(Tab2DeleteRowButton);
            Panel11.Controls.Add(Tab2InsertRowButton);
            Panel11.Controls.Add(Label70);
            Panel11.Controls.Add(Tab2ChannelNotes);
            Panel11.Controls.Add(Panel8);
            Panel11.Controls.Add(Label22);
            Panel11.Controls.Add(Tab2SetChannelButtone);
            Panel11.Controls.Add(Label23);
            Panel11.Controls.Add(Label24);
            Panel11.Controls.Add(Tab2ClearChannelList);
            Panel11.Controls.Add(Label25);
            Panel11.Controls.Add(Label33);
            Panel11.Controls.Add(Tab2ChannelTextBox);
            Panel11.Controls.Add(Label34);
            Panel11.Controls.Add(Label35);
            Panel11.Controls.Add(Tab2ToneComboBox);
            Panel11.Controls.Add(Tab2RepeaterComboBox);
            Panel11.Controls.Add(Tab2KHzCombBox);
            Panel11.Controls.Add(Tab2MHzComboBox);
            Panel11.Controls.Add(Tab2MenuStrip);
            Panel11.Dock = DockStyle.Fill;
            Panel11.Location = new Point(3, 3);
            Panel11.Name = "Panel11";
            Panel11.Size = new Size(455, 277);
            Panel11.TabIndex = 0;
            // 
            // Tab2DeleteRowButton
            // 
            Tab2DeleteRowButton.Location = new Point(268, 243);
            Tab2DeleteRowButton.Name = "Tab2DeleteRowButton";
            Tab2DeleteRowButton.Size = new Size(139, 23);
            Tab2DeleteRowButton.TabIndex = 23;
            Tab2DeleteRowButton.Text = "Delete Row";
            Tab2DeleteRowButton.UseVisualStyleBackColor = true;
            // 
            // Tab2InsertRowButton
            // 
            Tab2InsertRowButton.Location = new Point(268, 214);
            Tab2InsertRowButton.Name = "Tab2InsertRowButton";
            Tab2InsertRowButton.Size = new Size(140, 23);
            Tab2InsertRowButton.TabIndex = 22;
            Tab2InsertRowButton.Text = "Insert Row";
            Tab2InsertRowButton.UseVisualStyleBackColor = true;
            // 
            // Label70
            // 
            Label70.AutoSize = true;
            Label70.Location = new Point(7, 103);
            Label70.Name = "Label70";
            Label70.Size = new Size(155, 25);
            Label70.TabIndex = 20;
            Label70.Text = "Channel Notes";
            // 
            // Tab2ChannelNotes
            // 
            Tab2ChannelNotes.Location = new Point(7, 122);
            Tab2ChannelNotes.MaxLength = 10;
            Tab2ChannelNotes.Name = "Tab2ChannelNotes";
            Tab2ChannelNotes.Size = new Size(335, 30);
            Tab2ChannelNotes.TabIndex = 19;
            // 
            // Panel8
            // 
            Panel8.Controls.Add(Tab2CtcssOff);
            Panel8.Controls.Add(Tab2CtcssXmit);
            Panel8.Controls.Add(Tab2CtcssXmitRec);
            Panel8.Location = new Point(348, 76);
            Panel8.Name = "Panel8";
            Panel8.Size = new Size(100, 72);
            Panel8.TabIndex = 16;
            // 
            // Tab2CtcssOff
            // 
            Tab2CtcssOff.AutoSize = true;
            Tab2CtcssOff.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab2CtcssOff.Location = new Point(9, 46);
            Tab2CtcssOff.Name = "Tab2CtcssOff";
            Tab2CtcssOff.Size = new Size(66, 29);
            Tab2CtcssOff.TabIndex = 17;
            Tab2CtcssOff.TabStop = true;
            Tab2CtcssOff.Text = "Off";
            Tab2CtcssOff.UseVisualStyleBackColor = true;
            // 
            // Tab2CtcssXmit
            // 
            Tab2CtcssXmit.AutoSize = true;
            Tab2CtcssXmit.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab2CtcssXmit.Location = new Point(9, 5);
            Tab2CtcssXmit.Name = "Tab2CtcssXmit";
            Tab2CtcssXmit.Size = new Size(80, 29);
            Tab2CtcssXmit.TabIndex = 14;
            Tab2CtcssXmit.TabStop = true;
            Tab2CtcssXmit.Text = "Xmit";
            Tab2CtcssXmit.UseVisualStyleBackColor = true;
            // 
            // Tab2CtcssXmitRec
            // 
            Tab2CtcssXmitRec.AutoSize = true;
            Tab2CtcssXmitRec.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab2CtcssXmitRec.Location = new Point(9, 26);
            Tab2CtcssXmitRec.Name = "Tab2CtcssXmitRec";
            Tab2CtcssXmitRec.Size = new Size(124, 29);
            Tab2CtcssXmitRec.TabIndex = 15;
            Tab2CtcssXmitRec.TabStop = true;
            Tab2CtcssXmitRec.Text = "Xmit/Rec";
            Tab2CtcssXmitRec.UseVisualStyleBackColor = true;
            // 
            // Label22
            // 
            Label22.AutoSize = true;
            Label22.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label22.Location = new Point(359, 60);
            Label22.Name = "Label22";
            Label22.Size = new Size(88, 25);
            Label22.TabIndex = 13;
            Label22.Text = "CTCSS";
            // 
            // Tab2SetChannelButtone
            // 
            Tab2SetChannelButtone.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab2SetChannelButtone.Location = new Point(268, 154);
            Tab2SetChannelButtone.Name = "Tab2SetChannelButtone";
            Tab2SetChannelButtone.Size = new Size(140, 48);
            Tab2SetChannelButtone.TabIndex = 11;
            Tab2SetChannelButtone.Text = "Set/Update Channel";
            Tab2SetChannelButtone.UseVisualStyleBackColor = true;
            // 
            // Label23
            // 
            Label23.AutoSize = true;
            Label23.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label23.Location = new Point(115, 24);
            Label23.Name = "Label23";
            Label23.Size = new Size(276, 37);
            Label23.TabIndex = 10;
            Label23.Text = "Channel Settings";
            // 
            // Label24
            // 
            Label24.AutoSize = true;
            Label24.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label24.Location = new Point(294, 60);
            Label24.Name = "Label24";
            Label24.Size = new Size(62, 25);
            Label24.TabIndex = 9;
            Label24.Text = "Tone";
            // 
            // Tab2ClearChannelList
            // 
            Tab2ClearChannelList.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab2ClearChannelList.Location = new Point(138, 209);
            Tab2ClearChannelList.Name = "Tab2ClearChannelList";
            Tab2ClearChannelList.Size = new Size(111, 43);
            Tab2ClearChannelList.TabIndex = 12;
            Tab2ClearChannelList.Text = "Clear Channel List";
            Tab2ClearChannelList.UseVisualStyleBackColor = true;
            // 
            // Label25
            // 
            Label25.AutoSize = true;
            Label25.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label25.Location = new Point(207, 60);
            Label25.Name = "Label25";
            Label25.Size = new Size(99, 25);
            Label25.TabIndex = 8;
            Label25.Text = "Repeater";
            // 
            // Label33
            // 
            Label33.AutoSize = true;
            Label33.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label33.Location = new Point(146, 60);
            Label33.Name = "Label33";
            Label33.Size = new Size(53, 25);
            Label33.TabIndex = 7;
            Label33.Text = "KHz";
            // 
            // Tab2ChannelTextBox
            // 
            Tab2ChannelTextBox.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab2ChannelTextBox.Location = new Point(7, 77);
            Tab2ChannelTextBox.Name = "Tab2ChannelTextBox";
            Tab2ChannelTextBox.ReadOnly = true;
            Tab2ChannelTextBox.Size = new Size(46, 28);
            Tab2ChannelTextBox.TabIndex = 6;
            // 
            // Label34
            // 
            Label34.AutoSize = true;
            Label34.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label34.Location = new Point(7, 61);
            Label34.Name = "Label34";
            Label34.Size = new Size(61, 25);
            Label34.TabIndex = 5;
            Label34.Text = "CH #";
            // 
            // Label35
            // 
            Label35.AutoSize = true;
            Label35.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label35.Location = new Point(75, 60);
            Label35.Name = "Label35";
            Label35.Size = new Size(56, 25);
            Label35.TabIndex = 4;
            Label35.Text = "MHz";
            // 
            // Tab2ToneComboBox
            // 
            Tab2ToneComboBox.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab2ToneComboBox.FormattingEnabled = true;
            Tab2ToneComboBox.Items.AddRange(new object[] { "OFF", "67.0", "71.9", "74.4", "77.0", "79.7", "82.5", "85.4", "88.5", "91.5", "94.8", "97.4", "100.0", "103.5", "107.2", "110.9", "114.8", "118.8", "123.0", "127.3", "131.8", "136.5", "141.3", "146.2", "151.4", "156.7", "162.2", "167.9", "173.8", "179.9", "186.2", "192.8", "203.5", "210.7", "218.1", "225.7", "233.6", "241.8", "250.3" });
            Tab2ToneComboBox.Location = new Point(291, 76);
            Tab2ToneComboBox.Name = "Tab2ToneComboBox";
            Tab2ToneComboBox.Size = new Size(58, 30);
            Tab2ToneComboBox.TabIndex = 3;
            // 
            // Tab2RepeaterComboBox
            // 
            Tab2RepeaterComboBox.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab2RepeaterComboBox.FormattingEnabled = true;
            Tab2RepeaterComboBox.Items.AddRange(new object[] { "PLUS", "MINUS", "SIMPLEX" });
            Tab2RepeaterComboBox.Location = new Point(204, 76);
            Tab2RepeaterComboBox.Name = "Tab2RepeaterComboBox";
            Tab2RepeaterComboBox.Size = new Size(83, 30);
            Tab2RepeaterComboBox.TabIndex = 2;
            // 
            // Tab2KHzCombBox
            // 
            Tab2KHzCombBox.DropDownWidth = 43;
            Tab2KHzCombBox.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab2KHzCombBox.FormattingEnabled = true;
            Tab2KHzCombBox.Items.AddRange(new object[] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "110", "120", "130", "140", "150", "160", "170", "180", "190", "200", "210", "220", "230", "240", "250", "260", "270", "280", "290", "300", "310", "320", "330", "340", "350", "360", "370", "380", "390", "400", "410", "420", "430", "440", "450", "460", "470", "480", "490", "500", "510", "520", "530", "540", "550", "560", "570", "580", "590", "600", "610", "620", "630", "640", "650", "660", "670", "680", "690", "700", "710", "720", "730", "740", "750", "760", "770", "780", "790", "800", "810", "820", "830", "840", "850", "860", "870", "880", "890", "900", "910", "920", "930", "940", "950", "960", "970", "980", "990" });
            Tab2KHzCombBox.Location = new Point(134, 76);
            Tab2KHzCombBox.MaxDropDownItems = 10;
            Tab2KHzCombBox.Name = "Tab2KHzCombBox";
            Tab2KHzCombBox.Size = new Size(66, 30);
            Tab2KHzCombBox.TabIndex = 1;
            // 
            // Tab2MHzComboBox
            // 
            Tab2MHzComboBox.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab2MHzComboBox.FormattingEnabled = true;
            Tab2MHzComboBox.Items.AddRange(new object[] { "BLANK", "146", "147", "148", "149", "150" });
            Tab2MHzComboBox.Location = new Point(60, 76);
            Tab2MHzComboBox.Name = "Tab2MHzComboBox";
            Tab2MHzComboBox.Size = new Size(70, 30);
            Tab2MHzComboBox.TabIndex = 0;
            // 
            // Tab2MenuStrip
            // 
            Tab2MenuStrip.GripMargin = new Padding(2, 2, 0, 2);
            Tab2MenuStrip.ImageScalingSize = new Size(24, 24);
            Tab2MenuStrip.Items.AddRange(new ToolStripItem[] { Tab2FileToolStripMenuItem, Tab2SettingsToolStripMenuItem });
            Tab2MenuStrip.Location = new Point(0, 0);
            Tab2MenuStrip.Name = "Tab2MenuStrip";
            Tab2MenuStrip.Size = new Size(451, 33);
            Tab2MenuStrip.TabIndex = 17;
            Tab2MenuStrip.Text = "MenuStrip1";
            // 
            // Tab2FileToolStripMenuItem
            // 
            Tab2FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Tab2OpenChannelFileToolStripMenuItem, Tab2SaveChannelFileToolStripMenuItem });
            Tab2FileToolStripMenuItem.Font = new Font("Segoe UI", 9.0f, FontStyle.Bold);
            Tab2FileToolStripMenuItem.Name = "Tab2FileToolStripMenuItem";
            Tab2FileToolStripMenuItem.Size = new Size(57, 29);
            Tab2FileToolStripMenuItem.Text = "File";
            // 
            // Tab2OpenChannelFileToolStripMenuItem
            // 
            Tab2OpenChannelFileToolStripMenuItem.Name = "Tab2OpenChannelFileToolStripMenuItem";
            Tab2OpenChannelFileToolStripMenuItem.Size = new Size(268, 34);
            Tab2OpenChannelFileToolStripMenuItem.Text = "Open Channel File";
            // 
            // Tab2SaveChannelFileToolStripMenuItem
            // 
            Tab2SaveChannelFileToolStripMenuItem.Name = "Tab2SaveChannelFileToolStripMenuItem";
            Tab2SaveChannelFileToolStripMenuItem.Size = new Size(268, 34);
            Tab2SaveChannelFileToolStripMenuItem.Text = "Save Channel File";
            // 
            // Tab2SettingsToolStripMenuItem
            // 
            Tab2SettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Tab2BackToMainMenuToolStripMenuItem, Tab2KHzStepSizeToolStripMenuItem });
            Tab2SettingsToolStripMenuItem.Font = new Font("Segoe UI", 9.0f, FontStyle.Bold);
            Tab2SettingsToolStripMenuItem.Name = "Tab2SettingsToolStripMenuItem";
            Tab2SettingsToolStripMenuItem.Size = new Size(95, 29);
            Tab2SettingsToolStripMenuItem.Text = "Options";
            // 
            // Tab2BackToMainMenuToolStripMenuItem
            // 
            Tab2BackToMainMenuToolStripMenuItem.Name = "Tab2BackToMainMenuToolStripMenuItem";
            Tab2BackToMainMenuToolStripMenuItem.Size = new Size(280, 34);
            Tab2BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu";
            // 
            // Tab2KHzStepSizeToolStripMenuItem
            // 
            Tab2KHzStepSizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Tab2KHzToolStripComboBox });
            Tab2KHzStepSizeToolStripMenuItem.Name = "Tab2KHzStepSizeToolStripMenuItem";
            Tab2KHzStepSizeToolStripMenuItem.Size = new Size(280, 34);
            Tab2KHzStepSizeToolStripMenuItem.Text = "kHz Step Size";
            // 
            // Tab2KHzToolStripComboBox
            // 
            Tab2KHzToolStripComboBox.Items.AddRange(new object[] { "10", "12.5", "5", "25" });
            Tab2KHzToolStripComboBox.Name = "Tab2KHzToolStripComboBox";
            Tab2KHzToolStripComboBox.Size = new Size(121, 33);
            // 
            // Panel12
            // 
            Panel12.BackColor = Color.Silver;
            Panel12.BorderStyle = BorderStyle.Fixed3D;
            Panel12.Controls.Add(tab2ChannelFileName);
            Panel12.Controls.Add(Label10);
            Panel12.Controls.Add(Tab2StopProgramButton);
            Panel12.Controls.Add(Tab2UsbRcvdLabel);
            Panel12.Controls.Add(Label73);
            Panel12.Controls.Add(Tab2UsbCmdLabel);
            Panel12.Controls.Add(Label68);
            Panel12.Controls.Add(Tab2ComPortTextBox);
            Panel12.Controls.Add(Label38);
            Panel12.Controls.Add(Tab2ProgressBar1);
            Panel12.Controls.Add(Tab2ProgramButton);
            Panel12.Dock = DockStyle.Fill;
            Panel12.Location = new Point(3, 286);
            Panel12.Name = "Panel12";
            Panel12.Size = new Size(455, 206);
            Panel12.TabIndex = 1;
            // 
            // tab2ChannelFileName
            // 
            tab2ChannelFileName.BorderStyle = BorderStyle.Fixed3D;
            tab2ChannelFileName.Font = new Font("Microsoft Sans Serif", 8.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            tab2ChannelFileName.Location = new Point(147, 173);
            tab2ChannelFileName.Name = "tab2ChannelFileName";
            tab2ChannelFileName.Size = new Size(300, 25);
            tab2ChannelFileName.TabIndex = 28;
            tab2ChannelFileName.TextAlign = ContentAlignment.MiddleLeft;
            tab2ChannelFileName.Visible = false;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(11, 177);
            Label10.Name = "Label10";
            Label10.Size = new Size(187, 25);
            Label10.TabIndex = 27;
            Label10.Text = "Channel Filename";
            Label10.Visible = false;
            // 
            // Tab2StopProgramButton
            // 
            Tab2StopProgramButton.Location = new Point(45, 50);
            Tab2StopProgramButton.Name = "Tab2StopProgramButton";
            Tab2StopProgramButton.Size = new Size(117, 44);
            Tab2StopProgramButton.TabIndex = 26;
            Tab2StopProgramButton.Text = "Stop Programming";
            Tab2StopProgramButton.UseVisualStyleBackColor = true;
            // 
            // Tab2UsbRcvdLabel
            // 
            Tab2UsbRcvdLabel.BorderStyle = BorderStyle.Fixed3D;
            Tab2UsbRcvdLabel.Location = new Point(352, 134);
            Tab2UsbRcvdLabel.Name = "Tab2UsbRcvdLabel";
            Tab2UsbRcvdLabel.Size = new Size(96, 25);
            Tab2UsbRcvdLabel.TabIndex = 25;
            Tab2UsbRcvdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label73
            // 
            Label73.AutoSize = true;
            Label73.Location = new Point(277, 138);
            Label73.Name = "Label73";
            Label73.Size = new Size(94, 25);
            Label73.TabIndex = 24;
            Label73.Text = "received";
            // 
            // Tab2UsbCmdLabel
            // 
            Tab2UsbCmdLabel.BorderStyle = BorderStyle.Fixed3D;
            Tab2UsbCmdLabel.Location = new Point(168, 134);
            Tab2UsbCmdLabel.Name = "Tab2UsbCmdLabel";
            Tab2UsbCmdLabel.Size = new Size(96, 25);
            Tab2UsbCmdLabel.TabIndex = 23;
            Tab2UsbCmdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label68
            // 
            Label68.Location = new Point(10, 134);
            Label68.Name = "Label68";
            Label68.Size = new Size(231, 25);
            Label68.TabIndex = 21;
            Label68.Text = "Serial command sent";
            Label68.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab2ComPortTextBox
            // 
            Tab2ComPortTextBox.Enabled = false;
            Tab2ComPortTextBox.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab2ComPortTextBox.Location = new Point(347, 13);
            Tab2ComPortTextBox.Multiline = true;
            Tab2ComPortTextBox.Name = "Tab2ComPortTextBox";
            Tab2ComPortTextBox.Size = new Size(87, 80);
            Tab2ComPortTextBox.TabIndex = 20;
            Tab2ComPortTextBox.Text = "test1";
            Tab2ComPortTextBox.TextAlign = HorizontalAlignment.Center;
            Tab2ComPortTextBox.Visible = false;
            // 
            // Label38
            // 
            Label38.AutoSize = true;
            Label38.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label38.Location = new Point(80, 10);
            Label38.Name = "Label38";
            Label38.Size = new Size(320, 37);
            Label38.TabIndex = 11;
            Label38.Text = "Radio Programming";
            // 
            // Tab2ProgressBar1
            // 
            Tab2ProgressBar1.Location = new Point(53, 108);
            Tab2ProgressBar1.Name = "Tab2ProgressBar1";
            Tab2ProgressBar1.Size = new Size(335, 16);
            Tab2ProgressBar1.TabIndex = 1;
            // 
            // Tab2ProgramButton
            // 
            Tab2ProgramButton.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab2ProgramButton.Location = new Point(215, 50);
            Tab2ProgramButton.Name = "Tab2ProgramButton";
            Tab2ProgramButton.Size = new Size(98, 44);
            Tab2ProgramButton.TabIndex = 0;
            Tab2ProgramButton.Text = "Program Radio Channels";
            Tab2ProgramButton.UseVisualStyleBackColor = true;
            // 
            // Tab2StatusStrip
            // 
            Tab2StatusStrip.ImageScalingSize = new Size(24, 24);
            Tab2StatusStrip.Items.AddRange(new ToolStripItem[] { Tab2ToolStripStepSize, Tab2ToolStripStatusLabel });
            Tab2StatusStrip.Location = new Point(0, 495);
            Tab2StatusStrip.Name = "Tab2StatusStrip";
            Tab2StatusStrip.Size = new Size(461, 23);
            Tab2StatusStrip.TabIndex = 2;
            Tab2StatusStrip.Text = "StatusStrip1";
            // 
            // Tab2ToolStripStepSize
            // 
            Tab2ToolStripStepSize.Name = "Tab2ToolStripStepSize";
            Tab2ToolStripStepSize.Size = new Size(180, 16);
            Tab2ToolStripStepSize.Text = "ToolStripStatusLabel1";
            // 
            // Tab2ToolStripStatusLabel
            // 
            Tab2ToolStripStatusLabel.Font = new Font("Segoe UI", 9.0f, FontStyle.Bold);
            Tab2ToolStripStatusLabel.Name = "Tab2ToolStripStatusLabel";
            Tab2ToolStripStatusLabel.Size = new Size(196, 16);
            Tab2ToolStripStatusLabel.Text = "ToolStripStatusLabel2";
            // 
            // Panel15
            // 
            Panel15.BackColor = Color.Silver;
            Panel15.BorderStyle = BorderStyle.Fixed3D;
            Panel15.Controls.Add(Tab2ChannelListView);
            Panel15.Controls.Add(Label43);
            Panel15.Dock = DockStyle.Fill;
            Panel15.Location = new Point(470, 3);
            Panel15.Name = "Panel15";
            Panel15.Size = new Size(527, 518);
            Panel15.TabIndex = 1;
            // 
            // Tab2ChannelListView
            // 
            Tab2ChannelListView.Columns.AddRange(new ColumnHeader[] { ColumnHeader8, ColumnHeader7, ColumnHeader6, ColumnHeader15, ColumnHeader14, ColumnHeader27 });
            Tab2ChannelListView.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab2ChannelListView.FullRowSelect = true;
            Tab2ChannelListView.GridLines = true;
            Tab2ChannelListView.HideSelection = false;
            Tab2ChannelListView.Location = new Point(0, 34);
            Tab2ChannelListView.MultiSelect = false;
            Tab2ChannelListView.Name = "Tab2ChannelListView";
            Tab2ChannelListView.Size = new Size(523, 463);
            Tab2ChannelListView.TabIndex = 12;
            Tab2ChannelListView.UseCompatibleStateImageBehavior = false;
            Tab2ChannelListView.View = View.Details;
            // 
            // ColumnHeader8
            // 
            ColumnHeader8.Text = "CH#";
            ColumnHeader8.Width = 42;
            // 
            // ColumnHeader7
            // 
            ColumnHeader7.Text = "Frequency";
            ColumnHeader7.TextAlign = HorizontalAlignment.Center;
            ColumnHeader7.Width = 91;
            // 
            // ColumnHeader6
            // 
            ColumnHeader6.Text = "Repeater";
            ColumnHeader6.TextAlign = HorizontalAlignment.Center;
            ColumnHeader6.Width = 81;
            // 
            // ColumnHeader15
            // 
            ColumnHeader15.Text = "Tone";
            ColumnHeader15.TextAlign = HorizontalAlignment.Center;
            ColumnHeader15.Width = 50;
            // 
            // ColumnHeader14
            // 
            ColumnHeader14.Text = " CTCSS";
            ColumnHeader14.TextAlign = HorizontalAlignment.Center;
            ColumnHeader14.Width = 80;
            // 
            // ColumnHeader27
            // 
            ColumnHeader27.Text = "Notes";
            ColumnHeader27.Width = 375;
            // 
            // Label43
            // 
            Label43.AutoSize = true;
            Label43.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label43.Location = new Point(176, 10);
            Label43.Name = "Label43";
            Label43.Size = new Size(207, 37);
            Label43.TabIndex = 11;
            Label43.Text = "Channel List";
            // 
            // TabPage3
            // 
            TabPage3.Controls.Add(TableLayoutPanel8);
            TabPage3.Location = new Point(4, 34);
            TabPage3.Name = "TabPage3";
            TabPage3.Padding = new Padding(3);
            TabPage3.Size = new Size(1006, 530);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "TabPage3";
            TabPage3.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel8
            // 
            TableLayoutPanel8.ColumnCount = 2;
            TableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.8f));
            TableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.2f));
            TableLayoutPanel8.Controls.Add(TableLayoutPanel10, 0, 0);
            TableLayoutPanel8.Controls.Add(Panel23, 1, 0);
            TableLayoutPanel8.Dock = DockStyle.Fill;
            TableLayoutPanel8.Location = new Point(3, 3);
            TableLayoutPanel8.Name = "TableLayoutPanel8";
            TableLayoutPanel8.RowCount = 1;
            TableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel8.Size = new Size(1000, 524);
            TableLayoutPanel8.TabIndex = 3;
            // 
            // TableLayoutPanel10
            // 
            TableLayoutPanel10.ColumnCount = 1;
            TableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel10.Controls.Add(Panel20, 0, 0);
            TableLayoutPanel10.Controls.Add(Panel22, 0, 1);
            TableLayoutPanel10.Controls.Add(Tab3StatusStrip, 0, 2);
            TableLayoutPanel10.Dock = DockStyle.Fill;
            TableLayoutPanel10.Location = new Point(3, 3);
            TableLayoutPanel10.Name = "TableLayoutPanel10";
            TableLayoutPanel10.RowCount = 3;
            TableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 56.80473f));
            TableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 43.19527f));
            TableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 19.0f));
            TableLayoutPanel10.Size = new Size(461, 518);
            TableLayoutPanel10.TabIndex = 0;
            // 
            // Panel20
            // 
            Panel20.BackColor = Color.Silver;
            Panel20.BorderStyle = BorderStyle.Fixed3D;
            Panel20.Controls.Add(Tab3DeleteRowButton);
            Panel20.Controls.Add(Tab3InsertRowButton);
            Panel20.Controls.Add(Label71);
            Panel20.Controls.Add(Tab3ChannelNotes);
            Panel20.Controls.Add(Panel21);
            Panel20.Controls.Add(Label55);
            Panel20.Controls.Add(Tab3SetChannelButtone);
            Panel20.Controls.Add(Label56);
            Panel20.Controls.Add(Label57);
            Panel20.Controls.Add(Tab3ClearChannelList);
            Panel20.Controls.Add(Label58);
            Panel20.Controls.Add(Label59);
            Panel20.Controls.Add(Tab3ChannelTextBox);
            Panel20.Controls.Add(Label60);
            Panel20.Controls.Add(Label61);
            Panel20.Controls.Add(Tab3ToneComboBox);
            Panel20.Controls.Add(Tab3RepeaterComboBox);
            Panel20.Controls.Add(Tab3KHzCombBox);
            Panel20.Controls.Add(Tab3MHzComboBox);
            Panel20.Controls.Add(Tab3MenuStrip);
            Panel20.Dock = DockStyle.Fill;
            Panel20.Location = new Point(3, 3);
            Panel20.Name = "Panel20";
            Panel20.Size = new Size(455, 277);
            Panel20.TabIndex = 0;
            // 
            // Tab3DeleteRowButton
            // 
            Tab3DeleteRowButton.Location = new Point(268, 243);
            Tab3DeleteRowButton.Name = "Tab3DeleteRowButton";
            Tab3DeleteRowButton.Size = new Size(139, 23);
            Tab3DeleteRowButton.TabIndex = 22;
            Tab3DeleteRowButton.Text = "Delete Row";
            Tab3DeleteRowButton.UseVisualStyleBackColor = true;
            // 
            // Tab3InsertRowButton
            // 
            Tab3InsertRowButton.Location = new Point(268, 214);
            Tab3InsertRowButton.Name = "Tab3InsertRowButton";
            Tab3InsertRowButton.Size = new Size(140, 23);
            Tab3InsertRowButton.TabIndex = 21;
            Tab3InsertRowButton.Text = "Insert Row";
            Tab3InsertRowButton.UseVisualStyleBackColor = true;
            // 
            // Label71
            // 
            Label71.AutoSize = true;
            Label71.Location = new Point(7, 103);
            Label71.Name = "Label71";
            Label71.Size = new Size(155, 25);
            Label71.TabIndex = 20;
            Label71.Text = "Channel Notes";
            // 
            // Tab3ChannelNotes
            // 
            Tab3ChannelNotes.Location = new Point(7, 122);
            Tab3ChannelNotes.MaxLength = 10;
            Tab3ChannelNotes.Name = "Tab3ChannelNotes";
            Tab3ChannelNotes.Size = new Size(335, 30);
            Tab3ChannelNotes.TabIndex = 19;
            // 
            // Panel21
            // 
            Panel21.Controls.Add(Tab3CtcssOff);
            Panel21.Controls.Add(Tab3CtcssXmit);
            Panel21.Controls.Add(Tab3CtcssXmitRec);
            Panel21.Location = new Point(348, 76);
            Panel21.Name = "Panel21";
            Panel21.Size = new Size(100, 72);
            Panel21.TabIndex = 16;
            // 
            // Tab3CtcssOff
            // 
            Tab3CtcssOff.AutoSize = true;
            Tab3CtcssOff.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab3CtcssOff.Location = new Point(9, 46);
            Tab3CtcssOff.Name = "Tab3CtcssOff";
            Tab3CtcssOff.Size = new Size(66, 29);
            Tab3CtcssOff.TabIndex = 17;
            Tab3CtcssOff.TabStop = true;
            Tab3CtcssOff.Text = "Off";
            Tab3CtcssOff.UseVisualStyleBackColor = true;
            // 
            // Tab3CtcssXmit
            // 
            Tab3CtcssXmit.AutoSize = true;
            Tab3CtcssXmit.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab3CtcssXmit.Location = new Point(9, 5);
            Tab3CtcssXmit.Name = "Tab3CtcssXmit";
            Tab3CtcssXmit.Size = new Size(80, 29);
            Tab3CtcssXmit.TabIndex = 14;
            Tab3CtcssXmit.TabStop = true;
            Tab3CtcssXmit.Text = "Xmit";
            Tab3CtcssXmit.UseVisualStyleBackColor = true;
            // 
            // Tab3CtcssXmitRec
            // 
            Tab3CtcssXmitRec.AutoSize = true;
            Tab3CtcssXmitRec.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab3CtcssXmitRec.Location = new Point(9, 26);
            Tab3CtcssXmitRec.Name = "Tab3CtcssXmitRec";
            Tab3CtcssXmitRec.Size = new Size(124, 29);
            Tab3CtcssXmitRec.TabIndex = 15;
            Tab3CtcssXmitRec.TabStop = true;
            Tab3CtcssXmitRec.Text = "Xmit/Rec";
            Tab3CtcssXmitRec.UseVisualStyleBackColor = true;
            // 
            // Label55
            // 
            Label55.AutoSize = true;
            Label55.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label55.Location = new Point(359, 60);
            Label55.Name = "Label55";
            Label55.Size = new Size(88, 25);
            Label55.TabIndex = 13;
            Label55.Text = "CTCSS";
            // 
            // Tab3SetChannelButtone
            // 
            Tab3SetChannelButtone.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab3SetChannelButtone.Location = new Point(268, 154);
            Tab3SetChannelButtone.Name = "Tab3SetChannelButtone";
            Tab3SetChannelButtone.Size = new Size(140, 48);
            Tab3SetChannelButtone.TabIndex = 11;
            Tab3SetChannelButtone.Text = "Set/Update Channel";
            Tab3SetChannelButtone.UseVisualStyleBackColor = true;
            // 
            // Label56
            // 
            Label56.AutoSize = true;
            Label56.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label56.Location = new Point(115, 24);
            Label56.Name = "Label56";
            Label56.Size = new Size(276, 37);
            Label56.TabIndex = 10;
            Label56.Text = "Channel Settings";
            // 
            // Label57
            // 
            Label57.AutoSize = true;
            Label57.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label57.Location = new Point(294, 60);
            Label57.Name = "Label57";
            Label57.Size = new Size(62, 25);
            Label57.TabIndex = 9;
            Label57.Text = "Tone";
            // 
            // Tab3ClearChannelList
            // 
            Tab3ClearChannelList.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab3ClearChannelList.Location = new Point(138, 209);
            Tab3ClearChannelList.Name = "Tab3ClearChannelList";
            Tab3ClearChannelList.Size = new Size(111, 43);
            Tab3ClearChannelList.TabIndex = 12;
            Tab3ClearChannelList.Text = "Clear Channel List";
            Tab3ClearChannelList.UseVisualStyleBackColor = true;
            // 
            // Label58
            // 
            Label58.AutoSize = true;
            Label58.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label58.Location = new Point(207, 60);
            Label58.Name = "Label58";
            Label58.Size = new Size(99, 25);
            Label58.TabIndex = 8;
            Label58.Text = "Repeater";
            // 
            // Label59
            // 
            Label59.AutoSize = true;
            Label59.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label59.Location = new Point(146, 60);
            Label59.Name = "Label59";
            Label59.Size = new Size(53, 25);
            Label59.TabIndex = 7;
            Label59.Text = "KHz";
            // 
            // Tab3ChannelTextBox
            // 
            Tab3ChannelTextBox.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab3ChannelTextBox.Location = new Point(7, 77);
            Tab3ChannelTextBox.Name = "Tab3ChannelTextBox";
            Tab3ChannelTextBox.ReadOnly = true;
            Tab3ChannelTextBox.Size = new Size(46, 28);
            Tab3ChannelTextBox.TabIndex = 6;
            // 
            // Label60
            // 
            Label60.AutoSize = true;
            Label60.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label60.Location = new Point(7, 61);
            Label60.Name = "Label60";
            Label60.Size = new Size(61, 25);
            Label60.TabIndex = 5;
            Label60.Text = "CH #";
            // 
            // Label61
            // 
            Label61.AutoSize = true;
            Label61.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label61.Location = new Point(75, 60);
            Label61.Name = "Label61";
            Label61.Size = new Size(56, 25);
            Label61.TabIndex = 4;
            Label61.Text = "MHz";
            // 
            // Tab3ToneComboBox
            // 
            Tab3ToneComboBox.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab3ToneComboBox.FormattingEnabled = true;
            Tab3ToneComboBox.Items.AddRange(new object[] { "OFF", "67.0", "71.9", "74.4", "77.0", "79.7", "82.5", "85.4", "88.5", "91.5", "94.8", "97.4", "100.0", "103.5", "107.2", "110.9", "114.8", "118.8", "123.0", "127.3", "131.8", "136.5", "141.3", "146.2", "151.4", "156.7", "162.2", "167.9", "173.8", "179.9", "186.2", "192.8", "203.5", "210.7", "218.1", "225.7", "233.6", "241.8", "250.3" });
            Tab3ToneComboBox.Location = new Point(291, 76);
            Tab3ToneComboBox.Name = "Tab3ToneComboBox";
            Tab3ToneComboBox.Size = new Size(58, 30);
            Tab3ToneComboBox.TabIndex = 3;
            // 
            // Tab3RepeaterComboBox
            // 
            Tab3RepeaterComboBox.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab3RepeaterComboBox.FormattingEnabled = true;
            Tab3RepeaterComboBox.Items.AddRange(new object[] { "PLUS", "MINUS", "SIMPLEX" });
            Tab3RepeaterComboBox.Location = new Point(204, 76);
            Tab3RepeaterComboBox.Name = "Tab3RepeaterComboBox";
            Tab3RepeaterComboBox.Size = new Size(83, 30);
            Tab3RepeaterComboBox.TabIndex = 2;
            // 
            // Tab3KHzCombBox
            // 
            Tab3KHzCombBox.DropDownWidth = 43;
            Tab3KHzCombBox.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab3KHzCombBox.FormattingEnabled = true;
            Tab3KHzCombBox.Items.AddRange(new object[] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "110", "120", "130", "140", "150", "160", "170", "180", "190", "200", "210", "220", "230", "240", "250", "260", "270", "280", "290", "300", "310", "320", "330", "340", "350", "360", "370", "380", "390", "400", "410", "420", "430", "440", "450", "460", "470", "480", "490", "500", "510", "520", "530", "540", "550", "560", "570", "580", "590", "600", "610", "620", "630", "640", "650", "660", "670", "680", "690", "700", "710", "720", "730", "740", "750", "760", "770", "780", "790", "800", "810", "820", "830", "840", "850", "860", "870", "880", "890", "900", "910", "920", "930", "940", "950", "960", "970", "980", "990" });
            Tab3KHzCombBox.Location = new Point(134, 76);
            Tab3KHzCombBox.MaxDropDownItems = 10;
            Tab3KHzCombBox.Name = "Tab3KHzCombBox";
            Tab3KHzCombBox.Size = new Size(66, 30);
            Tab3KHzCombBox.TabIndex = 1;
            // 
            // Tab3MHzComboBox
            // 
            Tab3MHzComboBox.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab3MHzComboBox.FormattingEnabled = true;
            Tab3MHzComboBox.Items.AddRange(new object[] { "BLANK", "146", "147", "148", "149", "150" });
            Tab3MHzComboBox.Location = new Point(60, 76);
            Tab3MHzComboBox.Name = "Tab3MHzComboBox";
            Tab3MHzComboBox.Size = new Size(70, 30);
            Tab3MHzComboBox.TabIndex = 0;
            // 
            // Tab3MenuStrip
            // 
            Tab3MenuStrip.GripMargin = new Padding(2, 2, 0, 2);
            Tab3MenuStrip.ImageScalingSize = new Size(24, 24);
            Tab3MenuStrip.Items.AddRange(new ToolStripItem[] { Tab3FileToolStripMenuItem, Tab3SettingsToolStripMenuItem });
            Tab3MenuStrip.Location = new Point(0, 0);
            Tab3MenuStrip.Name = "Tab3MenuStrip";
            Tab3MenuStrip.Size = new Size(451, 33);
            Tab3MenuStrip.TabIndex = 17;
            Tab3MenuStrip.Text = "MenuStrip1";
            // 
            // Tab3FileToolStripMenuItem
            // 
            Tab3FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Tab3OpenChannelFileToolStripMenuItem, Tab3SaveChannelFileToolStripMenuItem });
            Tab3FileToolStripMenuItem.Font = new Font("Segoe UI", 9.0f, FontStyle.Bold);
            Tab3FileToolStripMenuItem.Name = "Tab3FileToolStripMenuItem";
            Tab3FileToolStripMenuItem.Size = new Size(57, 29);
            Tab3FileToolStripMenuItem.Text = "File";
            // 
            // Tab3OpenChannelFileToolStripMenuItem
            // 
            Tab3OpenChannelFileToolStripMenuItem.Name = "Tab3OpenChannelFileToolStripMenuItem";
            Tab3OpenChannelFileToolStripMenuItem.Size = new Size(268, 34);
            Tab3OpenChannelFileToolStripMenuItem.Text = "Open Channel File";
            // 
            // Tab3SaveChannelFileToolStripMenuItem
            // 
            Tab3SaveChannelFileToolStripMenuItem.Name = "Tab3SaveChannelFileToolStripMenuItem";
            Tab3SaveChannelFileToolStripMenuItem.Size = new Size(268, 34);
            Tab3SaveChannelFileToolStripMenuItem.Text = "Save Channel File";
            // 
            // Tab3SettingsToolStripMenuItem
            // 
            Tab3SettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Tab3BackToMainMenuToolStripMenuItem, Tab3KHzStepSizeToolStripMenuItem });
            Tab3SettingsToolStripMenuItem.Font = new Font("Segoe UI", 9.0f, FontStyle.Bold);
            Tab3SettingsToolStripMenuItem.Name = "Tab3SettingsToolStripMenuItem";
            Tab3SettingsToolStripMenuItem.Size = new Size(95, 29);
            Tab3SettingsToolStripMenuItem.Text = "Options";
            // 
            // Tab3BackToMainMenuToolStripMenuItem
            // 
            Tab3BackToMainMenuToolStripMenuItem.Name = "Tab3BackToMainMenuToolStripMenuItem";
            Tab3BackToMainMenuToolStripMenuItem.Size = new Size(280, 34);
            Tab3BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu";
            // 
            // Tab3KHzStepSizeToolStripMenuItem
            // 
            Tab3KHzStepSizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Tab3KHzToolStripComboBox });
            Tab3KHzStepSizeToolStripMenuItem.Name = "Tab3KHzStepSizeToolStripMenuItem";
            Tab3KHzStepSizeToolStripMenuItem.Size = new Size(280, 34);
            Tab3KHzStepSizeToolStripMenuItem.Text = "kHz Step Size";
            // 
            // Tab3KHzToolStripComboBox
            // 
            Tab3KHzToolStripComboBox.Items.AddRange(new object[] { "10", "12.5", "5", "25" });
            Tab3KHzToolStripComboBox.Name = "Tab3KHzToolStripComboBox";
            Tab3KHzToolStripComboBox.Size = new Size(121, 33);
            // 
            // Panel22
            // 
            Panel22.BackColor = Color.Silver;
            Panel22.BorderStyle = BorderStyle.Fixed3D;
            Panel22.Controls.Add(tab3ChannelFileName);
            Panel22.Controls.Add(Label36);
            Panel22.Controls.Add(Tab3StopProgramButton);
            Panel22.Controls.Add(Tab3UsbRcvdLabel);
            Panel22.Controls.Add(Label74);
            Panel22.Controls.Add(Tab3UsbCmdLabel);
            Panel22.Controls.Add(Label69);
            Panel22.Controls.Add(Tab3ComPortTextBox);
            Panel22.Controls.Add(Label64);
            Panel22.Controls.Add(Tab3ProgressBar1);
            Panel22.Controls.Add(Tab3ProgramButton);
            Panel22.Dock = DockStyle.Fill;
            Panel22.Location = new Point(3, 286);
            Panel22.Name = "Panel22";
            Panel22.Size = new Size(455, 209);
            Panel22.TabIndex = 1;
            // 
            // tab3ChannelFileName
            // 
            tab3ChannelFileName.BorderStyle = BorderStyle.Fixed3D;
            tab3ChannelFileName.Font = new Font("Microsoft Sans Serif", 8.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            tab3ChannelFileName.Location = new Point(149, 173);
            tab3ChannelFileName.Name = "tab3ChannelFileName";
            tab3ChannelFileName.Size = new Size(298, 25);
            tab3ChannelFileName.TabIndex = 27;
            tab3ChannelFileName.TextAlign = ContentAlignment.MiddleLeft;
            tab3ChannelFileName.Visible = false;
            // 
            // Label36
            // 
            Label36.AutoSize = true;
            Label36.Location = new Point(11, 177);
            Label36.Name = "Label36";
            Label36.Size = new Size(187, 25);
            Label36.TabIndex = 26;
            Label36.Text = "Channel Filename";
            Label36.Visible = false;
            // 
            // Tab3StopProgramButton
            // 
            Tab3StopProgramButton.Location = new Point(45, 50);
            Tab3StopProgramButton.Name = "Tab3StopProgramButton";
            Tab3StopProgramButton.Size = new Size(117, 44);
            Tab3StopProgramButton.TabIndex = 25;
            Tab3StopProgramButton.Text = "Stop Programming";
            Tab3StopProgramButton.UseVisualStyleBackColor = true;
            // 
            // Tab3UsbRcvdLabel
            // 
            Tab3UsbRcvdLabel.BorderStyle = BorderStyle.Fixed3D;
            Tab3UsbRcvdLabel.Location = new Point(352, 134);
            Tab3UsbRcvdLabel.Name = "Tab3UsbRcvdLabel";
            Tab3UsbRcvdLabel.Size = new Size(96, 25);
            Tab3UsbRcvdLabel.TabIndex = 24;
            Tab3UsbRcvdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label74
            // 
            Label74.AutoSize = true;
            Label74.Location = new Point(277, 138);
            Label74.Name = "Label74";
            Label74.Size = new Size(94, 25);
            Label74.TabIndex = 23;
            Label74.Text = "received";
            // 
            // Tab3UsbCmdLabel
            // 
            Tab3UsbCmdLabel.BorderStyle = BorderStyle.Fixed3D;
            Tab3UsbCmdLabel.Location = new Point(168, 134);
            Tab3UsbCmdLabel.Name = "Tab3UsbCmdLabel";
            Tab3UsbCmdLabel.Size = new Size(96, 25);
            Tab3UsbCmdLabel.TabIndex = 22;
            Tab3UsbCmdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label69
            // 
            Label69.Location = new Point(10, 134);
            Label69.Name = "Label69";
            Label69.Size = new Size(231, 25);
            Label69.TabIndex = 21;
            Label69.Text = "Serial command sent";
            Label69.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab3ComPortTextBox
            // 
            Tab3ComPortTextBox.Enabled = false;
            Tab3ComPortTextBox.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab3ComPortTextBox.Location = new Point(347, 13);
            Tab3ComPortTextBox.Multiline = true;
            Tab3ComPortTextBox.Name = "Tab3ComPortTextBox";
            Tab3ComPortTextBox.Size = new Size(87, 80);
            Tab3ComPortTextBox.TabIndex = 20;
            Tab3ComPortTextBox.Text = "test1";
            Tab3ComPortTextBox.TextAlign = HorizontalAlignment.Center;
            Tab3ComPortTextBox.Visible = false;
            // 
            // Label64
            // 
            Label64.AutoSize = true;
            Label64.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label64.Location = new Point(80, 10);
            Label64.Name = "Label64";
            Label64.Size = new Size(320, 37);
            Label64.TabIndex = 11;
            Label64.Text = "Radio Programming";
            // 
            // Tab3ProgressBar1
            // 
            Tab3ProgressBar1.Location = new Point(53, 108);
            Tab3ProgressBar1.Name = "Tab3ProgressBar1";
            Tab3ProgressBar1.Size = new Size(335, 16);
            Tab3ProgressBar1.TabIndex = 1;
            // 
            // Tab3ProgramButton
            // 
            Tab3ProgramButton.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab3ProgramButton.Location = new Point(215, 50);
            Tab3ProgramButton.Name = "Tab3ProgramButton";
            Tab3ProgramButton.Size = new Size(98, 44);
            Tab3ProgramButton.TabIndex = 0;
            Tab3ProgramButton.Text = "Program Radio Channels";
            Tab3ProgramButton.UseVisualStyleBackColor = true;
            // 
            // Tab3StatusStrip
            // 
            Tab3StatusStrip.ImageScalingSize = new Size(24, 24);
            Tab3StatusStrip.Items.AddRange(new ToolStripItem[] { Tab3ToolStripStepSize, Tab3ToolStripStatusLabel });
            Tab3StatusStrip.Location = new Point(0, 498);
            Tab3StatusStrip.Name = "Tab3StatusStrip";
            Tab3StatusStrip.Size = new Size(461, 20);
            Tab3StatusStrip.TabIndex = 2;
            Tab3StatusStrip.Text = "StatusStrip1";
            // 
            // Tab3ToolStripStepSize
            // 
            Tab3ToolStripStepSize.Name = "Tab3ToolStripStepSize";
            Tab3ToolStripStepSize.Size = new Size(180, 13);
            Tab3ToolStripStepSize.Text = "ToolStripStatusLabel1";
            // 
            // Tab3ToolStripStatusLabel
            // 
            Tab3ToolStripStatusLabel.Font = new Font("Segoe UI", 9.0f, FontStyle.Bold);
            Tab3ToolStripStatusLabel.Name = "Tab3ToolStripStatusLabel";
            Tab3ToolStripStatusLabel.Size = new Size(196, 13);
            Tab3ToolStripStatusLabel.Text = "ToolStripStatusLabel2";
            // 
            // Panel23
            // 
            Panel23.BackColor = Color.Silver;
            Panel23.BorderStyle = BorderStyle.Fixed3D;
            Panel23.Controls.Add(Tab3ChannelListView);
            Panel23.Controls.Add(Label65);
            Panel23.Dock = DockStyle.Fill;
            Panel23.Location = new Point(470, 3);
            Panel23.Name = "Panel23";
            Panel23.Size = new Size(527, 518);
            Panel23.TabIndex = 1;
            // 
            // Tab3ChannelListView
            // 
            Tab3ChannelListView.Columns.AddRange(new ColumnHeader[] { ColumnHeader21, ColumnHeader22, ColumnHeader23, ColumnHeader24, ColumnHeader25, ColumnHeader28 });
            Tab3ChannelListView.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab3ChannelListView.FullRowSelect = true;
            Tab3ChannelListView.GridLines = true;
            Tab3ChannelListView.HideSelection = false;
            Tab3ChannelListView.Location = new Point(0, 34);
            Tab3ChannelListView.MultiSelect = false;
            Tab3ChannelListView.Name = "Tab3ChannelListView";
            Tab3ChannelListView.Size = new Size(523, 463);
            Tab3ChannelListView.TabIndex = 12;
            Tab3ChannelListView.UseCompatibleStateImageBehavior = false;
            Tab3ChannelListView.View = View.Details;
            // 
            // ColumnHeader21
            // 
            ColumnHeader21.Text = "CH#";
            ColumnHeader21.Width = 42;
            // 
            // ColumnHeader22
            // 
            ColumnHeader22.Text = "Frequency";
            ColumnHeader22.TextAlign = HorizontalAlignment.Center;
            ColumnHeader22.Width = 91;
            // 
            // ColumnHeader23
            // 
            ColumnHeader23.Text = "Repeater";
            ColumnHeader23.TextAlign = HorizontalAlignment.Center;
            ColumnHeader23.Width = 81;
            // 
            // ColumnHeader24
            // 
            ColumnHeader24.Text = "Tone";
            ColumnHeader24.TextAlign = HorizontalAlignment.Center;
            ColumnHeader24.Width = 50;
            // 
            // ColumnHeader25
            // 
            ColumnHeader25.Text = " CTCSS";
            ColumnHeader25.TextAlign = HorizontalAlignment.Center;
            ColumnHeader25.Width = 80;
            // 
            // ColumnHeader28
            // 
            ColumnHeader28.Text = "Notes";
            ColumnHeader28.Width = 375;
            // 
            // Label65
            // 
            Label65.AutoSize = true;
            Label65.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label65.Location = new Point(176, 10);
            Label65.Name = "Label65";
            Label65.Size = new Size(207, 37);
            Label65.TabIndex = 11;
            Label65.Text = "Channel List";
            // 
            // SerialPort1
            // 
            SerialPort1.PortName = "COM3";
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.05068f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.94932f));
            TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 0, 0);
            TableLayoutPanel1.Controls.Add(Panel7, 1, 0);
            TableLayoutPanel1.Dock = DockStyle.Fill;
            TableLayoutPanel1.Location = new Point(3, 3);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new Size(838, 476);
            TableLayoutPanel1.TabIndex = 1;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.ColumnCount = 1;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel3.Controls.Add(Panel4, 0, 0);
            TableLayoutPanel3.Controls.Add(Panel6, 0, 1);
            TableLayoutPanel3.Dock = DockStyle.Fill;
            TableLayoutPanel3.Location = new Point(3, 3);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 3;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 53.25077f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 46.74923f));
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 154.0f));
            TableLayoutPanel3.Size = new Size(421, 470);
            TableLayoutPanel3.TabIndex = 0;
            // 
            // Panel4
            // 
            Panel4.BackColor = Color.Silver;
            Panel4.BorderStyle = BorderStyle.Fixed3D;
            Panel4.Controls.Add(Panel5);
            Panel4.Controls.Add(Label11);
            Panel4.Controls.Add(Button1);
            Panel4.Controls.Add(Label12);
            Panel4.Controls.Add(Label13);
            Panel4.Controls.Add(Label14);
            Panel4.Controls.Add(Label15);
            Panel4.Controls.Add(TextBox1);
            Panel4.Controls.Add(Label16);
            Panel4.Controls.Add(Label17);
            Panel4.Controls.Add(ComboBox1);
            Panel4.Controls.Add(ComboBox2);
            Panel4.Controls.Add(ComboBox3);
            Panel4.Controls.Add(ComboBox4);
            Panel4.Dock = DockStyle.Fill;
            Panel4.Location = new Point(3, 3);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(415, 162);
            Panel4.TabIndex = 0;
            // 
            // Panel5
            // 
            Panel5.Controls.Add(RadioButton1);
            Panel5.Controls.Add(RadioButton2);
            Panel5.Location = new Point(321, 76);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(90, 44);
            Panel5.TabIndex = 16;
            // 
            // RadioButton1
            // 
            RadioButton1.AutoSize = true;
            RadioButton1.Location = new Point(4, 5);
            RadioButton1.Name = "RadioButton1";
            RadioButton1.Size = new Size(66, 24);
            RadioButton1.TabIndex = 14;
            RadioButton1.TabStop = true;
            RadioButton1.Text = "Xmit";
            RadioButton1.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            RadioButton2.AutoSize = true;
            RadioButton2.Location = new Point(4, 23);
            RadioButton2.Name = "RadioButton2";
            RadioButton2.Size = new Size(99, 24);
            RadioButton2.TabIndex = 15;
            RadioButton2.TabStop = true;
            RadioButton2.Text = "Xmit/Rec";
            RadioButton2.UseVisualStyleBackColor = true;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label11.Location = new Point(324, 60);
            Label11.Name = "Label11";
            Label11.Size = new Size(65, 20);
            Label11.TabIndex = 13;
            Label11.Text = "CTCSS";
            // 
            // Button1
            // 
            Button1.Location = new Point(268, 136);
            Button1.Name = "Button1";
            Button1.Size = new Size(140, 23);
            Button1.TabIndex = 11;
            Button1.Text = "Set/Update Channel";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label12.Location = new Point(73, 24);
            Label12.Name = "Label12";
            Label12.Size = new Size(276, 37);
            Label12.TabIndex = 10;
            Label12.Text = "Channel Settings";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Location = new Point(273, 60);
            Label13.Name = "Label13";
            Label13.Size = new Size(45, 20);
            Label13.TabIndex = 9;
            Label13.Text = "Tone";
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Location = new Point(187, 60);
            Label14.Name = "Label14";
            Label14.Size = new Size(76, 20);
            Label14.TabIndex = 8;
            Label14.Text = "Repeater";
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Location = new Point(129, 60);
            Label15.Name = "Label15";
            Label15.Size = new Size(39, 20);
            Label15.TabIndex = 7;
            Label15.Text = "KHz";
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(9, 79);
            TextBox1.Name = "TextBox1";
            TextBox1.ReadOnly = true;
            TextBox1.Size = new Size(50, 26);
            TextBox1.TabIndex = 6;
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Location = new Point(13, 62);
            Label16.Name = "Label16";
            Label16.Size = new Size(68, 20);
            Label16.TabIndex = 5;
            Label16.Text = "Channel";
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Location = new Point(75, 62);
            Label17.Name = "Label17";
            Label17.Size = new Size(42, 20);
            Label17.TabIndex = 4;
            Label17.Text = "MHz";
            // 
            // ComboBox1
            // 
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Items.AddRange(new object[] { "OFF", "67.0", "71.9", "74.4", "77.0", "79.7", "82.5", "85.4", "88.5", "91.5", "94.8", "97.4", "100.0", "103.5", "107.2", "110.9", "114.8", "118.8", "123.0", "127.3", "131.8", "136.5", "141.3", "146.2", "151.4", "156.7", "162.2", "167.9", "173.8", "179.9", "186.2", "192.8", "203.5", "210.7", "218.1", "225.7", "233.6", "241.8", "250.3" });
            ComboBox1.Location = new Point(265, 76);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new Size(50, 28);
            ComboBox1.TabIndex = 3;
            // 
            // ComboBox2
            // 
            ComboBox2.FormattingEnabled = true;
            ComboBox2.Items.AddRange(new object[] { "PLUS", "MINUS", "SIMPLEX" });
            ComboBox2.Location = new Point(184, 76);
            ComboBox2.Name = "ComboBox2";
            ComboBox2.Size = new Size(75, 28);
            ComboBox2.TabIndex = 2;
            // 
            // ComboBox3
            // 
            ComboBox3.DropDownWidth = 43;
            ComboBox3.FormattingEnabled = true;
            ComboBox3.Items.AddRange(new object[] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "110", "120", "130", "140", "150", "160", "170", "180", "190", "200", "210", "220", "230", "240", "250", "260", "270", "280", "290", "300", "310", "320", "330", "340", "350", "360", "370", "380", "390", "400", "410", "420", "430", "440", "450", "460", "470", "480", "490", "500", "510", "520", "530", "540", "550", "560", "570", "580", "590", "600", "610", "620", "630", "640", "650", "660", "670", "680", "690", "700", "710", "720", "730", "740", "750", "760", "770", "780", "790", "800", "810", "820", "830", "840", "850", "860", "870", "880", "890", "900", "910", "920", "930", "940", "950", "960", "970", "980", "990" });
            ComboBox3.Location = new Point(128, 77);
            ComboBox3.MaxDropDownItems = 10;
            ComboBox3.Name = "ComboBox3";
            ComboBox3.Size = new Size(50, 28);
            ComboBox3.TabIndex = 1;
            // 
            // ComboBox4
            // 
            ComboBox4.FormattingEnabled = true;
            ComboBox4.Items.AddRange(new object[] { "BLANK", "146", "147", "148", "149", "150" });
            ComboBox4.Location = new Point(65, 78);
            ComboBox4.Name = "ComboBox4";
            ComboBox4.Size = new Size(57, 28);
            ComboBox4.TabIndex = 0;
            // 
            // Panel6
            // 
            Panel6.BackColor = Color.Silver;
            Panel6.BorderStyle = BorderStyle.Fixed3D;
            Panel6.Controls.Add(Label18);
            Panel6.Controls.Add(NumericUpDown1);
            Panel6.Controls.Add(Label19);
            Panel6.Controls.Add(NumericUpDown2);
            Panel6.Controls.Add(Button2);
            Panel6.Controls.Add(Label20);
            Panel6.Controls.Add(ProgressBar1);
            Panel6.Controls.Add(Button3);
            Panel6.Dock = DockStyle.Fill;
            Panel6.Location = new Point(3, 171);
            Panel6.Name = "Panel6";
            Panel6.Size = new Size(415, 141);
            Panel6.TabIndex = 1;
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.Location = new Point(9, 42);
            Label18.Name = "Label18";
            Label18.Size = new Size(101, 20);
            Label18.TabIndex = 18;
            Label18.Text = "Button in mS";
            // 
            // NumericUpDown1
            // 
            NumericUpDown1.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            NumericUpDown1.Location = new Point(9, 57);
            NumericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NumericUpDown1.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            NumericUpDown1.Name = "NumericUpDown1";
            NumericUpDown1.Size = new Size(55, 26);
            NumericUpDown1.TabIndex = 17;
            NumericUpDown1.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // Label19
            // 
            Label19.AutoSize = true;
            Label19.Location = new Point(9, 4);
            Label19.Name = "Label19";
            Label19.Size = new Size(89, 20);
            Label19.TabIndex = 16;
            Label19.Text = "Tone in mS";
            // 
            // NumericUpDown2
            // 
            NumericUpDown2.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            NumericUpDown2.Location = new Point(9, 19);
            NumericUpDown2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NumericUpDown2.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            NumericUpDown2.Name = "NumericUpDown2";
            NumericUpDown2.Size = new Size(55, 26);
            NumericUpDown2.TabIndex = 15;
            NumericUpDown2.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // Button2
            // 
            Button2.Location = new Point(78, 56);
            Button2.Name = "Button2";
            Button2.Size = new Size(100, 37);
            Button2.TabIndex = 12;
            Button2.Text = "Clear Channel List";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Label20
            // 
            Label20.AutoSize = true;
            Label20.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label20.Location = new Point(73, 13);
            Label20.Name = "Label20";
            Label20.Size = new Size(358, 37);
            Label20.TabIndex = 11;
            Label20.Text = "Channel Programming";
            // 
            // ProgressBar1
            // 
            ProgressBar1.Location = new Point(31, 108);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(335, 16);
            ProgressBar1.TabIndex = 1;
            // 
            // Button3
            // 
            Button3.Location = new Point(220, 56);
            Button3.Name = "Button3";
            Button3.Size = new Size(95, 37);
            Button3.TabIndex = 0;
            Button3.Text = "Program Radio Channels";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Panel7
            // 
            Panel7.BackColor = Color.Silver;
            Panel7.BorderStyle = BorderStyle.Fixed3D;
            Panel7.Controls.Add(ListView1);
            Panel7.Controls.Add(Label21);
            Panel7.Dock = DockStyle.Fill;
            Panel7.Location = new Point(430, 3);
            Panel7.Name = "Panel7";
            Panel7.Size = new Size(405, 470);
            Panel7.TabIndex = 1;
            // 
            // ListView1
            // 
            ListView1.Columns.AddRange(new ColumnHeader[] { ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5 });
            ListView1.FullRowSelect = true;
            ListView1.GridLines = true;
            ListView1.HideSelection = false;
            ListView1.Location = new Point(0, 49);
            ListView1.MultiSelect = false;
            ListView1.Name = "ListView1";
            ListView1.Size = new Size(389, 377);
            ListView1.TabIndex = 12;
            ListView1.UseCompatibleStateImageBehavior = false;
            ListView1.View = View.Details;
            // 
            // ColumnHeader1
            // 
            ColumnHeader1.Text = "Channel";
            ColumnHeader1.Width = 64;
            // 
            // ColumnHeader2
            // 
            ColumnHeader2.Text = "Frequency";
            ColumnHeader2.Width = 81;
            // 
            // ColumnHeader3
            // 
            ColumnHeader3.Text = "Repeater Mode";
            ColumnHeader3.Width = 105;
            // 
            // ColumnHeader4
            // 
            ColumnHeader4.Text = "Tone";
            ColumnHeader4.Width = 76;
            // 
            // ColumnHeader5
            // 
            ColumnHeader5.Text = " CTSS";
            // 
            // Label21
            // 
            Label21.AutoSize = true;
            Label21.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label21.Location = new Point(109, 10);
            Label21.Name = "Label21";
            Label21.Size = new Size(207, 37);
            Label21.TabIndex = 11;
            Label21.Text = "Channel List";
            // 
            // Panel9
            // 
            Panel9.BackColor = Color.Silver;
            Panel9.BorderStyle = BorderStyle.Fixed3D;
            Panel9.Controls.Add(Panel10);
            Panel9.Controls.Add(Label26);
            Panel9.Controls.Add(Button5);
            Panel9.Controls.Add(Label27);
            Panel9.Controls.Add(Label28);
            Panel9.Controls.Add(Label29);
            Panel9.Controls.Add(Label30);
            Panel9.Controls.Add(TextBox2);
            Panel9.Controls.Add(Label31);
            Panel9.Controls.Add(Label32);
            Panel9.Controls.Add(ComboBox5);
            Panel9.Controls.Add(ComboBox6);
            Panel9.Controls.Add(ComboBox7);
            Panel9.Controls.Add(ComboBox8);
            Panel9.Dock = DockStyle.Fill;
            Panel9.Location = new Point(3, 3);
            Panel9.Name = "Panel9";
            Panel9.Size = new Size(415, 162);
            Panel9.TabIndex = 0;
            // 
            // Panel10
            // 
            Panel10.Controls.Add(RadioButton5);
            Panel10.Controls.Add(RadioButton6);
            Panel10.Location = new Point(321, 76);
            Panel10.Name = "Panel10";
            Panel10.Size = new Size(90, 44);
            Panel10.TabIndex = 16;
            // 
            // RadioButton5
            // 
            RadioButton5.AutoSize = true;
            RadioButton5.Location = new Point(4, 5);
            RadioButton5.Name = "RadioButton5";
            RadioButton5.Size = new Size(66, 24);
            RadioButton5.TabIndex = 14;
            RadioButton5.TabStop = true;
            RadioButton5.Text = "Xmit";
            RadioButton5.UseVisualStyleBackColor = true;
            // 
            // RadioButton6
            // 
            RadioButton6.AutoSize = true;
            RadioButton6.Location = new Point(4, 23);
            RadioButton6.Name = "RadioButton6";
            RadioButton6.Size = new Size(99, 24);
            RadioButton6.TabIndex = 15;
            RadioButton6.TabStop = true;
            RadioButton6.Text = "Xmit/Rec";
            RadioButton6.UseVisualStyleBackColor = true;
            // 
            // Label26
            // 
            Label26.AutoSize = true;
            Label26.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label26.Location = new Point(324, 60);
            Label26.Name = "Label26";
            Label26.Size = new Size(65, 20);
            Label26.TabIndex = 13;
            Label26.Text = "CTCSS";
            // 
            // Button5
            // 
            Button5.Location = new Point(268, 136);
            Button5.Name = "Button5";
            Button5.Size = new Size(140, 23);
            Button5.TabIndex = 11;
            Button5.Text = "Set/Update Channel";
            Button5.UseVisualStyleBackColor = true;
            // 
            // Label27
            // 
            Label27.AutoSize = true;
            Label27.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label27.Location = new Point(73, 24);
            Label27.Name = "Label27";
            Label27.Size = new Size(276, 37);
            Label27.TabIndex = 10;
            Label27.Text = "Channel Settings";
            // 
            // Label28
            // 
            Label28.AutoSize = true;
            Label28.Location = new Point(273, 60);
            Label28.Name = "Label28";
            Label28.Size = new Size(45, 20);
            Label28.TabIndex = 9;
            Label28.Text = "Tone";
            // 
            // Label29
            // 
            Label29.AutoSize = true;
            Label29.Location = new Point(187, 60);
            Label29.Name = "Label29";
            Label29.Size = new Size(76, 20);
            Label29.TabIndex = 8;
            Label29.Text = "Repeater";
            // 
            // Label30
            // 
            Label30.AutoSize = true;
            Label30.Location = new Point(129, 60);
            Label30.Name = "Label30";
            Label30.Size = new Size(39, 20);
            Label30.TabIndex = 7;
            Label30.Text = "KHz";
            // 
            // TextBox2
            // 
            TextBox2.Location = new Point(9, 79);
            TextBox2.Name = "TextBox2";
            TextBox2.ReadOnly = true;
            TextBox2.Size = new Size(50, 26);
            TextBox2.TabIndex = 6;
            // 
            // Label31
            // 
            Label31.AutoSize = true;
            Label31.Location = new Point(13, 62);
            Label31.Name = "Label31";
            Label31.Size = new Size(68, 20);
            Label31.TabIndex = 5;
            Label31.Text = "Channel";
            // 
            // Label32
            // 
            Label32.AutoSize = true;
            Label32.Location = new Point(75, 62);
            Label32.Name = "Label32";
            Label32.Size = new Size(42, 20);
            Label32.TabIndex = 4;
            Label32.Text = "MHz";
            // 
            // ComboBox5
            // 
            ComboBox5.FormattingEnabled = true;
            ComboBox5.Items.AddRange(new object[] { "OFF", "67.0", "71.9", "74.4", "77.0", "79.7", "82.5", "85.4", "88.5", "91.5", "94.8", "97.4", "100.0", "103.5", "107.2", "110.9", "114.8", "118.8", "123.0", "127.3", "131.8", "136.5", "141.3", "146.2", "151.4", "156.7", "162.2", "167.9", "173.8", "179.9", "186.2", "192.8", "203.5", "210.7", "218.1", "225.7", "233.6", "241.8", "250.3" });
            ComboBox5.Location = new Point(265, 76);
            ComboBox5.Name = "ComboBox5";
            ComboBox5.Size = new Size(50, 28);
            ComboBox5.TabIndex = 3;
            // 
            // ComboBox6
            // 
            ComboBox6.FormattingEnabled = true;
            ComboBox6.Items.AddRange(new object[] { "PLUS", "MINUS", "SIMPLEX" });
            ComboBox6.Location = new Point(184, 76);
            ComboBox6.Name = "ComboBox6";
            ComboBox6.Size = new Size(75, 28);
            ComboBox6.TabIndex = 2;
            // 
            // ComboBox7
            // 
            ComboBox7.DropDownWidth = 43;
            ComboBox7.FormattingEnabled = true;
            ComboBox7.Items.AddRange(new object[] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "110", "120", "130", "140", "150", "160", "170", "180", "190", "200", "210", "220", "230", "240", "250", "260", "270", "280", "290", "300", "310", "320", "330", "340", "350", "360", "370", "380", "390", "400", "410", "420", "430", "440", "450", "460", "470", "480", "490", "500", "510", "520", "530", "540", "550", "560", "570", "580", "590", "600", "610", "620", "630", "640", "650", "660", "670", "680", "690", "700", "710", "720", "730", "740", "750", "760", "770", "780", "790", "800", "810", "820", "830", "840", "850", "860", "870", "880", "890", "900", "910", "920", "930", "940", "950", "960", "970", "980", "990" });
            ComboBox7.Location = new Point(128, 77);
            ComboBox7.MaxDropDownItems = 10;
            ComboBox7.Name = "ComboBox7";
            ComboBox7.Size = new Size(50, 28);
            ComboBox7.TabIndex = 1;
            // 
            // ComboBox8
            // 
            ComboBox8.FormattingEnabled = true;
            ComboBox8.Items.AddRange(new object[] { "BLANK", "146", "147", "148", "149", "150" });
            ComboBox8.Location = new Point(65, 78);
            ComboBox8.Name = "ComboBox8";
            ComboBox8.Size = new Size(57, 28);
            ComboBox8.TabIndex = 0;
            // 
            // TableLayoutPanel5
            // 
            TableLayoutPanel5.ColumnCount = 2;
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.05068f));
            TableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.94932f));
            TableLayoutPanel5.Controls.Add(TableLayoutPanel6, 0, 0);
            TableLayoutPanel5.Controls.Add(Panel14, 1, 0);
            TableLayoutPanel5.Dock = DockStyle.Fill;
            TableLayoutPanel5.Location = new Point(3, 3);
            TableLayoutPanel5.Name = "TableLayoutPanel5";
            TableLayoutPanel5.RowCount = 1;
            TableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel5.Size = new Size(838, 476);
            TableLayoutPanel5.TabIndex = 1;
            // 
            // TableLayoutPanel6
            // 
            TableLayoutPanel6.ColumnCount = 1;
            TableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel6.Controls.Add(Panel9, 0, 0);
            TableLayoutPanel6.Controls.Add(Panel13, 0, 1);
            TableLayoutPanel6.Dock = DockStyle.Fill;
            TableLayoutPanel6.Location = new Point(3, 3);
            TableLayoutPanel6.Name = "TableLayoutPanel6";
            TableLayoutPanel6.RowCount = 3;
            TableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 53.25077f));
            TableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 46.74923f));
            TableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 154.0f));
            TableLayoutPanel6.Size = new Size(421, 470);
            TableLayoutPanel6.TabIndex = 0;
            // 
            // Panel13
            // 
            Panel13.BackColor = Color.Silver;
            Panel13.BorderStyle = BorderStyle.Fixed3D;
            Panel13.Controls.Add(Label39);
            Panel13.Controls.Add(NumericUpDown5);
            Panel13.Controls.Add(Label40);
            Panel13.Controls.Add(NumericUpDown6);
            Panel13.Controls.Add(Button8);
            Panel13.Controls.Add(Label41);
            Panel13.Controls.Add(ProgressBar3);
            Panel13.Controls.Add(Button9);
            Panel13.Dock = DockStyle.Fill;
            Panel13.Location = new Point(3, 171);
            Panel13.Name = "Panel13";
            Panel13.Size = new Size(415, 141);
            Panel13.TabIndex = 1;
            // 
            // Label39
            // 
            Label39.AutoSize = true;
            Label39.Location = new Point(9, 42);
            Label39.Name = "Label39";
            Label39.Size = new Size(101, 20);
            Label39.TabIndex = 18;
            Label39.Text = "Button in mS";
            // 
            // NumericUpDown5
            // 
            NumericUpDown5.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            NumericUpDown5.Location = new Point(9, 57);
            NumericUpDown5.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NumericUpDown5.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            NumericUpDown5.Name = "NumericUpDown5";
            NumericUpDown5.Size = new Size(55, 26);
            NumericUpDown5.TabIndex = 17;
            NumericUpDown5.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // Label40
            // 
            Label40.AutoSize = true;
            Label40.Location = new Point(9, 4);
            Label40.Name = "Label40";
            Label40.Size = new Size(89, 20);
            Label40.TabIndex = 16;
            Label40.Text = "Tone in mS";
            // 
            // NumericUpDown6
            // 
            NumericUpDown6.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            NumericUpDown6.Location = new Point(9, 19);
            NumericUpDown6.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NumericUpDown6.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            NumericUpDown6.Name = "NumericUpDown6";
            NumericUpDown6.Size = new Size(55, 26);
            NumericUpDown6.TabIndex = 15;
            NumericUpDown6.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // Button8
            // 
            Button8.Location = new Point(78, 56);
            Button8.Name = "Button8";
            Button8.Size = new Size(100, 37);
            Button8.TabIndex = 12;
            Button8.Text = "Clear Channel List";
            Button8.UseVisualStyleBackColor = true;
            // 
            // Label41
            // 
            Label41.AutoSize = true;
            Label41.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label41.Location = new Point(73, 13);
            Label41.Name = "Label41";
            Label41.Size = new Size(358, 37);
            Label41.TabIndex = 11;
            Label41.Text = "Channel Programming";
            // 
            // ProgressBar3
            // 
            ProgressBar3.Location = new Point(31, 108);
            ProgressBar3.Name = "ProgressBar3";
            ProgressBar3.Size = new Size(335, 16);
            ProgressBar3.TabIndex = 1;
            // 
            // Button9
            // 
            Button9.Location = new Point(220, 56);
            Button9.Name = "Button9";
            Button9.Size = new Size(95, 37);
            Button9.TabIndex = 0;
            Button9.Text = "Program Radio Channels";
            Button9.UseVisualStyleBackColor = true;
            // 
            // Panel14
            // 
            Panel14.BackColor = Color.Silver;
            Panel14.BorderStyle = BorderStyle.Fixed3D;
            Panel14.Controls.Add(ListView2);
            Panel14.Controls.Add(Label42);
            Panel14.Dock = DockStyle.Fill;
            Panel14.Location = new Point(430, 3);
            Panel14.Name = "Panel14";
            Panel14.Size = new Size(405, 470);
            Panel14.TabIndex = 1;
            // 
            // ListView2
            // 
            ListView2.Columns.AddRange(new ColumnHeader[] { ColumnHeader9, ColumnHeader10, ColumnHeader11, ColumnHeader12, ColumnHeader13 });
            ListView2.FullRowSelect = true;
            ListView2.GridLines = true;
            ListView2.HideSelection = false;
            ListView2.Location = new Point(0, 49);
            ListView2.MultiSelect = false;
            ListView2.Name = "ListView2";
            ListView2.Size = new Size(389, 377);
            ListView2.TabIndex = 12;
            ListView2.UseCompatibleStateImageBehavior = false;
            ListView2.View = View.Details;
            // 
            // ColumnHeader9
            // 
            ColumnHeader9.Text = "Channel";
            ColumnHeader9.Width = 64;
            // 
            // ColumnHeader10
            // 
            ColumnHeader10.Text = "Frequency";
            ColumnHeader10.Width = 81;
            // 
            // ColumnHeader11
            // 
            ColumnHeader11.Text = "Repeater Mode";
            ColumnHeader11.Width = 105;
            // 
            // ColumnHeader12
            // 
            ColumnHeader12.Text = "Tone";
            ColumnHeader12.Width = 76;
            // 
            // ColumnHeader13
            // 
            ColumnHeader13.Text = " CTSS";
            // 
            // Label42
            // 
            Label42.AutoSize = true;
            Label42.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label42.Location = new Point(109, 10);
            Label42.Name = "Label42";
            Label42.Size = new Size(207, 37);
            Label42.TabIndex = 11;
            Label42.Text = "Channel List";
            // 
            // TableLayoutPanel9
            // 
            TableLayoutPanel9.ColumnCount = 1;
            TableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel9.Controls.Add(Panel16, 0, 0);
            TableLayoutPanel9.Controls.Add(Panel18, 0, 1);
            TableLayoutPanel9.Controls.Add(deleteStatusStrip1, 0, 2);
            TableLayoutPanel9.Dock = DockStyle.Fill;
            TableLayoutPanel9.Location = new Point(3, 3);
            TableLayoutPanel9.Name = "TableLayoutPanel9";
            TableLayoutPanel9.RowCount = 3;
            TableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 53.25077f));
            TableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 46.74923f));
            TableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 154.0f));
            TableLayoutPanel9.Size = new Size(421, 470);
            TableLayoutPanel9.TabIndex = 0;
            // 
            // Panel16
            // 
            Panel16.BackColor = Color.Silver;
            Panel16.BorderStyle = BorderStyle.Fixed3D;
            Panel16.Controls.Add(Panel17);
            Panel16.Controls.Add(Label44);
            Panel16.Controls.Add(Button4);
            Panel16.Controls.Add(Label45);
            Panel16.Controls.Add(Label46);
            Panel16.Controls.Add(Label47);
            Panel16.Controls.Add(Label48);
            Panel16.Controls.Add(TextBox3);
            Panel16.Controls.Add(Label49);
            Panel16.Controls.Add(Label50);
            Panel16.Controls.Add(ComboBox9);
            Panel16.Controls.Add(ComboBox10);
            Panel16.Controls.Add(ComboBox11);
            Panel16.Controls.Add(ComboBox12);
            Panel16.Controls.Add(deleteMenuStrip1);
            Panel16.Dock = DockStyle.Fill;
            Panel16.Location = new Point(3, 3);
            Panel16.Name = "Panel16";
            Panel16.Size = new Size(415, 162);
            Panel16.TabIndex = 0;
            // 
            // Panel17
            // 
            Panel17.Controls.Add(RadioButton3);
            Panel17.Controls.Add(RadioButton4);
            Panel17.Location = new Point(321, 76);
            Panel17.Name = "Panel17";
            Panel17.Size = new Size(90, 44);
            Panel17.TabIndex = 16;
            // 
            // RadioButton3
            // 
            RadioButton3.AutoSize = true;
            RadioButton3.Location = new Point(4, 5);
            RadioButton3.Name = "RadioButton3";
            RadioButton3.Size = new Size(66, 24);
            RadioButton3.TabIndex = 14;
            RadioButton3.TabStop = true;
            RadioButton3.Text = "Xmit";
            RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton4
            // 
            RadioButton4.AutoSize = true;
            RadioButton4.Location = new Point(4, 23);
            RadioButton4.Name = "RadioButton4";
            RadioButton4.Size = new Size(99, 24);
            RadioButton4.TabIndex = 15;
            RadioButton4.TabStop = true;
            RadioButton4.Text = "Xmit/Rec";
            RadioButton4.UseVisualStyleBackColor = true;
            // 
            // Label44
            // 
            Label44.AutoSize = true;
            Label44.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label44.Location = new Point(324, 60);
            Label44.Name = "Label44";
            Label44.Size = new Size(65, 20);
            Label44.TabIndex = 13;
            Label44.Text = "CTCSS";
            // 
            // Button4
            // 
            Button4.Location = new Point(268, 136);
            Button4.Name = "Button4";
            Button4.Size = new Size(140, 23);
            Button4.TabIndex = 11;
            Button4.Text = "Set/Update Channel";
            Button4.UseVisualStyleBackColor = true;
            // 
            // Label45
            // 
            Label45.AutoSize = true;
            Label45.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label45.Location = new Point(73, 24);
            Label45.Name = "Label45";
            Label45.Size = new Size(276, 37);
            Label45.TabIndex = 10;
            Label45.Text = "Channel Settings";
            // 
            // Label46
            // 
            Label46.AutoSize = true;
            Label46.Location = new Point(273, 60);
            Label46.Name = "Label46";
            Label46.Size = new Size(45, 20);
            Label46.TabIndex = 9;
            Label46.Text = "Tone";
            // 
            // Label47
            // 
            Label47.AutoSize = true;
            Label47.Location = new Point(187, 60);
            Label47.Name = "Label47";
            Label47.Size = new Size(76, 20);
            Label47.TabIndex = 8;
            Label47.Text = "Repeater";
            // 
            // Label48
            // 
            Label48.AutoSize = true;
            Label48.Location = new Point(129, 60);
            Label48.Name = "Label48";
            Label48.Size = new Size(39, 20);
            Label48.TabIndex = 7;
            Label48.Text = "KHz";
            // 
            // TextBox3
            // 
            TextBox3.Location = new Point(9, 79);
            TextBox3.Name = "TextBox3";
            TextBox3.ReadOnly = true;
            TextBox3.Size = new Size(50, 26);
            TextBox3.TabIndex = 6;
            // 
            // Label49
            // 
            Label49.AutoSize = true;
            Label49.Location = new Point(13, 62);
            Label49.Name = "Label49";
            Label49.Size = new Size(68, 20);
            Label49.TabIndex = 5;
            Label49.Text = "Channel";
            // 
            // Label50
            // 
            Label50.AutoSize = true;
            Label50.Location = new Point(75, 62);
            Label50.Name = "Label50";
            Label50.Size = new Size(42, 20);
            Label50.TabIndex = 4;
            Label50.Text = "MHz";
            // 
            // ComboBox9
            // 
            ComboBox9.FormattingEnabled = true;
            ComboBox9.Items.AddRange(new object[] { "OFF", "67.0", "71.9", "74.4", "77.0", "79.7", "82.5", "85.4", "88.5", "91.5", "94.8", "97.4", "100.0", "103.5", "107.2", "110.9", "114.8", "118.8", "123.0", "127.3", "131.8", "136.5", "141.3", "146.2", "151.4", "156.7", "162.2", "167.9", "173.8", "179.9", "186.2", "192.8", "203.5", "210.7", "218.1", "225.7", "233.6", "241.8", "250.3" });
            ComboBox9.Location = new Point(265, 76);
            ComboBox9.Name = "ComboBox9";
            ComboBox9.Size = new Size(50, 28);
            ComboBox9.TabIndex = 3;
            // 
            // ComboBox10
            // 
            ComboBox10.FormattingEnabled = true;
            ComboBox10.Items.AddRange(new object[] { "PLUS", "MINUS", "SIMPLEX" });
            ComboBox10.Location = new Point(184, 76);
            ComboBox10.Name = "ComboBox10";
            ComboBox10.Size = new Size(75, 28);
            ComboBox10.TabIndex = 2;
            // 
            // ComboBox11
            // 
            ComboBox11.DropDownWidth = 43;
            ComboBox11.FormattingEnabled = true;
            ComboBox11.Items.AddRange(new object[] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "110", "120", "130", "140", "150", "160", "170", "180", "190", "200", "210", "220", "230", "240", "250", "260", "270", "280", "290", "300", "310", "320", "330", "340", "350", "360", "370", "380", "390", "400", "410", "420", "430", "440", "450", "460", "470", "480", "490", "500", "510", "520", "530", "540", "550", "560", "570", "580", "590", "600", "610", "620", "630", "640", "650", "660", "670", "680", "690", "700", "710", "720", "730", "740", "750", "760", "770", "780", "790", "800", "810", "820", "830", "840", "850", "860", "870", "880", "890", "900", "910", "920", "930", "940", "950", "960", "970", "980", "990" });
            ComboBox11.Location = new Point(128, 77);
            ComboBox11.MaxDropDownItems = 10;
            ComboBox11.Name = "ComboBox11";
            ComboBox11.Size = new Size(50, 28);
            ComboBox11.TabIndex = 1;
            // 
            // ComboBox12
            // 
            ComboBox12.FormattingEnabled = true;
            ComboBox12.Items.AddRange(new object[] { "BLANK", "146", "147", "148", "149", "150" });
            ComboBox12.Location = new Point(65, 78);
            ComboBox12.Name = "ComboBox12";
            ComboBox12.Size = new Size(57, 28);
            ComboBox12.TabIndex = 0;
            // 
            // deleteMenuStrip1
            // 
            deleteMenuStrip1.GripMargin = new Padding(2, 2, 0, 2);
            deleteMenuStrip1.ImageScalingSize = new Size(24, 24);
            deleteMenuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem1, ToolStripMenuItem4 });
            deleteMenuStrip1.Location = new Point(0, 0);
            deleteMenuStrip1.Name = "deleteMenuStrip1";
            deleteMenuStrip1.Size = new Size(411, 24);
            deleteMenuStrip1.TabIndex = 17;
            deleteMenuStrip1.Text = "MenuStrip1";
            deleteMenuStrip1.Visible = false;
            // 
            // ToolStripMenuItem1
            // 
            ToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem2, ToolStripMenuItem3 });
            ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            ToolStripMenuItem1.Size = new Size(54, 20);
            ToolStripMenuItem1.Text = "File";
            // 
            // ToolStripMenuItem2
            // 
            ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            ToolStripMenuItem2.Size = new Size(257, 34);
            ToolStripMenuItem2.Text = "Open Channel File";
            // 
            // ToolStripMenuItem3
            // 
            ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            ToolStripMenuItem3.Size = new Size(257, 34);
            ToolStripMenuItem3.Text = "Save Channel File";
            // 
            // ToolStripMenuItem4
            // 
            ToolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem5, ToolStripMenuItem6 });
            ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            ToolStripMenuItem4.Size = new Size(92, 20);
            ToolStripMenuItem4.Text = "Options";
            // 
            // ToolStripMenuItem5
            // 
            ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            ToolStripMenuItem5.Size = new Size(266, 34);
            ToolStripMenuItem5.Text = "Back to Main Menu";
            // 
            // ToolStripMenuItem6
            // 
            ToolStripMenuItem6.DropDownItems.AddRange(new ToolStripItem[] { ToolStripComboBox1 });
            ToolStripMenuItem6.Name = "ToolStripMenuItem6";
            ToolStripMenuItem6.Size = new Size(266, 34);
            ToolStripMenuItem6.Text = "kHz Step Size";
            // 
            // ToolStripComboBox1
            // 
            ToolStripComboBox1.Items.AddRange(new object[] { "10", "12.5" });
            ToolStripComboBox1.Name = "ToolStripComboBox1";
            ToolStripComboBox1.Size = new Size(121, 33);
            // 
            // Panel18
            // 
            Panel18.BackColor = Color.Silver;
            Panel18.BorderStyle = BorderStyle.Fixed3D;
            Panel18.Controls.Add(Label51);
            Panel18.Controls.Add(NumericUpDown3);
            Panel18.Controls.Add(Label52);
            Panel18.Controls.Add(NumericUpDown4);
            Panel18.Controls.Add(Button6);
            Panel18.Controls.Add(Label53);
            Panel18.Controls.Add(ProgressBar2);
            Panel18.Controls.Add(Button7);
            Panel18.Dock = DockStyle.Fill;
            Panel18.Location = new Point(3, 171);
            Panel18.Name = "Panel18";
            Panel18.Size = new Size(415, 141);
            Panel18.TabIndex = 1;
            // 
            // Label51
            // 
            Label51.AutoSize = true;
            Label51.Location = new Point(9, 42);
            Label51.Name = "Label51";
            Label51.Size = new Size(101, 20);
            Label51.TabIndex = 18;
            Label51.Text = "Button in mS";
            // 
            // NumericUpDown3
            // 
            NumericUpDown3.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            NumericUpDown3.Location = new Point(9, 57);
            NumericUpDown3.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NumericUpDown3.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            NumericUpDown3.Name = "NumericUpDown3";
            NumericUpDown3.Size = new Size(55, 26);
            NumericUpDown3.TabIndex = 17;
            NumericUpDown3.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // Label52
            // 
            Label52.AutoSize = true;
            Label52.Location = new Point(9, 4);
            Label52.Name = "Label52";
            Label52.Size = new Size(89, 20);
            Label52.TabIndex = 16;
            Label52.Text = "Tone in mS";
            // 
            // NumericUpDown4
            // 
            NumericUpDown4.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            NumericUpDown4.Location = new Point(9, 19);
            NumericUpDown4.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NumericUpDown4.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            NumericUpDown4.Name = "NumericUpDown4";
            NumericUpDown4.Size = new Size(55, 26);
            NumericUpDown4.TabIndex = 15;
            NumericUpDown4.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // Button6
            // 
            Button6.Location = new Point(78, 56);
            Button6.Name = "Button6";
            Button6.Size = new Size(100, 37);
            Button6.TabIndex = 12;
            Button6.Text = "Clear Channel List";
            Button6.UseVisualStyleBackColor = true;
            // 
            // Label53
            // 
            Label53.AutoSize = true;
            Label53.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label53.Location = new Point(73, 13);
            Label53.Name = "Label53";
            Label53.Size = new Size(358, 37);
            Label53.TabIndex = 11;
            Label53.Text = "Channel Programming";
            // 
            // ProgressBar2
            // 
            ProgressBar2.Location = new Point(31, 108);
            ProgressBar2.Name = "ProgressBar2";
            ProgressBar2.Size = new Size(335, 16);
            ProgressBar2.TabIndex = 1;
            // 
            // Button7
            // 
            Button7.Location = new Point(220, 56);
            Button7.Name = "Button7";
            Button7.Size = new Size(95, 37);
            Button7.TabIndex = 0;
            Button7.Text = "Program Radio Channels";
            Button7.UseVisualStyleBackColor = true;
            // 
            // deleteStatusStrip1
            // 
            deleteStatusStrip1.ImageScalingSize = new Size(24, 24);
            deleteStatusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2 });
            deleteStatusStrip1.Location = new Point(0, 438);
            deleteStatusStrip1.Name = "deleteStatusStrip1";
            deleteStatusStrip1.Size = new Size(421, 32);
            deleteStatusStrip1.TabIndex = 2;
            deleteStatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            ToolStripStatusLabel1.Size = new Size(180, 25);
            ToolStripStatusLabel1.Text = "ToolStripStatusLabel1";
            // 
            // ToolStripStatusLabel2
            // 
            ToolStripStatusLabel2.Font = new Font("Segoe UI", 9.0f, FontStyle.Bold);
            ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            ToolStripStatusLabel2.Size = new Size(196, 25);
            ToolStripStatusLabel2.Text = "ToolStripStatusLabel2";
            // 
            // Panel19
            // 
            Panel19.BackColor = Color.Silver;
            Panel19.BorderStyle = BorderStyle.Fixed3D;
            Panel19.Controls.Add(ListView3);
            Panel19.Controls.Add(Label54);
            Panel19.Dock = DockStyle.Fill;
            Panel19.Location = new Point(430, 3);
            Panel19.Name = "Panel19";
            Panel19.Size = new Size(405, 470);
            Panel19.TabIndex = 1;
            // 
            // ListView3
            // 
            ListView3.Columns.AddRange(new ColumnHeader[] { ColumnHeader16, ColumnHeader17, ColumnHeader18, ColumnHeader19, ColumnHeader20 });
            ListView3.FullRowSelect = true;
            ListView3.GridLines = true;
            ListView3.HideSelection = false;
            ListView3.Location = new Point(0, 49);
            ListView3.MultiSelect = false;
            ListView3.Name = "ListView3";
            ListView3.Size = new Size(389, 377);
            ListView3.TabIndex = 12;
            ListView3.UseCompatibleStateImageBehavior = false;
            ListView3.View = View.Details;
            // 
            // ColumnHeader16
            // 
            ColumnHeader16.Text = "Channel";
            ColumnHeader16.Width = 64;
            // 
            // ColumnHeader17
            // 
            ColumnHeader17.Text = "Frequency";
            ColumnHeader17.Width = 81;
            // 
            // ColumnHeader18
            // 
            ColumnHeader18.Text = "Repeater Mode";
            ColumnHeader18.Width = 105;
            // 
            // ColumnHeader19
            // 
            ColumnHeader19.Text = "Tone";
            ColumnHeader19.Width = 76;
            // 
            // ColumnHeader20
            // 
            ColumnHeader20.Text = " CTSS";
            // 
            // Label54
            // 
            Label54.AutoSize = true;
            Label54.Font = new Font("Microsoft Sans Serif", 16.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label54.Location = new Point(109, 10);
            Label54.Name = "Label54";
            Label54.Size = new Size(207, 37);
            Label54.TabIndex = 11;
            Label54.Text = "Channel List";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(1014, 568);
            Controls.Add(TabControl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Channel Lists (Version 1.1)";
            TabControl.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            Tab1TableLayoutPanel1.ResumeLayout(false);
            Tab1TableLayoutPanel1.PerformLayout();
            TableLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel2.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Tab1CtcssPanel.ResumeLayout(false);
            Tab1CtcssPanel.PerformLayout();
            Tab1MenuStrip.ResumeLayout(false);
            Tab1MenuStrip.PerformLayout();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            Tab1StatusStrip1.ResumeLayout(false);
            Tab1StatusStrip1.PerformLayout();
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            TabPage2.ResumeLayout(false);
            TableLayoutPanel7.ResumeLayout(false);
            TableLayoutPanel4.ResumeLayout(false);
            TableLayoutPanel4.PerformLayout();
            Panel11.ResumeLayout(false);
            Panel11.PerformLayout();
            Panel8.ResumeLayout(false);
            Panel8.PerformLayout();
            Tab2MenuStrip.ResumeLayout(false);
            Tab2MenuStrip.PerformLayout();
            Panel12.ResumeLayout(false);
            Panel12.PerformLayout();
            Tab2StatusStrip.ResumeLayout(false);
            Tab2StatusStrip.PerformLayout();
            Panel15.ResumeLayout(false);
            Panel15.PerformLayout();
            TabPage3.ResumeLayout(false);
            TableLayoutPanel8.ResumeLayout(false);
            TableLayoutPanel10.ResumeLayout(false);
            TableLayoutPanel10.PerformLayout();
            Panel20.ResumeLayout(false);
            Panel20.PerformLayout();
            Panel21.ResumeLayout(false);
            Panel21.PerformLayout();
            Tab3MenuStrip.ResumeLayout(false);
            Tab3MenuStrip.PerformLayout();
            Panel22.ResumeLayout(false);
            Panel22.PerformLayout();
            Tab3StatusStrip.ResumeLayout(false);
            Tab3StatusStrip.PerformLayout();
            Panel23.ResumeLayout(false);
            Panel23.PerformLayout();
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel3.ResumeLayout(false);
            Panel4.ResumeLayout(false);
            Panel4.PerformLayout();
            Panel5.ResumeLayout(false);
            Panel5.PerformLayout();
            Panel6.ResumeLayout(false);
            Panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown2).EndInit();
            Panel7.ResumeLayout(false);
            Panel7.PerformLayout();
            Panel9.ResumeLayout(false);
            Panel9.PerformLayout();
            Panel10.ResumeLayout(false);
            Panel10.PerformLayout();
            TableLayoutPanel5.ResumeLayout(false);
            TableLayoutPanel6.ResumeLayout(false);
            Panel13.ResumeLayout(false);
            Panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown6).EndInit();
            Panel14.ResumeLayout(false);
            Panel14.PerformLayout();
            TableLayoutPanel9.ResumeLayout(false);
            TableLayoutPanel9.PerformLayout();
            Panel16.ResumeLayout(false);
            Panel16.PerformLayout();
            Panel17.ResumeLayout(false);
            Panel17.PerformLayout();
            deleteMenuStrip1.ResumeLayout(false);
            deleteMenuStrip1.PerformLayout();
            Panel18.ResumeLayout(false);
            Panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown4).EndInit();
            deleteStatusStrip1.ResumeLayout(false);
            deleteStatusStrip1.PerformLayout();
            Panel19.ResumeLayout(false);
            Panel19.PerformLayout();
            FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            ResumeLayout(false);

        }


        internal Timer Timer1;
        internal OpenFileDialog OpenFileDialog1;
        internal SaveFileDialog SaveFileDialog1;


        internal TabControl TabControl;
        internal TabPage TabPage1;
        internal TableLayoutPanel Tab1TableLayoutPanel1;
        internal TableLayoutPanel TableLayoutPanel2;
        internal Panel Panel1;
        internal Panel Tab1CtcssPanel;
        internal RadioButton Tab1CtcssXmit;
        internal RadioButton Tab1CtcssXmitRec;
        internal Label Tab1CtcssLabel;
        internal Button Tab1SetChannelButtone;
        internal Label Label6;
        internal Label Label5;
        internal Label Label4;
        internal Label Label3;
        internal TextBox Tab1ChannelTextBox;
        internal Label Label2;
        internal Label Label1;
        internal ComboBox Tab1ToneComboBox;
        internal ComboBox Tab1RepeaterComboBox;
        internal ComboBox Tab1KHzCombBox;
        internal ComboBox Tab1MHzComboBox;
        internal MenuStrip Tab1MenuStrip;
        internal ToolStripMenuItem Tab1FileToolStripMenuItem;
        internal ToolStripMenuItem Tab1OpenChannelFileToolStripMenuItem;
        internal ToolStripMenuItem Tab1SaveChannelFileToolStripMenuItem;
        internal ToolStripMenuItem Tab1SettingsToolStripMenuItem;
        internal ToolStripMenuItem Tab1BackToMainMenuToolStripMenuItem;
        internal ToolStripMenuItem Tab1KHzStepSizeToolStripMenuItem;
        internal ToolStripComboBox Tab1KHzToolStripComboBox;
        internal Panel Panel2;
        internal Label Label7;
        internal ProgressBar Tab1ProgressBar1;
        internal Button Tab1ProgramButton;
        internal StatusStrip Tab1StatusStrip1;
        internal ToolStripStatusLabel Tab1ToolStripStepSize;
        internal ToolStripStatusLabel Tab1ToolStripStatusLabel;
        internal Panel Panel3;
        internal ListView Tab1ChannelListView;
        internal ColumnHeader Channel;
        internal ColumnHeader Frequency;
        internal ColumnHeader Repeater;
        internal ColumnHeader Tone;
        internal ColumnHeader CTSS;
        internal Label Label8;
        internal TabPage TabPage2;

        internal Button Tab1ClearChannelList;
        internal System.IO.Ports.SerialPort SerialPort1;
        internal Timer Timer2;
        internal TableLayoutPanel TableLayoutPanel1;
        internal TableLayoutPanel TableLayoutPanel3;
        internal Panel Panel4;
        internal Panel Panel5;
        internal RadioButton RadioButton1;
        internal RadioButton RadioButton2;
        internal Label Label11;
        internal Button Button1;
        internal Label Label12;
        internal Label Label13;
        internal Label Label14;
        internal Label Label15;
        internal TextBox TextBox1;
        internal Label Label16;
        internal Label Label17;
        internal ComboBox ComboBox1;
        internal ComboBox ComboBox2;
        internal ComboBox ComboBox3;
        internal ComboBox ComboBox4;
        internal Panel Panel6;
        internal Label Label18;
        internal NumericUpDown NumericUpDown1;
        internal Label Label19;
        internal NumericUpDown NumericUpDown2;
        internal Button Button2;
        internal Label Label20;
        internal ProgressBar ProgressBar1;
        internal Button Button3;
        internal Panel Panel7;
        internal ListView ListView1;
        internal ColumnHeader ColumnHeader1;
        internal ColumnHeader ColumnHeader2;
        internal ColumnHeader ColumnHeader3;
        internal ColumnHeader ColumnHeader4;
        internal ColumnHeader ColumnHeader5;
        internal Label Label21;
        internal TableLayoutPanel TableLayoutPanel7;
        internal TableLayoutPanel TableLayoutPanel4;
        internal Panel Panel11;
        internal Panel Panel8;
        internal RadioButton Tab2CtcssXmit;
        internal RadioButton Tab2CtcssXmitRec;
        internal Label Label22;
        internal Button Tab2SetChannelButtone;
        internal Label Label23;
        internal Label Label24;
        internal Label Label25;
        internal Label Label33;
        internal TextBox Tab2ChannelTextBox;
        internal Label Label34;
        internal Label Label35;
        internal ComboBox Tab2ToneComboBox;
        internal ComboBox Tab2RepeaterComboBox;
        internal ComboBox Tab2KHzCombBox;
        internal ComboBox Tab2MHzComboBox;
        internal MenuStrip Tab2MenuStrip;
        internal ToolStripMenuItem Tab2FileToolStripMenuItem;
        internal ToolStripMenuItem Tab2OpenChannelFileToolStripMenuItem;
        internal ToolStripMenuItem Tab2SaveChannelFileToolStripMenuItem;
        internal ToolStripMenuItem Tab2SettingsToolStripMenuItem;
        internal ToolStripMenuItem Tab2BackToMainMenuToolStripMenuItem;
        internal ToolStripMenuItem Tab2KHzStepSizeToolStripMenuItem;
        internal ToolStripComboBox Tab2KHzToolStripComboBox;
        internal Panel Panel12;
        internal Button Tab2ClearChannelList;
        internal Label Label38;
        internal ProgressBar Tab2ProgressBar1;
        internal Button Tab2ProgramButton;
        internal StatusStrip Tab2StatusStrip;
        internal ToolStripStatusLabel Tab2ToolStripStepSize;
        internal ToolStripStatusLabel Tab2ToolStripStatusLabel;
        internal Panel Panel15;
        internal ListView Tab2ChannelListView;
        internal ColumnHeader ColumnHeader8;
        internal ColumnHeader ColumnHeader7;
        internal ColumnHeader ColumnHeader6;
        internal ColumnHeader ColumnHeader15;
        internal ColumnHeader ColumnHeader14;
        internal Label Label43;
        internal Panel Panel9;
        internal Panel Panel10;
        internal RadioButton RadioButton5;
        internal RadioButton RadioButton6;
        internal Label Label26;
        internal Button Button5;
        internal Label Label27;
        internal Label Label28;
        internal Label Label29;
        internal Label Label30;
        internal TextBox TextBox2;
        internal Label Label31;
        internal Label Label32;
        internal ComboBox ComboBox5;
        internal ComboBox ComboBox6;
        internal ComboBox ComboBox7;
        internal ComboBox ComboBox8;
        internal TableLayoutPanel TableLayoutPanel5;
        internal TableLayoutPanel TableLayoutPanel6;
        internal Panel Panel13;
        internal Label Label39;
        internal NumericUpDown NumericUpDown5;
        internal Label Label40;
        internal NumericUpDown NumericUpDown6;
        internal Button Button8;
        internal Label Label41;
        internal ProgressBar ProgressBar3;
        internal Button Button9;
        internal Panel Panel14;
        internal ListView ListView2;
        internal ColumnHeader ColumnHeader9;
        internal ColumnHeader ColumnHeader10;
        internal ColumnHeader ColumnHeader11;
        internal ColumnHeader ColumnHeader12;
        internal ColumnHeader ColumnHeader13;
        internal Label Label42;
        internal TabPage TabPage3;
        internal TableLayoutPanel TableLayoutPanel8;
        internal TableLayoutPanel TableLayoutPanel10;
        internal Panel Panel20;
        internal Panel Panel21;
        internal RadioButton Tab3CtcssXmit;
        internal RadioButton Tab3CtcssXmitRec;
        internal Label Label55;
        internal Button Tab3SetChannelButtone;
        internal Label Label56;
        internal Label Label57;
        internal Label Label58;
        internal Label Label59;
        internal TextBox Tab3ChannelTextBox;
        internal Label Label60;
        internal Label Label61;
        internal ComboBox Tab3ToneComboBox;
        internal ComboBox Tab3RepeaterComboBox;
        internal ComboBox Tab3KHzCombBox;
        internal ComboBox Tab3MHzComboBox;
        internal MenuStrip Tab3MenuStrip;
        internal ToolStripMenuItem Tab3FileToolStripMenuItem;
        internal ToolStripMenuItem Tab3OpenChannelFileToolStripMenuItem;
        internal ToolStripMenuItem Tab3SaveChannelFileToolStripMenuItem;
        internal ToolStripMenuItem Tab3SettingsToolStripMenuItem;
        internal ToolStripMenuItem Tab3BackToMainMenuToolStripMenuItem;
        internal ToolStripMenuItem Tab3KHzStepSizeToolStripMenuItem;
        internal ToolStripComboBox Tab3KHzToolStripComboBox;
        internal Panel Panel22;
        internal Button Tab3ClearChannelList;
        internal Label Label64;
        internal ProgressBar Tab3ProgressBar1;
        internal Button Tab3ProgramButton;
        internal StatusStrip Tab3StatusStrip;
        internal ToolStripStatusLabel Tab3ToolStripStepSize;
        internal ToolStripStatusLabel Tab3ToolStripStatusLabel;
        internal Panel Panel23;
        internal ListView Tab3ChannelListView;
        internal ColumnHeader ColumnHeader21;
        internal ColumnHeader ColumnHeader22;
        internal ColumnHeader ColumnHeader23;
        internal ColumnHeader ColumnHeader24;
        internal ColumnHeader ColumnHeader25;
        internal Label Label65;
        internal TableLayoutPanel TableLayoutPanel9;
        internal Panel Panel16;
        internal Panel Panel17;
        internal RadioButton RadioButton3;
        internal RadioButton RadioButton4;
        internal Label Label44;
        internal Button Button4;
        internal Label Label45;
        internal Label Label46;
        internal Label Label47;
        internal Label Label48;
        internal TextBox TextBox3;
        internal Label Label49;
        internal Label Label50;
        internal ComboBox ComboBox9;
        internal ComboBox ComboBox10;
        internal ComboBox ComboBox11;
        internal ComboBox ComboBox12;
        internal MenuStrip deleteMenuStrip1;
        internal ToolStripMenuItem ToolStripMenuItem1;
        internal ToolStripMenuItem ToolStripMenuItem2;
        internal ToolStripMenuItem ToolStripMenuItem3;
        internal ToolStripMenuItem ToolStripMenuItem4;
        internal ToolStripMenuItem ToolStripMenuItem5;
        internal ToolStripMenuItem ToolStripMenuItem6;
        internal ToolStripComboBox ToolStripComboBox1;
        internal Panel Panel18;
        internal Label Label51;
        internal NumericUpDown NumericUpDown3;
        internal Label Label52;
        internal NumericUpDown NumericUpDown4;
        internal Button Button6;
        internal Label Label53;
        internal ProgressBar ProgressBar2;
        internal Button Button7;
        internal StatusStrip deleteStatusStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal Panel Panel19;
        internal ListView ListView3;
        internal ColumnHeader ColumnHeader16;
        internal ColumnHeader ColumnHeader17;
        internal ColumnHeader ColumnHeader18;
        internal ColumnHeader ColumnHeader19;
        internal ColumnHeader ColumnHeader20;
        internal Label Label54;
        internal TextBox Tab1ComPortTextBox;
        internal TextBox Tab2ComPortTextBox;
        internal TextBox Tab3ComPortTextBox;
        internal Label Label66;
        internal Label Tab1UsbCmdLabel;
        internal Label Label68;
        internal Label Tab2UsbCmdLabel;
        internal Label Tab3UsbCmdLabel;
        internal Label Label69;
        internal TextBox Tab1ChannelNotes;
        internal Label Label67;
        internal TextBox Tab2ChannelNotes;
        internal TextBox Tab3ChannelNotes;
        internal Label Label70;
        internal ColumnHeader ColumnHeader27;
        internal Label Label71;
        internal ColumnHeader ColumnHeader28;
        internal ColumnHeader Notes;
        internal Button Tab3DeleteRowButton;
        internal Button Tab3InsertRowButton;
        internal Button Tab1DeleteRowButton;
        internal Button Tab1InsertRowButton;
        internal Button Tab2DeleteRowButton;
        internal Button Tab2InsertRowButton;
        internal Label Tab1UsbRcvdLabel;
        internal Label Label72;
        internal Label Label73;
        internal Label Label74;
        internal Label Tab2UsbRcvdLabel;
        internal Label Tab3UsbRcvdLabel;
        internal Button Tab1StopProgramButton;
        internal Button Tab2StopProgramButton;
        internal Button Tab3StopProgramButton;
        internal Label Label9;
        internal Label tab1ChannelFileName;
        internal Label tab2ChannelFileName;
        internal Label Label10;
        internal Label tab3ChannelFileName;
        internal Label Label36;
        internal RadioButton Tab1CtcssOff;
        internal RadioButton Tab2CtcssOff;
        internal RadioButton Tab3CtcssOff;

    }
}