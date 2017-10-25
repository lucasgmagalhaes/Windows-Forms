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
            Nodo aux = new Nodo(dado);
           this.raiz =  Inserir(new Nodo(dado), this.raiz);
        }
        private Nodo Inserir(Nodo novo, Nodo onde)
        {
            if (onde == null) return novo;
            else
            {
                if (onde.Dado.CompareTo(novo.Dado) == 1)
                {
                    onde.Esq = Inserir(novo, onde.Esq);
                }
                else if (onde.Dado.CompareTo(novo.Dado) == -1)
                {
                    onde.Dir = Inserir(novo, onde.Dir);
                }
            }
            return onde;
        }
        public IDados Procurar(int dad)
        {
            return Procurar(dad, this.raiz).Dado;
        }
        public IDados Procurar(long dad)
        {
            return Procurar(dad, this.raiz).Dado;
        }
        private Nodo Procurar(int procura, Nodo atual)
        {
            if (atual == null) return atual;
            else
            {
                if (atual.Dado.CompareTo(procura) == 1) return Procurar(procura, atual.Esq);
                else if (atual.Dado.CompareTo(procura) == -1) return Procurar(procura, atual.Dir);
                else return atual;
            }
        }
        private Nodo Procurar(long procura, Nodo atual)
        {
            if (atual == null) return atual;
            else
            {
                if (atual.Dado.CompareTo(procura) == 1) return Procurar(procura, atual.Esq);
                else if (atual.Dado.CompareTo(procura) == -1) return Procurar(procura, atual.Dir);
                else return atual;
            }
        }
    }
}
