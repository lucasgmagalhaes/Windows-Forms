using System;
using System.Windows.Forms;
using Ti;
namespace BulletWorld
{
    public partial class frmHelpcs : Form
    {
        public frmHelpcs()
        {
            InitializeComponent();
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.MdiParent = frmMain.ActiveForm;
            menu.Show();
            this.Close();
        }
    }
}
