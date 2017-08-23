using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ti;
using BulletWorld.Class;
using System.Drawing;

namespace BulletWorld
{
    public partial class frmSelectPlayer : Form
    {
        public frmSelectPlayer()
        {
            InitializeComponent();
        }
        private bool stop;
        private List<string> players;
        /// <summary>
        /// Volta ao menu principal
        /// </summary>
        private void Back()
        {
            this.Hide();
            frmMenu backmenu = new frmMenu();
            backmenu.MdiParent = frmMain.ActiveForm;
            backmenu.Show();
            this.Close();
        }
        private void New()
        {
            frmNewPlayer newplayer = new frmNewPlayer();
            newplayer.MdiParent = frmMain.ActiveForm;
            newplayer.Show();
        }
        private void SelectPlayer()
        {
            frmMenu.name = listboxplayer.GetItemText(listboxplayer.SelectedItem);
            Back();
        }
        private void Delete()
        {
            string nametodelete = listboxplayer.GetItemText(listboxplayer.SelectedItem);
            if (frmMenu.name == nametodelete || nametodelete == "Guest")
            {
                if (nametodelete == "Guest")
                {
                    lblblock.Text = "Você não pode deletar um convidado. \r\n      Que deselegante, jovem!";
                    lblblock.Location = new Point(307, 61);
                }
                else
                {
                    lblblock.Text = "Ops! Você não pode se deletar mané!";
                    lblblock.Location = new Point(314, 77);
                }
                lblblock.Visible = true;
                timer1.Enabled = true;
            }
            else
            {
                players.Remove(nametodelete);
                Player.Delete(nametodelete);
                listboxplayer.Items.Clear();
                foreach (string names in players)
                {
                    listboxplayer.Items.Add(names);
                }
            }
        }

        private void frmback_Click(object sender, EventArgs e)
        {
            Back();
        }
        /// <summary>
        /// Abre o frmNewPlayer para criar um novo player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnnew_Click(object sender, EventArgs e)
        {
            New();
        }
        /// <summary>
        /// Recebe uma lista com o nome de todos os jogadores e insere no ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSelectPlayer_Load(object sender, EventArgs e)
        {
            players = DataBase.LoadUsersName();
            foreach (string names in players)
            {
                listboxplayer.Items.Add(names);
                //O usuário foi selecionado, e o arquivo deletado, logo, tal usuário não existe mais.
                if (names != frmMenu.name) frmMenu.name = "Guest"; 
            }
            listboxplayer.SelectedIndex = 0;

            listboxplayer.Focus();
        }
        /// <summary>
        /// Assim que um player for selecionado, o jogo retorna ao menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btncheck_Click(object sender, EventArgs e)
        {
            SelectPlayer();
        }
        /// <summary>
        /// Deleta o usuário selecionado do registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!stop) stop = true;
            else
            {
                lblblock.Visible = false;
                timer1.Enabled = false;
                stop = false;
            }
        }

        private void frmSelectPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1) New();
            else if (e.KeyCode == Keys.F2) SelectPlayer();
            else if (e.KeyCode == Keys.F3) Delete();
        }
    }
}
