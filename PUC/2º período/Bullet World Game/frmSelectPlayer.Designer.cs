namespace BulletWorld
{
    partial class frmSelectPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectPlayer));
            this.btnnew = new System.Windows.Forms.Button();
            this.listboxplayer = new System.Windows.Forms.ListBox();
            this.btncheck = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.frmback = new System.Windows.Forms.Button();
            this.lblblock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnnew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnnew.FlatAppearance.BorderSize = 0;
            this.btnnew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.Location = new System.Drawing.Point(667, 110);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(37, 34);
            this.btnnew.TabIndex = 0;
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // listboxplayer
            // 
            this.listboxplayer.BackColor = System.Drawing.SystemColors.Window;
            this.listboxplayer.Font = new System.Drawing.Font("Computer Pixel-7", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxplayer.FormattingEnabled = true;
            this.listboxplayer.ItemHeight = 22;
            this.listboxplayer.Location = new System.Drawing.Point(331, 110);
            this.listboxplayer.Name = "listboxplayer";
            this.listboxplayer.Size = new System.Drawing.Size(330, 268);
            this.listboxplayer.TabIndex = 1;
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btncheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btncheck.FlatAppearance.BorderSize = 0;
            this.btncheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btncheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheck.Image = ((System.Drawing.Image)(resources.GetObject("btncheck.Image")));
            this.btncheck.Location = new System.Drawing.Point(667, 150);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(37, 34);
            this.btncheck.TabIndex = 2;
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(667, 190);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(37, 34);
            this.btndelete.TabIndex = 3;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // frmback
            // 
            this.frmback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.frmback.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.frmback.FlatAppearance.BorderSize = 0;
            this.frmback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.frmback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.frmback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmback.Font = new System.Drawing.Font("Computer Pixel-7", 26.25F);
            this.frmback.ForeColor = System.Drawing.Color.Gold;
            this.frmback.Image = ((System.Drawing.Image)(resources.GetObject("frmback.Image")));
            this.frmback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.frmback.Location = new System.Drawing.Point(12, 12);
            this.frmback.Name = "frmback";
            this.frmback.Size = new System.Drawing.Size(108, 34);
            this.frmback.TabIndex = 4;
            this.frmback.Text = "Back";
            this.frmback.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.frmback.UseVisualStyleBackColor = false;
            this.frmback.Click += new System.EventHandler(this.frmback_Click);
            // 
            // lblblock
            // 
            this.lblblock.AutoSize = true;
            this.lblblock.Font = new System.Drawing.Font("Computer Pixel-7", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblblock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblblock.Location = new System.Drawing.Point(314, 77);
            this.lblblock.Name = "lblblock";
            this.lblblock.Size = new System.Drawing.Size(364, 23);
            this.lblblock.TabIndex = 5;
            this.lblblock.Text = "Ops! Você não pode se deletar mané!";
            this.lblblock.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Computer Pixel-7", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(307, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "F1 - New Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Computer Pixel-7", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(504, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "F2 - Select Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Computer Pixel-7", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "F3 - Delete Player";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Computer Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(722, 433);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 73);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Don\'t come to the dark side";
            // 
            // frmSelectPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(992, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblblock);
            this.Controls.Add(this.frmback);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.listboxplayer);
            this.Controls.Add(this.btnnew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmSelectPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSelectPlayer";
            this.Load += new System.EventHandler(this.frmSelectPlayer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSelectPlayer_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button frmback;
        private System.Windows.Forms.ListBox listboxplayer;
        private System.Windows.Forms.Label lblblock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}