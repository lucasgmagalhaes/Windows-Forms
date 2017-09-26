using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Estruturas_de_dados.Estrutura_Base;

namespace Estruturas_de_dados.Lista_Tipos
{
    /// <summary>
    /// Classe base para implementação das demais estruturas do tipo lista
    /// </summary>
    class Lista
    {
        protected Elemento prim, ult;

        public virtual void Add(Dados el)
        {
            Elemento aux = new Elemento(el);
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
                    Elemento auxel = aux.Prox;
                    aux.Prox = aux.Prox.Prox;
                    auxel = null;
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
