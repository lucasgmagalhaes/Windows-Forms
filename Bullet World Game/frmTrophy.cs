using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Ti;
using BulletWorld.Class;
/// <summary>
/// ESTE FORM POSSUI 2 DATAGRIDVIEW
/// MOTIVO:
/// 1º DataGrid está configurado para receber imagem na primeira coluna enquanto o segundo recebe texto na primeira coluna
/// a diferença é apenas essa. Porém, ao usuário ele verá apenas uma tabela de ranking tendo o 1º, 2º e 3º lugar destacados
/// </summary>
namespace BulletWorld
{
    public partial class frmTrophy : Form
    {
        public frmTrophy()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Método não relevante para os usuários
        /// Basicamente ele deixa o fundo do DataGridView igual a cor do BackColor do .thisForm
        /// </summary>
        private void DataGridSetColor()
        {
            DataGridPlayer.EnableHeadersVisualStyles = false;
            DataGridPlayer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(85, 85, 255);
            DataGridPlayer.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(85, 85, 255);

            foreach (DataGridViewColumn col in DataGridPlayer.Columns)
            {
                col.DefaultCellStyle.BackColor = Color.FromArgb(85, 85, 255);
                col.DefaultCellStyle.SelectionBackColor = Color.FromArgb(85, 85, 255);
            }

            DataGridOtherPlayers.EnableHeadersVisualStyles = false;
            DataGridOtherPlayers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(85, 85, 255);
            DataGridOtherPlayers.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(85, 85, 255);

            foreach (DataGridViewColumn col in DataGridOtherPlayers.Columns)
            {
                col.DefaultCellStyle.BackColor = Color.FromArgb(85, 85, 255);
                col.DefaultCellStyle.SelectionBackColor = Color.FromArgb(85, 85, 255);
            }
        }
        /// <summary>
        /// No carregamento do form, o primeiro DataGridView será preenchido de acordo com a quantidade de usuários cadastrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPlayerSelect_Load(object sender, EventArgs e)
        {
            DataGridSetColor();
            List<Player> Players = Ranking.Type(1);
            if(Players.Count >= 1 && Players[0] != null)
            {
                DataGridPlayer.Rows.Add(Properties.Resources.Primeiro, Players[0].Name, Players[0].Points);
                if (Players.Count >= 2 && Players[1] != null)
                {
                    DataGridPlayer.Rows.Add(Properties.Resources.Segundo, Players[1].Name, Players[1].Points);
                    if (Players.Count >= 3 && Players[2] != null) DataGridPlayer.Rows.Add(Properties.Resources.Terceiro, Players[2].Name, Players[2].Points);
                }
            }
            for (int x = 3; x < Players.Count; x++) DataGridOtherPlayers.Rows.Add(x + 1, Players[x].Name, Players[x].Points); 
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.MdiParent = frmMain.ActiveForm;
            menu.Show();
            this.Close();
        }
    }
}
