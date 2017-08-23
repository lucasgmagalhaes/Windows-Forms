namespace TI_FSI
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUpArq = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.charGeralRegis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.charGeral = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.charRoupa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.charComida = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.charBrinquedos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtCaminhoArq = new System.Windows.Forms.TextBox();
            this.lbltempo = new System.Windows.Forms.Label();
            this.TimerTempo = new System.Windows.Forms.Timer(this.components);
            this.picload = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charGeralRegis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charGeral)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charRoupa)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charComida)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charBrinquedos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picload)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpArq
            // 
            this.btnUpArq.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpArq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpArq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpArq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpArq.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpArq.Location = new System.Drawing.Point(600, 38);
            this.btnUpArq.Name = "btnUpArq";
            this.btnUpArq.Size = new System.Drawing.Size(181, 23);
            this.btnUpArq.TabIndex = 1;
            this.btnUpArq.Text = "PROCURAR";
            this.btnUpArq.UseVisualStyleBackColor = false;
            this.btnUpArq.Click += new System.EventHandler(this.button1_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Controls.Add(this.tabPage4);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(12, 86);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1068, 453);
            this.TabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.charGeralRegis);
            this.tabPage1.Controls.Add(this.charGeral);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1060, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Geral";
            // 
            // charGeralRegis
            // 
            this.charGeralRegis.BackColor = System.Drawing.Color.Gainsboro;
            this.charGeralRegis.BorderlineColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Gainsboro;
            chartArea1.BorderColor = System.Drawing.Color.Gainsboro;
            chartArea1.Name = "ChartArea1";
            this.charGeralRegis.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Gainsboro;
            legend1.BackImageTransparentColor = System.Drawing.Color.Gainsboro;
            legend1.BackSecondaryColor = System.Drawing.Color.Gainsboro;
            legend1.BorderColor = System.Drawing.Color.Gainsboro;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.InterlacedRowsColor = System.Drawing.Color.Gainsboro;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend";
            legend1.Title = "Colunas";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.charGeralRegis.Legends.Add(legend1);
            this.charGeralRegis.Location = new System.Drawing.Point(526, 6);
            this.charGeralRegis.Name = "charGeralRegis";
            series1.BackSecondaryColor = System.Drawing.Color.Gainsboro;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.Gainsboro;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend";
            series1.MarkerBorderColor = System.Drawing.Color.Gainsboro;
            series1.Name = "SeriesGeral";
            this.charGeralRegis.Series.Add(series1);
            this.charGeralRegis.Size = new System.Drawing.Size(460, 412);
            this.charGeralRegis.TabIndex = 1;
            this.charGeralRegis.Text = "chart1";
            title1.DockedToChartArea = "ChartArea1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "title";
            title1.Text = "Análise por número de registros";
            this.charGeralRegis.Titles.Add(title1);
            // 
            // charGeral
            // 
            this.charGeral.BackColor = System.Drawing.Color.Gainsboro;
            this.charGeral.BorderlineColor = System.Drawing.Color.Gainsboro;
            chartArea2.BackColor = System.Drawing.Color.Gainsboro;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Gainsboro;
            chartArea2.BorderColor = System.Drawing.Color.Gainsboro;
            chartArea2.Name = "ChartArea1";
            this.charGeral.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Gainsboro;
            legend2.BackImageTransparentColor = System.Drawing.Color.Gainsboro;
            legend2.BackSecondaryColor = System.Drawing.Color.Gainsboro;
            legend2.BorderColor = System.Drawing.Color.Gainsboro;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.InterlacedRowsColor = System.Drawing.Color.Gainsboro;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend";
            legend2.Title = "Colunas";
            legend2.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.charGeral.Legends.Add(legend2);
            this.charGeral.Location = new System.Drawing.Point(7, 6);
            this.charGeral.Name = "charGeral";
            series2.BackSecondaryColor = System.Drawing.Color.Gainsboro;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Color = System.Drawing.Color.Gainsboro;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend";
            series2.MarkerBorderColor = System.Drawing.Color.Gainsboro;
            series2.Name = "SeriesGeral";
            this.charGeral.Series.Add(series2);
            this.charGeral.Size = new System.Drawing.Size(460, 412);
            this.charGeral.TabIndex = 0;
            this.charGeral.Text = "chart1";
            title2.DockedToChartArea = "ChartArea1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "title";
            title2.Text = "Análise por quantidade";
            this.charGeral.Titles.Add(title2);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.charRoupa);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1060, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Roupas";
            // 
            // charRoupa
            // 
            this.charRoupa.BackColor = System.Drawing.Color.Gainsboro;
            this.charRoupa.BorderlineColor = System.Drawing.Color.Gainsboro;
            chartArea3.BackColor = System.Drawing.Color.Gainsboro;
            chartArea3.BackSecondaryColor = System.Drawing.Color.Gainsboro;
            chartArea3.BorderColor = System.Drawing.Color.Gainsboro;
            chartArea3.Name = "ChartArea1";
            this.charRoupa.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Gainsboro;
            legend3.BackImageTransparentColor = System.Drawing.Color.Gainsboro;
            legend3.BackSecondaryColor = System.Drawing.Color.Gainsboro;
            legend3.BorderColor = System.Drawing.Color.Gainsboro;
            legend3.InterlacedRowsColor = System.Drawing.Color.Gainsboro;
            legend3.Name = "Legend1";
            this.charRoupa.Legends.Add(legend3);
            this.charRoupa.Location = new System.Drawing.Point(311, 9);
            this.charRoupa.Name = "charRoupa";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.charRoupa.Series.Add(series3);
            this.charRoupa.Size = new System.Drawing.Size(454, 412);
            this.charRoupa.TabIndex = 1;
            this.charRoupa.Text = "chart2";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.charComida);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1060, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Comida";
            // 
            // charComida
            // 
            this.charComida.BackColor = System.Drawing.Color.Gainsboro;
            this.charComida.BorderlineColor = System.Drawing.Color.Gainsboro;
            chartArea4.BackColor = System.Drawing.Color.Gainsboro;
            chartArea4.BackSecondaryColor = System.Drawing.Color.Gainsboro;
            chartArea4.BorderColor = System.Drawing.Color.Gainsboro;
            chartArea4.Name = "ChartArea1";
            this.charComida.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Gainsboro;
            legend4.BackImageTransparentColor = System.Drawing.Color.Gainsboro;
            legend4.BackSecondaryColor = System.Drawing.Color.Gainsboro;
            legend4.BorderColor = System.Drawing.Color.Gainsboro;
            legend4.InterlacedRowsColor = System.Drawing.Color.Gainsboro;
            legend4.Name = "Legend1";
            this.charComida.Legends.Add(legend4);
            this.charComida.Location = new System.Drawing.Point(311, 9);
            this.charComida.Name = "charComida";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.charComida.Series.Add(series4);
            this.charComida.Size = new System.Drawing.Size(454, 412);
            this.charComida.TabIndex = 2;
            this.charComida.Text = "chart3";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage4.Controls.Add(this.charBrinquedos);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1060, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Brinquedo";
            // 
            // charBrinquedos
            // 
            this.charBrinquedos.BackColor = System.Drawing.Color.Gainsboro;
            this.charBrinquedos.BorderlineColor = System.Drawing.Color.Gainsboro;
            chartArea5.BackColor = System.Drawing.Color.Gainsboro;
            chartArea5.BackSecondaryColor = System.Drawing.Color.Gainsboro;
            chartArea5.BorderColor = System.Drawing.Color.Gainsboro;
            chartArea5.Name = "ChartArea1";
            this.charBrinquedos.ChartAreas.Add(chartArea5);
            legend5.BackColor = System.Drawing.Color.Gainsboro;
            legend5.BackImageTransparentColor = System.Drawing.Color.Gainsboro;
            legend5.BackSecondaryColor = System.Drawing.Color.Gainsboro;
            legend5.BorderColor = System.Drawing.Color.Gainsboro;
            legend5.InterlacedRowsColor = System.Drawing.Color.Gainsboro;
            legend5.Name = "Legend1";
            this.charBrinquedos.Legends.Add(legend5);
            this.charBrinquedos.Location = new System.Drawing.Point(311, 9);
            this.charBrinquedos.Name = "charBrinquedos";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.charBrinquedos.Series.Add(series5);
            this.charBrinquedos.Size = new System.Drawing.Size(454, 412);
            this.charBrinquedos.TabIndex = 2;
            this.charBrinquedos.Text = "chart4";
            // 
            // txtCaminhoArq
            // 
            this.txtCaminhoArq.Enabled = false;
            this.txtCaminhoArq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminhoArq.Location = new System.Drawing.Point(12, 39);
            this.txtCaminhoArq.Name = "txtCaminhoArq";
            this.txtCaminhoArq.Size = new System.Drawing.Size(582, 22);
            this.txtCaminhoArq.TabIndex = 5;
            // 
            // lbltempo
            // 
            this.lbltempo.AutoSize = true;
            this.lbltempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbltempo.Location = new System.Drawing.Point(921, 9);
            this.lbltempo.Name = "lbltempo";
            this.lbltempo.Size = new System.Drawing.Size(155, 20);
            this.lbltempo.TabIndex = 6;
            this.lbltempo.Text = "00/00/0000 00:00:00";
            // 
            // TimerTempo
            // 
            this.TimerTempo.Enabled = true;
            this.TimerTempo.Interval = 1000;
            this.TimerTempo.Tick += new System.EventHandler(this.TimerTempo_Tick);
            // 
            // picload
            // 
            this.picload.Image = global::TI_FSI.Properties.Resources.Load;
            this.picload.Location = new System.Drawing.Point(785, 32);
            this.picload.Name = "picload";
            this.picload.Size = new System.Drawing.Size(36, 32);
            this.picload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picload.TabIndex = 7;
            this.picload.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Caminho do arquivo excel: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1083, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picload);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.lbltempo);
            this.Controls.Add(this.txtCaminhoArq);
            this.Controls.Add(this.btnUpArq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório geral de dados Excel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charGeralRegis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charGeral)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charRoupa)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charComida)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charBrinquedos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpArq;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtCaminhoArq;
        private System.Windows.Forms.Label lbltempo;
        private System.Windows.Forms.Timer TimerTempo;
        public System.Windows.Forms.DataVisualization.Charting.Chart charGeral;
        public System.Windows.Forms.DataVisualization.Charting.Chart charComida;
        public System.Windows.Forms.DataVisualization.Charting.Chart charBrinquedos;
        private System.Windows.Forms.TabControl TabControl;
        public System.Windows.Forms.DataVisualization.Charting.Chart charRoupa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picload;
        public System.Windows.Forms.DataVisualization.Charting.Chart charGeralRegis;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
    }
}

