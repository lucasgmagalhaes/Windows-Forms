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
            for (int i = 0; i <= tamanho; i++) this.dados.Add(null);
        }

        public int GetPosition(string val)
        {
            string[] spt = val.Split('.');
            int endcount = 0;
            if (Convert.ToInt32(spt[0]) < 160)
            {
                endcount = Convert.ToInt32(spt[1].Substring(0, 1)) + Convert.ToInt32(spt[1].Substring(1, 1)) + Convert.ToInt32(spt[1].Substring(2, 1)) % 10;
                return Convert.ToInt32(spt[0] + endcount);
            }
            else if (Convert.ToInt32(spt[0]) < 210)
            {
                endcount = Convert.ToInt32(spt[1].Substring(0, 1)) + Convert.ToInt32(spt[1].Substring(1, 1)) + Convert.ToInt32(spt[1].Substring(2, 1));
                return Convert.ToInt32(spt[0]) + endcount;
            }
            else
            {
                endcount = Convert.ToInt32(spt[1].Substring(0, 1)) + Convert.ToInt32(spt[1].Substring(1, 1)) + Convert.ToInt32(spt[1].Substring(2, 1));
                int aux = Convert.ToInt32(spt[0] + endcount) % 2100;
                //if(dados[aux] != null)
                //{
                //   aux = aux - Convert.ToInt32(spt[1].Substring(0, 1)) + Convert.ToInt32(spt[1].Substring(1, 1));
                //    if (aux < 0) aux *= -1;
                //    return aux;
                //}
                return aux;
            }
        }
        public void Inserir(Passageiro dado)
        {
        }

    }
}
