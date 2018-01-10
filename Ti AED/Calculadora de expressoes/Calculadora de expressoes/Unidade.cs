using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora_de_expressoes
{
    class Unidade : Dados
    {
        private string val;

        public Unidade(string val)
        {
            this.val = val;
        }

        public bool Equals(Dados d)
        {
            Unidade aux = (Unidade)d;
            if (this.val == aux.val) return true;
            else return false;
        }
    }
}
