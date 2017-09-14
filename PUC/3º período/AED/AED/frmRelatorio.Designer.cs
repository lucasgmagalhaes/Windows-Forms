namespace AED
{
    partial class frmRelatorio
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
            this.groupfatorial = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtfatorialiterativo = new System.Windows.Forms.TextBox();
            this.cmbfatorial = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfactorialrecursivo = new System.Windows.Forms.TextBox();
            this.groupfibonacci = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbfibonacci = new System.Windows.Forms.ComboBox();
            this.txtfibonacciiterativo = new System.Windows.Forms.TextBox();
            this.txtfibonaccirecursivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grouppesquisa = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbpesquisa = new System.Windows.Forms.ComboBox();
            this.txtpesquisasequencial = new System.Windows.Forms.TextBox();
            this.txtpesuisabinaria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grouphanoi = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbhanoi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txthanoitempo = new System.Windows.Forms.TextBox();
            this.txthanoitamanho = new System.Windows.Forms.TextBox();
            this.txthanoioperacoes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblfulltime = new System.Windows.Forms.Label();
            this.groupfatorial.SuspendLayout();
            this.groupfibonacci.SuspendLayout();
            this.grouppesquisa.SuspendLayout();
            this.grouphanoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupfatorial
            // 
            this.groupfatorial.Controls.Add(this.label10);
            this.groupfatorial.Controls.Add(this.txtfatorialiterativo);
            this.groupfatorial.Controls.Add(this.cmbfatorial);
            this.groupfatorial.Controls.Add(this.label3);
            this.groupfatorial.Controls.Add(this.label1);
            this.groupfatorial.Controls.Add(this.txtfactorialrecursivo);
            this.groupfatorial.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupfatorial.Location = new System.Drawing.Point(12, 47);
            this.groupfatorial.Name = "groupfatorial";
            this.groupfatorial.Size = new System.Drawing.Size(478, 112);
            this.groupfatorial.TabIndex = 6;
            this.groupfatorial.TabStop = false;
            this.groupfatorial.Text = "Fatorial";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Exibir resultados de:";
            // 
            // txtfatorialiterativo
            // 
            this.txtfatorialiterativo.Location = new System.Drawing.Point(167, 46);
            this.txtfatorialiterativo.Name = "txtfatorialiterativo";
            this.txtfatorialiterativo.ReadOnly = true;
            this.txtfatorialiterativo.Size = new System.Drawing.Size(167, 21);
            this.txtfatorialiterativo.TabIndex = 3;
            // 
            // cmbfatorial
            // 
            this.cmbfatorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfatorial.Enabled = false;
            this.cmbfatorial.FormattingEnabled = true;
            this.cmbfatorial.Location = new System.Drawing.Point(167, 73);
            this.cmbfatorial.Name = "cmbfatorial";
            this.cmbfatorial.Size = new System.Drawing.Size(167, 23);
            this.cmbfatorial.TabIndex = 12;
            this.cmbfatorial.SelectedIndexChanged += new System.EventHandler(this.cmbfatorial_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Iterativo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recursivo";
            // 
            // txtfactorialrecursivo
            // 
            this.txtfactorialrecursivo.Location = new System.Drawing.Point(167, 20);
            this.txtfactorialrecursivo.Name = "txtfactorialrecursivo";
            this.txtfactorialrecursivo.ReadOnly = true;
            this.txtfactorialrecursivo.Size = new System.Drawing.Size(167, 21);
            this.txtfactorialrecursivo.TabIndex = 1;
            // 
            // groupfibonacci
            // 
            this.groupfibonacci.Controls.Add(this.label12);
            this.groupfibonacci.Controls.Add(this.cmbfibonacci);
            this.groupfibonacci.Controls.Add(this.txtfibonacciiterativo);
            this.groupfibonacci.Controls.Add(this.txtfibonaccirecursivo);
            this.groupfibonacci.Controls.Add(this.label4);
            this.groupfibonacci.Controls.Add(this.label2);
            this.groupfibonacci.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupfibonacci.Location = new System.Drawing.Point(12, 165);
            this.groupfibonacci.Name = "groupfibonacci";
            this.groupfibonacci.Size = new System.Drawing.Size(478, 112);
            this.groupfibonacci.TabIndex = 7;
            this.groupfibonacci.TabStop = false;
            this.groupfibonacci.Text = "Fibonacci";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Exibir resultados de:";
            // 
            // cmbfibonacci
            // 
            this.cmbfibonacci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfibonacci.Enabled = false;
            this.cmbfibonacci.FormattingEnabled = true;
            this.cmbfibonacci.Location = new System.Drawing.Point(167, 77);
            this.cmbfibonacci.Name = "cmbfibonacci";
            this.cmbfibonacci.Size = new System.Drawing.Size(167, 23);
            this.cmbfibonacci.TabIndex = 14;
            this.cmbfibonacci.SelectedIndexChanged += new System.EventHandler(this.cmbfibonacci_SelectedIndexChanged);
            // 
            // txtfibonacciiterativo
            // 
            this.txtfibonacciiterativo.Location = new System.Drawing.Point(167, 47);
            this.txtfibonacciiterativo.Name = "txtfibonacciiterativo";
            this.txtfibonacciiterativo.ReadOnly = true;
            this.txtfibonacciiterativo.Size = new System.Drawing.Size(167, 21);
            this.txtfibonacciiterativo.TabIndex = 3;
            // 
            // txtfibonaccirecursivo
            // 
            this.txtfibonaccirecursivo.Location = new System.Drawing.Point(167, 20);
            this.txtfibonaccirecursivo.Name = "txtfibonaccirecursivo";
            this.txtfibonaccirecursivo.ReadOnly = true;
            this.txtfibonaccirecursivo.Size = new System.Drawing.Size(167, 21);
            this.txtfibonaccirecursivo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Recursivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Iterativo";
            // 
            // grouppesquisa
            // 
            this.grouppesquisa.Controls.Add(this.label11);
            this.grouppesquisa.Controls.Add(this.cmbpesquisa);
            this.grouppesquisa.Controls.Add(this.txtpesquisasequencial);
            this.grouppesquisa.Controls.Add(this.txtpesuisabinaria);
            this.grouppesquisa.Controls.Add(this.label5);
            this.grouppesquisa.Controls.Add(this.label6);
            this.grouppesquisa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouppesquisa.Location = new System.Drawing.Point(12, 283);
            this.grouppesquisa.Name = "grouppesquisa";
            this.grouppesquisa.Size = new System.Drawing.Size(478, 127);
            this.grouppesquisa.TabIndex = 8;
            this.grouppesquisa.TabStop = false;
            this.grouppesquisa.Text = "Pesquisa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Exibir resultados de:";
            // 
            // cmbpesquisa
            // 
            this.cmbpesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpesquisa.Enabled = false;
            this.cmbpesquisa.FormattingEnabled = true;
            this.cmbpesquisa.Location = new System.Drawing.Point(167, 83);
            this.cmbpesquisa.Name = "cmbpesquisa";
            this.cmbpesquisa.Size = new System.Drawing.Size(167, 23);
            this.cmbpesquisa.TabIndex = 14;
            this.cmbpesquisa.SelectedIndexChanged += new System.EventHandler(this.cmbpesquisa_SelectedIndexChanged);
            // 
            // txtpesquisasequencial
            // 
            this.txtpesquisasequencial.Location = new System.Drawing.Point(167, 57);
            this.txtpesquisasequencial.Name = "txtpesquisasequencial";
            this.txtpesquisasequencial.ReadOnly = true;
            this.txtpesquisasequencial.Size = new System.Drawing.Size(167, 21);
            this.txtpesquisasequencial.TabIndex = 3;
            // 
            // txtpesuisabinaria
            // 
            this.txtpesuisabinaria.Location = new System.Drawing.Point(167, 30);
            this.txtpesuisabinaria.Name = "txtpesuisabinaria";
            this.txtpesuisabinaria.ReadOnly = true;
            this.txtpesuisabinaria.Size = new System.Drawing.Size(167, 21);
            this.txtpesuisabinaria.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sequencial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Binária";
            // 
            // grouphanoi
            // 
            this.grouphanoi.Controls.Add(this.label13);
            this.grouphanoi.Controls.Add(this.cmbhanoi);
            this.grouphanoi.Controls.Add(this.label9);
            this.grouphanoi.Controls.Add(this.txthanoitempo);
            this.grouphanoi.Controls.Add(this.txthanoitamanho);
            this.grouphanoi.Controls.Add(this.txthanoioperacoes);
            this.grouphanoi.Controls.Add(this.label8);
            this.grouphanoi.Controls.Add(this.label7);
            this.grouphanoi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouphanoi.Location = new System.Drawing.Point(12, 416);
            this.grouphanoi.Name = "grouphanoi";
            this.grouphanoi.Size = new System.Drawing.Size(478, 145);
            this.grouphanoi.TabIndex = 9;
            this.grouphanoi.TabStop = false;
            this.grouphanoi.Text = "Hanoi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "Exibir resultados de:";
            // 
            // cmbhanoi
            // 
            this.cmbhanoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbhanoi.Enabled = false;
            this.cmbhanoi.FormattingEnabled = true;
            this.cmbhanoi.Location = new System.Drawing.Point(167, 106);
            this.cmbhanoi.Name = "cmbhanoi";
            this.cmbhanoi.Size = new System.Drawing.Size(167, 23);
            this.cmbhanoi.TabIndex = 14;
            this.cmbhanoi.SelectedIndexChanged += new System.EventHandler(this.cmbhanoi_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Operações totais";
            // 
            // txthanoitempo
            // 
            this.txthanoitempo.Location = new System.Drawing.Point(167, 80);
            this.txthanoitempo.Name = "txthanoitempo";
            this.txthanoitempo.ReadOnly = true;
            this.txthanoitempo.Size = new System.Drawing.Size(167, 21);
            this.txthanoitempo.TabIndex = 3;
            // 
            // txthanoitamanho
            // 
            this.txthanoitamanho.Location = new System.Drawing.Point(167, 26);
            this.txthanoitamanho.Name = "txthanoitamanho";
            this.txthanoitamanho.ReadOnly = true;
            this.txthanoitamanho.Size = new System.Drawing.Size(167, 21);
            this.txthanoitamanho.TabIndex = 1;
            // 
            // txthanoioperacoes
            // 
            this.txthanoioperacoes.Location = new System.Drawing.Point(167, 53);
            this.txthanoioperacoes.Name = "txthanoioperacoes";
            this.txthanoioperacoes.ReadOnly = true;
            this.txthanoioperacoes.Size = new System.Drawing.Size(167, 21);
            this.txthanoioperacoes.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tamanho ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tempo de execução";
            // 
            // lblfulltime
            // 
            this.lblfulltime.AutoSize = true;
            this.lblfulltime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfulltime.Location = new System.Drawing.Point(14, 14);
            this.lblfulltime.Name = "lblfulltime";
            this.lblfulltime.Size = new System.Drawing.Size(251, 16);
            this.lblfulltime.TabIndex = 13;
            this.lblfulltime.Text = "Tempo total  decorrido de processamento:";
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 570);
            this.Controls.Add(this.lblfulltime);
            this.Controls.Add(this.grouphanoi);
            this.Controls.Add(this.grouppesquisa);
            this.Controls.Add(this.groupfibonacci);
            this.Controls.Add(this.groupfatorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de processamento";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            this.groupfatorial.ResumeLayout(false);
            this.groupfatorial.PerformLayout();
            this.groupfibonacci.ResumeLayout(false);
            this.groupfibonacci.PerformLayout();
            this.grouppesquisa.ResumeLayout(false);
            this.grouppesquisa.PerformLayout();
            this.grouphanoi.ResumeLayout(false);
            this.grouphanoi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupfatorial;
        private System.Windows.Forms.TextBox txtfatorialiterativo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfactorialrecursivo;
        private System.Windows.Forms.GroupBox groupfibonacci;
        private System.Windows.Forms.TextBox txtfibonacciiterativo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfibonaccirecursivo;
        private System.Windows.Forms.GroupBox grouppesquisa;
        private System.Windows.Forms.TextBox txtpesquisasequencial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpesuisabinaria;
        private System.Windows.Forms.GroupBox grouphanoi;
        private System.Windows.Forms.TextBox txthanoitempo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txthanoitamanho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txthanoioperacoes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbfatorial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbfibonacci;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbpesquisa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbhanoi;
        private System.Windows.Forms.Label lblfulltime;
    }
}