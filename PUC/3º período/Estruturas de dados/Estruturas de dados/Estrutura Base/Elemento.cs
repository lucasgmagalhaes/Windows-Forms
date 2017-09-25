using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estruturas_de_dados.Estrutura_Base
{
    class Elemento
    {
        protected Dados dado;
        protected Elemento prox;
        internal Elemento Prox { get => prox; set => prox = value; }

        public Elemento(Dados obj)
        {
            this.dado = obj;
        }

        public Dados GetDados()
        {
            return dado;
        }
    }
}
