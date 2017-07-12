using System;
using System.ComponentModel;
using System.Windows.Forms;
using AutoCRM;
using Bloqueados_Auto;


namespace AutoBlockConfigs
{
    public partial class frmChecker : Form
    {
        Form1 mainform;
        public frmChecker(string user, string pass, Form1 form)
        {
            InitializeComponent();
            this.useremail = user;
            this.passuser = pass;
            this.mainform = form;
        }

        private string useremail, passuser;
        private bool step1, step2, step3, step4;
        private int step = 0;

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            mainform.WindowState = FormWindowState.Minimized;
            this.Close();
        }

        private void frmChecker_Shown(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainform.WindowState = FormWindowState.Minimized;
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (Email.NetTest())
                {
                    step1 = true;
                }
                else step1 = false;
            }
            catch
            {
                step1 = false;
            }

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.ReportProgress(25);
            step++;

            try
            {
                if (Email.UserAccountTest(useremail, passuser) == "0")
                {
                    step2 = true;
                }
                else step2 = false;
            }
            catch
            {
                step2 = false;
            }

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.ReportProgress(25);
            step++;

            try
            {
                if (Email.Send(useremail, useremail, passuser, "Teste", "Email de teste")) step3 = true;
                else
                {
                    step3 = false;
                }
            }
            catch
            {
                step3 = false;
            }
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.ReportProgress(25);
            step++;
            try
            {
                if (Conection.Open()) step4 = true;
                else step4 = true;
            }
            catch
            {
                step4 = false;
            }

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.ReportProgress(25);
            step++;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value += e.ProgressPercentage;

            if (progressBar1.Value == 25)
            {
                if (step1) pictureBox1.Image = Properties.Resources.Checkmark_16;
                else
                {
                    lblConection.Text += "Falha";
                    pictureBox1.Image = Properties.Resources.Delete_16;
                }
            }
            if (progressBar1.Value == 50)
            {
                lblconfiguser.Visible = true;

                if (step2) pictureBox2.Image = Properties.Resources.Checkmark_16;
                else
                {
                    lblconfiguser.Text += "Falha";
                    pictureBox2.Image = Properties.Resources.Delete_16;
                }
            }
            if (progressBar1.Value == 75)
            {
                lblsendemail.Visible = true;

                if (step3) pictureBox3.Image = Properties.Resources.Checkmark_16;
                else
                {
                    lblsendemail.Text += "Falha";
                    pictureBox3.Image = Properties.Resources.Delete_16;
                }
            }
            if (progressBar1.Value == 100)
            {
                lblserver.Visible = true;

                if (step4) pictureBox4.Image = Properties.Resources.Checkmark_16;
                else
                {
                    lblserver.Text += "Falha";
                    pictureBox4.Image = Properties.Resources.Delete_16;
                }
            }
            button1.Visible = true;
        }
    }
}
