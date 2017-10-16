namespace Leitor_De_Processos
{
    /// <summary>
    /// Classe base para implementação das demais estruturas do tipo lista
    /// </summary>
    abstract class Lista
    {
        protected Elemento prim, ult;
        protected Dados menor;
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
        private void Rebuild()
        {
            if (this.prim.Prox == null)
            {
                Dados dad = null;
                this.prim = new Elemento(dad);
                this.ult = prim;
                this.menor = this.ult.GetDados();
            }
        }
        public virtual void Add(Dados el)
        {
            Rebuild();
            Elemento aux = new Elemento(el);
            this.ult.Prox = aux;
            this.ult = aux;
            ElementAdded();
            Processo dd = (Processo)menor;
            if (dd == null) this.menor = el;
            else if (dd.CompareTTotalExecucao(el) == -1) this.menor = el;
        }
        private void CalcMenor()
        {
            Elemento next = this.prim.Prox;
            while (next != null)
            {
                Processo dd = (Processo)menor;
                if (dd == null) this.menor = next.GetDados();
                else
                if (dd.CompareTTotalExecucao(next.GetDados()) == -1) this.menor = next.GetDados();
                next = next.Prox;
            }
        }
        public int CompareMinElement(Dados obj)
        {
            Processo aux = (Processo)(obj);
            Processo owner = (Processo)(menor);
            if (aux.T_total_execucao > owner.T_total_execucao) return 1;
            else if (aux.T_total_execucao == owner.T_total_execucao) return 0;
            else return -1;;
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
                    Rebuild();
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
                Rebuild();
                return aux2.GetDados();
            }
            else return null;
        }
        public Dados MenorElemento()
        {
            return menor;
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
