using System;

namespace Calculadora_de_expressoes.Pack
{
    interface Dados : IEquatable<Dados>
    {
        new bool Equals(Dados o);
        int CompareTo(Dados o);
    }
}
