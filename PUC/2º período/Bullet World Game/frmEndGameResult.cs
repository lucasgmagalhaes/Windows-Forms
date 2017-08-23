using System;
using System.Drawing;
using System.Windows.Forms;
using Ti;
namespace BulletWorld
{
    public partial class frmEndGameResult : Form
    {
        private int i;
        /// <summary>
        /// Abre o diálogo de resultado de fim de jogo. Sendo True para vitória e False para derrota
        /// </summary>
        /// <param name="typ">código que se refere ao personagem selecionado</param>
        /// <param name="result">True = vitória / False = derrota</param>
        public frmEndGameResult(int typ, bool result)
        {
            InitializeComponent();
            this.i = typ;

            if (result)
            {
                label1.Text = "V I T Ó R I A";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "D E R R O T A";
                label1.ForeColor = Color.Red;
            }
        }

        private void frmderrota_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(this.MdiParent.Width - 4, this.MdiParent.Height - 4);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.MdiParent.WindowState = FormWindowState.Normal;
            this.MdiParent.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Close();
            frmMenu back = new frmMenu();
            back.MdiParent = frmMain.ActiveForm;
            back.Show();
        }

        private void btnagain_Click(object sender, EventArgs e)
        {
            frmBulletWorld jogo = null;

            jogo = new frmBulletWorld(i);

            frmMain.MyGC();
            frmMenu back = new frmMenu();
            jogo.MdiParent = frmMain.ActiveForm;
            jogo.Show();
            this.Close();
            
        }

        private void btnnewchar_Click(object sender, EventArgs e)
        {
            this.MdiParent.WindowState = FormWindowState.Normal;
            this.MdiParent.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Close();
            frmMain.MyGC();
            frmChoice select = new frmChoice();
            select.MdiParent = frmMain.ActiveForm;
            select.Show();
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
