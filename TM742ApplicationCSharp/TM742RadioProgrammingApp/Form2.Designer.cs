using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Radio
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form2 : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            TableLayoutPanel1 = new TableLayoutPanel();
            TableLayoutPanel2 = new TableLayoutPanel();
            Panel2 = new Panel();
            GroupBox1 = new GroupBox();
            Mod2None = new RadioButton();
            Mod2UT1200 = new RadioButton();
            Mod2UT440 = new RadioButton();
            Mod2UT30 = new RadioButton();
            Mod2UT220 = new RadioButton();
            Mod2UT50 = new RadioButton();
            Mod2UT144 = new RadioButton();
            Panel3 = new Panel();
            GroupBox2 = new GroupBox();
            Mod1None = new RadioButton();
            Mod1UT1200 = new RadioButton();
            Mod1UT440 = new RadioButton();
            Mod1UT30 = new RadioButton();
            Mod1UT220 = new RadioButton();
            Mod1UT50 = new RadioButton();
            Mod1UT144 = new RadioButton();
            Panel1 = new Panel();
            GroupBox3 = new GroupBox();
            Mod3None = new RadioButton();
            Mod3UT1200 = new RadioButton();
            Mod3UT440 = new RadioButton();
            Mod3UT30 = new RadioButton();
            Mod3UT220 = new RadioButton();
            Mod3UT50 = new RadioButton();
            Mod3UT144 = new RadioButton();
            TableLayoutPanel3 = new TableLayoutPanel();
            Panel5 = new Panel();
            GroupBox5 = new GroupBox();
            debugRadioTimingButton = new RadioButton();
            slowRadioTimingButton = new RadioButton();
            normalRadioTimingButton = new RadioButton();
            GroupBox4 = new GroupBox();
            AROcheckBox = new CheckBox();
            wideBandCheckBox = new CheckBox();
            eTypeRadioCheckBox = new CheckBox();
            eTypeRadioCheckBox.CheckedChanged += new EventHandler(eTypeRadioCheckBox_CheckedChanged);
            Tsu7CheckBox = new CheckBox();
            Panel6 = new Panel();
            Panel4 = new Panel();
            ChannelLists = new Button();
            ChannelLists.Click += new EventHandler(ChannelLists_Click);
            ToolTip1 = new ToolTip(components);
            TableLayoutPanel1.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            Panel2.SuspendLayout();
            GroupBox1.SuspendLayout();
            Panel3.SuspendLayout();
            GroupBox2.SuspendLayout();
            Panel1.SuspendLayout();
            GroupBox3.SuspendLayout();
            TableLayoutPanel3.SuspendLayout();
            Panel5.SuspendLayout();
            GroupBox5.SuspendLayout();
            GroupBox4.SuspendLayout();
            Panel6.SuspendLayout();
            Panel4.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.ColumnCount = 1;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0);
            TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 0, 1);
            TableLayoutPanel1.Dock = DockStyle.Fill;
            TableLayoutPanel1.Location = new Point(0, 0);
            TableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 2;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 58.44156f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41.55844f));
            TableLayoutPanel1.Size = new Size(573, 592);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.ColumnCount = 3;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.17544f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.82456f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 211.0f));
            TableLayoutPanel2.Controls.Add(Panel2, 1, 0);
            TableLayoutPanel2.Controls.Add(Panel3, 0, 0);
            TableLayoutPanel2.Controls.Add(Panel1, 2, 0);
            TableLayoutPanel2.Dock = DockStyle.Fill;
            TableLayoutPanel2.Location = new Point(4, 5);
            TableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 1;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel2.Size = new Size(565, 335);
            TableLayoutPanel2.TabIndex = 0;
            // 
            // Panel2
            // 
            Panel2.BorderStyle = BorderStyle.Fixed3D;
            Panel2.Controls.Add(GroupBox1);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(181, 5);
            Panel2.Margin = new Padding(4, 5, 4, 5);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(168, 325);
            Panel2.TabIndex = 1;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(Mod2None);
            GroupBox1.Controls.Add(Mod2UT1200);
            GroupBox1.Controls.Add(Mod2UT440);
            GroupBox1.Controls.Add(Mod2UT30);
            GroupBox1.Controls.Add(Mod2UT220);
            GroupBox1.Controls.Add(Mod2UT50);
            GroupBox1.Controls.Add(Mod2UT144);
            GroupBox1.Location = new Point(24, 32);
            GroupBox1.Margin = new Padding(4, 5, 4, 5);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new Padding(4, 5, 4, 5);
            GroupBox1.Size = new Size(146, 288);
            GroupBox1.TabIndex = 2;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Module 2";
            // 
            // Mod2None
            // 
            Mod2None.AutoSize = true;
            Mod2None.Location = new Point(40, 29);
            Mod2None.Margin = new Padding(4, 5, 4, 5);
            Mod2None.Name = "Mod2None";
            Mod2None.Size = new Size(72, 24);
            Mod2None.TabIndex = 6;
            Mod2None.TabStop = true;
            Mod2None.Text = "None";
            Mod2None.UseVisualStyleBackColor = true;
            // 
            // Mod2UT1200
            // 
            Mod2UT1200.AutoSize = true;
            Mod2UT1200.Location = new Point(40, 242);
            Mod2UT1200.Margin = new Padding(4, 5, 4, 5);
            Mod2UT1200.Name = "Mod2UT1200";
            Mod2UT1200.Size = new Size(95, 24);
            Mod2UT1200.TabIndex = 5;
            Mod2UT1200.TabStop = true;
            Mod2UT1200.Text = "UT 1200";
            Mod2UT1200.UseVisualStyleBackColor = true;
            // 
            // Mod2UT440
            // 
            Mod2UT440.AutoSize = true;
            Mod2UT440.Location = new Point(40, 206);
            Mod2UT440.Margin = new Padding(4, 5, 4, 5);
            Mod2UT440.Name = "Mod2UT440";
            Mod2UT440.Size = new Size(86, 24);
            Mod2UT440.TabIndex = 4;
            Mod2UT440.TabStop = true;
            Mod2UT440.Text = "UT 440";
            Mod2UT440.UseVisualStyleBackColor = true;
            // 
            // Mod2UT30
            // 
            Mod2UT30.AutoSize = true;
            Mod2UT30.Location = new Point(40, 65);
            Mod2UT30.Margin = new Padding(4, 5, 4, 5);
            Mod2UT30.Name = "Mod2UT30";
            Mod2UT30.Size = new Size(77, 24);
            Mod2UT30.TabIndex = 0;
            Mod2UT30.TabStop = true;
            Mod2UT30.Text = "UT 30";
            Mod2UT30.UseVisualStyleBackColor = true;
            // 
            // Mod2UT220
            // 
            Mod2UT220.AutoSize = true;
            Mod2UT220.Location = new Point(40, 171);
            Mod2UT220.Margin = new Padding(4, 5, 4, 5);
            Mod2UT220.Name = "Mod2UT220";
            Mod2UT220.Size = new Size(86, 24);
            Mod2UT220.TabIndex = 3;
            Mod2UT220.TabStop = true;
            Mod2UT220.Text = "UT 220";
            Mod2UT220.UseVisualStyleBackColor = true;
            // 
            // Mod2UT50
            // 
            Mod2UT50.AutoSize = true;
            Mod2UT50.Location = new Point(40, 100);
            Mod2UT50.Margin = new Padding(4, 5, 4, 5);
            Mod2UT50.Name = "Mod2UT50";
            Mod2UT50.Size = new Size(77, 24);
            Mod2UT50.TabIndex = 1;
            Mod2UT50.TabStop = true;
            Mod2UT50.Text = "UT 50";
            Mod2UT50.UseVisualStyleBackColor = true;
            // 
            // Mod2UT144
            // 
            Mod2UT144.AutoSize = true;
            Mod2UT144.Location = new Point(40, 135);
            Mod2UT144.Margin = new Padding(4, 5, 4, 5);
            Mod2UT144.Name = "Mod2UT144";
            Mod2UT144.Size = new Size(86, 24);
            Mod2UT144.TabIndex = 2;
            Mod2UT144.TabStop = true;
            Mod2UT144.Text = "UT 144";
            Mod2UT144.UseVisualStyleBackColor = true;
            // 
            // Panel3
            // 
            Panel3.BorderStyle = BorderStyle.Fixed3D;
            Panel3.Controls.Add(GroupBox2);
            Panel3.Dock = DockStyle.Fill;
            Panel3.Location = new Point(4, 5);
            Panel3.Margin = new Padding(4, 5, 4, 5);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(169, 325);
            Panel3.TabIndex = 2;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(Mod1None);
            GroupBox2.Controls.Add(Mod1UT1200);
            GroupBox2.Controls.Add(Mod1UT440);
            GroupBox2.Controls.Add(Mod1UT30);
            GroupBox2.Controls.Add(Mod1UT220);
            GroupBox2.Controls.Add(Mod1UT50);
            GroupBox2.Controls.Add(Mod1UT144);
            GroupBox2.Location = new Point(22, 32);
            GroupBox2.Margin = new Padding(4, 5, 4, 5);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Padding = new Padding(4, 5, 4, 5);
            GroupBox2.Size = new Size(146, 288);
            GroupBox2.TabIndex = 1;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Module 1";
            // 
            // Mod1None
            // 
            Mod1None.AutoSize = true;
            Mod1None.Location = new Point(40, 29);
            Mod1None.Margin = new Padding(4, 5, 4, 5);
            Mod1None.Name = "Mod1None";
            Mod1None.Size = new Size(72, 24);
            Mod1None.TabIndex = 6;
            Mod1None.TabStop = true;
            Mod1None.Text = "None";
            Mod1None.UseVisualStyleBackColor = true;
            // 
            // Mod1UT1200
            // 
            Mod1UT1200.AutoSize = true;
            Mod1UT1200.Location = new Point(40, 242);
            Mod1UT1200.Margin = new Padding(4, 5, 4, 5);
            Mod1UT1200.Name = "Mod1UT1200";
            Mod1UT1200.Size = new Size(95, 24);
            Mod1UT1200.TabIndex = 5;
            Mod1UT1200.TabStop = true;
            Mod1UT1200.Text = "UT 1200";
            Mod1UT1200.UseVisualStyleBackColor = true;
            // 
            // Mod1UT440
            // 
            Mod1UT440.AutoSize = true;
            Mod1UT440.Location = new Point(40, 206);
            Mod1UT440.Margin = new Padding(4, 5, 4, 5);
            Mod1UT440.Name = "Mod1UT440";
            Mod1UT440.Size = new Size(86, 24);
            Mod1UT440.TabIndex = 4;
            Mod1UT440.TabStop = true;
            Mod1UT440.Text = "UT 440";
            Mod1UT440.UseVisualStyleBackColor = true;
            // 
            // Mod1UT30
            // 
            Mod1UT30.AutoSize = true;
            Mod1UT30.Location = new Point(40, 65);
            Mod1UT30.Margin = new Padding(4, 5, 4, 5);
            Mod1UT30.Name = "Mod1UT30";
            Mod1UT30.Size = new Size(77, 24);
            Mod1UT30.TabIndex = 0;
            Mod1UT30.TabStop = true;
            Mod1UT30.Text = "UT 30";
            Mod1UT30.UseVisualStyleBackColor = true;
            // 
            // Mod1UT220
            // 
            Mod1UT220.AutoSize = true;
            Mod1UT220.Location = new Point(40, 171);
            Mod1UT220.Margin = new Padding(4, 5, 4, 5);
            Mod1UT220.Name = "Mod1UT220";
            Mod1UT220.Size = new Size(86, 24);
            Mod1UT220.TabIndex = 3;
            Mod1UT220.TabStop = true;
            Mod1UT220.Text = "UT 220";
            Mod1UT220.UseVisualStyleBackColor = true;
            // 
            // Mod1UT50
            // 
            Mod1UT50.AutoSize = true;
            Mod1UT50.Location = new Point(40, 100);
            Mod1UT50.Margin = new Padding(4, 5, 4, 5);
            Mod1UT50.Name = "Mod1UT50";
            Mod1UT50.Size = new Size(77, 24);
            Mod1UT50.TabIndex = 1;
            Mod1UT50.TabStop = true;
            Mod1UT50.Text = "UT 50";
            Mod1UT50.UseVisualStyleBackColor = true;
            // 
            // Mod1UT144
            // 
            Mod1UT144.AutoSize = true;
            Mod1UT144.Location = new Point(40, 135);
            Mod1UT144.Margin = new Padding(4, 5, 4, 5);
            Mod1UT144.Name = "Mod1UT144";
            Mod1UT144.Size = new Size(86, 24);
            Mod1UT144.TabIndex = 2;
            Mod1UT144.TabStop = true;
            Mod1UT144.Text = "UT 144";
            Mod1UT144.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            Panel1.BorderStyle = BorderStyle.Fixed3D;
            Panel1.Controls.Add(GroupBox3);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(357, 5);
            Panel1.Margin = new Padding(4, 5, 4, 5);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(204, 325);
            Panel1.TabIndex = 3;
            // 
            // GroupBox3
            // 
            GroupBox3.Controls.Add(Mod3None);
            GroupBox3.Controls.Add(Mod3UT1200);
            GroupBox3.Controls.Add(Mod3UT440);
            GroupBox3.Controls.Add(Mod3UT30);
            GroupBox3.Controls.Add(Mod3UT220);
            GroupBox3.Controls.Add(Mod3UT50);
            GroupBox3.Controls.Add(Mod3UT144);
            GroupBox3.Location = new Point(27, 32);
            GroupBox3.Margin = new Padding(4, 5, 4, 5);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Padding = new Padding(4, 5, 4, 5);
            GroupBox3.Size = new Size(146, 288);
            GroupBox3.TabIndex = 3;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "Module 3";
            // 
            // Mod3None
            // 
            Mod3None.AutoSize = true;
            Mod3None.Location = new Point(40, 29);
            Mod3None.Margin = new Padding(4, 5, 4, 5);
            Mod3None.Name = "Mod3None";
            Mod3None.Size = new Size(72, 24);
            Mod3None.TabIndex = 6;
            Mod3None.TabStop = true;
            Mod3None.Text = "None";
            Mod3None.UseVisualStyleBackColor = true;
            // 
            // Mod3UT1200
            // 
            Mod3UT1200.AutoSize = true;
            Mod3UT1200.Location = new Point(40, 242);
            Mod3UT1200.Margin = new Padding(4, 5, 4, 5);
            Mod3UT1200.Name = "Mod3UT1200";
            Mod3UT1200.Size = new Size(95, 24);
            Mod3UT1200.TabIndex = 5;
            Mod3UT1200.TabStop = true;
            Mod3UT1200.Text = "UT 1200";
            Mod3UT1200.UseVisualStyleBackColor = true;
            // 
            // Mod3UT440
            // 
            Mod3UT440.AutoSize = true;
            Mod3UT440.Location = new Point(40, 206);
            Mod3UT440.Margin = new Padding(4, 5, 4, 5);
            Mod3UT440.Name = "Mod3UT440";
            Mod3UT440.Size = new Size(86, 24);
            Mod3UT440.TabIndex = 4;
            Mod3UT440.TabStop = true;
            Mod3UT440.Text = "UT 440";
            Mod3UT440.UseVisualStyleBackColor = true;
            // 
            // Mod3UT30
            // 
            Mod3UT30.AutoSize = true;
            Mod3UT30.Location = new Point(40, 65);
            Mod3UT30.Margin = new Padding(4, 5, 4, 5);
            Mod3UT30.Name = "Mod3UT30";
            Mod3UT30.Size = new Size(77, 24);
            Mod3UT30.TabIndex = 0;
            Mod3UT30.TabStop = true;
            Mod3UT30.Text = "UT 30";
            Mod3UT30.UseVisualStyleBackColor = true;
            // 
            // Mod3UT220
            // 
            Mod3UT220.AutoSize = true;
            Mod3UT220.Location = new Point(40, 171);
            Mod3UT220.Margin = new Padding(4, 5, 4, 5);
            Mod3UT220.Name = "Mod3UT220";
            Mod3UT220.Size = new Size(86, 24);
            Mod3UT220.TabIndex = 3;
            Mod3UT220.TabStop = true;
            Mod3UT220.Text = "UT 220";
            Mod3UT220.UseVisualStyleBackColor = true;
            // 
            // Mod3UT50
            // 
            Mod3UT50.AutoSize = true;
            Mod3UT50.Location = new Point(40, 100);
            Mod3UT50.Margin = new Padding(4, 5, 4, 5);
            Mod3UT50.Name = "Mod3UT50";
            Mod3UT50.Size = new Size(77, 24);
            Mod3UT50.TabIndex = 1;
            Mod3UT50.TabStop = true;
            Mod3UT50.Text = "UT 50";
            Mod3UT50.UseVisualStyleBackColor = true;
            // 
            // Mod3UT144
            // 
            Mod3UT144.AutoSize = true;
            Mod3UT144.Location = new Point(40, 135);
            Mod3UT144.Margin = new Padding(4, 5, 4, 5);
            Mod3UT144.Name = "Mod3UT144";
            Mod3UT144.Size = new Size(86, 24);
            Mod3UT144.TabIndex = 2;
            Mod3UT144.TabStop = true;
            Mod3UT144.Text = "UT 144";
            Mod3UT144.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel3
            // 
            TableLayoutPanel3.ColumnCount = 2;
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.61702f));
            TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.38298f));
            TableLayoutPanel3.Controls.Add(Panel5, 0, 0);
            TableLayoutPanel3.Controls.Add(Panel6, 1, 0);
            TableLayoutPanel3.Dock = DockStyle.Fill;
            TableLayoutPanel3.Location = new Point(4, 350);
            TableLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
            TableLayoutPanel3.Name = "TableLayoutPanel3";
            TableLayoutPanel3.RowCount = 1;
            TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel3.Size = new Size(565, 237);
            TableLayoutPanel3.TabIndex = 1;
            // 
            // Panel5
            // 
            Panel5.Controls.Add(GroupBox5);
            Panel5.Controls.Add(GroupBox4);
            Panel5.Dock = DockStyle.Fill;
            Panel5.Location = new Point(4, 5);
            Panel5.Margin = new Padding(4, 5, 4, 5);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(379, 227);
            Panel5.TabIndex = 0;
            // 
            // GroupBox5
            // 
            GroupBox5.Controls.Add(debugRadioTimingButton);
            GroupBox5.Controls.Add(slowRadioTimingButton);
            GroupBox5.Controls.Add(normalRadioTimingButton);
            GroupBox5.Location = new Point(192, 6);
            GroupBox5.Margin = new Padding(4, 5, 4, 5);
            GroupBox5.Name = "GroupBox5";
            GroupBox5.Padding = new Padding(4, 5, 4, 5);
            GroupBox5.Size = new Size(138, 154);
            GroupBox5.TabIndex = 1;
            GroupBox5.TabStop = false;
            GroupBox5.Text = "Radio Timing";
            // 
            // debugRadioTimingButton
            // 
            debugRadioTimingButton.AutoSize = true;
            debugRadioTimingButton.Location = new Point(15, 102);
            debugRadioTimingButton.Margin = new Padding(4, 5, 4, 5);
            debugRadioTimingButton.Name = "debugRadioTimingButton";
            debugRadioTimingButton.Size = new Size(82, 24);
            debugRadioTimingButton.TabIndex = 2;
            debugRadioTimingButton.TabStop = true;
            debugRadioTimingButton.Text = "Debug";
            debugRadioTimingButton.UseVisualStyleBackColor = true;
            // 
            // slowRadioTimingButton
            // 
            slowRadioTimingButton.AutoSize = true;
            slowRadioTimingButton.Location = new Point(15, 66);
            slowRadioTimingButton.Margin = new Padding(4, 5, 4, 5);
            slowRadioTimingButton.Name = "slowRadioTimingButton";
            slowRadioTimingButton.Size = new Size(68, 24);
            slowRadioTimingButton.TabIndex = 1;
            slowRadioTimingButton.TabStop = true;
            slowRadioTimingButton.Text = "Slow";
            slowRadioTimingButton.UseVisualStyleBackColor = true;
            // 
            // normalRadioTimingButton
            // 
            normalRadioTimingButton.AutoSize = true;
            normalRadioTimingButton.Checked = true;
            normalRadioTimingButton.Location = new Point(15, 31);
            normalRadioTimingButton.Margin = new Padding(4, 5, 4, 5);
            normalRadioTimingButton.Name = "normalRadioTimingButton";
            normalRadioTimingButton.Size = new Size(84, 24);
            normalRadioTimingButton.TabIndex = 0;
            normalRadioTimingButton.TabStop = true;
            normalRadioTimingButton.Text = "Normal";
            normalRadioTimingButton.UseVisualStyleBackColor = true;
            // 
            // GroupBox4
            // 
            GroupBox4.Controls.Add(AROcheckBox);
            GroupBox4.Controls.Add(wideBandCheckBox);
            GroupBox4.Controls.Add(eTypeRadioCheckBox);
            GroupBox4.Controls.Add(Tsu7CheckBox);
            GroupBox4.Location = new Point(9, 6);
            GroupBox4.Margin = new Padding(4, 5, 4, 5);
            GroupBox4.Name = "GroupBox4";
            GroupBox4.Padding = new Padding(4, 5, 4, 5);
            GroupBox4.Size = new Size(174, 194);
            GroupBox4.TabIndex = 0;
            GroupBox4.TabStop = false;
            GroupBox4.Text = "Radio Options";
            // 
            // AROcheckBox
            // 
            AROcheckBox.Location = new Point(10, 137);
            AROcheckBox.Margin = new Padding(4, 5, 4, 5);
            AROcheckBox.Name = "AROcheckBox";
            AROcheckBox.Size = new Size(156, 48);
            AROcheckBox.TabIndex = 4;
            AROcheckBox.Text = "Automatic Repeater Offset";
            AROcheckBox.UseVisualStyleBackColor = true;
            // 
            // wideBandCheckBox
            // 
            wideBandCheckBox.AutoSize = true;
            wideBandCheckBox.Location = new Point(10, 111);
            wideBandCheckBox.Margin = new Padding(4, 5, 4, 5);
            wideBandCheckBox.Name = "wideBandCheckBox";
            wideBandCheckBox.Size = new Size(113, 24);
            wideBandCheckBox.TabIndex = 3;
            wideBandCheckBox.Text = "Wide Band";
            wideBandCheckBox.UseVisualStyleBackColor = true;
            // 
            // eTypeRadioCheckBox
            // 
            eTypeRadioCheckBox.AutoSize = true;
            eTypeRadioCheckBox.Location = new Point(10, 78);
            eTypeRadioCheckBox.Margin = new Padding(4, 5, 4, 5);
            eTypeRadioCheckBox.Name = "eTypeRadioCheckBox";
            eTypeRadioCheckBox.Size = new Size(136, 24);
            eTypeRadioCheckBox.TabIndex = 2;
            eTypeRadioCheckBox.Text = "'E' Type Radio";
            eTypeRadioCheckBox.UseVisualStyleBackColor = true;
            // 
            // Tsu7CheckBox
            // 
            Tsu7CheckBox.AutoSize = true;
            Tsu7CheckBox.Location = new Point(10, 45);
            Tsu7CheckBox.Margin = new Padding(4, 5, 4, 5);
            Tsu7CheckBox.Name = "Tsu7CheckBox";
            Tsu7CheckBox.Size = new Size(145, 24);
            Tsu7CheckBox.TabIndex = 0;
            Tsu7CheckBox.Text = "TSU-7 Installed";
            Tsu7CheckBox.UseVisualStyleBackColor = true;
            // 
            // Panel6
            // 
            Panel6.Controls.Add(Panel4);
            Panel6.Dock = DockStyle.Fill;
            Panel6.Location = new Point(391, 5);
            Panel6.Margin = new Padding(4, 5, 4, 5);
            Panel6.Name = "Panel6";
            Panel6.Size = new Size(170, 227);
            Panel6.TabIndex = 1;
            // 
            // Panel4
            // 
            Panel4.BorderStyle = BorderStyle.Fixed3D;
            Panel4.Controls.Add(ChannelLists);
            Panel4.Dock = DockStyle.Fill;
            Panel4.Location = new Point(0, 0);
            Panel4.Margin = new Padding(4, 5, 4, 5);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(170, 227);
            Panel4.TabIndex = 1;
            // 
            // ChannelLists
            // 
            ChannelLists.Location = new Point(27, 71);
            ChannelLists.Margin = new Padding(4, 5, 4, 5);
            ChannelLists.Name = "ChannelLists";
            ChannelLists.Size = new Size(117, 60);
            ChannelLists.TabIndex = 2;
            ChannelLists.Text = "Go To Channel Lists";
            ChannelLists.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 592);
            Controls.Add(TableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Radio Configuration (Version 1.1)";
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel2.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            Panel3.ResumeLayout(false);
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            Panel1.ResumeLayout(false);
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            TableLayoutPanel3.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            GroupBox5.ResumeLayout(false);
            GroupBox5.PerformLayout();
            GroupBox4.ResumeLayout(false);
            GroupBox4.PerformLayout();
            Panel6.ResumeLayout(false);
            Panel4.ResumeLayout(false);
            Load += new EventHandler(Form2_Load);
            FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            ResumeLayout(false);

        }
        internal TableLayoutPanel TableLayoutPanel1;
        internal TableLayoutPanel TableLayoutPanel2;
        internal Panel Panel2;
        internal Panel Panel3;
        internal Panel Panel4;
        internal GroupBox GroupBox2;
        internal RadioButton Mod1UT1200;
        internal RadioButton Mod1UT440;
        internal RadioButton Mod1UT30;
        internal RadioButton Mod1UT220;
        internal RadioButton Mod1UT50;
        internal RadioButton Mod1UT144;
        internal RadioButton Mod1None;
        internal GroupBox GroupBox1;
        internal RadioButton Mod2None;
        internal RadioButton Mod2UT1200;
        internal RadioButton Mod2UT440;
        internal RadioButton Mod2UT30;
        internal RadioButton Mod2UT220;
        internal RadioButton Mod2UT50;
        internal RadioButton Mod2UT144;
        internal Panel Panel1;
        internal GroupBox GroupBox3;
        internal RadioButton Mod3None;
        internal RadioButton Mod3UT1200;
        internal RadioButton Mod3UT440;
        internal RadioButton Mod3UT30;
        internal RadioButton Mod3UT220;
        internal RadioButton Mod3UT50;
        internal RadioButton Mod3UT144;
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
    }
}