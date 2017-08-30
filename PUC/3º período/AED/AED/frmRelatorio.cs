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

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            if(hanoilog != null)
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
    }
}
