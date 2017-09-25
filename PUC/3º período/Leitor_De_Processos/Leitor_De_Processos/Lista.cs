using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_De_Processos
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
            Elemento aux = this.prim.Proximo;
            while((aux != null) && (!aux.GetDados().Equals(obj))){
                aux = aux.Proximo;
            }
            if (aux == null) return null;
            else return aux.GetDados();
        }
        public void Retirar(Dados obj)
        {
            Elemento aux = this.prim.Proximo;
            while ((aux != null) && (!aux.GetDados().Equals(obj)))
            {
                aux = aux.Proximo;
            }
            if(aux.Proximo != null)
            {
                Elemento auxret = aux.Proximo;
                aux.Proximo = auxret.Proximo;
                if (auxret == this.ult) this.ult = aux;
                else auxret.Proximo = null;
            }         
        }
    }
}
