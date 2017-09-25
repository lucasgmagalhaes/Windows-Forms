using Estruturas_de_dados.Estrutura_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estruturas_de_dados.Lista_Tipos
{
    /// <summary>
    /// Basicamente, a lista "normal" é uma lista encadeada. Apenas deixei isso explícito
    /// </summary>
    class Encadeada : Lista
    {
        public Encadeada()
        {
            Dados aux = null;
            this.prim = new Elemento(aux);
            this.ult = prim;
        }
    }
}
