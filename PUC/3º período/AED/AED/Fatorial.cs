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
        public double iterativo_resul;
        public double recursivo_resul;       

        public static List<int> VALS = new List<int>();
        public static int[] AUTOVALS = new int[] {5,10,20,40,50,100};
        //Fatorial iterativo
        public static ulong FatorialIterativo(ulong val)
        {
            ulong result = 1;
            for (uint i = 0; i <= val; i++)
            {
                if (i == 0 || i == 1)
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
        /// <summary>
        /// Quando o método de fatorial recursivo for chamado, ele estará contido por outro método, para garantir 
        /// adequadamente o tempo de contagem
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static ulong FatorialRecursivo(ulong val)
        {
            if (val == 0 || val == 1)
            {
                return 1;
            }
            else
            {
                return val *= FatorialRecursivo(val - 1);
            }
        }
    }
}
