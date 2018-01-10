using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora_de_expressoes
{
    class Lista
    {
        protected Elemento prim, ult;

        public Lista()
        {
            Dados aux = null;
            this.prim = new Elemento(aux);
            this.ult = prim;
        }
        public virtual void Add(string d)
        {
            Elemento aux = new Elemento(d);
            this.ult.Prox = aux;
            this.ult = aux;
        }
        public virtual void Remover(Dados obj)
        {
            Elemento aux = this.prim;
            while (aux != null)
            {
                if (aux.Prox.GetDados().Equals(obj))
                {
                    aux.Prox = aux.Prox.Prox;
                    break;
                }
                aux = aux.Prox;
            }
        }
        public Dados Find(Dados obj)
        {
            Elemento aux = this.prim;
            while (aux != null)
            {
                if (aux.GetDados().Equals(obj))
                {
                    return aux.GetDados();
                }
                aux = aux.Prox;
            }
            return null;
        }
    }
}
