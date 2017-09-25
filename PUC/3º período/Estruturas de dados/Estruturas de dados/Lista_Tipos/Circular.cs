using Estruturas_de_dados.Estrutura_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estruturas_de_dados.Lista_Tipos
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
        }
    }
}
