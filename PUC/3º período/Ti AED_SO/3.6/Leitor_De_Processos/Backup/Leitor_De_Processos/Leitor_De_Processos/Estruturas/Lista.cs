namespace Leitor_De_Processos
{
    /// <summary>
    /// Classe base para implementação das demais estruturas do tipo lista
    /// </summary>
    abstract class Lista
    {
        protected Elemento prim, ult, menor;
        protected int count;

        public Dados Primeiro()
        {
            return this.prim.Prox.GetDados();
        }
        protected void ElementAdded()
        {
            count++;
        }
        protected void ElementDeleted()
        {
            count--;
        }
        public int Count()
        {
            return count;
        }
        public virtual void Add(Dados el)
        {
            Elemento aux = new Elemento(el);
            if (this.prim == null) this.prim = new Elemento(null);
            this.ult.Prox = aux;
            this.ult = aux;
            ElementAdded();
            Processo dd = (Processo)menor.GetDados();
            if (dd == null) this.menor = aux;
            else if (dd.CompareTTotalExecucao(el) == -1) this.menor = aux;
        }
        private void CalcMenor()
        {
            Elemento next = this.prim.Prox;
            while (next != null)
            {
                Processo dd = (Processo)menor.GetDados();
                if (dd == null) this.menor = next;
                else
                if (dd.CompareTTotalExecucao(next.GetDados()) == -1) this.menor = next;
                next = next.Prox;
            }
        }
        public int CompareMinElement(Dados obj)
        {
            Processo aux = (Processo)(obj);
            Processo owner = (Processo)(menor.GetDados());
            if (aux.T_total_execucao > owner.T_total_execucao) return 1;
            else if (aux.T_total_execucao == owner.T_total_execucao) return 0;
            else return -1;
        }
        public virtual Dados Remover(Dados obj)
        {
            Elemento aux = this.prim;
            while (aux.Prox != null)
            {
                if (aux.Prox.GetDados().Equals(obj))
                {
                    Elemento aux2 = aux.Prox;
                    aux.Prox = aux.Prox.Prox;
                    aux2.Prox = null;
                    ElementDeleted();
                    CalcMenor();
                    return aux2.GetDados();
                }
                aux = aux.Prox;
            }
            return null;
        }
        public virtual Dados RemoveFirst()
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
        public Dados MenorElemento()
        {
            return menor.GetDados();
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
        public void Clear()
        {
            Elemento aux = this.prim.Prox;
            Elemento aux2;
            while (aux != null)
            {
                aux2 = aux;
                aux = null;
                aux = aux2.Prox;
            }
        }
    }
}
