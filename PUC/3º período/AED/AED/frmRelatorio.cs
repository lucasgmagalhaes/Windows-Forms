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
        public frmRelatorio(List<string> args)
        {
            InitializeComponent();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < frmmain.log.Count; i++)
            {

                string[] splitnome = frmmain.log[i].Split(':');
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
    }
}
