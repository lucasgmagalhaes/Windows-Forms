using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_Contas.Classes
{
    class Arvore
    {
        private Nodo raiz;

        public Arvore()
        {
            this.raiz = null;
        }

        public void Inserir(IDados dado)
        {
            if (this.raiz == null) this.raiz = new Nodo(dado);
            else
            {
                int get = this.raiz.CompareTo(dado);
                if (get == 1) this.raiz.Esq = new Nodo(Inserir(dado, raiz.Esq));
                else if (get == -1) this.raiz.Dir = new Nodo(Inserir(dado, raiz.Dir));
            }
        }
        private IDados Inserir(IDados dado, Nodo onde)
        {
            if (onde == null) return dado;
            else
            {
                if (onde.CompareTo(dado) == 1)
                {
                   onde.Esq =  new Nodo(Inserir(dado, onde.Esq));
                }
                else if (onde.CompareTo(dado) == -1)
                {
                   onde.Dir = new Nodo(Inserir(dado, onde.Dir));
                }
            }
            return onde;
        }
    }
}
