namespace projNumberSystemsConverter
{
    partial class frmHelp
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
            this.btnOk_Help = new System.Windows.Forms.Button();
            this.lstHelp = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOk_Help
            // 
            this.btnOk_Help.Location = new System.Drawing.Point(215, 289);
            this.btnOk_Help.Name = "btnOk_Help";
            this.btnOk_Help.Size = new System.Drawing.Size(75, 23);
            this.btnOk_Help.TabIndex = 2;
            this.btnOk_Help.Text = "Ok";
            this.btnOk_Help.UseVisualStyleBackColor = true;
            this.btnOk_Help.Click += new System.EventHandler(this.btnOk_Help_Click);
            // 
            // lstHelp
            // 
            this.lstHelp.FormattingEnabled = true;
            this.lstHelp.Location = new System.Drawing.Point(13, 18);
            this.lstHelp.Name = "lstHelp";
            this.lstHelp.Size = new System.Drawing.Size(509, 264);
            this.lstHelp.TabIndex = 1;
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 331);
            this.Controls.Add(this.btnOk_Help);
            this.Controls.Add(this.lstHelp);
            this.Name = "frmHelp";
            this.Text = "frmHelp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk_Help;
        private System.Windows.Forms.ListBox lstHelp;
    }
}