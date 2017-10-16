using System;
using System.Windows.Forms;
using System.Threading;
using Leitor_De_Processos._3_6;

namespace Leitor_De_Processos
{
    public partial class frmexer3_6 : Form
    {
        public frmexer3_6()
        {
            InitializeComponent();
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

        private void tb_Valor_TextChanged(object sender, EventArgs e)
        {
            tb_Valor.Text.ToString();
        }
    }
}
