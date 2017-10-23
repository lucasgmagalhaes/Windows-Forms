using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_Contas.Classes
{
    abstract class Conta : IDados
    {
        protected int id;
        protected int mes;
        protected double leitura_anterior;
        protected double leitura_atual;

        public Conta(int id, int mes, double leitura_anterior, double leitura_atual)
        {
            this.id = id;
            this.mes = mes;
            this.leitura_anterior = leitura_anterior;
            this.leitura_atual = leitura_atual;
        }

        public bool Equals(IDados d)
        {
            Conta aux = (Conta)d;
            if (aux.id == this.id) return true;
            else return false;
        }
        public abstract int GetTipo();
        public int CompareTo(IDados other)
        {
            Conta aux = (Conta)other;
            if (this.id > aux.id) return 1;
            else if (this.id == aux.id) return 0;
            else return -1;
        }
    }
}
