using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estruturas_de_dados.Estrutura_Base
{
    class ElementoDuploEncadeado : Elemento
    {
        private Elemento anterior;
        public Elemento Anterior { get => anterior; set => anterior = value; }

        public ElementoDuploEncadeado(Dados val) : base(val)
        {
            base.dado = val;
        }
    }
}
