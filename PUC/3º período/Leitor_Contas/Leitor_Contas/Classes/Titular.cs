using System;
using System.Collections.Generic;

namespace Leitor_Contas.Classes
{
    class Titular : IDados
    {
        private string cpf;
        private List<Conta> contas;

        public string CPF { get { return this.cpf; } }
        public List<Conta> Contas { get { return this.contas; } }
        public Titular(string cpf)
        {
            this.cpf = cpf;
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
            long cpfthis = Convert.ToInt64(this.cpf.Replace(".", "").Replace("-", ""));
            long cpfother = Convert.ToInt64(aux.cpf.Replace(".", "").Replace("-", ""));
            if (cpfthis > cpfother) return 1;
            else if (cpfthis == cpfother) return 0;
            else return -1;
        }

        public int CompareTo(long d)
        {
            long cpfthis = Convert.ToInt64(this.cpf.Replace(".", "").Replace("-", ""));
            if (cpfthis > d) return 1;
            else if (cpfthis == d) return 0;
            else return -1;
        }

        public int CompareTo(string d)
        {
            try
            {
                long cpfthis = Convert.ToInt64(this.cpf.Replace(".", "").Replace("-", ""));
                long cpfother = Convert.ToInt64(d.Replace(".", "").Replace("-", ""));
                if (cpfthis > cpfother) return 1;
                else if (cpfthis == cpfother) return 0;
                else return -1;
            }
            catch { return -10; }
        }
    }
}
