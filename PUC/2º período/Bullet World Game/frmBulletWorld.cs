using System;
using System.Diagnostics;
using System.Windows.Forms;
using ComeBullet;
using System.Drawing;
using Ti;
using BulletWorld.Class.Chars;
namespace BulletWorld
{
    public partial class frmBulletWorld : Form
    {
        public frmBulletWorld()
        {
            InitializeComponent();
        }
        frmQuit backmenu;
        Personagem personagem;
        private int getper;

        public frmBulletWorld(int i)
        {
            InitializeComponent();
            this.getper = i;
            switch (i)
            {
                case 1:
                    personagem = new CheepCheep(this);
                    break;
                case 2:
                    personagem = new BulletBill(this);
                    break;
                case 3:
                    personagem = new CrazyBlooper(this);
                    break;
                case 4:
                    personagem = new LeftMario(this);
                    break;
                case 5:
                    personagem = new Wario(this);
                    break;
                case 6:
                    personagem = new Wizard(this);
                    break;
                case 7:
                    personagem = new BulletBirl(this);
                    break;
            }
        }

        Stopwatch tempoJogo;
        public Random aleat = new Random(DateTime.Now.Millisecond);
        public Lista objetos = new Lista();

        private void Init()
        {
            objetos.limpaLista();
            ////teste
            //Teste timer e velocidade
            timer1.Enabled = timer2.Enabled = timer3.Enabled = true;
            tempoJogo = new Stopwatch();
            tempoJogo.Start();
        }

        private void frmBulletWorld_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region LOCKED
            if (e.KeyChar == '\u001b')
            {
                backmenu = new frmQuit("Vai mesmo arregar? AHN, EIN?!");
                backmenu.MdiParent = frmMain.ActiveForm;
                backmenu.Show();
            }
            #endregion
        }

        private void frmBulletWorld_Load(object sender, EventArgs e)
        {
            #region LOCKED
            this.Location = new Point(0, 0);
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(this.MdiParent.Width - 4, this.MdiParent.Height - 4);
            #endregion        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(personagem.verificaLimites()) personagem.mover();
            else
            {
                timer1.Enabled = timer2.Enabled = timer3.Enabled = false;
                frmEndGameResult lose = new frmEndGameResult(getper, false);
                lose.MdiParent = frmMain.ActiveForm;
                lose.Show();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            // Teste Timer e velocidade
            TimeSpan ts = tempoJogo.Elapsed;
            timeLabel.Text = ts.Minutes.ToString("00") + ":" + ts.Seconds.ToString("00") + ":" + (ts.Milliseconds / 10).ToString("00");
        }

        private void frmBulletWorld_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left) personagem.setDirecao(4);
            else if (e.KeyCode == Keys.Right) personagem.setDirecao(2);
            else if (e.KeyCode == Keys.Up) personagem.setDirecao(1);
            else if (e.KeyCode == Keys.Down) personagem.setDirecao(3);
        }

        private void frmBulletWorld_Shown(object sender, EventArgs e)
        {
            Init();
        }
    }
}
