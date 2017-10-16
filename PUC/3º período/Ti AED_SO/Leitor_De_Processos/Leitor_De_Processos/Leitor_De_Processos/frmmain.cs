using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Drawing;
using Leitor_De_Processos.Main;

namespace Leitor_De_Processos
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.listProcessos.ListViewItemSorter = lvwColumnSorter;
        }
        /// <summary>
        /// Pausa a execução do processo
        /// </summary>
        private bool pause;
        /// <summary>
        /// define de o backgroundWork deve ou não ser cancelado
        /// </summary>
        private bool cancel;
        /// <summary>
        /// Classe responsável por gerenciar os processos em Lista
        /// </summary>
        private ProcessManager motor;
        /// <summary>
        /// Define se um ou mais processos está sendo executado
        /// </summary>
        private bool ProcessRunning = false;
        /// <summary>
        /// Define se o processo em execução receberá foco
        /// </summary>
        private bool FollowProcess = true;
        /// <summary>
        /// Marca o processo que está sendo executado sem acompanha-lo no ListView
        /// </summary>
        private bool CheckInExecution = true;
        /// <summary>
        /// Variável de auxílio para a ordenação de colunas
        /// </summary>
        private ListViewColumnSorter lvwColumnSorter;
        /// <summary>
        /// Marca os processos com cores de acordo com sua prioridade
        /// </summary>
        private bool ListColors;
        /// <summary>
        /// Define um item que será executado
        /// </summary>
        private ListViewItem item_to_execute;
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
        /// <summary>
        /// Executa o primeiro elemento da fila
        /// </summary>
        /// <param name="generic"></param>
        private void RunList(int generic)
        {
            motor.In_execution = generic;
            Cicle_Run.RunWorkerAsync();
        }
        /// <summary>
        /// Atualiza o ID e o nome do processo que esta em execução no momento
        /// </summary>
        /// <param name="aux"></param>
        private void UpdateInExecutionProcess(Processo aux)
        {
            try
            {
                item_to_execute = GetProcessInListView(aux);
                lblid.Text = "ID:  " + aux.Pid;
                lblnome.Text = "Nome:  " + aux.Name;
                if (FollowProcess == true)
                {
                    listProcessos.Select();
                    item_to_execute.Selected = true;
                    listProcessos.EnsureVisible(item_to_execute.Index);
                }
                else if (CheckInExecution == true)
                {
                    listProcessos.Select();
                    item_to_execute.Selected = true;
                }
            }
            catch { }
        }
        /// <summary>
        /// Retorna o processo da fila no listview
        /// </summary>
        /// <param name="what"></param>
        /// <returns></returns>
        private ListViewItem GetProcessInListView(Processo what)
        {
            foreach (ListViewItem item in listProcessos.Items)
                if (item.Text == what.Pid.ToString())
                    return item;
            return null;
        }
        /// <summary>
        /// Define a cor das "rows" do ListView de acordo com sua prioridade
        /// </summary>
        /// <param name="item"></param>
        private void SetRowColor(ListViewItem item)
        {
            item.UseItemStyleForSubItems = false;
            if (item.SubItems[2].Text == "5") for (int i = 2; i < item.SubItems.Count; i++) item.SubItems[i].BackColor = panelcolor5.BackColor;
            else if (item.SubItems[2].Text == "4") for (int i = 2; i < item.SubItems.Count; i++) item.SubItems[i].BackColor = panelcolor4.BackColor;
            else if (item.SubItems[2].Text == "3") for (int i = 2; i < item.SubItems.Count; i++) item.SubItems[i].BackColor = panelcolor3.BackColor;
            else if (item.SubItems[2].Text == "2") for (int i = 2; i < item.SubItems.Count; i++) item.SubItems[i].BackColor = panelcolor2.BackColor;
            else if (item.SubItems[2].Text == "1") for (int i = 2; i < item.SubItems.Count; i++) item.SubItems[i].BackColor = panelcolor1.BackColor;
        }
        /// <summary>
        /// Remove a cor da linha
        /// </summary>
        private void RemoveRowColors()
        {
            foreach (ListViewItem item in listProcessos.Items) for (int i = 2; i < item.SubItems.Count; i++) item.SubItems[i].BackColor = Color.White;
        }
        /// <summary>
        /// Marca a linha com cor
        /// </summary>
        private void MarkRowWithColors()
        {
            foreach (ListViewItem item in listProcessos.Items)
            {
                item.UseItemStyleForSubItems = false;
                if (item.SubItems[2].Text == "5") for (int i = 2; i < item.SubItems.Count; i++) item.SubItems[i].BackColor = panelcolor5.BackColor;
                else if (item.SubItems[2].Text == "4") for (int i = 2; i < item.SubItems.Count; i++) item.SubItems[i].BackColor = panelcolor4.BackColor;
                else if (item.SubItems[2].Text == "3") for (int i = 2; i < item.SubItems.Count; i++) item.SubItems[i].BackColor = panelcolor3.BackColor;
                else if (item.SubItems[2].Text == "2") for (int i = 2; i < item.SubItems.Count; i++) item.SubItems[i].BackColor = panelcolor2.BackColor;
                else if (item.SubItems[2].Text == "1") for (int i = 2; i < item.SubItems.Count; i++) item.SubItems[i].BackColor = panelcolor1.BackColor;
            }
        }
        private void SetPauseResume()
        {
            if (ProcessRunning)
            {
                if (pause)
                {
                    pause = false;
                    pararExecuçãoToolStripMenuItem.Text = "Pausar";
                    pararExecuçãoToolStripMenuItem.ToolTipText = "Pausa o processo em execução";
                }
                else
                {
                    pause = true;
                    pararExecuçãoToolStripMenuItem.Text = "Retomar";
                    pararExecuçãoToolStripMenuItem.ToolTipText = "Retoma o processo em execução";
                }
            }
        }
        private void RestoreProcess()
        {
            listProcessos.Items.Clear();
            ListFinalizados.Items.Clear();
            listlog.Items.Clear();
            lblc5.Text = "C5 ";
            lblc4.Text = "C4 ";
            lblc3.Text = "C3 ";
            lblc2.Text = "C2 ";
            lblc1.Text = "C1 ";
            lblid.Text = "ID:";
            lblnome.Text = "Nome:";
            lblspeed.Text = "Velocidade de processamento: ";
            lbltimercount.Text = "Tempo em execução  ";
            lblfinalizados.Text = "Processos finalizados: ";
            SetPauseResume();
            ProcessRunning = false;

            Processo procretore;
            Lista backup = new Encadeada();
            Lista b = motor.GetBackup();
            motor = new ProcessManager();
            while ((procretore = (Processo)b.RemoveFirst()) != null)
            {
                procretore.ResetProcesso();
                backup.Add(procretore);
            }
            while ((procretore = (Processo)backup.RemoveFirst()) != null)
            {
                motor.SetProcessToRightLine(procretore);
                if (ListColors) SetRowColor(AddProcessToListView(procretore));
                else AddProcessToListView(procretore);
                lbllist.Text = "Processo listados " + motor.TPLIST++;
                UpdateCounters();
            }
        }
        /// <summary>
        /// Insere o processo no ListView listProcessos
        /// </summary>
        /// <param name="toadd"></param>
        private ListViewItem AddProcessToListView(Processo toadd)
        {
            ListViewItem item = new ListViewItem();
            item.Text = toadd.Pid.ToString();
            item.SubItems.Add(toadd.Name);
            item.SubItems.Add(toadd.Prio.ToString());
            item.SubItems.Add(toadd.Tempo_por_ciclo.ToString());
            item.SubItems.Add(toadd.Ciclo.ToString());
            item.SubItems.Add(toadd.Ciclos_executados.ToString());
            item.SubItems.Add("Parado");
            item.SubItems.Add("0");
            listProcessos.Items.Add(item);
            return item;
        }
        #region Events
        /// <summary>
        /// Executa um processo e informa o processo dele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cicle_Run_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!cancel)
            {
                while (pause) Thread.Sleep(400);
                motor.RunCicle();
                Thread.Sleep(Convert.ToInt32(motor.To_run.Tempo_por_ciclo * motor.Speed));
                Cicle_Run.ReportProgress(CalcPercentage(motor.To_run.Ciclo, motor.To_run.Ciclos_executados));
            }
            else
            {
                e.Cancel = true;
                cancel = false;
                return;
            }
        }
        /// <summary>
        /// Thread de interface exibe o progresso de execução do processo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cicle_Run_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UpdateInExecutionProcess(motor.To_run);

            while (motor.Escalonamento_log.Count() > 0)
            {
                ProcessLog get = (ProcessLog)(motor.Escalonamento_log.Remover());
                listlog.Items.Add("Processo de ID " + get.Processo.Pid + " foi removido da prioridade " + get.Operation_from + " e inserido na prioridade " + get.Operation_to);
                item_to_execute.SubItems[2].Text = get.Operation_to.ToString();

                listProcessos.Select();
                item_to_execute.Selected = true;
                item_to_execute.BackColor = Color.Yellow;
                listProcessos.EnsureVisible(item_to_execute.Index);

                if (motor.ToUP != null)
                {
                    ListViewItem item = GetProcessInListView(motor.ToUP);
                    item.SubItems[2].Text = get.Operation_to.ToString();
                    motor.ToUP = null;
                }
            }
            if (item_to_execute != null && motor.To_run != null)
            {
                item_to_execute.SubItems[item_to_execute.SubItems.Count - 2].Text = "Em execução";
                item_to_execute.SubItems[item_to_execute.SubItems.Count - 3].Text = motor.To_run.Ciclos_executados.ToString();
                item_to_execute.SubItems[item_to_execute.SubItems.Count - 1].Text = CalcPercentage(motor.To_run.Ciclo, motor.To_run.Ciclos_executados).ToString() + "%";
                if (motor.To_run.Ciclos_executados == motor.To_run.Ciclo)
                {
                    item_to_execute.SubItems[item_to_execute.SubItems.Count - 2].Text = "Finalizado";
                    listProcessos.Items[item_to_execute.Index].Remove();
                    ListViewItem item_finalizado = new ListViewItem();

                    item_finalizado.Text = item_to_execute.Text;
                    item_finalizado.SubItems.Add(item_to_execute.SubItems[1]);
                    item_finalizado.SubItems.Add(item_to_execute.SubItems[2]);
                    item_finalizado.SubItems.Add(item_to_execute.SubItems[3]);
                    item_finalizado.SubItems.Add(item_to_execute.SubItems[4]);
                    ListFinalizados.Items.Add(item_finalizado);
                    lblfinalizados.Text = "Processos finalizados: " + motor.TPF++;
                    UpdateCounters();
                }
                else item_to_execute.SubItems[item_to_execute.SubItems.Count - 2].Text = "Em espera";
            }
        }
        private void UpdateCounters()
        {
            lblc5.Text = "C5 " + motor.Listas_categoria[4].Count();
            lblc4.Text = "C4 " + motor.Listas_categoria[3].Count();
            lblc3.Text = "C3 " + motor.Listas_categoria[2].Count();
            lblc2.Text = "C2 " + motor.Listas_categoria[1].Count();
            lblc1.Text = "C1 " + motor.Listas_categoria[0].Count();
        }
        /// <summary>
        /// Verifica se há mais processos para serem executados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cicle_Run_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (motor.To_run != null)
            {
                if (motor.To_run.Ciclos_executados != motor.To_run.Ciclo) RunList(motor.WhatShouldIRun());
                else
                {
                    if (motor.WhatShouldIRun() != -1) RunList(motor.WhatShouldIRun());
                    else
                    {
                        Timer_Processing.Stop();
                        ProcessRunning = false;
                        lblid.Text = "ID:  ";
                        lblnome.Text = "Nome:  ";
                        MessageBox.Show("Processos finalizados !");
                    }
                }
            }
        }
        /// <summary>
        /// Cria uma lista e adiciona as colunas corretas para o ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmmain_Load_1(object sender, EventArgs e)
        {
            motor = new ProcessManager();
            Cicle_Run.WorkerReportsProgress = true;
            Cicle_Run.WorkerSupportsCancellation = true;
            listProcessos.MultiSelect = false;
            listProcessos.FullRowSelect = true;
            listProcessos.Columns.Add("colPID", "PID", 70);
            listProcessos.Columns.Add("colname", "Nome", 160);
            listProcessos.Columns.Add("colprio", "Prioridade", 100);
            listProcessos.Columns.Add("coltempciclo", "Tempo por ciclo", 165);
            listProcessos.Columns.Add("colciclo", "Ciclos", 165);
            listProcessos.Columns.Add("colciclo_runned", "Executados", 165);
            listProcessos.Columns.Add("colstatus", "Status", 90);
            listProcessos.Columns.Add("colprog", "Progresso", 120);

            ListFinalizados.MultiSelect = false;
            ListFinalizados.FullRowSelect = true;
            ListFinalizados.Columns.Add("colPID", "PID", 70);
            ListFinalizados.Columns.Add("colname", "Nome", 160);
            ListFinalizados.Columns.Add("colprio", "Prioridade", 100);
            ListFinalizados.Columns.Add("coltempciclo", "Tempo por ciclo", 165);
            ListFinalizados.Columns.Add("colciclo", "Ciclos", 165);
            btnfinish.Enabled = false;
        }
        private void SetFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (listProcessos.Items.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Já existe processos na lista. Deseja substitui-los ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        listProcessos.Items.Clear();
                        motor = new ProcessManager();
                    }
                }
                else motor = new ProcessManager();
                if (open.FileName.EndsWith("txt"))
                {
                    using (StreamReader read = new StreamReader(open.FileName))
                    {
                        string line;
                        while ((line = read.ReadLine()) != null)
                        {
                            string[] splt = line.Split(';');
                            Processo toadd = new Processo(int.Parse(splt[0]), splt[1], int.Parse(splt[2]), float.Parse(splt[3]), int.Parse(splt[4]));
                            motor.SetProcessToRightLine(toadd);
                            if (ListColors) SetRowColor(AddProcessToListView(toadd));
                            else AddProcessToListView(toadd);
                            lbllist.Text = "Processo listados " + motor.TPLIST++;
                            UpdateCounters();
                        }
                        btnfinish.Enabled = true;
                        read.Close();
                        motor.ClearAuxs();
                    }
                }
            }
        }
        /// <summary>
        /// Carrega um arquivo com um bloco de processos para lista interna e o ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolTipCarregar_Click(object sender, EventArgs e)
        {
            SetFile();
        }
        /// <summary>
        /// Roda uma ação em um processo com base no estado atual dele
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnfinish_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Executa todos os processos da lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void processamentoSequencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listProcessos.Items.Count > 0)
            {
                if (ProcessRunning == false)
                {
                    lblspeed.Text = "Velocidade de processamento: x" + motor.Speed + "ms";
                    motor.Count_Time.Start();
                    Timer_Processing.Start();
                    RunList(motor.WhatShouldIRun());
                    ProcessRunning = true;
                }
            }
            else
            {
                DialogResult resp = MessageBox.Show("Não há processos listados. Deseja carrega-los ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes) SetFile();
            }
        }
        /// <summary>
        /// Ordena uma coluna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listProcessos_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending) lvwColumnSorter.Order = SortOrder.Descending;
                else lvwColumnSorter.Order = SortOrder.Ascending;
                listProcessos.Columns[e.Column].Text += " ▲";
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            this.listProcessos.Sort();
        }
        /// <summary>
        /// Define se o programa acompanhará(terá foco sobre cada processo que é executado)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem1.Checked == true)
            {
                toolStripMenuItem1.Checked = false;
                FollowProcess = false;
            }
            else
            {
                toolStripMenuItem1.Checked = true;
                FollowProcess = true;
                if (ProcessRunning == true)
                {
                    listProcessos.Select();
                    listProcessos.SelectedItems[0].Selected = true;
                    listProcessos.EnsureVisible(listProcessos.SelectedItems[0].Index);
                }
            }
        }
        /// <summary>
        /// Sai do sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProcessRunning == true)
            {
                DialogResult result = MessageBox.Show("Ainda há processos em execução, deseja mesmo encerrar a aplicação ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) this.Close();
            }
            else this.Close();
        }
        private void ImgQuestion_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            // tt.SetToolTip(this.ImgQuestion, "O processo em execução é retirado da lista de processos(Ação interna do programa). Visualmente, nada é modificado");
        }
        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhelp open = new frmhelp();
            open.ShowDialog();
        }
        private void marcarProcessoEmExecuçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (marcarProcessoEmExecuçãoToolStripMenuItem.Checked == true)
            {
                marcarProcessoEmExecuçãoToolStripMenuItem.Checked = false;
                CheckInExecution = false;
            }
            else
            {
                marcarProcessoEmExecuçãoToolStripMenuItem.Checked = true;
                CheckInExecution = true;
            }
        }
        private void separarPrioridadesPorCoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (separarPrioridadesPorCoresToolStripMenuItem.Checked == true)
            {
                separarPrioridadesPorCoresToolStripMenuItem.Checked = false;
                ListColors = false;
                RemoveRowColors();
            }
            else
            {
                separarPrioridadesPorCoresToolStripMenuItem.Checked = true;
                ListColors = true;
                MarkRowWithColors();
            }
        }
        #endregion

        private void Timer_Processing_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = motor.Count_Time.Elapsed;
            lbltimercount.Text = "Tempo em execução  " + ts.Hours.ToString("00") + ":" + ts.Minutes.ToString("00") + ":" + ts.Seconds.ToString("00");
        }

        private void ToolSpeed1_Click(object sender, EventArgs e)
        {
            if (ToolSpeed1.Checked != true)
            {
                ToolSpeed1.Checked = true;
                ToolSpeed2.Checked = false;
                ToolSpeed3.Checked = false;
                motor.Speed = 10;
                lblspeed.Text = "Velocidade de processamento: 10x";
            }
        }

        private void ToolSpeed2_Click(object sender, EventArgs e)
        {
            if (ToolSpeed2.Checked != true)
            {
                ToolSpeed1.Checked = false;
                ToolSpeed2.Checked = true;
                ToolSpeed3.Checked = false;
                motor.Speed = 100;
                lblspeed.Text = "Velocidade de processamento:  100x";
            }
        }

        private void ToolSpeed3_Click(object sender, EventArgs e)
        {
            if (ToolSpeed3.Checked != true)
            {
                ToolSpeed1.Checked = false;
                ToolSpeed2.Checked = false;
                ToolSpeed3.Checked = true;
                motor.Speed = 1000;
                lblspeed.Text = "Velocidade de processamento: 1000x";
            }
        }
        private void informaçõesDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TI_Arquitetura.frmmain open = new TI_Arquitetura.frmmain();
            open.Show();
        }
        private void pararExecuçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPauseResume();
        }
        private void pararToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cicle_Run.WorkerSupportsCancellation = true;
            cancel = true;
            Cicle_Run.CancelAsync();
            RestoreProcess();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmexer3_6 open = new frmexer3_6();
            open.Show();
        }
    }
}