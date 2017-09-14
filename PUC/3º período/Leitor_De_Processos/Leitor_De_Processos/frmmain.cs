using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Leitor_De_Processos
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// retorna em % o quanto a tarefa em execução foi completa
        /// </summary>
        /// <param name="total"></param>
        /// <param name="rest"></param>
        /// <returns></returns>
        private int CalcPercentage(int total, int rest)
        {
            return (rest * 100) / total;
        }
        private Lista Mylist;
        /// <summary>
        /// Remove a tarefa selecionada
        /// </summary>
        private void RemoveTask()
        {
            listProcessos.SelectedItems[0].Remove();

        }
        /// <summary>
        /// retorna execução da tarefa
        /// </summary>
        private void ResumeTask()
        {
            ProcessCount.Start();
        }
        /// <summary>
        /// Pausa a tarefa selecionada
        /// </summary>
        private void PauseTask()
        {
            ProcessCount.Stop();
        }
        private void StartHighPriority()
        {
            int maior = 0;
            Elemento aux = Mylist.Prim.Proximo;
            while (aux != null)
            {
                Processo dado = (Processo)(aux.GetDados());
                if (dado.Prio > maior && dado.Ciclos_executados < dado.Ciclo)
                {
                    prioritario = dado;
                    maior = prioritario.Prio;
                }
                else if(dado.Prio == maior && dado.Ciclos_executados < dado.Ciclo) {
                    if ((dado.Ciclos_executados - dado.Ciclo) < (prioritario.Ciclo - prioritario.Ciclos_executados))
                    {
                        prioritario = dado;
                        maior = prioritario.Prio;
                    }
                }
                aux = aux.Proximo;
            }
            foreach (ListViewItem item in listProcessos.Items)
            {
                if (int.Parse(item.Text) == prioritario.Pid)
                {
                    item_to_execute = item;
                    ProcessCount.Start();
                    break;
                }
            }
        }
        private bool sequencialexecution;
        private void SequencialPriority(bool set)
        {
            sequencialexecution = set;
        }
        private void frmmain_Load_1(object sender, EventArgs e)
        {
            Mylist = new Lista();

            listProcessos.MultiSelect = false;
            listProcessos.FullRowSelect = true;

            listProcessos.Columns.Add("colPID", "PID", 70);
            listProcessos.Columns.Add("colname", "Nome", 160);
            listProcessos.Columns.Add("colprio", "Prioridade", 100);
            listProcessos.Columns.Add("coltempciclo", "Tempo por ciclo", 165);
            listProcessos.Columns.Add("colciclo", "ciclos", 165);
            listProcessos.Columns.Add("colstatus", "Status", 90);
            listProcessos.Columns.Add("colprog", "Progresso", 120);
            btnfinish.Enabled = false;
        }
        private void ToolTipCarregar_Click(object sender, EventArgs e)
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
                            ListViewItem item = new ListViewItem();
                            item.Text = splt[0];
                            for (int i = 1; i < splt.Length; i++)
                            {
                                item.SubItems.Add(splt[i]);
                            }
                            item.SubItems.Add("Parado");
                            item.SubItems.Add("0");
                            listProcessos.Items.Add(item);
                            Mylist.Inserir(new Processo(int.Parse(splt[0]), splt[1], int.Parse(splt[2]), float.Parse(splt[3]), int.Parse(splt[4])));
                        }
                        btnfinish.Enabled = true;
                        read.Close();
                    }
                }
            }
        }
        private Processo prioritario = null;
        private void ToolStripStart_Click(object sender, EventArgs e)
        {
            StartHighPriority();
            SequencialPriority(false);
        }
        private ListViewItem item_to_execute;
        private void ProcessCount_Tick(object sender, EventArgs e)
        {
            item_to_execute.SubItems[5].Text = "Em execução";
            if (prioritario.Ciclos_executados < prioritario.Ciclo)
            {
                prioritario.Ciclos_executados++;
                item_to_execute.SubItems[6].Text = CalcPercentage(prioritario.Ciclo, prioritario.Ciclos_executados).ToString() + "%";
            }
            else
            {
                item_to_execute.SubItems[5].Text = "Finalizado";
                ProcessCount.Stop();
                if (sequencialexecution == true) StartHighPriority();
            }
        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            if (listProcessos.SelectedItems.Count > 0)
            {
                if (btnfinish.Text == btntextop[0]) RemoveTask();
                else if (btnfinish.Text == btntextop[1])
                {
                    PauseTask();
                    listProcessos.SelectedItems[0].SubItems[4].Text = "Pausado";
                }
                else ResumeTask();
                listProcessos.Refresh();
            }
        }
        string[] btntextop = new string[3] { "Finalizar tarefa", "Pausar tarefa", "Retomar tarefa" };
        private void listProcessos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProcessos.SelectedItems.Count > 0)
            {
                if (listProcessos.SelectedItems[0].SubItems[4].Text == "Em execução") btnfinish.Text = btntextop[1];
                else if (listProcessos.SelectedItems[0].SubItems[4].Text == "Pausado") btnfinish.Text = btntextop[2];
                else btnfinish.Text = btntextop[0];
            }
        }
        private void processamentoSequencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartHighPriority();
            SequencialPriority(true);
        }
    }
}

