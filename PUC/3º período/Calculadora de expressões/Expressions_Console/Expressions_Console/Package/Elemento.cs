namespace Expressions_Console.Package
{
    class Elemento
    {
        protected string val;
        protected Elemento prox;

        internal Elemento Prox { get => prox; set => prox = value; }

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
