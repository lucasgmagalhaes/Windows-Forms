using System;
using System.IO;
using System.Windows.Forms;
using AutoCRM;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;


namespace AutoBlockConfigs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static string pathfooter;

        private void Save()
        {
            if (checkMonday.Checked != false || checkTuesday.Checked != false || checkWednesday.Checked != false || checkThursday.Checked != false || checkFriday.Checked != false || checkSaturday.Checked != false || checkSunday.Checked != false)
            {
                if (!String.IsNullOrEmpty(combohora.Text) && !String.IsNullOrEmpty(combominuto.Text))
                {
                    if (!String.IsNullOrEmpty(txtfooter.Text))
                    {
                        try
                        {
                            using (StreamWriter Save = new StreamWriter("DataSettings", false))
                            {
                                Save.WriteLine(Encription.Encryption(txtuser.Text));
                                Save.WriteLine(Encription.Encryption(txtpass.Text));
                                Save.WriteLine(Encription.Encryption(txtSMTP.Text));
                                Save.WriteLine(Encription.Encryption(txtport.Text));
                                Save.WriteLine(Encription.Encryption(txtto.Text));
                                Save.WriteLine(Encription.Encryption(txttitle.Text));

                                string bigmsg = txtmsg.Text;
                                bigmsg = bigmsg.Replace("\n", "\\n");
                                Save.WriteLine(Encription.Encryption(bigmsg));

                                Save.WriteLine(Encription.Encryption(combohora.Text));
                                Save.WriteLine(Encription.Encryption(combominuto.Text));

                                if (checkEnableTimer.Checked) Save.WriteLine(Encription.Encryption("true"));
                                else Save.WriteLine(Encription.Encryption("false"));

                                var allchecks = groupBox5.Controls.OfType<CheckBox>();
                                foreach (CheckBox chk in allchecks)
                                {
                                    if (chk.CheckState == CheckState.Checked) Save.WriteLine(Encription.Encryption(chk.Name));
                                }
                                Save.Close();
                            }
                            groupBox1.Enabled = groupBox2.Enabled = false;
                            checkenableall.CheckState = CheckState.Unchecked;
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("Não foi possível criar o arquivo de configurações. Erro: " + err.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        using (StreamWriter footerfile = new StreamWriter("DataFooter", false))
                        {
                            if (pathfooter == AppDomain.CurrentDomain.BaseDirectory + txtfooter.Text) // verifica se o arquivo que o usuário selecionou não é o arquivo que já está na pasta destino em que ele será encaminhado
                            {
                                footerfile.WriteLine(Encription.Encryption(txtfooter.Text));
                                footerfile.WriteLine(Encription.Encryption(pathfooter));
                            }
                            else
                            {
                                try
                                {
                                    File.Copy(pathfooter, AppDomain.CurrentDomain.BaseDirectory + txtfooter.Text, true);
                                    footerfile.WriteLine(Encription.Encryption(txtfooter.Text));
                                    footerfile.WriteLine(Encription.Encryption(pathfooter));
                                }
                                catch (Exception err)
                                {
                                    MessageBox.Show("Falha na cópia da assinatura para a pasta raiz do applicativo. \nO aplicativo usará a assinatura onde ela está localizada atualmente.  Erro de cópia: " + err.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    footerfile.WriteLine(Encription.Encryption(pathfooter));
                                }
                            }
                            footerfile.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Assinatura não selecionada", "Footer Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário definir uma Hora e minuto para a execução.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("É necessário ao menos 1 dia para o envio dos emails.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private List<string> Checks = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;

            if (File.Exists("DataSettings"))
            {
                try
                {
                    using (StreamReader Ler = new StreamReader("DataSettings"))
                    {
                        txtuser.Text = Encription.Decription(Ler.ReadLine());
                        txtpass.Text = Encription.Decription(Ler.ReadLine());
                        txtSMTP.Text = Encription.Decription(Ler.ReadLine());
                        txtport.Text = Encription.Decription(Ler.ReadLine());
                        txtto.Text = Encription.Decription(Ler.ReadLine());
                        txttitle.Text = Encription.Decription(Ler.ReadLine());
                        string bigmsg = Encription.Decription(Ler.ReadLine());
                        txtmsg.Text = bigmsg.Replace("\\n", "\n");

                        combohora.Text = Encription.Decription(Ler.ReadLine());
                        combominuto.Text = Encription.Decription(Ler.ReadLine());

                        if (Encription.Decription(Ler.ReadLine()) == "true") checkEnableTimer.Checked = true;
                        else checkEnableTimer.Checked = false;

                        string line;
                        var allchecks = groupBox5.Controls.OfType<CheckBox>();
                        while ((line = Ler.ReadLine()) != null)
                        {
                            foreach (CheckBox chk in allchecks)
                            {
                                if (chk.Name == Encription.Decription(line))
                                {
                                    chk.Checked = true;
                                    Checks.Add(Encription.Decription(line));
                                }
                            }
                        }
                        Ler.Close();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Não foi possível ler completamente o arquivo de configurações. Erro: " + err.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (File.Exists("DataFooter"))
            {
                try
                {
                    using (StreamReader datafoo = new StreamReader("DataFooter"))
                    {
                        string[] splt = Encription.Decription(datafoo.ReadLine()).Split('\\');
                        txtfooter.Text = splt.LastOrDefault();
                        pathfooter = Encription.Decription(datafoo.ReadLine());
                        datafoo.Close();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Não foi possível ler completamente o arquivo com o caminho da assinatura. Erro: " + err.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                this.Hide();
                notifyIcon1.BalloonTipTitle = "Status de Operação";
                if (checkEnableTimer.Checked == true) notifyIcon1.BalloonTipText = "O sistema de envio de relatório de clientes está ativado. Envio agendado pra as " + combohora.Text + ":" + combominuto.Text;
                else notifyIcon1.BalloonTipText = "Não foi habilitado o envio do relatório";
                notifyIcon1.ShowBalloonTip(2000);
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void TimerCheckProcessExecute_Tick(object sender, EventArgs e)
        {
            foreach (string ch in Checks)
            {
                string day = "check" + DateTime.Today.DayOfWeek.ToString();
                if (day == ch)
                {
                    if (DateTime.Now.Hour == int.Parse(combohora.Text) && DateTime.Now.Minute == int.Parse(combominuto.Text) && DateTime.Now.Second == 0)
                    {
                        if (Process.GetProcessesByName("Bloqueados Auto").Length == 0)
                        {
                            try
                            {
                                Process.Start("Bloqueados Auto");
                            }
                            catch
                            {
                                checkEnableTimer.Checked = false;
                                MessageBox.Show("Não foi possível localizar o exe de processamento de envio.", "Falha inicializar processo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void checkEnableTimer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEnableTimer.Checked == true) TimerCheckProcessExecute.Enabled = true;
            else TimerCheckProcessExecute.Enabled = false;
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtuser.Text) && !String.IsNullOrEmpty(txtpass.Text) && !String.IsNullOrEmpty(txtSMTP.Text) && !String.IsNullOrEmpty(txtport.Text))
            {
                frmChecker loader = new frmChecker(txtuser.Text, txtpass.Text, this);
                loader.ShowDialog();
            }
            Save();
        }

        private void btnsalve_Click_1(object sender, EventArgs e)
        {
            Save();
        }
        #region CheckBoxes

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkenableall.Checked) groupBox2.Enabled = groupBox1.Enabled = true;
            else groupBox2.Enabled = groupBox1.Enabled = false;
        }

        private void checksegunda_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMonday.Checked) Checks.Add(checkMonday.Name);
        }

        private void checksterca_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTuesday.Checked) Checks.Add(checkTuesday.Name);
        }

        private void checkquarta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkWednesday.Checked) Checks.Add(checkWednesday.Name);
        }

        private void checkquinta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkThursday.Checked) Checks.Add(checkThursday.Name);
        }

        private void checksexta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFriday.Checked) Checks.Add(checkFriday.Name);
        }

        private void checksabado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSaturday.Checked) Checks.Add(checkSaturday.Name);
        }

        private void checkdomingo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSunday.Checked) Checks.Add(checkSunday.Name);
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exitmsg = MessageBox.Show("Tem certeza que quer sair do aplicativo?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitmsg == DialogResult.No) e.Cancel = true;
        }

        private void btnsearchfooter_Click(object sender, EventArgs e)
        {
            bool pass = false;
            while (!pass)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string[] splt = openFileDialog1.SafeFileName.ToString().Split('.');

                    if (splt.LastOrDefault() == "jpeg" || splt.LastOrDefault() == "jpg")
                    {
                        txtfooter.Text = openFileDialog1.SafeFileName;
                        pathfooter = openFileDialog1.FileName;
                        pass = true;
                    }
                    else
                    {
                        DialogResult dial = MessageBox.Show("A assinatura dever está no formado JPG ou JPEG de imagem.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
