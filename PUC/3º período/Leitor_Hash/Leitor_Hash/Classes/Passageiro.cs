using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_Hash.Classes
{
    class Passageiro
    {
        private string codigo;
        private string nome;
        private List<string> reservas;

        public string Codigo { get { return this.codigo; }  }
        public string Nome { get { return this.nome; }  }
        public List<string> Reservas { get { return this.reservas; }}

        public Passageiro(string codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.reservas = new List<string>();
        }

        //private int FormatCode(string code)
        //{
        //    return Convert.ToInt32(code.Replace(".", "").Replace("-", ""));
        //}
    }
}
