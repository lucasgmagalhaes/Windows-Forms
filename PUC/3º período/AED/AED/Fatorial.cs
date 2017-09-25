using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED
{
    class Fatorial
    {
        public int val;
        public string iterativo_resul;
        public string recursivo_resul;

        public static List<int> VALS = new List<int>();
        public static int[] AUTOVALS = new int[] { 5, 10, 20, 40, 50, 100 };
        //Fatorial iterativo
        public static ulong FatorialIterativo(ulong val)
        {
            ulong result = 1;
            for (uint i = 1; i <= val; i++)
            {
                if (i > 1)
                {
                    result *= i;
                }
            }
            return result;
        }
        /// <summary>
        /// Quando o método de fatorial recursivo for chamado, ele estará contido por outro método, para garantir 
        /// adequadamente o tempo de contagem
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static ulong FatorialRecursivo(ulong val)
        {
            if (val == 0)
            {
                return 1;
            }
            else
            {
                return val * FatorialRecursivo(val - 1);
            }
        }
    }
}

