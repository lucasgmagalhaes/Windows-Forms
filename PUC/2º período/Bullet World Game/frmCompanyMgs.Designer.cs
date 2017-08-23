namespace Ti
{
    partial class frmCompanyMgs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompanyMgs));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureCompany = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Computer Pixel-7", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(315, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "C# Soni Blaine Corporations";
            // 
            // pictureCompany
            // 
            this.pictureCompany.Image = ((System.Drawing.Image)(resources.GetObject("pictureCompany.Image")));
            this.pictureCompany.Location = new System.Drawing.Point(439, 146);
            this.pictureCompany.Name = "pictureCompany";
            this.pictureCompany.Size = new System.Drawing.Size(108, 106);
            this.pictureCompany.TabIndex = 0;
            this.pictureCompany.TabStop = false;
            this.pictureCompany.Tag = "";
            // 
            // frmCompanyMgs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(992, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompanyMgs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompanyMgs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCompany;
        private System.Windows.Forms.Label label1;
    }
}