using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_Contas.Classes
{
    class Nodo : IDados                                           
    {
        private Nodo dir, esq;
        private IDados dad;
        public Nodo Dir { get { return this.dir; } set { this.dir = value; }}
        public Nodo Esq { get { return this.dir; } set { this.dir = value; }}
        public IDados Dado { get { return this.dad; }}
        public Nodo(IDados dad)
        {
            this.dad = dad;
            this.dir = this.esq = null;
        }

        public bool Equals(IDados d)
        {
            if (d == this.dad) return true;
            else return false;
        }

        public int CompareTo(IDados other)
        {
            return dad.CompareTo(other);
        }
    }
}
