using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_Hash.Classes
{
    class TabelaHash
    {
        private List<Passageiro> dados;
        public List<Passageiro> Dados { get { return this.dados; } }
        public TabelaHash(int tamanho)
        {
            this.dados = new List<Passageiro>(tamanho);
        }

        private int GetPosition(int val)
        {
            TesteFormula<Passageiro> pass = new TesteFormula<Passageiro>();
            return pass.YourMethod(GetPosition);
        }
        public void Inserir(Passageiro dado)
        {
        }

    }
}
