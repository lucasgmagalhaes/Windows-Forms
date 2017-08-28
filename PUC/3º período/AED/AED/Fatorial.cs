using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED
{
    class Fatorial
    {
        public static List<int> VALS = new List<int>();

        //Fatorial iterativo
        public static ulong FatorialIterativo(ulong val)
        {
            ulong result = 1;
            Contador.Start();
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

            frmmain.SavarNoLog("FATORIAL", "ITERATIVO", val.ToString(), Contador.Stop());
            return result;
        }

        /// <summary>
        /// Método oficial de recursividade no fatorial
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        private static ulong MaskRecursivo(ulong val)
        {
            if (val == 0 || val == 1)
            {
                return 1;
            }
            else
            {
                return val *= MaskRecursivo(val - 1);
            }
        }

        /// <summary>
        /// Quando o método de fatorial recursivo for chamado, ele estará contido por outro método, para garantir 
        /// adequadamente o tempo de contagem
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static ulong FatorialRecursivo(ulong val)
        {
            Contador.Start();
            ulong total = MaskRecursivo(val);
            frmmain.SavarNoLog("FATORIAL","RECURSIVO", val.ToString(), Contador.Stop());
            return total;
        }
    }
}
