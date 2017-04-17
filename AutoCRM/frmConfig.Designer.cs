namespace AutoCRM
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.btnsalvar = new System.Windows.Forms.Button();
            this.lblnomeservidor = new System.Windows.Forms.Label();
            this.txtservidor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbanco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtport = new System.Windows.Forms.MaskedTextBox();
            this.btndefault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsalvar
            // 
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(197, 226);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 6;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // lblnomeservidor
            // 
            this.lblnomeservidor.AutoSize = true;
            this.lblnomeservidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomeservidor.Location = new System.Drawing.Point(31, 26);
            this.lblnomeservidor.Name = "lblnomeservidor";
            this.lblnomeservidor.Size = new System.Drawing.Size(141, 15);
            this.lblnomeservidor.TabIndex = 1;
            this.lblnomeservidor.Text = "IP do Servidor do Banco:";
            // 
            // txtservidor
            // 
            this.txtservidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtservidor.Location = new System.Drawing.Point(31, 44);
            this.txtservidor.MaxLength = 100;
            this.txtservidor.Name = "txtservidor";
            this.txtservidor.Size = new System.Drawing.Size(153, 22);
            this.txtservidor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Porta:";
            // 
            // txtbanco
            // 
            this.txtbanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbanco.Location = new System.Drawing.Point(31, 99);
            this.txtbanco.MaxLength = 100;
            this.txtbanco.Name = "txtbanco";
            this.txtbanco.Size = new System.Drawing.Size(219, 22);
            this.txtbanco.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome do banco:";
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(31, 149);
            this.txtuser.MaxLength = 20;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(135, 22);
            this.txtuser.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Usuário:";
            // 
            // txtsenha
            // 
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(31, 190);
            this.txtsenha.MaxLength = 20;
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '•';
            this.txtsenha.Size = new System.Drawing.Size(135, 22);
            this.txtsenha.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Senha:";
            // 
            // mtxtport
            // 
            this.mtxtport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtport.HidePromptOnLeave = true;
            this.mtxtport.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtxtport.Location = new System.Drawing.Point(190, 44);
            this.mtxtport.Mask = "00000";
            this.mtxtport.Name = "mtxtport";
            this.mtxtport.PromptChar = ' ';
            this.mtxtport.Size = new System.Drawing.Size(60, 22);
            this.mtxtport.TabIndex = 2;
            // 
            // btndefault
            // 
            this.btndefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndefault.Location = new System.Drawing.Point(56, 226);
            this.btndefault.Name = "btndefault";
            this.btndefault.Size = new System.Drawing.Size(135, 23);
            this.btndefault.TabIndex = 7;
            this.btndefault.Text = "Configuração padrão";
            this.btndefault.UseVisualStyleBackColor = true;
            this.btndefault.Click += new System.EventHandler(this.btndefault_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btndefault);
            this.Controls.Add(this.mtxtport);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbanco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtservidor);
            this.Controls.Add(this.lblnomeservidor);
            this.Controls.Add(this.btnsalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações ";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Label lblnomeservidor;
        private System.Windows.Forms.TextBox txtservidor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbanco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtport;
        private System.Windows.Forms.Button btndefault;
    }
}