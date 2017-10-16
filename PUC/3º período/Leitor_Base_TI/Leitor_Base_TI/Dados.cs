using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leitor_Base_TI
{
    interface Dados : IEquatable<Dados>
    {
        bool Equals(Dados o);
        int CompareTo(Dados o);
    }
}
