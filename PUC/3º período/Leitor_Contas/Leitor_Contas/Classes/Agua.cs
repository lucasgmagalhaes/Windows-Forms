using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_Contas.Classes
{
    class Agua : Conta
    {
        public Agua(int id, int mes, double leitura_anterior, double leitura_atual) : base(id, mes, leitura_anterior, leitura_atual)
        {
            this.id = id;
            this.mes = mes;
            this.leitura_anterior = leitura_anterior;
            this.leitura_atual = leitura_atual;
        }
        public override int GetTipo()
        {
            return 1;
        }
    }
}
