using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora_de_expressoes
{
    interface Dados : IEquatable<Dados>
    {
        bool Equals(Dados d);
    }
}
