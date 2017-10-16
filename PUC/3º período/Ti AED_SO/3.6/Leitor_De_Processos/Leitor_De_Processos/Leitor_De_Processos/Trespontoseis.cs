using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Leitor_De_Processos
{
    public partial class Trespontoseis : Form
    {
        public Trespontoseis()
        {
            InitializeComponent();
        }

        private void tb_Valor_TextChanged(object sender, EventArgs e)
        {
            tb_Valor.Text.ToString();
        }

        private void bt_Exe_Click(object sender, EventArgs e)
        {
            //instancia a classe tarefas e variáveis
            Tarefas t = new Tarefas();
            double resultFat = 0, resultFib = 0, total = 0;
            int num = int.Parse(tb_Valor.Text.ToString());

            //inicia uma nova thread chamando o método Fatorial da classe Tarefa
            Thread tr = new Thread((() => resultFib = t.CalcFibonacciIterativo(num)));

            tr.Start();

            new Thread(() => resultFat = t.Fatorial(num)).Start();

            //Sleep para dar "tempo" ao programa executar a thread
            Thread.Sleep(1000);
            lbFib.Text = resultFib.ToString();
            lbFat.Text = resultFat.ToString();
            //apresenta o resultado na tela
            total = resultFat + resultFib;

            lb_Result.Text = total.ToString();
        }
    }
}
