<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Tab1TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tab1DeleteRowButton = New System.Windows.Forms.Button()
        Me.Tab1InsertRowButton = New System.Windows.Forms.Button()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Tab1ChannelNotes = New System.Windows.Forms.TextBox()
        Me.Tab1CtcssPanel = New System.Windows.Forms.Panel()
        Me.Tab1CtcssOff = New System.Windows.Forms.RadioButton()
        Me.Tab1CtcssXmit = New System.Windows.Forms.RadioButton()
        Me.Tab1CtcssXmitRec = New System.Windows.Forms.RadioButton()
        Me.Tab1CtcssLabel = New System.Windows.Forms.Label()
        Me.Tab1SetChannelButtone = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tab1ClearChannelList = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tab1ChannelTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tab1ToneComboBox = New System.Windows.Forms.ComboBox()
        Me.Tab1RepeaterComboBox = New System.Windows.Forms.ComboBox()
        Me.Tab1KHzCombBox = New System.Windows.Forms.ComboBox()
        Me.Tab1MHzComboBox = New System.Windows.Forms.ComboBox()
        Me.Tab1MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.Tab1FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab1OpenChannelFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab1SaveChannelFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab1SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab1BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab1KHzStepSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab1KHzToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tab1ChannelFileName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tab1StopProgramButton = New System.Windows.Forms.Button()
        Me.Tab1UsbRcvdLabel = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Tab1UsbCmdLabel = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Tab1ComPortTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tab1ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Tab1ProgramButton = New System.Windows.Forms.Button()
        Me.Tab1StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Tab1ToolStripStepSize = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tab1ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Tab1ChannelListView = New System.Windows.Forms.ListView()
        Me.Channel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Frequency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Repeater = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CTSS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Notes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Tab2DeleteRowButton = New System.Windows.Forms.Button()
        Me.Tab2InsertRowButton = New System.Windows.Forms.Button()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Tab2ChannelNotes = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Tab2CtcssOff = New System.Windows.Forms.RadioButton()
        Me.Tab2CtcssXmit = New System.Windows.Forms.RadioButton()
        Me.Tab2CtcssXmitRec = New System.Windows.Forms.RadioButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Tab2SetChannelButtone = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Tab2ClearChannelList = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Tab2ChannelTextBox = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Tab2ToneComboBox = New System.Windows.Forms.ComboBox()
        Me.Tab2RepeaterComboBox = New System.Windows.Forms.ComboBox()
        Me.Tab2KHzCombBox = New System.Windows.Forms.ComboBox()
        Me.Tab2MHzComboBox = New System.Windows.Forms.ComboBox()
        Me.Tab2MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.Tab2FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab2OpenChannelFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab2SaveChannelFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab2SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab2BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab2KHzStepSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab2KHzToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.tab2ChannelFileName = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Tab2StopProgramButton = New System.Windows.Forms.Button()
        Me.Tab2UsbRcvdLabel = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Tab2UsbCmdLabel = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Tab2ComPortTextBox = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Tab2ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Tab2ProgramButton = New System.Windows.Forms.Button()
        Me.Tab2StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.Tab2ToolStripStepSize = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tab2ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Tab2ChannelListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Tab3DeleteRowButton = New System.Windows.Forms.Button()
        Me.Tab3InsertRowButton = New System.Windows.Forms.Button()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Tab3ChannelNotes = New System.Windows.Forms.TextBox()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Tab3CtcssOff = New System.Windows.Forms.RadioButton()
        Me.Tab3CtcssXmit = New System.Windows.Forms.RadioButton()
        Me.Tab3CtcssXmitRec = New System.Windows.Forms.RadioButton()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Tab3SetChannelButtone = New System.Windows.Forms.Button()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Tab3ClearChannelList = New System.Windows.Forms.Button()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Tab3ChannelTextBox = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Tab3ToneComboBox = New System.Windows.Forms.ComboBox()
        Me.Tab3RepeaterComboBox = New System.Windows.Forms.ComboBox()
        Me.Tab3KHzCombBox = New System.Windows.Forms.ComboBox()
        Me.Tab3MHzComboBox = New System.Windows.Forms.ComboBox()
        Me.Tab3MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.Tab3FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab3OpenChannelFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab3SaveChannelFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab3SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab3BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab3KHzStepSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab3KHzToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.tab3ChannelFileName = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Tab3StopProgramButton = New System.Windows.Forms.Button()
        Me.Tab3UsbRcvdLabel = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Tab3UsbCmdLabel = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Tab3ComPortTextBox = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Tab3ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Tab3ProgramButton = New System.Windows.Forms.Button()
        Me.Tab3StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.Tab3ToolStripStepSize = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tab3ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Tab3ChannelListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label65 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.deleteMenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.deleteStatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label54 = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Tab1TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Tab1CtcssPanel.SuspendLayout()
        Me.Tab1MenuStrip.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Tab1StatusStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Tab2MenuStrip.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Tab2StatusStrip.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Tab3MenuStrip.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Tab3StatusStrip.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.deleteMenuStrip1.SuspendLayout()
        Me.Panel18.SuspendLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.deleteStatusStrip1.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveFileDialog1
        '
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1014, 568)
        Me.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Tab1TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1006, 530)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Tab1TableLayoutPanel1
        '
        Me.Tab1TableLayoutPanel1.ColumnCount = 2
        Me.Tab1TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.78069!))
        Me.Tab1TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.21931!))
        Me.Tab1TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.Tab1TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 0)
        Me.Tab1TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab1TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.Tab1TableLayoutPanel1.Name = "Tab1TableLayoutPanel1"
        Me.Tab1TableLayoutPanel1.RowCount = 1
        Me.Tab1TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Tab1TableLayoutPanel1.Size = New System.Drawing.Size(1000, 524)
        Me.Tab1TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Tab1StatusStrip1, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(461, 518)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Tab1DeleteRowButton)
        Me.Panel1.Controls.Add(Me.Tab1InsertRowButton)
        Me.Panel1.Controls.Add(Me.Label67)
        Me.Panel1.Controls.Add(Me.Tab1ChannelNotes)
        Me.Panel1.Controls.Add(Me.Tab1CtcssPanel)
        Me.Panel1.Controls.Add(Me.Tab1CtcssLabel)
        Me.Panel1.Controls.Add(Me.Tab1SetChannelButtone)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Tab1ClearChannelList)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Tab1ChannelTextBox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Tab1ToneComboBox)
        Me.Panel1.Controls.Add(Me.Tab1RepeaterComboBox)
        Me.Panel1.Controls.Add(Me.Tab1KHzCombBox)
        Me.Panel1.Controls.Add(Me.Tab1MHzComboBox)
        Me.Panel1.Controls.Add(Me.Tab1MenuStrip)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 277)
        Me.Panel1.TabIndex = 0
        '
        'Tab1DeleteRowButton
        '
        Me.Tab1DeleteRowButton.Location = New System.Drawing.Point(268, 243)
        Me.Tab1DeleteRowButton.Name = "Tab1DeleteRowButton"
        Me.Tab1DeleteRowButton.Size = New System.Drawing.Size(139, 23)
        Me.Tab1DeleteRowButton.TabIndex = 24
        Me.Tab1DeleteRowButton.Text = "Delete Row"
        Me.Tab1DeleteRowButton.UseVisualStyleBackColor = True
        '
        'Tab1InsertRowButton
        '
        Me.Tab1InsertRowButton.Location = New System.Drawing.Point(268, 214)
        Me.Tab1InsertRowButton.Name = "Tab1InsertRowButton"
        Me.Tab1InsertRowButton.Size = New System.Drawing.Size(140, 23)
        Me.Tab1InsertRowButton.TabIndex = 22
        Me.Tab1InsertRowButton.Text = "Insert Row"
        Me.Tab1InsertRowButton.UseVisualStyleBackColor = True
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(7, 103)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(155, 25)
        Me.Label67.TabIndex = 19
        Me.Label67.Text = "Channel Notes"
        '
        'Tab1ChannelNotes
        '
        Me.Tab1ChannelNotes.Location = New System.Drawing.Point(7, 122)
        Me.Tab1ChannelNotes.MaxLength = 25
        Me.Tab1ChannelNotes.Name = "Tab1ChannelNotes"
        Me.Tab1ChannelNotes.Size = New System.Drawing.Size(335, 30)
        Me.Tab1ChannelNotes.TabIndex = 18
        '
        'Tab1CtcssPanel
        '
        Me.Tab1CtcssPanel.Controls.Add(Me.Tab1CtcssOff)
        Me.Tab1CtcssPanel.Controls.Add(Me.Tab1CtcssXmit)
        Me.Tab1CtcssPanel.Controls.Add(Me.Tab1CtcssXmitRec)
        Me.Tab1CtcssPanel.Location = New System.Drawing.Point(348, 76)
        Me.Tab1CtcssPanel.Name = "Tab1CtcssPanel"
        Me.Tab1CtcssPanel.Size = New System.Drawing.Size(100, 72)
        Me.Tab1CtcssPanel.TabIndex = 16
        '
        'Tab1CtcssOff
        '
        Me.Tab1CtcssOff.AutoSize = True
        Me.Tab1CtcssOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1CtcssOff.Location = New System.Drawing.Point(9, 46)
        Me.Tab1CtcssOff.Name = "Tab1CtcssOff"
        Me.Tab1CtcssOff.Size = New System.Drawing.Size(66, 29)
        Me.Tab1CtcssOff.TabIndex = 16
        Me.Tab1CtcssOff.TabStop = True
        Me.Tab1CtcssOff.Text = "Off"
        Me.Tab1CtcssOff.UseVisualStyleBackColor = True
        '
        'Tab1CtcssXmit
        '
        Me.Tab1CtcssXmit.AutoSize = True
        Me.Tab1CtcssXmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1CtcssXmit.Location = New System.Drawing.Point(9, 5)
        Me.Tab1CtcssXmit.Name = "Tab1CtcssXmit"
        Me.Tab1CtcssXmit.Size = New System.Drawing.Size(80, 29)
        Me.Tab1CtcssXmit.TabIndex = 14
        Me.Tab1CtcssXmit.TabStop = True
        Me.Tab1CtcssXmit.Text = "Xmit"
        Me.Tab1CtcssXmit.UseVisualStyleBackColor = True
        '
        'Tab1CtcssXmitRec
        '
        Me.Tab1CtcssXmitRec.AutoSize = True
        Me.Tab1CtcssXmitRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1CtcssXmitRec.Location = New System.Drawing.Point(9, 26)
        Me.Tab1CtcssXmitRec.Name = "Tab1CtcssXmitRec"
        Me.Tab1CtcssXmitRec.Size = New System.Drawing.Size(124, 29)
        Me.Tab1CtcssXmitRec.TabIndex = 15
        Me.Tab1CtcssXmitRec.TabStop = True
        Me.Tab1CtcssXmitRec.Text = "Xmit/Rec"
        Me.Tab1CtcssXmitRec.UseVisualStyleBackColor = True
        '
        'Tab1CtcssLabel
        '
        Me.Tab1CtcssLabel.AutoSize = True
        Me.Tab1CtcssLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1CtcssLabel.Location = New System.Drawing.Point(359, 60)
        Me.Tab1CtcssLabel.Name = "Tab1CtcssLabel"
        Me.Tab1CtcssLabel.Size = New System.Drawing.Size(88, 25)
        Me.Tab1CtcssLabel.TabIndex = 13
        Me.Tab1CtcssLabel.Text = "CTCSS"
        '
        'Tab1SetChannelButtone
        '
        Me.Tab1SetChannelButtone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1SetChannelButtone.Location = New System.Drawing.Point(268, 154)
        Me.Tab1SetChannelButtone.Name = "Tab1SetChannelButtone"
        Me.Tab1SetChannelButtone.Size = New System.Drawing.Size(140, 48)
        Me.Tab1SetChannelButtone.TabIndex = 11
        Me.Tab1SetChannelButtone.Text = "Set/Update Channel"
        Me.Tab1SetChannelButtone.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(115, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(276, 37)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Channel Settings"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(294, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tone"
        '
        'Tab1ClearChannelList
        '
        Me.Tab1ClearChannelList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1ClearChannelList.Location = New System.Drawing.Point(138, 209)
        Me.Tab1ClearChannelList.Name = "Tab1ClearChannelList"
        Me.Tab1ClearChannelList.Size = New System.Drawing.Size(111, 43)
        Me.Tab1ClearChannelList.TabIndex = 12
        Me.Tab1ClearChannelList.Text = "Clear Channel List"
        Me.Tab1ClearChannelList.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(207, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Repeater"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(146, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "KHz"
        '
        'Tab1ChannelTextBox
        '
        Me.Tab1ChannelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1ChannelTextBox.Location = New System.Drawing.Point(7, 77)
        Me.Tab1ChannelTextBox.Name = "Tab1ChannelTextBox"
        Me.Tab1ChannelTextBox.ReadOnly = True
        Me.Tab1ChannelTextBox.Size = New System.Drawing.Size(46, 28)
        Me.Tab1ChannelTextBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CH #"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "MHz"
        '
        'Tab1ToneComboBox
        '
        Me.Tab1ToneComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1ToneComboBox.FormattingEnabled = True
        Me.Tab1ToneComboBox.Items.AddRange(New Object() {"OFF", "67.0", "71.9", "74.4", "77.0", "79.7", "82.5", "85.4", "88.5", "91.5", "94.8", "97.4", "100.0", "103.5", "107.2", "110.9", "114.8", "118.8", "123.0", "127.3", "131.8", "136.5", "141.3", "146.2", "151.4", "156.7", "162.2", "167.9", "173.8", "179.9", "186.2", "192.8", "203.5", "210.7", "218.1", "225.7", "233.6", "241.8", "250.3"})
        Me.Tab1ToneComboBox.Location = New System.Drawing.Point(291, 76)
        Me.Tab1ToneComboBox.Name = "Tab1ToneComboBox"
        Me.Tab1ToneComboBox.Size = New System.Drawing.Size(58, 30)
        Me.Tab1ToneComboBox.TabIndex = 3
        '
        'Tab1RepeaterComboBox
        '
        Me.Tab1RepeaterComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1RepeaterComboBox.FormattingEnabled = True
        Me.Tab1RepeaterComboBox.Items.AddRange(New Object() {"PLUS", "MINUS", "SIMPLEX"})
        Me.Tab1RepeaterComboBox.Location = New System.Drawing.Point(204, 76)
        Me.Tab1RepeaterComboBox.Name = "Tab1RepeaterComboBox"
        Me.Tab1RepeaterComboBox.Size = New System.Drawing.Size(83, 30)
        Me.Tab1RepeaterComboBox.TabIndex = 2
        '
        'Tab1KHzCombBox
        '
        Me.Tab1KHzCombBox.DropDownWidth = 43
        Me.Tab1KHzCombBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1KHzCombBox.FormattingEnabled = True
        Me.Tab1KHzCombBox.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "110", "120", "130", "140", "150", "160", "170", "180", "190", "200", "210", "220", "230", "240", "250", "260", "270", "280", "290", "300", "310", "320", "330", "340", "350", "360", "370", "380", "390", "400", "410", "420", "430", "440", "450", "460", "470", "480", "490", "500", "510", "520", "530", "540", "550", "560", "570", "580", "590", "600", "610", "620", "630", "640", "650", "660", "670", "680", "690", "700", "710", "720", "730", "740", "750", "760", "770", "780", "790", "800", "810", "820", "830", "840", "850", "860", "870", "880", "890", "900", "910", "920", "930", "940", "950", "960", "970", "980", "990"})
        Me.Tab1KHzCombBox.Location = New System.Drawing.Point(134, 76)
        Me.Tab1KHzCombBox.MaxDropDownItems = 10
        Me.Tab1KHzCombBox.Name = "Tab1KHzCombBox"
        Me.Tab1KHzCombBox.Size = New System.Drawing.Size(66, 30)
        Me.Tab1KHzCombBox.TabIndex = 1
        '
        'Tab1MHzComboBox
        '
        Me.Tab1MHzComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1MHzComboBox.FormattingEnabled = True
        Me.Tab1MHzComboBox.Items.AddRange(New Object() {"BLANK", "146", "147", "148", "149", "150"})
        Me.Tab1MHzComboBox.Location = New System.Drawing.Point(60, 76)
        Me.Tab1MHzComboBox.Name = "Tab1MHzComboBox"
        Me.Tab1MHzComboBox.Size = New System.Drawing.Size(70, 30)
        Me.Tab1MHzComboBox.TabIndex = 0
        '
        'Tab1MenuStrip
        '
        Me.Tab1MenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.Tab1MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Tab1MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tab1FileToolStripMenuItem, Me.Tab1SettingsToolStripMenuItem})
        Me.Tab1MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.Tab1MenuStrip.Name = "Tab1MenuStrip"
        Me.Tab1MenuStrip.Size = New System.Drawing.Size(451, 33)
        Me.Tab1MenuStrip.TabIndex = 17
        Me.Tab1MenuStrip.Text = "MenuStrip1"
        '
        'Tab1FileToolStripMenuItem
        '
        Me.Tab1FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tab1OpenChannelFileToolStripMenuItem, Me.Tab1SaveChannelFileToolStripMenuItem})
        Me.Tab1FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Tab1FileToolStripMenuItem.Name = "Tab1FileToolStripMenuItem"
        Me.Tab1FileToolStripMenuItem.Size = New System.Drawing.Size(57, 29)
        Me.Tab1FileToolStripMenuItem.Text = "File"
        '
        'Tab1OpenChannelFileToolStripMenuItem
        '
        Me.Tab1OpenChannelFileToolStripMenuItem.Name = "Tab1OpenChannelFileToolStripMenuItem"
        Me.Tab1OpenChannelFileToolStripMenuItem.Size = New System.Drawing.Size(268, 34)
        Me.Tab1OpenChannelFileToolStripMenuItem.Text = "Open Channel File"
        '
        'Tab1SaveChannelFileToolStripMenuItem
        '
        Me.Tab1SaveChannelFileToolStripMenuItem.Name = "Tab1SaveChannelFileToolStripMenuItem"
        Me.Tab1SaveChannelFileToolStripMenuItem.Size = New System.Drawing.Size(268, 34)
        Me.Tab1SaveChannelFileToolStripMenuItem.Text = "Save Channel File"
        '
        'Tab1SettingsToolStripMenuItem
        '
        Me.Tab1SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tab1BackToMainMenuToolStripMenuItem, Me.Tab1KHzStepSizeToolStripMenuItem})
        Me.Tab1SettingsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Tab1SettingsToolStripMenuItem.Name = "Tab1SettingsToolStripMenuItem"
        Me.Tab1SettingsToolStripMenuItem.Size = New System.Drawing.Size(95, 29)
        Me.Tab1SettingsToolStripMenuItem.Text = "Options"
        '
        'Tab1BackToMainMenuToolStripMenuItem
        '
        Me.Tab1BackToMainMenuToolStripMenuItem.Name = "Tab1BackToMainMenuToolStripMenuItem"
        Me.Tab1BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(280, 34)
        Me.Tab1BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu"
        '
        'Tab1KHzStepSizeToolStripMenuItem
        '
        Me.Tab1KHzStepSizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tab1KHzToolStripComboBox})
        Me.Tab1KHzStepSizeToolStripMenuItem.Name = "Tab1KHzStepSizeToolStripMenuItem"
        Me.Tab1KHzStepSizeToolStripMenuItem.Size = New System.Drawing.Size(280, 34)
        Me.Tab1KHzStepSizeToolStripMenuItem.Text = "kHz Step Size"
        '
        'Tab1KHzToolStripComboBox
        '
        Me.Tab1KHzToolStripComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Tab1KHzToolStripComboBox.Items.AddRange(New Object() {"10", "12.5", "5", "25"})
        Me.Tab1KHzToolStripComboBox.Name = "Tab1KHzToolStripComboBox"
        Me.Tab1KHzToolStripComboBox.Size = New System.Drawing.Size(121, 33)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.tab1ChannelFileName)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Tab1StopProgramButton)
        Me.Panel2.Controls.Add(Me.Tab1UsbRcvdLabel)
        Me.Panel2.Controls.Add(Me.Label72)
        Me.Panel2.Controls.Add(Me.Tab1UsbCmdLabel)
        Me.Panel2.Controls.Add(Me.Label66)
        Me.Panel2.Controls.Add(Me.Tab1ComPortTextBox)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Tab1ProgressBar1)
        Me.Panel2.Controls.Add(Me.Tab1ProgramButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 286)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(455, 206)
        Me.Panel2.TabIndex = 1
        '
        'tab1ChannelFileName
        '
        Me.tab1ChannelFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tab1ChannelFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1ChannelFileName.Location = New System.Drawing.Point(149, 173)
        Me.tab1ChannelFileName.Name = "tab1ChannelFileName"
        Me.tab1ChannelFileName.Size = New System.Drawing.Size(298, 25)
        Me.tab1ChannelFileName.TabIndex = 26
        Me.tab1ChannelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tab1ChannelFileName.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 25)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Channel Filename"
        Me.Label9.Visible = False
        '
        'Tab1StopProgramButton
        '
        Me.Tab1StopProgramButton.Location = New System.Drawing.Point(45, 50)
        Me.Tab1StopProgramButton.Name = "Tab1StopProgramButton"
        Me.Tab1StopProgramButton.Size = New System.Drawing.Size(117, 44)
        Me.Tab1StopProgramButton.TabIndex = 24
        Me.Tab1StopProgramButton.Text = "Stop Programming"
        Me.Tab1StopProgramButton.UseVisualStyleBackColor = True
        '
        'Tab1UsbRcvdLabel
        '
        Me.Tab1UsbRcvdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tab1UsbRcvdLabel.Location = New System.Drawing.Point(352, 134)
        Me.Tab1UsbRcvdLabel.Name = "Tab1UsbRcvdLabel"
        Me.Tab1UsbRcvdLabel.Size = New System.Drawing.Size(96, 25)
        Me.Tab1UsbRcvdLabel.TabIndex = 23
        Me.Tab1UsbRcvdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(277, 138)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(94, 25)
        Me.Label72.TabIndex = 22
        Me.Label72.Text = "received"
        '
        'Tab1UsbCmdLabel
        '
        Me.Tab1UsbCmdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tab1UsbCmdLabel.Location = New System.Drawing.Point(168, 134)
        Me.Tab1UsbCmdLabel.Name = "Tab1UsbCmdLabel"
        Me.Tab1UsbCmdLabel.Size = New System.Drawing.Size(96, 25)
        Me.Tab1UsbCmdLabel.TabIndex = 21
        Me.Tab1UsbCmdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label66
        '
        Me.Label66.Location = New System.Drawing.Point(10, 134)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(179, 25)
        Me.Label66.TabIndex = 20
        Me.Label66.Text = "Serial command sent"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tab1ComPortTextBox
        '
        Me.Tab1ComPortTextBox.Enabled = False
        Me.Tab1ComPortTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1ComPortTextBox.Location = New System.Drawing.Point(347, 13)
        Me.Tab1ComPortTextBox.Multiline = True
        Me.Tab1ComPortTextBox.Name = "Tab1ComPortTextBox"
        Me.Tab1ComPortTextBox.Size = New System.Drawing.Size(87, 80)
        Me.Tab1ComPortTextBox.TabIndex = 19
        Me.Tab1ComPortTextBox.Text = "test1"
        Me.Tab1ComPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Tab1ComPortTextBox.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(80, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(320, 37)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Radio Programming"
        '
        'Tab1ProgressBar1
        '
        Me.Tab1ProgressBar1.Location = New System.Drawing.Point(53, 108)
        Me.Tab1ProgressBar1.Name = "Tab1ProgressBar1"
        Me.Tab1ProgressBar1.Size = New System.Drawing.Size(335, 16)
        Me.Tab1ProgressBar1.TabIndex = 1
        '
        'Tab1ProgramButton
        '
        Me.Tab1ProgramButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1ProgramButton.Location = New System.Drawing.Point(215, 50)
        Me.Tab1ProgramButton.Name = "Tab1ProgramButton"
        Me.Tab1ProgramButton.Size = New System.Drawing.Size(98, 44)
        Me.Tab1ProgramButton.TabIndex = 0
        Me.Tab1ProgramButton.Text = "Program Radio Channels"
        Me.Tab1ProgramButton.UseVisualStyleBackColor = True
        '
        'Tab1StatusStrip1
        '
        Me.Tab1StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Tab1StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tab1ToolStripStepSize, Me.Tab1ToolStripStatusLabel})
        Me.Tab1StatusStrip1.Location = New System.Drawing.Point(0, 495)
        Me.Tab1StatusStrip1.Name = "Tab1StatusStrip1"
        Me.Tab1StatusStrip1.Size = New System.Drawing.Size(461, 23)
        Me.Tab1StatusStrip1.TabIndex = 2
        Me.Tab1StatusStrip1.Text = "StatusStrip1"
        '
        'Tab1ToolStripStepSize
        '
        Me.Tab1ToolStripStepSize.Name = "Tab1ToolStripStepSize"
        Me.Tab1ToolStripStepSize.Size = New System.Drawing.Size(180, 16)
        Me.Tab1ToolStripStepSize.Text = "ToolStripStatusLabel1"
        '
        'Tab1ToolStripStatusLabel
        '
        Me.Tab1ToolStripStatusLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Tab1ToolStripStatusLabel.Name = "Tab1ToolStripStatusLabel"
        Me.Tab1ToolStripStatusLabel.Size = New System.Drawing.Size(196, 16)
        Me.Tab1ToolStripStatusLabel.Text = "ToolStripStatusLabel2"
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Tab1ChannelListView)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(470, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(527, 518)
        Me.Panel3.TabIndex = 1
        '
        'Tab1ChannelListView
        '
        Me.Tab1ChannelListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Channel, Me.Frequency, Me.Repeater, Me.Tone, Me.CTSS, Me.Notes})
        Me.Tab1ChannelListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab1ChannelListView.FullRowSelect = True
        Me.Tab1ChannelListView.GridLines = True
        Me.Tab1ChannelListView.HideSelection = False
        Me.Tab1ChannelListView.LabelWrap = False
        Me.Tab1ChannelListView.Location = New System.Drawing.Point(0, 34)
        Me.Tab1ChannelListView.MultiSelect = False
        Me.Tab1ChannelListView.Name = "Tab1ChannelListView"
        Me.Tab1ChannelListView.Size = New System.Drawing.Size(523, 463)
        Me.Tab1ChannelListView.TabIndex = 12
        Me.Tab1ChannelListView.UseCompatibleStateImageBehavior = False
        Me.Tab1ChannelListView.View = System.Windows.Forms.View.Details
        '
        'Channel
        '
        Me.Channel.Text = "CH#"
        Me.Channel.Width = 42
        '
        'Frequency
        '
        Me.Frequency.Text = "Frequency"
        Me.Frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Frequency.Width = 91
        '
        'Repeater
        '
        Me.Repeater.Text = "Repeater"
        Me.Repeater.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Repeater.Width = 81
        '
        'Tone
        '
        Me.Tone.Text = "Tone"
        Me.Tone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Tone.Width = 50
        '
        'CTSS
        '
        Me.CTSS.Text = " CTCSS"
        Me.CTSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CTSS.Width = 80
        '
        'Notes
        '
        Me.Notes.Text = "Notes"
        Me.Notes.Width = 375
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(176, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(207, 37)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Channel List"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1006, 530)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.7!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.3!))
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Panel15, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1000, 524)
        Me.TableLayoutPanel7.TabIndex = 2
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel11, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel12, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Tab2StatusStrip, 0, 2)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(461, 518)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Silver
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Controls.Add(Me.Tab2DeleteRowButton)
        Me.Panel11.Controls.Add(Me.Tab2InsertRowButton)
        Me.Panel11.Controls.Add(Me.Label70)
        Me.Panel11.Controls.Add(Me.Tab2ChannelNotes)
        Me.Panel11.Controls.Add(Me.Panel8)
        Me.Panel11.Controls.Add(Me.Label22)
        Me.Panel11.Controls.Add(Me.Tab2SetChannelButtone)
        Me.Panel11.Controls.Add(Me.Label23)
        Me.Panel11.Controls.Add(Me.Label24)
        Me.Panel11.Controls.Add(Me.Tab2ClearChannelList)
        Me.Panel11.Controls.Add(Me.Label25)
        Me.Panel11.Controls.Add(Me.Label33)
        Me.Panel11.Controls.Add(Me.Tab2ChannelTextBox)
        Me.Panel11.Controls.Add(Me.Label34)
        Me.Panel11.Controls.Add(Me.Label35)
        Me.Panel11.Controls.Add(Me.Tab2ToneComboBox)
        Me.Panel11.Controls.Add(Me.Tab2RepeaterComboBox)
        Me.Panel11.Controls.Add(Me.Tab2KHzCombBox)
        Me.Panel11.Controls.Add(Me.Tab2MHzComboBox)
        Me.Panel11.Controls.Add(Me.Tab2MenuStrip)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(3, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(455, 277)
        Me.Panel11.TabIndex = 0
        '
        'Tab2DeleteRowButton
        '
        Me.Tab2DeleteRowButton.Location = New System.Drawing.Point(268, 243)
        Me.Tab2DeleteRowButton.Name = "Tab2DeleteRowButton"
        Me.Tab2DeleteRowButton.Size = New System.Drawing.Size(139, 23)
        Me.Tab2DeleteRowButton.TabIndex = 23
        Me.Tab2DeleteRowButton.Text = "Delete Row"
        Me.Tab2DeleteRowButton.UseVisualStyleBackColor = True
        '
        'Tab2InsertRowButton
        '
        Me.Tab2InsertRowButton.Location = New System.Drawing.Point(268, 214)
        Me.Tab2InsertRowButton.Name = "Tab2InsertRowButton"
        Me.Tab2InsertRowButton.Size = New System.Drawing.Size(140, 23)
        Me.Tab2InsertRowButton.TabIndex = 22
        Me.Tab2InsertRowButton.Text = "Insert Row"
        Me.Tab2InsertRowButton.UseVisualStyleBackColor = True
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(7, 103)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(155, 25)
        Me.Label70.TabIndex = 20
        Me.Label70.Text = "Channel Notes"
        '
        'Tab2ChannelNotes
        '
        Me.Tab2ChannelNotes.Location = New System.Drawing.Point(7, 122)
        Me.Tab2ChannelNotes.MaxLength = 10
        Me.Tab2ChannelNotes.Name = "Tab2ChannelNotes"
        Me.Tab2ChannelNotes.Size = New System.Drawing.Size(335, 30)
        Me.Tab2ChannelNotes.TabIndex = 19
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Tab2CtcssOff)
        Me.Panel8.Controls.Add(Me.Tab2CtcssXmit)
        Me.Panel8.Controls.Add(Me.Tab2CtcssXmitRec)
        Me.Panel8.Location = New System.Drawing.Point(348, 76)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(100, 72)
        Me.Panel8.TabIndex = 16
        '
        'Tab2CtcssOff
        '
        Me.Tab2CtcssOff.AutoSize = True
        Me.Tab2CtcssOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab2CtcssOff.Location = New System.Drawing.Point(9, 46)
        Me.Tab2CtcssOff.Name = "Tab2CtcssOff"
        Me.Tab2CtcssOff.Size = New System.Drawing.Size(66, 29)
        Me.Tab2CtcssOff.TabIndex = 17
        Me.Tab2CtcssOff.TabStop = True
        Me.Tab2CtcssOff.Text = "Off"
        Me.Tab2CtcssOff.UseVisualStyleBackColor = True
        '
        'Tab2CtcssXmit
        '
        Me.Tab2CtcssXmit.AutoSize = True
        Me.Tab2CtcssXmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab2CtcssXmit.Location = New System.Drawing.Point(9, 5)
        Me.Tab2CtcssXmit.Name = "Tab2CtcssXmit"
        Me.Tab2CtcssXmit.Size = New System.Drawing.Size(80, 29)
        Me.Tab2CtcssXmit.TabIndex = 14
        Me.Tab2CtcssXmit.TabStop = True
        Me.Tab2CtcssXmit.Text = "Xmit"
        Me.Tab2CtcssXmit.UseVisualStyleBackColor = True
        '
        'Tab2CtcssXmitRec
        '
        Me.Tab2CtcssXmitRec.AutoSize = True
        Me.Tab2CtcssXmitRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab2CtcssXmitRec.Location = New System.Drawing.Point(9, 26)
        Me.Tab2CtcssXmitRec.Name = "Tab2CtcssXmitRec"
        Me.Tab2CtcssXmitRec.Size = New System.Drawing.Size(124, 29)
        Me.Tab2CtcssXmitRec.TabIndex = 15
        Me.Tab2CtcssXmitRec.TabStop = True
        Me.Tab2CtcssXmitRec.Text = "Xmit/Rec"
        Me.Tab2CtcssXmitRec.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(359, 60)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 25)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "CTCSS"
        '
        'Tab2SetChannelButtone
        '
        Me.Tab2SetChannelButtone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab2SetChannelButtone.Location = New System.Drawing.Point(268, 154)
        Me.Tab2SetChannelButtone.Name = "Tab2SetChannelButtone"
        Me.Tab2SetChannelButtone.Size = New System.Drawing.Size(140, 48)
        Me.Tab2SetChannelButtone.TabIndex = 11
        Me.Tab2SetChannelButtone.Text = "Set/Update Channel"
        Me.Tab2SetChannelButtone.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(115, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(276, 37)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Channel Settings"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(294, 60)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 25)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "Tone"
        '
        'Tab2ClearChannelList
        '
        Me.Tab2ClearChannelList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab2ClearChannelList.Location = New System.Drawing.Point(138, 209)
        Me.Tab2ClearChannelList.Name = "Tab2ClearChannelList"
        Me.Tab2ClearChannelList.Size = New System.Drawing.Size(111, 43)
        Me.Tab2ClearChannelList.TabIndex = 12
        Me.Tab2ClearChannelList.Text = "Clear Channel List"
        Me.Tab2ClearChannelList.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(207, 60)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(99, 25)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "Repeater"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(146, 60)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(53, 25)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "KHz"
        '
        'Tab2ChannelTextBox
        '
        Me.Tab2ChannelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab2ChannelTextBox.Location = New System.Drawing.Point(7, 77)
        Me.Tab2ChannelTextBox.Name = "Tab2ChannelTextBox"
        Me.Tab2ChannelTextBox.ReadOnly = True
        Me.Tab2ChannelTextBox.Size = New System.Drawing.Size(46, 28)
        Me.Tab2ChannelTextBox.TabIndex = 6
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(7, 61)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(61, 25)
        Me.Label34.TabIndex = 5
        Me.Label34.Text = "CH #"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(75, 60)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(56, 25)
        Me.Label35.TabIndex = 4
        Me.Label35.Text = "MHz"
        '
        'Tab2ToneComboBox
        '
        Me.Tab2ToneComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab2ToneComboBox.FormattingEnabled = True
        Me.Tab2ToneComboBox.Items.AddRange(New Object() {"OFF", "67.0", "71.9", "74.4", "77.0", "79.7", "82.5", "85.4", "88.5", "91.5", "94.8", "97.4", "100.0", "103.5", "107.2", "110.9", "114.8", "118.8", "123.0", "127.3", "131.8", "136.5", "141.3", "146.2", "151.4", "156.7", "162.2", "167.9", "173.8", "179.9", "186.2", "192.8", "203.5", "210.7", "218.1", "225.7", "233.6", "241.8", "250.3"})
        Me.Tab2ToneComboBox.Location = New System.Drawing.Point(291, 76)
        Me.Tab2ToneComboBox.Name = "Tab2ToneComboBox"
        Me.Tab2ToneComboBox.Size = New System.Drawing.Size(58, 30)
        Me.Tab2ToneComboBox.TabIndex = 3
        '
        'Tab2RepeaterComboBox
        '
        Me.Tab2RepeaterComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab2RepeaterComboBox.FormattingEnabled = True
        Me.Tab2RepeaterComboBox.Items.AddRange(New Object() {"PLUS", "MINUS", "SIMPLEX"})
        Me.Tab2RepeaterComboBox.Location = New System.Drawing.Point(204, 76)
        Me.Tab2RepeaterComboBox.Name = "Tab2RepeaterComboBox"
        Me.Tab2RepeaterComboBox.Size = New System.Drawing.Size(83, 30)
        Me.Tab2RepeaterComboBox.TabIndex = 2
        '
        'Tab2KHzCombBox
        '
        Me.Tab2KHzCombBox.DropDownWidth = 43
        Me.Tab2KHzCombBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab2KHzCombBox.FormattingEnabled = True
        Me.Tab2KHzCombBox.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "110", "120", "130", "140", "150", "160", "170", "180", "190", "200", "210", "220", "230", "240", "250", "260", "270", "280", "290", "300", "310", "320", "330", "340", "350", "360", "370", "380", "390", "400", "410", "420", "430", "440", "450", "460", "470", "480", "490", "500", "510", "520", "530", "540", "550", "560", "570", "580", "590", "600", "610", "620", "630", "640", "650", "660", "670", "680", "690", "700", "710", "720", "730", "740", "750", "760", "770", "780", "790", "800", "810", "820", "830", "840", "850", "860", "870", "880", "890", "900", "910", "920", "930", "940", "950", "960", "970", "980", "990"})
        Me.Tab2KHzCombBox.Location = New System.Drawing.Point(134, 76)
        Me.Tab2KHzCombBox.MaxDropDownItems = 10
        Me.Tab2KHzCombBox.Name = "Tab2KHzCombBox"
        Me.Tab2KHzCombBox.Size = New System.Drawing.Size(66, 30)
        Me.Tab2KHzCombBox.TabIndex = 1
        '
        'Tab2MHzComboBox
        '
        Me.Tab2MHzComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab2MHzComboBox.FormattingEnabled = True
        Me.Tab2MHzComboBox.Items.AddRange(New Object() {"BLANK", "146", "147", "148", "149", "150"})
        Me.Tab2MHzComboBox.Location = New System.Drawing.Point(60, 76)
        Me.Tab2MHzComboBox.Name = "Tab2MHzComboBox"
        Me.Tab2MHzComboBox.Size = New System.Drawing.Size(70, 30)
        Me.Tab2MHzComboBox.TabIndex = 0
        '
        'Tab2MenuStrip
        '
        Me.Tab2MenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.Tab2MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Tab2MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tab2FileToolStripMenuItem, Me.Tab2SettingsToolStripMenuItem})
        Me.Tab2MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.Tab2MenuStrip.Name = "Tab2MenuStrip"
        Me.Tab2MenuStrip.Size = New System.Drawing.Size(451, 33)
        Me.Tab2MenuStrip.TabIndex = 17
        Me.Tab2MenuStrip.Text = "MenuStrip1"
        '
        'Tab2FileToolStripMenuItem
        '
        Me.Tab2FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tab2OpenChannelFileToolStripMenuItem, Me.Tab2SaveChannelFileToolStripMenuItem})
        Me.Tab2FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Tab2FileToolStripMenuItem.Name = "Tab2FileToolStripMenuItem"
        Me.Tab2FileToolStripMenuItem.Size = New System.Drawing.Size(57, 29)
        Me.Tab2FileToolStripMenuItem.Text = "File"
        '
        'Tab2OpenChannelFileToolStripMenuItem
        '
        Me.Tab2OpenChannelFileToolStripMenuItem.Name = "Tab2OpenChannelFileToolStripMenuItem"
        Me.Tab2OpenChannelFileToolStripMenuItem.Size = New System.Drawing.Size(268, 34)
        Me.Tab2OpenChannelFileToolStripMenuItem.Text = "Open Channel File"
        '
        'Tab2SaveChannelFileToolStripMenuItem
        '
        Me.Tab2SaveChannelFileToolStripMenuItem.Name = "Tab2SaveChannelFileToolStripMenuItem"
        Me.Tab2SaveChannelFileToolStripMenuItem.Size = New System.Drawing.Size(268, 34)
        Me.Tab2SaveChannelFileToolStripMenuItem.Text = "Save Channel File"
        '
        'Tab2SettingsToolStripMenuItem
        '
        Me.Tab2SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tab2BackToMainMenuToolStripMenuItem, Me.Tab2KHzStepSizeToolStripMenuItem})
        Me.Tab2SettingsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Tab2SettingsToolStripMenuItem.Name = "Tab2SettingsToolStripMenuItem"
        Me.Tab2SettingsToolStripMenuItem.Size = New System.Drawing.Size(95, 29)
        Me.Tab2SettingsToolStripMenuItem.Text = "Options"
        '
        'Tab2BackToMainMenuToolStripMenuItem
        '
        Me.Tab2BackToMainMenuToolStripMenuItem.Name = "Tab2BackToMainMenuToolStripMenuItem"
        Me.Tab2BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(280, 34)
        Me.Tab2BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu"
        '
        'Tab2KHzStepSizeToolStripMenuItem
        '
        Me.Tab2KHzStepSizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tab2KHzToolStripComboBox})
        Me.Tab2KHzStepSizeToolStripMenuItem.Name = "Tab2KHzStepSizeToolStripMenuItem"
        Me.Tab2KHzStepSizeToolStripMenuItem.Size = New System.Drawing.Size(280, 34)
        Me.Tab2KHzStepSizeToolStripMenuItem.Text = "kHz Step Size"
        '
        'Tab2KHzToolStripComboBox
        '
        Me.Tab2KHzToolStripComboBox.Items.AddRange(New Object() {"10", "12.5", "5", "25"})
        Me.Tab2KHzToolStripComboBox.Name = "Tab2KHzToolStripComboBox"
        Me.Tab2KHzToolStripComboBox.Size = New System.Drawing.Size(121, 33)
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Silver
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel12.Controls.Add(Me.tab2ChannelFileName)
        Me.Panel12.Controls.Add(Me.Label10)
        Me.Panel12.Controls.Add(Me.Tab2StopProgramButton)
        Me.Panel12.Controls.Add(Me.Tab2UsbRcvdLabel)
        Me.Panel12.Controls.Add(Me.Label73)
        Me.Panel12.Controls.Add(Me.Tab2UsbCmdLabel)
        Me.Panel12.Controls.Add(Me.Label68)
        Me.Panel12.Controls.Add(Me.Tab2ComPortTextBox)
        Me.Panel12.Controls.Add(Me.Label38)
        Me.Panel12.Controls.Add(Me.Tab2ProgressBar1)
        Me.Panel12.Controls.Add(Me.Tab2ProgramButton)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(3, 286)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(455, 206)
        Me.Panel12.TabIndex = 1
        '
        'tab2ChannelFileName
        '
        Me.tab2ChannelFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tab2ChannelFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab2ChannelFileName.Location = New System.Drawing.Point(147, 173)
        Me.tab2ChannelFileName.Name = "tab2ChannelFileName"
        Me.tab2ChannelFileName.Size = New System.Drawing.Size(300, 25)
        Me.tab2ChannelFileName.TabIndex = 28
        Me.tab2ChannelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tab2ChannelFileName.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 177)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(187, 25)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Channel Filename"
        Me.Label10.Visible = False
        '
        'Tab2StopProgramButton
        '
        Me.Tab2StopProgramButton.Location = New System.Drawing.Point(45, 50)
        Me.Tab2StopProgramButton.Name = "Tab2StopProgramButton"
        Me.Tab2StopProgramButton.Size = New System.Drawing.Size(117, 44)
        Me.Tab2StopProgramButton.TabIndex = 26
        Me.Tab2StopProgramButton.Text = "Stop Programming"
        Me.Tab2StopProgramButton.UseVisualStyleBackColor = True
        '
        'Tab2UsbRcvdLabel
        '
        Me.Tab2UsbRcvdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tab2UsbRcvdLabel.Location = New System.Drawing.Point(352, 134)
        Me.Tab2UsbRcvdLabel.Name = "Tab2UsbRcvdLabel"
        Me.Tab2UsbRcvdLabel.Size = New System.Drawing.Size(96, 25)
        Me.Tab2UsbRcvdLabel.TabIndex = 25
        Me.Tab2UsbRcvdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(277, 138)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(94, 25)
        Me.Label73.TabIndex = 24
        Me.Label73.Text = "received"
        '
        'Tab2UsbCmdLabel
        '
        Me.Tab2UsbCmdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tab2UsbCmdLabel.Location = New System.Drawing.Point(168, 134)
        Me.Tab2UsbCmdLabel.Name = "Tab2UsbCmdLabel"
        Me.Tab2UsbCmdLabel.Size = New System.Drawing.Size(96, 25)
        Me.Tab2UsbCmdLabel.TabIndex = 23
        Me.Tab2UsbCmdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label68
        '
        Me.Label68.Location = New System.Drawing.Point(10, 134)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(231, 25)
        Me.Label68.TabIndex = 21
        Me.Label68.Text = "Serial command sent"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tab2ComPortTextBox
        '
        Me.Tab2ComPortTextBox.Enabled = False
        Me.Tab2ComPortTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab2ComPortTextBox.Location = New System.Drawing.Point(347, 13)
        Me.Tab2ComPortTextBox.Multiline = True
        Me.Tab2ComPortTextBox.Name = "Tab2ComPortTextBox"
        Me.Tab2ComPortTextBox.Size = New System.Drawing.Size(87, 80)
        Me.Tab2ComPortTextBox.TabIndex = 20
        Me.Tab2ComPortTextBox.Text = "test1"
        Me.Tab2ComPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Tab2ComPortTextBox.Visible = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(80, 10)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(320, 37)
        Me.Label38.TabIndex = 11
        Me.Label38.Text = "Radio Programming"
        '
        'Tab2ProgressBar1
        '
        Me.Tab2ProgressBar1.Location = New System.Drawing.Point(53, 108)
        Me.Tab2ProgressBar1.Name = "Tab2ProgressBar1"
        Me.Tab2ProgressBar1.Size = New System.Drawing.Size(335, 16)
        Me.Tab2ProgressBar1.TabIndex = 1
        '
        'Tab2ProgramButton
        '
        Me.Tab2ProgramButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab2ProgramButton.Location = New System.Drawing.Point(215, 50)
        Me.Tab2ProgramButton.Name = "Tab2ProgramButton"
        Me.Tab2ProgramButton.Size = New System.Drawing.Size(98, 44)
        Me.Tab2ProgramButton.TabIndex = 0
        Me.Tab2ProgramButton.Text = "Program Radio Channels"
        Me.Tab2ProgramButton.UseVisualStyleBackColor = True
        '
        'Tab2StatusStrip
        '
        Me.Tab2StatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Tab2StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tab2ToolStripStepSize, Me.Tab2ToolStripStatusLabel})
        Me.Tab2StatusStrip.Location = New System.Drawing.Point(0, 495)
        Me.Tab2StatusStrip.Name = "Tab2StatusStrip"
        Me.Tab2StatusStrip.Size = New System.Drawing.Size(461, 23)
        Me.Tab2StatusStrip.TabIndex = 2
        Me.Tab2StatusStrip.Text = "StatusStrip1"
        '
        'Tab2ToolStripStepSize
        '
        Me.Tab2ToolStripStepSize.Name = "Tab2ToolStripStepSize"
        Me.Tab2ToolStripStepSize.Size = New System.Drawing.Size(180, 16)
        Me.Tab2ToolStripStepSize.Text = "ToolStripStatusLabel1"
        '
        'Tab2ToolStripStatusLabel
        '
        Me.Tab2ToolStripStatusLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Tab2ToolStripStatusLabel.Name = "Tab2ToolStripStatusLabel"
        Me.Tab2ToolStripStatusLabel.Size = New System.Drawing.Size(196, 16)
        Me.Tab2ToolStripStatusLabel.Text = "ToolStripStatusLabel2"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Silver
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel15.Controls.Add(Me.Tab2ChannelListView)
        Me.Panel15.Controls.Add(Me.Label43)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(470, 3)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(527, 518)
        Me.Panel15.TabIndex = 1
        '
        'Tab2ChannelListView
        '
        Me.Tab2ChannelListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader7, Me.ColumnHeader6, Me.ColumnHeader15, Me.ColumnHeader14, Me.ColumnHeader27})
        Me.Tab2ChannelListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab2ChannelListView.FullRowSelect = True
        Me.Tab2ChannelListView.GridLines = True
        Me.Tab2ChannelListView.HideSelection = False
        Me.Tab2ChannelListView.Location = New System.Drawing.Point(0, 34)
        Me.Tab2ChannelListView.MultiSelect = False
        Me.Tab2ChannelListView.Name = "Tab2ChannelListView"
        Me.Tab2ChannelListView.Size = New System.Drawing.Size(523, 463)
        Me.Tab2ChannelListView.TabIndex = 12
        Me.Tab2ChannelListView.UseCompatibleStateImageBehavior = False
        Me.Tab2ChannelListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "CH#"
        Me.ColumnHeader8.Width = 42
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Frequency"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 91
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Repeater"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 81
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Tone"
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader15.Width = 50
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = " CTCSS"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader14.Width = 80
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "Notes"
        Me.ColumnHeader27.Width = 375
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(176, 10)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(207, 37)
        Me.Label43.TabIndex = 11
        Me.Label43.Text = "Channel List"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1006, 530)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.8!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.2!))
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel10, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Panel23, 1, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(1000, 524)
        Me.TableLayoutPanel8.TabIndex = 3
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.Panel20, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.Panel22, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.Tab3StatusStrip, 0, 2)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 3
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.80473!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.19527!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(461, 518)
        Me.TableLayoutPanel10.TabIndex = 0
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.Silver
        Me.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel20.Controls.Add(Me.Tab3DeleteRowButton)
        Me.Panel20.Controls.Add(Me.Tab3InsertRowButton)
        Me.Panel20.Controls.Add(Me.Label71)
        Me.Panel20.Controls.Add(Me.Tab3ChannelNotes)
        Me.Panel20.Controls.Add(Me.Panel21)
        Me.Panel20.Controls.Add(Me.Label55)
        Me.Panel20.Controls.Add(Me.Tab3SetChannelButtone)
        Me.Panel20.Controls.Add(Me.Label56)
        Me.Panel20.Controls.Add(Me.Label57)
        Me.Panel20.Controls.Add(Me.Tab3ClearChannelList)
        Me.Panel20.Controls.Add(Me.Label58)
        Me.Panel20.Controls.Add(Me.Label59)
        Me.Panel20.Controls.Add(Me.Tab3ChannelTextBox)
        Me.Panel20.Controls.Add(Me.Label60)
        Me.Panel20.Controls.Add(Me.Label61)
        Me.Panel20.Controls.Add(Me.Tab3ToneComboBox)
        Me.Panel20.Controls.Add(Me.Tab3RepeaterComboBox)
        Me.Panel20.Controls.Add(Me.Tab3KHzCombBox)
        Me.Panel20.Controls.Add(Me.Tab3MHzComboBox)
        Me.Panel20.Controls.Add(Me.Tab3MenuStrip)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel20.Location = New System.Drawing.Point(3, 3)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(455, 277)
        Me.Panel20.TabIndex = 0
        '
        'Tab3DeleteRowButton
        '
        Me.Tab3DeleteRowButton.Location = New System.Drawing.Point(268, 243)
        Me.Tab3DeleteRowButton.Name = "Tab3DeleteRowButton"
        Me.Tab3DeleteRowButton.Size = New System.Drawing.Size(139, 23)
        Me.Tab3DeleteRowButton.TabIndex = 22
        Me.Tab3DeleteRowButton.Text = "Delete Row"
        Me.Tab3DeleteRowButton.UseVisualStyleBackColor = True
        '
        'Tab3InsertRowButton
        '
        Me.Tab3InsertRowButton.Location = New System.Drawing.Point(268, 214)
        Me.Tab3InsertRowButton.Name = "Tab3InsertRowButton"
        Me.Tab3InsertRowButton.Size = New System.Drawing.Size(140, 23)
        Me.Tab3InsertRowButton.TabIndex = 21
        Me.Tab3InsertRowButton.Text = "Insert Row"
        Me.Tab3InsertRowButton.UseVisualStyleBackColor = True
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(7, 103)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(155, 25)
        Me.Label71.TabIndex = 20
        Me.Label71.Text = "Channel Notes"
        '
        'Tab3ChannelNotes
        '
        Me.Tab3ChannelNotes.Location = New System.Drawing.Point(7, 122)
        Me.Tab3ChannelNotes.MaxLength = 10
        Me.Tab3ChannelNotes.Name = "Tab3ChannelNotes"
        Me.Tab3ChannelNotes.Size = New System.Drawing.Size(335, 30)
        Me.Tab3ChannelNotes.TabIndex = 19
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.Tab3CtcssOff)
        Me.Panel21.Controls.Add(Me.Tab3CtcssXmit)
        Me.Panel21.Controls.Add(Me.Tab3CtcssXmitRec)
        Me.Panel21.Location = New System.Drawing.Point(348, 76)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(100, 72)
        Me.Panel21.TabIndex = 16
        '
        'Tab3CtcssOff
        '
        Me.Tab3CtcssOff.AutoSize = True
        Me.Tab3CtcssOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab3CtcssOff.Location = New System.Drawing.Point(9, 46)
        Me.Tab3CtcssOff.Name = "Tab3CtcssOff"
        Me.Tab3CtcssOff.Size = New System.Drawing.Size(66, 29)
        Me.Tab3CtcssOff.TabIndex = 17
        Me.Tab3CtcssOff.TabStop = True
        Me.Tab3CtcssOff.Text = "Off"
        Me.Tab3CtcssOff.UseVisualStyleBackColor = True
        '
        'Tab3CtcssXmit
        '
        Me.Tab3CtcssXmit.AutoSize = True
        Me.Tab3CtcssXmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab3CtcssXmit.Location = New System.Drawing.Point(9, 5)
        Me.Tab3CtcssXmit.Name = "Tab3CtcssXmit"
        Me.Tab3CtcssXmit.Size = New System.Drawing.Size(80, 29)
        Me.Tab3CtcssXmit.TabIndex = 14
        Me.Tab3CtcssXmit.TabStop = True
        Me.Tab3CtcssXmit.Text = "Xmit"
        Me.Tab3CtcssXmit.UseVisualStyleBackColor = True
        '
        'Tab3CtcssXmitRec
        '
        Me.Tab3CtcssXmitRec.AutoSize = True
        Me.Tab3CtcssXmitRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab3CtcssXmitRec.Location = New System.Drawing.Point(9, 26)
        Me.Tab3CtcssXmitRec.Name = "Tab3CtcssXmitRec"
        Me.Tab3CtcssXmitRec.Size = New System.Drawing.Size(124, 29)
        Me.Tab3CtcssXmitRec.TabIndex = 15
        Me.Tab3CtcssXmitRec.TabStop = True
        Me.Tab3CtcssXmitRec.Text = "Xmit/Rec"
        Me.Tab3CtcssXmitRec.UseVisualStyleBackColor = True
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(359, 60)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(88, 25)
        Me.Label55.TabIndex = 13
        Me.Label55.Text = "CTCSS"
        '
        'Tab3SetChannelButtone
        '
        Me.Tab3SetChannelButtone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab3SetChannelButtone.Location = New System.Drawing.Point(268, 154)
        Me.Tab3SetChannelButtone.Name = "Tab3SetChannelButtone"
        Me.Tab3SetChannelButtone.Size = New System.Drawing.Size(140, 48)
        Me.Tab3SetChannelButtone.TabIndex = 11
        Me.Tab3SetChannelButtone.Text = "Set/Update Channel"
        Me.Tab3SetChannelButtone.UseVisualStyleBackColor = True
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(115, 24)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(276, 37)
        Me.Label56.TabIndex = 10
        Me.Label56.Text = "Channel Settings"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(294, 60)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(62, 25)
        Me.Label57.TabIndex = 9
        Me.Label57.Text = "Tone"
        '
        'Tab3ClearChannelList
        '
        Me.Tab3ClearChannelList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab3ClearChannelList.Location = New System.Drawing.Point(138, 209)
        Me.Tab3ClearChannelList.Name = "Tab3ClearChannelList"
        Me.Tab3ClearChannelList.Size = New System.Drawing.Size(111, 43)
        Me.Tab3ClearChannelList.TabIndex = 12
        Me.Tab3ClearChannelList.Text = "Clear Channel List"
        Me.Tab3ClearChannelList.UseVisualStyleBackColor = True
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(207, 60)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(99, 25)
        Me.Label58.TabIndex = 8
        Me.Label58.Text = "Repeater"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(146, 60)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(53, 25)
        Me.Label59.TabIndex = 7
        Me.Label59.Text = "KHz"
        '
        'Tab3ChannelTextBox
        '
        Me.Tab3ChannelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab3ChannelTextBox.Location = New System.Drawing.Point(7, 77)
        Me.Tab3ChannelTextBox.Name = "Tab3ChannelTextBox"
        Me.Tab3ChannelTextBox.ReadOnly = True
        Me.Tab3ChannelTextBox.Size = New System.Drawing.Size(46, 28)
        Me.Tab3ChannelTextBox.TabIndex = 6
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(7, 61)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(61, 25)
        Me.Label60.TabIndex = 5
        Me.Label60.Text = "CH #"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(75, 60)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(56, 25)
        Me.Label61.TabIndex = 4
        Me.Label61.Text = "MHz"
        '
        'Tab3ToneComboBox
        '
        Me.Tab3ToneComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab3ToneComboBox.FormattingEnabled = True
        Me.Tab3ToneComboBox.Items.AddRange(New Object() {"OFF", "67.0", "71.9", "74.4", "77.0", "79.7", "82.5", "85.4", "88.5", "91.5", "94.8", "97.4", "100.0", "103.5", "107.2", "110.9", "114.8", "118.8", "123.0", "127.3", "131.8", "136.5", "141.3", "146.2", "151.4", "156.7", "162.2", "167.9", "173.8", "179.9", "186.2", "192.8", "203.5", "210.7", "218.1", "225.7", "233.6", "241.8", "250.3"})
        Me.Tab3ToneComboBox.Location = New System.Drawing.Point(291, 76)
        Me.Tab3ToneComboBox.Name = "Tab3ToneComboBox"
        Me.Tab3ToneComboBox.Size = New System.Drawing.Size(58, 30)
        Me.Tab3ToneComboBox.TabIndex = 3
        '
        'Tab3RepeaterComboBox
        '
        Me.Tab3RepeaterComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab3RepeaterComboBox.FormattingEnabled = True
        Me.Tab3RepeaterComboBox.Items.AddRange(New Object() {"PLUS", "MINUS", "SIMPLEX"})
        Me.Tab3RepeaterComboBox.Location = New System.Drawing.Point(204, 76)
        Me.Tab3RepeaterComboBox.Name = "Tab3RepeaterComboBox"
        Me.Tab3RepeaterComboBox.Size = New System.Drawing.Size(83, 30)
        Me.Tab3RepeaterComboBox.TabIndex = 2
        '
        'Tab3KHzCombBox
        '
        Me.Tab3KHzCombBox.DropDownWidth = 43
        Me.Tab3KHzCombBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab3KHzCombBox.FormattingEnabled = True
        Me.Tab3KHzCombBox.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "110", "120", "130", "140", "150", "160", "170", "180", "190", "200", "210", "220", "230", "240", "250", "260", "270", "280", "290", "300", "310", "320", "330", "340", "350", "360", "370", "380", "390", "400", "410", "420", "430", "440", "450", "460", "470", "480", "490", "500", "510", "520", "530", "540", "550", "560", "570", "580", "590", "600", "610", "620", "630", "640", "650", "660", "670", "680", "690", "700", "710", "720", "730", "740", "750", "760", "770", "780", "790", "800", "810", "820", "830", "840", "850", "860", "870", "880", "890", "900", "910", "920", "930", "940", "950", "960", "970", "980", "990"})
        Me.Tab3KHzCombBox.Location = New System.Drawing.Point(134, 76)
        Me.Tab3KHzCombBox.MaxDropDownItems = 10
        Me.Tab3KHzCombBox.Name = "Tab3KHzCombBox"
        Me.Tab3KHzCombBox.Size = New System.Drawing.Size(66, 30)
        Me.Tab3KHzCombBox.TabIndex = 1
        '
        'Tab3MHzComboBox
        '
        Me.Tab3MHzComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab3MHzComboBox.FormattingEnabled = True
        Me.Tab3MHzComboBox.Items.AddRange(New Object() {"BLANK", "146", "147", "148", "149", "150"})
        Me.Tab3MHzComboBox.Location = New System.Drawing.Point(60, 76)
        Me.Tab3MHzComboBox.Name = "Tab3MHzComboBox"
        Me.Tab3MHzComboBox.Size = New System.Drawing.Size(70, 30)
        Me.Tab3MHzComboBox.TabIndex = 0
        '
        'Tab3MenuStrip
        '
        Me.Tab3MenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.Tab3MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Tab3MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tab3FileToolStripMenuItem, Me.Tab3SettingsToolStripMenuItem})
        Me.Tab3MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.Tab3MenuStrip.Name = "Tab3MenuStrip"
        Me.Tab3MenuStrip.Size = New System.Drawing.Size(451, 33)
        Me.Tab3MenuStrip.TabIndex = 17
        Me.Tab3MenuStrip.Text = "MenuStrip1"
        '
        'Tab3FileToolStripMenuItem
        '
        Me.Tab3FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tab3OpenChannelFileToolStripMenuItem, Me.Tab3SaveChannelFileToolStripMenuItem})
        Me.Tab3FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Tab3FileToolStripMenuItem.Name = "Tab3FileToolStripMenuItem"
        Me.Tab3FileToolStripMenuItem.Size = New System.Drawing.Size(57, 29)
        Me.Tab3FileToolStripMenuItem.Text = "File"
        '
        'Tab3OpenChannelFileToolStripMenuItem
        '
        Me.Tab3OpenChannelFileToolStripMenuItem.Name = "Tab3OpenChannelFileToolStripMenuItem"
        Me.Tab3OpenChannelFileToolStripMenuItem.Size = New System.Drawing.Size(268, 34)
        Me.Tab3OpenChannelFileToolStripMenuItem.Text = "Open Channel File"
        '
        'Tab3SaveChannelFileToolStripMenuItem
        '
        Me.Tab3SaveChannelFileToolStripMenuItem.Name = "Tab3SaveChannelFileToolStripMenuItem"
        Me.Tab3SaveChannelFileToolStripMenuItem.Size = New System.Drawing.Size(268, 34)
        Me.Tab3SaveChannelFileToolStripMenuItem.Text = "Save Channel File"
        '
        'Tab3SettingsToolStripMenuItem
        '
        Me.Tab3SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tab3BackToMainMenuToolStripMenuItem, Me.Tab3KHzStepSizeToolStripMenuItem})
        Me.Tab3SettingsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Tab3SettingsToolStripMenuItem.Name = "Tab3SettingsToolStripMenuItem"
        Me.Tab3SettingsToolStripMenuItem.Size = New System.Drawing.Size(95, 29)
        Me.Tab3SettingsToolStripMenuItem.Text = "Options"
        '
        'Tab3BackToMainMenuToolStripMenuItem
        '
        Me.Tab3BackToMainMenuToolStripMenuItem.Name = "Tab3BackToMainMenuToolStripMenuItem"
        Me.Tab3BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(280, 34)
        Me.Tab3BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu"
        '
        'Tab3KHzStepSizeToolStripMenuItem
        '
        Me.Tab3KHzStepSizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tab3KHzToolStripComboBox})
        Me.Tab3KHzStepSizeToolStripMenuItem.Name = "Tab3KHzStepSizeToolStripMenuItem"
        Me.Tab3KHzStepSizeToolStripMenuItem.Size = New System.Drawing.Size(280, 34)
        Me.Tab3KHzStepSizeToolStripMenuItem.Text = "kHz Step Size"
        '
        'Tab3KHzToolStripComboBox
        '
        Me.Tab3KHzToolStripComboBox.Items.AddRange(New Object() {"10", "12.5", "5", "25"})
        Me.Tab3KHzToolStripComboBox.Name = "Tab3KHzToolStripComboBox"
        Me.Tab3KHzToolStripComboBox.Size = New System.Drawing.Size(121, 33)
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.Silver
        Me.Panel22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel22.Controls.Add(Me.tab3ChannelFileName)
        Me.Panel22.Controls.Add(Me.Label36)
        Me.Panel22.Controls.Add(Me.Tab3StopProgramButton)
        Me.Panel22.Controls.Add(Me.Tab3UsbRcvdLabel)
        Me.Panel22.Controls.Add(Me.Label74)
        Me.Panel22.Controls.Add(Me.Tab3UsbCmdLabel)
        Me.Panel22.Controls.Add(Me.Label69)
        Me.Panel22.Controls.Add(Me.Tab3ComPortTextBox)
        Me.Panel22.Controls.Add(Me.Label64)
        Me.Panel22.Controls.Add(Me.Tab3ProgressBar1)
        Me.Panel22.Controls.Add(Me.Tab3ProgramButton)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel22.Location = New System.Drawing.Point(3, 286)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(455, 209)
        Me.Panel22.TabIndex = 1
        '
        'tab3ChannelFileName
        '
        Me.tab3ChannelFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tab3ChannelFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab3ChannelFileName.Location = New System.Drawing.Point(149, 173)
        Me.tab3ChannelFileName.Name = "tab3ChannelFileName"
        Me.tab3ChannelFileName.Size = New System.Drawing.Size(298, 25)
        Me.tab3ChannelFileName.TabIndex = 27
        Me.tab3ChannelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tab3ChannelFileName.Visible = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(11, 177)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(187, 25)
        Me.Label36.TabIndex = 26
        Me.Label36.Text = "Channel Filename"
        Me.Label36.Visible = False
        '
        'Tab3StopProgramButton
        '
        Me.Tab3StopProgramButton.Location = New System.Drawing.Point(45, 50)
        Me.Tab3StopProgramButton.Name = "Tab3StopProgramButton"
        Me.Tab3StopProgramButton.Size = New System.Drawing.Size(117, 44)
        Me.Tab3StopProgramButton.TabIndex = 25
        Me.Tab3StopProgramButton.Text = "Stop Programming"
        Me.Tab3StopProgramButton.UseVisualStyleBackColor = True
        '
        'Tab3UsbRcvdLabel
        '
        Me.Tab3UsbRcvdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tab3UsbRcvdLabel.Location = New System.Drawing.Point(352, 134)
        Me.Tab3UsbRcvdLabel.Name = "Tab3UsbRcvdLabel"
        Me.Tab3UsbRcvdLabel.Size = New System.Drawing.Size(96, 25)
        Me.Tab3UsbRcvdLabel.TabIndex = 24
        Me.Tab3UsbRcvdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(277, 138)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(94, 25)
        Me.Label74.TabIndex = 23
        Me.Label74.Text = "received"
        '
        'Tab3UsbCmdLabel
        '
        Me.Tab3UsbCmdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tab3UsbCmdLabel.Location = New System.Drawing.Point(168, 134)
        Me.Tab3UsbCmdLabel.Name = "Tab3UsbCmdLabel"
        Me.Tab3UsbCmdLabel.Size = New System.Drawing.Size(96, 25)
        Me.Tab3UsbCmdLabel.TabIndex = 22
        Me.Tab3UsbCmdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label69
        '
        Me.Label69.Location = New System.Drawing.Point(10, 134)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(231, 25)
        Me.Label69.TabIndex = 21
        Me.Label69.Text = "Serial command sent"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tab3ComPortTextBox
        '
        Me.Tab3ComPortTextBox.Enabled = False
        Me.Tab3ComPortTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab3ComPortTextBox.Location = New System.Drawing.Point(347, 13)
        Me.Tab3ComPortTextBox.Multiline = True
        Me.Tab3ComPortTextBox.Name = "Tab3ComPortTextBox"
        Me.Tab3ComPortTextBox.Size = New System.Drawing.Size(87, 80)
        Me.Tab3ComPortTextBox.TabIndex = 20
        Me.Tab3ComPortTextBox.Text = "test1"
        Me.Tab3ComPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Tab3ComPortTextBox.Visible = False
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(80, 10)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(320, 37)
        Me.Label64.TabIndex = 11
        Me.Label64.Text = "Radio Programming"
        '
        'Tab3ProgressBar1
        '
        Me.Tab3ProgressBar1.Location = New System.Drawing.Point(53, 108)
        Me.Tab3ProgressBar1.Name = "Tab3ProgressBar1"
        Me.Tab3ProgressBar1.Size = New System.Drawing.Size(335, 16)
        Me.Tab3ProgressBar1.TabIndex = 1
        '
        'Tab3ProgramButton
        '
        Me.Tab3ProgramButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab3ProgramButton.Location = New System.Drawing.Point(215, 50)
        Me.Tab3ProgramButton.Name = "Tab3ProgramButton"
        Me.Tab3ProgramButton.Size = New System.Drawing.Size(98, 44)
        Me.Tab3ProgramButton.TabIndex = 0
        Me.Tab3ProgramButton.Text = "Program Radio Channels"
        Me.Tab3ProgramButton.UseVisualStyleBackColor = True
        '
        'Tab3StatusStrip
        '
        Me.Tab3StatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Tab3StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tab3ToolStripStepSize, Me.Tab3ToolStripStatusLabel})
        Me.Tab3StatusStrip.Location = New System.Drawing.Point(0, 498)
        Me.Tab3StatusStrip.Name = "Tab3StatusStrip"
        Me.Tab3StatusStrip.Size = New System.Drawing.Size(461, 20)
        Me.Tab3StatusStrip.TabIndex = 2
        Me.Tab3StatusStrip.Text = "StatusStrip1"
        '
        'Tab3ToolStripStepSize
        '
        Me.Tab3ToolStripStepSize.Name = "Tab3ToolStripStepSize"
        Me.Tab3ToolStripStepSize.Size = New System.Drawing.Size(180, 13)
        Me.Tab3ToolStripStepSize.Text = "ToolStripStatusLabel1"
        '
        'Tab3ToolStripStatusLabel
        '
        Me.Tab3ToolStripStatusLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Tab3ToolStripStatusLabel.Name = "Tab3ToolStripStatusLabel"
        Me.Tab3ToolStripStatusLabel.Size = New System.Drawing.Size(196, 13)
        Me.Tab3ToolStripStatusLabel.Text = "ToolStripStatusLabel2"
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.Silver
        Me.Panel23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel23.Controls.Add(Me.Tab3ChannelListView)
        Me.Panel23.Controls.Add(Me.Label65)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel23.Location = New System.Drawing.Point(470, 3)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(527, 518)
        Me.Panel23.TabIndex = 1
        '
        'Tab3ChannelListView
        '
        Me.Tab3ChannelListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader28})
        Me.Tab3ChannelListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab3ChannelListView.FullRowSelect = True
        Me.Tab3ChannelListView.GridLines = True
        Me.Tab3ChannelListView.HideSelection = False
        Me.Tab3ChannelListView.Location = New System.Drawing.Point(0, 34)
        Me.Tab3ChannelListView.MultiSelect = False
        Me.Tab3ChannelListView.Name = "Tab3ChannelListView"
        Me.Tab3ChannelListView.Size = New System.Drawing.Size(523, 463)
        Me.Tab3ChannelListView.TabIndex = 12
        Me.Tab3ChannelListView.UseCompatibleStateImageBehavior = False
        Me.Tab3ChannelListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "CH#"
        Me.ColumnHeader21.Width = 42
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Frequency"
        Me.ColumnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader22.Width = 91
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Repeater"
        Me.ColumnHeader23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader23.Width = 81
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Tone"
        Me.ColumnHeader24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader24.Width = 50
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = " CTCSS"
        Me.ColumnHeader25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader25.Width = 80
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "Notes"
        Me.ColumnHeader28.Width = 375
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(176, 10)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(207, 37)
        Me.Label65.TabIndex = 11
        Me.Label65.Text = "Channel List"
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.05068!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.94932!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel7, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(838, 476)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel6, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.25077!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.74923!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(421, 470)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.ComboBox1)
        Me.Panel4.Controls.Add(Me.ComboBox2)
        Me.Panel4.Controls.Add(Me.ComboBox3)
        Me.Panel4.Controls.Add(Me.ComboBox4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(415, 162)
        Me.Panel4.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.RadioButton1)
        Me.Panel5.Controls.Add(Me.RadioButton2)
        Me.Panel5.Location = New System.Drawing.Point(321, 76)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(90, 44)
        Me.Panel5.TabIndex = 16
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(4, 5)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(66, 24)
        Me.RadioButton1.TabIndex = 14
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Xmit"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(4, 23)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(99, 24)
        Me.RadioButton2.TabIndex = 15
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Xmit/Rec"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(324, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 20)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "CTCSS"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(268, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Set/Update Channel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(73, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(276, 37)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Channel Settings"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(273, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 20)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Tone"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(187, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 20)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Repeater"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(129, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 20)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "KHz"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 79)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(50, 26)
        Me.TextBox1.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 62)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 20)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Channel"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(75, 62)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 20)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "MHz"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"OFF", "67.0", "71.9", "74.4", "77.0", "79.7", "82.5", "85.4", "88.5", "91.5", "94.8", "97.4", "100.0", "103.5", "107.2", "110.9", "114.8", "118.8", "123.0", "127.3", "131.8", "136.5", "141.3", "146.2", "151.4", "156.7", "162.2", "167.9", "173.8", "179.9", "186.2", "192.8", "203.5", "210.7", "218.1", "225.7", "233.6", "241.8", "250.3"})
        Me.ComboBox1.Location = New System.Drawing.Point(265, 76)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(50, 28)
        Me.ComboBox1.TabIndex = 3
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"PLUS", "MINUS", "SIMPLEX"})
        Me.ComboBox2.Location = New System.Drawing.Point(184, 76)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(75, 28)
        Me.ComboBox2.TabIndex = 2
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownWidth = 43
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "110", "120", "130", "140", "150", "160", "170", "180", "190", "200", "210", "220", "230", "240", "250", "260", "270", "280", "290", "300", "310", "320", "330", "340", "350", "360", "370", "380", "390", "400", "410", "420", "430", "440", "450", "460", "470", "480", "490", "500", "510", "520", "530", "540", "550", "560", "570", "580", "590", "600", "610", "620", "630", "640", "650", "660", "670", "680", "690", "700", "710", "720", "730", "740", "750", "760", "770", "780", "790", "800", "810", "820", "830", "840", "850", "860", "870", "880", "890", "900", "910", "920", "930", "940", "950", "960", "970", "980", "990"})
        Me.ComboBox3.Location = New System.Drawing.Point(128, 77)
        Me.ComboBox3.MaxDropDownItems = 10
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(50, 28)
        Me.ComboBox3.TabIndex = 1
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"BLANK", "146", "147", "148", "149", "150"})
        Me.ComboBox4.Location = New System.Drawing.Point(65, 78)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(57, 28)
        Me.ComboBox4.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Controls.Add(Me.NumericUpDown1)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.NumericUpDown2)
        Me.Panel6.Controls.Add(Me.Button2)
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Controls.Add(Me.ProgressBar1)
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 171)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(415, 141)
        Me.Panel6.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 42)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(101, 20)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Button in mS"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(9, 57)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(55, 26)
        Me.NumericUpDown1.TabIndex = 17
        Me.NumericUpDown1.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 4)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 20)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Tone in mS"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown2.Location = New System.Drawing.Point(9, 19)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(55, 26)
        Me.NumericUpDown2.TabIndex = 15
        Me.NumericUpDown2.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(78, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 37)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Clear Channel List"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(73, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(358, 37)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Channel Programming"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(31, 108)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(335, 16)
        Me.ProgressBar1.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(220, 56)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 37)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Program Radio Channels"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Silver
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.ListView1)
        Me.Panel7.Controls.Add(Me.Label21)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(430, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(405, 470)
        Me.Panel7.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 49)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(389, 377)
        Me.ListView1.TabIndex = 12
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Channel"
        Me.ColumnHeader1.Width = 64
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Frequency"
        Me.ColumnHeader2.Width = 81
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Repeater Mode"
        Me.ColumnHeader3.Width = 105
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tone"
        Me.ColumnHeader4.Width = 76
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = " CTSS"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(109, 10)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(207, 37)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "Channel List"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Silver
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Controls.Add(Me.Label26)
        Me.Panel9.Controls.Add(Me.Button5)
        Me.Panel9.Controls.Add(Me.Label27)
        Me.Panel9.Controls.Add(Me.Label28)
        Me.Panel9.Controls.Add(Me.Label29)
        Me.Panel9.Controls.Add(Me.Label30)
        Me.Panel9.Controls.Add(Me.TextBox2)
        Me.Panel9.Controls.Add(Me.Label31)
        Me.Panel9.Controls.Add(Me.Label32)
        Me.Panel9.Controls.Add(Me.ComboBox5)
        Me.Panel9.Controls.Add(Me.ComboBox6)
        Me.Panel9.Controls.Add(Me.ComboBox7)
        Me.Panel9.Controls.Add(Me.ComboBox8)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(3, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(415, 162)
        Me.Panel9.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.RadioButton5)
        Me.Panel10.Controls.Add(Me.RadioButton6)
        Me.Panel10.Location = New System.Drawing.Point(321, 76)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(90, 44)
        Me.Panel10.TabIndex = 16
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(4, 5)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(66, 24)
        Me.RadioButton5.TabIndex = 14
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Xmit"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(4, 23)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(99, 24)
        Me.RadioButton6.TabIndex = 15
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Xmit/Rec"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(324, 60)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 20)
        Me.Label26.TabIndex = 13
        Me.Label26.Text = "CTCSS"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(268, 136)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(140, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Set/Update Channel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(73, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(276, 37)
        Me.Label27.TabIndex = 10
        Me.Label27.Text = "Channel Settings"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(273, 60)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 20)
        Me.Label28.TabIndex = 9
        Me.Label28.Text = "Tone"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(187, 60)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(76, 20)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "Repeater"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(129, 60)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(39, 20)
        Me.Label30.TabIndex = 7
        Me.Label30.Text = "KHz"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(9, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(50, 26)
        Me.TextBox2.TabIndex = 6
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(13, 62)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(68, 20)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "Channel"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(75, 62)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(42, 20)
        Me.Label32.TabIndex = 4
        Me.Label32.Text = "MHz"
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"OFF", "67.0", "71.9", "74.4", "77.0", "79.7", "82.5", "85.4", "88.5", "91.5", "94.8", "97.4", "100.0", "103.5", "107.2", "110.9", "114.8", "118.8", "123.0", "127.3", "131.8", "136.5", "141.3", "146.2", "151.4", "156.7", "162.2", "167.9", "173.8", "179.9", "186.2", "192.8", "203.5", "210.7", "218.1", "225.7", "233.6", "241.8", "250.3"})
        Me.ComboBox5.Location = New System.Drawing.Point(265, 76)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(50, 28)
        Me.ComboBox5.TabIndex = 3
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"PLUS", "MINUS", "SIMPLEX"})
        Me.ComboBox6.Location = New System.Drawing.Point(184, 76)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(75, 28)
        Me.ComboBox6.TabIndex = 2
        '
        'ComboBox7
        '
        Me.ComboBox7.DropDownWidth = 43
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "110", "120", "130", "140", "150", "160", "170", "180", "190", "200", "210", "220", "230", "240", "250", "260", "270", "280", "290", "300", "310", "320", "330", "340", "350", "360", "370", "380", "390", "400", "410", "420", "430", "440", "450", "460", "470", "480", "490", "500", "510", "520", "530", "540", "550", "560", "570", "580", "590", "600", "610", "620", "630", "640", "650", "660", "670", "680", "690", "700", "710", "720", "730", "740", "750", "760", "770", "780", "790", "800", "810", "820", "830", "840", "850", "860", "870", "880", "890", "900", "910", "920", "930", "940", "950", "960", "970", "980", "990"})
        Me.ComboBox7.Location = New System.Drawing.Point(128, 77)
        Me.ComboBox7.MaxDropDownItems = 10
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(50, 28)
        Me.ComboBox7.TabIndex = 1
        '
        'ComboBox8
        '
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Items.AddRange(New Object() {"BLANK", "146", "147", "148", "149", "150"})
        Me.ComboBox8.Location = New System.Drawing.Point(65, 78)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(57, 28)
        Me.ComboBox8.TabIndex = 0
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.05068!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.94932!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Panel14, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(838, 476)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Panel9, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Panel13, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.25077!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.74923!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(421, 470)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Silver
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel13.Controls.Add(Me.Label39)
        Me.Panel13.Controls.Add(Me.NumericUpDown5)
        Me.Panel13.Controls.Add(Me.Label40)
        Me.Panel13.Controls.Add(Me.NumericUpDown6)
        Me.Panel13.Controls.Add(Me.Button8)
        Me.Panel13.Controls.Add(Me.Label41)
        Me.Panel13.Controls.Add(Me.ProgressBar3)
        Me.Panel13.Controls.Add(Me.Button9)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(3, 171)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(415, 141)
        Me.Panel13.TabIndex = 1
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(9, 42)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(101, 20)
        Me.Label39.TabIndex = 18
        Me.Label39.Text = "Button in mS"
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown5.Location = New System.Drawing.Point(9, 57)
        Me.NumericUpDown5.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown5.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(55, 26)
        Me.NumericUpDown5.TabIndex = 17
        Me.NumericUpDown5.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(9, 4)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(89, 20)
        Me.Label40.TabIndex = 16
        Me.Label40.Text = "Tone in mS"
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown6.Location = New System.Drawing.Point(9, 19)
        Me.NumericUpDown6.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown6.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(55, 26)
        Me.NumericUpDown6.TabIndex = 15
        Me.NumericUpDown6.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(78, 56)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 37)
        Me.Button8.TabIndex = 12
        Me.Button8.Text = "Clear Channel List"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(73, 13)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(358, 37)
        Me.Label41.TabIndex = 11
        Me.Label41.Text = "Channel Programming"
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(31, 108)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(335, 16)
        Me.ProgressBar3.TabIndex = 1
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(220, 56)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(95, 37)
        Me.Button9.TabIndex = 0
        Me.Button9.Text = "Program Radio Channels"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Silver
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel14.Controls.Add(Me.ListView2)
        Me.Panel14.Controls.Add(Me.Label42)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(430, 3)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(405, 470)
        Me.Panel14.TabIndex = 1
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(0, 49)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(389, 377)
        Me.ListView2.TabIndex = 12
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Channel"
        Me.ColumnHeader9.Width = 64
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Frequency"
        Me.ColumnHeader10.Width = 81
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Repeater Mode"
        Me.ColumnHeader11.Width = 105
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Tone"
        Me.ColumnHeader12.Width = 76
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = " CTSS"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(109, 10)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(207, 37)
        Me.Label42.TabIndex = 11
        Me.Label42.Text = "Channel List"
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.Panel16, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Panel18, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.deleteStatusStrip1, 0, 2)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 3
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.25077!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.74923!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(421, 470)
        Me.TableLayoutPanel9.TabIndex = 0
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.Silver
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Controls.Add(Me.Label44)
        Me.Panel16.Controls.Add(Me.Button4)
        Me.Panel16.Controls.Add(Me.Label45)
        Me.Panel16.Controls.Add(Me.Label46)
        Me.Panel16.Controls.Add(Me.Label47)
        Me.Panel16.Controls.Add(Me.Label48)
        Me.Panel16.Controls.Add(Me.TextBox3)
        Me.Panel16.Controls.Add(Me.Label49)
        Me.Panel16.Controls.Add(Me.Label50)
        Me.Panel16.Controls.Add(Me.ComboBox9)
        Me.Panel16.Controls.Add(Me.ComboBox10)
        Me.Panel16.Controls.Add(Me.ComboBox11)
        Me.Panel16.Controls.Add(Me.ComboBox12)
        Me.Panel16.Controls.Add(Me.deleteMenuStrip1)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(3, 3)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(415, 162)
        Me.Panel16.TabIndex = 0
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.RadioButton3)
        Me.Panel17.Controls.Add(Me.RadioButton4)
        Me.Panel17.Location = New System.Drawing.Point(321, 76)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(90, 44)
        Me.Panel17.TabIndex = 16
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(4, 5)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(66, 24)
        Me.RadioButton3.TabIndex = 14
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Xmit"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(4, 23)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(99, 24)
        Me.RadioButton4.TabIndex = 15
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Xmit/Rec"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(324, 60)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(65, 20)
        Me.Label44.TabIndex = 13
        Me.Label44.Text = "CTCSS"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(268, 136)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Set/Update Channel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(73, 24)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(276, 37)
        Me.Label45.TabIndex = 10
        Me.Label45.Text = "Channel Settings"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(273, 60)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(45, 20)
        Me.Label46.TabIndex = 9
        Me.Label46.Text = "Tone"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(187, 60)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(76, 20)
        Me.Label47.TabIndex = 8
        Me.Label47.Text = "Repeater"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(129, 60)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(39, 20)
        Me.Label48.TabIndex = 7
        Me.Label48.Text = "KHz"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(9, 79)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(50, 26)
        Me.TextBox3.TabIndex = 6
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(13, 62)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(68, 20)
        Me.Label49.TabIndex = 5
        Me.Label49.Text = "Channel"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(75, 62)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(42, 20)
        Me.Label50.TabIndex = 4
        Me.Label50.Text = "MHz"
        '
        'ComboBox9
        '
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Items.AddRange(New Object() {"OFF", "67.0", "71.9", "74.4", "77.0", "79.7", "82.5", "85.4", "88.5", "91.5", "94.8", "97.4", "100.0", "103.5", "107.2", "110.9", "114.8", "118.8", "123.0", "127.3", "131.8", "136.5", "141.3", "146.2", "151.4", "156.7", "162.2", "167.9", "173.8", "179.9", "186.2", "192.8", "203.5", "210.7", "218.1", "225.7", "233.6", "241.8", "250.3"})
        Me.ComboBox9.Location = New System.Drawing.Point(265, 76)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(50, 28)
        Me.ComboBox9.TabIndex = 3
        '
        'ComboBox10
        '
        Me.ComboBox10.FormattingEnabled = True
        Me.ComboBox10.Items.AddRange(New Object() {"PLUS", "MINUS", "SIMPLEX"})
        Me.ComboBox10.Location = New System.Drawing.Point(184, 76)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(75, 28)
        Me.ComboBox10.TabIndex = 2
        '
        'ComboBox11
        '
        Me.ComboBox11.DropDownWidth = 43
        Me.ComboBox11.FormattingEnabled = True
        Me.ComboBox11.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "110", "120", "130", "140", "150", "160", "170", "180", "190", "200", "210", "220", "230", "240", "250", "260", "270", "280", "290", "300", "310", "320", "330", "340", "350", "360", "370", "380", "390", "400", "410", "420", "430", "440", "450", "460", "470", "480", "490", "500", "510", "520", "530", "540", "550", "560", "570", "580", "590", "600", "610", "620", "630", "640", "650", "660", "670", "680", "690", "700", "710", "720", "730", "740", "750", "760", "770", "780", "790", "800", "810", "820", "830", "840", "850", "860", "870", "880", "890", "900", "910", "920", "930", "940", "950", "960", "970", "980", "990"})
        Me.ComboBox11.Location = New System.Drawing.Point(128, 77)
        Me.ComboBox11.MaxDropDownItems = 10
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(50, 28)
        Me.ComboBox11.TabIndex = 1
        '
        'ComboBox12
        '
        Me.ComboBox12.FormattingEnabled = True
        Me.ComboBox12.Items.AddRange(New Object() {"BLANK", "146", "147", "148", "149", "150"})
        Me.ComboBox12.Location = New System.Drawing.Point(65, 78)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(57, 28)
        Me.ComboBox12.TabIndex = 0
        '
        'deleteMenuStrip1
        '
        Me.deleteMenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.deleteMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.deleteMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem4})
        Me.deleteMenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.deleteMenuStrip1.Name = "deleteMenuStrip1"
        Me.deleteMenuStrip1.Size = New System.Drawing.Size(411, 24)
        Me.deleteMenuStrip1.TabIndex = 17
        Me.deleteMenuStrip1.Text = "MenuStrip1"
        Me.deleteMenuStrip1.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(257, 34)
        Me.ToolStripMenuItem2.Text = "Open Channel File"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(257, 34)
        Me.ToolStripMenuItem3.Text = "Save Channel File"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(92, 20)
        Me.ToolStripMenuItem4.Text = "Options"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(266, 34)
        Me.ToolStripMenuItem5.Text = "Back to Main Menu"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1})
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(266, 34)
        Me.ToolStripMenuItem6.Text = "kHz Step Size"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"10", "12.5"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 33)
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.Silver
        Me.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel18.Controls.Add(Me.Label51)
        Me.Panel18.Controls.Add(Me.NumericUpDown3)
        Me.Panel18.Controls.Add(Me.Label52)
        Me.Panel18.Controls.Add(Me.NumericUpDown4)
        Me.Panel18.Controls.Add(Me.Button6)
        Me.Panel18.Controls.Add(Me.Label53)
        Me.Panel18.Controls.Add(Me.ProgressBar2)
        Me.Panel18.Controls.Add(Me.Button7)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel18.Location = New System.Drawing.Point(3, 171)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(415, 141)
        Me.Panel18.TabIndex = 1
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(9, 42)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(101, 20)
        Me.Label51.TabIndex = 18
        Me.Label51.Text = "Button in mS"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown3.Location = New System.Drawing.Point(9, 57)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(55, 26)
        Me.NumericUpDown3.TabIndex = 17
        Me.NumericUpDown3.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(9, 4)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(89, 20)
        Me.Label52.TabIndex = 16
        Me.Label52.Text = "Tone in mS"
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown4.Location = New System.Drawing.Point(9, 19)
        Me.NumericUpDown4.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown4.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(55, 26)
        Me.NumericUpDown4.TabIndex = 15
        Me.NumericUpDown4.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(78, 56)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 37)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Clear Channel List"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(73, 13)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(358, 37)
        Me.Label53.TabIndex = 11
        Me.Label53.Text = "Channel Programming"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(31, 108)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(335, 16)
        Me.ProgressBar2.TabIndex = 1
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(220, 56)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(95, 37)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Program Radio Channels"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'deleteStatusStrip1
        '
        Me.deleteStatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.deleteStatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.deleteStatusStrip1.Location = New System.Drawing.Point(0, 438)
        Me.deleteStatusStrip1.Name = "deleteStatusStrip1"
        Me.deleteStatusStrip1.Size = New System.Drawing.Size(421, 32)
        Me.deleteStatusStrip1.TabIndex = 2
        Me.deleteStatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(180, 25)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(196, 25)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.Silver
        Me.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel19.Controls.Add(Me.ListView3)
        Me.Panel19.Controls.Add(Me.Label54)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel19.Location = New System.Drawing.Point(430, 3)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(405, 470)
        Me.Panel19.TabIndex = 1
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20})
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(0, 49)
        Me.ListView3.MultiSelect = False
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(389, 377)
        Me.ListView3.TabIndex = 12
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Channel"
        Me.ColumnHeader16.Width = 64
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Frequency"
        Me.ColumnHeader17.Width = 81
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Repeater Mode"
        Me.ColumnHeader18.Width = 105
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Tone"
        Me.ColumnHeader19.Width = 76
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = " CTSS"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(109, 10)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(207, 37)
        Me.Label54.TabIndex = 11
        Me.Label54.Text = "Channel List"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1014, 568)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Channel Lists (Version 1.1)"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Tab1TableLayoutPanel1.ResumeLayout(False)
        Me.Tab1TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Tab1CtcssPanel.ResumeLayout(False)
        Me.Tab1CtcssPanel.PerformLayout()
        Me.Tab1MenuStrip.ResumeLayout(False)
        Me.Tab1MenuStrip.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Tab1StatusStrip1.ResumeLayout(False)
        Me.Tab1StatusStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Tab2MenuStrip.ResumeLayout(False)
        Me.Tab2MenuStrip.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Tab2StatusStrip.ResumeLayout(False)
        Me.Tab2StatusStrip.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.Panel21.ResumeLayout(False)
        Me.Panel21.PerformLayout()
        Me.Tab3MenuStrip.ResumeLayout(False)
        Me.Tab3MenuStrip.PerformLayout()
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.Tab3StatusStrip.ResumeLayout(False)
        Me.Tab3StatusStrip.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.deleteMenuStrip1.ResumeLayout(False)
        Me.deleteMenuStrip1.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.deleteStatusStrip1.ResumeLayout(False)
        Me.deleteStatusStrip1.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.ResumeLayout(False)

    End Sub


    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog


    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Tab1TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Tab1CtcssPanel As System.Windows.Forms.Panel
    Friend WithEvents Tab1CtcssXmit As System.Windows.Forms.RadioButton
    Friend WithEvents Tab1CtcssXmitRec As System.Windows.Forms.RadioButton
    Friend WithEvents Tab1CtcssLabel As System.Windows.Forms.Label
    Friend WithEvents Tab1SetChannelButtone As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tab1ChannelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tab1ToneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tab1RepeaterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tab1KHzCombBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tab1MHzComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tab1MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents Tab1FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab1OpenChannelFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab1SaveChannelFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab1SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab1BackToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab1KHzStepSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab1KHzToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Tab1ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Tab1ProgramButton As System.Windows.Forms.Button
    Friend WithEvents Tab1StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Tab1ToolStripStepSize As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Tab1ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Tab1ChannelListView As System.Windows.Forms.ListView
    Friend WithEvents Channel As System.Windows.Forms.ColumnHeader
    Friend WithEvents Frequency As System.Windows.Forms.ColumnHeader
    Friend WithEvents Repeater As System.Windows.Forms.ColumnHeader
    Friend WithEvents Tone As System.Windows.Forms.ColumnHeader
    Friend WithEvents CTSS As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage

    Friend WithEvents Tab1ClearChannelList As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Tab2CtcssXmit As System.Windows.Forms.RadioButton
    Friend WithEvents Tab2CtcssXmitRec As System.Windows.Forms.RadioButton
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Tab2SetChannelButtone As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Tab2ChannelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Tab2ToneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tab2RepeaterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tab2KHzCombBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tab2MHzComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tab2MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents Tab2FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab2OpenChannelFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab2SaveChannelFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab2SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab2BackToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab2KHzStepSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab2KHzToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Tab2ClearChannelList As System.Windows.Forms.Button
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Tab2ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Tab2ProgramButton As System.Windows.Forms.Button
    Friend WithEvents Tab2StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Tab2ToolStripStepSize As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Tab2ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Tab2ChannelListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar3 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel10 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents Tab3CtcssXmit As System.Windows.Forms.RadioButton
    Friend WithEvents Tab3CtcssXmitRec As System.Windows.Forms.RadioButton
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Tab3SetChannelButtone As System.Windows.Forms.Button
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Tab3ChannelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Tab3ToneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tab3RepeaterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tab3KHzCombBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tab3MHzComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tab3MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents Tab3FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab3OpenChannelFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab3SaveChannelFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab3SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab3BackToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab3KHzStepSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tab3KHzToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents Tab3ClearChannelList As System.Windows.Forms.Button
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Tab3ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Tab3ProgramButton As System.Windows.Forms.Button
    Friend WithEvents Tab3StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Tab3ToolStripStepSize As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Tab3ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents Tab3ChannelListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel9 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents ComboBox9 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox10 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox11 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox12 As System.Windows.Forms.ComboBox
    Friend WithEvents deleteMenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents deleteStatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Tab1ComPortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tab2ComPortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tab3ComPortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Tab1UsbCmdLabel As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Tab2UsbCmdLabel As System.Windows.Forms.Label
    Friend WithEvents Tab3UsbCmdLabel As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Tab1ChannelNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Tab2ChannelNotes As System.Windows.Forms.TextBox
    Friend WithEvents Tab3ChannelNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Notes As System.Windows.Forms.ColumnHeader
    Friend WithEvents Tab3DeleteRowButton As System.Windows.Forms.Button
    Friend WithEvents Tab3InsertRowButton As System.Windows.Forms.Button
    Friend WithEvents Tab1DeleteRowButton As System.Windows.Forms.Button
    Friend WithEvents Tab1InsertRowButton As System.Windows.Forms.Button
    Friend WithEvents Tab2DeleteRowButton As System.Windows.Forms.Button
    Friend WithEvents Tab2InsertRowButton As System.Windows.Forms.Button
    Friend WithEvents Tab1UsbRcvdLabel As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Tab2UsbRcvdLabel As System.Windows.Forms.Label
    Friend WithEvents Tab3UsbRcvdLabel As System.Windows.Forms.Label
    Friend WithEvents Tab1StopProgramButton As System.Windows.Forms.Button
    Friend WithEvents Tab2StopProgramButton As System.Windows.Forms.Button
    Friend WithEvents Tab3StopProgramButton As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tab1ChannelFileName As System.Windows.Forms.Label
    Friend WithEvents tab2ChannelFileName As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tab3ChannelFileName As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Tab1CtcssOff As System.Windows.Forms.RadioButton
    Friend WithEvents Tab2CtcssOff As System.Windows.Forms.RadioButton
    Friend WithEvents Tab3CtcssOff As System.Windows.Forms.RadioButton

End Class


