using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_De_Processos
{
    class ProcessLog : Dados
    {
        private int operation_from;
        private int operation_to;
        private Processo processo;

        public int Operation_from { get => operation_from; }
        public int Operation_to { get => operation_to; }
        internal Processo Processo { get => processo; }

        public ProcessLog(int from, int to, Processo prc)
        {
            this.operation_from = from;
            this.operation_to = to;
            this.processo = prc;
        }

        public bool Equals(Dados o)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Dados o)
        {
            throw new NotImplementedException();
        }
    }

}
