namespace BulletWorld
{
    partial class frmTrophy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrophy));
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.DataGridPlayer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridOtherPlayers = new System.Windows.Forms.DataGridView();
            this.ColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOtherPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackgroundImage = global::BulletWorld.Properties.Resources.BackgroundMain;
            this.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(992, 518);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 0;
            this.PictureBox2.TabStop = false;
            // 
            // DataGridPlayer
            // 
            this.DataGridPlayer.AllowUserToAddRows = false;
            this.DataGridPlayer.AllowUserToDeleteRows = false;
            this.DataGridPlayer.AllowUserToResizeColumns = false;
            this.DataGridPlayer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Computer Pixel-7", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridPlayer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridPlayer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.DataGridPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridPlayer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DataGridPlayer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Computer Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPlayer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DataGridPlayer.Enabled = false;
            this.DataGridPlayer.Location = new System.Drawing.Point(229, 69);
            this.DataGridPlayer.MultiSelect = false;
            this.DataGridPlayer.Name = "DataGridPlayer";
            this.DataGridPlayer.ReadOnly = true;
            this.DataGridPlayer.RowHeadersVisible = false;
            this.DataGridPlayer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridPlayer.RowTemplate.Height = 33;
            this.DataGridPlayer.RowTemplate.ReadOnly = true;
            this.DataGridPlayer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridPlayer.ShowCellErrors = false;
            this.DataGridPlayer.ShowCellToolTips = false;
            this.DataGridPlayer.ShowEditingIcon = false;
            this.DataGridPlayer.ShowRowErrors = false;
            this.DataGridPlayer.Size = new System.Drawing.Size(603, 120);
            this.DataGridPlayer.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 300F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Position";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Computer Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Player";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 380;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Computer Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.NullValue = "-";
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Points";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 153;
            // 
            // position
            // 
            this.position.HeaderText = "Colocation";
            this.position.Name = "position";
            this.position.ReadOnly = true;
            // 
            // DataGridOtherPlayers
            // 
            this.DataGridOtherPlayers.AllowUserToAddRows = false;
            this.DataGridOtherPlayers.AllowUserToDeleteRows = false;
            this.DataGridOtherPlayers.AllowUserToResizeColumns = false;
            this.DataGridOtherPlayers.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Computer Pixel-7", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridOtherPlayers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridOtherPlayers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.DataGridOtherPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridOtherPlayers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DataGridOtherPlayers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Computer Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridOtherPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridOtherPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridOtherPlayers.ColumnHeadersVisible = false;
            this.DataGridOtherPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPosition,
            this.ColumnName,
            this.ColumnPoints});
            this.DataGridOtherPlayers.Enabled = false;
            this.DataGridOtherPlayers.Location = new System.Drawing.Point(229, 189);
            this.DataGridOtherPlayers.MultiSelect = false;
            this.DataGridOtherPlayers.Name = "DataGridOtherPlayers";
            this.DataGridOtherPlayers.ReadOnly = true;
            this.DataGridOtherPlayers.RowHeadersVisible = false;
            this.DataGridOtherPlayers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridOtherPlayers.RowTemplate.ReadOnly = true;
            this.DataGridOtherPlayers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridOtherPlayers.ShowCellErrors = false;
            this.DataGridOtherPlayers.ShowCellToolTips = false;
            this.DataGridOtherPlayers.ShowEditingIcon = false;
            this.DataGridOtherPlayers.ShowRowErrors = false;
            this.DataGridOtherPlayers.Size = new System.Drawing.Size(603, 235);
            this.DataGridOtherPlayers.TabIndex = 6;
            // 
            // ColumnPosition
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Computer Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnPosition.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnPosition.FillWeight = 150F;
            this.ColumnPosition.Frozen = true;
            this.ColumnPosition.HeaderText = "";
            this.ColumnPosition.Name = "ColumnPosition";
            this.ColumnPosition.ReadOnly = true;
            this.ColumnPosition.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPosition.Width = 70;
            // 
            // ColumnName
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Computer Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnName.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnName.Frozen = true;
            this.ColumnName.HeaderText = "";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 380;
            // 
            // ColumnPoints
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Computer Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.NullValue = "-";
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnPoints.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColumnPoints.Frozen = true;
            this.ColumnPoints.HeaderText = "";
            this.ColumnPoints.Name = "ColumnPoints";
            this.ColumnPoints.ReadOnly = true;
            this.ColumnPoints.Width = 153;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Computer Pixel-7", 26.25F);
            this.btnback.ForeColor = System.Drawing.Color.Gold;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnback.Location = new System.Drawing.Point(27, 34);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(105, 33);
            this.btnback.TabIndex = 17;
            this.btnback.Text = "Back";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // frmTrophy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 518);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.DataGridOtherPlayers);
            this.Controls.Add(this.DataGridPlayer);
            this.Controls.Add(this.PictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTrophy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPlayerSelect";
            this.Load += new System.EventHandler(this.frmPlayerSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOtherPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridView DataGridPlayer;
        private System.Windows.Forms.DataGridView DataGridOtherPlayers;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPoints;
        private System.Windows.Forms.Button btnback;
    }
}