using System;

namespace Leitor_Base_TI
{
    class Lista
    {
        private Elemento prim, ult;

        public Lista()
        {
            this.prim = new Elemento(null);
            this.ult = this.prim;
        }

        internal Elemento Prim { get => prim; set => prim = value; }
        internal Elemento Ult { get => ult; set => ult = value; }

        public void Inserir(Dados novo)
        {
            Elemento aux = new Elemento(novo);
            this.ult.Proximo = aux;
            this.ult = aux;
        }
        public Dados Localizar(Object obj)
        {
            Elemento aux = this.prim;
            while (aux != null)
            {
                if (aux.GetDados().Equals(obj))
                {
                    return aux.GetDados();
                }
                aux = aux.Proximo;
            }
            return null;
        }
        /// <summary>
        /// Retira um item da lista
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public Dados Retirar(Dados obj)
        {
            Elemento aux = this.prim;
            Elemento auxel = aux.Proximo;
            while (aux != null)
            {
                if (aux.Proximo.GetDados().Equals(obj))
                {                  
                    aux.Proximo = aux.Proximo.Proximo;
                    auxel = null;
                    break;
                }
                aux = aux.Proximo;
            }
            if (auxel == null) return obj;
            else return null;
        }
        /// <summary>
        /// Informa o número de elementos na lista
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            int i = 0;
            Elemento aux = this.prim;
            while (aux != null) i++;
            return i;
        }
    }
}
