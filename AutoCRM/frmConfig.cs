using System;
using System.Windows.Forms;
using System.IO;

namespace AutoCRM
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }
        //Variável usada para saber se deve ou não carregar as informações do arquivo quando for feita a conexão
        bool LoadQuest = true;
        private void btndefault_Click(object sender, EventArgs e)
        {
            txtservidor.Text = "";
            txtbanco.Text = "";
            txtsenha.Text = "";
            txtuser.Text = "";
            mtxtport.Text = "";

            Conection.DataBaseName(txtbanco.Text);
            Conection.ServerName(txtservidor.Text);
            Conection.Password(txtsenha.Text);
            Conection.User(txtuser.Text);
            Conection.Port(mtxtport.Text);
        }
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            using (StreamWriter Configs = new StreamWriter("Configuracoes", false))
            {
                Encription.LerChave();
                Configs.WriteLine(Encription.Encryption(txtservidor.Text));
                Configs.WriteLine(Encription.Encryption(txtbanco.Text));
                Configs.WriteLine(Encription.Encryption(txtsenha.Text));
                Configs.WriteLine(Encription.Encryption(txtuser.Text));
                Configs.WriteLine(Encription.Encryption(mtxtport.Text));
                Configs.Close();
            }

            Conection.DataBaseName(txtbanco.Text);
            Conection.ServerName(txtservidor.Text);
            Conection.Password(txtsenha.Text);
            Conection.User(txtuser.Text);
            Conection.Port(mtxtport.Text);

            DialogResult Result;
            if (LoadQuest == true)
            {
                Conection.LoadConfigs();
                LoadQuest = false;
            }
                if (Conection.Open() == true)
            {
                Result = MessageBox.Show("Conexão efetuada com sucesso.", "V11");
                if (Result == DialogResult.OK) this.Close();
            }
            else
            {
                Result = MessageBox.Show("Não foi possível conectar com o Banco.");
            }

        }
        private void frmConfig_Load(object sender, EventArgs e)
        {
            Conection.LoadConfigs();
            txtbanco.Text = Conection.DatabaseN;
            txtsenha.Text = Conection.PwdN;
            txtservidor.Text = Conection.ServerN;
            txtuser.Text = Conection.UidN;
            mtxtport.Text = Conection.Port1;
        }
    }
}
