using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leitor_De_Processos
{
    class Circular : Lista
    {
        public Circular()
        {
            Dados aux = null;
            base.prim = new Elemento(aux);
            base.ult = base.prim;
            base.ult.Prox = base.prim;
        }
        public override void Add(Dados d)
        {
            Elemento aux = new Elemento(d);
            base.ult.Prox = aux;
            base.ult = aux;
            base.ult.Prox = base.prim;
            ElementAdded();
        }
    }
}
