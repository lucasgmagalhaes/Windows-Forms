using System;
using System.Collections.Generic;

namespace Leitor_Contas.Classes
{
    class Titular : IDados
    {
        private long cpf;
        private List<Conta> contas;

        public long CPF { get { return this.cpf; } }
        public List<Conta> Contas { get { return this.contas; } }
        public Titular(string cpf)
        {
            this.cpf = Convert.ToInt64(cpf.Replace(".", "").Replace("-", ""));
            this.contas = new List<Conta>();
        }
        public void AddConta(Conta cont)
        {
            contas.Add(cont);
        }
        public bool Equals(IDados d)
        {
            Titular aux = (Titular)d;
            if (aux.cpf == this.cpf) return true;
            else return false;
        }
        public int CompareTo(IDados other)
        {
            Titular aux = (Titular)other;
            if (this.cpf > aux.cpf) return 1;
            else if (this.cpf == aux.cpf) return 0;
            else return -1;
        }

        public int CompareTo(long d)
        {
            if (this.cpf > d) return 1;
            else if (this.cpf == d) return 0;
            else return -1;
        }
    }
}
