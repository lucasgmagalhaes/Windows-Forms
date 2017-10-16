namespace TI_Arquitetura
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listHD = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listProcessor = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listgeneral = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listcache = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.listProcessosRunning = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblcpu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldisk = new System.Windows.Forms.Label();
            this.lblram = new System.Windows.Forms.Label();
            this.timer_performance = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.listspecific = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.listservices = new System.Windows.Forms.ListView();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listHD);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(533, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Disco Rígido";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listHD
            // 
            this.listHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listHD.FullRowSelect = true;
            this.listHD.Location = new System.Drawing.Point(3, 3);
            this.listHD.Name = "listHD";
            this.listHD.Size = new System.Drawing.Size(527, 403);
            this.listHD.TabIndex = 2;
            this.listHD.UseCompatibleStateImageBehavior = false;
            this.listHD.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Info";
            this.columnHeader6.Width = 250;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listProcessor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(533, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Processador";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listProcessor
            // 
            this.listProcessor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listProcessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listProcessor.FullRowSelect = true;
            this.listProcessor.Location = new System.Drawing.Point(3, 3);
            this.listProcessor.Name = "listProcessor";
            this.listProcessor.Size = new System.Drawing.Size(527, 403);
            this.listProcessor.TabIndex = 0;
            this.listProcessor.UseCompatibleStateImageBehavior = false;
            this.listProcessor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Info";
            this.columnHeader2.Width = 250;
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.tabPage3);
            this.tab3.Controls.Add(this.tabPage1);
            this.tab3.Controls.Add(this.tabPage4);
            this.tab3.Controls.Add(this.tabPage2);
            this.tab3.Controls.Add(this.tabPage5);
            this.tab3.Controls.Add(this.tabPage6);
            this.tab3.Controls.Add(this.tabPage7);
            this.tab3.Location = new System.Drawing.Point(3, 165);
            this.tab3.Name = "tab3";
            this.tab3.SelectedIndex = 0;
            this.tab3.Size = new System.Drawing.Size(541, 435);
            this.tab3.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listgeneral);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(533, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Informações Gerais";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listgeneral
            // 
            this.listgeneral.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.listgeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listgeneral.FullRowSelect = true;
            this.listgeneral.Location = new System.Drawing.Point(3, 3);
            this.listgeneral.Name = "listgeneral";
            this.listgeneral.Size = new System.Drawing.Size(527, 403);
            this.listgeneral.TabIndex = 1;
            this.listgeneral.UseCompatibleStateImageBehavior = false;
            this.listgeneral.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            this.columnHeader7.Width = 160;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Info";
            this.columnHeader8.Width = 250;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listcache);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(533, 409);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cache";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listcache
            // 
            this.listcache.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.listcache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listcache.FullRowSelect = true;
            this.listcache.Location = new System.Drawing.Point(3, 3);
            this.listcache.Name = "listcache";
            this.listcache.Size = new System.Drawing.Size(527, 403);
            this.listcache.TabIndex = 3;
            this.listcache.UseCompatibleStateImageBehavior = false;
            this.listcache.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Name";
            this.columnHeader9.Width = 160;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Info";
            this.columnHeader10.Width = 250;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.listProcessosRunning);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(533, 409);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Processos ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // listProcessosRunning
            // 
            this.listProcessosRunning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listProcessosRunning.FullRowSelect = true;
            this.listProcessosRunning.Location = new System.Drawing.Point(0, 0);
            this.listProcessosRunning.Name = "listProcessosRunning";
            this.listProcessosRunning.Size = new System.Drawing.Size(533, 409);
            this.listProcessosRunning.TabIndex = 2;
            this.listProcessosRunning.UseCompatibleStateImageBehavior = false;
            this.listProcessosRunning.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 0;
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 1;
            this.columnHeader4.Text = "Info";
            this.columnHeader4.Width = 250;
            // 
            // lblcpu
            // 
            this.lblcpu.AutoSize = true;
            this.lblcpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpu.Location = new System.Drawing.Point(49, 43);
            this.lblcpu.Name = "lblcpu";
            this.lblcpu.Size = new System.Drawing.Size(27, 16);
            this.lblcpu.TabIndex = 2;
            this.lblcpu.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Memória";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Disco";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbldisk);
            this.groupBox1.Controls.Add(this.lblram);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblcpu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(298, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lbldisk
            // 
            this.lbldisk.AutoSize = true;
            this.lbldisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisk.Location = new System.Drawing.Point(158, 43);
            this.lbldisk.Name = "lbldisk";
            this.lbldisk.Size = new System.Drawing.Size(27, 16);
            this.lbldisk.TabIndex = 7;
            this.lbldisk.Text = "0%";
            // 
            // lblram
            // 
            this.lblram.AutoSize = true;
            this.lblram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblram.Location = new System.Drawing.Point(104, 43);
            this.lblram.Name = "lblram";
            this.lblram.Size = new System.Drawing.Size(27, 16);
            this.lblram.TabIndex = 6;
            this.lblram.Text = "0%";
            // 
            // timer_performance
            // 
            this.timer_performance.Interval = 1300;
            this.timer_performance.Tick += new System.EventHandler(this.timer_performance_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(8, 139);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(286, 15);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(82, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "HD - Espaço ocupado\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(299, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "0%";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.listspecific);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(533, 409);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Programas Específicos";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // listspecific
            // 
            this.listspecific.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listspecific.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listspecific.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listspecific.FullRowSelect = true;
            this.listspecific.HoverSelection = true;
            this.listspecific.Location = new System.Drawing.Point(0, 0);
            this.listspecific.MultiSelect = false;
            this.listspecific.Name = "listspecific";
            this.listspecific.Size = new System.Drawing.Size(533, 409);
            this.listspecific.TabIndex = 2;
            this.listspecific.UseCompatibleStateImageBehavior = false;
            this.listspecific.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Nome";
            this.columnHeader12.Width = 130;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "CPU";
            this.columnHeader13.Width = 80;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "RAM";
            this.columnHeader14.Width = 90;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Paginação";
            this.columnHeader15.Width = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(299, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Professor: Paulo Amaral";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Trabalho prático de SO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lucas Gomes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ítalo Fabrício";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(181, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Henrique Kiskch";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(182, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Pedro Henrique";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TI_Arquitetura45.Properties.Resources.puc_minas;
            this.pictureBox1.Location = new System.Drawing.Point(1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.listservices);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(533, 409);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Serviços";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // listservices
            // 
            this.listservices.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listservices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listservices.FullRowSelect = true;
            this.listservices.HoverSelection = true;
            this.listservices.Location = new System.Drawing.Point(0, 0);
            this.listservices.MultiSelect = false;
            this.listservices.Name = "listservices";
            this.listservices.Size = new System.Drawing.Size(533, 409);
            this.listservices.TabIndex = 3;
            this.listservices.UseCompatibleStateImageBehavior = false;
            this.listservices.View = System.Windows.Forms.View.Details;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 604);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tab3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Hardware Informations .Net 4.5";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tab3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listHD;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listProcessor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabControl tab3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listgeneral;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lblcpu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldisk;
        private System.Windows.Forms.Label lblram;
        private System.Windows.Forms.Timer timer_performance;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView listcache;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListView listProcessosRunning;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ListView listspecific;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ListView listservices;
    }
}

