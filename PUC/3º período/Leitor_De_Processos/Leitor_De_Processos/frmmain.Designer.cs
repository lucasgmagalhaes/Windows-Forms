namespace Leitor_De_Processos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTipCarregar = new System.Windows.Forms.ToolStripMenuItem();
            this.execuçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripStart = new System.Windows.Forms.ToolStripMenuItem();
            this.processamentoSequencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnfinish = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ProcessCount = new System.Windows.Forms.Timer(this.components);
            this.listProcessos = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.execuçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolTipCarregar});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // ToolTipCarregar
            // 
            this.ToolTipCarregar.Name = "ToolTipCarregar";
            this.ToolTipCarregar.Size = new System.Drawing.Size(143, 22);
            this.ToolTipCarregar.Text = "Carregar lista";
            this.ToolTipCarregar.Click += new System.EventHandler(this.ToolTipCarregar_Click);
            // 
            // execuçãoToolStripMenuItem
            // 
            this.execuçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStart,
            this.processamentoSequencialToolStripMenuItem});
            this.execuçãoToolStripMenuItem.Name = "execuçãoToolStripMenuItem";
            this.execuçãoToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.execuçãoToolStripMenuItem.Text = "Execução de processo";
            // 
            // ToolStripStart
            // 
            this.ToolStripStart.Name = "ToolStripStart";
            this.ToolStripStart.Size = new System.Drawing.Size(152, 22);
            this.ToolStripStart.Text = "Unitário";
            this.ToolStripStart.Click += new System.EventHandler(this.ToolStripStart_Click);
            // 
            // processamentoSequencialToolStripMenuItem
            // 
            this.processamentoSequencialToolStripMenuItem.Name = "processamentoSequencialToolStripMenuItem";
            this.processamentoSequencialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.processamentoSequencialToolStripMenuItem.Text = "Sequencial";
            this.processamentoSequencialToolStripMenuItem.Click += new System.EventHandler(this.processamentoSequencialToolStripMenuItem_Click);
            // 
            // btnfinish
            // 
            this.btnfinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfinish.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnfinish.Location = new System.Drawing.Point(616, 3);
            this.btnfinish.Name = "btnfinish";
            this.btnfinish.Size = new System.Drawing.Size(91, 26);
            this.btnfinish.TabIndex = 0;
            this.btnfinish.Tag = "";
            this.btnfinish.Text = "Finalizar tarefa";
            this.btnfinish.UseVisualStyleBackColor = true;
            this.btnfinish.Click += new System.EventHandler(this.btnfinish_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.74194F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.25806F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(710, 29);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // ProcessCount
            // 
            this.ProcessCount.Interval = 1000;
            this.ProcessCount.Tick += new System.EventHandler(this.ProcessCount_Tick);
            // 
            // listProcessos
            // 
            this.listProcessos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listProcessos.Location = new System.Drawing.Point(0, 53);
            this.listProcessos.Name = "listProcessos";
            this.listProcessos.Size = new System.Drawing.Size(710, 429);
            this.listProcessos.TabIndex = 7;
            this.listProcessos.UseCompatibleStateImageBehavior = false;
            this.listProcessos.View = System.Windows.Forms.View.Details;
            this.listProcessos.SelectedIndexChanged += new System.EventHandler(this.listProcessos_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.7031F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.2969F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel2.Controls.Add(this.btnfinish, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 482);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(710, 44);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 526);
            this.Controls.Add(this.listProcessos);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitor de Processos";
            this.Load += new System.EventHandler(this.frmmain_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolTipCarregar;
        private System.Windows.Forms.Button btnfinish;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem execuçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripStart;
        private System.Windows.Forms.Timer ProcessCount;
        private System.Windows.Forms.ToolStripMenuItem processamentoSequencialToolStripMenuItem;
        private System.Windows.Forms.ListView listProcessos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

