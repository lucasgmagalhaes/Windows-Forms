using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_De_Processos
{
    class Elemento
    {
        private Dados dado;
        private Elemento proximo;

        public Elemento(Dados dad)
        {
            this.dado = dad;
        }

        internal Elemento Proximo
        {
            get
            {
                return proximo;
            }

            set
            {
                proximo = value;
            }
        }

        public Dados GetDados()
        {
            return dado;
        }
    }
}
