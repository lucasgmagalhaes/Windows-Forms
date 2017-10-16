using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leitor_De_Processos
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
            this.menor = this.ult;
        }
    }
}
