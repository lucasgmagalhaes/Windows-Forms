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
        protected Titular pessoa;

        public int Id { get { return this.id; } }
        public int Mes { get { return this.Mes; } }
        public double Leitura_anterior { get { return this.leitura_anterior; } }
        public double Leitura_atual { get { return this.leitura_atual; } }
        public Titular Pessoa { get { return this.pessoa; } }
        public Conta(int id, int mes, double leitura_anterior, double leitura_atual, Titular pessoa)
        {
            this.id = id;
            this.mes = mes;
            this.leitura_anterior = leitura_anterior;
            this.leitura_atual = leitura_atual;
            this.pessoa = pessoa;
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

        public int CompareTo(int d)
        {
            if (this.id > d) return 1;
            else if (this.id == d) return 0;
            else return -1;
        }

        public int CompareTo(long d)
        {
            throw new NotImplementedException();
        }
    }
}
