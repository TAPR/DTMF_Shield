using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Radio
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Tab1TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Tab1DeleteRowButton = new System.Windows.Forms.Button();
            this.Tab1InsertRowButton = new System.Windows.Forms.Button();
            this.Label67 = new System.Windows.Forms.Label();
            this.Tab1ChannelNotes = new System.Windows.Forms.TextBox();
            this.Tab1CtcssPanel = new System.Windows.Forms.Panel();
            this.Tab1CtcssOff = new System.Windows.Forms.RadioButton();
            this.Tab1CtcssXmit = new System.Windows.Forms.RadioButton();
            this.Tab1CtcssXmitRec = new System.Windows.Forms.RadioButton();
            this.Tab1CtcssLabel = new System.Windows.Forms.Label();
            this.Tab1SetChannelButton = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Tab1ClearChannelList = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Tab1ChannelTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Tab1ToneComboBox = new System.Windows.Forms.ComboBox();
            this.Tab1RepeaterComboBox = new System.Windows.Forms.ComboBox();
            this.Tab1KHzCombBox = new System.Windows.Forms.ComboBox();
            this.Tab1MHzComboBox = new System.Windows.Forms.ComboBox();
            this.Tab1MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Tab1FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab1OpenChannelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab1SaveChannelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab1SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab1BackToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab1KHzStepSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab1KHzToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.textBoxSerialCommands = new System.Windows.Forms.TextBox();
            this.tab1ChannelFileName = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Tab1StopProgramButton = new System.Windows.Forms.Button();
            this.Tab1UsbRcvdLabel = new System.Windows.Forms.Label();
            this.Label72 = new System.Windows.Forms.Label();
            this.Tab1UsbCmdLabel = new System.Windows.Forms.Label();
            this.Label66 = new System.Windows.Forms.Label();
            this.Tab1ComPortTextBox = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Tab1ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.Tab1ProgramButton = new System.Windows.Forms.Button();
            this.Tab1StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Tab1ToolStripStepSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tab1ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Tab1ChannelListView = new System.Windows.Forms.ListView();
            this.Channel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Frequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Repeater = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CTSS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Notes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label8 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.TableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel11 = new System.Windows.Forms.Panel();
            this.Tab2DeleteRowButton = new System.Windows.Forms.Button();
            this.Tab2InsertRowButton = new System.Windows.Forms.Button();
            this.Label70 = new System.Windows.Forms.Label();
            this.Tab2ChannelNotes = new System.Windows.Forms.TextBox();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.Tab2CtcssOff = new System.Windows.Forms.RadioButton();
            this.Tab2CtcssXmit = new System.Windows.Forms.RadioButton();
            this.Tab2CtcssXmitRec = new System.Windows.Forms.RadioButton();
            this.Label22 = new System.Windows.Forms.Label();
            this.Tab2SetChannelButton = new System.Windows.Forms.Button();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Tab2ClearChannelList = new System.Windows.Forms.Button();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.Tab2ChannelTextBox = new System.Windows.Forms.TextBox();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.Tab2ToneComboBox = new System.Windows.Forms.ComboBox();
            this.Tab2RepeaterComboBox = new System.Windows.Forms.ComboBox();
            this.Tab2KHzCombBox = new System.Windows.Forms.ComboBox();
            this.Tab2MHzComboBox = new System.Windows.Forms.ComboBox();
            this.Tab2MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Tab2FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab2OpenChannelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab2SaveChannelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab2SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab2BackToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab2KHzStepSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab2KHzToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.Panel12 = new System.Windows.Forms.Panel();
            this.tab2ChannelFileName = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Tab2StopProgramButton = new System.Windows.Forms.Button();
            this.Tab2UsbRcvdLabel = new System.Windows.Forms.Label();
            this.Label73 = new System.Windows.Forms.Label();
            this.Tab2UsbCmdLabel = new System.Windows.Forms.Label();
            this.Label68 = new System.Windows.Forms.Label();
            this.Tab2ComPortTextBox = new System.Windows.Forms.TextBox();
            this.Label38 = new System.Windows.Forms.Label();
            this.Tab2ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.Tab2ProgramButton = new System.Windows.Forms.Button();
            this.Tab2StatusStrip = new System.Windows.Forms.StatusStrip();
            this.Tab2ToolStripStepSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tab2ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Panel15 = new System.Windows.Forms.Panel();
            this.Tab2ChannelListView = new System.Windows.Forms.ListView();
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label43 = new System.Windows.Forms.Label();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.TableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel20 = new System.Windows.Forms.Panel();
            this.Tab3DeleteRowButton = new System.Windows.Forms.Button();
            this.Tab3InsertRowButton = new System.Windows.Forms.Button();
            this.Label71 = new System.Windows.Forms.Label();
            this.Tab3ChannelNotes = new System.Windows.Forms.TextBox();
            this.Panel21 = new System.Windows.Forms.Panel();
            this.Tab3CtcssOff = new System.Windows.Forms.RadioButton();
            this.Tab3CtcssXmit = new System.Windows.Forms.RadioButton();
            this.Tab3CtcssXmitRec = new System.Windows.Forms.RadioButton();
            this.Label55 = new System.Windows.Forms.Label();
            this.Tab3SetChannelButton = new System.Windows.Forms.Button();
            this.Label56 = new System.Windows.Forms.Label();
            this.Label57 = new System.Windows.Forms.Label();
            this.Tab3ClearChannelList = new System.Windows.Forms.Button();
            this.Label58 = new System.Windows.Forms.Label();
            this.Label59 = new System.Windows.Forms.Label();
            this.Tab3ChannelTextBox = new System.Windows.Forms.TextBox();
            this.Label60 = new System.Windows.Forms.Label();
            this.Label61 = new System.Windows.Forms.Label();
            this.Tab3ToneComboBox = new System.Windows.Forms.ComboBox();
            this.Tab3RepeaterComboBox = new System.Windows.Forms.ComboBox();
            this.Tab3KHzCombBox = new System.Windows.Forms.ComboBox();
            this.Tab3MHzComboBox = new System.Windows.Forms.ComboBox();
            this.Tab3MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Tab3FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab3OpenChannelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab3SaveChannelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab3SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab3BackToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab3KHzStepSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab3KHzToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.Panel22 = new System.Windows.Forms.Panel();
            this.tab3ChannelFileName = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Tab3StopProgramButton = new System.Windows.Forms.Button();
            this.Tab3UsbRcvdLabel = new System.Windows.Forms.Label();
            this.Label74 = new System.Windows.Forms.Label();
            this.Tab3UsbCmdLabel = new System.Windows.Forms.Label();
            this.Label69 = new System.Windows.Forms.Label();
            this.Tab3ComPortTextBox = new System.Windows.Forms.TextBox();
            this.Label64 = new System.Windows.Forms.Label();
            this.Tab3ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.Tab3ProgramButton = new System.Windows.Forms.Button();
            this.Tab3StatusStrip = new System.Windows.Forms.StatusStrip();
            this.Tab3ToolStripStepSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tab3ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Panel23 = new System.Windows.Forms.Panel();
            this.Tab3ChannelListView = new System.Windows.Forms.ListView();
            this.ColumnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label65 = new System.Windows.Forms.Label();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.Label11 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.ComboBox3 = new System.Windows.Forms.ComboBox();
            this.ComboBox4 = new System.Windows.Forms.ComboBox();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Label18 = new System.Windows.Forms.Label();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Label19 = new System.Windows.Forms.Label();
            this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label20 = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.Button3 = new System.Windows.Forms.Button();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label21 = new System.Windows.Forms.Label();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.Panel10 = new System.Windows.Forms.Panel();
            this.RadioButton5 = new System.Windows.Forms.RadioButton();
            this.RadioButton6 = new System.Windows.Forms.RadioButton();
            this.Label26 = new System.Windows.Forms.Label();
            this.Button5 = new System.Windows.Forms.Button();
            this.Label27 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label31 = new System.Windows.Forms.Label();
            this.Label32 = new System.Windows.Forms.Label();
            this.ComboBox5 = new System.Windows.Forms.ComboBox();
            this.ComboBox6 = new System.Windows.Forms.ComboBox();
            this.ComboBox7 = new System.Windows.Forms.ComboBox();
            this.ComboBox8 = new System.Windows.Forms.ComboBox();
            this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel13 = new System.Windows.Forms.Panel();
            this.Label39 = new System.Windows.Forms.Label();
            this.NumericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.Label40 = new System.Windows.Forms.Label();
            this.NumericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.Button8 = new System.Windows.Forms.Button();
            this.Label41 = new System.Windows.Forms.Label();
            this.ProgressBar3 = new System.Windows.Forms.ProgressBar();
            this.Button9 = new System.Windows.Forms.Button();
            this.Panel14 = new System.Windows.Forms.Panel();
            this.ListView2 = new System.Windows.Forms.ListView();
            this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label42 = new System.Windows.Forms.Label();
            this.TableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel16 = new System.Windows.Forms.Panel();
            this.Panel17 = new System.Windows.Forms.Panel();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioButton4 = new System.Windows.Forms.RadioButton();
            this.Label44 = new System.Windows.Forms.Label();
            this.Button4 = new System.Windows.Forms.Button();
            this.Label45 = new System.Windows.Forms.Label();
            this.Label46 = new System.Windows.Forms.Label();
            this.Label47 = new System.Windows.Forms.Label();
            this.Label48 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label49 = new System.Windows.Forms.Label();
            this.Label50 = new System.Windows.Forms.Label();
            this.ComboBox9 = new System.Windows.Forms.ComboBox();
            this.ComboBox10 = new System.Windows.Forms.ComboBox();
            this.ComboBox11 = new System.Windows.Forms.ComboBox();
            this.ComboBox12 = new System.Windows.Forms.ComboBox();
            this.deleteMenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.Panel18 = new System.Windows.Forms.Panel();
            this.Label51 = new System.Windows.Forms.Label();
            this.NumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.Label52 = new System.Windows.Forms.Label();
            this.NumericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.Button6 = new System.Windows.Forms.Button();
            this.Label53 = new System.Windows.Forms.Label();
            this.ProgressBar2 = new System.Windows.Forms.ProgressBar();
            this.Button7 = new System.Windows.Forms.Button();
            this.deleteStatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Panel19 = new System.Windows.Forms.Panel();
            this.ListView3 = new System.Windows.Forms.ListView();
            this.ColumnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label54 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.Tab1TableLayoutPanel1.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Tab1CtcssPanel.SuspendLayout();
            this.Tab1MenuStrip.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Tab1StatusStrip1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TableLayoutPanel7.SuspendLayout();
            this.TableLayoutPanel4.SuspendLayout();
            this.Panel11.SuspendLayout();
            this.Panel8.SuspendLayout();
            this.Tab2MenuStrip.SuspendLayout();
            this.Panel12.SuspendLayout();
            this.Tab2StatusStrip.SuspendLayout();
            this.Panel15.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TableLayoutPanel8.SuspendLayout();
            this.TableLayoutPanel10.SuspendLayout();
            this.Panel20.SuspendLayout();
            this.Panel21.SuspendLayout();
            this.Tab3MenuStrip.SuspendLayout();
            this.Panel22.SuspendLayout();
            this.Tab3StatusStrip.SuspendLayout();
            this.Panel23.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.TableLayoutPanel3.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).BeginInit();
            this.Panel7.SuspendLayout();
            this.Panel9.SuspendLayout();
            this.Panel10.SuspendLayout();
            this.TableLayoutPanel5.SuspendLayout();
            this.TableLayoutPanel6.SuspendLayout();
            this.Panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown6)).BeginInit();
            this.Panel14.SuspendLayout();
            this.TableLayoutPanel9.SuspendLayout();
            this.Panel16.SuspendLayout();
            this.Panel17.SuspendLayout();
            this.deleteMenuStrip1.SuspendLayout();
            this.Panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown4)).BeginInit();
            this.deleteStatusStrip1.SuspendLayout();
            this.Panel19.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            this.OpenFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPage1);
            this.TabControl.Controls.Add(this.TabPage2);
            this.TabControl.Controls.Add(this.TabPage3);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1014, 669);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 0;
            this.TabControl.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl_Deselecting);
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.Tab1TableLayoutPanel1);
            this.TabPage1.Location = new System.Drawing.Point(4, 34);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1006, 631);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "TabPage1";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // Tab1TableLayoutPanel1
            // 
            this.Tab1TableLayoutPanel1.ColumnCount = 2;
            this.Tab1TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.78069F));
            this.Tab1TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.21931F));
            this.Tab1TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 0, 0);
            this.Tab1TableLayoutPanel1.Controls.Add(this.Panel3, 1, 0);
            this.Tab1TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab1TableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.Tab1TableLayoutPanel1.Name = "Tab1TableLayoutPanel1";
            this.Tab1TableLayoutPanel1.RowCount = 1;
            this.Tab1TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tab1TableLayoutPanel1.Size = new System.Drawing.Size(1000, 625);
            this.Tab1TableLayoutPanel1.TabIndex = 1;
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.ColumnCount = 1;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel2.Controls.Add(this.Panel1, 0, 0);
            this.TableLayoutPanel2.Controls.Add(this.Panel2, 0, 1);
            this.TableLayoutPanel2.Controls.Add(this.Tab1StatusStrip1, 0, 2);
            this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 3;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.98658F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.01342F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(461, 619);
            this.TableLayoutPanel2.TabIndex = 0;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Silver;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.Tab1DeleteRowButton);
            this.Panel1.Controls.Add(this.Tab1InsertRowButton);
            this.Panel1.Controls.Add(this.Label67);
            this.Panel1.Controls.Add(this.Tab1ChannelNotes);
            this.Panel1.Controls.Add(this.Tab1CtcssPanel);
            this.Panel1.Controls.Add(this.Tab1CtcssLabel);
            this.Panel1.Controls.Add(this.Tab1SetChannelButton);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Tab1ClearChannelList);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Tab1ChannelTextBox);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Tab1ToneComboBox);
            this.Panel1.Controls.Add(this.Tab1RepeaterComboBox);
            this.Panel1.Controls.Add(this.Tab1KHzCombBox);
            this.Panel1.Controls.Add(this.Tab1MHzComboBox);
            this.Panel1.Controls.Add(this.Tab1MenuStrip);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(455, 280);
            this.Panel1.TabIndex = 0;
            // 
            // Tab1DeleteRowButton
            // 
            this.Tab1DeleteRowButton.Location = new System.Drawing.Point(268, 243);
            this.Tab1DeleteRowButton.Name = "Tab1DeleteRowButton";
            this.Tab1DeleteRowButton.Size = new System.Drawing.Size(139, 23);
            this.Tab1DeleteRowButton.TabIndex = 24;
            this.Tab1DeleteRowButton.Text = "Delete Row";
            this.Tab1DeleteRowButton.UseVisualStyleBackColor = true;
            this.Tab1DeleteRowButton.Click += new System.EventHandler(this.Tab1DeleteRowButton_Click);
            // 
            // Tab1InsertRowButton
            // 
            this.Tab1InsertRowButton.Location = new System.Drawing.Point(268, 214);
            this.Tab1InsertRowButton.Name = "Tab1InsertRowButton";
            this.Tab1InsertRowButton.Size = new System.Drawing.Size(140, 23);
            this.Tab1InsertRowButton.TabIndex = 22;
            this.Tab1InsertRowButton.Text = "Insert Row";
            this.Tab1InsertRowButton.UseVisualStyleBackColor = true;
            this.Tab1InsertRowButton.Click += new System.EventHandler(this.Button11_Click);
            // 
            // Label67
            // 
            this.Label67.AutoSize = true;
            this.Label67.Location = new System.Drawing.Point(7, 103);
            this.Label67.Name = "Label67";
            this.Label67.Size = new System.Drawing.Size(155, 25);
            this.Label67.TabIndex = 19;
            this.Label67.Text = "Channel Notes";
            // 
            // Tab1ChannelNotes
            // 
            this.Tab1ChannelNotes.Location = new System.Drawing.Point(7, 122);
            this.Tab1ChannelNotes.MaxLength = 25;
            this.Tab1ChannelNotes.Name = "Tab1ChannelNotes";
            this.Tab1ChannelNotes.Size = new System.Drawing.Size(335, 30);
            this.Tab1ChannelNotes.TabIndex = 18;
            // 
            // Tab1CtcssPanel
            // 
            this.Tab1CtcssPanel.Controls.Add(this.Tab1CtcssOff);
            this.Tab1CtcssPanel.Controls.Add(this.Tab1CtcssXmit);
            this.Tab1CtcssPanel.Controls.Add(this.Tab1CtcssXmitRec);
            this.Tab1CtcssPanel.Location = new System.Drawing.Point(348, 76);
            this.Tab1CtcssPanel.Name = "Tab1CtcssPanel";
            this.Tab1CtcssPanel.Size = new System.Drawing.Size(100, 72);
            this.Tab1CtcssPanel.TabIndex = 16;
            // 
            // Tab1CtcssOff
            // 
            this.Tab1CtcssOff.AutoSize = true;
            this.Tab1CtcssOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1CtcssOff.Location = new System.Drawing.Point(9, 46);
            this.Tab1CtcssOff.Name = "Tab1CtcssOff";
            this.Tab1CtcssOff.Size = new System.Drawing.Size(66, 29);
            this.Tab1CtcssOff.TabIndex = 16;
            this.Tab1CtcssOff.TabStop = true;
            this.Tab1CtcssOff.Text = "Off";
            this.Tab1CtcssOff.UseVisualStyleBackColor = true;
            this.Tab1CtcssOff.CheckedChanged += new System.EventHandler(this.Tab1CtcssOff_CheckedChanged);
            // 
            // Tab1CtcssXmit
            // 
            this.Tab1CtcssXmit.AutoSize = true;
            this.Tab1CtcssXmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1CtcssXmit.Location = new System.Drawing.Point(9, 5);
            this.Tab1CtcssXmit.Name = "Tab1CtcssXmit";
            this.Tab1CtcssXmit.Size = new System.Drawing.Size(80, 29);
            this.Tab1CtcssXmit.TabIndex = 14;
            this.Tab1CtcssXmit.TabStop = true;
            this.Tab1CtcssXmit.Text = "Xmit";
            this.Tab1CtcssXmit.UseVisualStyleBackColor = true;
            this.Tab1CtcssXmit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tab1CtcssXmit_MouseDown);
            // 
            // Tab1CtcssXmitRec
            // 
            this.Tab1CtcssXmitRec.AutoSize = true;
            this.Tab1CtcssXmitRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1CtcssXmitRec.Location = new System.Drawing.Point(9, 26);
            this.Tab1CtcssXmitRec.Name = "Tab1CtcssXmitRec";
            this.Tab1CtcssXmitRec.Size = new System.Drawing.Size(124, 29);
            this.Tab1CtcssXmitRec.TabIndex = 15;
            this.Tab1CtcssXmitRec.TabStop = true;
            this.Tab1CtcssXmitRec.Text = "Xmit/Rec";
            this.Tab1CtcssXmitRec.UseVisualStyleBackColor = true;
            this.Tab1CtcssXmitRec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tab1CtcssXmit_MouseDown);
            // 
            // Tab1CtcssLabel
            // 
            this.Tab1CtcssLabel.AutoSize = true;
            this.Tab1CtcssLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1CtcssLabel.Location = new System.Drawing.Point(359, 60);
            this.Tab1CtcssLabel.Name = "Tab1CtcssLabel";
            this.Tab1CtcssLabel.Size = new System.Drawing.Size(88, 25);
            this.Tab1CtcssLabel.TabIndex = 13;
            this.Tab1CtcssLabel.Text = "CTCSS";
            // 
            // Tab1SetChannelButton
            // 
            this.Tab1SetChannelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1SetChannelButton.Location = new System.Drawing.Point(268, 154);
            this.Tab1SetChannelButton.Name = "Tab1SetChannelButton";
            this.Tab1SetChannelButton.Size = new System.Drawing.Size(140, 48);
            this.Tab1SetChannelButton.TabIndex = 11;
            this.Tab1SetChannelButton.Text = "Set/Update Channel";
            this.Tab1SetChannelButton.UseVisualStyleBackColor = true;
            this.Tab1SetChannelButton.Click += new System.EventHandler(this.Tab1SetChannelButton_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(115, 24);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(276, 37);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Channel Settings";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(294, 60);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(62, 25);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "Tone";
            // 
            // Tab1ClearChannelList
            // 
            this.Tab1ClearChannelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1ClearChannelList.Location = new System.Drawing.Point(138, 209);
            this.Tab1ClearChannelList.Name = "Tab1ClearChannelList";
            this.Tab1ClearChannelList.Size = new System.Drawing.Size(111, 43);
            this.Tab1ClearChannelList.TabIndex = 12;
            this.Tab1ClearChannelList.Text = "Clear Channel List";
            this.Tab1ClearChannelList.UseVisualStyleBackColor = true;
            this.Tab1ClearChannelList.Click += new System.EventHandler(this.ButtonClearChannelList1_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(207, 60);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(99, 25);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Repeater";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(146, 60);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(53, 25);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "KHz";
            // 
            // Tab1ChannelTextBox
            // 
            this.Tab1ChannelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1ChannelTextBox.Location = new System.Drawing.Point(7, 77);
            this.Tab1ChannelTextBox.Name = "Tab1ChannelTextBox";
            this.Tab1ChannelTextBox.ReadOnly = true;
            this.Tab1ChannelTextBox.Size = new System.Drawing.Size(46, 28);
            this.Tab1ChannelTextBox.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(7, 61);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(61, 25);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "CH #";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(75, 60);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 25);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "MHz";
            // 
            // Tab1ToneComboBox
            // 
            this.Tab1ToneComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1ToneComboBox.FormattingEnabled = true;
            this.Tab1ToneComboBox.Items.AddRange(new object[] {
            "OFF",
            "67.0",
            "71.9",
            "74.4",
            "77.0",
            "79.7",
            "82.5",
            "85.4",
            "88.5",
            "91.5",
            "94.8",
            "97.4",
            "100.0",
            "103.5",
            "107.2",
            "110.9",
            "114.8",
            "118.8",
            "123.0",
            "127.3",
            "131.8",
            "136.5",
            "141.3",
            "146.2",
            "151.4",
            "156.7",
            "162.2",
            "167.9",
            "173.8",
            "179.9",
            "186.2",
            "192.8",
            "203.5",
            "210.7",
            "218.1",
            "225.7",
            "233.6",
            "241.8",
            "250.3"});
            this.Tab1ToneComboBox.Location = new System.Drawing.Point(291, 76);
            this.Tab1ToneComboBox.Name = "Tab1ToneComboBox";
            this.Tab1ToneComboBox.Size = new System.Drawing.Size(58, 30);
            this.Tab1ToneComboBox.TabIndex = 3;
            this.Tab1ToneComboBox.SelectedIndexChanged += new System.EventHandler(this.Tab1ToneComboBox_SelectedIndexChanged);
            this.Tab1ToneComboBox.DropDownClosed += new System.EventHandler(this.Tab1ToneComboBox_DropDownClosed);
            // 
            // Tab1RepeaterComboBox
            // 
            this.Tab1RepeaterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1RepeaterComboBox.FormattingEnabled = true;
            this.Tab1RepeaterComboBox.Items.AddRange(new object[] {
            "PLUS",
            "MINUS",
            "SIMPLEX"});
            this.Tab1RepeaterComboBox.Location = new System.Drawing.Point(204, 76);
            this.Tab1RepeaterComboBox.Name = "Tab1RepeaterComboBox";
            this.Tab1RepeaterComboBox.Size = new System.Drawing.Size(83, 30);
            this.Tab1RepeaterComboBox.TabIndex = 2;
            // 
            // Tab1KHzCombBox
            // 
            this.Tab1KHzCombBox.DropDownWidth = 43;
            this.Tab1KHzCombBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1KHzCombBox.FormattingEnabled = true;
            this.Tab1KHzCombBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "210",
            "220",
            "230",
            "240",
            "250",
            "260",
            "270",
            "280",
            "290",
            "300",
            "310",
            "320",
            "330",
            "340",
            "350",
            "360",
            "370",
            "380",
            "390",
            "400",
            "410",
            "420",
            "430",
            "440",
            "450",
            "460",
            "470",
            "480",
            "490",
            "500",
            "510",
            "520",
            "530",
            "540",
            "550",
            "560",
            "570",
            "580",
            "590",
            "600",
            "610",
            "620",
            "630",
            "640",
            "650",
            "660",
            "670",
            "680",
            "690",
            "700",
            "710",
            "720",
            "730",
            "740",
            "750",
            "760",
            "770",
            "780",
            "790",
            "800",
            "810",
            "820",
            "830",
            "840",
            "850",
            "860",
            "870",
            "880",
            "890",
            "900",
            "910",
            "920",
            "930",
            "940",
            "950",
            "960",
            "970",
            "980",
            "990"});
            this.Tab1KHzCombBox.Location = new System.Drawing.Point(134, 76);
            this.Tab1KHzCombBox.MaxDropDownItems = 10;
            this.Tab1KHzCombBox.Name = "Tab1KHzCombBox";
            this.Tab1KHzCombBox.Size = new System.Drawing.Size(66, 30);
            this.Tab1KHzCombBox.TabIndex = 1;
            this.Tab1KHzCombBox.SelectedIndexChanged += new System.EventHandler(this.Tab1KHzCombBox_SelectedIndexChanged);
            // 
            // Tab1MHzComboBox
            // 
            this.Tab1MHzComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1MHzComboBox.FormattingEnabled = true;
            this.Tab1MHzComboBox.Items.AddRange(new object[] {
            "BLANK",
            "146",
            "147",
            "148",
            "149",
            "150"});
            this.Tab1MHzComboBox.Location = new System.Drawing.Point(60, 76);
            this.Tab1MHzComboBox.Name = "Tab1MHzComboBox";
            this.Tab1MHzComboBox.Size = new System.Drawing.Size(70, 30);
            this.Tab1MHzComboBox.TabIndex = 0;
            this.Tab1MHzComboBox.SelectedIndexChanged += new System.EventHandler(this.Tab1MHzComboBox_SelectedIndexChanged);
            // 
            // Tab1MenuStrip
            // 
            this.Tab1MenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Tab1MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Tab1MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab1FileToolStripMenuItem,
            this.Tab1SettingsToolStripMenuItem});
            this.Tab1MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.Tab1MenuStrip.Name = "Tab1MenuStrip";
            this.Tab1MenuStrip.Size = new System.Drawing.Size(451, 33);
            this.Tab1MenuStrip.TabIndex = 17;
            this.Tab1MenuStrip.Text = "MenuStrip1";
            // 
            // Tab1FileToolStripMenuItem
            // 
            this.Tab1FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab1OpenChannelFileToolStripMenuItem,
            this.Tab1SaveChannelFileToolStripMenuItem});
            this.Tab1FileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Tab1FileToolStripMenuItem.Name = "Tab1FileToolStripMenuItem";
            this.Tab1FileToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.Tab1FileToolStripMenuItem.Text = "File";
            // 
            // Tab1OpenChannelFileToolStripMenuItem
            // 
            this.Tab1OpenChannelFileToolStripMenuItem.Name = "Tab1OpenChannelFileToolStripMenuItem";
            this.Tab1OpenChannelFileToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.Tab1OpenChannelFileToolStripMenuItem.Text = "Open Channel File";
            this.Tab1OpenChannelFileToolStripMenuItem.Click += new System.EventHandler(this.Tab1OpenChannelFileToolStripMenuItem_Click);
            // 
            // Tab1SaveChannelFileToolStripMenuItem
            // 
            this.Tab1SaveChannelFileToolStripMenuItem.Name = "Tab1SaveChannelFileToolStripMenuItem";
            this.Tab1SaveChannelFileToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.Tab1SaveChannelFileToolStripMenuItem.Text = "Save Channel File";
            this.Tab1SaveChannelFileToolStripMenuItem.Click += new System.EventHandler(this.Tab1SaveChannelFileToolStripMenuItem_Click);
            // 
            // Tab1SettingsToolStripMenuItem
            // 
            this.Tab1SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab1BackToMainMenuToolStripMenuItem,
            this.Tab1KHzStepSizeToolStripMenuItem});
            this.Tab1SettingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Tab1SettingsToolStripMenuItem.Name = "Tab1SettingsToolStripMenuItem";
            this.Tab1SettingsToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.Tab1SettingsToolStripMenuItem.Text = "Options";
            // 
            // Tab1BackToMainMenuToolStripMenuItem
            // 
            this.Tab1BackToMainMenuToolStripMenuItem.Name = "Tab1BackToMainMenuToolStripMenuItem";
            this.Tab1BackToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.Tab1BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu";
            this.Tab1BackToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.Tab1BackToMainMenuToolStripMenuItem_Click);
            // 
            // Tab1KHzStepSizeToolStripMenuItem
            // 
            this.Tab1KHzStepSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab1KHzToolStripComboBox});
            this.Tab1KHzStepSizeToolStripMenuItem.Name = "Tab1KHzStepSizeToolStripMenuItem";
            this.Tab1KHzStepSizeToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.Tab1KHzStepSizeToolStripMenuItem.Text = "kHz Step Size";
            this.Tab1KHzStepSizeToolStripMenuItem.Click += new System.EventHandler(this.Tab1KHzStepSizeToolStripMenuItem_Click);
            // 
            // Tab1KHzToolStripComboBox
            // 
            this.Tab1KHzToolStripComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Tab1KHzToolStripComboBox.Items.AddRange(new object[] {
            "10",
            "12.5",
            "5",
            "25"});
            this.Tab1KHzToolStripComboBox.Name = "Tab1KHzToolStripComboBox";
            this.Tab1KHzToolStripComboBox.Size = new System.Drawing.Size(121, 33);
            this.Tab1KHzToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.Tab1KHzToolStripComboBox_SelectedIndexChanged);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Silver;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel2.Controls.Add(this.textBoxSerialCommands);
            this.Panel2.Controls.Add(this.tab1ChannelFileName);
            this.Panel2.Controls.Add(this.Label9);
            this.Panel2.Controls.Add(this.Tab1StopProgramButton);
            this.Panel2.Controls.Add(this.Tab1UsbRcvdLabel);
            this.Panel2.Controls.Add(this.Label72);
            this.Panel2.Controls.Add(this.Tab1UsbCmdLabel);
            this.Panel2.Controls.Add(this.Label66);
            this.Panel2.Controls.Add(this.Tab1ComPortTextBox);
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.Tab1ProgressBar1);
            this.Panel2.Controls.Add(this.Tab1ProgramButton);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(3, 289);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(455, 304);
            this.Panel2.TabIndex = 1;
            // 
            // textBoxSerialCommands
            // 
            this.textBoxSerialCommands.Location = new System.Drawing.Point(7, 212);
            this.textBoxSerialCommands.Multiline = true;
            this.textBoxSerialCommands.Name = "textBoxSerialCommands";
            this.textBoxSerialCommands.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSerialCommands.Size = new System.Drawing.Size(439, 85);
            this.textBoxSerialCommands.TabIndex = 27;
            // 
            // tab1ChannelFileName
            // 
            this.tab1ChannelFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tab1ChannelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1ChannelFileName.Location = new System.Drawing.Point(149, 173);
            this.tab1ChannelFileName.Name = "tab1ChannelFileName";
            this.tab1ChannelFileName.Size = new System.Drawing.Size(298, 25);
            this.tab1ChannelFileName.TabIndex = 26;
            this.tab1ChannelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab1ChannelFileName.Visible = false;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(8, 177);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(124, 25);
            this.Label9.TabIndex = 25;
            this.Label9.Text = "Module File";
            this.Label9.Visible = false;
            // 
            // Tab1StopProgramButton
            // 
            this.Tab1StopProgramButton.Location = new System.Drawing.Point(45, 50);
            this.Tab1StopProgramButton.Name = "Tab1StopProgramButton";
            this.Tab1StopProgramButton.Size = new System.Drawing.Size(117, 44);
            this.Tab1StopProgramButton.TabIndex = 24;
            this.Tab1StopProgramButton.Text = "Stop Programming";
            this.Tab1StopProgramButton.UseVisualStyleBackColor = true;
            this.Tab1StopProgramButton.Click += new System.EventHandler(this.StopProgramButton_Click);
            // 
            // Tab1UsbRcvdLabel
            // 
            this.Tab1UsbRcvdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tab1UsbRcvdLabel.Location = new System.Drawing.Point(352, 134);
            this.Tab1UsbRcvdLabel.Name = "Tab1UsbRcvdLabel";
            this.Tab1UsbRcvdLabel.Size = new System.Drawing.Size(96, 25);
            this.Tab1UsbRcvdLabel.TabIndex = 23;
            this.Tab1UsbRcvdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label72
            // 
            this.Label72.AutoSize = true;
            this.Label72.Location = new System.Drawing.Point(277, 138);
            this.Label72.Name = "Label72";
            this.Label72.Size = new System.Drawing.Size(94, 25);
            this.Label72.TabIndex = 22;
            this.Label72.Text = "received";
            // 
            // Tab1UsbCmdLabel
            // 
            this.Tab1UsbCmdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tab1UsbCmdLabel.Location = new System.Drawing.Point(168, 134);
            this.Tab1UsbCmdLabel.Name = "Tab1UsbCmdLabel";
            this.Tab1UsbCmdLabel.Size = new System.Drawing.Size(96, 25);
            this.Tab1UsbCmdLabel.TabIndex = 21;
            this.Tab1UsbCmdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label66
            // 
            this.Label66.Location = new System.Drawing.Point(10, 134);
            this.Label66.Name = "Label66";
            this.Label66.Size = new System.Drawing.Size(179, 25);
            this.Label66.TabIndex = 20;
            this.Label66.Text = "Serial command sent";
            this.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab1ComPortTextBox
            // 
            this.Tab1ComPortTextBox.Enabled = false;
            this.Tab1ComPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1ComPortTextBox.Location = new System.Drawing.Point(347, 13);
            this.Tab1ComPortTextBox.Multiline = true;
            this.Tab1ComPortTextBox.Name = "Tab1ComPortTextBox";
            this.Tab1ComPortTextBox.Size = new System.Drawing.Size(87, 80);
            this.Tab1ComPortTextBox.TabIndex = 19;
            this.Tab1ComPortTextBox.Text = "test1";
            this.Tab1ComPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tab1ComPortTextBox.Visible = false;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(80, 10);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(320, 37);
            this.Label7.TabIndex = 11;
            this.Label7.Text = "Radio Programming";
            // 
            // Tab1ProgressBar1
            // 
            this.Tab1ProgressBar1.Location = new System.Drawing.Point(53, 108);
            this.Tab1ProgressBar1.Name = "Tab1ProgressBar1";
            this.Tab1ProgressBar1.Size = new System.Drawing.Size(335, 16);
            this.Tab1ProgressBar1.TabIndex = 1;
            // 
            // Tab1ProgramButton
            // 
            this.Tab1ProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1ProgramButton.Location = new System.Drawing.Point(215, 50);
            this.Tab1ProgramButton.Name = "Tab1ProgramButton";
            this.Tab1ProgramButton.Size = new System.Drawing.Size(98, 44);
            this.Tab1ProgramButton.TabIndex = 0;
            this.Tab1ProgramButton.Text = "Program Radio Channels";
            this.Tab1ProgramButton.UseVisualStyleBackColor = true;
            this.Tab1ProgramButton.Click += new System.EventHandler(this.ButtonProgramBandModule1_Click);
            // 
            // Tab1StatusStrip1
            // 
            this.Tab1StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Tab1StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab1ToolStripStepSize,
            this.Tab1ToolStripStatusLabel});
            this.Tab1StatusStrip1.Location = new System.Drawing.Point(0, 596);
            this.Tab1StatusStrip1.Name = "Tab1StatusStrip1";
            this.Tab1StatusStrip1.Size = new System.Drawing.Size(461, 23);
            this.Tab1StatusStrip1.TabIndex = 2;
            this.Tab1StatusStrip1.Text = "StatusStrip1";
            // 
            // Tab1ToolStripStepSize
            // 
            this.Tab1ToolStripStepSize.Name = "Tab1ToolStripStepSize";
            this.Tab1ToolStripStepSize.Size = new System.Drawing.Size(180, 16);
            this.Tab1ToolStripStepSize.Text = "ToolStripStatusLabel1";
            // 
            // Tab1ToolStripStatusLabel
            // 
            this.Tab1ToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Tab1ToolStripStatusLabel.Name = "Tab1ToolStripStatusLabel";
            this.Tab1ToolStripStatusLabel.Size = new System.Drawing.Size(196, 16);
            this.Tab1ToolStripStatusLabel.Text = "ToolStripStatusLabel2";
            // 
            // Panel3
            // 
            this.Panel3.AutoSize = true;
            this.Panel3.BackColor = System.Drawing.Color.Silver;
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel3.Controls.Add(this.Tab1ChannelListView);
            this.Panel3.Controls.Add(this.Label8);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(470, 3);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(527, 619);
            this.Panel3.TabIndex = 1;
            // 
            // Tab1ChannelListView
            // 
            this.Tab1ChannelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Channel,
            this.Frequency,
            this.Repeater,
            this.Tone,
            this.CTSS,
            this.Notes});
            this.Tab1ChannelListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1ChannelListView.FullRowSelect = true;
            this.Tab1ChannelListView.GridLines = true;
            this.Tab1ChannelListView.HideSelection = false;
            this.Tab1ChannelListView.LabelWrap = false;
            this.Tab1ChannelListView.Location = new System.Drawing.Point(0, 34);
            this.Tab1ChannelListView.MultiSelect = false;
            this.Tab1ChannelListView.Name = "Tab1ChannelListView";
            this.Tab1ChannelListView.Size = new System.Drawing.Size(523, 583);
            this.Tab1ChannelListView.TabIndex = 12;
            this.Tab1ChannelListView.UseCompatibleStateImageBehavior = false;
            this.Tab1ChannelListView.View = System.Windows.Forms.View.Details;
            this.Tab1ChannelListView.SelectedIndexChanged += new System.EventHandler(this.Tab1ChannelListView_SelectedIndexChanged);
            // 
            // Channel
            // 
            this.Channel.Text = "CH#";
            this.Channel.Width = 42;
            // 
            // Frequency
            // 
            this.Frequency.Text = "Frequency";
            this.Frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Frequency.Width = 91;
            // 
            // Repeater
            // 
            this.Repeater.Text = "Repeater";
            this.Repeater.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Repeater.Width = 81;
            // 
            // Tone
            // 
            this.Tone.Text = "Tone";
            this.Tone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tone.Width = 50;
            // 
            // CTSS
            // 
            this.CTSS.Text = " CTCSS";
            this.CTSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CTSS.Width = 80;
            // 
            // Notes
            // 
            this.Notes.Text = "Notes";
            this.Notes.Width = 375;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(176, 10);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(207, 37);
            this.Label8.TabIndex = 11;
            this.Label8.Text = "Channel List";
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.TableLayoutPanel7);
            this.TabPage2.Location = new System.Drawing.Point(4, 34);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(1006, 631);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "TabPage2";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel7
            // 
            this.TableLayoutPanel7.ColumnCount = 2;
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.7F));
            this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.3F));
            this.TableLayoutPanel7.Controls.Add(this.TableLayoutPanel4, 0, 0);
            this.TableLayoutPanel7.Controls.Add(this.Panel15, 1, 0);
            this.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel7.Name = "TableLayoutPanel7";
            this.TableLayoutPanel7.RowCount = 1;
            this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel7.Size = new System.Drawing.Size(1000, 625);
            this.TableLayoutPanel7.TabIndex = 2;
            // 
            // TableLayoutPanel4
            // 
            this.TableLayoutPanel4.ColumnCount = 1;
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel4.Controls.Add(this.Panel11, 0, 0);
            this.TableLayoutPanel4.Controls.Add(this.Panel12, 0, 1);
            this.TableLayoutPanel4.Controls.Add(this.Tab2StatusStrip, 0, 2);
            this.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel4.Name = "TableLayoutPanel4";
            this.TableLayoutPanel4.RowCount = 3;
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TableLayoutPanel4.Size = new System.Drawing.Size(461, 619);
            this.TableLayoutPanel4.TabIndex = 0;
            // 
            // Panel11
            // 
            this.Panel11.BackColor = System.Drawing.Color.Silver;
            this.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel11.Controls.Add(this.Tab2DeleteRowButton);
            this.Panel11.Controls.Add(this.Tab2InsertRowButton);
            this.Panel11.Controls.Add(this.Label70);
            this.Panel11.Controls.Add(this.Tab2ChannelNotes);
            this.Panel11.Controls.Add(this.Panel8);
            this.Panel11.Controls.Add(this.Label22);
            this.Panel11.Controls.Add(this.Tab2SetChannelButton);
            this.Panel11.Controls.Add(this.Label23);
            this.Panel11.Controls.Add(this.Label24);
            this.Panel11.Controls.Add(this.Tab2ClearChannelList);
            this.Panel11.Controls.Add(this.Label25);
            this.Panel11.Controls.Add(this.Label33);
            this.Panel11.Controls.Add(this.Tab2ChannelTextBox);
            this.Panel11.Controls.Add(this.Label34);
            this.Panel11.Controls.Add(this.Label35);
            this.Panel11.Controls.Add(this.Tab2ToneComboBox);
            this.Panel11.Controls.Add(this.Tab2RepeaterComboBox);
            this.Panel11.Controls.Add(this.Tab2KHzCombBox);
            this.Panel11.Controls.Add(this.Tab2MHzComboBox);
            this.Panel11.Controls.Add(this.Tab2MenuStrip);
            this.Panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel11.Location = new System.Drawing.Point(3, 3);
            this.Panel11.Name = "Panel11";
            this.Panel11.Size = new System.Drawing.Size(455, 335);
            this.Panel11.TabIndex = 0;
            // 
            // Tab2DeleteRowButton
            // 
            this.Tab2DeleteRowButton.Location = new System.Drawing.Point(268, 243);
            this.Tab2DeleteRowButton.Name = "Tab2DeleteRowButton";
            this.Tab2DeleteRowButton.Size = new System.Drawing.Size(139, 23);
            this.Tab2DeleteRowButton.TabIndex = 23;
            this.Tab2DeleteRowButton.Text = "Delete Row";
            this.Tab2DeleteRowButton.UseVisualStyleBackColor = true;
            this.Tab2DeleteRowButton.Click += new System.EventHandler(this.Tab2DeleteRowButton_Click);
            // 
            // Tab2InsertRowButton
            // 
            this.Tab2InsertRowButton.Location = new System.Drawing.Point(268, 214);
            this.Tab2InsertRowButton.Name = "Tab2InsertRowButton";
            this.Tab2InsertRowButton.Size = new System.Drawing.Size(140, 23);
            this.Tab2InsertRowButton.TabIndex = 22;
            this.Tab2InsertRowButton.Text = "Insert Row";
            this.Tab2InsertRowButton.UseVisualStyleBackColor = true;
            this.Tab2InsertRowButton.Click += new System.EventHandler(this.Button11_Click);
            // 
            // Label70
            // 
            this.Label70.AutoSize = true;
            this.Label70.Location = new System.Drawing.Point(7, 103);
            this.Label70.Name = "Label70";
            this.Label70.Size = new System.Drawing.Size(155, 25);
            this.Label70.TabIndex = 20;
            this.Label70.Text = "Channel Notes";
            // 
            // Tab2ChannelNotes
            // 
            this.Tab2ChannelNotes.Location = new System.Drawing.Point(7, 122);
            this.Tab2ChannelNotes.MaxLength = 10;
            this.Tab2ChannelNotes.Name = "Tab2ChannelNotes";
            this.Tab2ChannelNotes.Size = new System.Drawing.Size(335, 30);
            this.Tab2ChannelNotes.TabIndex = 19;
            // 
            // Panel8
            // 
            this.Panel8.Controls.Add(this.Tab2CtcssOff);
            this.Panel8.Controls.Add(this.Tab2CtcssXmit);
            this.Panel8.Controls.Add(this.Tab2CtcssXmitRec);
            this.Panel8.Location = new System.Drawing.Point(348, 76);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(100, 72);
            this.Panel8.TabIndex = 16;
            // 
            // Tab2CtcssOff
            // 
            this.Tab2CtcssOff.AutoSize = true;
            this.Tab2CtcssOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2CtcssOff.Location = new System.Drawing.Point(9, 46);
            this.Tab2CtcssOff.Name = "Tab2CtcssOff";
            this.Tab2CtcssOff.Size = new System.Drawing.Size(66, 29);
            this.Tab2CtcssOff.TabIndex = 17;
            this.Tab2CtcssOff.TabStop = true;
            this.Tab2CtcssOff.Text = "Off";
            this.Tab2CtcssOff.UseVisualStyleBackColor = true;
            this.Tab2CtcssOff.CheckedChanged += new System.EventHandler(this.Tab2CtcssOff_CheckedChanged);
            // 
            // Tab2CtcssXmit
            // 
            this.Tab2CtcssXmit.AutoSize = true;
            this.Tab2CtcssXmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2CtcssXmit.Location = new System.Drawing.Point(9, 5);
            this.Tab2CtcssXmit.Name = "Tab2CtcssXmit";
            this.Tab2CtcssXmit.Size = new System.Drawing.Size(80, 29);
            this.Tab2CtcssXmit.TabIndex = 14;
            this.Tab2CtcssXmit.TabStop = true;
            this.Tab2CtcssXmit.Text = "Xmit";
            this.Tab2CtcssXmit.UseVisualStyleBackColor = true;
            this.Tab2CtcssXmit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tab2CtcssXmit_MouseDown);
            // 
            // Tab2CtcssXmitRec
            // 
            this.Tab2CtcssXmitRec.AutoSize = true;
            this.Tab2CtcssXmitRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2CtcssXmitRec.Location = new System.Drawing.Point(9, 26);
            this.Tab2CtcssXmitRec.Name = "Tab2CtcssXmitRec";
            this.Tab2CtcssXmitRec.Size = new System.Drawing.Size(124, 29);
            this.Tab2CtcssXmitRec.TabIndex = 15;
            this.Tab2CtcssXmitRec.TabStop = true;
            this.Tab2CtcssXmitRec.Text = "Xmit/Rec";
            this.Tab2CtcssXmitRec.UseVisualStyleBackColor = true;
            this.Tab2CtcssXmitRec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tab2CtcssXmit_MouseDown);
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.Location = new System.Drawing.Point(359, 60);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(88, 25);
            this.Label22.TabIndex = 13;
            this.Label22.Text = "CTCSS";
            // 
            // Tab2SetChannelButton
            // 
            this.Tab2SetChannelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2SetChannelButton.Location = new System.Drawing.Point(268, 154);
            this.Tab2SetChannelButton.Name = "Tab2SetChannelButton";
            this.Tab2SetChannelButton.Size = new System.Drawing.Size(140, 48);
            this.Tab2SetChannelButton.TabIndex = 11;
            this.Tab2SetChannelButton.Text = "Set/Update Channel";
            this.Tab2SetChannelButton.UseVisualStyleBackColor = true;
            this.Tab2SetChannelButton.Click += new System.EventHandler(this.Tab2SetChannelButton_Click);
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.Location = new System.Drawing.Point(115, 24);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(276, 37);
            this.Label23.TabIndex = 10;
            this.Label23.Text = "Channel Settings";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.Location = new System.Drawing.Point(294, 60);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(62, 25);
            this.Label24.TabIndex = 9;
            this.Label24.Text = "Tone";
            // 
            // Tab2ClearChannelList
            // 
            this.Tab2ClearChannelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2ClearChannelList.Location = new System.Drawing.Point(138, 209);
            this.Tab2ClearChannelList.Name = "Tab2ClearChannelList";
            this.Tab2ClearChannelList.Size = new System.Drawing.Size(111, 43);
            this.Tab2ClearChannelList.TabIndex = 12;
            this.Tab2ClearChannelList.Text = "Clear Channel List";
            this.Tab2ClearChannelList.UseVisualStyleBackColor = true;
            this.Tab2ClearChannelList.Click += new System.EventHandler(this.ButtonClearChannelList2_Click);
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label25.Location = new System.Drawing.Point(207, 60);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(99, 25);
            this.Label25.TabIndex = 8;
            this.Label25.Text = "Repeater";
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label33.Location = new System.Drawing.Point(146, 60);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(53, 25);
            this.Label33.TabIndex = 7;
            this.Label33.Text = "KHz";
            // 
            // Tab2ChannelTextBox
            // 
            this.Tab2ChannelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2ChannelTextBox.Location = new System.Drawing.Point(7, 77);
            this.Tab2ChannelTextBox.Name = "Tab2ChannelTextBox";
            this.Tab2ChannelTextBox.ReadOnly = true;
            this.Tab2ChannelTextBox.Size = new System.Drawing.Size(46, 28);
            this.Tab2ChannelTextBox.TabIndex = 6;
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label34.Location = new System.Drawing.Point(7, 61);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(61, 25);
            this.Label34.TabIndex = 5;
            this.Label34.Text = "CH #";
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label35.Location = new System.Drawing.Point(75, 60);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(56, 25);
            this.Label35.TabIndex = 4;
            this.Label35.Text = "MHz";
            // 
            // Tab2ToneComboBox
            // 
            this.Tab2ToneComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2ToneComboBox.FormattingEnabled = true;
            this.Tab2ToneComboBox.Items.AddRange(new object[] {
            "OFF",
            "67.0",
            "71.9",
            "74.4",
            "77.0",
            "79.7",
            "82.5",
            "85.4",
            "88.5",
            "91.5",
            "94.8",
            "97.4",
            "100.0",
            "103.5",
            "107.2",
            "110.9",
            "114.8",
            "118.8",
            "123.0",
            "127.3",
            "131.8",
            "136.5",
            "141.3",
            "146.2",
            "151.4",
            "156.7",
            "162.2",
            "167.9",
            "173.8",
            "179.9",
            "186.2",
            "192.8",
            "203.5",
            "210.7",
            "218.1",
            "225.7",
            "233.6",
            "241.8",
            "250.3"});
            this.Tab2ToneComboBox.Location = new System.Drawing.Point(291, 76);
            this.Tab2ToneComboBox.Name = "Tab2ToneComboBox";
            this.Tab2ToneComboBox.Size = new System.Drawing.Size(58, 30);
            this.Tab2ToneComboBox.TabIndex = 3;
            this.Tab2ToneComboBox.SelectedIndexChanged += new System.EventHandler(this.Tab2ToneComboBox_SelectedIndexChanged);
            this.Tab2ToneComboBox.DropDownClosed += new System.EventHandler(this.Tab2ToneComboBox_DropDownClosed);
            // 
            // Tab2RepeaterComboBox
            // 
            this.Tab2RepeaterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2RepeaterComboBox.FormattingEnabled = true;
            this.Tab2RepeaterComboBox.Items.AddRange(new object[] {
            "PLUS",
            "MINUS",
            "SIMPLEX"});
            this.Tab2RepeaterComboBox.Location = new System.Drawing.Point(204, 76);
            this.Tab2RepeaterComboBox.Name = "Tab2RepeaterComboBox";
            this.Tab2RepeaterComboBox.Size = new System.Drawing.Size(83, 30);
            this.Tab2RepeaterComboBox.TabIndex = 2;
            // 
            // Tab2KHzCombBox
            // 
            this.Tab2KHzCombBox.DropDownWidth = 43;
            this.Tab2KHzCombBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2KHzCombBox.FormattingEnabled = true;
            this.Tab2KHzCombBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "210",
            "220",
            "230",
            "240",
            "250",
            "260",
            "270",
            "280",
            "290",
            "300",
            "310",
            "320",
            "330",
            "340",
            "350",
            "360",
            "370",
            "380",
            "390",
            "400",
            "410",
            "420",
            "430",
            "440",
            "450",
            "460",
            "470",
            "480",
            "490",
            "500",
            "510",
            "520",
            "530",
            "540",
            "550",
            "560",
            "570",
            "580",
            "590",
            "600",
            "610",
            "620",
            "630",
            "640",
            "650",
            "660",
            "670",
            "680",
            "690",
            "700",
            "710",
            "720",
            "730",
            "740",
            "750",
            "760",
            "770",
            "780",
            "790",
            "800",
            "810",
            "820",
            "830",
            "840",
            "850",
            "860",
            "870",
            "880",
            "890",
            "900",
            "910",
            "920",
            "930",
            "940",
            "950",
            "960",
            "970",
            "980",
            "990"});
            this.Tab2KHzCombBox.Location = new System.Drawing.Point(134, 76);
            this.Tab2KHzCombBox.MaxDropDownItems = 10;
            this.Tab2KHzCombBox.Name = "Tab2KHzCombBox";
            this.Tab2KHzCombBox.Size = new System.Drawing.Size(66, 30);
            this.Tab2KHzCombBox.TabIndex = 1;
            this.Tab2KHzCombBox.SelectedIndexChanged += new System.EventHandler(this.Tab2KHzCombBox_SelectedIndexChanged);
            // 
            // Tab2MHzComboBox
            // 
            this.Tab2MHzComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2MHzComboBox.FormattingEnabled = true;
            this.Tab2MHzComboBox.Items.AddRange(new object[] {
            "BLANK",
            "146",
            "147",
            "148",
            "149",
            "150"});
            this.Tab2MHzComboBox.Location = new System.Drawing.Point(60, 76);
            this.Tab2MHzComboBox.Name = "Tab2MHzComboBox";
            this.Tab2MHzComboBox.Size = new System.Drawing.Size(70, 30);
            this.Tab2MHzComboBox.TabIndex = 0;
            this.Tab2MHzComboBox.SelectedIndexChanged += new System.EventHandler(this.Tab2MHzComboBox_SelectedIndexChanged);
            // 
            // Tab2MenuStrip
            // 
            this.Tab2MenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Tab2MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Tab2MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab2FileToolStripMenuItem,
            this.Tab2SettingsToolStripMenuItem});
            this.Tab2MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.Tab2MenuStrip.Name = "Tab2MenuStrip";
            this.Tab2MenuStrip.Size = new System.Drawing.Size(451, 33);
            this.Tab2MenuStrip.TabIndex = 17;
            this.Tab2MenuStrip.Text = "MenuStrip1";
            // 
            // Tab2FileToolStripMenuItem
            // 
            this.Tab2FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab2OpenChannelFileToolStripMenuItem,
            this.Tab2SaveChannelFileToolStripMenuItem});
            this.Tab2FileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Tab2FileToolStripMenuItem.Name = "Tab2FileToolStripMenuItem";
            this.Tab2FileToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.Tab2FileToolStripMenuItem.Text = "File";
            // 
            // Tab2OpenChannelFileToolStripMenuItem
            // 
            this.Tab2OpenChannelFileToolStripMenuItem.Name = "Tab2OpenChannelFileToolStripMenuItem";
            this.Tab2OpenChannelFileToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.Tab2OpenChannelFileToolStripMenuItem.Text = "Open Channel File";
            this.Tab2OpenChannelFileToolStripMenuItem.Click += new System.EventHandler(this.Tab1OpenChannelFileToolStripMenuItem_Click);
            // 
            // Tab2SaveChannelFileToolStripMenuItem
            // 
            this.Tab2SaveChannelFileToolStripMenuItem.Name = "Tab2SaveChannelFileToolStripMenuItem";
            this.Tab2SaveChannelFileToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.Tab2SaveChannelFileToolStripMenuItem.Text = "Save Channel File";
            this.Tab2SaveChannelFileToolStripMenuItem.Click += new System.EventHandler(this.Tab1SaveChannelFileToolStripMenuItem_Click);
            // 
            // Tab2SettingsToolStripMenuItem
            // 
            this.Tab2SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab2BackToMainMenuToolStripMenuItem,
            this.Tab2KHzStepSizeToolStripMenuItem});
            this.Tab2SettingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Tab2SettingsToolStripMenuItem.Name = "Tab2SettingsToolStripMenuItem";
            this.Tab2SettingsToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.Tab2SettingsToolStripMenuItem.Text = "Options";
            // 
            // Tab2BackToMainMenuToolStripMenuItem
            // 
            this.Tab2BackToMainMenuToolStripMenuItem.Name = "Tab2BackToMainMenuToolStripMenuItem";
            this.Tab2BackToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.Tab2BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu";
            this.Tab2BackToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.Tab2BackToMainMenuToolStripMenuItem_Click);
            // 
            // Tab2KHzStepSizeToolStripMenuItem
            // 
            this.Tab2KHzStepSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab2KHzToolStripComboBox});
            this.Tab2KHzStepSizeToolStripMenuItem.Name = "Tab2KHzStepSizeToolStripMenuItem";
            this.Tab2KHzStepSizeToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.Tab2KHzStepSizeToolStripMenuItem.Text = "kHz Step Size";
            this.Tab2KHzStepSizeToolStripMenuItem.Click += new System.EventHandler(this.Tab2KHzStepSizeToolStripMenuItem_Click);
            // 
            // Tab2KHzToolStripComboBox
            // 
            this.Tab2KHzToolStripComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tab2KHzToolStripComboBox.Items.AddRange(new object[] {
            "10",
            "12.5",
            "5",
            "25"});
            this.Tab2KHzToolStripComboBox.Name = "Tab2KHzToolStripComboBox";
            this.Tab2KHzToolStripComboBox.Size = new System.Drawing.Size(121, 33);
            this.Tab2KHzToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.Tab2KHzToolStripComboBox_SelectedIndexChanged);
            // 
            // Panel12
            // 
            this.Panel12.BackColor = System.Drawing.Color.Silver;
            this.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel12.Controls.Add(this.tab2ChannelFileName);
            this.Panel12.Controls.Add(this.Label10);
            this.Panel12.Controls.Add(this.Tab2StopProgramButton);
            this.Panel12.Controls.Add(this.Tab2UsbRcvdLabel);
            this.Panel12.Controls.Add(this.Label73);
            this.Panel12.Controls.Add(this.Tab2UsbCmdLabel);
            this.Panel12.Controls.Add(this.Label68);
            this.Panel12.Controls.Add(this.Tab2ComPortTextBox);
            this.Panel12.Controls.Add(this.Label38);
            this.Panel12.Controls.Add(this.Tab2ProgressBar1);
            this.Panel12.Controls.Add(this.Tab2ProgramButton);
            this.Panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel12.Location = new System.Drawing.Point(3, 344);
            this.Panel12.Name = "Panel12";
            this.Panel12.Size = new System.Drawing.Size(455, 249);
            this.Panel12.TabIndex = 1;
            // 
            // tab2ChannelFileName
            // 
            this.tab2ChannelFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tab2ChannelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2ChannelFileName.Location = new System.Drawing.Point(147, 173);
            this.tab2ChannelFileName.Name = "tab2ChannelFileName";
            this.tab2ChannelFileName.Size = new System.Drawing.Size(300, 25);
            this.tab2ChannelFileName.TabIndex = 28;
            this.tab2ChannelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab2ChannelFileName.Visible = false;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(11, 177);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(187, 25);
            this.Label10.TabIndex = 27;
            this.Label10.Text = "Channel Filename";
            this.Label10.Visible = false;
            // 
            // Tab2StopProgramButton
            // 
            this.Tab2StopProgramButton.Location = new System.Drawing.Point(45, 50);
            this.Tab2StopProgramButton.Name = "Tab2StopProgramButton";
            this.Tab2StopProgramButton.Size = new System.Drawing.Size(117, 44);
            this.Tab2StopProgramButton.TabIndex = 26;
            this.Tab2StopProgramButton.Text = "Stop Programming";
            this.Tab2StopProgramButton.UseVisualStyleBackColor = true;
            this.Tab2StopProgramButton.Click += new System.EventHandler(this.StopProgramButton_Click);
            // 
            // Tab2UsbRcvdLabel
            // 
            this.Tab2UsbRcvdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tab2UsbRcvdLabel.Location = new System.Drawing.Point(352, 134);
            this.Tab2UsbRcvdLabel.Name = "Tab2UsbRcvdLabel";
            this.Tab2UsbRcvdLabel.Size = new System.Drawing.Size(96, 25);
            this.Tab2UsbRcvdLabel.TabIndex = 25;
            this.Tab2UsbRcvdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label73
            // 
            this.Label73.AutoSize = true;
            this.Label73.Location = new System.Drawing.Point(277, 138);
            this.Label73.Name = "Label73";
            this.Label73.Size = new System.Drawing.Size(94, 25);
            this.Label73.TabIndex = 24;
            this.Label73.Text = "received";
            // 
            // Tab2UsbCmdLabel
            // 
            this.Tab2UsbCmdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tab2UsbCmdLabel.Location = new System.Drawing.Point(168, 134);
            this.Tab2UsbCmdLabel.Name = "Tab2UsbCmdLabel";
            this.Tab2UsbCmdLabel.Size = new System.Drawing.Size(96, 25);
            this.Tab2UsbCmdLabel.TabIndex = 23;
            this.Tab2UsbCmdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label68
            // 
            this.Label68.Location = new System.Drawing.Point(10, 134);
            this.Label68.Name = "Label68";
            this.Label68.Size = new System.Drawing.Size(231, 25);
            this.Label68.TabIndex = 21;
            this.Label68.Text = "Serial command sent";
            this.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab2ComPortTextBox
            // 
            this.Tab2ComPortTextBox.Enabled = false;
            this.Tab2ComPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2ComPortTextBox.Location = new System.Drawing.Point(347, 13);
            this.Tab2ComPortTextBox.Multiline = true;
            this.Tab2ComPortTextBox.Name = "Tab2ComPortTextBox";
            this.Tab2ComPortTextBox.Size = new System.Drawing.Size(87, 80);
            this.Tab2ComPortTextBox.TabIndex = 20;
            this.Tab2ComPortTextBox.Text = "test1";
            this.Tab2ComPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tab2ComPortTextBox.Visible = false;
            // 
            // Label38
            // 
            this.Label38.AutoSize = true;
            this.Label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label38.Location = new System.Drawing.Point(80, 10);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(320, 37);
            this.Label38.TabIndex = 11;
            this.Label38.Text = "Radio Programming";
            // 
            // Tab2ProgressBar1
            // 
            this.Tab2ProgressBar1.Location = new System.Drawing.Point(53, 108);
            this.Tab2ProgressBar1.Name = "Tab2ProgressBar1";
            this.Tab2ProgressBar1.Size = new System.Drawing.Size(335, 16);
            this.Tab2ProgressBar1.TabIndex = 1;
            // 
            // Tab2ProgramButton
            // 
            this.Tab2ProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2ProgramButton.Location = new System.Drawing.Point(215, 50);
            this.Tab2ProgramButton.Name = "Tab2ProgramButton";
            this.Tab2ProgramButton.Size = new System.Drawing.Size(98, 44);
            this.Tab2ProgramButton.TabIndex = 0;
            this.Tab2ProgramButton.Text = "Program Radio Channels";
            this.Tab2ProgramButton.UseVisualStyleBackColor = true;
            this.Tab2ProgramButton.Click += new System.EventHandler(this.ButtonProgramBandModule2_Click);
            // 
            // Tab2StatusStrip
            // 
            this.Tab2StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Tab2StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab2ToolStripStepSize,
            this.Tab2ToolStripStatusLabel});
            this.Tab2StatusStrip.Location = new System.Drawing.Point(0, 596);
            this.Tab2StatusStrip.Name = "Tab2StatusStrip";
            this.Tab2StatusStrip.Size = new System.Drawing.Size(461, 23);
            this.Tab2StatusStrip.TabIndex = 2;
            this.Tab2StatusStrip.Text = "StatusStrip1";
            // 
            // Tab2ToolStripStepSize
            // 
            this.Tab2ToolStripStepSize.Name = "Tab2ToolStripStepSize";
            this.Tab2ToolStripStepSize.Size = new System.Drawing.Size(180, 16);
            this.Tab2ToolStripStepSize.Text = "ToolStripStatusLabel1";
            // 
            // Tab2ToolStripStatusLabel
            // 
            this.Tab2ToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Tab2ToolStripStatusLabel.Name = "Tab2ToolStripStatusLabel";
            this.Tab2ToolStripStatusLabel.Size = new System.Drawing.Size(196, 16);
            this.Tab2ToolStripStatusLabel.Text = "ToolStripStatusLabel2";
            // 
            // Panel15
            // 
            this.Panel15.BackColor = System.Drawing.Color.Silver;
            this.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel15.Controls.Add(this.Tab2ChannelListView);
            this.Panel15.Controls.Add(this.Label43);
            this.Panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel15.Location = new System.Drawing.Point(470, 3);
            this.Panel15.Name = "Panel15";
            this.Panel15.Size = new System.Drawing.Size(527, 619);
            this.Panel15.TabIndex = 1;
            // 
            // Tab2ChannelListView
            // 
            this.Tab2ChannelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader8,
            this.ColumnHeader7,
            this.ColumnHeader6,
            this.ColumnHeader15,
            this.ColumnHeader14,
            this.ColumnHeader27});
            this.Tab2ChannelListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab2ChannelListView.FullRowSelect = true;
            this.Tab2ChannelListView.GridLines = true;
            this.Tab2ChannelListView.HideSelection = false;
            this.Tab2ChannelListView.Location = new System.Drawing.Point(0, 34);
            this.Tab2ChannelListView.MultiSelect = false;
            this.Tab2ChannelListView.Name = "Tab2ChannelListView";
            this.Tab2ChannelListView.Size = new System.Drawing.Size(523, 463);
            this.Tab2ChannelListView.TabIndex = 12;
            this.Tab2ChannelListView.UseCompatibleStateImageBehavior = false;
            this.Tab2ChannelListView.View = System.Windows.Forms.View.Details;
            this.Tab2ChannelListView.SelectedIndexChanged += new System.EventHandler(this.Tab2ChannelListView_SelectedIndexChanged);
            // 
            // ColumnHeader8
            // 
            this.ColumnHeader8.Text = "CH#";
            this.ColumnHeader8.Width = 42;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "Frequency";
            this.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader7.Width = 91;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "Repeater";
            this.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader6.Width = 81;
            // 
            // ColumnHeader15
            // 
            this.ColumnHeader15.Text = "Tone";
            this.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader15.Width = 50;
            // 
            // ColumnHeader14
            // 
            this.ColumnHeader14.Text = " CTCSS";
            this.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader14.Width = 80;
            // 
            // ColumnHeader27
            // 
            this.ColumnHeader27.Text = "Notes";
            this.ColumnHeader27.Width = 375;
            // 
            // Label43
            // 
            this.Label43.AutoSize = true;
            this.Label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label43.Location = new System.Drawing.Point(176, 10);
            this.Label43.Name = "Label43";
            this.Label43.Size = new System.Drawing.Size(207, 37);
            this.Label43.TabIndex = 11;
            this.Label43.Text = "Channel List";
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.TableLayoutPanel8);
            this.TabPage3.Location = new System.Drawing.Point(4, 34);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(1006, 631);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "TabPage3";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel8
            // 
            this.TableLayoutPanel8.ColumnCount = 2;
            this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.8F));
            this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.2F));
            this.TableLayoutPanel8.Controls.Add(this.TableLayoutPanel10, 0, 0);
            this.TableLayoutPanel8.Controls.Add(this.Panel23, 1, 0);
            this.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel8.Name = "TableLayoutPanel8";
            this.TableLayoutPanel8.RowCount = 1;
            this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel8.Size = new System.Drawing.Size(1000, 625);
            this.TableLayoutPanel8.TabIndex = 3;
            // 
            // TableLayoutPanel10
            // 
            this.TableLayoutPanel10.ColumnCount = 1;
            this.TableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel10.Controls.Add(this.Panel20, 0, 0);
            this.TableLayoutPanel10.Controls.Add(this.Panel22, 0, 1);
            this.TableLayoutPanel10.Controls.Add(this.Tab3StatusStrip, 0, 2);
            this.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel10.Name = "TableLayoutPanel10";
            this.TableLayoutPanel10.RowCount = 3;
            this.TableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.80473F));
            this.TableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.19527F));
            this.TableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.TableLayoutPanel10.Size = new System.Drawing.Size(461, 619);
            this.TableLayoutPanel10.TabIndex = 0;
            // 
            // Panel20
            // 
            this.Panel20.BackColor = System.Drawing.Color.Silver;
            this.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel20.Controls.Add(this.Tab3DeleteRowButton);
            this.Panel20.Controls.Add(this.Tab3InsertRowButton);
            this.Panel20.Controls.Add(this.Label71);
            this.Panel20.Controls.Add(this.Tab3ChannelNotes);
            this.Panel20.Controls.Add(this.Panel21);
            this.Panel20.Controls.Add(this.Label55);
            this.Panel20.Controls.Add(this.Tab3SetChannelButton);
            this.Panel20.Controls.Add(this.Label56);
            this.Panel20.Controls.Add(this.Label57);
            this.Panel20.Controls.Add(this.Tab3ClearChannelList);
            this.Panel20.Controls.Add(this.Label58);
            this.Panel20.Controls.Add(this.Label59);
            this.Panel20.Controls.Add(this.Tab3ChannelTextBox);
            this.Panel20.Controls.Add(this.Label60);
            this.Panel20.Controls.Add(this.Label61);
            this.Panel20.Controls.Add(this.Tab3ToneComboBox);
            this.Panel20.Controls.Add(this.Tab3RepeaterComboBox);
            this.Panel20.Controls.Add(this.Tab3KHzCombBox);
            this.Panel20.Controls.Add(this.Tab3MHzComboBox);
            this.Panel20.Controls.Add(this.Tab3MenuStrip);
            this.Panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel20.Location = new System.Drawing.Point(3, 3);
            this.Panel20.Name = "Panel20";
            this.Panel20.Size = new System.Drawing.Size(455, 334);
            this.Panel20.TabIndex = 0;
            // 
            // Tab3DeleteRowButton
            // 
            this.Tab3DeleteRowButton.Location = new System.Drawing.Point(268, 243);
            this.Tab3DeleteRowButton.Name = "Tab3DeleteRowButton";
            this.Tab3DeleteRowButton.Size = new System.Drawing.Size(139, 23);
            this.Tab3DeleteRowButton.TabIndex = 22;
            this.Tab3DeleteRowButton.Text = "Delete Row";
            this.Tab3DeleteRowButton.UseVisualStyleBackColor = true;
            this.Tab3DeleteRowButton.Click += new System.EventHandler(this.Tab3DeleteRowButton_Click);
            // 
            // Tab3InsertRowButton
            // 
            this.Tab3InsertRowButton.Location = new System.Drawing.Point(268, 214);
            this.Tab3InsertRowButton.Name = "Tab3InsertRowButton";
            this.Tab3InsertRowButton.Size = new System.Drawing.Size(140, 23);
            this.Tab3InsertRowButton.TabIndex = 21;
            this.Tab3InsertRowButton.Text = "Insert Row";
            this.Tab3InsertRowButton.UseVisualStyleBackColor = true;
            this.Tab3InsertRowButton.Click += new System.EventHandler(this.Button11_Click);
            // 
            // Label71
            // 
            this.Label71.AutoSize = true;
            this.Label71.Location = new System.Drawing.Point(7, 103);
            this.Label71.Name = "Label71";
            this.Label71.Size = new System.Drawing.Size(155, 25);
            this.Label71.TabIndex = 20;
            this.Label71.Text = "Channel Notes";
            // 
            // Tab3ChannelNotes
            // 
            this.Tab3ChannelNotes.Location = new System.Drawing.Point(7, 122);
            this.Tab3ChannelNotes.MaxLength = 10;
            this.Tab3ChannelNotes.Name = "Tab3ChannelNotes";
            this.Tab3ChannelNotes.Size = new System.Drawing.Size(335, 30);
            this.Tab3ChannelNotes.TabIndex = 19;
            // 
            // Panel21
            // 
            this.Panel21.Controls.Add(this.Tab3CtcssOff);
            this.Panel21.Controls.Add(this.Tab3CtcssXmit);
            this.Panel21.Controls.Add(this.Tab3CtcssXmitRec);
            this.Panel21.Location = new System.Drawing.Point(348, 76);
            this.Panel21.Name = "Panel21";
            this.Panel21.Size = new System.Drawing.Size(100, 72);
            this.Panel21.TabIndex = 16;
            // 
            // Tab3CtcssOff
            // 
            this.Tab3CtcssOff.AutoSize = true;
            this.Tab3CtcssOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3CtcssOff.Location = new System.Drawing.Point(9, 46);
            this.Tab3CtcssOff.Name = "Tab3CtcssOff";
            this.Tab3CtcssOff.Size = new System.Drawing.Size(66, 29);
            this.Tab3CtcssOff.TabIndex = 17;
            this.Tab3CtcssOff.TabStop = true;
            this.Tab3CtcssOff.Text = "Off";
            this.Tab3CtcssOff.UseVisualStyleBackColor = true;
            this.Tab3CtcssOff.CheckedChanged += new System.EventHandler(this.Tab3CtcssOff_CheckedChanged);
            // 
            // Tab3CtcssXmit
            // 
            this.Tab3CtcssXmit.AutoSize = true;
            this.Tab3CtcssXmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3CtcssXmit.Location = new System.Drawing.Point(9, 5);
            this.Tab3CtcssXmit.Name = "Tab3CtcssXmit";
            this.Tab3CtcssXmit.Size = new System.Drawing.Size(80, 29);
            this.Tab3CtcssXmit.TabIndex = 14;
            this.Tab3CtcssXmit.TabStop = true;
            this.Tab3CtcssXmit.Text = "Xmit";
            this.Tab3CtcssXmit.UseVisualStyleBackColor = true;
            this.Tab3CtcssXmit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tab3CtcssXmit_MouseDown);
            // 
            // Tab3CtcssXmitRec
            // 
            this.Tab3CtcssXmitRec.AutoSize = true;
            this.Tab3CtcssXmitRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3CtcssXmitRec.Location = new System.Drawing.Point(9, 26);
            this.Tab3CtcssXmitRec.Name = "Tab3CtcssXmitRec";
            this.Tab3CtcssXmitRec.Size = new System.Drawing.Size(124, 29);
            this.Tab3CtcssXmitRec.TabIndex = 15;
            this.Tab3CtcssXmitRec.TabStop = true;
            this.Tab3CtcssXmitRec.Text = "Xmit/Rec";
            this.Tab3CtcssXmitRec.UseVisualStyleBackColor = true;
            this.Tab3CtcssXmitRec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tab3CtcssXmit_MouseDown);
            // 
            // Label55
            // 
            this.Label55.AutoSize = true;
            this.Label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label55.Location = new System.Drawing.Point(359, 60);
            this.Label55.Name = "Label55";
            this.Label55.Size = new System.Drawing.Size(88, 25);
            this.Label55.TabIndex = 13;
            this.Label55.Text = "CTCSS";
            // 
            // Tab3SetChannelButton
            // 
            this.Tab3SetChannelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3SetChannelButton.Location = new System.Drawing.Point(268, 154);
            this.Tab3SetChannelButton.Name = "Tab3SetChannelButton";
            this.Tab3SetChannelButton.Size = new System.Drawing.Size(140, 48);
            this.Tab3SetChannelButton.TabIndex = 11;
            this.Tab3SetChannelButton.Text = "Set/Update Channel";
            this.Tab3SetChannelButton.UseVisualStyleBackColor = true;
            this.Tab3SetChannelButton.Click += new System.EventHandler(this.Tab3SetChannelButton_Click);
            // 
            // Label56
            // 
            this.Label56.AutoSize = true;
            this.Label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label56.Location = new System.Drawing.Point(115, 24);
            this.Label56.Name = "Label56";
            this.Label56.Size = new System.Drawing.Size(276, 37);
            this.Label56.TabIndex = 10;
            this.Label56.Text = "Channel Settings";
            // 
            // Label57
            // 
            this.Label57.AutoSize = true;
            this.Label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label57.Location = new System.Drawing.Point(294, 60);
            this.Label57.Name = "Label57";
            this.Label57.Size = new System.Drawing.Size(62, 25);
            this.Label57.TabIndex = 9;
            this.Label57.Text = "Tone";
            // 
            // Tab3ClearChannelList
            // 
            this.Tab3ClearChannelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3ClearChannelList.Location = new System.Drawing.Point(138, 209);
            this.Tab3ClearChannelList.Name = "Tab3ClearChannelList";
            this.Tab3ClearChannelList.Size = new System.Drawing.Size(111, 43);
            this.Tab3ClearChannelList.TabIndex = 12;
            this.Tab3ClearChannelList.Text = "Clear Channel List";
            this.Tab3ClearChannelList.UseVisualStyleBackColor = true;
            this.Tab3ClearChannelList.Click += new System.EventHandler(this.ButtonClearChannelList3_Click);
            // 
            // Label58
            // 
            this.Label58.AutoSize = true;
            this.Label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label58.Location = new System.Drawing.Point(207, 60);
            this.Label58.Name = "Label58";
            this.Label58.Size = new System.Drawing.Size(99, 25);
            this.Label58.TabIndex = 8;
            this.Label58.Text = "Repeater";
            // 
            // Label59
            // 
            this.Label59.AutoSize = true;
            this.Label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label59.Location = new System.Drawing.Point(146, 60);
            this.Label59.Name = "Label59";
            this.Label59.Size = new System.Drawing.Size(53, 25);
            this.Label59.TabIndex = 7;
            this.Label59.Text = "KHz";
            // 
            // Tab3ChannelTextBox
            // 
            this.Tab3ChannelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3ChannelTextBox.Location = new System.Drawing.Point(7, 77);
            this.Tab3ChannelTextBox.Name = "Tab3ChannelTextBox";
            this.Tab3ChannelTextBox.ReadOnly = true;
            this.Tab3ChannelTextBox.Size = new System.Drawing.Size(46, 28);
            this.Tab3ChannelTextBox.TabIndex = 6;
            // 
            // Label60
            // 
            this.Label60.AutoSize = true;
            this.Label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label60.Location = new System.Drawing.Point(7, 61);
            this.Label60.Name = "Label60";
            this.Label60.Size = new System.Drawing.Size(61, 25);
            this.Label60.TabIndex = 5;
            this.Label60.Text = "CH #";
            // 
            // Label61
            // 
            this.Label61.AutoSize = true;
            this.Label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label61.Location = new System.Drawing.Point(75, 60);
            this.Label61.Name = "Label61";
            this.Label61.Size = new System.Drawing.Size(56, 25);
            this.Label61.TabIndex = 4;
            this.Label61.Text = "MHz";
            // 
            // Tab3ToneComboBox
            // 
            this.Tab3ToneComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3ToneComboBox.FormattingEnabled = true;
            this.Tab3ToneComboBox.Items.AddRange(new object[] {
            "OFF",
            "67.0",
            "71.9",
            "74.4",
            "77.0",
            "79.7",
            "82.5",
            "85.4",
            "88.5",
            "91.5",
            "94.8",
            "97.4",
            "100.0",
            "103.5",
            "107.2",
            "110.9",
            "114.8",
            "118.8",
            "123.0",
            "127.3",
            "131.8",
            "136.5",
            "141.3",
            "146.2",
            "151.4",
            "156.7",
            "162.2",
            "167.9",
            "173.8",
            "179.9",
            "186.2",
            "192.8",
            "203.5",
            "210.7",
            "218.1",
            "225.7",
            "233.6",
            "241.8",
            "250.3"});
            this.Tab3ToneComboBox.Location = new System.Drawing.Point(291, 76);
            this.Tab3ToneComboBox.Name = "Tab3ToneComboBox";
            this.Tab3ToneComboBox.Size = new System.Drawing.Size(58, 30);
            this.Tab3ToneComboBox.TabIndex = 3;
            this.Tab3ToneComboBox.SelectedIndexChanged += new System.EventHandler(this.Tab3ToneComboBox_SelectedIndexChanged);
            this.Tab3ToneComboBox.DropDownClosed += new System.EventHandler(this.Tab3ToneComboBox_DropDownClosed);
            // 
            // Tab3RepeaterComboBox
            // 
            this.Tab3RepeaterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3RepeaterComboBox.FormattingEnabled = true;
            this.Tab3RepeaterComboBox.Items.AddRange(new object[] {
            "PLUS",
            "MINUS",
            "SIMPLEX"});
            this.Tab3RepeaterComboBox.Location = new System.Drawing.Point(204, 76);
            this.Tab3RepeaterComboBox.Name = "Tab3RepeaterComboBox";
            this.Tab3RepeaterComboBox.Size = new System.Drawing.Size(83, 30);
            this.Tab3RepeaterComboBox.TabIndex = 2;
            // 
            // Tab3KHzCombBox
            // 
            this.Tab3KHzCombBox.DropDownWidth = 43;
            this.Tab3KHzCombBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3KHzCombBox.FormattingEnabled = true;
            this.Tab3KHzCombBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "210",
            "220",
            "230",
            "240",
            "250",
            "260",
            "270",
            "280",
            "290",
            "300",
            "310",
            "320",
            "330",
            "340",
            "350",
            "360",
            "370",
            "380",
            "390",
            "400",
            "410",
            "420",
            "430",
            "440",
            "450",
            "460",
            "470",
            "480",
            "490",
            "500",
            "510",
            "520",
            "530",
            "540",
            "550",
            "560",
            "570",
            "580",
            "590",
            "600",
            "610",
            "620",
            "630",
            "640",
            "650",
            "660",
            "670",
            "680",
            "690",
            "700",
            "710",
            "720",
            "730",
            "740",
            "750",
            "760",
            "770",
            "780",
            "790",
            "800",
            "810",
            "820",
            "830",
            "840",
            "850",
            "860",
            "870",
            "880",
            "890",
            "900",
            "910",
            "920",
            "930",
            "940",
            "950",
            "960",
            "970",
            "980",
            "990"});
            this.Tab3KHzCombBox.Location = new System.Drawing.Point(134, 76);
            this.Tab3KHzCombBox.MaxDropDownItems = 10;
            this.Tab3KHzCombBox.Name = "Tab3KHzCombBox";
            this.Tab3KHzCombBox.Size = new System.Drawing.Size(66, 30);
            this.Tab3KHzCombBox.TabIndex = 1;
            this.Tab3KHzCombBox.SelectedIndexChanged += new System.EventHandler(this.Tab3KHzCombBox_SelectedIndexChanged);
            // 
            // Tab3MHzComboBox
            // 
            this.Tab3MHzComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3MHzComboBox.FormattingEnabled = true;
            this.Tab3MHzComboBox.Items.AddRange(new object[] {
            "BLANK",
            "146",
            "147",
            "148",
            "149",
            "150"});
            this.Tab3MHzComboBox.Location = new System.Drawing.Point(60, 76);
            this.Tab3MHzComboBox.Name = "Tab3MHzComboBox";
            this.Tab3MHzComboBox.Size = new System.Drawing.Size(70, 30);
            this.Tab3MHzComboBox.TabIndex = 0;
            this.Tab3MHzComboBox.SelectedIndexChanged += new System.EventHandler(this.Tab3MHzComboBox_SelectedIndexChanged);
            // 
            // Tab3MenuStrip
            // 
            this.Tab3MenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Tab3MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Tab3MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab3FileToolStripMenuItem,
            this.Tab3SettingsToolStripMenuItem});
            this.Tab3MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.Tab3MenuStrip.Name = "Tab3MenuStrip";
            this.Tab3MenuStrip.Size = new System.Drawing.Size(451, 33);
            this.Tab3MenuStrip.TabIndex = 17;
            this.Tab3MenuStrip.Text = "MenuStrip1";
            // 
            // Tab3FileToolStripMenuItem
            // 
            this.Tab3FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab3OpenChannelFileToolStripMenuItem,
            this.Tab3SaveChannelFileToolStripMenuItem});
            this.Tab3FileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Tab3FileToolStripMenuItem.Name = "Tab3FileToolStripMenuItem";
            this.Tab3FileToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.Tab3FileToolStripMenuItem.Text = "File";
            // 
            // Tab3OpenChannelFileToolStripMenuItem
            // 
            this.Tab3OpenChannelFileToolStripMenuItem.Name = "Tab3OpenChannelFileToolStripMenuItem";
            this.Tab3OpenChannelFileToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.Tab3OpenChannelFileToolStripMenuItem.Text = "Open Channel File";
            this.Tab3OpenChannelFileToolStripMenuItem.Click += new System.EventHandler(this.Tab1OpenChannelFileToolStripMenuItem_Click);
            // 
            // Tab3SaveChannelFileToolStripMenuItem
            // 
            this.Tab3SaveChannelFileToolStripMenuItem.Name = "Tab3SaveChannelFileToolStripMenuItem";
            this.Tab3SaveChannelFileToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.Tab3SaveChannelFileToolStripMenuItem.Text = "Save Channel File";
            this.Tab3SaveChannelFileToolStripMenuItem.Click += new System.EventHandler(this.Tab1SaveChannelFileToolStripMenuItem_Click);
            // 
            // Tab3SettingsToolStripMenuItem
            // 
            this.Tab3SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab3BackToMainMenuToolStripMenuItem,
            this.Tab3KHzStepSizeToolStripMenuItem});
            this.Tab3SettingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Tab3SettingsToolStripMenuItem.Name = "Tab3SettingsToolStripMenuItem";
            this.Tab3SettingsToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.Tab3SettingsToolStripMenuItem.Text = "Options";
            // 
            // Tab3BackToMainMenuToolStripMenuItem
            // 
            this.Tab3BackToMainMenuToolStripMenuItem.Name = "Tab3BackToMainMenuToolStripMenuItem";
            this.Tab3BackToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.Tab3BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu";
            this.Tab3BackToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.Tab3BackToMainMenuToolStripMenuItem_Click);
            // 
            // Tab3KHzStepSizeToolStripMenuItem
            // 
            this.Tab3KHzStepSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab3KHzToolStripComboBox});
            this.Tab3KHzStepSizeToolStripMenuItem.Name = "Tab3KHzStepSizeToolStripMenuItem";
            this.Tab3KHzStepSizeToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.Tab3KHzStepSizeToolStripMenuItem.Text = "kHz Step Size";
            this.Tab3KHzStepSizeToolStripMenuItem.Click += new System.EventHandler(this.Tab3KHzStepSizeToolStripMenuItem_Click);
            // 
            // Tab3KHzToolStripComboBox
            // 
            this.Tab3KHzToolStripComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tab3KHzToolStripComboBox.Items.AddRange(new object[] {
            "10",
            "12.5",
            "5",
            "25"});
            this.Tab3KHzToolStripComboBox.Name = "Tab3KHzToolStripComboBox";
            this.Tab3KHzToolStripComboBox.Size = new System.Drawing.Size(121, 33);
            this.Tab3KHzToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.Tab3KHzToolStripComboBox_SelectedIndexChanged);
            // 
            // Panel22
            // 
            this.Panel22.BackColor = System.Drawing.Color.Silver;
            this.Panel22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel22.Controls.Add(this.tab3ChannelFileName);
            this.Panel22.Controls.Add(this.Label36);
            this.Panel22.Controls.Add(this.Tab3StopProgramButton);
            this.Panel22.Controls.Add(this.Tab3UsbRcvdLabel);
            this.Panel22.Controls.Add(this.Label74);
            this.Panel22.Controls.Add(this.Tab3UsbCmdLabel);
            this.Panel22.Controls.Add(this.Label69);
            this.Panel22.Controls.Add(this.Tab3ComPortTextBox);
            this.Panel22.Controls.Add(this.Label64);
            this.Panel22.Controls.Add(this.Tab3ProgressBar1);
            this.Panel22.Controls.Add(this.Tab3ProgramButton);
            this.Panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel22.Location = new System.Drawing.Point(3, 343);
            this.Panel22.Name = "Panel22";
            this.Panel22.Size = new System.Drawing.Size(455, 253);
            this.Panel22.TabIndex = 1;
            // 
            // tab3ChannelFileName
            // 
            this.tab3ChannelFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tab3ChannelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab3ChannelFileName.Location = new System.Drawing.Point(149, 173);
            this.tab3ChannelFileName.Name = "tab3ChannelFileName";
            this.tab3ChannelFileName.Size = new System.Drawing.Size(298, 25);
            this.tab3ChannelFileName.TabIndex = 27;
            this.tab3ChannelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab3ChannelFileName.Visible = false;
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Location = new System.Drawing.Point(11, 177);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(187, 25);
            this.Label36.TabIndex = 26;
            this.Label36.Text = "Channel Filename";
            this.Label36.Visible = false;
            // 
            // Tab3StopProgramButton
            // 
            this.Tab3StopProgramButton.Location = new System.Drawing.Point(45, 50);
            this.Tab3StopProgramButton.Name = "Tab3StopProgramButton";
            this.Tab3StopProgramButton.Size = new System.Drawing.Size(117, 44);
            this.Tab3StopProgramButton.TabIndex = 25;
            this.Tab3StopProgramButton.Text = "Stop Programming";
            this.Tab3StopProgramButton.UseVisualStyleBackColor = true;
            this.Tab3StopProgramButton.Click += new System.EventHandler(this.StopProgramButton_Click);
            // 
            // Tab3UsbRcvdLabel
            // 
            this.Tab3UsbRcvdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tab3UsbRcvdLabel.Location = new System.Drawing.Point(352, 134);
            this.Tab3UsbRcvdLabel.Name = "Tab3UsbRcvdLabel";
            this.Tab3UsbRcvdLabel.Size = new System.Drawing.Size(96, 25);
            this.Tab3UsbRcvdLabel.TabIndex = 24;
            this.Tab3UsbRcvdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label74
            // 
            this.Label74.AutoSize = true;
            this.Label74.Location = new System.Drawing.Point(277, 138);
            this.Label74.Name = "Label74";
            this.Label74.Size = new System.Drawing.Size(94, 25);
            this.Label74.TabIndex = 23;
            this.Label74.Text = "received";
            // 
            // Tab3UsbCmdLabel
            // 
            this.Tab3UsbCmdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tab3UsbCmdLabel.Location = new System.Drawing.Point(168, 134);
            this.Tab3UsbCmdLabel.Name = "Tab3UsbCmdLabel";
            this.Tab3UsbCmdLabel.Size = new System.Drawing.Size(96, 25);
            this.Tab3UsbCmdLabel.TabIndex = 22;
            this.Tab3UsbCmdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label69
            // 
            this.Label69.Location = new System.Drawing.Point(10, 134);
            this.Label69.Name = "Label69";
            this.Label69.Size = new System.Drawing.Size(231, 25);
            this.Label69.TabIndex = 21;
            this.Label69.Text = "Serial command sent";
            this.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tab3ComPortTextBox
            // 
            this.Tab3ComPortTextBox.Enabled = false;
            this.Tab3ComPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3ComPortTextBox.Location = new System.Drawing.Point(347, 13);
            this.Tab3ComPortTextBox.Multiline = true;
            this.Tab3ComPortTextBox.Name = "Tab3ComPortTextBox";
            this.Tab3ComPortTextBox.Size = new System.Drawing.Size(87, 80);
            this.Tab3ComPortTextBox.TabIndex = 20;
            this.Tab3ComPortTextBox.Text = "test1";
            this.Tab3ComPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tab3ComPortTextBox.Visible = false;
            // 
            // Label64
            // 
            this.Label64.AutoSize = true;
            this.Label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label64.Location = new System.Drawing.Point(80, 10);
            this.Label64.Name = "Label64";
            this.Label64.Size = new System.Drawing.Size(320, 37);
            this.Label64.TabIndex = 11;
            this.Label64.Text = "Radio Programming";
            // 
            // Tab3ProgressBar1
            // 
            this.Tab3ProgressBar1.Location = new System.Drawing.Point(53, 108);
            this.Tab3ProgressBar1.Name = "Tab3ProgressBar1";
            this.Tab3ProgressBar1.Size = new System.Drawing.Size(335, 16);
            this.Tab3ProgressBar1.TabIndex = 1;
            // 
            // Tab3ProgramButton
            // 
            this.Tab3ProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3ProgramButton.Location = new System.Drawing.Point(215, 50);
            this.Tab3ProgramButton.Name = "Tab3ProgramButton";
            this.Tab3ProgramButton.Size = new System.Drawing.Size(98, 44);
            this.Tab3ProgramButton.TabIndex = 0;
            this.Tab3ProgramButton.Text = "Program Radio Channels";
            this.Tab3ProgramButton.UseVisualStyleBackColor = true;
            this.Tab3ProgramButton.Click += new System.EventHandler(this.ButtonProgramBandModule3_Click);
            // 
            // Tab3StatusStrip
            // 
            this.Tab3StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Tab3StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab3ToolStripStepSize,
            this.Tab3ToolStripStatusLabel});
            this.Tab3StatusStrip.Location = new System.Drawing.Point(0, 599);
            this.Tab3StatusStrip.Name = "Tab3StatusStrip";
            this.Tab3StatusStrip.Size = new System.Drawing.Size(461, 20);
            this.Tab3StatusStrip.TabIndex = 2;
            this.Tab3StatusStrip.Text = "StatusStrip1";
            // 
            // Tab3ToolStripStepSize
            // 
            this.Tab3ToolStripStepSize.Name = "Tab3ToolStripStepSize";
            this.Tab3ToolStripStepSize.Size = new System.Drawing.Size(180, 13);
            this.Tab3ToolStripStepSize.Text = "ToolStripStatusLabel1";
            // 
            // Tab3ToolStripStatusLabel
            // 
            this.Tab3ToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Tab3ToolStripStatusLabel.Name = "Tab3ToolStripStatusLabel";
            this.Tab3ToolStripStatusLabel.Size = new System.Drawing.Size(196, 13);
            this.Tab3ToolStripStatusLabel.Text = "ToolStripStatusLabel2";
            // 
            // Panel23
            // 
            this.Panel23.BackColor = System.Drawing.Color.Silver;
            this.Panel23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel23.Controls.Add(this.Tab3ChannelListView);
            this.Panel23.Controls.Add(this.Label65);
            this.Panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel23.Location = new System.Drawing.Point(470, 3);
            this.Panel23.Name = "Panel23";
            this.Panel23.Size = new System.Drawing.Size(527, 619);
            this.Panel23.TabIndex = 1;
            // 
            // Tab3ChannelListView
            // 
            this.Tab3ChannelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader21,
            this.ColumnHeader22,
            this.ColumnHeader23,
            this.ColumnHeader24,
            this.ColumnHeader25,
            this.ColumnHeader28});
            this.Tab3ChannelListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab3ChannelListView.FullRowSelect = true;
            this.Tab3ChannelListView.GridLines = true;
            this.Tab3ChannelListView.HideSelection = false;
            this.Tab3ChannelListView.Location = new System.Drawing.Point(0, 34);
            this.Tab3ChannelListView.MultiSelect = false;
            this.Tab3ChannelListView.Name = "Tab3ChannelListView";
            this.Tab3ChannelListView.Size = new System.Drawing.Size(523, 463);
            this.Tab3ChannelListView.TabIndex = 12;
            this.Tab3ChannelListView.UseCompatibleStateImageBehavior = false;
            this.Tab3ChannelListView.View = System.Windows.Forms.View.Details;
            this.Tab3ChannelListView.SelectedIndexChanged += new System.EventHandler(this.Tab3ChannelListView_SelectedIndexChanged);
            // 
            // ColumnHeader21
            // 
            this.ColumnHeader21.Text = "CH#";
            this.ColumnHeader21.Width = 42;
            // 
            // ColumnHeader22
            // 
            this.ColumnHeader22.Text = "Frequency";
            this.ColumnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader22.Width = 91;
            // 
            // ColumnHeader23
            // 
            this.ColumnHeader23.Text = "Repeater";
            this.ColumnHeader23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader23.Width = 81;
            // 
            // ColumnHeader24
            // 
            this.ColumnHeader24.Text = "Tone";
            this.ColumnHeader24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader24.Width = 50;
            // 
            // ColumnHeader25
            // 
            this.ColumnHeader25.Text = " CTCSS";
            this.ColumnHeader25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader25.Width = 80;
            // 
            // ColumnHeader28
            // 
            this.ColumnHeader28.Text = "Notes";
            this.ColumnHeader28.Width = 375;
            // 
            // Label65
            // 
            this.Label65.AutoSize = true;
            this.Label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label65.Location = new System.Drawing.Point(176, 10);
            this.Label65.Name = "Label65";
            this.Label65.Size = new System.Drawing.Size(207, 37);
            this.Label65.TabIndex = 11;
            this.Label65.Text = "Channel List";
            // 
            // SerialPort1
            // 
            this.SerialPort1.PortName = "COM3";
            this.SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.05068F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.94932F));
            this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Panel7, 1, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(838, 476);
            this.TableLayoutPanel1.TabIndex = 1;
            // 
            // TableLayoutPanel3
            // 
            this.TableLayoutPanel3.ColumnCount = 1;
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel3.Controls.Add(this.Panel4, 0, 0);
            this.TableLayoutPanel3.Controls.Add(this.Panel6, 0, 1);
            this.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 3;
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.25077F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.74923F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.TableLayoutPanel3.Size = new System.Drawing.Size(421, 470);
            this.TableLayoutPanel3.TabIndex = 0;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Silver;
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel4.Controls.Add(this.Panel5);
            this.Panel4.Controls.Add(this.Label11);
            this.Panel4.Controls.Add(this.Button1);
            this.Panel4.Controls.Add(this.Label12);
            this.Panel4.Controls.Add(this.Label13);
            this.Panel4.Controls.Add(this.Label14);
            this.Panel4.Controls.Add(this.Label15);
            this.Panel4.Controls.Add(this.TextBox1);
            this.Panel4.Controls.Add(this.Label16);
            this.Panel4.Controls.Add(this.Label17);
            this.Panel4.Controls.Add(this.ComboBox1);
            this.Panel4.Controls.Add(this.ComboBox2);
            this.Panel4.Controls.Add(this.ComboBox3);
            this.Panel4.Controls.Add(this.ComboBox4);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel4.Location = new System.Drawing.Point(3, 3);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(415, 162);
            this.Panel4.TabIndex = 0;
            // 
            // Panel5
            // 
            this.Panel5.Controls.Add(this.RadioButton1);
            this.Panel5.Controls.Add(this.RadioButton2);
            this.Panel5.Location = new System.Drawing.Point(321, 76);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(90, 44);
            this.Panel5.TabIndex = 16;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(4, 5);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(66, 24);
            this.RadioButton1.TabIndex = 14;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Xmit";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(4, 23);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(99, 24);
            this.RadioButton2.TabIndex = 15;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "Xmit/Rec";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(324, 60);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(65, 20);
            this.Label11.TabIndex = 13;
            this.Label11.Text = "CTCSS";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(268, 136);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(140, 23);
            this.Button1.TabIndex = 11;
            this.Button1.Text = "Set/Update Channel";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(73, 24);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(276, 37);
            this.Label12.TabIndex = 10;
            this.Label12.Text = "Channel Settings";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(273, 60);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(45, 20);
            this.Label13.TabIndex = 9;
            this.Label13.Text = "Tone";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(187, 60);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(76, 20);
            this.Label14.TabIndex = 8;
            this.Label14.Text = "Repeater";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(129, 60);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(39, 20);
            this.Label15.TabIndex = 7;
            this.Label15.Text = "KHz";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(9, 79);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new System.Drawing.Size(50, 26);
            this.TextBox1.TabIndex = 6;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(13, 62);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(68, 20);
            this.Label16.TabIndex = 5;
            this.Label16.Text = "Channel";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(75, 62);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(42, 20);
            this.Label17.TabIndex = 4;
            this.Label17.Text = "MHz";
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "OFF",
            "67.0",
            "71.9",
            "74.4",
            "77.0",
            "79.7",
            "82.5",
            "85.4",
            "88.5",
            "91.5",
            "94.8",
            "97.4",
            "100.0",
            "103.5",
            "107.2",
            "110.9",
            "114.8",
            "118.8",
            "123.0",
            "127.3",
            "131.8",
            "136.5",
            "141.3",
            "146.2",
            "151.4",
            "156.7",
            "162.2",
            "167.9",
            "173.8",
            "179.9",
            "186.2",
            "192.8",
            "203.5",
            "210.7",
            "218.1",
            "225.7",
            "233.6",
            "241.8",
            "250.3"});
            this.ComboBox1.Location = new System.Drawing.Point(265, 76);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(50, 28);
            this.ComboBox1.TabIndex = 3;
            // 
            // ComboBox2
            // 
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Items.AddRange(new object[] {
            "PLUS",
            "MINUS",
            "SIMPLEX"});
            this.ComboBox2.Location = new System.Drawing.Point(184, 76);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(75, 28);
            this.ComboBox2.TabIndex = 2;
            // 
            // ComboBox3
            // 
            this.ComboBox3.DropDownWidth = 43;
            this.ComboBox3.FormattingEnabled = true;
            this.ComboBox3.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "210",
            "220",
            "230",
            "240",
            "250",
            "260",
            "270",
            "280",
            "290",
            "300",
            "310",
            "320",
            "330",
            "340",
            "350",
            "360",
            "370",
            "380",
            "390",
            "400",
            "410",
            "420",
            "430",
            "440",
            "450",
            "460",
            "470",
            "480",
            "490",
            "500",
            "510",
            "520",
            "530",
            "540",
            "550",
            "560",
            "570",
            "580",
            "590",
            "600",
            "610",
            "620",
            "630",
            "640",
            "650",
            "660",
            "670",
            "680",
            "690",
            "700",
            "710",
            "720",
            "730",
            "740",
            "750",
            "760",
            "770",
            "780",
            "790",
            "800",
            "810",
            "820",
            "830",
            "840",
            "850",
            "860",
            "870",
            "880",
            "890",
            "900",
            "910",
            "920",
            "930",
            "940",
            "950",
            "960",
            "970",
            "980",
            "990"});
            this.ComboBox3.Location = new System.Drawing.Point(128, 77);
            this.ComboBox3.MaxDropDownItems = 10;
            this.ComboBox3.Name = "ComboBox3";
            this.ComboBox3.Size = new System.Drawing.Size(50, 28);
            this.ComboBox3.TabIndex = 1;
            // 
            // ComboBox4
            // 
            this.ComboBox4.FormattingEnabled = true;
            this.ComboBox4.Items.AddRange(new object[] {
            "BLANK",
            "146",
            "147",
            "148",
            "149",
            "150"});
            this.ComboBox4.Location = new System.Drawing.Point(65, 78);
            this.ComboBox4.Name = "ComboBox4";
            this.ComboBox4.Size = new System.Drawing.Size(57, 28);
            this.ComboBox4.TabIndex = 0;
            // 
            // Panel6
            // 
            this.Panel6.BackColor = System.Drawing.Color.Silver;
            this.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel6.Controls.Add(this.Label18);
            this.Panel6.Controls.Add(this.NumericUpDown1);
            this.Panel6.Controls.Add(this.Label19);
            this.Panel6.Controls.Add(this.NumericUpDown2);
            this.Panel6.Controls.Add(this.Button2);
            this.Panel6.Controls.Add(this.Label20);
            this.Panel6.Controls.Add(this.ProgressBar1);
            this.Panel6.Controls.Add(this.Button3);
            this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel6.Location = new System.Drawing.Point(3, 171);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(415, 141);
            this.Panel6.TabIndex = 1;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(9, 42);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(101, 20);
            this.Label18.TabIndex = 18;
            this.Label18.Text = "Button in mS";
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown1.Location = new System.Drawing.Point(9, 57);
            this.NumericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(55, 26);
            this.NumericUpDown1.TabIndex = 17;
            this.NumericUpDown1.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(9, 4);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(89, 20);
            this.Label19.TabIndex = 16;
            this.Label19.Text = "Tone in mS";
            // 
            // NumericUpDown2
            // 
            this.NumericUpDown2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown2.Location = new System.Drawing.Point(9, 19);
            this.NumericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDown2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown2.Name = "NumericUpDown2";
            this.NumericUpDown2.Size = new System.Drawing.Size(55, 26);
            this.NumericUpDown2.TabIndex = 15;
            this.NumericUpDown2.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(78, 56);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(100, 37);
            this.Button2.TabIndex = 12;
            this.Button2.Text = "Clear Channel List";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(73, 13);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(358, 37);
            this.Label20.TabIndex = 11;
            this.Label20.Text = "Channel Programming";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(31, 108);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(335, 16);
            this.ProgressBar1.TabIndex = 1;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(220, 56);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(95, 37);
            this.Button3.TabIndex = 0;
            this.Button3.Text = "Program Radio Channels";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // Panel7
            // 
            this.Panel7.BackColor = System.Drawing.Color.Silver;
            this.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel7.Controls.Add(this.ListView1);
            this.Panel7.Controls.Add(this.Label21);
            this.Panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel7.Location = new System.Drawing.Point(430, 3);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(405, 470);
            this.Panel7.TabIndex = 1;
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5});
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(0, 49);
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(389, 377);
            this.ListView1.TabIndex = 12;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Channel";
            this.ColumnHeader1.Width = 64;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Frequency";
            this.ColumnHeader2.Width = 81;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Repeater Mode";
            this.ColumnHeader3.Width = 105;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Tone";
            this.ColumnHeader4.Width = 76;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = " CTSS";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.Location = new System.Drawing.Point(109, 10);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(207, 37);
            this.Label21.TabIndex = 11;
            this.Label21.Text = "Channel List";
            // 
            // Panel9
            // 
            this.Panel9.BackColor = System.Drawing.Color.Silver;
            this.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel9.Controls.Add(this.Panel10);
            this.Panel9.Controls.Add(this.Label26);
            this.Panel9.Controls.Add(this.Button5);
            this.Panel9.Controls.Add(this.Label27);
            this.Panel9.Controls.Add(this.Label28);
            this.Panel9.Controls.Add(this.Label29);
            this.Panel9.Controls.Add(this.Label30);
            this.Panel9.Controls.Add(this.TextBox2);
            this.Panel9.Controls.Add(this.Label31);
            this.Panel9.Controls.Add(this.Label32);
            this.Panel9.Controls.Add(this.ComboBox5);
            this.Panel9.Controls.Add(this.ComboBox6);
            this.Panel9.Controls.Add(this.ComboBox7);
            this.Panel9.Controls.Add(this.ComboBox8);
            this.Panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel9.Location = new System.Drawing.Point(3, 3);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(415, 162);
            this.Panel9.TabIndex = 0;
            // 
            // Panel10
            // 
            this.Panel10.Controls.Add(this.RadioButton5);
            this.Panel10.Controls.Add(this.RadioButton6);
            this.Panel10.Location = new System.Drawing.Point(321, 76);
            this.Panel10.Name = "Panel10";
            this.Panel10.Size = new System.Drawing.Size(90, 44);
            this.Panel10.TabIndex = 16;
            // 
            // RadioButton5
            // 
            this.RadioButton5.AutoSize = true;
            this.RadioButton5.Location = new System.Drawing.Point(4, 5);
            this.RadioButton5.Name = "RadioButton5";
            this.RadioButton5.Size = new System.Drawing.Size(66, 24);
            this.RadioButton5.TabIndex = 14;
            this.RadioButton5.TabStop = true;
            this.RadioButton5.Text = "Xmit";
            this.RadioButton5.UseVisualStyleBackColor = true;
            // 
            // RadioButton6
            // 
            this.RadioButton6.AutoSize = true;
            this.RadioButton6.Location = new System.Drawing.Point(4, 23);
            this.RadioButton6.Name = "RadioButton6";
            this.RadioButton6.Size = new System.Drawing.Size(99, 24);
            this.RadioButton6.TabIndex = 15;
            this.RadioButton6.TabStop = true;
            this.RadioButton6.Text = "Xmit/Rec";
            this.RadioButton6.UseVisualStyleBackColor = true;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label26.Location = new System.Drawing.Point(324, 60);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(65, 20);
            this.Label26.TabIndex = 13;
            this.Label26.Text = "CTCSS";
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(268, 136);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(140, 23);
            this.Button5.TabIndex = 11;
            this.Button5.Text = "Set/Update Channel";
            this.Button5.UseVisualStyleBackColor = true;
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label27.Location = new System.Drawing.Point(73, 24);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(276, 37);
            this.Label27.TabIndex = 10;
            this.Label27.Text = "Channel Settings";
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(273, 60);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(45, 20);
            this.Label28.TabIndex = 9;
            this.Label28.Text = "Tone";
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(187, 60);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(76, 20);
            this.Label29.TabIndex = 8;
            this.Label29.Text = "Repeater";
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Location = new System.Drawing.Point(129, 60);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(39, 20);
            this.Label30.TabIndex = 7;
            this.Label30.Text = "KHz";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(9, 79);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.Size = new System.Drawing.Size(50, 26);
            this.TextBox2.TabIndex = 6;
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(13, 62);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(68, 20);
            this.Label31.TabIndex = 5;
            this.Label31.Text = "Channel";
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.Location = new System.Drawing.Point(75, 62);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(42, 20);
            this.Label32.TabIndex = 4;
            this.Label32.Text = "MHz";
            // 
            // ComboBox5
            // 
            this.ComboBox5.FormattingEnabled = true;
            this.ComboBox5.Items.AddRange(new object[] {
            "OFF",
            "67.0",
            "71.9",
            "74.4",
            "77.0",
            "79.7",
            "82.5",
            "85.4",
            "88.5",
            "91.5",
            "94.8",
            "97.4",
            "100.0",
            "103.5",
            "107.2",
            "110.9",
            "114.8",
            "118.8",
            "123.0",
            "127.3",
            "131.8",
            "136.5",
            "141.3",
            "146.2",
            "151.4",
            "156.7",
            "162.2",
            "167.9",
            "173.8",
            "179.9",
            "186.2",
            "192.8",
            "203.5",
            "210.7",
            "218.1",
            "225.7",
            "233.6",
            "241.8",
            "250.3"});
            this.ComboBox5.Location = new System.Drawing.Point(265, 76);
            this.ComboBox5.Name = "ComboBox5";
            this.ComboBox5.Size = new System.Drawing.Size(50, 28);
            this.ComboBox5.TabIndex = 3;
            // 
            // ComboBox6
            // 
            this.ComboBox6.FormattingEnabled = true;
            this.ComboBox6.Items.AddRange(new object[] {
            "PLUS",
            "MINUS",
            "SIMPLEX"});
            this.ComboBox6.Location = new System.Drawing.Point(184, 76);
            this.ComboBox6.Name = "ComboBox6";
            this.ComboBox6.Size = new System.Drawing.Size(75, 28);
            this.ComboBox6.TabIndex = 2;
            // 
            // ComboBox7
            // 
            this.ComboBox7.DropDownWidth = 43;
            this.ComboBox7.FormattingEnabled = true;
            this.ComboBox7.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "210",
            "220",
            "230",
            "240",
            "250",
            "260",
            "270",
            "280",
            "290",
            "300",
            "310",
            "320",
            "330",
            "340",
            "350",
            "360",
            "370",
            "380",
            "390",
            "400",
            "410",
            "420",
            "430",
            "440",
            "450",
            "460",
            "470",
            "480",
            "490",
            "500",
            "510",
            "520",
            "530",
            "540",
            "550",
            "560",
            "570",
            "580",
            "590",
            "600",
            "610",
            "620",
            "630",
            "640",
            "650",
            "660",
            "670",
            "680",
            "690",
            "700",
            "710",
            "720",
            "730",
            "740",
            "750",
            "760",
            "770",
            "780",
            "790",
            "800",
            "810",
            "820",
            "830",
            "840",
            "850",
            "860",
            "870",
            "880",
            "890",
            "900",
            "910",
            "920",
            "930",
            "940",
            "950",
            "960",
            "970",
            "980",
            "990"});
            this.ComboBox7.Location = new System.Drawing.Point(128, 77);
            this.ComboBox7.MaxDropDownItems = 10;
            this.ComboBox7.Name = "ComboBox7";
            this.ComboBox7.Size = new System.Drawing.Size(50, 28);
            this.ComboBox7.TabIndex = 1;
            // 
            // ComboBox8
            // 
            this.ComboBox8.FormattingEnabled = true;
            this.ComboBox8.Items.AddRange(new object[] {
            "BLANK",
            "146",
            "147",
            "148",
            "149",
            "150"});
            this.ComboBox8.Location = new System.Drawing.Point(65, 78);
            this.ComboBox8.Name = "ComboBox8";
            this.ComboBox8.Size = new System.Drawing.Size(57, 28);
            this.ComboBox8.TabIndex = 0;
            // 
            // TableLayoutPanel5
            // 
            this.TableLayoutPanel5.ColumnCount = 2;
            this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.05068F));
            this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.94932F));
            this.TableLayoutPanel5.Controls.Add(this.TableLayoutPanel6, 0, 0);
            this.TableLayoutPanel5.Controls.Add(this.Panel14, 1, 0);
            this.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel5.Name = "TableLayoutPanel5";
            this.TableLayoutPanel5.RowCount = 1;
            this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel5.Size = new System.Drawing.Size(838, 476);
            this.TableLayoutPanel5.TabIndex = 1;
            // 
            // TableLayoutPanel6
            // 
            this.TableLayoutPanel6.ColumnCount = 1;
            this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel6.Controls.Add(this.Panel9, 0, 0);
            this.TableLayoutPanel6.Controls.Add(this.Panel13, 0, 1);
            this.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel6.Name = "TableLayoutPanel6";
            this.TableLayoutPanel6.RowCount = 3;
            this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.25077F));
            this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.74923F));
            this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.TableLayoutPanel6.Size = new System.Drawing.Size(421, 470);
            this.TableLayoutPanel6.TabIndex = 0;
            // 
            // Panel13
            // 
            this.Panel13.BackColor = System.Drawing.Color.Silver;
            this.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel13.Controls.Add(this.Label39);
            this.Panel13.Controls.Add(this.NumericUpDown5);
            this.Panel13.Controls.Add(this.Label40);
            this.Panel13.Controls.Add(this.NumericUpDown6);
            this.Panel13.Controls.Add(this.Button8);
            this.Panel13.Controls.Add(this.Label41);
            this.Panel13.Controls.Add(this.ProgressBar3);
            this.Panel13.Controls.Add(this.Button9);
            this.Panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel13.Location = new System.Drawing.Point(3, 171);
            this.Panel13.Name = "Panel13";
            this.Panel13.Size = new System.Drawing.Size(415, 141);
            this.Panel13.TabIndex = 1;
            // 
            // Label39
            // 
            this.Label39.AutoSize = true;
            this.Label39.Location = new System.Drawing.Point(9, 42);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(101, 20);
            this.Label39.TabIndex = 18;
            this.Label39.Text = "Button in mS";
            // 
            // NumericUpDown5
            // 
            this.NumericUpDown5.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown5.Location = new System.Drawing.Point(9, 57);
            this.NumericUpDown5.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDown5.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown5.Name = "NumericUpDown5";
            this.NumericUpDown5.Size = new System.Drawing.Size(55, 26);
            this.NumericUpDown5.TabIndex = 17;
            this.NumericUpDown5.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // Label40
            // 
            this.Label40.AutoSize = true;
            this.Label40.Location = new System.Drawing.Point(9, 4);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(89, 20);
            this.Label40.TabIndex = 16;
            this.Label40.Text = "Tone in mS";
            // 
            // NumericUpDown6
            // 
            this.NumericUpDown6.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown6.Location = new System.Drawing.Point(9, 19);
            this.NumericUpDown6.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDown6.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown6.Name = "NumericUpDown6";
            this.NumericUpDown6.Size = new System.Drawing.Size(55, 26);
            this.NumericUpDown6.TabIndex = 15;
            this.NumericUpDown6.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(78, 56);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(100, 37);
            this.Button8.TabIndex = 12;
            this.Button8.Text = "Clear Channel List";
            this.Button8.UseVisualStyleBackColor = true;
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label41.Location = new System.Drawing.Point(73, 13);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(358, 37);
            this.Label41.TabIndex = 11;
            this.Label41.Text = "Channel Programming";
            // 
            // ProgressBar3
            // 
            this.ProgressBar3.Location = new System.Drawing.Point(31, 108);
            this.ProgressBar3.Name = "ProgressBar3";
            this.ProgressBar3.Size = new System.Drawing.Size(335, 16);
            this.ProgressBar3.TabIndex = 1;
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(220, 56);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(95, 37);
            this.Button9.TabIndex = 0;
            this.Button9.Text = "Program Radio Channels";
            this.Button9.UseVisualStyleBackColor = true;
            // 
            // Panel14
            // 
            this.Panel14.BackColor = System.Drawing.Color.Silver;
            this.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel14.Controls.Add(this.ListView2);
            this.Panel14.Controls.Add(this.Label42);
            this.Panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel14.Location = new System.Drawing.Point(430, 3);
            this.Panel14.Name = "Panel14";
            this.Panel14.Size = new System.Drawing.Size(405, 470);
            this.Panel14.TabIndex = 1;
            // 
            // ListView2
            // 
            this.ListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader9,
            this.ColumnHeader10,
            this.ColumnHeader11,
            this.ColumnHeader12,
            this.ColumnHeader13});
            this.ListView2.FullRowSelect = true;
            this.ListView2.GridLines = true;
            this.ListView2.HideSelection = false;
            this.ListView2.Location = new System.Drawing.Point(0, 49);
            this.ListView2.MultiSelect = false;
            this.ListView2.Name = "ListView2";
            this.ListView2.Size = new System.Drawing.Size(389, 377);
            this.ListView2.TabIndex = 12;
            this.ListView2.UseCompatibleStateImageBehavior = false;
            this.ListView2.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader9
            // 
            this.ColumnHeader9.Text = "Channel";
            this.ColumnHeader9.Width = 64;
            // 
            // ColumnHeader10
            // 
            this.ColumnHeader10.Text = "Frequency";
            this.ColumnHeader10.Width = 81;
            // 
            // ColumnHeader11
            // 
            this.ColumnHeader11.Text = "Repeater Mode";
            this.ColumnHeader11.Width = 105;
            // 
            // ColumnHeader12
            // 
            this.ColumnHeader12.Text = "Tone";
            this.ColumnHeader12.Width = 76;
            // 
            // ColumnHeader13
            // 
            this.ColumnHeader13.Text = " CTSS";
            // 
            // Label42
            // 
            this.Label42.AutoSize = true;
            this.Label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label42.Location = new System.Drawing.Point(109, 10);
            this.Label42.Name = "Label42";
            this.Label42.Size = new System.Drawing.Size(207, 37);
            this.Label42.TabIndex = 11;
            this.Label42.Text = "Channel List";
            // 
            // TableLayoutPanel9
            // 
            this.TableLayoutPanel9.ColumnCount = 1;
            this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel9.Controls.Add(this.Panel16, 0, 0);
            this.TableLayoutPanel9.Controls.Add(this.Panel18, 0, 1);
            this.TableLayoutPanel9.Controls.Add(this.deleteStatusStrip1, 0, 2);
            this.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanel9.Name = "TableLayoutPanel9";
            this.TableLayoutPanel9.RowCount = 3;
            this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.25077F));
            this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.74923F));
            this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.TableLayoutPanel9.Size = new System.Drawing.Size(421, 470);
            this.TableLayoutPanel9.TabIndex = 0;
            // 
            // Panel16
            // 
            this.Panel16.BackColor = System.Drawing.Color.Silver;
            this.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel16.Controls.Add(this.Panel17);
            this.Panel16.Controls.Add(this.Label44);
            this.Panel16.Controls.Add(this.Button4);
            this.Panel16.Controls.Add(this.Label45);
            this.Panel16.Controls.Add(this.Label46);
            this.Panel16.Controls.Add(this.Label47);
            this.Panel16.Controls.Add(this.Label48);
            this.Panel16.Controls.Add(this.TextBox3);
            this.Panel16.Controls.Add(this.Label49);
            this.Panel16.Controls.Add(this.Label50);
            this.Panel16.Controls.Add(this.ComboBox9);
            this.Panel16.Controls.Add(this.ComboBox10);
            this.Panel16.Controls.Add(this.ComboBox11);
            this.Panel16.Controls.Add(this.ComboBox12);
            this.Panel16.Controls.Add(this.deleteMenuStrip1);
            this.Panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel16.Location = new System.Drawing.Point(3, 3);
            this.Panel16.Name = "Panel16";
            this.Panel16.Size = new System.Drawing.Size(415, 162);
            this.Panel16.TabIndex = 0;
            // 
            // Panel17
            // 
            this.Panel17.Controls.Add(this.RadioButton3);
            this.Panel17.Controls.Add(this.RadioButton4);
            this.Panel17.Location = new System.Drawing.Point(321, 76);
            this.Panel17.Name = "Panel17";
            this.Panel17.Size = new System.Drawing.Size(90, 44);
            this.Panel17.TabIndex = 16;
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Location = new System.Drawing.Point(4, 5);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(66, 24);
            this.RadioButton3.TabIndex = 14;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "Xmit";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton4
            // 
            this.RadioButton4.AutoSize = true;
            this.RadioButton4.Location = new System.Drawing.Point(4, 23);
            this.RadioButton4.Name = "RadioButton4";
            this.RadioButton4.Size = new System.Drawing.Size(99, 24);
            this.RadioButton4.TabIndex = 15;
            this.RadioButton4.TabStop = true;
            this.RadioButton4.Text = "Xmit/Rec";
            this.RadioButton4.UseVisualStyleBackColor = true;
            // 
            // Label44
            // 
            this.Label44.AutoSize = true;
            this.Label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label44.Location = new System.Drawing.Point(324, 60);
            this.Label44.Name = "Label44";
            this.Label44.Size = new System.Drawing.Size(65, 20);
            this.Label44.TabIndex = 13;
            this.Label44.Text = "CTCSS";
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(268, 136);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(140, 23);
            this.Button4.TabIndex = 11;
            this.Button4.Text = "Set/Update Channel";
            this.Button4.UseVisualStyleBackColor = true;
            // 
            // Label45
            // 
            this.Label45.AutoSize = true;
            this.Label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label45.Location = new System.Drawing.Point(73, 24);
            this.Label45.Name = "Label45";
            this.Label45.Size = new System.Drawing.Size(276, 37);
            this.Label45.TabIndex = 10;
            this.Label45.Text = "Channel Settings";
            // 
            // Label46
            // 
            this.Label46.AutoSize = true;
            this.Label46.Location = new System.Drawing.Point(273, 60);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(45, 20);
            this.Label46.TabIndex = 9;
            this.Label46.Text = "Tone";
            // 
            // Label47
            // 
            this.Label47.AutoSize = true;
            this.Label47.Location = new System.Drawing.Point(187, 60);
            this.Label47.Name = "Label47";
            this.Label47.Size = new System.Drawing.Size(76, 20);
            this.Label47.TabIndex = 8;
            this.Label47.Text = "Repeater";
            // 
            // Label48
            // 
            this.Label48.AutoSize = true;
            this.Label48.Location = new System.Drawing.Point(129, 60);
            this.Label48.Name = "Label48";
            this.Label48.Size = new System.Drawing.Size(39, 20);
            this.Label48.TabIndex = 7;
            this.Label48.Text = "KHz";
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(9, 79);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.ReadOnly = true;
            this.TextBox3.Size = new System.Drawing.Size(50, 26);
            this.TextBox3.TabIndex = 6;
            // 
            // Label49
            // 
            this.Label49.AutoSize = true;
            this.Label49.Location = new System.Drawing.Point(13, 62);
            this.Label49.Name = "Label49";
            this.Label49.Size = new System.Drawing.Size(68, 20);
            this.Label49.TabIndex = 5;
            this.Label49.Text = "Channel";
            // 
            // Label50
            // 
            this.Label50.AutoSize = true;
            this.Label50.Location = new System.Drawing.Point(75, 62);
            this.Label50.Name = "Label50";
            this.Label50.Size = new System.Drawing.Size(42, 20);
            this.Label50.TabIndex = 4;
            this.Label50.Text = "MHz";
            // 
            // ComboBox9
            // 
            this.ComboBox9.FormattingEnabled = true;
            this.ComboBox9.Items.AddRange(new object[] {
            "OFF",
            "67.0",
            "71.9",
            "74.4",
            "77.0",
            "79.7",
            "82.5",
            "85.4",
            "88.5",
            "91.5",
            "94.8",
            "97.4",
            "100.0",
            "103.5",
            "107.2",
            "110.9",
            "114.8",
            "118.8",
            "123.0",
            "127.3",
            "131.8",
            "136.5",
            "141.3",
            "146.2",
            "151.4",
            "156.7",
            "162.2",
            "167.9",
            "173.8",
            "179.9",
            "186.2",
            "192.8",
            "203.5",
            "210.7",
            "218.1",
            "225.7",
            "233.6",
            "241.8",
            "250.3"});
            this.ComboBox9.Location = new System.Drawing.Point(265, 76);
            this.ComboBox9.Name = "ComboBox9";
            this.ComboBox9.Size = new System.Drawing.Size(50, 28);
            this.ComboBox9.TabIndex = 3;
            // 
            // ComboBox10
            // 
            this.ComboBox10.FormattingEnabled = true;
            this.ComboBox10.Items.AddRange(new object[] {
            "PLUS",
            "MINUS",
            "SIMPLEX"});
            this.ComboBox10.Location = new System.Drawing.Point(184, 76);
            this.ComboBox10.Name = "ComboBox10";
            this.ComboBox10.Size = new System.Drawing.Size(75, 28);
            this.ComboBox10.TabIndex = 2;
            // 
            // ComboBox11
            // 
            this.ComboBox11.DropDownWidth = 43;
            this.ComboBox11.FormattingEnabled = true;
            this.ComboBox11.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "210",
            "220",
            "230",
            "240",
            "250",
            "260",
            "270",
            "280",
            "290",
            "300",
            "310",
            "320",
            "330",
            "340",
            "350",
            "360",
            "370",
            "380",
            "390",
            "400",
            "410",
            "420",
            "430",
            "440",
            "450",
            "460",
            "470",
            "480",
            "490",
            "500",
            "510",
            "520",
            "530",
            "540",
            "550",
            "560",
            "570",
            "580",
            "590",
            "600",
            "610",
            "620",
            "630",
            "640",
            "650",
            "660",
            "670",
            "680",
            "690",
            "700",
            "710",
            "720",
            "730",
            "740",
            "750",
            "760",
            "770",
            "780",
            "790",
            "800",
            "810",
            "820",
            "830",
            "840",
            "850",
            "860",
            "870",
            "880",
            "890",
            "900",
            "910",
            "920",
            "930",
            "940",
            "950",
            "960",
            "970",
            "980",
            "990"});
            this.ComboBox11.Location = new System.Drawing.Point(128, 77);
            this.ComboBox11.MaxDropDownItems = 10;
            this.ComboBox11.Name = "ComboBox11";
            this.ComboBox11.Size = new System.Drawing.Size(50, 28);
            this.ComboBox11.TabIndex = 1;
            // 
            // ComboBox12
            // 
            this.ComboBox12.FormattingEnabled = true;
            this.ComboBox12.Items.AddRange(new object[] {
            "BLANK",
            "146",
            "147",
            "148",
            "149",
            "150"});
            this.ComboBox12.Location = new System.Drawing.Point(65, 78);
            this.ComboBox12.Name = "ComboBox12";
            this.ComboBox12.Size = new System.Drawing.Size(57, 28);
            this.ComboBox12.TabIndex = 0;
            // 
            // deleteMenuStrip1
            // 
            this.deleteMenuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.deleteMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.deleteMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.ToolStripMenuItem4});
            this.deleteMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.deleteMenuStrip1.Name = "deleteMenuStrip1";
            this.deleteMenuStrip1.Size = new System.Drawing.Size(411, 24);
            this.deleteMenuStrip1.TabIndex = 17;
            this.deleteMenuStrip1.Text = "MenuStrip1";
            this.deleteMenuStrip1.Visible = false;
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem2,
            this.ToolStripMenuItem3});
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.ToolStripMenuItem1.Text = "File";
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(257, 34);
            this.ToolStripMenuItem2.Text = "Open Channel File";
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(257, 34);
            this.ToolStripMenuItem3.Text = "Save Channel File";
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem5,
            this.ToolStripMenuItem6});
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(92, 20);
            this.ToolStripMenuItem4.Text = "Options";
            // 
            // ToolStripMenuItem5
            // 
            this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            this.ToolStripMenuItem5.Size = new System.Drawing.Size(266, 34);
            this.ToolStripMenuItem5.Text = "Back to Main Menu";
            // 
            // ToolStripMenuItem6
            // 
            this.ToolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripComboBox1});
            this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
            this.ToolStripMenuItem6.Size = new System.Drawing.Size(266, 34);
            this.ToolStripMenuItem6.Text = "kHz Step Size";
            // 
            // ToolStripComboBox1
            // 
            this.ToolStripComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripComboBox1.Items.AddRange(new object[] {
            "10",
            "12.5"});
            this.ToolStripComboBox1.Name = "ToolStripComboBox1";
            this.ToolStripComboBox1.Size = new System.Drawing.Size(121, 33);
            // 
            // Panel18
            // 
            this.Panel18.BackColor = System.Drawing.Color.Silver;
            this.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel18.Controls.Add(this.Label51);
            this.Panel18.Controls.Add(this.NumericUpDown3);
            this.Panel18.Controls.Add(this.Label52);
            this.Panel18.Controls.Add(this.NumericUpDown4);
            this.Panel18.Controls.Add(this.Button6);
            this.Panel18.Controls.Add(this.Label53);
            this.Panel18.Controls.Add(this.ProgressBar2);
            this.Panel18.Controls.Add(this.Button7);
            this.Panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel18.Location = new System.Drawing.Point(3, 171);
            this.Panel18.Name = "Panel18";
            this.Panel18.Size = new System.Drawing.Size(415, 141);
            this.Panel18.TabIndex = 1;
            // 
            // Label51
            // 
            this.Label51.AutoSize = true;
            this.Label51.Location = new System.Drawing.Point(9, 42);
            this.Label51.Name = "Label51";
            this.Label51.Size = new System.Drawing.Size(101, 20);
            this.Label51.TabIndex = 18;
            this.Label51.Text = "Button in mS";
            // 
            // NumericUpDown3
            // 
            this.NumericUpDown3.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown3.Location = new System.Drawing.Point(9, 57);
            this.NumericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDown3.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown3.Name = "NumericUpDown3";
            this.NumericUpDown3.Size = new System.Drawing.Size(55, 26);
            this.NumericUpDown3.TabIndex = 17;
            this.NumericUpDown3.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // Label52
            // 
            this.Label52.AutoSize = true;
            this.Label52.Location = new System.Drawing.Point(9, 4);
            this.Label52.Name = "Label52";
            this.Label52.Size = new System.Drawing.Size(89, 20);
            this.Label52.TabIndex = 16;
            this.Label52.Text = "Tone in mS";
            // 
            // NumericUpDown4
            // 
            this.NumericUpDown4.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown4.Location = new System.Drawing.Point(9, 19);
            this.NumericUpDown4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDown4.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown4.Name = "NumericUpDown4";
            this.NumericUpDown4.Size = new System.Drawing.Size(55, 26);
            this.NumericUpDown4.TabIndex = 15;
            this.NumericUpDown4.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(78, 56);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(100, 37);
            this.Button6.TabIndex = 12;
            this.Button6.Text = "Clear Channel List";
            this.Button6.UseVisualStyleBackColor = true;
            // 
            // Label53
            // 
            this.Label53.AutoSize = true;
            this.Label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label53.Location = new System.Drawing.Point(73, 13);
            this.Label53.Name = "Label53";
            this.Label53.Size = new System.Drawing.Size(358, 37);
            this.Label53.TabIndex = 11;
            this.Label53.Text = "Channel Programming";
            // 
            // ProgressBar2
            // 
            this.ProgressBar2.Location = new System.Drawing.Point(31, 108);
            this.ProgressBar2.Name = "ProgressBar2";
            this.ProgressBar2.Size = new System.Drawing.Size(335, 16);
            this.ProgressBar2.TabIndex = 1;
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(220, 56);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(95, 37);
            this.Button7.TabIndex = 0;
            this.Button7.Text = "Program Radio Channels";
            this.Button7.UseVisualStyleBackColor = true;
            // 
            // deleteStatusStrip1
            // 
            this.deleteStatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.deleteStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripStatusLabel2});
            this.deleteStatusStrip1.Location = new System.Drawing.Point(0, 438);
            this.deleteStatusStrip1.Name = "deleteStatusStrip1";
            this.deleteStatusStrip1.Size = new System.Drawing.Size(421, 32);
            this.deleteStatusStrip1.TabIndex = 2;
            this.deleteStatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(180, 25);
            this.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(196, 25);
            this.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2";
            // 
            // Panel19
            // 
            this.Panel19.BackColor = System.Drawing.Color.Silver;
            this.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel19.Controls.Add(this.ListView3);
            this.Panel19.Controls.Add(this.Label54);
            this.Panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel19.Location = new System.Drawing.Point(430, 3);
            this.Panel19.Name = "Panel19";
            this.Panel19.Size = new System.Drawing.Size(405, 470);
            this.Panel19.TabIndex = 1;
            // 
            // ListView3
            // 
            this.ListView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader16,
            this.ColumnHeader17,
            this.ColumnHeader18,
            this.ColumnHeader19,
            this.ColumnHeader20});
            this.ListView3.FullRowSelect = true;
            this.ListView3.GridLines = true;
            this.ListView3.HideSelection = false;
            this.ListView3.Location = new System.Drawing.Point(0, 49);
            this.ListView3.MultiSelect = false;
            this.ListView3.Name = "ListView3";
            this.ListView3.Size = new System.Drawing.Size(389, 377);
            this.ListView3.TabIndex = 12;
            this.ListView3.UseCompatibleStateImageBehavior = false;
            this.ListView3.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader16
            // 
            this.ColumnHeader16.Text = "Channel";
            this.ColumnHeader16.Width = 64;
            // 
            // ColumnHeader17
            // 
            this.ColumnHeader17.Text = "Frequency";
            this.ColumnHeader17.Width = 81;
            // 
            // ColumnHeader18
            // 
            this.ColumnHeader18.Text = "Repeater Mode";
            this.ColumnHeader18.Width = 105;
            // 
            // ColumnHeader19
            // 
            this.ColumnHeader19.Text = "Tone";
            this.ColumnHeader19.Width = 76;
            // 
            // ColumnHeader20
            // 
            this.ColumnHeader20.Text = " CTSS";
            // 
            // Label54
            // 
            this.Label54.AutoSize = true;
            this.Label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label54.Location = new System.Drawing.Point(109, 10);
            this.Label54.Name = "Label54";
            this.Label54.Size = new System.Drawing.Size(207, 37);
            this.Label54.TabIndex = 11;
            this.Label54.Text = "Channel List";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1014, 669);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Channel Lists (Version 1.2)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.TabControl.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.Tab1TableLayoutPanel1.ResumeLayout(false);
            this.Tab1TableLayoutPanel1.PerformLayout();
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Tab1CtcssPanel.ResumeLayout(false);
            this.Tab1CtcssPanel.PerformLayout();
            this.Tab1MenuStrip.ResumeLayout(false);
            this.Tab1MenuStrip.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Tab1StatusStrip1.ResumeLayout(false);
            this.Tab1StatusStrip1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TableLayoutPanel7.ResumeLayout(false);
            this.TableLayoutPanel4.ResumeLayout(false);
            this.TableLayoutPanel4.PerformLayout();
            this.Panel11.ResumeLayout(false);
            this.Panel11.PerformLayout();
            this.Panel8.ResumeLayout(false);
            this.Panel8.PerformLayout();
            this.Tab2MenuStrip.ResumeLayout(false);
            this.Tab2MenuStrip.PerformLayout();
            this.Panel12.ResumeLayout(false);
            this.Panel12.PerformLayout();
            this.Tab2StatusStrip.ResumeLayout(false);
            this.Tab2StatusStrip.PerformLayout();
            this.Panel15.ResumeLayout(false);
            this.Panel15.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TableLayoutPanel8.ResumeLayout(false);
            this.TableLayoutPanel10.ResumeLayout(false);
            this.TableLayoutPanel10.PerformLayout();
            this.Panel20.ResumeLayout(false);
            this.Panel20.PerformLayout();
            this.Panel21.ResumeLayout(false);
            this.Panel21.PerformLayout();
            this.Tab3MenuStrip.ResumeLayout(false);
            this.Tab3MenuStrip.PerformLayout();
            this.Panel22.ResumeLayout(false);
            this.Panel22.PerformLayout();
            this.Tab3StatusStrip.ResumeLayout(false);
            this.Tab3StatusStrip.PerformLayout();
            this.Panel23.ResumeLayout(false);
            this.Panel23.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel3.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).EndInit();
            this.Panel7.ResumeLayout(false);
            this.Panel7.PerformLayout();
            this.Panel9.ResumeLayout(false);
            this.Panel9.PerformLayout();
            this.Panel10.ResumeLayout(false);
            this.Panel10.PerformLayout();
            this.TableLayoutPanel5.ResumeLayout(false);
            this.TableLayoutPanel6.ResumeLayout(false);
            this.Panel13.ResumeLayout(false);
            this.Panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown6)).EndInit();
            this.Panel14.ResumeLayout(false);
            this.Panel14.PerformLayout();
            this.TableLayoutPanel9.ResumeLayout(false);
            this.TableLayoutPanel9.PerformLayout();
            this.Panel16.ResumeLayout(false);
            this.Panel16.PerformLayout();
            this.Panel17.ResumeLayout(false);
            this.Panel17.PerformLayout();
            this.deleteMenuStrip1.ResumeLayout(false);
            this.deleteMenuStrip1.PerformLayout();
            this.Panel18.ResumeLayout(false);
            this.Panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown4)).EndInit();
            this.deleteStatusStrip1.ResumeLayout(false);
            this.deleteStatusStrip1.PerformLayout();
            this.Panel19.ResumeLayout(false);
            this.Panel19.PerformLayout();
            this.ResumeLayout(false);

        }


        internal Timer Timer1;
        internal OpenFileDialog OpenFileDialog1;
        internal SaveFileDialog SaveFileDialog1;


        internal TabControl TabControl;
        internal TableLayoutPanel Tab1TableLayoutPanel1;
        internal TableLayoutPanel TableLayoutPanel2;
        internal Panel Panel1;
        internal Panel Tab1CtcssPanel;
        internal RadioButton Tab1CtcssXmit;
        internal RadioButton Tab1CtcssXmitRec;
        internal Label Tab1CtcssLabel;
        internal Button Tab1SetChannelButton;
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
        internal Button Tab2SetChannelButton;
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
        internal TableLayoutPanel TableLayoutPanel8;
        internal TableLayoutPanel TableLayoutPanel10;
        internal Panel Panel20;
        internal Panel Panel21;
        internal RadioButton Tab3CtcssXmit;
        internal RadioButton Tab3CtcssXmitRec;
        internal Label Label55;
        internal Button Tab3SetChannelButton;
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
        private TextBox textBoxSerialCommands;
        public TabPage TabPage1;
        public TabPage TabPage2;
        public TabPage TabPage3;
    }
}