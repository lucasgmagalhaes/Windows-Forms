using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_Contas.Classes
{
    class Nodo                                          
    {
        private Nodo dir, esq;
        private IDados dad;
        public Nodo Dir { get { return this.dir; } set { this.dir = value; }}
        public Nodo Esq { get { return this.esq; } set { this.esq = value; }}
        public IDados Dado { get { return this.dad; }}
        public Nodo(IDados dad)
        {
            this.dad = dad;
            this.dir = this.esq = null;
        }
    }
}
