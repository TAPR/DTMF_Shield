
namespace Radio
{
    partial class ModuleSelectorControl
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
            this.comboBoxModuleType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxModuleType
            // 
            this.comboBoxModuleType.FormattingEnabled = true;
            this.comboBoxModuleType.Location = new System.Drawing.Point(0, 4);
            this.comboBoxModuleType.Name = "comboBoxModuleType";
            this.comboBoxModuleType.Size = new System.Drawing.Size(147, 28);
            this.comboBoxModuleType.TabIndex = 0;
            // 
            // ModuleSelectorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxModuleType);
            this.Name = "ModuleSelectorControl";
            this.Size = new System.Drawing.Size(150, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxModuleType;
    }
}
