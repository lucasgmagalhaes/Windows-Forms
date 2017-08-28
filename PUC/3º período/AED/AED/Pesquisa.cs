using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED
{
    class Pesquisa
    {
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
                    frmmain.SavarNoLog("PESQUISA", "SEQUENCIAL", "", Contador.Stop());
                    return i;
                }
            }
            frmmain.SavarNoLog("PESQUISA", "SEQUENCIAL", "", Contador.Stop());
            return -1;
        }
        private static long MaskBinaria(long[] vetor, long achar, int inc, int fim)
        {
            int meio = (inc + fim) / 2;

            if (inc > fim) return -1;
            else if (meio == achar) return vetor[meio];
            else if (meio > achar) return PesquisaBinaria(vetor, achar, ++meio, fim);
            else return PesquisaBinaria(vetor, achar, --meio, inc);
        }
        public static long PesquisaBinaria(long[] vetor, long achar, int inc, int fim)
        {
            Contador.Start();
            long result = MaskBinaria(vetor, achar, inc, fim);
            frmmain.SavarNoLog("PESQUISA", "RECURSIVO", result.ToString(), Contador.Stop());
            return result;
        }
    }
}
