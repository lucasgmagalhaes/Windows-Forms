namespace BulletWorld
{
    partial class frmEndGameResult
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnagain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnewchar = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnquit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(194)))));
            this.label1.Font = new System.Drawing.Font("Computer Pixel-7", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(400, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "D E R R O T A";
            // 
            // btnagain
            // 
            this.btnagain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnagain.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnagain.FlatAppearance.BorderSize = 2;
            this.btnagain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagain.Font = new System.Drawing.Font("Computer Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagain.ForeColor = System.Drawing.Color.White;
            this.btnagain.Location = new System.Drawing.Point(541, 341);
            this.btnagain.Name = "btnagain";
            this.btnagain.Size = new System.Drawing.Size(240, 31);
            this.btnagain.TabIndex = 1;
            this.btnagain.Text = "Tentar novamente";
            this.btnagain.UseVisualStyleBackColor = false;
            this.btnagain.Click += new System.EventHandler(this.btnagain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BulletWorld.Properties.Resources.Trofeu;
            this.pictureBox1.Location = new System.Drawing.Point(541, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Computer Pixel-7", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(609, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "pontuação";
            // 
            // btnnewchar
            // 
            this.btnnewchar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnnewchar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnnewchar.FlatAppearance.BorderSize = 2;
            this.btnnewchar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewchar.Font = new System.Drawing.Font("Computer Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewchar.ForeColor = System.Drawing.Color.White;
            this.btnnewchar.Location = new System.Drawing.Point(541, 378);
            this.btnnewchar.Name = "btnnewchar";
            this.btnnewchar.Size = new System.Drawing.Size(240, 31);
            this.btnnewchar.TabIndex = 7;
            this.btnnewchar.Text = "Novo personagem";
            this.btnnewchar.UseVisualStyleBackColor = false;
            this.btnnewchar.Click += new System.EventHandler(this.btnnewchar_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnback.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnback.FlatAppearance.BorderSize = 2;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Computer Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(541, 415);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(240, 31);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Menu principal";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnquit
            // 
            this.btnquit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnquit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnquit.FlatAppearance.BorderSize = 2;
            this.btnquit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquit.Font = new System.Drawing.Font("Computer Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquit.ForeColor = System.Drawing.Color.White;
            this.btnquit.Location = new System.Drawing.Point(541, 452);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(240, 31);
            this.btnquit.TabIndex = 9;
            this.btnquit.Text = "Sair do jogo";
            this.btnquit.UseVisualStyleBackColor = false;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // frmEndGameResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(1062, 522);
            this.Controls.Add(this.btnquit);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnnewchar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnagain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEndGameResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmderrota";
            this.Load += new System.EventHandler(this.frmderrota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnagain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnewchar;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnquit;
    }
}