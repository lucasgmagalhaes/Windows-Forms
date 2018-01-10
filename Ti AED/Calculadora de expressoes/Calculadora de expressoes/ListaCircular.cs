using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora_de_expressoes
{
    class ListaCircular : Lista
    {
        public ListaCircular()
        {
            Dados aux = null;
            base.prim = new Elemento(aux);
            base.ult = base.prim;
            base.ult.Prox = base.prim;
        }

        public override void Add(string d)
        {
            Elemento aux = new Elemento(d);
            base.ult.Prox = aux;
            base.ult = aux;
            base.ult.Prox = base.prim;
        }
    }
}
