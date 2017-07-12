using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI_FSI.Classes
{
    public class DADOS
    {
        public string info;
        public int valor;

        /// <summary>
        /// Usado na classe comida
        /// </summary>
        /// <param name="i"></param>
        /// <param name="v"></param>
        public DADOS(string i, int v)
        {
            this.info = i;
            this.valor = v;
        }
    }
}
