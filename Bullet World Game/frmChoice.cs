using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ti;
namespace BulletWorld
{
    public partial class frmChoice : Form
    {
        public frmChoice()
        {
            InitializeComponent();
        }

        private void btnPLAY_Click(object sender, EventArgs e)
        {
            frmBulletWorld jogo = null;

            if (radioButton1.Checked) jogo = new frmBulletWorld(1);
            else if (radioButton2.Checked) jogo = new frmBulletWorld(2);
            else if (radioButton3.Checked) jogo = new frmBulletWorld(3);
            else if (radioButton4.Checked) jogo = new frmBulletWorld(4);
            else if (radioButton5.Checked) jogo = new frmBulletWorld(5);
            else if (radioButton6.Checked) jogo = new frmBulletWorld(6);
            else if (radioButton7.Checked) jogo = new frmBulletWorld(7);

            frmMenu back = new frmMenu();
            jogo.MdiParent = frmMain.ActiveForm;
            this.MdiParent.FormBorderStyle = FormBorderStyle.None;
            this.MdiParent.WindowState = FormWindowState.Maximized;
            jogo.Show();
            this.Close();
        }

        private void frmback_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu backmenu = new frmMenu();
            backmenu.MdiParent = frmMain.ActiveForm;
            backmenu.Show();
            this.Close();
        }
    }
}
