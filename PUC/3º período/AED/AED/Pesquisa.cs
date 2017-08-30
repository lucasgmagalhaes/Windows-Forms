using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED
{
    class Pesquisa
    {
        public int val;
        public double binaria_resul;
        public double sequencial_resul;

        public static Dictionary<int, int> VAL = new Dictionary<int, int>();
        public static int[] AUTOVALS = new int[] { 10000, 20000, 100000};
        /// <summary>
        /// Preenche um vetor ordenado
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        private static long[] PreencherVetor(long[] vector)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                vector[i] = i;
            }
            return vector;
        }

        public static long PesquisaSequencial(long[] vetor, long achar)
        {
            vetor = PreencherVetor(vetor);
            Contador.Start();
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == achar)
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
            else if (meio > achar) return PesquisaBinaria(vetor, achar, meio + 1, fim);
            else return PesquisaBinaria(vetor, achar, meio - 1, inc);
        }
    }
}
