namespace AutoBlockConfigs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TimerCheckProcessExecute = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtmsg = new System.Windows.Forms.RichTextBox();
            this.txtto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsearchfooter = new System.Windows.Forms.Button();
            this.txtfooter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtSMTP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkMonday = new System.Windows.Forms.CheckBox();
            this.checkTuesday = new System.Windows.Forms.CheckBox();
            this.checkThursday = new System.Windows.Forms.CheckBox();
            this.checkSunday = new System.Windows.Forms.CheckBox();
            this.checkSaturday = new System.Windows.Forms.CheckBox();
            this.checkWednesday = new System.Windows.Forms.CheckBox();
            this.checkFriday = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.combohora = new System.Windows.Forms.ComboBox();
            this.combominuto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtport = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalve = new System.Windows.Forms.Button();
            this.checkEnableTimer = new System.Windows.Forms.CheckBox();
            this.checkenableall = new System.Windows.Forms.CheckBox();
            this.btnconectar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerCheckProcessExecute
            // 
            this.TimerCheckProcessExecute.Interval = 500;
            this.TimerCheckProcessExecute.Tick += new System.EventHandler(this.TimerCheckProcessExecute_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "BloqueadosPDFAuto";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // txtmsg
            // 
            this.txtmsg.Location = new System.Drawing.Point(87, 82);
            this.txtmsg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(660, 176);
            this.txtmsg.TabIndex = 10;
            this.txtmsg.Text = "";
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(87, 26);
            this.txtto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtto.MaxLength = 300;
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(660, 21);
            this.txtto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Para";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsearchfooter);
            this.groupBox2.Controls.Add(this.txtfooter);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtmsg);
            this.groupBox2.Controls.Add(this.txtto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txttitle);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(9, 262);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(754, 306);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurações do corpo do Email";
            // 
            // btnsearchfooter
            // 
            this.btnsearchfooter.Location = new System.Drawing.Point(285, 262);
            this.btnsearchfooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsearchfooter.Name = "btnsearchfooter";
            this.btnsearchfooter.Size = new System.Drawing.Size(87, 26);
            this.btnsearchfooter.TabIndex = 21;
            this.btnsearchfooter.Text = "Procurar";
            this.btnsearchfooter.UseVisualStyleBackColor = true;
            this.btnsearchfooter.Click += new System.EventHandler(this.btnsearchfooter_Click);
            // 
            // txtfooter
            // 
            this.txtfooter.Enabled = false;
            this.txtfooter.Location = new System.Drawing.Point(87, 266);
            this.txtfooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfooter.Name = "txtfooter";
            this.txtfooter.Size = new System.Drawing.Size(191, 21);
            this.txtfooter.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Assinatura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Título";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mensagem";
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(87, 52);
            this.txttitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttitle.MaxLength = 60;
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(660, 21);
            this.txttitle.TabIndex = 8;
            // 
            // txtSMTP
            // 
            this.txtSMTP.Location = new System.Drawing.Point(115, 117);
            this.txtSMTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSMTP.MaxLength = 30;
            this.txtSMTP.Name = "txtSMTP";
            this.txtSMTP.Size = new System.Drawing.Size(223, 21);
            this.txtSMTP.TabIndex = 8;
            this.txtSMTP.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Servidor SMTP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Servidor de Saída (SMTP)";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(115, 84);
            this.txtpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpass.MaxLength = 30;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '•';
            this.txtpass.Size = new System.Drawing.Size(223, 21);
            this.txtpass.TabIndex = 6;
            this.txtpass.Tag = "";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(115, 52);
            this.txtuser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtuser.MaxLength = 30;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(223, 21);
            this.txtuser.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtport);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSMTP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtuser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(9, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(754, 226);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações do Usuário de envio";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(383, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(345, 198);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Definições de rotina";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkMonday);
            this.groupBox5.Controls.Add(this.checkTuesday);
            this.groupBox5.Controls.Add(this.checkThursday);
            this.groupBox5.Controls.Add(this.checkSunday);
            this.groupBox5.Controls.Add(this.checkSaturday);
            this.groupBox5.Controls.Add(this.checkWednesday);
            this.groupBox5.Controls.Add(this.checkFriday);
            this.groupBox5.Location = new System.Drawing.Point(10, 81);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(317, 97);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dias";
            // 
            // checkMonday
            // 
            this.checkMonday.AutoSize = true;
            this.checkMonday.Location = new System.Drawing.Point(7, 19);
            this.checkMonday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkMonday.Name = "checkMonday";
            this.checkMonday.Size = new System.Drawing.Size(113, 19);
            this.checkMonday.TabIndex = 18;
            this.checkMonday.Text = "Segunda  - feira";
            this.checkMonday.UseVisualStyleBackColor = true;
            this.checkMonday.CheckedChanged += new System.EventHandler(this.checksegunda_CheckedChanged);
            // 
            // checkTuesday
            // 
            this.checkTuesday.AutoSize = true;
            this.checkTuesday.Location = new System.Drawing.Point(7, 42);
            this.checkTuesday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkTuesday.Name = "checkTuesday";
            this.checkTuesday.Size = new System.Drawing.Size(90, 19);
            this.checkTuesday.TabIndex = 19;
            this.checkTuesday.Text = "Terça - feira";
            this.checkTuesday.UseVisualStyleBackColor = true;
            this.checkTuesday.CheckedChanged += new System.EventHandler(this.checksterca_CheckedChanged);
            // 
            // checkThursday
            // 
            this.checkThursday.AutoSize = true;
            this.checkThursday.Location = new System.Drawing.Point(131, 18);
            this.checkThursday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkThursday.Name = "checkThursday";
            this.checkThursday.Size = new System.Drawing.Size(96, 19);
            this.checkThursday.TabIndex = 21;
            this.checkThursday.Text = "Quinta - feira";
            this.checkThursday.UseVisualStyleBackColor = true;
            this.checkThursday.CheckedChanged += new System.EventHandler(this.checkquinta_CheckedChanged);
            // 
            // checkSunday
            // 
            this.checkSunday.AutoSize = true;
            this.checkSunday.Location = new System.Drawing.Point(236, 19);
            this.checkSunday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkSunday.Name = "checkSunday";
            this.checkSunday.Size = new System.Drawing.Size(77, 19);
            this.checkSunday.TabIndex = 24;
            this.checkSunday.Text = "Domingo";
            this.checkSunday.UseVisualStyleBackColor = true;
            this.checkSunday.CheckedChanged += new System.EventHandler(this.checkdomingo_CheckedChanged);
            // 
            // checkSaturday
            // 
            this.checkSaturday.AutoSize = true;
            this.checkSaturday.Location = new System.Drawing.Point(131, 70);
            this.checkSaturday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkSaturday.Name = "checkSaturday";
            this.checkSaturday.Size = new System.Drawing.Size(69, 19);
            this.checkSaturday.TabIndex = 23;
            this.checkSaturday.Text = "Sábado";
            this.checkSaturday.UseVisualStyleBackColor = true;
            this.checkSaturday.CheckedChanged += new System.EventHandler(this.checksabado_CheckedChanged);
            // 
            // checkWednesday
            // 
            this.checkWednesday.AutoSize = true;
            this.checkWednesday.Location = new System.Drawing.Point(7, 69);
            this.checkWednesday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkWednesday.Name = "checkWednesday";
            this.checkWednesday.Size = new System.Drawing.Size(97, 19);
            this.checkWednesday.TabIndex = 20;
            this.checkWednesday.Text = "Quarta - feira";
            this.checkWednesday.UseVisualStyleBackColor = true;
            this.checkWednesday.CheckedChanged += new System.EventHandler(this.checkquarta_CheckedChanged);
            // 
            // checkFriday
            // 
            this.checkFriday.AutoSize = true;
            this.checkFriday.Location = new System.Drawing.Point(131, 44);
            this.checkFriday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkFriday.Name = "checkFriday";
            this.checkFriday.Size = new System.Drawing.Size(90, 19);
            this.checkFriday.TabIndex = 22;
            this.checkFriday.Text = "Sexta - feira";
            this.checkFriday.UseVisualStyleBackColor = true;
            this.checkFriday.CheckedChanged += new System.EventHandler(this.checksexta_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.combohora);
            this.groupBox4.Controls.Add(this.combominuto);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(10, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(317, 67);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hora";
            // 
            // combohora
            // 
            this.combohora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combohora.DropDownWidth = 50;
            this.combohora.FormattingEnabled = true;
            this.combohora.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.combohora.Location = new System.Drawing.Point(56, 25);
            this.combohora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combohora.Name = "combohora";
            this.combohora.Size = new System.Drawing.Size(58, 23);
            this.combohora.TabIndex = 14;
            // 
            // combominuto
            // 
            this.combominuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combominuto.DropDownWidth = 50;
            this.combominuto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.combominuto.FormattingEnabled = true;
            this.combominuto.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.combominuto.Location = new System.Drawing.Point(173, 25);
            this.combominuto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combominuto.Name = "combominuto";
            this.combominuto.Size = new System.Drawing.Size(58, 23);
            this.combominuto.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Hora";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Minuto";
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(177, 146);
            this.txtport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtport.Mask = "00000";
            this.txtport.Name = "txtport";
            this.txtport.PromptChar = ' ';
            this.txtport.Size = new System.Drawing.Size(65, 21);
            this.txtport.TabIndex = 11;
            this.txtport.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // btnsalve
            // 
            this.btnsalve.Location = new System.Drawing.Point(542, 575);
            this.btnsalve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsalve.Name = "btnsalve";
            this.btnsalve.Size = new System.Drawing.Size(87, 26);
            this.btnsalve.TabIndex = 14;
            this.btnsalve.Text = "Salvar";
            this.btnsalve.UseVisualStyleBackColor = true;
            this.btnsalve.Click += new System.EventHandler(this.btnsalve_Click_1);
            // 
            // checkEnableTimer
            // 
            this.checkEnableTimer.AccessibleDescription = "sssddd";
            this.checkEnableTimer.AccessibleName = "sss";
            this.checkEnableTimer.AutoSize = true;
            this.checkEnableTimer.Location = new System.Drawing.Point(326, 579);
            this.checkEnableTimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkEnableTimer.Name = "checkEnableTimer";
            this.checkEnableTimer.Size = new System.Drawing.Size(217, 19);
            this.checkEnableTimer.TabIndex = 18;
            this.checkEnableTimer.Text = "Iniciar Acompanhamento de tempo";
            this.checkEnableTimer.UseVisualStyleBackColor = true;
            this.checkEnableTimer.CheckedChanged += new System.EventHandler(this.checkEnableTimer_CheckedChanged);
            // 
            // checkenableall
            // 
            this.checkenableall.AccessibleDescription = "sssddd";
            this.checkenableall.AccessibleName = "sss";
            this.checkenableall.AutoSize = true;
            this.checkenableall.Location = new System.Drawing.Point(9, 6);
            this.checkenableall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkenableall.Name = "checkenableall";
            this.checkenableall.Size = new System.Drawing.Size(139, 19);
            this.checkenableall.TabIndex = 19;
            this.checkenableall.Text = "Editar configurações";
            this.checkenableall.UseVisualStyleBackColor = true;
            this.checkenableall.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnconectar
            // 
            this.btnconectar.Location = new System.Drawing.Point(637, 574);
            this.btnconectar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(128, 26);
            this.btnconectar.TabIndex = 20;
            this.btnconectar.Text = "Testar Conexão";
            this.btnconectar.UseVisualStyleBackColor = true;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 608);
            this.Controls.Add(this.btnconectar);
            this.Controls.Add(this.checkenableall);
            this.Controls.Add(this.checkEnableTimer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsalve);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações para SMTP e inicialização";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerCheckProcessExecute;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.RichTextBox txtmsg;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtSMTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsalve;
        private System.Windows.Forms.CheckBox checkEnableTimer;
        private System.Windows.Forms.MaskedTextBox txtport;
        private System.Windows.Forms.CheckBox checkenableall;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combominuto;
        private System.Windows.Forms.ComboBox combohora;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkMonday;
        private System.Windows.Forms.CheckBox checkSunday;
        private System.Windows.Forms.CheckBox checkTuesday;
        private System.Windows.Forms.CheckBox checkFriday;
        private System.Windows.Forms.CheckBox checkWednesday;
        private System.Windows.Forms.CheckBox checkSaturday;
        private System.Windows.Forms.CheckBox checkThursday;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.Button btnsearchfooter;
        private System.Windows.Forms.TextBox txtfooter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

