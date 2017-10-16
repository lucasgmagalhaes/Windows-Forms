using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leitor_De_Processos
{
    class Fila
    {
        private Elemento prim, ult, menor;
        private int count;

        internal Elemento Prim
        {
            get
            {
                return prim;
            }

            set
            {
                prim = value;
            }
        }

        internal Elemento Ult
        {
            get
            {
                return ult;
            }

            set
            {
                ult = value;
            }
        }

        internal Elemento Menor
        {
            get
            {
                return menor;
            }

            set
            {
                menor = value;
            }
        }

        //internal Elemento Menor { get => menor; }

        public Fila()
        {
            Elemento aux = new Elemento(null);
            this.Prim = aux;
            this.Ult = Prim;
            this.Menor = this.Ult;
            count = 0;
        }
        public Elemento Primeiro()
        {
            return Prim.Prox;
        }
        private void ElementAdded()
        {
            count++;
        }
        private void ElementDeleted()
        {
            count--;
        }
        public Dados MenorElemento()
        {
            return Menor.GetDados();
        }

        public void Add(Dados dad)
        {
            if (dad != null)
            {
                Elemento toinsert = new Elemento(dad);
                this.Ult.Prox = toinsert;
                this.Ult = this.Ult.Prox;
                ElementAdded();
            }
        }
        public int Count()
        {
            return count;
        }
        public Dados Remover()
        {
            if (this.Prim.Prox != null)
            {
                Elemento aux = this.Prim.Prox;
                Elemento aux2 = aux;
                this.Prim.Prox = aux.Prox;
                aux = null;
                ElementDeleted();
                return aux2.GetDados();
            }
            else return null;
        }
        public void Clear()
        {
            while (this.Prim.Prox != null)
            {
                Elemento aux = this.Prim.Prox;
                Elemento aux2 = aux;
                this.Prim.Prox = aux.Prox;
                aux = null;
                ElementDeleted();
            }
            Elemento aux3 = new Elemento(null);
            this.Prim = aux3;
            this.Ult = Prim;
        }
    }
}