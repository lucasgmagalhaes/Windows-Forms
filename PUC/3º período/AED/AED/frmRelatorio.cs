using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AED
{
    public partial class frmRelatorio : Form
    {
        List<string> log;
        string hanoilog;
        List<string> argsalllog;
        List<Fatorial> FatorialInfos = new List<Fatorial>();
        List<Fibonacci> FibonacciInfos = new List<Fibonacci>();
        List<Pesquisa> PesquisaInfos = new List<Pesquisa>();
        List<Hanoi> HanoiInfos = new List<Hanoi>();

        #region CONSTRUCTORS
        /// <summary>
        /// Construtor referente a todas as execuções com exceção do Hanoi
        /// </summary>
        /// <param name="args">Fatorial, Fibonacci, Pesquisa</param>
        public frmRelatorio(List<string> args)
        {
            log = args;
            InitializeComponent();
        }
        /// <summary>
        /// Construtor da execução do Hanoi
        /// </summary>
        /// <param name="arg">Hanoi</param>
        public frmRelatorio(string arg)
        {
            hanoilog = arg;
            InitializeComponent();
        }
        /// <summary>
        /// Construtor da execução de todos os valores, incluindo Hanoi
        /// </summary>
        /// <param name="args">Fatorial, Fibonacci, Pesquisa</param>
        /// <param name="arg">Hanoi</param>
        public frmRelatorio(List<string> args, string arg)
        {
            hanoilog = arg;
            log = args;
            InitializeComponent();
        }
        /// <summary>
        /// Construtor para a execução de um único registro
        /// </summary>
        /// <param name="args">Resultados</param>
        /// <param name="name">Valor referente</param>
        /// <param name="combo">combobox que contem os registros</param>
        public frmRelatorio(List<string> args, string name, ComboBox combo)
        {
            InitializeComponent();
            SwitchConstructor(args, name, combo);
        }
        /// <summary>
        /// Construtor para a execução de um único registro
        /// </summary>
        /// <param name="args">Resultados</param>
        /// <param name="name">Valor referente</param>
        /// <param name="combo">combobox que contem os registros</param>
        public frmRelatorio(List<string> args, List<string> names, List<ComboBox> combos)
        {
            InitializeComponent();
            for (int i = 0; i < names.Count; i++)
            {
                SwitchConstructor(args, names[i], combos[i]);
            }
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args">Lista de valores</param>
        /// <param name="name">nome do campo</param>
        /// <param name="combo">comboboxreferente</param>
        private void SwitchConstructor(List<string> args, string name, ComboBox combo)
        {
            argsalllog = args;
            switch (name)
            {
                case "FATORIAL":

                    cmbfatorial.Enabled = true;
                    foreach (int v in combo.Items)
                    {
                        Fatorial fact = new Fatorial();
                        fact.val = v;
                        string[] spl = args[0].Split('>');
                        fact.iterativo_resul = spl[1];
                        args.RemoveAt(0);
                        string[] spl1 = args[0].Split('>');
                        fact.recursivo_resul = spl1[1];
                        args.RemoveAt(0);
                        FatorialInfos.Add(fact);
                        cmbfatorial.Items.Add(v);
                    }
                    break;
                case "FIBONACCI":
                    cmbfibonacci.Enabled = true;
                    foreach (int v in combo.Items)
                    {
                        Fibonacci fibo = new Fibonacci();
                        fibo.val = v;
                        string[] spl = args[0].Split('>');
                        fibo.iterativo_resul = (spl[1]);
                        args.RemoveAt(0);
                        string[] spl1 = args[0].Split('>');
                        fibo.recursivo_resul = spl1[1];
                        args.RemoveAt(0);
                        FibonacciInfos.Add(fibo);
                        cmbfibonacci.Items.Add(v);
                    }
                    break;
                case "PESQUISA":
                    cmbpesquisa.Enabled = true;
                    foreach (int v in combo.Items)
                    {
                        Pesquisa pesq = new Pesquisa();
                        pesq.val = v;
                        string[] spl = args[0].Split('>');
                        pesq.binaria_resul = spl[1];
                        args.RemoveAt(0);
                        string[] spl1 = args[0].Split('>');
                        pesq.sequencial_resul = spl1[1];
                        args.RemoveAt(0);
                        PesquisaInfos.Add(pesq);
                        cmbpesquisa.Items.Add(v);
                    }
                    break;
                case "HANOI":
                    cmbhanoi.Enabled = true;
                    foreach (int v in combo.Items)
                    {
                        Hanoi hano = new Hanoi();
                        hano.discos = v;
                        string[] spl = args[0].Split(';');
                        hano.moves = int.Parse(spl[1]);
                        hano.tempo = spl[2];
                        args.RemoveAt(0);
                        HanoiInfos.Add(hano);
                        cmbhanoi.Items.Add(v);
                    }
                    break;
            }
        }

        private void AllLog()
        {
            for (int i = 0; i < log.Count; i++)
            {

                string[] splitnome = log[i].Split(':');
                string[] splitval = log[i].Split('>');

                if (splitnome[0] == "FATORIAL")
                {
                    if (splitval[0] == "FATORIAL:ITERATIVO")
                    {
                        txtfatorialiterativo.Text = splitval[1];
                    }
                    else
                    {
                        txtfactorialrecursivo.Text = splitval[1];
                    }
                }
                else if (splitnome[0] == "FIBONACCI")
                {
                    if (splitval[0] == "FIBONACCI:ITERATIVO")
                    {
                        txtfibonacciiterativo.Text = splitval[1];
                    }
                    else
                    {
                        txtfibonaccirecursivo.Text = splitval[1];
                    }
                }
                else if (splitnome[0] == "PESQUISA")
                {
                    if (splitval[0] == "PESQUISA:SEQUENCIAL")
                    {
                        txtpesquisasequencial.Text = splitval[1];
                    }
                    else
                    {
                        txtpesuisabinaria.Text = splitval[1];
                    }
                }
            }

        }

        private void HanoiLog()
        {
            string[] result = hanoilog.Split(';');
            txthanoitamanho.Text = result[0];
            txthanoioperacoes.Text = result[1];
            txthanoitempo.Text = result[2];
            hanoilog = null;
        }

        private void ListLog()
        {
            if (FatorialInfos.Count > 0)
            {
                cmbfatorial.Text = FatorialInfos[0].val.ToString();
                txtfactorialrecursivo.Text = FatorialInfos[0].recursivo_resul;
                txtfatorialiterativo.Text = FatorialInfos[0].iterativo_resul;
            }
            if (FibonacciInfos.Count > 0)
            {
                cmbfibonacci.Text = FibonacciInfos[0].val.ToString();
                txtfibonaccirecursivo.Text = FibonacciInfos[0].recursivo_resul;
                txtfibonacciiterativo.Text = FibonacciInfos[0].iterativo_resul;
            }
            if (PesquisaInfos.Count > 0)
            {
                cmbpesquisa.Text = PesquisaInfos[0].ToString();
                txtpesquisasequencial.Text = PesquisaInfos[0].sequencial_resul;
                txtpesuisabinaria.Text = PesquisaInfos[0].binaria_resul;
            }
            if (PesquisaInfos.Count > 0)
            {
                cmbpesquisa.Text = PesquisaInfos[0].val.ToString();
                txtpesquisasequencial.Text = PesquisaInfos[0].sequencial_resul;
                txtpesuisabinaria.Text = PesquisaInfos[0].binaria_resul;
            }
            if (HanoiInfos.Count > 0)
            {
                cmbhanoi.Text = HanoiInfos[0].discos.ToString();
                txthanoitamanho.Text = HanoiInfos[0].discos.ToString();
                txthanoioperacoes.Text = HanoiInfos[0].moves.ToString();
                txthanoitempo.Text = HanoiInfos[0].tempo;
            }
        }
        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            lblfulltime.Text += "  " + frmmain.ALLCOUNT.Elapsed;
            if (cmbfatorial.Items.Count > 0 && cmbfibonacci.Items.Count > 0 && cmbpesquisa.Items.Count > 0 && cmbhanoi.Items.Count > 0)
            {
                ListLog();
            }
            {
                if (log != null)
                {
                    AllLog();
                }
                if (!string.IsNullOrEmpty(hanoilog))
                {
                    HanoiLog();
                }
            }
        }

        private void cmbformatresult_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void cmbfatorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = int.Parse(cmbfatorial.SelectedItem.ToString());

            for (int i = 0; i < FatorialInfos.Count; i++)
            {
                if (FatorialInfos[i].val == selected)
                {
                    selected = i;
                    break;
                }
            }
            cmbfatorial.Text = FatorialInfos[selected].val.ToString();
            txtfactorialrecursivo.Text = FatorialInfos[selected].recursivo_resul;
            txtfatorialiterativo.Text = FatorialInfos[selected].iterativo_resul;
        }

        private void cmbfibonacci_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = int.Parse(cmbfibonacci.SelectedItem.ToString());

            for (int i = 0; i < FibonacciInfos.Count; i++)
            {
                if (FibonacciInfos[i].val == selected)
                {
                    selected = i;
                    break;
                }
            }
            cmbfibonacci.Text = FibonacciInfos[selected].val.ToString();
            txtfibonaccirecursivo.Text = FibonacciInfos[selected].recursivo_resul;
            txtfibonacciiterativo.Text = FibonacciInfos[selected].iterativo_resul;
        }

        private void cmbpesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = int.Parse(cmbpesquisa.SelectedItem.ToString());

            for (int i = 0; i < PesquisaInfos.Count; i++)
            {
                if (PesquisaInfos[i].val == selected)
                {
                    selected = i;
                    break;
                }
            }
            cmbpesquisa.Text = PesquisaInfos[selected].val.ToString();
            txtpesuisabinaria.Text = PesquisaInfos[selected].binaria_resul;
            txtpesquisasequencial.Text = PesquisaInfos[selected].sequencial_resul;
        }

        private void cmbhanoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = int.Parse(cmbhanoi.SelectedItem.ToString());

            for (int i = 0; i < HanoiInfos.Count; i++)
            {
                if (HanoiInfos[i].discos == selected)
                {
                    selected = i;
                    break;
                }
            }
            cmbhanoi.Text = HanoiInfos[selected].discos.ToString();
            txthanoitamanho.Text = HanoiInfos[selected].discos.ToString();
            txthanoioperacoes.Text = HanoiInfos[selected].moves.ToString();
            txthanoitempo.Text = HanoiInfos[selected].tempo;
        }
    }
}
