namespace AutoCRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.btnlancar = new System.Windows.Forms.Button();
            this.txtfilepath = new System.Windows.Forms.TextBox();
            this.lblklog = new System.Windows.Forms.LinkLabel();
            this.btnconfig = new System.Windows.Forms.Button();
            this.btnselecionar = new System.Windows.Forms.Button();
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.lbltatus = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecionar arquivo CRM";
            // 
            // btnlancar
            // 
            this.btnlancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlancar.Location = new System.Drawing.Point(67, 81);
            this.btnlancar.Name = "btnlancar";
            this.btnlancar.Size = new System.Drawing.Size(265, 26);
            this.btnlancar.TabIndex = 1;
            this.btnlancar.Text = "Lançar";
            this.btnlancar.UseVisualStyleBackColor = true;
            this.btnlancar.Click += new System.EventHandler(this.btnlancar_Click);
            // 
            // txtfilepath
            // 
            this.txtfilepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfilepath.Location = new System.Drawing.Point(13, 55);
            this.txtfilepath.Name = "txtfilepath";
            this.txtfilepath.Size = new System.Drawing.Size(368, 22);
            this.txtfilepath.TabIndex = 2;
            // 
            // lblklog
            // 
            this.lblklog.AutoSize = true;
            this.lblklog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblklog.Location = new System.Drawing.Point(275, 121);
            this.lblklog.Name = "lblklog";
            this.lblklog.Size = new System.Drawing.Size(113, 15);
            this.lblklog.TabIndex = 4;
            this.lblklog.TabStop = true;
            this.lblklog.Text = "Log de lançamento";
            this.lblklog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblklog_LinkClicked_1);
            // 
            // btnconfig
            // 
            this.btnconfig.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnconfig.FlatAppearance.BorderSize = 0;
            this.btnconfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfig.Image = global::AutoCRM.Properties.Resources.Settings_16;
            this.btnconfig.Location = new System.Drawing.Point(388, 7);
            this.btnconfig.Name = "btnconfig";
            this.btnconfig.Size = new System.Drawing.Size(23, 23);
            this.btnconfig.TabIndex = 5;
            this.btnconfig.UseVisualStyleBackColor = true;
            this.btnconfig.Click += new System.EventHandler(this.btnconfig_Click);
            // 
            // btnselecionar
            // 
            this.btnselecionar.FlatAppearance.BorderSize = 0;
            this.btnselecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselecionar.Image = global::AutoCRM.Properties.Resources.Search_16;
            this.btnselecionar.Location = new System.Drawing.Point(383, 53);
            this.btnselecionar.Name = "btnselecionar";
            this.btnselecionar.Size = new System.Drawing.Size(32, 23);
            this.btnselecionar.TabIndex = 3;
            this.btnselecionar.UseVisualStyleBackColor = true;
            this.btnselecionar.Click += new System.EventHandler(this.btnselecionar_Click);
            // 
            // progresso
            // 
            this.progresso.Location = new System.Drawing.Point(18, 138);
            this.progresso.Minimum = 1;
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(368, 22);
            this.progresso.TabIndex = 0;
            this.progresso.Value = 1;
            // 
            // lbltatus
            // 
            this.lbltatus.AutoSize = true;
            this.lbltatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltatus.Location = new System.Drawing.Point(20, 120);
            this.lbltatus.Name = "lbltatus";
            this.lbltatus.Size = new System.Drawing.Size(41, 15);
            this.lbltatus.TabIndex = 7;
            this.lbltatus.Text = "label2";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 183);
            this.Controls.Add(this.lbltatus);
            this.Controls.Add(this.progresso);
            this.Controls.Add(this.btnconfig);
            this.Controls.Add(this.lblklog);
            this.Controls.Add(this.btnselecionar);
            this.Controls.Add(this.txtfilepath);
            this.Controls.Add(this.btnlancar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mafra - CRM automático";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlancar;
        private System.Windows.Forms.TextBox txtfilepath;
        private System.Windows.Forms.Button btnselecionar;
        private System.Windows.Forms.LinkLabel lblklog;
        private System.Windows.Forms.Button btnconfig;
        private System.Windows.Forms.ProgressBar progresso;
        private System.Windows.Forms.Label lbltatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

