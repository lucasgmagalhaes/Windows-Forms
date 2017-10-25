using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_Contas.Classes
{
    interface IDados : IComparable<IDados>
    {
        bool Equals(IDados d);
        int CompareTo(long d);
        int CompareTo(string d);
    }
}
