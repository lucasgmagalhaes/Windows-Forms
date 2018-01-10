using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora_de_expressoes
{
    class Elemento
    {
        private Dados dado;
        private Elemento prox;
        internal Elemento Prox { get => prox; set => prox = value; }

        public Elemento(string val)
        {
            Unidade aux = new Unidade(val);
            this.dado = aux;
        }
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
