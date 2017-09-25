using Estruturas_de_dados.Estrutura_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estruturas_de_dados.Lista_Tipos
{
    class Duplamente_Encadeada : Lista
    {
        public Duplamente_Encadeada()
        {
            base.prim = new Elemento(null);
            base.ult = base.prim;
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
