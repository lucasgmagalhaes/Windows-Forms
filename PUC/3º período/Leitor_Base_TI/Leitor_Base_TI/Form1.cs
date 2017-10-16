using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Leitor_Base_TI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Lista Processes;

        private void Form1_Load(object sender, EventArgs e)
        {
            listallprocess.MultiSelect = false;
            listallprocess.FullRowSelect = true;
            listallprocess.Columns.Add("colPID", "PID", 70);
            listallprocess.Columns.Add("colname", "Nome", 160);
            listallprocess.Columns.Add("colprio", "Prioridade", 100);
            listallprocess.Columns.Add("coltempo", "Tempo de execução", 100);
            listallprocess.Columns.Add("colstatus", "Status", 90);
            listallprocess.Columns.Add("colprog", "Progresso", 120);

            listfinished.MultiSelect = false;
            listfinished.FullRowSelect = true;
            listfinished.Columns.Add("colPID", "PID", 70);
            listfinished.Columns.Add("colname", "Nome", 160);
            listfinished.Columns.Add("colprio", "Prioridade", 100);
            listfinished.Columns.Add("coltempo", "Tempo de execução", 100);
            listfinished.Columns.Add("colstatus", "Status", 90);
            listfinished.Columns.Add("colprog", "Progresso", 120);
        }

        private void btncarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.FileName.EndsWith("txt"))
                {
                    using (StreamReader read = new StreamReader(open.FileName))
                    {
                        string line;
                        while ((line = read.ReadLine()) != null)
                        {
                            string[] splt = line.Split(';');
                            Processo toadd = new Processo(int.Parse(splt[0]), splt[1], int.Parse(splt[2]), int.Parse(splt[3]));
                            Processes.Inserir(toadd);
                            ListViewItem item = new ListViewItem();
                            item.Text = toadd.Pid.ToString();
                            item.SubItems.Add(toadd.Name);
                            item.SubItems.Add(toadd.Prio.ToString());
                            item.SubItems.Add(toadd.Tempo_execucao.ToString());
                            item.SubItems.Add("Parado");
                            item.SubItems.Add("0");
                           listallprocess.Items.Add(item);
                        }
                        read.Close();
                    }
                }
            }
        }
    }
}
