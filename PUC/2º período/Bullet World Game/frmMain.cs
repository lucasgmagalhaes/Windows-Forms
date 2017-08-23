using System;
using System.Windows.Forms;
using BulletWorld;
using System.Collections.Generic;
using System.IO;
using BulletWorld.Class;

namespace Ti
{
    /// <summary>
    /// Form feito para dar "suporte" aos demais forms, com exceção do frmBulletWorld
    /// significa que tais forms serão abertos DENTRO deste form. O objetivo dessa escolha foi impedir que o usuário
    /// fique vendo várias telas serem abertas e fechadas na barra de tarefas
    /// O método usado para inserir um form em outro foi o MDIContainer, o container é uma propriedade de cada form e vem
    /// por padrão desabilitada.
    /// -----------------------------------
    /// Forms subsequentes quando forem iniciados terão inseridas a propriedade de: objdoform.MdiParent = this;
    /// significa que tal form que será iniciado ficará dentro do form sitado (this);
    /// Um mdichild não pode ser parent tbm. Ex: form x é parent e abre o form y que é child. Se o y tentar abrir um form z
    /// sendo y parent, tal aplicação acionará uma exceção.
    /// </summary>
    public partial class frmMain : Form
    {
        #region Variáveis
        private bool fristmsg;
        private int secondmsg = 0;
        private frmFirstMgsHS msg = new frmFirstMgsHS();
        private frmCompanyMgs comp = new frmCompanyMgs();
        private frmMenu menu = new frmMenu();
        private frmTrophy selectplayer = new frmTrophy();
        private frmChoice choice = new frmChoice();
        private frmBulletWorld world = new frmBulletWorld();
        #endregion
        #region Construtores
        /// <summary>
        /// construtor padrão que carregará todos os form iniciais
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            comp.MdiParent = this;
            msg.MdiParent = this;
            menu.MdiParent = this;
            msg.Show();
            timer_firstmsg.Enabled = true;
            timer_companymsg.Enabled = true;
        }
        /// <summary>
        /// Método usado quando a "partida" acabar e o jogador voltar para a tela principal
        /// </summary>
        /// <param name="reboot"></param>
        public frmMain(bool reboot)
        {
            InitializeComponent();
            selectplayer.MdiParent = this;
            menu.MdiParent = this;
            menu.Show();
        }

        public static void MyGC()
        {
            List<Form> frm = new List<Form>();
            foreach(Form active in Application.OpenForms)
            {
                frm.Add(active);
            }
            foreach(Form got in frm)
            {
                if (got.Name != "frmMenu" && got.Name != "frmMain") got.Close();
            }
        }

        #endregion
        #region Timers
        /// <summary>
        /// Primeira msg mostrando "Para uma melhor experiência de jogo, recomenda-se o uso do headset" tendo 
        /// o controle feito pelo timer_firstmsg. o fristmsg funciona como um "deve passar? true"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_firstmsg_Tick(object sender, EventArgs e) //Timer para contar o tempo em que a primeira msg ficará exibida
        {
            if (fristmsg == true)
            {
                timer_firstmsg.Enabled = false;
                msg.Close();
                timer_companymsg.Enabled = true;
            }
            else fristmsg = true;
        }
        /// <summary>
        /// Controla o tempo em que a segunda msg será exibida, em seguida o menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_companymsg_Tick(object sender, EventArgs e)
        {
            if (secondmsg == 2) comp.Show();
            else if (secondmsg == 4)
            {
                timer_companymsg.Enabled = false;
                comp.Close();
                GC.Collect(); //Como esse form não será exibido novamente, pode fecha-lo
                menu.Show();
            }
            secondmsg++;
        }
        #endregion
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Data.xml")) DataBase.CreateXML();
        }
        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if(choice.ActiveMdiChild != null)
            {
                menu.Show();
                world.Close();
            }
        }
    }
}
