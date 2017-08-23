using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AED
{
    public partial class frmmain : Form
    {
        #region FATORIAL
        static List<int> fatorialVALS = new List<int>();
        //Fatorial iterativo
        public static long FatorialIterativo(int val)
        {
            long result = 1;

            for(int i = 0; i <= val; i++)
            {
                if(i == 0 || i == 1)
                {
                    result = 1;
                }
                else
                {
                    result *= i; 
                }
            }

            return result;
        }
        
        public static long FatorialRecursivo(long val)
        {
            if(val == 0 || val == 1)
            {
                return 1;
            }
            else
            {
                return val *= FatorialRecursivo(val - 1);
            }
        }
        #endregion

        #region Fibonacci
        public static long FibonacciIterativo(long val)
        {
            long n1 = 0, n2 = 0, n3 = 0;
            for (int i = 0; i < val; i++){

                if (val == 0 || val == 1)
                {
                    n1 =  n2 = n3 =1;
                }
                else
                {
                    n3 = n2 + n1;
                    n1 = n2;
                    n2 = n3;
                }
            }
            return n3;
        }

        public static long FibonacciRecursivo(long val)
        {
            if(val == 0 || val == 1)
            {
                return 1;
            }
            else
            {
                return FibonacciRecursivo(val - 1) + FibonacciRecursivo(val - 2);
            }
        }

        #endregion

        #region PESQUISA

        public static long PesquisaSequencial(long[] vetor, long achar)
        {
            for(int i = 0; i < vetor.Length; i++)
            {
                if(vetor[i] == achar)
                {
                    return i;
                }
            }
            return -1;
        }

        public static long PesquisaBinaria(long[] vetor, long achar, int inc, int fim)
        {
            int meio = (inc + fim) / 2;

            if (inc > fim) return -1;
            else if (meio == achar) return vetor[meio];
            else if (meio > achar) PesquisaBinaria(vetor, achar, ++meio, fim);
            else PesquisaBinaria(vetor, achar, --meio, inc);
        }

        #endregion
        public frmmain()
        {
            InitializeComponent();
        }

        private void btnfatorialInt_Click(object sender, EventArgs e)
        {
            int num = 1;
            try
            {
               num =  Convert.ToInt32(txtfatorialintvalor.Text);
            }
            catch
            {
                MessageBox.Show("O valor informado no campo de registro de valor do Fatorial não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            fatorialVALS.Add(num);
            cmbfatorial.Items.Add(num);
        }

        private void btnfatorialexecutar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
