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

        private int GetPosition(string val)
        {
            string[] spt = val.Split('.');
            int val1 = Convert.ToInt32(spt[0]), val2 = Convert.ToInt32(spt[3]);
            return 1;
        }
        public void Inserir(Passageiro dado)
        {
        }

    }
}
