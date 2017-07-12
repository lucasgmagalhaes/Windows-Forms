using System;
using System.Windows.Forms;
using BulletWorld.Class;
using Ti;
namespace BulletWorld
{
    public partial class frmNewPlayer : Form
    {
        public frmNewPlayer()
        {
            InitializeComponent();
        }

        private int count = 0;

        private void ENTER()
        {
            if (txtplayername.Text != "")
            {
                Player create = new Player(txtplayername.Text);
                if (create.Name != "")
                {
                    frmMenu.name = txtplayername.Text;
                    this.Hide();
                    frmMenu backmenu = new frmMenu();
                    backmenu.MdiParent = frmMain.ActiveForm;
                    backmenu.Show();
                    this.Close();
                }
                else
                {
                    lblexists.Visible = true;
                    Timer_Exists.Enabled = true;
                }
            }
        }

        private void btncreateplayer_Click(object sender, EventArgs e)
        {
            ENTER();
        }

        private void Timer_Exists_Tick(object sender, EventArgs e)
        {
            if (count == 2)
            {
                lblexists.Visible = false;
                Timer_Exists.Enabled = false;
            }
            else count++;
        }

        private void frmNewPlayer_Load(object sender, EventArgs e)
        {
            lblname.Focus();
        }

        private void frmNewPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') ENTER();
            else if (e.KeyChar == '\u001b') this.Close();
        }
    }
}
