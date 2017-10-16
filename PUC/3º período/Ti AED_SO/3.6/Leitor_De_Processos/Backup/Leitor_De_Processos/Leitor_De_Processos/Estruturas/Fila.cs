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
        internal Elemento Menor { get => menor; }

        public Fila()
        {
            Elemento aux = new Elemento(null);
            this.prim = aux;
            this.ult = prim;
            this.menor = this.ult;
            count = 0;
        }
        public Elemento Primeiro()
        {
            return prim.Prox;
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
            return menor.GetDados();
        }
        private void CalcMenor()
        {
            Elemento f = this.prim.Prox;
            Elemento next = f.Prox;
            while(next != f)
            {
                Processo dd = (Processo)menor.GetDados();
                if (dd.CompareTTotalExecucao(next.GetDados()) == -1) this.menor = next;
                next = next.Prox;
            }
        }
        public int CompareMinElement(Dados obj)
        {
            Processo aux = (Processo)(obj);
            Processo owner = (Processo)(menor.GetDados());
            if (aux.T_total_execucao > owner.T_total_execucao ) return 1;
            else if (aux.T_total_execucao == owner.T_total_execucao) return 0;
            else return -1;
        }
        public void Add(Dados dad)
        {
            if (dad != null)
            {
                Elemento toinsert = new Elemento(dad);
                this.ult.Prox = toinsert;
                this.ult = this.ult.Prox;
                ElementAdded();
                Processo dd = (Processo)menor.GetDados();
                if (dd.CompareTTotalExecucao(dad) == -1) this.menor = toinsert;
            }
        }
        public int Count()
        {
            return count;
        }
        public Dados Remover()
        {
            if (this.prim.Prox != null)
            {
                Elemento aux = this.prim.Prox;
                Elemento aux2 = aux;
                this.prim.Prox = aux.Prox;
                aux = null;
                ElementDeleted();
                CalcMenor();
                return aux2.GetDados();
            }
            else return null;
        }
        public void Clear()
        {
            while (this.prim.Prox != null)
            {
                Elemento aux = this.prim.Prox;
                Elemento aux2 = aux;
                this.prim.Prox = aux.Prox;
                aux = null;
                ElementDeleted();
            }
            Elemento aux3 = new Elemento(null);
            this.prim = aux3;
            this.ult = prim;
        }

    }
}
