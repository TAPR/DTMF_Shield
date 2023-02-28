
namespace Radio
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable IDE1006

    partial class ModuleChannelList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PanelChannelSettings = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownCustomOffsetMHz = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CtcssOffRadioButton = new System.Windows.Forms.RadioButton();
            this.CtcssXmitRadioButton = new System.Windows.Forms.RadioButton();
            this.CtcssXmitRecRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.KhzSpacingComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteRowButton = new System.Windows.Forms.Button();
            this.InsertRowButton = new System.Windows.Forms.Button();
            this.Label67 = new System.Windows.Forms.Label();
            this.ChannelNotes = new System.Windows.Forms.TextBox();
            this.Tab1SetChannelButton = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.ClearChannelListButton = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.ChannelTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ToneComboBox = new System.Windows.Forms.ComboBox();
            this.RepeaterModeComboBox = new System.Windows.Forms.ComboBox();
            this.KHzComboBox = new System.Windows.Forms.ComboBox();
            this.MHzComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ChannelListView = new System.Windows.Forms.ListView();
            this.Channel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Frequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Repeater = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CTCSS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomSplit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Notes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PanelChannelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomOffsetMHz)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PanelChannelSettings);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.ChannelListView);
            this.splitContainer1.Size = new System.Drawing.Size(1442, 624);
            this.splitContainer1.SplitterDistance = 717;
            this.splitContainer1.TabIndex = 0;
            // 
            // PanelChannelSettings
            // 
            this.PanelChannelSettings.BackColor = System.Drawing.Color.Silver;
            this.PanelChannelSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelChannelSettings.Controls.Add(this.label8);
            this.PanelChannelSettings.Controls.Add(this.numericUpDownCustomOffsetMHz);
            this.PanelChannelSettings.Controls.Add(this.groupBox1);
            this.PanelChannelSettings.Controls.Add(this.label7);
            this.PanelChannelSettings.Controls.Add(this.KhzSpacingComboBox);
            this.PanelChannelSettings.Controls.Add(this.DeleteRowButton);
            this.PanelChannelSettings.Controls.Add(this.InsertRowButton);
            this.PanelChannelSettings.Controls.Add(this.Label67);
            this.PanelChannelSettings.Controls.Add(this.ChannelNotes);
            this.PanelChannelSettings.Controls.Add(this.Tab1SetChannelButton);
            this.PanelChannelSettings.Controls.Add(this.Label6);
            this.PanelChannelSettings.Controls.Add(this.Label5);
            this.PanelChannelSettings.Controls.Add(this.ClearChannelListButton);
            this.PanelChannelSettings.Controls.Add(this.Label4);
            this.PanelChannelSettings.Controls.Add(this.Label3);
            this.PanelChannelSettings.Controls.Add(this.ChannelTextBox);
            this.PanelChannelSettings.Controls.Add(this.Label2);
            this.PanelChannelSettings.Controls.Add(this.Label1);
            this.PanelChannelSettings.Controls.Add(this.ToneComboBox);
            this.PanelChannelSettings.Controls.Add(this.RepeaterModeComboBox);
            this.PanelChannelSettings.Controls.Add(this.KHzComboBox);
            this.PanelChannelSettings.Controls.Add(this.MHzComboBox);
            this.PanelChannelSettings.Location = new System.Drawing.Point(5, 5);
            this.PanelChannelSettings.Name = "PanelChannelSettings";
            this.PanelChannelSettings.Size = new System.Drawing.Size(705, 612);
            this.PanelChannelSettings.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(526, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Odd Split MHz";
            // 
            // numericUpDownCustomOffsetMHz
            // 
            this.numericUpDownCustomOffsetMHz.Location = new System.Drawing.Point(527, 157);
            this.numericUpDownCustomOffsetMHz.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownCustomOffsetMHz.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.numericUpDownCustomOffsetMHz.Name = "numericUpDownCustomOffsetMHz";
            this.numericUpDownCustomOffsetMHz.Size = new System.Drawing.Size(80, 26);
            this.numericUpDownCustomOffsetMHz.TabIndex = 28;
            this.numericUpDownCustomOffsetMHz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CtcssOffRadioButton);
            this.groupBox1.Controls.Add(this.CtcssXmitRadioButton);
            this.groupBox1.Controls.Add(this.CtcssXmitRecRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(525, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 118);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CTCSS";
            // 
            // CtcssOffRadioButton
            // 
            this.CtcssOffRadioButton.AutoSize = true;
            this.CtcssOffRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtcssOffRadioButton.Location = new System.Drawing.Point(6, 83);
            this.CtcssOffRadioButton.Name = "CtcssOffRadioButton";
            this.CtcssOffRadioButton.Size = new System.Drawing.Size(66, 29);
            this.CtcssOffRadioButton.TabIndex = 16;
            this.CtcssOffRadioButton.TabStop = true;
            this.CtcssOffRadioButton.Text = "Off";
            this.CtcssOffRadioButton.UseVisualStyleBackColor = true;
            this.CtcssOffRadioButton.CheckedChanged += new System.EventHandler(this.CtcssOffRadioButton_CheckedChanged);
            // 
            // CtcssXmitRadioButton
            // 
            this.CtcssXmitRadioButton.AutoSize = true;
            this.CtcssXmitRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtcssXmitRadioButton.Location = new System.Drawing.Point(6, 25);
            this.CtcssXmitRadioButton.Name = "CtcssXmitRadioButton";
            this.CtcssXmitRadioButton.Size = new System.Drawing.Size(80, 29);
            this.CtcssXmitRadioButton.TabIndex = 14;
            this.CtcssXmitRadioButton.TabStop = true;
            this.CtcssXmitRadioButton.Text = "Xmit";
            this.CtcssXmitRadioButton.UseVisualStyleBackColor = true;
            this.CtcssXmitRadioButton.CheckedChanged += new System.EventHandler(this.CtcssXmit_CheckedChanged);
            // 
            // CtcssXmitRecRadioButton
            // 
            this.CtcssXmitRecRadioButton.AutoSize = true;
            this.CtcssXmitRecRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtcssXmitRecRadioButton.Location = new System.Drawing.Point(6, 52);
            this.CtcssXmitRecRadioButton.Name = "CtcssXmitRecRadioButton";
            this.CtcssXmitRecRadioButton.Size = new System.Drawing.Size(124, 29);
            this.CtcssXmitRecRadioButton.TabIndex = 15;
            this.CtcssXmitRecRadioButton.TabStop = true;
            this.CtcssXmitRecRadioButton.Text = "Xmit/Rec";
            this.CtcssXmitRecRadioButton.UseVisualStyleBackColor = true;
            this.CtcssXmitRecRadioButton.CheckedChanged += new System.EventHandler(this.CtcssXmitRec_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "KHz Step Size";
            // 
            // KhzSpacingComboBox
            // 
            this.KhzSpacingComboBox.AllowDrop = true;
            this.KhzSpacingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhzSpacingComboBox.Items.AddRange(new object[] {
            "10",
            "12.5",
            "5",
            "25",
            "20",
            "15"});
            this.KhzSpacingComboBox.Location = new System.Drawing.Point(198, 58);
            this.KhzSpacingComboBox.Name = "KhzSpacingComboBox";
            this.KhzSpacingComboBox.Size = new System.Drawing.Size(100, 33);
            this.KhzSpacingComboBox.TabIndex = 25;
            this.KhzSpacingComboBox.SelectedIndexChanged += new System.EventHandler(this.KhzSpacingComboBox_SelectedIndexChanged);
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRowButton.Location = new System.Drawing.Point(463, 376);
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Size = new System.Drawing.Size(200, 46);
            this.DeleteRowButton.TabIndex = 24;
            this.DeleteRowButton.Text = "Delete Row";
            this.DeleteRowButton.UseVisualStyleBackColor = true;
            this.DeleteRowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // InsertRowButton
            // 
            this.InsertRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertRowButton.Location = new System.Drawing.Point(463, 326);
            this.InsertRowButton.Name = "InsertRowButton";
            this.InsertRowButton.Size = new System.Drawing.Size(200, 44);
            this.InsertRowButton.TabIndex = 22;
            this.InsertRowButton.Text = "Insert Row";
            this.InsertRowButton.UseVisualStyleBackColor = true;
            this.InsertRowButton.Click += new System.EventHandler(this.InsertRowButton_Click);
            // 
            // Label67
            // 
            this.Label67.AutoSize = true;
            this.Label67.Location = new System.Drawing.Point(8, 202);
            this.Label67.Name = "Label67";
            this.Label67.Size = new System.Drawing.Size(114, 20);
            this.Label67.TabIndex = 19;
            this.Label67.Text = "Channel Notes";
            // 
            // ChannelNotes
            // 
            this.ChannelNotes.Location = new System.Drawing.Point(12, 235);
            this.ChannelNotes.MaxLength = 25;
            this.ChannelNotes.Name = "ChannelNotes";
            this.ChannelNotes.Size = new System.Drawing.Size(473, 26);
            this.ChannelNotes.TabIndex = 18;
            // 
            // Tab1SetChannelButton
            // 
            this.Tab1SetChannelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1SetChannelButton.Location = new System.Drawing.Point(209, 302);
            this.Tab1SetChannelButton.Name = "Tab1SetChannelButton";
            this.Tab1SetChannelButton.Size = new System.Drawing.Size(200, 68);
            this.Tab1SetChannelButton.TabIndex = 11;
            this.Tab1SetChannelButton.Text = "Set/Update Channel";
            this.Tab1SetChannelButton.UseVisualStyleBackColor = true;
            this.Tab1SetChannelButton.Click += new System.EventHandler(this.SetChannelButton_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(115, 7);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(276, 37);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Channel Settings";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(423, 117);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(62, 25);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "Tone";
            // 
            // ClearChannelListButton
            // 
            this.ClearChannelListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearChannelListButton.Location = new System.Drawing.Point(463, 428);
            this.ClearChannelListButton.Name = "ClearChannelListButton";
            this.ClearChannelListButton.Size = new System.Drawing.Size(200, 75);
            this.ClearChannelListButton.TabIndex = 12;
            this.ClearChannelListButton.Text = "Clear Channel List";
            this.ClearChannelListButton.UseVisualStyleBackColor = true;
            this.ClearChannelListButton.Click += new System.EventHandler(this.ClearChannelListButton_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(292, 117);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(99, 25);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Repeater";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(198, 117);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(53, 25);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "KHz";
            // 
            // ChannelTextBox
            // 
            this.ChannelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelTextBox.Location = new System.Drawing.Point(3, 154);
            this.ChannelTextBox.Name = "ChannelTextBox";
            this.ChannelTextBox.ReadOnly = true;
            this.ChannelTextBox.Size = new System.Drawing.Size(62, 28);
            this.ChannelTextBox.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(7, 117);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(61, 25);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "CH #";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(82, 117);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 25);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "MHz";
            // 
            // ToneComboBox
            // 
            this.ToneComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToneComboBox.FormattingEnabled = true;
            this.ToneComboBox.Items.AddRange(new object[] {
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
            this.ToneComboBox.Location = new System.Drawing.Point(416, 154);
            this.ToneComboBox.Name = "ToneComboBox";
            this.ToneComboBox.Size = new System.Drawing.Size(99, 30);
            this.ToneComboBox.TabIndex = 3;
            this.ToneComboBox.SelectedIndexChanged += new System.EventHandler(this.ToneComboBox_SelectedIndexChanged);
            // 
            // RepeaterModeComboBox
            // 
            this.RepeaterModeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeaterModeComboBox.FormattingEnabled = true;
            this.RepeaterModeComboBox.Items.AddRange(new object[] {
            "PLUS",
            "MINUS",
            "SIMPLEX"});
            this.RepeaterModeComboBox.Location = new System.Drawing.Point(276, 154);
            this.RepeaterModeComboBox.Name = "RepeaterModeComboBox";
            this.RepeaterModeComboBox.Size = new System.Drawing.Size(133, 30);
            this.RepeaterModeComboBox.TabIndex = 2;
            // 
            // KHzComboBox
            // 
            this.KHzComboBox.DropDownWidth = 43;
            this.KHzComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KHzComboBox.FormattingEnabled = true;
            this.KHzComboBox.Items.AddRange(new object[] {
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
            this.KHzComboBox.Location = new System.Drawing.Point(180, 154);
            this.KHzComboBox.MaxDropDownItems = 10;
            this.KHzComboBox.Name = "KHzComboBox";
            this.KHzComboBox.Size = new System.Drawing.Size(90, 30);
            this.KHzComboBox.TabIndex = 1;
            this.KHzComboBox.SelectedIndexChanged += new System.EventHandler(this.KHzCombBox_SelectedIndexChanged);
            // 
            // MHzComboBox
            // 
            this.MHzComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MHzComboBox.FormattingEnabled = true;
            this.MHzComboBox.Items.AddRange(new object[] {
            "BLANK",
            "146",
            "147",
            "148",
            "149",
            "150"});
            this.MHzComboBox.Location = new System.Drawing.Point(71, 152);
            this.MHzComboBox.Name = "MHzComboBox";
            this.MHzComboBox.Size = new System.Drawing.Size(102, 30);
            this.MHzComboBox.TabIndex = 0;
            this.MHzComboBox.SelectedIndexChanged += new System.EventHandler(this.MHzComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(171, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 37);
            this.label9.TabIndex = 14;
            this.label9.Text = "Channel List";
            // 
            // ChannelListView
            // 
            this.ChannelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Channel,
            this.Frequency,
            this.Repeater,
            this.Tone,
            this.CTCSS,
            this.CustomSplit,
            this.Notes});
            this.ChannelListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelListView.FullRowSelect = true;
            this.ChannelListView.GridLines = true;
            this.ChannelListView.HideSelection = false;
            this.ChannelListView.LabelWrap = false;
            this.ChannelListView.Location = new System.Drawing.Point(3, 68);
            this.ChannelListView.MultiSelect = false;
            this.ChannelListView.Name = "ChannelListView";
            this.ChannelListView.Size = new System.Drawing.Size(711, 549);
            this.ChannelListView.TabIndex = 13;
            this.ChannelListView.UseCompatibleStateImageBehavior = false;
            this.ChannelListView.View = System.Windows.Forms.View.Details;
            this.ChannelListView.SelectedIndexChanged += new System.EventHandler(this.ChannelListView_SelectedIndexChanged);
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
            // CTCSS
            // 
            this.CTCSS.Text = " CTCSS";
            this.CTCSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CTCSS.Width = 77;
            // 
            // CustomSplit
            // 
            this.CustomSplit.Text = "Custom Split";
            // 
            // Notes
            // 
            this.Notes.Text = "Notes";
            this.Notes.Width = 375;
            // 
            // ModuleChannelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ModuleChannelList";
            this.Size = new System.Drawing.Size(1442, 624);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PanelChannelSettings.ResumeLayout(false);
            this.PanelChannelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomOffsetMHz)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.ListView ChannelListView;
        internal System.Windows.Forms.ColumnHeader Channel;
        internal System.Windows.Forms.ColumnHeader Frequency;
        internal System.Windows.Forms.ColumnHeader Repeater;
        internal System.Windows.Forms.ColumnHeader Tone;
        internal System.Windows.Forms.ColumnHeader CTCSS;
        internal System.Windows.Forms.ColumnHeader CustomSplit;
        internal System.Windows.Forms.ColumnHeader Notes;
        internal System.Windows.Forms.Panel PanelChannelSettings;
        internal System.Windows.Forms.Label label8;
        public System.Windows.Forms.NumericUpDown numericUpDownCustomOffsetMHz;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.RadioButton CtcssOffRadioButton;
        internal System.Windows.Forms.RadioButton CtcssXmitRadioButton;
        internal System.Windows.Forms.RadioButton CtcssXmitRecRadioButton;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox KhzSpacingComboBox;
        internal System.Windows.Forms.Button DeleteRowButton;
        internal System.Windows.Forms.Button InsertRowButton;
        internal System.Windows.Forms.Label Label67;
        internal System.Windows.Forms.TextBox ChannelNotes;
        internal System.Windows.Forms.Button Tab1SetChannelButton;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button ClearChannelListButton;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox ChannelTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox ToneComboBox;
        internal System.Windows.Forms.ComboBox RepeaterModeComboBox;
        internal System.Windows.Forms.ComboBox KHzComboBox;
        internal System.Windows.Forms.ComboBox MHzComboBox;
        internal System.Windows.Forms.Label label9;
    }
}
