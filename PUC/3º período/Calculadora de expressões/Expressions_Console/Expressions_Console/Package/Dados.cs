using System;

namespace Expressions_Console.Package
{
    interface Dados : IEquatable<Dados>
    {
        new bool Equals(Dados o);
        int CompareTo(Dados o);
    }
}
