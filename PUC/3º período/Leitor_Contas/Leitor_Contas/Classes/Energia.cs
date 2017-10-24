using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_Contas.Classes
{
    class Energia : Conta
    {
        public Energia(int id, int mes, double leitura_anterior, double leitura_atual, Titular pessoa) : base(id, mes, leitura_anterior, leitura_atual, pessoa)
        {
            this.id = id;
            this.mes = mes;
            this.leitura_anterior = leitura_anterior;
            this.leitura_atual = leitura_atual;
            this.pessoa = pessoa;
        }
        public override int GetTipo()
        {
            return 2;
        }
    }
}
