using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula3;

namespace Microondas
{
    public partial class Form1 : Form
    {
        Microondas micro = new Microondas();
        Relogio temp = new Relogio(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

        int countDisplay = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void TampaProp()
        {
            if (micro.Status() == false)
            {
                if (micro.StatusPorta() == false)
                {
                    picTampa.Image = Properties.Resources.Aberto;
                    micro.AbrirPorta();
                   
                    if (COMIDAPRONTA.Enabled == true)
                    {
                        COMIDAPRONTA.Enabled = false;
                        if (micro.ON_OFF() == false) ExibirHora();
                        else ExibirContador();
                        Unlock();
                    }                   
                }
                else
                {
                    picTampa.Image = Properties.Resources.Fechado;
                    micro.FecharPorta();
                }
            }
        }

        private void ExibirHora()
        {
            lblminuto.Text = temp.HoraAjustada();
            lblseg.Text = temp.MinutoAjustado();
        }

        private void ExibirContador()
        {
            lblminuto.Text = micro.MinutoAjustado();
            lbl2pontos.Text = ":";
            lblseg.Text = micro.SegundoAjustado();
        }

        private void Lock()
        {
            btnt1.Enabled = false;
            btnt2.Enabled = false;
            btnt3.Enabled = false;
            btnt4.Enabled = false;
            btnt5.Enabled = false;
            btnt6.Enabled = false;
            btnt7.Enabled = false;
            btnt8.Enabled = false;
            btnt9.Enabled = false;
            btnt0.Enabled = false;
            btnstart.Enabled = false;
            btnaumentap.Enabled = false;
            btndiminuip.Enabled = false;
        }

        private void Unlock()
        {
            btnt1.Enabled = true;
            btnt2.Enabled = true;
            btnt3.Enabled = true;
            btnt4.Enabled = true;
            btnt5.Enabled = true;
            btnt6.Enabled = true;
            btnt7.Enabled = true;
            btnt8.Enabled = true;
            btnt9.Enabled = true;
            btnt0.Enabled = true;
            btnstart.Enabled = true;
            btnaumentap.Enabled = true;
            btndiminuip.Enabled = true;
        }

        private void picTampa_Click(object sender, EventArgs e)
        { 
            TampaProp();
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            TampaProp();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPAUSE.Visible = false;
            ExibirHora();
            Lock();

            Hora.Enabled = true;
            lblPAUSE.Text = "";
        }

        private void btnt1_Click(object sender, EventArgs e)
        {
            if (lbl2pontos.Text == ":")
            {
                micro.SetTime(1);
                ExibirContador();
            }
        }

        private void btnt2_Click(object sender, EventArgs e)
        {
            if (lbl2pontos.Text == ":")
            {
                micro.SetTime(2);
                ExibirContador();
            }
        }

        private void btnt3_Click(object sender, EventArgs e)
        {
            if (lbl2pontos.Text == ":")
            {
                micro.SetTime(3);
                ExibirContador();
            }
        }

        private void btnt4_Click(object sender, EventArgs e)
        {
            if (lbl2pontos.Text == ":")
            {
                micro.SetTime(4);
                ExibirContador();
            }
        }

        private void btnt5_Click(object sender, EventArgs e)
        {
            if (lbl2pontos.Text == ":")
            {
                micro.SetTime(5);
                ExibirContador();
            }
        }

        private void btnt6_Click(object sender, EventArgs e)
        {
            if (lbl2pontos.Text == ":")
            {
                micro.SetTime(6);
                ExibirContador();
            }
        }

        private void btnt7_Click(object sender, EventArgs e)
        {
            if (lbl2pontos.Text == ":")
            {
                micro.SetTime(7);
                ExibirContador();
            }
        }

        private void btnt8_Click(object sender, EventArgs e)
        {
            if (lbl2pontos.Text == ":")
            {
                micro.SetTime(8);
                ExibirContador();
            }
        }

        private void btnt9_Click(object sender, EventArgs e)
        {
            if (lbl2pontos.Text == ":")
            {
                micro.SetTime(9);
                ExibirContador();
            }
        }

        private void btnt0_Click(object sender, EventArgs e)
        {
            if (lbl2pontos.Text == ":")
            {
                micro.SetTime(0);
                ExibirContador();
            }
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (micro.StatusPorta() == false)
            {
                if (micro.Tempo() != "00:00")
                {
                    micro.Ativar();

                    if (Cronometro.Enabled == true)
                    {
                        Cronometro.Enabled = false;
                        lblPAUSE.Visible = true;

                    }
                    else
                    {
                        Cronometro.Enabled = true;
                        lblPAUSE.Visible = false;
                    }
                }
            }
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            if (micro.Start() == true)
            {
                Cronometro.Enabled = false;
                picTampa.Enabled = true;
                btnabrir.Enabled = true;
                Lock();
            }
            else
            {
                picTampa.Enabled = false;
                btnabrir.Enabled = false;
            }
            if (micro.Tempo() == "00:00")
            {
                micro.Desativar();
                COMIDAPRONTA.Enabled = true;
            }
            if (PotenciaDisplay.Enabled == false) ExibirContador();
        }

        private void btnaumentap_Click(object sender, EventArgs e)
        {
            micro.AumentarP();
            lbl2pontos.Text = micro.Potencia();
            PANEL2P.Size = new Size(75, 71);
            PANEL2P.Location = new Point(110, 0);

            if (micro.Potencia() == "10")
            {
               // NORMAL X = 126 Y = 0 
                PANEL2P.Location = new Point(90, 0);
            }

            lblminuto.Visible = false;
            lblseg.Visible = false;
            PotenciaDisplay.Enabled = true;
            countDisplay = 0;
        }

        private void PotenciaDisplay_Tick(object sender, EventArgs e)
        {
            if (lbl2pontos.Text != ":")
            {
                if (countDisplay == 2)
                {
                    PANEL2P.Size = new Size(20, 71);
                    PANEL2P.Location = new Point(126, 0);
                    lblminuto.Visible = true;
                    lblseg.Visible = true;
                    ExibirContador();
                    countDisplay = 0;

                    PotenciaDisplay.Enabled = false;
                }
                else countDisplay++;
            }
        }

        private void btndiminuip_Click(object sender, EventArgs e)
        {
            
            micro.DiminuirP();
            lbl2pontos.Text = micro.Potencia();
            PANEL2P.Size = new Size(75, 71);
            PANEL2P.Location = new Point(110, 0);
            lblminuto.Visible = false;
            lblseg.Visible = false;
            PotenciaDisplay.Enabled = true;
            countDisplay = 0;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            if (Hora.Enabled == true)
            {
                micro.Ligar();
                Hora.Enabled = false;
                Unlock();

                ExibirContador();
                lblPAUSE.Text = "PAUSE";
                lblPAUSE.Visible = false;
            }
            else
            {
                micro.Desligar();
                COMIDAPRONTA.Enabled = false;
                Hora.Enabled = true;
                temp.SetHora(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                ExibirHora();
                Lock();

                Cronometro.Enabled = false;
                PotenciaDisplay.Enabled = false;
                lblPAUSE.Text = "";
            }
            picTampa.Enabled = true;
            btnabrir.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            temp.TimerClock();

            if (lbl2pontos.Text == ":") lbl2pontos.Text = " ";
            else lbl2pontos.Text = ":";

            lblminuto.Text = temp.HoraAjustada();
            lblseg.Text = temp.MinutoAjustado();
        }

        private void COMIDAPRONTA_Tick(object sender, EventArgs e)
        {
            if (countDisplay == 1)
            {
                lbl2pontos.Text = "";
                lblminuto.Text = "";
                lblseg.Text = "";
                countDisplay = 0;
            }
            else
            {
                ExibirContador();
                countDisplay++;
            }
        }
    }
}
