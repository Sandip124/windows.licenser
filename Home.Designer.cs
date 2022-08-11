namespace windows.licenser
{
    partial class Home
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
            this.editionSelectorElem = new System.Windows.Forms.ComboBox();
            this.licenseRenewBtnElem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editionSelectorElem
            // 
            this.editionSelectorElem.FormattingEnabled = true;
            this.editionSelectorElem.Location = new System.Drawing.Point(187, 65);
            this.editionSelectorElem.Name = "editionSelectorElem";
            this.editionSelectorElem.Size = new System.Drawing.Size(313, 21);
            this.editionSelectorElem.TabIndex = 0;
            // 
            // licenseRenewBtnElem
            // 
            this.licenseRenewBtnElem.Location = new System.Drawing.Point(223, 111);
            this.licenseRenewBtnElem.Name = "licenseRenewBtnElem";
            this.licenseRenewBtnElem.Size = new System.Drawing.Size(252, 50);
            this.licenseRenewBtnElem.TabIndex = 1;
            this.licenseRenewBtnElem.Text = "Renew Licese";
            this.licenseRenewBtnElem.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 283);
            this.Controls.Add(this.licenseRenewBtnElem);
            this.Controls.Add(this.editionSelectorElem);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox editionSelectorElem;
        private System.Windows.Forms.Button licenseRenewBtnElem;

        #endregion
    }
}