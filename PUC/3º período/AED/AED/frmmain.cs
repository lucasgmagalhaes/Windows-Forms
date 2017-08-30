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

        #region FRMMAIN INTERN
        /// <summary>
        /// Todos os metódos, quando finalizados, são salvos em uma variável de log, que será carregada no frmRelatorio
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="val"></param>
        /// <param name="result"></param>
        public static void SavarNoLog(string classe, string tipo, double result)
        {
            log.Add(classe + ":" + tipo + ">" + result);
        }
        public static void ClearStorage()
        {
            log.Clear();
        }
        /// <summary>
        /// A variável de log consiste em: NOMEDACLASS:TIPO_DO_MÉTODO_DA_CLASSE->TEMPO_DE_EXECUÇÃO
        /// </summary>
        private static List<string> log = new List<string>();
        private static long teste;
        #endregion

        #region GENERAL METHODS
        private void frmmain_Load(object sender, EventArgs e)
        {
            btnresults.Enabled = false;
            btnallrun.Enabled = false;
        }
        private void btnallregister_Click(object sender, EventArgs e)
        {
            cmbfatorial.Items.Clear();
            cmbfibonacci.Items.Clear();
            cmbpesquisa.Items.Clear();
            cmbhanoi.Items.Clear();

            foreach (int val in Fatorial.AUTOVALS)
            {
                cmbfatorial.Items.Add(val);
            }
            cmbfatorial.Text = cmbfatorial.Items[0].ToString();
            foreach (int val in Fibonacci.AUTOVALS)
            {
                cmbfibonacci.Items.Add(val);
            }
            cmbfibonacci.Text = cmbfibonacci.Items[0].ToString();
            foreach (int val in Pesquisa.AUTOVALS)
            {
                cmbpesquisa.Items.Add(val);
            }
            cmbpesquisa.Text = cmbpesquisa.Items[0].ToString();
            foreach (int val in Hanoi.AUTOVALS)
            {
                cmbhanoi.Items.Add(val);
            }
            cmbhanoi.Text = cmbhanoi.Items[0].ToString();
            btnallrun.Enabled = true;
        }
        private void RemoveFromCMB(ComboBox combo)
        {
            int val = Convert.ToInt32(combo.SelectedItem);
            combo.Items.Remove(val);
            if (combo.Items.Count > 0)
            {
                combo.Text = combo.Items[0].ToString();
            }
        }
        private void btnallrun_Click(object sender, EventArgs e)
        {
            FatorialRun();
            FibonacciRun();
            PesquisaRun();
            string gethanoi = HanoiRun();
            frmRelatorio open = new frmRelatorio(log, HanoiRun());
            open.ShowDialog();
        }
        #endregion

        #region FATORIAL
        private void FatorialRun()
        {
            ulong teste = Convert.ToUInt64(txtfatorialintvalor.Text);
            Contador.Start();
            Fatorial.FatorialIterativo(teste);
            SavarNoLog("FATORIAL", "ITERATIVO", Contador.Stop());
            Contador.Start();
            Fatorial.FatorialRecursivo(teste);
            SavarNoLog("FATORIAL", "RECURSIVO", Contador.Stop());
        }
        private void FatorialRun(ulong send)
        {
            Contador.Start();
            Fatorial.FatorialIterativo(send);
            SavarNoLog("FATORIAL", "ITERATIVO", Contador.Stop());
            Contador.Start();
            Fatorial.FatorialRecursivo(send);
            SavarNoLog("FATORIAL", "RECURSIVO", Contador.Stop());
        }
        private void btnautofatorialAUTOREG_Click(object sender, EventArgs e)
        {
            cmbfatorial.Items.Clear();
            foreach (int val in Fatorial.AUTOVALS)
            {
                cmbfatorial.Items.Add(val);
            }
            cmbfatorial.Text = cmbfatorial.Items[0].ToString();
        }
        private void btnfatorialexecutar_Click(object sender, EventArgs e)
        {
            FatorialRun();
            frmRelatorio open = new frmRelatorio(log);
            open.ShowDialog();
        }
        private void btnfatorialInt_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtfatorialintvalor.Text);
                Fatorial.VALS.Add(num);
                cmbfatorial.Items.Add(num);
                cmbfatorial.Text = num.ToString();
                txtfatorialintvalor.Text = "";
            }
            catch
            {
                MessageBox.Show("O valor informado no campo de registro de valor do Fatorial não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfatorialintvalor.Text = "";
            }
        }
        private void btnfatorialREMOVE_Click(object sender, EventArgs e)
        {
            RemoveFromCMB(cmbfatorial);
        }

        private void btnfatorialCLEAR_Click(object sender, EventArgs e)
        {
            cmbfatorial.Items.Clear();
        }
        private void btnfatorialRUNREGISTER_Click(object sender, EventArgs e)
        {
            if (cmbfatorial.Items.Count > 0)
            {
                foreach (int val in cmbfatorial.Items)
                {
                    FatorialRun(Convert.ToUInt64(val));
                }
                frmRelatorio open = new frmRelatorio(log, "FATORIAL", cmbfatorial);
                open.ShowDialog();
            }
        }
        #endregion

        #region FIBONACCI
        private void FibonacciRun()
        {
            teste = Convert.ToInt64(txtfibonaccivalor.Text);
            Fibonacci.FibonacciIterativo(teste);
            Contador.Start();
            Fibonacci.FibonacciRecursivo(teste);
            double timer = Contador.Stop();
            SavarNoLog("FIBONACCI", "RECURSIVO", timer);
        }
        private void FibonacciRun(long val)
        {
            Contador.Start();
            Fibonacci.FibonacciIterativo(val);
            SavarNoLog("FIBONACCI", "ITERATIVO", Contador.Stop());
            Contador.Start();
            Fibonacci.FibonacciRecursivo(val);
            double timer = Contador.Stop();
            SavarNoLog("FIBONACCI", "RECURSIVO", timer);
        }
        private void btnfibonacciRUNREGISTER_Click(object sender, EventArgs e)
        {
            if (cmbfibonacci.Items.Count > 0)
            {
                foreach (int val in cmbfibonacci.Items)
                {
                    FibonacciRun(Convert.ToInt64(val));
                }
                frmRelatorio open = new frmRelatorio(log, "FIBONACCI", cmbfibonacci);
                open.ShowDialog();
            }
        }
        private void btnfibonacciAUTOREG_Click(object sender, EventArgs e)
        {
            cmbfibonacci.Items.Clear();
            foreach (int val in Fibonacci.AUTOVALS)
            {
                cmbfibonacci.Items.Add(val);
            }
            cmbfibonacci.Text = cmbfibonacci.Items[0].ToString();
        }
        private void btnfibonacciexecute_Click(object sender, EventArgs e)
        {
            FibonacciRun();
            frmRelatorio open = new frmRelatorio(log);
            open.ShowDialog();
        }

        private void btnfibonacciREG_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtfibonaccivalor.Text);
                Fibonacci.VALS.Add(num);
                cmbfibonacci.Items.Add(num);
                cmbfatorial.Text = num.ToString();
                txtfibonaccivalor.Text = "";
            }
            catch
            {
                MessageBox.Show("O valor informado no campo de registro de valor  não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfibonaccivalor.Text = "";
            }
        }
        private void btnfibonacciREMOVE_Click(object sender, EventArgs e)
        {
            RemoveFromCMB(cmbfibonacci);
        }
        private void btnfibonacciCLEAR_Click(object sender, EventArgs e)
        {
            cmbfibonacci.Items.Clear();
        }
        #endregion

        #region PESQUISA
        private void PesquisaRun()
        {
            long[] send = new long[Convert.ToUInt64(txtpesquisavetortamanho.Text)];
            long val = Convert.ToInt64(txtpesquisapesquisarpor.Text);
            Contador.Start();
            Pesquisa.PesquisaBinaria(send, val, 0, send.Length - 1);
            frmmain.SavarNoLog("PESQUISA", "RECURSIVO", Contador.Stop());
            Contador.Start();
            Pesquisa.PesquisaSequencial(send, val);
            SavarNoLog("PESQUISA", "SEQUENCIAL", Contador.Stop());
        }
        private void PesquisaRun(long size)
        {
            long[] send = new long[size];
            long val = Convert.ToInt64(size+1);
            Contador.Start();
            Pesquisa.PesquisaBinaria(send, val, 0, send.Length - 1);
            frmmain.SavarNoLog("PESQUISA", "RECURSIVO", Contador.Stop());
            Contador.Start();
            Pesquisa.PesquisaSequencial(send, val);
            SavarNoLog("PESQUISA", "SEQUENCIAL", Contador.Stop());
        }
        private void btnpesquisaRUNREGISTER_Click(object sender, EventArgs e)
        {
            if (cmbpesquisa.Items.Count > 0)
            {
                foreach (int val in cmbpesquisa.Items)
                {
                    PesquisaRun(Convert.ToInt64(val));
                }
                frmRelatorio open = new frmRelatorio(log, "PESQUISA", cmbpesquisa);
                open.ShowDialog();
            }
        }
        private void btnpesquisaAUTOREG_Click(object sender, EventArgs e)
        {
            cmbpesquisa.Items.Clear();
            foreach (int val in Pesquisa.AUTOVALS)
            {
                cmbpesquisa.Items.Add(val);
            }
            cmbpesquisa.Text = cmbpesquisa.Items[0].ToString();
        }
        private void btnpesquisaexecutar_Click(object sender, EventArgs e)
        {
            PesquisaRun();
            frmRelatorio open = new frmRelatorio(log);
            open.ShowDialog();
        }

        private void btnpesquisaREG_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtpesquisapesquisarpor.Text);
                int vectorsize = Convert.ToInt32(txtpesquisavetortamanho.Text);
                Pesquisa.VAL.Add(num, vectorsize);
                cmbpesquisa.Items.Add(num + " -> " + vectorsize + "[]");
                cmbpesquisa.Text = num + " -> " + vectorsize + "[]";
                cmbpesquisa.Text = num.ToString();
                txtpesquisapesquisarpor.Text = "";
                txtpesquisavetortamanho.Text = "";
            }
            catch
            {
                MessageBox.Show("O valor informado no campo de registro de valor  não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpesquisapesquisarpor.Text = "";
                txtpesquisavetortamanho.Text = "";
            }
        }
        private void btnpesquisaREMOVE_Click(object sender, EventArgs e)
        {
            RemoveFromCMB(cmbpesquisa);
        }
        private void btnpesquisaCLEAR_Click(object sender, EventArgs e)
        {
            cmbpesquisa.Items.Clear();
        }
        #endregion

        #region HANOI
        private string HanoiRun(string hanoilog = "")
        {
            Stack<int>[] all = new Stack<int>[3];
            int discos = int.Parse(txthanoivalor.Text);

            all[0] = all[1] = all[2] = new Stack<int>(discos);
            for (int i = discos; i > 0; i--)
            {
                all[0].Push(i);
            }

            Contador.Start();
            Hanoi.BuildHanoi(all, 0, 1, 2, discos);

            int moves = Hanoi.GetHesult();
            return hanoilog = discos + ";" + moves + ";" + Contador.Stop();
        }
        private string HanoiRun(int blocks, string hanoilog = "")
        {
            Stack<int>[] all = new Stack<int>[3];

            all[0] = all[1] = all[2] = new Stack<int>(blocks);
            for (int i = blocks; i > 0; i--)
            {
                all[0].Push(i);
            }

            Contador.Start();
            Hanoi.BuildHanoi(all, 0, 1, 2, blocks);

            int g = Hanoi.GetHesult();
            return hanoilog = blocks + ";" + g + ";" + Contador.Stop();
        }
        private void btnhanoiAUTOREG_Click(object sender, EventArgs e)
        {
            cmbhanoi.Items.Clear();
            foreach (int val in Hanoi.AUTOVALS)
            {
                cmbhanoi.Items.Add(val);
            }
            cmbhanoi.Text = cmbhanoi.Items[0].ToString();
        }
        private void btnhanoiexecute_Click(object sender, EventArgs e)
        {
            HanoiRun();
            frmRelatorio open = new frmRelatorio(HanoiRun());
            open.ShowDialog();
        }
        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txthanoivalor.Text);
                Hanoi.VAL.Add(num);
                cmbhanoi.Items.Add(num);
                cmbhanoi.Text = num.ToString();
                txthanoivalor.Text = "";
            }
            catch
            {
                MessageBox.Show("O valor informado no campo de registro de valor não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthanoivalor.Text = "";
            }
        }
        private void btnhanoiREMOVE_Click(object sender, EventArgs e)
        {
            RemoveFromCMB(cmbhanoi);
        }
        private void btnhanoiCLEAR_Click(object sender, EventArgs e)
        {
            cmbhanoi.Items.Clear();
        }
        private void btnhanoiRUNREGISTER_Click(object sender, EventArgs e)
        {
            if (cmbhanoi.Items.Count > 0)
            {
                List<string> hanoilog = new List<string>();
                foreach (int val in cmbhanoi.Items)
                {
                   hanoilog.Add(HanoiRun(val));
                }

                frmRelatorio open = new frmRelatorio(hanoilog, "HANOI", cmbhanoi);
                open.ShowDialog();
            }
        }
        #endregion

    }
}
