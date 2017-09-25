using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estruturas_de_dados.Estrutura_Base
{   
/// <summary>
/// Está é basicamente sua classe principal. Essa classe que conterá as informações salvas nas estruturas de dados
/// </summary>
    class Generico : Dados
    {
        private string val;

        public Generico(string val)
        {
            this.val = val;
        }

        public bool Equals(Dados d)
        {
            Generico aux = (Generico)d;
            if (this.val == aux.val) return true;
            else return false;
        }
    }
}
