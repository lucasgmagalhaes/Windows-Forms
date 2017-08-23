using System;
using System.Drawing;
using System.Windows.Forms;
using Ti;
namespace BulletWorld
{
    public partial class frmQuit : Form
    {
        public frmQuit()
        {
            InitializeComponent();
        }

        private string message;

        public frmQuit(string msg)
        {
            InitializeComponent();
            this.message = msg;
        }
        /// <summary>
        /// O comportamento do btnclick varia se o .this form for acionado no frmMenu ou durante a "partida"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnquit_Click(object sender, EventArgs e)
        {
            if (message != null)
            {
                this.MdiParent.WindowState = FormWindowState.Normal;
                this.MdiParent.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.Close();
                frmMenu back = new frmMenu();
                back.MdiParent = frmMain.ActiveForm; 
                back.Show();
            }
            else
            {
                Application.Exit();
            }
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Há uma pequena configuração para que o lbl da msg seja ajustado corretamente para ficar
        /// no centro da tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQuit_Load(object sender, EventArgs e)
        {
            if (message != null)
            {
                label1.Location = new Point(66, 47);
                label1.Text = message;
            }
        }
    }
}
