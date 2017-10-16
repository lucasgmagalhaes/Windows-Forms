using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_De_Processos
{
    /// <summary>
    /// Para cada lista, é possível remover ou inseri-la, sendo os código 0 ou 1 respectivamente para 
    /// essas operações
    /// </summary>
    class Escalonamento_Change
    {
        private int operationFrom;
        private int operationTo;
        private Dados dado;

        public int OperationFrom { get => operationFrom;  }
        public int OperationTo { get => operationTo;  }

        public Escalonamento_Change(int from, int to, Dados dd)
        {
            this.operationFrom = from;
            this.operationTo = to;
            this.dado = dd;
        }

        public Processo GetProcess()
        {
            return (Processo)(dado);
        }
    }
}
