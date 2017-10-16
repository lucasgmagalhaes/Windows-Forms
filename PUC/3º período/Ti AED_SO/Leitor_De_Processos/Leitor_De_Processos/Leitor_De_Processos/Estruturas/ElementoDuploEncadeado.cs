using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leitor_De_Processos
{
    class ElementoDuploEncadeado : Elemento
    {
        private Elemento anterior;
        //public Elemento Anterior { get => anterior; set => anterior = value; }

        public ElementoDuploEncadeado(Dados val) : base(val)
        {
            base.dado = val;
        }

        internal Elemento Anterior
        {
            get
            {
                return anterior;
            }

            set
            {
                anterior = value;
            }
        }
    }
}
