using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_Hash.Classes
{
    class Valores
    {
        public int Valbase { get; }
        public int Multi { get; }
        public int Rest { get; }

        public Valores(int val, int m, int r)
        {
            this.Valbase = val;
            this.Multi = m;
            this.Rest = r;
        }
    }
}
