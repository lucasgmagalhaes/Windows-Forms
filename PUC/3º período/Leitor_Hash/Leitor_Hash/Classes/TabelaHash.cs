using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_Hash.Classes
{
    class TabelaHash
    {
        private Passageiro[] dados;
        public Passageiro[] Dados { get { return this.dados; } }
        public TabelaHash(int tamanho)
        {
            this.dados = new Passageiro[tamanho];
        }

        public int GetPosition(string val, Passageiro pass)
        {
            string[] spt = val.Split('.');
            int get;

            get = (Convert.ToInt32(spt[0] + spt[1]) % 701) +1;
            while(dados[get] != null) get++;
            dados[get] = pass;
            return get;
        }
        public void Inserir(Passageiro dado)
        {
            string[] spt = dado.Codigo.Split('.');
            int get;

            get = (Convert.ToInt32(spt[0] + spt[1]) % 701) + 1;
            while (dados[get] != null)
            {
                get++;
                if (get > dados.Count() - 1) get = 0;
            }
            dados[get] = dado;
        }
        public Passageiro Buscar(string dado)
        {
            string[] spt = dado.Split('.');
            int get;

            get = (Convert.ToInt32(spt[0] + spt[1]) % 701) + 1;
            while (dados[get].Codigo != dado)
            {
                get++;
                if (get > dados.Count() - 1) return null;
            }
            return dados[get];
        }
    }
}
