using BulletWorld;
using System;
using System.Windows.Forms;

namespace Ti
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(string player)
        {
            InitializeComponent();
            name = player;
        }

        private PictureBox[] _PictureBox;
        private PictureBox[] _Piccustom;
        private Label[] _Label;
        public static string name = "Guest";

        #region Forms Opens Blocks Methods
        //Conjunto de blocos para abrir forms
        private void OpenSelectChar()
        {        
            frmChoice quit = new frmChoice();
            quit.MdiParent = ActiveForm;
            quit.Show();
            this.Close();
        }

        private void OpenTrophy()
        {          
            frmTrophy selectplayer = new frmTrophy();
            selectplayer.MdiParent = frmMain.ActiveForm;
            selectplayer.Show();
            this.Close();
        }

        private void OpenSelectPlayer()
        {
            frmSelectPlayer player = new frmSelectPlayer();
            player.MdiParent = frmMain.ActiveForm;
            player.Show();
            this.Close();
        }

        private void OpenHelp()
        {           
            frmHelpcs selectplayer = new frmHelpcs();
            selectplayer.MdiParent = frmMain.ActiveForm;
            selectplayer.Show();
            this.Close();
        }

        private void OpenQuit()
        {
            frmQuit quit = new frmQuit();
            quit.MdiParent = frmMain.ActiveForm;
            quit.Show();
        }

      
        #endregion

        #region Contadores Labels/Picturebox
        private int LabelsCounter()
        {
            int aux = 0;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    aux++;
                }
            }
            return aux;
        }

        private int PictureBoxCounter()
        {
            int aux = 0;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is PictureBox)
                {
                    aux++;
                }
            }
            return aux;
        }
        #endregion
        /// <summary>
        /// O motivo para a criação de um método para receber a tecla precionada é apenas para
        /// facilitar a análise em breakpoint
        /// </summary>
        /// <param name="e"></param>
        private void KeyPressForm(PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                for (int i = 0; i < _Piccustom.Length; i++)
                {
                    if (_Piccustom[i].Visible == true)
                    {
                        _Piccustom[i].Visible = false;
                        if (i + 1 < _Piccustom.Length)
                        {
                            if (_Piccustom[i + 1] != null) _Piccustom[i + 1].Visible = true;
                        }
                        else _Piccustom[0].Visible = true;
                        break;
                    }
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                for (int i = 0; i <= _PictureBox.Length; i++)
                {
                    if (_Piccustom[i].Visible == true)
                    {
                        _Piccustom[i].Visible = false;
                        if (i - 1 < 0) _Piccustom[_Piccustom.Length - 1].Visible = true;
                        else
                        {
                            if (_Piccustom[i - 1] != null) _Piccustom[i - 1].Visible = true;
                        }
                        break;
                    }
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (picbox6.Visible == false)
                {
                    for (int x = 0; x <= _Piccustom.Length - 2; x++) _Piccustom[x].Visible = false;
                    picbox6.Visible = true;
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (picbox6.Visible == true)
                {
                    picbox6.Visible = false;
                    picbox1.Visible = true;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (picbox1.Visible == true) OpenSelectChar();
                else if (picbox3.Visible == true) OpenSelectPlayer();
                else if (picbox4.Visible == true) OpenHelp();
                else if (picbox5.Visible == true) OpenQuit();
                else if (picbox6.Visible == true) OpenTrophy();
            }
            else if (e.KeyCode == Keys.Escape) OpenQuit();
        }
        /// <summary>
        /// Mudança de visibilidade dos cursores para quando por apertada uma tecla
        /// </summary>
        /// <param name="name"></param>
        private void CursorChangOption(string name)
        {
            if (name == "Single Player")
            {
                picbox1.Visible = true;
                picbox2.Visible = false;
                picbox3.Visible = false;
                picbox4.Visible = false;
                picbox5.Visible = false;
                picbox6.Visible = false;
            }
            else if (name == "Player vs Player")
            {
                picbox1.Visible = false;
                picbox2.Visible = true;
                picbox3.Visible = false;
                picbox4.Visible = false;
                picbox5.Visible = false;
                picbox6.Visible = false;
            }
            else if (name == "Change Player")
            {
                picbox1.Visible = false;
                picbox2.Visible = false;
                picbox3.Visible = true;
                picbox4.Visible = false;
                picbox5.Visible = false;
                picbox6.Visible = false;
            }
            else if (name == "Help")
            {
                picbox1.Visible = false;
                picbox2.Visible = false;
                picbox3.Visible = false;
                picbox4.Visible = true;
                picbox5.Visible = false;
                picbox6.Visible = false;
            }
            else if(name == "Quit")
            {
                picbox1.Visible = false;
                picbox2.Visible = false;
                picbox3.Visible = false;
                picbox4.Visible = false;
                picbox5.Visible = true;
                picbox6.Visible = false;
            }
            else
            {
                picbox1.Visible = false;
                picbox2.Visible = false;
                picbox3.Visible = false;
                picbox4.Visible = false;
                picbox5.Visible = false;
                picbox6.Visible = true;
            }
        }
        /// <summary>
        /// Evento gerado ao ser precionado uma tecla dentro do form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenu_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            KeyPressForm(e);
        }
        /// <summary>
        /// Facilidade na hora do "MOUSEHOVER" ja que será percorrido um vetor para o tratamento de qual lbl será exibido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenu_Load(object sender, EventArgs e)
        {
            frmMain.MyGC();

            lblplayername.Text = name;

            _Label = new Label[LabelsCounter()];
            _PictureBox = new PictureBox[PictureBoxCounter()];
            _Piccustom = new PictureBox[6];

            _Label[0] = this.lblplayer;
            _Label[1] = this.lblplayername;
            _Label[2] = this.lblsingle;
            _Label[3] = this.lbl2players;
            _Label[4] = this.lblchangeplayer;
            _Label[5] = this.lblhelp;
            _Label[6] = this.lblquit;

            _PictureBox[0] = _Piccustom[0] = this.picbox1;
            _PictureBox[1] = _Piccustom[1] = this.picbox2;
            _PictureBox[2] = _Piccustom[2] = this.picbox3;
            _PictureBox[3] = _Piccustom[3] = this.picbox4;
            _PictureBox[4] = _Piccustom[4] = this.picbox5;
            _PictureBox[5] = _Piccustom[5] = this.picbox6;
            _PictureBox[6] = this.picboxGameLogo;
            _PictureBox[7] = this.picboxTrophy;
        }
        #region MOUSE HOVER
        private void lblsingle_MouseHover(object sender, EventArgs e)
        {
            CursorChangOption(lblsingle.Text);
        }

        private void lbl2players_MouseHover(object sender, EventArgs e)
        {
            CursorChangOption(lbl2players.Text);
        }

        private void lblhelp_MouseHover(object sender, EventArgs e)
        {
            CursorChangOption(lblhelp.Text);
        }

        private void lblquit_MouseHover(object sender, EventArgs e)
        {
            CursorChangOption(lblquit.Text);
        }

        private void lblchangeplayer_MouseHover(object sender, EventArgs e)
        {
            CursorChangOption(lblchangeplayer.Text);
        }

        private void picboxTrophy_MouseHover(object sender, EventArgs e)
        {
            CursorChangOption(picbox6.Name);
        }
#endregion

        #region CLICK BUTTON
        private void lblsingle_Click(object sender, EventArgs e)
        {
            OpenSelectChar();
        }

        private void lbl2players_Click(object sender, EventArgs e)
        {
            OpenSelectChar();
        }

        private void lblchangeplayer_Click(object sender, EventArgs e)
        {
            OpenSelectPlayer();
        }

        private void lblhelp_Click(object sender, EventArgs e)
        {
            OpenHelp();
        }

        private void lblquit_Click(object sender, EventArgs e)
        {
            OpenQuit();
        }

        private void picboxTrophy_Click(object sender, EventArgs e)
        {
            OpenTrophy();
        }
#endregion
    }
}
