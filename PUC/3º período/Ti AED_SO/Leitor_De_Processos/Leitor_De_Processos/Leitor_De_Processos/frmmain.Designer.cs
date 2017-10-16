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
            this.processamentoSequencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pararExecuçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pararToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marcarProcessoEmExecuçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separarPrioridadesPorCoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.velocidadeDeProcessamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolSpeed1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolSpeed2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolSpeed3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnfinish = new System.Windows.Forms.Button();
            this.listProcessos = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ListFinalizados = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.listlog = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblc4 = new System.Windows.Forms.Label();
            this.lblc5 = new System.Windows.Forms.Label();
            this.lblc3 = new System.Windows.Forms.Label();
            this.lbllist = new System.Windows.Forms.Label();
            this.lblc1 = new System.Windows.Forms.Label();
            this.lblc2 = new System.Windows.Forms.Label();
            this.lbltimercount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelcolor4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelcolor1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelcolor2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelcolor3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelcolor5 = new System.Windows.Forms.Panel();
            this.lblfinalizados = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblspeed = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.Cicle_Run = new System.ComponentModel.BackgroundWorker();
            this.Timer_Processing = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.execuçãoToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.informaçõesDoSistemaToolStripMenuItem,
            this.exercíciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolTipCarregar});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.ShortcutKeyDisplayString = "d";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // ToolTipCarregar
            // 
            this.ToolTipCarregar.Name = "ToolTipCarregar";
            this.ToolTipCarregar.Size = new System.Drawing.Size(152, 22);
            this.ToolTipCarregar.Text = "Carregar lista";
            this.ToolTipCarregar.Click += new System.EventHandler(this.ToolTipCarregar_Click);
            // 
            // execuçãoToolStripMenuItem
            // 
            this.execuçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processamentoSequencialToolStripMenuItem,
            this.pararExecuçãoToolStripMenuItem,
            this.pararToolStripMenuItem});
            this.execuçãoToolStripMenuItem.Name = "execuçãoToolStripMenuItem";
            this.execuçãoToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.execuçãoToolStripMenuItem.Text = "Execução de processo";
            // 
            // processamentoSequencialToolStripMenuItem
            // 
            this.processamentoSequencialToolStripMenuItem.Name = "processamentoSequencialToolStripMenuItem";
            this.processamentoSequencialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.processamentoSequencialToolStripMenuItem.Text = "Iniciar";
            this.processamentoSequencialToolStripMenuItem.ToolTipText = "Executa todos os processos com base na sua prioridade";
            this.processamentoSequencialToolStripMenuItem.Click += new System.EventHandler(this.processamentoSequencialToolStripMenuItem_Click);
            // 
            // pararExecuçãoToolStripMenuItem
            // 
            this.pararExecuçãoToolStripMenuItem.Name = "pararExecuçãoToolStripMenuItem";
            this.pararExecuçãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pararExecuçãoToolStripMenuItem.Text = "Pausar";
            this.pararExecuçãoToolStripMenuItem.ToolTipText = "Pausa o processo de execução";
            this.pararExecuçãoToolStripMenuItem.Click += new System.EventHandler(this.pararExecuçãoToolStripMenuItem_Click);
            // 
            // pararToolStripMenuItem
            // 
            this.pararToolStripMenuItem.Name = "pararToolStripMenuItem";
            this.pararToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pararToolStripMenuItem.Text = "Parar";
            this.pararToolStripMenuItem.ToolTipText = "Interrompe a execução do(s) processo(s)";
            this.pararToolStripMenuItem.Click += new System.EventHandler(this.pararToolStripMenuItem_Click);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.marcarProcessoEmExecuçãoToolStripMenuItem,
            this.separarPrioridadesPorCoresToolStripMenuItem,
            this.velocidadeDeProcessamentoToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeyDisplayString = "";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
            this.toolStripMenuItem1.Text = "Acompanhar execução";
            this.toolStripMenuItem1.ToolTipText = "Marca automaticamente o processo que está sendo executado";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // marcarProcessoEmExecuçãoToolStripMenuItem
            // 
            this.marcarProcessoEmExecuçãoToolStripMenuItem.Checked = true;
            this.marcarProcessoEmExecuçãoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.marcarProcessoEmExecuçãoToolStripMenuItem.Name = "marcarProcessoEmExecuçãoToolStripMenuItem";
            this.marcarProcessoEmExecuçãoToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.marcarProcessoEmExecuçãoToolStripMenuItem.Text = "Marcar processo em execução";
            this.marcarProcessoEmExecuçãoToolStripMenuItem.Click += new System.EventHandler(this.marcarProcessoEmExecuçãoToolStripMenuItem_Click);
            // 
            // separarPrioridadesPorCoresToolStripMenuItem
            // 
            this.separarPrioridadesPorCoresToolStripMenuItem.Name = "separarPrioridadesPorCoresToolStripMenuItem";
            this.separarPrioridadesPorCoresToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.separarPrioridadesPorCoresToolStripMenuItem.Text = "Separar prioridades por cores";
            this.separarPrioridadesPorCoresToolStripMenuItem.Click += new System.EventHandler(this.separarPrioridadesPorCoresToolStripMenuItem_Click);
            // 
            // velocidadeDeProcessamentoToolStripMenuItem
            // 
            this.velocidadeDeProcessamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolSpeed1,
            this.ToolSpeed2,
            this.ToolSpeed3});
            this.velocidadeDeProcessamentoToolStripMenuItem.Name = "velocidadeDeProcessamentoToolStripMenuItem";
            this.velocidadeDeProcessamentoToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.velocidadeDeProcessamentoToolStripMenuItem.Text = "Velocidade de processamento";
            // 
            // ToolSpeed1
            // 
            this.ToolSpeed1.Checked = true;
            this.ToolSpeed1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolSpeed1.Name = "ToolSpeed1";
            this.ToolSpeed1.Size = new System.Drawing.Size(119, 22);
            this.ToolSpeed1.Text = "x10ms";
            this.ToolSpeed1.Click += new System.EventHandler(this.ToolSpeed1_Click);
            // 
            // ToolSpeed2
            // 
            this.ToolSpeed2.Name = "ToolSpeed2";
            this.ToolSpeed2.Size = new System.Drawing.Size(119, 22);
            this.ToolSpeed2.Text = "x100ms";
            this.ToolSpeed2.Click += new System.EventHandler(this.ToolSpeed2_Click);
            // 
            // ToolSpeed3
            // 
            this.ToolSpeed3.Name = "ToolSpeed3";
            this.ToolSpeed3.Size = new System.Drawing.Size(119, 22);
            this.ToolSpeed3.Text = "x1000ms";
            this.ToolSpeed3.Click += new System.EventHandler(this.ToolSpeed3_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // informaçõesDoSistemaToolStripMenuItem
            // 
            this.informaçõesDoSistemaToolStripMenuItem.Name = "informaçõesDoSistemaToolStripMenuItem";
            this.informaçõesDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.informaçõesDoSistemaToolStripMenuItem.Text = "Informações do sistema";
            this.informaçõesDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.informaçõesDoSistemaToolStripMenuItem_Click);
            // 
            // exercíciosToolStripMenuItem
            // 
            this.exercíciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.exercíciosToolStripMenuItem.Name = "exercíciosToolStripMenuItem";
            this.exercíciosToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.exercíciosToolStripMenuItem.Text = "Exercícios";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(89, 22);
            this.toolStripMenuItem3.Text = "3.6";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // btnfinish
            // 
            this.btnfinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfinish.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnfinish.Location = new System.Drawing.Point(712, 3);
            this.btnfinish.Name = "btnfinish";
            this.btnfinish.Size = new System.Drawing.Size(120, 30);
            this.btnfinish.TabIndex = 0;
            this.btnfinish.Tag = "";
            this.btnfinish.Text = "Finalizar Processo";
            this.btnfinish.UseVisualStyleBackColor = true;
            this.btnfinish.Click += new System.EventHandler(this.btnfinish_Click);
            // 
            // listProcessos
            // 
            this.listProcessos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listProcessos.Location = new System.Drawing.Point(3, 3);
            this.listProcessos.Name = "listProcessos";
            this.listProcessos.Size = new System.Drawing.Size(821, 440);
            this.listProcessos.TabIndex = 7;
            this.listProcessos.UseCompatibleStateImageBehavior = false;
            this.listProcessos.View = System.Windows.Forms.View.Details;
            this.listProcessos.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listProcessos_ColumnClick);
            this.listProcessos.SelectedIndexChanged += new System.EventHandler(this.listProcessos_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.83334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.Controls.Add(this.btnfinish, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 563);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(835, 44);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 474);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listProcessos);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(827, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Processos Execução";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ListFinalizados);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(827, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Finalizados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ListFinalizados
            // 
            this.ListFinalizados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListFinalizados.Location = new System.Drawing.Point(3, 3);
            this.ListFinalizados.Name = "ListFinalizados";
            this.ListFinalizados.Size = new System.Drawing.Size(821, 440);
            this.ListFinalizados.TabIndex = 8;
            this.ListFinalizados.UseCompatibleStateImageBehavior = false;
            this.ListFinalizados.View = System.Windows.Forms.View.Details;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(827, 446);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Informações";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tableLayoutPanel3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(827, 446);
            this.panel7.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 474F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.tableLayoutPanel3.Controls.Add(this.listlog, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 292F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(827, 446);
            this.tableLayoutPanel3.TabIndex = 24;
            // 
            // listlog
            // 
            this.listlog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listlog.FormattingEnabled = true;
            this.listlog.ItemHeight = 15;
            this.listlog.Location = new System.Drawing.Point(3, 229);
            this.listlog.Name = "listlog";
            this.listlog.Size = new System.Drawing.Size(468, 286);
            this.listlog.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.lbltimercount);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.lblfinalizados);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 220);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Processamento";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblc4);
            this.groupBox4.Controls.Add(this.lblc5);
            this.groupBox4.Controls.Add(this.lblc3);
            this.groupBox4.Controls.Add(this.lbllist);
            this.groupBox4.Controls.Add(this.lblc1);
            this.groupBox4.Controls.Add(this.lblc2);
            this.groupBox4.Location = new System.Drawing.Point(133, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(149, 177);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Prioridades";
            // 
            // lblc4
            // 
            this.lblc4.AutoSize = true;
            this.lblc4.Location = new System.Drawing.Point(14, 53);
            this.lblc4.Name = "lblc4";
            this.lblc4.Size = new System.Drawing.Size(21, 15);
            this.lblc4.TabIndex = 18;
            this.lblc4.Text = "C4";
            // 
            // lblc5
            // 
            this.lblc5.AutoSize = true;
            this.lblc5.Location = new System.Drawing.Point(14, 26);
            this.lblc5.Name = "lblc5";
            this.lblc5.Size = new System.Drawing.Size(21, 15);
            this.lblc5.TabIndex = 22;
            this.lblc5.Text = "C5";
            // 
            // lblc3
            // 
            this.lblc3.AutoSize = true;
            this.lblc3.Location = new System.Drawing.Point(14, 77);
            this.lblc3.Name = "lblc3";
            this.lblc3.Size = new System.Drawing.Size(21, 15);
            this.lblc3.TabIndex = 19;
            this.lblc3.Text = "C3";
            // 
            // lbllist
            // 
            this.lbllist.AutoSize = true;
            this.lbllist.Location = new System.Drawing.Point(6, 151);
            this.lbllist.Name = "lbllist";
            this.lbllist.Size = new System.Drawing.Size(105, 15);
            this.lbllist.TabIndex = 16;
            this.lbllist.Text = "Processos na lista: ";
            // 
            // lblc1
            // 
            this.lblc1.AutoSize = true;
            this.lblc1.Location = new System.Drawing.Point(14, 129);
            this.lblc1.Name = "lblc1";
            this.lblc1.Size = new System.Drawing.Size(21, 15);
            this.lblc1.TabIndex = 21;
            this.lblc1.Text = "C1";
            // 
            // lblc2
            // 
            this.lblc2.AutoSize = true;
            this.lblc2.Location = new System.Drawing.Point(14, 105);
            this.lblc2.Name = "lblc2";
            this.lblc2.Size = new System.Drawing.Size(21, 15);
            this.lblc2.TabIndex = 20;
            this.lblc2.Text = "C2";
            // 
            // lbltimercount
            // 
            this.lbltimercount.AutoSize = true;
            this.lbltimercount.Location = new System.Drawing.Point(288, 57);
            this.lbltimercount.Name = "lbltimercount";
            this.lbltimercount.Size = new System.Drawing.Size(116, 15);
            this.lbltimercount.TabIndex = 24;
            this.lbltimercount.Text = "Tempo em execução";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelcolor4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.panelcolor1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.panelcolor2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.panelcolor3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.panelcolor5);
            this.groupBox2.Location = new System.Drawing.Point(4, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 177);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Níveis de prioridde ";
            // 
            // panelcolor4
            // 
            this.panelcolor4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(190)))));
            this.panelcolor4.Location = new System.Drawing.Point(39, 52);
            this.panelcolor4.Name = "panelcolor4";
            this.panelcolor4.Size = new System.Drawing.Size(49, 24);
            this.panelcolor4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "5";
            // 
            // panelcolor1
            // 
            this.panelcolor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.panelcolor1.Location = new System.Drawing.Point(39, 124);
            this.panelcolor1.Name = "panelcolor1";
            this.panelcolor1.Size = new System.Drawing.Size(49, 24);
            this.panelcolor1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "4";
            // 
            // panelcolor2
            // 
            this.panelcolor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(175)))), ((int)(((byte)(221)))));
            this.panelcolor2.Location = new System.Drawing.Point(39, 100);
            this.panelcolor2.Name = "panelcolor2";
            this.panelcolor2.Size = new System.Drawing.Size(49, 24);
            this.panelcolor2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "3";
            // 
            // panelcolor3
            // 
            this.panelcolor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(214)))));
            this.panelcolor3.Location = new System.Drawing.Point(39, 76);
            this.panelcolor3.Name = "panelcolor3";
            this.panelcolor3.Size = new System.Drawing.Size(49, 24);
            this.panelcolor3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "1";
            // 
            // panelcolor5
            // 
            this.panelcolor5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(25)))), ((int)(((byte)(117)))));
            this.panelcolor5.Location = new System.Drawing.Point(39, 28);
            this.panelcolor5.Name = "panelcolor5";
            this.panelcolor5.Size = new System.Drawing.Size(49, 24);
            this.panelcolor5.TabIndex = 0;
            // 
            // lblfinalizados
            // 
            this.lblfinalizados.AutoSize = true;
            this.lblfinalizados.Location = new System.Drawing.Point(287, 27);
            this.lblfinalizados.Name = "lblfinalizados";
            this.lblfinalizados.Size = new System.Drawing.Size(121, 15);
            this.lblfinalizados.TabIndex = 17;
            this.lblfinalizados.Text = "Processos finalizados:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 458F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(835, 65);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblspeed);
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Em execução";
            // 
            // lblspeed
            // 
            this.lblspeed.AutoSize = true;
            this.lblspeed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblspeed.Location = new System.Drawing.Point(9, 39);
            this.lblspeed.Name = "lblspeed";
            this.lblspeed.Size = new System.Drawing.Size(170, 15);
            this.lblspeed.TabIndex = 3;
            this.lblspeed.Text = "Velocidade de processamento: ";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(113, 18);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(43, 15);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblid.Location = new System.Drawing.Point(8, 20);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 15);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID:";
            // 
            // Cicle_Run
            // 
            this.Cicle_Run.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Cicle_Run_DoWork);
            this.Cicle_Run.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Cicle_Run_ProgressChanged);
            this.Cicle_Run.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Cicle_Run_RunWorkerCompleted);
            // 
            // Timer_Processing
            // 
            this.Timer_Processing.Interval = 1000;
            this.Timer_Processing.Tick += new System.EventHandler(this.Timer_Processing_Tick);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 607);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitor de Processos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmmain_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolTipCarregar;
        private System.Windows.Forms.Button btnfinish;
        private System.Windows.Forms.ToolStripMenuItem execuçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processamentoSequencialToolStripMenuItem;
        private System.Windows.Forms.ListView listProcessos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pararExecuçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pararToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker Cicle_Run;
        private System.Windows.Forms.ToolStripMenuItem marcarProcessoEmExecuçãoToolStripMenuItem;
        private System.Windows.Forms.ListView ListFinalizados;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelcolor4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelcolor1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelcolor2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelcolor3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelcolor5;
        private System.Windows.Forms.ToolStripMenuItem separarPrioridadesPorCoresToolStripMenuItem;
        private System.Windows.Forms.Label lblfinalizados;
        private System.Windows.Forms.Label lbllist;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblc5;
        private System.Windows.Forms.Label lblc1;
        private System.Windows.Forms.Label lblc4;
        private System.Windows.Forms.Label lblc2;
        private System.Windows.Forms.Label lblc3;
        private System.Windows.Forms.Timer Timer_Processing;
        private System.Windows.Forms.Label lbltimercount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem velocidadeDeProcessamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolSpeed1;
        private System.Windows.Forms.ToolStripMenuItem ToolSpeed2;
        private System.Windows.Forms.ToolStripMenuItem ToolSpeed3;
        private System.Windows.Forms.Label lblspeed;
        private System.Windows.Forms.ListBox listlog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStripMenuItem informaçõesDoSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

