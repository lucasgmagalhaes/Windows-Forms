using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estruturas_de_dados.Estrutura_Base
{
    interface Dados : IEquatable<Dados> //sempre que houver implementação desta interface, a classe herdada não 
    {                                   // precisará implementar o método original Equals(Object d)
        bool Equals(Dados d);
    }
}
