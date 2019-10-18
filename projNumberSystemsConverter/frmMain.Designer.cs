namespace projNumberSystemsConverter
{
    partial class frmMain
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExplanation = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtConvertTo = new System.Windows.Forms.TextBox();
            this.cboConvertTo = new System.Windows.Forms.ComboBox();
            this.txtConvertFrom = new System.Windows.Forms.TextBox();
            this.lblConvertTo = new System.Windows.Forms.Label();
            this.lblConvertFrom = new System.Windows.Forms.Label();
            this.cboConvertFrom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(150, 128);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExplanation
            // 
            this.btnExplanation.Location = new System.Drawing.Point(268, 128);
            this.btnExplanation.Name = "btnExplanation";
            this.btnExplanation.Size = new System.Drawing.Size(75, 23);
            this.btnExplanation.TabIndex = 8;
            this.btnExplanation.Text = "Explanation";
            this.btnExplanation.UseVisualStyleBackColor = true;
            this.btnExplanation.Click += new System.EventHandler(this.btnExplanation_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(268, 181);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(143, 181);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(24, 181);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtConvertTo
            // 
            this.txtConvertTo.Location = new System.Drawing.Point(97, 102);
            this.txtConvertTo.Name = "txtConvertTo";
            this.txtConvertTo.ReadOnly = true;
            this.txtConvertTo.Size = new System.Drawing.Size(246, 20);
            this.txtConvertTo.TabIndex = 4;
            // 
            // cboConvertTo
            // 
            this.cboConvertTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConvertTo.FormattingEnabled = true;
            this.cboConvertTo.Location = new System.Drawing.Point(97, 75);
            this.cboConvertTo.Name = "cboConvertTo";
            this.cboConvertTo.Size = new System.Drawing.Size(121, 21);
            this.cboConvertTo.TabIndex = 3;
            // 
            // txtConvertFrom
            // 
            this.txtConvertFrom.Location = new System.Drawing.Point(97, 39);
            this.txtConvertFrom.Name = "txtConvertFrom";
            this.txtConvertFrom.Size = new System.Drawing.Size(246, 20);
            this.txtConvertFrom.TabIndex = 2;
            // 
            // lblConvertTo
            // 
            this.lblConvertTo.AutoSize = true;
            this.lblConvertTo.Location = new System.Drawing.Point(21, 78);
            this.lblConvertTo.Name = "lblConvertTo";
            this.lblConvertTo.Size = new System.Drawing.Size(62, 13);
            this.lblConvertTo.TabIndex = 10;
            this.lblConvertTo.Text = "Convert to: ";
            // 
            // lblConvertFrom
            // 
            this.lblConvertFrom.AutoSize = true;
            this.lblConvertFrom.Location = new System.Drawing.Point(18, 15);
            this.lblConvertFrom.Name = "lblConvertFrom";
            this.lblConvertFrom.Size = new System.Drawing.Size(73, 13);
            this.lblConvertFrom.TabIndex = 0;
            this.lblConvertFrom.Text = "Convert from: ";
            // 
            // cboConvertFrom
            // 
            this.cboConvertFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConvertFrom.FormattingEnabled = true;
            this.cboConvertFrom.Location = new System.Drawing.Point(97, 12);
            this.cboConvertFrom.Name = "cboConvertFrom";
            this.cboConvertFrom.Size = new System.Drawing.Size(121, 21);
            this.cboConvertFrom.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 227);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExplanation);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtConvertTo);
            this.Controls.Add(this.cboConvertTo);
            this.Controls.Add(this.txtConvertFrom);
            this.Controls.Add(this.lblConvertTo);
            this.Controls.Add(this.lblConvertFrom);
            this.Controls.Add(this.cboConvertFrom);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Systems Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExplanation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtConvertTo;
        private System.Windows.Forms.ComboBox cboConvertTo;
        private System.Windows.Forms.TextBox txtConvertFrom;
        private System.Windows.Forms.Label lblConvertTo;
        private System.Windows.Forms.Label lblConvertFrom;
        private System.Windows.Forms.ComboBox cboConvertFrom;
    }
}

