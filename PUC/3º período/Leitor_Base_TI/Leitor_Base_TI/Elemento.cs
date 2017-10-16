using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leitor_Base_TI
{
    class Elemento
    {
        private Dados dado;
        private Elemento proximo;

        public Elemento(Dados dad)
        {
            this.dado = dad;
        }

        internal Elemento Proximo { get => proximo; set => proximo = value; }

        public Dados GetDados()
        {
            return dado;
        }
    }
}
