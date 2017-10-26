using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leitor_Contas.Classes;
namespace Leitor_Contas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Arvore pessoas = new Arvore();
        private Arvore contas = new Arvore();
        private void btnabrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(open.FileName) == ".TXT")
                {
                    txtfile.Text = open.FileName;
                    try
                    {
                        using (StreamReader read = new StreamReader(open.FileName))
                        {
                            string line;
                            while ((line = read.ReadLine()) != null)
                            {
                                string[] spt = line.Split(';');
                                Titular pessoa = new Titular(spt[1]);
                                ListViewItem item1 = new ListViewItem();
                                item1.Text = spt[0];
                                Conta conta;
                                if (spt[2] == "1")
                                {
                                    conta = new Energia(int.Parse(spt[0]), 0, 0, 0, pessoa);
                                    item1.SubItems.Add("Energia");
                                }
                                else
                                {
                                    conta = new Agua(int.Parse(spt[0]), 0, 0, 0, pessoa);
                                    item1.SubItems.Add("Agua");
                                }
                                Titular aux = (Titular)pessoas.Procurar(pessoa);
                                if (aux == null)
                                {
                                    pessoa.AddConta(conta);
                                    pessoas.Inserir(pessoa);
                                }
                                else aux.AddConta(conta);
                                contas.Inserir(conta);
                                listcontas.Items.Add(item1);
                                ListViewItem item = new ListViewItem();
                                item.Text = spt[1];
                                item.SubItems.Add(spt[2]);
                                listpeople.Items.Add(item);
                            }
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (pessoas.Count > 1)
            {
                string val = txtpesquisar.Text;
                Titular get = (Titular)pessoas.Procurar(val);
                ListViewItem item = new ListViewItem();
                if (get != null)
                {
                    lbltitular.Text = "Titular: " + get.CPF.ToString();

                    foreach (Conta cont in get.Contas)
                    {
                        item = new ListViewItem();
                        item.Text = cont.Id.ToString();
                        if (cont.GetTipo() == 1) item.SubItems.Add("Energia");
                        else item.SubItems.Add("Água");
                        item.SubItems.Add(cont.Mes.ToString());
                        item.SubItems.Add(cont.Leitura_anterior.ToString());
                        item.SubItems.Add(cont.Leitura_atual.ToString());
                        listresultp.Items.Add(item);
                    }
                }
                else
                {
                    Conta aux = (Conta)contas.Procurar(Convert.ToInt32(val));
                    if (aux != null)
                    {
                        lbltitular.Text = "Titular: " + aux.Pessoa.CPF.ToString();

                        item = new ListViewItem();
                        item.Text = aux.Id.ToString();
                        if (aux.GetTipo() == 1) item.SubItems.Add("Energia");
                        else item.SubItems.Add("Água");
                        item.SubItems.Add(aux.Mes.ToString());
                        item.SubItems.Add(aux.Leitura_anterior.ToString());
                        item.SubItems.Add(aux.Leitura_atual.ToString());
                        listresultp.Items.Add(item);
                    }
                }
            }
            else txtpesquisar.Text = "";
        }
    }
}
