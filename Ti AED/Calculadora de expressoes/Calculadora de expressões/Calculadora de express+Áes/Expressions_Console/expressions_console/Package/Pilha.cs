namespace Expressions_Console.Package
{
    class Pilha
    {
        public Elemento topo, fundo;

        public Pilha()
        {
            this.topo = new Elemento(null);
            this.fundo = this.topo;
        }

        public void push(string novo)
        {
            Elemento elemento = new Elemento(novo);
            elemento.Prox = this.topo.Prox;
            this.topo.Prox = elemento;
            if (this.topo == this.fundo) this.fundo = elemento;
        }

        public string pop()
        {
            Elemento aux = this.topo.Prox;

            if (aux != null)
            {
                this.topo.Prox = aux.Prox;
                aux.Prox = null;
                if (aux == this.fundo)
                    this.fundo = this.topo;
                return aux.GetDado();
            }
            else return null;
        }

        public string peek()
        {
            return this.topo.Prox.GetDado();
        }

        public bool pilhaVazia()
        {
            return (this.topo == this.fundo);
        }

    }
}
