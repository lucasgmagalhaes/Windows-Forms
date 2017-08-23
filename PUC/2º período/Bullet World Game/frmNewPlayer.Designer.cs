namespace BulletWorld
{
    partial class frmNewPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewPlayer));
            this.btncreateplayer = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.txtplayername = new System.Windows.Forms.TextBox();
            this.lblexists = new System.Windows.Forms.Label();
            this.Timer_Exists = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btncreateplayer
            // 
            this.btncreateplayer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btncreateplayer.FlatAppearance.BorderSize = 0;
            this.btncreateplayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btncreateplayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btncreateplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncreateplayer.Image = ((System.Drawing.Image)(resources.GetObject("btncreateplayer.Image")));
            this.btncreateplayer.Location = new System.Drawing.Point(268, 50);
            this.btncreateplayer.Name = "btncreateplayer";
            this.btncreateplayer.Size = new System.Drawing.Size(46, 34);
            this.btncreateplayer.TabIndex = 1;
            this.btncreateplayer.UseVisualStyleBackColor = true;
            this.btncreateplayer.Click += new System.EventHandler(this.btncreateplayer_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Computer Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Gold;
            this.lblname.Location = new System.Drawing.Point(15, 61);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(46, 19);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Nome";
            // 
            // txtplayername
            // 
            this.txtplayername.Font = new System.Drawing.Font("Computer Pixel-7", 18F);
            this.txtplayername.Location = new System.Drawing.Point(63, 54);
            this.txtplayername.MaxLength = 20;
            this.txtplayername.Name = "txtplayername";
            this.txtplayername.Size = new System.Drawing.Size(199, 31);
            this.txtplayername.TabIndex = 0;
            this.txtplayername.Tag = "";
            // 
            // lblexists
            // 
            this.lblexists.AutoSize = true;
            this.lblexists.Font = new System.Drawing.Font("Computer Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexists.ForeColor = System.Drawing.Color.Maroon;
            this.lblexists.Location = new System.Drawing.Point(62, 32);
            this.lblexists.Name = "lblexists";
            this.lblexists.Size = new System.Drawing.Size(148, 19);
            this.lblexists.TabIndex = 3;
            this.lblexists.Text = "Jogador já existe";
            this.lblexists.Visible = false;
            // 
            // Timer_Exists
            // 
            this.Timer_Exists.Interval = 1000;
            this.Timer_Exists.Tick += new System.EventHandler(this.Timer_Exists_Tick);
            // 
            // frmNewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(341, 126);
            this.Controls.Add(this.lblexists);
            this.Controls.Add(this.txtplayername);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btncreateplayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNewPlayer_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmNewPlayer_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreateplayer;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtplayername;
        private System.Windows.Forms.Label lblexists;
        private System.Windows.Forms.Timer Timer_Exists;
    }
}