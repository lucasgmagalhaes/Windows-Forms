using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace AED
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Todos os metódos, quando finalizados, são salvos em uma variável de log, que será carregada no frmRelatorio
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="val"></param>
        /// <param name="result"></param>
        public static void SavarNoLog(string classe, string tipo, string val, string result)
        {
            frmmain.log.Add(classe + ":" + tipo + ">" + result);
        }
        /// <summary>
        /// A variável de log consiste em: NOMEDACLASS:TIPO_DO_MÉTODO_DA_CLASSE->TEMPO_DE_EXECUÇÃO
        /// </summary>
        public static List<string> log = new List<string>();
        private static long teste;

        private void frmmain_Load(object sender, EventArgs e)
        {
            Stack<int>[] all = new Stack<int>[3];
            all[0] = new Stack<int>(3);
            all[1] = new Stack<int>(3);
            all[2] = new Stack<int>(3);
            all[0].Push(3);
            all[0].Push(2);
            all[0].Push(1);
            //BuildHanoi(all, 0, 2, 1, 3);
        }

        private void btnfatorialexecutar_Click(object sender, EventArgs e)
        {
            ulong teste = Convert.ToUInt64(txtfatorialintvalor.Text);
            Fatorial.FatorialRecursivo(teste);
            Fatorial.FatorialIterativo(teste);
            frmRelatorio open = new frmRelatorio(log);
            open.ShowDialog();
        }

        private void btnautofatorialReg_Click(object sender, EventArgs e)
        {

        }

        private void btnfibonacciexecute_Click(object sender, EventArgs e)
        {
            LoadPanel.Visible = true;
            Backgrounduuh.RunWorkerAsync();
            teste = Convert.ToInt64(txtfibonaccivalor.Text);
            frmRelatorio open = new frmRelatorio(log);
            open.ShowDialog();
        }
        private void Backgrounduuh_DoWork(object sender, DoWorkEventArgs e)
        {
            Fibonacci.FibonacciIterativo(teste);
            Thread nova = new Thread(testes);
            nova.Start();
        }
        private void testes()
        {
            Fibonacci.FibonacciRecursivo(teste);
        }

        private void btnfatorialInt_Click(object sender, EventArgs e)
        {
            int num = 1;
            try
            {
                num = Convert.ToInt32(txtfatorialintvalor.Text);
            }
            catch
            {
                MessageBox.Show("O valor informado no campo de registro de valor do Fatorial não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Fatorial.VALS.Add(num);
            cmbfatorial.Items.Add(num);
        }

        private void btnpesquisaexecutar_Click(object sender, EventArgs e)
        {
            long[] send = new long[Convert.ToUInt64(txtpesquisavetortamanho.Text)];
            long val = Convert.ToInt64(txtpesquisapesquisarpor.Text);
            Pesquisa.PesquisaBinaria(send, val, 0, send.Length -1);
            Pesquisa.PesquisaSequencial(send, val);
            frmRelatorio open = new frmRelatorio(log);
            open.ShowDialog();
        }
    }
}
