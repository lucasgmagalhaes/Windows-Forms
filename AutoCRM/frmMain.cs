using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace AutoCRM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string status, info;
        int count = 0;
        bool created;

        private void btnconfig_Click(object sender, EventArgs e)
        {
            frmConfig open = new frmConfig();
            open.ShowDialog();
        }
        private void btnselecionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog SelectOpen = new OpenFileDialog();

            if (SelectOpen.ShowDialog() == DialogResult.OK)
            {
                FileInfo PathFile = new FileInfo(SelectOpen.SafeFileName);
                txtfilepath.Text = SelectOpen.FileName;
            }
        }
        private void btnlancar_Click(object sender, EventArgs e)
        {
            btnconfig.Enabled = false;
            btnlancar.Enabled = false;
            btnselecionar.Enabled = false;

            LOG.CreateLogFile();
            lbltatus.Text = "Conectando ao Banco...";
            if (created == false) LOG.CreateLogFile();
            LOG.Logfile.WriteLine(lbltatus.Text);
            if (txtfilepath.Text != null && txtfilepath.Text != "")
            {
                if (File.Exists(txtfilepath.Text))
                {
                    Conection.LoadConfigs();

                    if (Conection.Open() == true)
                    {
                        string[] provsplit = txtfilepath.Text.Split('.');

                        if (provsplit[1] == "xls" || provsplit[1] == "xlsx")
                        {
                            lbltatus.Text = "Abrindo arquivo para leitura...";
                            string aux = CrmFile.SetFile(txtfilepath.Text);
                            LOG.Logfile.WriteLine(lbltatus.Text);
                            if (aux == "")
                            {
                                lbltatus.Text = "Validando tipo de arquivo sendo lido...";
                                string aux1 = CrmFile.ValidarArquivo();
                                if (aux1 == "")
                                {
                                    string aux2 = CrmFile.ValidarArquivo();
                                    if (aux == "")
                                    {
                                        progresso.Maximum = CrmFile.xlsRowsCount();
                                        progresso.Minimum = 0;
                                        backgroundWorker1.RunWorkerAsync();
                                    }
                                    else
                                    {
                                        MessageBox.Show(aux2, "Falha na leitura do arquivo XLS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        LOG.Logfile.WriteLine(aux2);
                                    }
                                } //O arquivo selecionado para leitura não é do tipo válido
                                else
                                {
                                    MessageBox.Show(aux1, "Falha na leitura do arquivo XLS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    LOG.Logfile.WriteLine(aux1);
                                }
                            }
                            else
                            {
                                MessageBox.Show(aux, "Falha na leitura do arquivo XLS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                LOG.Logfile.WriteLine(aux);
                            }
                        }
                    }
                    else
                    {
                        lbltatus.Text = "";
                        DialogResult Opok = MessageBox.Show("Não há conexão com o banco de dados. Verifique as configurações de conexão.", "Falha na conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LOG.Logfile.WriteLine("Não há conexão com o banco de dados.Verifique as configurações de conexão.");
                        if (Opok == DialogResult.OK)
                        {
                            frmConfig open = new frmConfig();
                            open.ShowDialog();
                        }
                    }
                }
                else
                {
                    if (txtfilepath.Text == "endexcel")
                    {
                        string inf = CrmFile.CloseXLS();
                        if (inf == "") LOG.Logfile.WriteLine("Arquivo/Processo xls fechado/finalizado");
                        else LOG.Logfile.WriteLine(inf);
                    }
                }
            }
            else
            {
                //Caso não haja um arquivo selecionado, não será feito nada;
            }
            lbltatus.Text = "";

            btnconfig.Enabled = true;
            btnlancar.Enabled = true;
            btnselecionar.Enabled = true;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lbltatus.Text = "";
            Type office = Type.GetTypeFromProgID("Excel.Application");
            created = true;
            if (office == null)
            {
                MessageBox.Show("Pacote office não instalado", "DLL Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);              
                Application.Exit();
            }
            else
            {
                CrmFile.CreateXLSApp();
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bool keepfor = true;
            for (int r = 1; r <= CrmFile.xlsRowsCount(); r++)
            {
                if (keepfor == true)
                {
                    if (r == 1 || r > 3)
                    {
                        status = CrmFile.LerArquivoESalvarManual(r);
                    }
                    if (status == "OK")
                    {
                        if (progresso.Value != progresso.Maximum)
                        {
                            count = r;
                            backgroundWorker1.WorkerReportsProgress = true;
                            backgroundWorker1.ReportProgress(r);

                            if (r >= 4)
                            {
                                if (V11BD.GetContrato())
                                {
                                    if (V11BD.GetCentro_Custo())
                                    {
                                        info = V11BD.InsertIntoBD();
                                        if (info == "") LOG.Logfile.WriteLine(CrmFile.ShowInformations());
                                        else LOG.Logfile.WriteLine(info);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Centro de custo não encontrado", "Falha de GET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        string inf = CrmFile.CloseXLS();
                                        if (inf == "") LOG.Logfile.WriteLine("Arquivo/Processo xls fechado/finalizado");
                                        else LOG.Logfile.WriteLine(inf);
                                        Conection.Close();
                                        break;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Contrato não encontrado", "Falha de GET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    string inf = CrmFile.CloseXLS();
                                    if (inf == "") LOG.Logfile.WriteLine("Arquivo/Processo xls fechado/finalizado");
                                    else LOG.Logfile.WriteLine(inf);
                                    Conection.Close();
                                    break;
                                }
                            }
                        }
                    }
                    else if(status == "skip")
                    {
                        LOG.Logfile.WriteLine("Linha " + r + " já possui CRM cadastrado");
                    }
                    else if (status == "Arquivo para leitura inválido")
                    {
                        keepfor = false;
                        string inf = CrmFile.CloseXLS();
                        if (inf == "") LOG.Logfile.WriteLine("Arquivo/Processo xls fechado/finalizado");
                        else LOG.Logfile.WriteLine(inf);
                        Conection.Close();
                    }
                    else if (status == "" || status == null)
                    {
                        //Caso o campo de CRM ja esteja preenchido, não é preciso realizar o processo novamente.
                    }
                    else
                    {
                        MessageBox.Show(status, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        string inf = CrmFile.CloseXLS();
                        if (inf == "") LOG.Logfile.WriteLine("Arquivo/Processo xls fechado/finalizado");
                        else LOG.Logfile.WriteLine(inf);
                        Conection.Close();
                        break;
                    }
                }
                else break;
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Se o programa estiver lendo a linha 4
            if (count >= 4)
            {
                progresso.Value = e.ProgressPercentage;
                lbltatus.Text = "Registrando linha CRM " + (count - 3) + " de " + (CrmFile.xlsRowsCount() - 3);
            }
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lbltatus.Text != "" && lbltatus.Text != "Registro completo" )
            {
                DialogResult resp = MessageBox.Show("Deseja interromper o cadastro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    Conection.Close();
                    string inf = CrmFile.CloseXLS();
                    if (inf == "") LOG.Logfile.WriteLine("Arquivo/Processo xls fechado/finalizado");
                    else try
                        {
                            LOG.Logfile.WriteLine(inf);
                        }
                        catch
                        {

                        }
                }
            }
        }

        private void lblklog_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(Environment.CurrentDirectory + @"\log");
            }
            catch
            {
                MessageBox.Show("Não foi possível localizar a pasta de LOGs do app", "Folder not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnconfig.Enabled = true;
            btnlancar.Enabled = true;
            btnselecionar.Enabled = true;

            string inf = CrmFile.CloseXLS();
            if (inf == "") LOG.Logfile.WriteLine("Arquivo/Processo xls fechado/finalizado");
            else LOG.Logfile.WriteLine(inf);
            Conection.Close();
            LOG.Logfile.Close();
            created = false;

            if (status == "OK") lbltatus.Text = "Registro completo";
            else
            {
                progresso.Value = 0;
                lbltatus.Text = "";
            }
        }
    }
}
