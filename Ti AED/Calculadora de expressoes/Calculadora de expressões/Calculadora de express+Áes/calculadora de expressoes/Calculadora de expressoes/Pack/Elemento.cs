namespace Calculadora_de_expressoes.Pack
{
    class Elemento
    {
        protected string val;
        protected Elemento prox;
        internal Elemento Prox { get { return prox; } set { prox = value; } }

        public Elemento(string d)
        {
            this.val = d;
        }

        public string GetDado()
        {
            return val;
        }
    }
}
