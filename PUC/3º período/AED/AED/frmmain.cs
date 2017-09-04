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
        private static Stopwatch _ALLCOUNT = new Stopwatch();
        public static Stopwatch ALLCOUNT { get => _ALLCOUNT; }
        #region FRMMAIN INTERN
        /// <summary>
        /// Todos os metódos, quando finalizados, são salvos em uma variável de log, que será carregada no frmRelatorio
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="val"></param>
        /// <param name="result"></param>
        public static void SavarNoLog(string classe, string tipo, string result)
        {
            log.Add(classe + ":" + tipo + ">" + result);
        }
        public static void ClearStorage()
        {
            log.Clear();
        }
        /// <summary>
        /// Realinha os items do combobox
        /// </summary>
        /// <param name="cb"></param>
        private void ComboAlign(ComboBox cb)
        {
            List<int> resize = new List<int>();
            foreach (int i in cb.Items)
            {
                resize.Add(i);
            }
            resize.Sort();
            cb.DropDownHeight = 106;
            cb.Items.Clear();
            foreach (int a in resize)
            {
                cb.Items.Add(a);
            }
        }
        /// <summary>
        /// A variável de log consiste em: NOMEDACLASS:TIPO_DO_MÉTODO_DA_CLASSE->TEMPO_DE_EXECUÇÃO
        /// </summary>
        private static List<string> log = new List<string>();
        int timersleep = 50;

        #endregion

        #region GENERAL METHODS
        /// <summary>
        /// Verifica se todos os combobox estão preenchidos
        /// </summary>
        /// <returns></returns>
        private void CheckFullCMB()
        {
            if (cmbfatorial.Items.Count > 0 && cmbfibonacci.Items.Count > 0 && cmbpesquisa.Items.Count > 0 && cmbhanoi.Items.Count > 0)
            {
                EnableAllRun();
            }
            else
            {
                DisableAllRun();
            }
        }
        private void btnlimparREGISTRO_Click(object sender, EventArgs e)
        {
            foreach (Control cmb in this.Controls)
            {
                if (cmb is ComboBox)
                {
                    //Missing to do
                }
            }
        }
        /// <summary>
        /// Habilita botão de registro
        /// </summary>
        private void EnableAllRun()
        {
            btnrunREGISTRO.Enabled = true;
        }
        /// <summary>
        /// Disabilita botão de registro
        /// </summary>
        private void DisableAllRun()
        {
            btnrunREGISTRO.Enabled = false;
        }
        private void frmmain_Load(object sender, EventArgs e)
        {
            btnrunREGISTRO.Enabled = false;
        }
        private void btnresults_Click(object sender, EventArgs e)
        {
            frmRelatorio op = new frmRelatorio(log);
            op.ShowDialog();
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
            btnrunREGISTRO.Enabled = true;
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
            _ALLCOUNT.Start();
            FatorialRunCMB();
            FibonacciRunCMB();
            PesquisaRunCMB();
            _ALLCOUNT.Stop();
            List<string> solo = HanoiRunCMG();
            foreach (string han in solo)
            {
                log.Add(han);
            }
            List<string> names = new List<string>() { "FATORIAL", "FIBONACCI", "PESQUISA", "HANOI" };
            List<ComboBox> combos = new List<ComboBox>() { cmbfatorial, cmbfibonacci, cmbpesquisa, cmbhanoi };
            frmRelatorio open = new frmRelatorio(log, names, combos);
            open.ShowDialog();
        }
        #endregion

        #region FATORIAL
        private void FatorialRunCMB()
        {
            if (cmbfatorial.Items.Count > 0)
            {
                foreach (int val in cmbfatorial.Items)
                {
                    FatorialRun(Convert.ToUInt64(val));
                    //  Thread.Sleep(timersleep);
                }
            }
        }
        /// <summary>
        /// Fatorial simples para inicializar o timer.
        /// </summary>
        private void FatorialFirstRun()
        {
            Contador.Start();
            Fatorial.FatorialIterativo(5);
            string re = Contador.Stop();
            Contador.Start();
            Fatorial.FatorialRecursivo(5);
            re = Contador.Stop();
        }
        private void FatorialRun(ulong send)
        {
            Contador.Start();
            ulong val = Fatorial.FatorialIterativo(send);
            string re = Contador.Stop();
            if (re == "00:00:00")
            {
                Contador.Start();
                Fatorial.FatorialIterativo(send);
                re = Contador.Stop();
            }
            SavarNoLog("FATORIAL", "ITERATIVO", re);
            Contador.Start();
            Fatorial.FatorialRecursivo(send);
            re = Contador.Stop();
            if (re == "00:00:00")
            {
                Contador.Start();
                Fatorial.FatorialRecursivo(send);
                re = Contador.Stop();
            }
            SavarNoLog("FATORIAL", "RECURSIVO", re);
        }
        private void btnautofatorialAUTOREG_Click(object sender, EventArgs e)
        {
            cmbfatorial.Items.Clear();
            foreach (int val in Fatorial.AUTOVALS)
            {
                cmbfatorial.Items.Add(val);
            }
            cmbfatorial.Text = cmbfatorial.Items[0].ToString();
            btnfatorialRUNREGISTER.Enabled = true;
            btnfatorialREMOVE.Enabled = true;
            CheckFullCMB();
        }
        private void btnfatorialexecutar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtfatorialintvalor.Text))
            {
                ulong send;
                try
                {
                    send = Convert.ToUInt64(txtfatorialintvalor.Text);
                    _ALLCOUNT.Start();
                    FatorialFirstRun();
                    FatorialRun(send);
                    frmRelatorio open = new frmRelatorio(log);
                    _ALLCOUNT.Stop();
                    open.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("O valor informado no campo de registro de valor do Fatorial não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            txtfatorialintvalor.Text = "";
        }
        private void btnfatorialInt_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtfatorialintvalor.Text))
            {
                try
                {
                    int num = Convert.ToInt32(txtfatorialintvalor.Text);
                    Fatorial.VALS.Add(num);
                    cmbfatorial.Items.Add(num);
                    cmbfatorial.Text = num.ToString();
                    txtfatorialintvalor.Text = "";
                    txtfatorialintvalor.Focus();
                    ComboAlign(cmbfatorial);
                    btnrunREGISTRO.Enabled = true;
                    CheckFullCMB();
                }
                catch
                {
                    MessageBox.Show("O valor informado no campo de registro de valor do Fatorial não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtfatorialintvalor.Text = "";
                }
            }
        }
        private void btnfatorialREMOVE_Click(object sender, EventArgs e)
        {
            RemoveFromCMB(cmbfatorial);
            CheckFullCMB();
        }
        private void btnfatorialCLEAR_Click(object sender, EventArgs e)
        {
            cmbfatorial.DropDownHeight = 106;
            cmbfatorial.Items.Clear();
            CheckFullCMB();
        }
        private void btnfatorialRUNREGISTER_Click(object sender, EventArgs e)
        {
            if (cmbfatorial.Items.Count > 0)
            {
                _ALLCOUNT.Start();
                FatorialFirstRun();
                FatorialRunCMB();
                _ALLCOUNT.Stop();
                frmRelatorio open = new frmRelatorio(log, "FATORIAL", cmbfatorial);
                open.ShowDialog();
            }
        }
        #endregion

        #region FIBONACCI
        /// <summary>
        /// Fibonacci simples para inicializar o timer.
        /// </summary>
        private void FibonacciFirstRun()
        {
            long teste = 5;
            Contador.Start();
            Fibonacci.FibonacciIterativo(teste);
            string timer1 = Contador.Stop();
            Contador.Start();
            Fibonacci.FibonacciRecursivo(teste);
            string timer = Contador.Stop();
        }
        private void FibonacciRun(long val)
        {
            Contador.Start();
            Fibonacci.FibonacciIterativo(val);
            string re = Contador.Stop();
            if (re == "00:00:00")
            {
                Contador.Start();
                Fibonacci.FibonacciIterativo(val);
                re = Contador.Stop();
            }
            SavarNoLog("FIBONACCI", "ITERATIVO", re);
            Contador.Start();
            Fibonacci.FibonacciRecursivo(val);
            re = Contador.Stop();
            if (re == "00:00:00")
            {
                Contador.Start();
                Fibonacci.FibonacciRecursivo(val);
                re = Contador.Stop();
            }
            SavarNoLog("FIBONACCI", "RECURSIVO", re);
        }
        private void FibonacciRunCMB()
        {
            if (cmbfibonacci.Items.Count > 0)
            {
                foreach (int val in cmbfibonacci.Items)
                {
                    FibonacciRun(Convert.ToInt64(val));
                }
            }
        }
        private void btnfibonacciRUNREGISTER_Click(object sender, EventArgs e)
        {
            FibonacciFirstRun();
            _ALLCOUNT.Start();
            FibonacciRunCMB();
            _ALLCOUNT.Stop();
            frmRelatorio open = new frmRelatorio(log, "FIBONACCI", cmbfibonacci);
            open.ShowDialog();
        }
        private void btnfibonacciAUTOREG_Click(object sender, EventArgs e)
        {
            cmbfibonacci.Items.Clear();
            foreach (int val in Fibonacci.AUTOVALS)
            {
                cmbfibonacci.Items.Add(val);
            }
            cmbfibonacci.Text = cmbfibonacci.Items[0].ToString();
            btnfibonacciREMOVE.Enabled = true;
            btnfibonacciCLEAR.Enabled = true;
            CheckFullCMB();
        }
        private void btnfibonacciexecute_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtfibonaccivalor.Text))
            {
                try
                {
                    FibonacciFirstRun();
                    _ALLCOUNT.Start();
                    FibonacciRun(Convert.ToInt64(txtfibonaccivalor.Text));
                    _ALLCOUNT.Stop();
                    frmRelatorio open = new frmRelatorio(log);
                    open.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("O valor informado no campo de registro de valor do Fatorial não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtfibonaccivalor.Text = "";
                }
            }
        }

        private void btnfibonacciREG_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtfibonaccivalor.Text);
                Fibonacci.VALS.Add(num);
                cmbfibonacci.Items.Add(num);
                cmbfibonacci.Text = num.ToString();
                txtfibonaccivalor.Text = "";
                txtfibonaccivalor.Focus();
                ComboAlign(cmbfibonacci);
                CheckFullCMB();
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
            CheckFullCMB();
        }
        private void btnfibonacciCLEAR_Click(object sender, EventArgs e)
        {
            cmbfibonacci.Items.Clear();
            CheckFullCMB();
        }
        #endregion

        #region PESQUISA
        private void PesquisaFirstRun()
        {
            long[] send = new long[5];
            Contador.Start();
            Pesquisa.PesquisaBinaria(send, 2, 0, send.Length - 1);
            string re = Contador.Stop();
            Contador.Start();
            Pesquisa.PesquisaSequencial(send, 2);
            re = Contador.Stop();
        }
        private void PesquisaRun(long size)
        {
            long[] send = new long[size];
            for (int i = 0; i < size; i++)
            {
                send[i] = i;
            }
            long val = Convert.ToInt64(size + 1);
            PesquisaFirstRun();
            Contador.Start();
            Pesquisa.PesquisaBinaria(send, val, 0, send.Length - 1);
            string re = Contador.Stop();
            if (re == "00:00:00")
            {
                Contador.Start();
                Pesquisa.PesquisaBinaria(send, val, 0, send.Length - 1);
                re = Contador.Stop();
            }
            SavarNoLog("PESQUISA", "RECURSIVO", re);
            Contador.Start();
            Pesquisa.PesquisaSequencial(send, val);
            re = Contador.Stop();
            if (re == "00:00:00")
            {
                Contador.Start();
                Pesquisa.PesquisaBinaria(send, val, 0, send.Length - 1);
                re = Contador.Stop();
            }
            SavarNoLog("PESQUISA", "SEQUENCIAL", re);
        }
        private void PesquisaRunCMB()
        {
            if (cmbpesquisa.Items.Count > 0)
            {
                foreach (int val in cmbpesquisa.Items)
                {
                    PesquisaRun(Convert.ToInt64(val));
                    Thread.Sleep(timersleep);
                }
            }
        }
        private void btnpesquisaRUNREGISTER_Click(object sender, EventArgs e)
        {
            _ALLCOUNT.Start();
            PesquisaRunCMB();
            _ALLCOUNT.Stop();
            frmRelatorio open = new frmRelatorio(log, "PESQUISA", cmbpesquisa);
            open.ShowDialog();
        }
        private void btnpesquisaAUTOREG_Click(object sender, EventArgs e)
        {
            cmbpesquisa.Items.Clear();
            foreach (int val in Pesquisa.AUTOVALS)
            {
                cmbpesquisa.Items.Add(val);
            }
            cmbpesquisa.Text = cmbpesquisa.Items[0].ToString();
            CheckFullCMB();
        }
        private void btnpesquisaexecutar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtpesquisavetortamanho.Text))
            {
                try
                {
                    long send = Convert.ToInt64(txtpesquisavetortamanho.Text);
                    _ALLCOUNT.Start();
                    PesquisaRun(send);
                    _ALLCOUNT.Stop();
                    frmRelatorio open = new frmRelatorio(log);
                    open.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("O valor informado no campo de registro de valor  não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpesquisavetortamanho.Text = "";
                }
            }
        }

        private void btnpesquisaREG_Click(object sender, EventArgs e)
        {
            try
            {
                int vectorsize = Convert.ToInt32(txtpesquisavetortamanho.Text);
                Pesquisa.VAL.Add(vectorsize);
                cmbpesquisa.Items.Add(vectorsize);
                cmbpesquisa.Text = vectorsize.ToString();
                txtpesquisavetortamanho.Text = "";
                txtpesquisavetortamanho.Focus();
                ComboAlign(cmbpesquisa);
                CheckFullCMB();
            }
            catch
            {
                MessageBox.Show("O valor informado no campo de registro de valor  não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpesquisavetortamanho.Text = "";
            }
        }
        private void btnpesquisaREMOVE_Click(object sender, EventArgs e)
        {
            RemoveFromCMB(cmbpesquisa);
            CheckFullCMB();
        }
        private void btnpesquisaCLEAR_Click(object sender, EventArgs e)
        {
            cmbpesquisa.Items.Clear();
            CheckFullCMB();
        }
        #endregion

        #region HANOI
        private void HanoiFirstRun()
        {
            Stack<int>[] all = new Stack<int>[3];
            all[0] = new Stack<int>();
            all[1] = new Stack<int>();
            all[2] = new Stack<int>();
            all[0].Push(1);
            Contador.Start();
            Hanoi.BuildHanoi(all, 0, 1, 2, 1);
            Contador.Stop();
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
            string re = Contador.Stop();
            if (re == "00:00:00")
            {
                Contador.Start();
                Hanoi.BuildHanoi(all, 0, 1, 2, blocks);

                g = Hanoi.GetHesult();
                re = Contador.Stop();
            }
            return hanoilog = blocks + ";" + g + ";" + re;
        }
        private List<string> HanoiRunCMG()
        {
            List<string> hanoilog = new List<string>();
            foreach (int val in cmbhanoi.Items)
            {
                hanoilog.Add(HanoiRun(val));
                // Thread.Sleep(timersleep);
            }
            return hanoilog;
        }
        private void btnhanoiAUTOREG_Click(object sender, EventArgs e)
        {
            cmbhanoi.Items.Clear();
            foreach (int val in Hanoi.AUTOVALS)
            {
                cmbhanoi.Items.Add(val);
            }
            cmbhanoi.Text = cmbhanoi.Items[0].ToString();
            CheckFullCMB();
        }
        private void btnhanoiexecute_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txthanoivalor.Text))
            {
                try
                {
                    int blocks = Convert.ToInt32(txthanoivalor.Text);
                    HanoiFirstRun();
                    _ALLCOUNT.Start();
                    HanoiRun(blocks);
                    _ALLCOUNT.Stop();
                    frmRelatorio open = new frmRelatorio(HanoiRun(blocks));
                    open.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("O valor informado no campo de registro de valor  não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txthanoivalor.Text = "";
                }
            }
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
                txthanoivalor.Focus();
                ComboAlign(cmbhanoi);
                CheckFullCMB();
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
            CheckFullCMB();
        }
        private void btnhanoiCLEAR_Click(object sender, EventArgs e)
        {
            cmbhanoi.Items.Clear();
            CheckFullCMB();
        }
        private void btnhanoiRUNREGISTER_Click(object sender, EventArgs e)
        {
            if (cmbhanoi.Items.Count > 0)
            {
                _ALLCOUNT.Start();
                HanoiFirstRun();
                _ALLCOUNT.Stop();
                List<string> getresult = HanoiRunCMG();
                frmRelatorio open = new frmRelatorio(getresult, "HANOI", cmbhanoi);
                open.ShowDialog();
            }
        }

        #endregion
    }
}
