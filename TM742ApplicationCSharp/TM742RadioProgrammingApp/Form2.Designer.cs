using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Radio
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Mod2None = new System.Windows.Forms.RadioButton();
            this.Mod2UT1200 = new System.Windows.Forms.RadioButton();
            this.Mod2UT440 = new System.Windows.Forms.RadioButton();
            this.Mod2UT30 = new System.Windows.Forms.RadioButton();
            this.Mod2UT220 = new System.Windows.Forms.RadioButton();
            this.Mod2UT50 = new System.Windows.Forms.RadioButton();
            this.Mod2UT144 = new System.Windows.Forms.RadioButton();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Mod1None = new System.Windows.Forms.RadioButton();
            this.Mod1UT1200 = new System.Windows.Forms.RadioButton();
            this.Mod1UT440 = new System.Windows.Forms.RadioButton();
            this.Mod1UT30 = new System.Windows.Forms.RadioButton();
            this.Mod1UT220 = new System.Windows.Forms.RadioButton();
            this.Mod1UT50 = new System.Windows.Forms.RadioButton();
            this.Mod1UT144 = new System.Windows.Forms.RadioButton();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Mod3None = new System.Windows.Forms.RadioButton();
            this.Mod3UT1200 = new System.Windows.Forms.RadioButton();
            this.Mod3UT440 = new System.Windows.Forms.RadioButton();
            this.Mod3UT30 = new System.Windows.Forms.RadioButton();
            this.Mod3UT220 = new System.Windows.Forms.RadioButton();
            this.Mod3UT50 = new System.Windows.Forms.RadioButton();
            this.Mod3UT144 = new System.Windows.Forms.RadioButton();
            this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.debugRadioTimingButton = new System.Windows.Forms.RadioButton();
            this.slowRadioTimingButton = new System.Windows.Forms.RadioButton();
            this.normalRadioTimingButton = new System.Windows.Forms.RadioButton();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.AROcheckBox = new System.Windows.Forms.CheckBox();
            this.wideBandCheckBox = new System.Windows.Forms.CheckBox();
            this.eTypeRadioCheckBox = new System.Windows.Forms.CheckBox();
            this.Tsu7CheckBox = new System.Windows.Forms.CheckBox();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.ChannelLists = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.44156F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.55844F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(573, 592);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.ColumnCount = 3;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.17544F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.82456F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.TableLayoutPanel2.Controls.Add(this.Panel2, 1, 0);
            this.TableLayoutPanel2.Controls.Add(this.Panel3, 0, 0);
            this.TableLayoutPanel2.Controls.Add(this.Panel1, 2, 0);
            this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel2.Location = new System.Drawing.Point(4, 5);
            this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 1;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(565, 335);
            this.TableLayoutPanel2.TabIndex = 0;
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel2.Controls.Add(this.GroupBox1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(180, 5);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(167, 325);
            this.Panel2.TabIndex = 1;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Mod2None);
            this.GroupBox1.Controls.Add(this.Mod2UT1200);
            this.GroupBox1.Controls.Add(this.Mod2UT440);
            this.GroupBox1.Controls.Add(this.Mod2UT30);
            this.GroupBox1.Controls.Add(this.Mod2UT220);
            this.GroupBox1.Controls.Add(this.Mod2UT50);
            this.GroupBox1.Controls.Add(this.Mod2UT144);
            this.GroupBox1.Location = new System.Drawing.Point(24, 32);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Size = new System.Drawing.Size(146, 288);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Module 2";
            // 
            // Mod2None
            // 
            this.Mod2None.AutoSize = true;
            this.Mod2None.Location = new System.Drawing.Point(40, 29);
            this.Mod2None.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod2None.Name = "Mod2None";
            this.Mod2None.Size = new System.Drawing.Size(72, 24);
            this.Mod2None.TabIndex = 6;
            this.Mod2None.TabStop = true;
            this.Mod2None.Text = "None";
            this.Mod2None.UseVisualStyleBackColor = true;
            // 
            // Mod2UT1200
            // 
            this.Mod2UT1200.AutoSize = true;
            this.Mod2UT1200.Location = new System.Drawing.Point(40, 242);
            this.Mod2UT1200.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod2UT1200.Name = "Mod2UT1200";
            this.Mod2UT1200.Size = new System.Drawing.Size(95, 24);
            this.Mod2UT1200.TabIndex = 5;
            this.Mod2UT1200.TabStop = true;
            this.Mod2UT1200.Text = "UT 1200";
            this.Mod2UT1200.UseVisualStyleBackColor = true;
            // 
            // Mod2UT440
            // 
            this.Mod2UT440.AutoSize = true;
            this.Mod2UT440.Location = new System.Drawing.Point(40, 206);
            this.Mod2UT440.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod2UT440.Name = "Mod2UT440";
            this.Mod2UT440.Size = new System.Drawing.Size(86, 24);
            this.Mod2UT440.TabIndex = 4;
            this.Mod2UT440.TabStop = true;
            this.Mod2UT440.Text = "UT 440";
            this.Mod2UT440.UseVisualStyleBackColor = true;
            // 
            // Mod2UT30
            // 
            this.Mod2UT30.AutoSize = true;
            this.Mod2UT30.Location = new System.Drawing.Point(40, 65);
            this.Mod2UT30.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod2UT30.Name = "Mod2UT30";
            this.Mod2UT30.Size = new System.Drawing.Size(77, 24);
            this.Mod2UT30.TabIndex = 0;
            this.Mod2UT30.TabStop = true;
            this.Mod2UT30.Text = "UT 30";
            this.Mod2UT30.UseVisualStyleBackColor = true;
            // 
            // Mod2UT220
            // 
            this.Mod2UT220.AutoSize = true;
            this.Mod2UT220.Location = new System.Drawing.Point(40, 171);
            this.Mod2UT220.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod2UT220.Name = "Mod2UT220";
            this.Mod2UT220.Size = new System.Drawing.Size(86, 24);
            this.Mod2UT220.TabIndex = 3;
            this.Mod2UT220.TabStop = true;
            this.Mod2UT220.Text = "UT 220";
            this.Mod2UT220.UseVisualStyleBackColor = true;
            // 
            // Mod2UT50
            // 
            this.Mod2UT50.AutoSize = true;
            this.Mod2UT50.Location = new System.Drawing.Point(40, 100);
            this.Mod2UT50.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod2UT50.Name = "Mod2UT50";
            this.Mod2UT50.Size = new System.Drawing.Size(77, 24);
            this.Mod2UT50.TabIndex = 1;
            this.Mod2UT50.TabStop = true;
            this.Mod2UT50.Text = "UT 50";
            this.Mod2UT50.UseVisualStyleBackColor = true;
            // 
            // Mod2UT144
            // 
            this.Mod2UT144.AutoSize = true;
            this.Mod2UT144.Location = new System.Drawing.Point(40, 135);
            this.Mod2UT144.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod2UT144.Name = "Mod2UT144";
            this.Mod2UT144.Size = new System.Drawing.Size(86, 24);
            this.Mod2UT144.TabIndex = 2;
            this.Mod2UT144.TabStop = true;
            this.Mod2UT144.Text = "UT 144";
            this.Mod2UT144.UseVisualStyleBackColor = true;
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel3.Controls.Add(this.GroupBox2);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(4, 5);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(168, 325);
            this.Panel3.TabIndex = 2;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Mod1None);
            this.GroupBox2.Controls.Add(this.Mod1UT1200);
            this.GroupBox2.Controls.Add(this.Mod1UT440);
            this.GroupBox2.Controls.Add(this.Mod1UT30);
            this.GroupBox2.Controls.Add(this.Mod1UT220);
            this.GroupBox2.Controls.Add(this.Mod1UT50);
            this.GroupBox2.Controls.Add(this.Mod1UT144);
            this.GroupBox2.Location = new System.Drawing.Point(22, 32);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Size = new System.Drawing.Size(146, 288);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Module 1";
            // 
            // Mod1None
            // 
            this.Mod1None.AutoSize = true;
            this.Mod1None.Location = new System.Drawing.Point(40, 29);
            this.Mod1None.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod1None.Name = "Mod1None";
            this.Mod1None.Size = new System.Drawing.Size(72, 24);
            this.Mod1None.TabIndex = 6;
            this.Mod1None.TabStop = true;
            this.Mod1None.Text = "None";
            this.Mod1None.UseVisualStyleBackColor = true;
            // 
            // Mod1UT1200
            // 
            this.Mod1UT1200.AutoSize = true;
            this.Mod1UT1200.Location = new System.Drawing.Point(40, 242);
            this.Mod1UT1200.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod1UT1200.Name = "Mod1UT1200";
            this.Mod1UT1200.Size = new System.Drawing.Size(95, 24);
            this.Mod1UT1200.TabIndex = 5;
            this.Mod1UT1200.TabStop = true;
            this.Mod1UT1200.Text = "UT 1200";
            this.Mod1UT1200.UseVisualStyleBackColor = true;
            // 
            // Mod1UT440
            // 
            this.Mod1UT440.AutoSize = true;
            this.Mod1UT440.Location = new System.Drawing.Point(40, 206);
            this.Mod1UT440.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod1UT440.Name = "Mod1UT440";
            this.Mod1UT440.Size = new System.Drawing.Size(86, 24);
            this.Mod1UT440.TabIndex = 4;
            this.Mod1UT440.TabStop = true;
            this.Mod1UT440.Text = "UT 440";
            this.Mod1UT440.UseVisualStyleBackColor = true;
            // 
            // Mod1UT30
            // 
            this.Mod1UT30.AutoSize = true;
            this.Mod1UT30.Location = new System.Drawing.Point(40, 65);
            this.Mod1UT30.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod1UT30.Name = "Mod1UT30";
            this.Mod1UT30.Size = new System.Drawing.Size(77, 24);
            this.Mod1UT30.TabIndex = 0;
            this.Mod1UT30.TabStop = true;
            this.Mod1UT30.Text = "UT 30";
            this.Mod1UT30.UseVisualStyleBackColor = true;
            // 
            // Mod1UT220
            // 
            this.Mod1UT220.AutoSize = true;
            this.Mod1UT220.Location = new System.Drawing.Point(40, 171);
            this.Mod1UT220.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod1UT220.Name = "Mod1UT220";
            this.Mod1UT220.Size = new System.Drawing.Size(86, 24);
            this.Mod1UT220.TabIndex = 3;
            this.Mod1UT220.TabStop = true;
            this.Mod1UT220.Text = "UT 220";
            this.Mod1UT220.UseVisualStyleBackColor = true;
            // 
            // Mod1UT50
            // 
            this.Mod1UT50.AutoSize = true;
            this.Mod1UT50.Location = new System.Drawing.Point(40, 100);
            this.Mod1UT50.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod1UT50.Name = "Mod1UT50";
            this.Mod1UT50.Size = new System.Drawing.Size(77, 24);
            this.Mod1UT50.TabIndex = 1;
            this.Mod1UT50.TabStop = true;
            this.Mod1UT50.Text = "UT 50";
            this.Mod1UT50.UseVisualStyleBackColor = true;
            // 
            // Mod1UT144
            // 
            this.Mod1UT144.AutoSize = true;
            this.Mod1UT144.Location = new System.Drawing.Point(40, 135);
            this.Mod1UT144.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod1UT144.Name = "Mod1UT144";
            this.Mod1UT144.Size = new System.Drawing.Size(86, 24);
            this.Mod1UT144.TabIndex = 2;
            this.Mod1UT144.TabStop = true;
            this.Mod1UT144.Text = "UT 144";
            this.Mod1UT144.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.GroupBox3);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(355, 5);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(206, 325);
            this.Panel1.TabIndex = 3;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Mod3None);
            this.GroupBox3.Controls.Add(this.Mod3UT1200);
            this.GroupBox3.Controls.Add(this.Mod3UT440);
            this.GroupBox3.Controls.Add(this.Mod3UT30);
            this.GroupBox3.Controls.Add(this.Mod3UT220);
            this.GroupBox3.Controls.Add(this.Mod3UT50);
            this.GroupBox3.Controls.Add(this.Mod3UT144);
            this.GroupBox3.Location = new System.Drawing.Point(27, 32);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox3.Size = new System.Drawing.Size(146, 288);
            this.GroupBox3.TabIndex = 3;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Module 3";
            // 
            // Mod3None
            // 
            this.Mod3None.AutoSize = true;
            this.Mod3None.Location = new System.Drawing.Point(40, 29);
            this.Mod3None.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod3None.Name = "Mod3None";
            this.Mod3None.Size = new System.Drawing.Size(72, 24);
            this.Mod3None.TabIndex = 6;
            this.Mod3None.TabStop = true;
            this.Mod3None.Text = "None";
            this.Mod3None.UseVisualStyleBackColor = true;
            // 
            // Mod3UT1200
            // 
            this.Mod3UT1200.AutoSize = true;
            this.Mod3UT1200.Location = new System.Drawing.Point(40, 242);
            this.Mod3UT1200.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod3UT1200.Name = "Mod3UT1200";
            this.Mod3UT1200.Size = new System.Drawing.Size(95, 24);
            this.Mod3UT1200.TabIndex = 5;
            this.Mod3UT1200.TabStop = true;
            this.Mod3UT1200.Text = "UT 1200";
            this.Mod3UT1200.UseVisualStyleBackColor = true;
            // 
            // Mod3UT440
            // 
            this.Mod3UT440.AutoSize = true;
            this.Mod3UT440.Location = new System.Drawing.Point(40, 206);
            this.Mod3UT440.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod3UT440.Name = "Mod3UT440";
            this.Mod3UT440.Size = new System.Drawing.Size(86, 24);
            this.Mod3UT440.TabIndex = 4;
            this.Mod3UT440.TabStop = true;
            this.Mod3UT440.Text = "UT 440";
            this.Mod3UT440.UseVisualStyleBackColor = true;
            // 
            // Mod3UT30
            // 
            this.Mod3UT30.AutoSize = true;
            this.Mod3UT30.Location = new System.Drawing.Point(40, 65);
            this.Mod3UT30.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod3UT30.Name = "Mod3UT30";
            this.Mod3UT30.Size = new System.Drawing.Size(77, 24);
            this.Mod3UT30.TabIndex = 0;
            this.Mod3UT30.TabStop = true;
            this.Mod3UT30.Text = "UT 30";
            this.Mod3UT30.UseVisualStyleBackColor = true;
            // 
            // Mod3UT220
            // 
            this.Mod3UT220.AutoSize = true;
            this.Mod3UT220.Location = new System.Drawing.Point(40, 171);
            this.Mod3UT220.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod3UT220.Name = "Mod3UT220";
            this.Mod3UT220.Size = new System.Drawing.Size(86, 24);
            this.Mod3UT220.TabIndex = 3;
            this.Mod3UT220.TabStop = true;
            this.Mod3UT220.Text = "UT 220";
            this.Mod3UT220.UseVisualStyleBackColor = true;
            // 
            // Mod3UT50
            // 
            this.Mod3UT50.AutoSize = true;
            this.Mod3UT50.Location = new System.Drawing.Point(40, 100);
            this.Mod3UT50.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod3UT50.Name = "Mod3UT50";
            this.Mod3UT50.Size = new System.Drawing.Size(77, 24);
            this.Mod3UT50.TabIndex = 1;
            this.Mod3UT50.TabStop = true;
            this.Mod3UT50.Text = "UT 50";
            this.Mod3UT50.UseVisualStyleBackColor = true;
            // 
            // Mod3UT144
            // 
            this.Mod3UT144.AutoSize = true;
            this.Mod3UT144.Location = new System.Drawing.Point(40, 135);
            this.Mod3UT144.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mod3UT144.Name = "Mod3UT144";
            this.Mod3UT144.Size = new System.Drawing.Size(86, 24);
            this.Mod3UT144.TabIndex = 2;
            this.Mod3UT144.TabStop = true;
            this.Mod3UT144.Text = "UT 144";
            this.Mod3UT144.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel3
            // 
            this.TableLayoutPanel3.ColumnCount = 2;
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.61702F));
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.38298F));
            this.TableLayoutPanel3.Controls.Add(this.Panel5, 0, 0);
            this.TableLayoutPanel3.Controls.Add(this.Panel6, 1, 0);
            this.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel3.Location = new System.Drawing.Point(4, 350);
            this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 1;
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel3.Size = new System.Drawing.Size(565, 237);
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
            this.Panel5.Size = new System.Drawing.Size(379, 227);
            this.Panel5.TabIndex = 0;
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.debugRadioTimingButton);
            this.GroupBox5.Controls.Add(this.slowRadioTimingButton);
            this.GroupBox5.Controls.Add(this.normalRadioTimingButton);
            this.GroupBox5.Location = new System.Drawing.Point(192, 6);
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
            this.debugRadioTimingButton.UseVisualStyleBackColor = true;
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
            this.slowRadioTimingButton.UseVisualStyleBackColor = true;
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
            this.normalRadioTimingButton.UseVisualStyleBackColor = true;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.AROcheckBox);
            this.GroupBox4.Controls.Add(this.wideBandCheckBox);
            this.GroupBox4.Controls.Add(this.eTypeRadioCheckBox);
            this.GroupBox4.Controls.Add(this.Tsu7CheckBox);
            this.GroupBox4.Location = new System.Drawing.Point(9, 6);
            this.GroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox4.Size = new System.Drawing.Size(174, 194);
            this.GroupBox4.TabIndex = 0;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Radio Options";
            // 
            // AROcheckBox
            // 
            this.AROcheckBox.Location = new System.Drawing.Point(10, 137);
            this.AROcheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AROcheckBox.Name = "AROcheckBox";
            this.AROcheckBox.Size = new System.Drawing.Size(156, 48);
            this.AROcheckBox.TabIndex = 4;
            this.AROcheckBox.Text = "Automatic Repeater Offset";
            this.AROcheckBox.UseVisualStyleBackColor = true;
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
            this.wideBandCheckBox.UseVisualStyleBackColor = true;
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
            this.Tsu7CheckBox.UseVisualStyleBackColor = true;
            // 
            // Panel6
            // 
            this.Panel6.Controls.Add(this.Panel4);
            this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel6.Location = new System.Drawing.Point(391, 5);
            this.Panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(170, 227);
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
            this.Panel4.Size = new System.Drawing.Size(170, 227);
            this.Panel4.TabIndex = 1;
            // 
            // ChannelLists
            // 
            this.ChannelLists.Location = new System.Drawing.Point(27, 71);
            this.ChannelLists.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChannelLists.Name = "ChannelLists";
            this.ChannelLists.Size = new System.Drawing.Size(117, 60);
            this.ChannelLists.TabIndex = 2;
            this.ChannelLists.Text = "Go To Channel Lists";
            this.ChannelLists.UseVisualStyleBackColor = true;
            this.ChannelLists.Click += new System.EventHandler(this.ShowChannelLists_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 592);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Radio Configuration (Version 1.2)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel2.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
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