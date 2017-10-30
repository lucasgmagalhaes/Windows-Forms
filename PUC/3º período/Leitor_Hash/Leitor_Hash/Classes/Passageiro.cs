using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_Hash.Classes
{
    class Passageiro
    {
        private int codigo;
        private string nome;
        private List<string> reservas;

        public int Codigo { get { return this.codigo; } set { this.codigo = value; } }
        public string Nome { get { return this.nome; } set { this.nome = value; } }
        public List<string> Reservas { get { return this.reservas; } set { this.reservas = value; } }

        public Passageiro(string codigo, string nome)
        {
            this.codigo = FormatCode(codigo);
            this.nome = nome;
        }

        private int FormatCode(string code)
        {
            return Convert.ToInt32(code.Replace(".", "").Replace("-", ""));
        }
    }
}
