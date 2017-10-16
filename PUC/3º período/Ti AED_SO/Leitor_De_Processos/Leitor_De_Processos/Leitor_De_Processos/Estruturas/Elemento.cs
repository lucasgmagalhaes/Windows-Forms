namespace Leitor_De_Processos
{
    class Elemento
    {
        protected Dados dado;
        private Elemento prox;

        public Elemento(Dados dad)
        {
            this.dado = dad;
        }

        internal Elemento Prox
        {
            get
            {
                return prox;
            }

            set
            {
                prox = value;
            }
        }

        //internal Elemento Prox { get => prox; set => prox = value; }

        public Dados GetDados()
        {
           return dado;
        }
    }
}
