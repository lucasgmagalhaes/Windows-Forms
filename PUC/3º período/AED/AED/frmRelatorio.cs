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

        List<Fatorial> FatorialInfos = new List<Fatorial>();
        List<Fibonacci> FibonacciInfos = new List<Fibonacci>();
        List<Pesquisa> PesquisaInfos = new List<Pesquisa>();
        List<Hanoi> HanoiInfos = new List<Hanoi>();

        public frmRelatorio(List<string> args)
        {
            log = args;
            InitializeComponent();
        }

        public frmRelatorio(string arg)
        {
            hanoilog = arg;
            InitializeComponent();
        }

        public frmRelatorio(List<string> args, string arg)
        {
            hanoilog = arg;
            log = args;
            InitializeComponent();
        }
        public frmRelatorio(List<string> args, string name, ComboBox combo)
        {
            InitializeComponent();
            switch (name)
            {
                case "FATORIAL":

                    cmbfatorial.Enabled = true;
                    foreach (int v in combo.Items)
                    {
                        Fatorial fact = new Fatorial();
                        fact.val = v;
                        string[] spl = args[0].Split('>');
                        fact.iterativo_resul = double.Parse(spl[1]);
                        args.RemoveAt(0);
                        string[] spl1 = args[0].Split('>');
                        fact.recursivo_resul = double.Parse(spl1[1]);
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
                        fibo.iterativo_resul = double.Parse(spl[1]);
                        args.RemoveAt(0);
                        string[] spl1 = args[0].Split('>');
                        fibo.recursivo_resul = double.Parse(spl1[1]);
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
                        pesq.sequencial_resul = double.Parse(spl[1]);
                        args.RemoveAt(0);
                        string[] spl1 = args[0].Split('>');
                        pesq.binaria_resul = double.Parse(spl1[1]);
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
                        hano.tempo = double.Parse(spl[2]);
                        args.RemoveAt(0);
                        HanoiInfos.Add(hano);
                        cmbhanoi.Items.Add(v);
                    }
                    break;
            }
        }
        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            cmbformatresult.Text = cmbformatresult.Items[0].ToString();
            if (hanoilog != null)
            {
                string[] result = hanoilog.Split(';');
                txthanoitamanho.Text = result[0];
                txthanoioperacoes.Text = result[1];
                txthanoitempo.Text = result[2];
                hanoilog = null;
            }
            if (log != null)
            {
                for (int i = 0; i < log.Count; i++)
                {

                    string[] splitnome = log[i].Split(':');
                    string[] splitval = splitnome[1].Split('>');

                    if (splitnome[0] == "FATORIAL")
                    {
                        if (splitval[0] == "ITERATIVO")
                        {
                            txtfactorialrecursivo.Text = splitval[1];
                        }
                        else
                        {
                            txtfatorialiterativo.Text = splitval[1];
                        }
                    }
                    else if (splitnome[0] == "FIBONACCI")
                    {
                        if (splitval[0] == "ITERATIVO")
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
                        if (splitval[0] == "SEQUENCIAL")
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
            frmmain.ClearStorage();
        }

        private void cmbformatresult_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach (Control ctrl in this.Controls)
            //{
            //    if (ctrl is GroupBox)
            //    {
            //        foreach (TextBox ct in ctrl.Controls.OfType<TextBox>())
            //        {
            //            if (!String.IsNullOrEmpty(ct.Text))
            //            {
            //                if (cmbformatresult.Text == cmbformatresult.Items[0].ToString()) //Mili
            //                {
            //                    double val = Convert.ToDouble(ct.Text);
            //                    ct.Text = TimeSpan.FromMilliseconds(val).TotalMinutes.ToString(); //Seg
            //                }

            //                else if (cmbformatresult.Text == cmbformatresult.Items[1].ToString())//Min
            //                {

            //                }
            //                else if (cmbformatresult.Text == cmbformatresult.Items[2].ToString())//Horas
            //                {

            //                }
            //                else if (cmbformatresult.Text == cmbformatresult.Items[3].ToString())//Dias
            //                {

            //                }
            //                else
            //                {

            //                }
            //            }
            //        }
            //    }
            //}

        }
    }
}
