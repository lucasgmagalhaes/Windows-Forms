using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leitor_De_Processos
{
    class Duplamente_Encadeada : Lista
    {
        public Duplamente_Encadeada()
        {
            base.prim = new Elemento(null);
            base.prim = base.prim;
        }
        public override void Add(Dados d)
        {
            ElementoDuploEncadeado aux = new ElementoDuploEncadeado(d);
            base.ult.Prox = aux;
            aux.Anterior = base.ult;
            base.ult = aux;
        }
    }
}
