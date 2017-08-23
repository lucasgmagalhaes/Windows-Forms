using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TI_FSI.Classes;

namespace TI_FSI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// chargeral - GeralTab / charRoupa - RoupaTab / charComida - ComidaTab / charBrinquedos - BrinquedoTab
        /// </summary>
        public Chart Send;
        Tabela table;
        private void Ops()
        {
            picload.Enabled = true;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog SelectOpen = new OpenFileDialog();
            if (SelectOpen.ShowDialog() == DialogResult.OK)
            {
                picload.Visible = true;

                FileInfo PathFile = new FileInfo(SelectOpen.SafeFileName);
                txtCaminhoArq.Text = SelectOpen.FileName;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExcelFile.CreateXLSApp();
            TabControl.Visible = false;
            picload.Visible = false;
        }

        private void TimerTempo_Tick(object sender, EventArgs e)
        {
            lbltempo.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExcelFile.CloseXLS();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Send = charGeral;

            if (ExcelFile.SetFile(txtCaminhoArq.Text, 1) == "1")
            {
                table = new Roupas(this);
                table.LoadGraphics();
            }
            if (ExcelFile.SetFile(txtCaminhoArq.Text, 2) == "1")
            {
                table = new Comida(this);
                table.LoadGraphics();
            }
            if (ExcelFile.SetFile(txtCaminhoArq.Text, 3) == "1")
            {
                table = new Brinquedo(this);
                table.LoadGraphics();
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            table = new Geral(this);
            table.LoadGraphics();
            table.LimparLista();
            table.LoadGraphics();

            TabControl.Visible = true;
            picload.Visible = false;
        }
    }
}
