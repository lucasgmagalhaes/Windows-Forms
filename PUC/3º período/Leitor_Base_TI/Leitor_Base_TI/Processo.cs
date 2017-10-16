using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leitor_Base_TI
{
    class Processo : Dados
    {
        private int pid;
        private string name;
        private int prio;
        private int tempo_execucao;

        public int Pid { get => pid; set => pid = value; }
        public string Name { get => name; set => name = value; }
        public int Prio { get => prio; set => prio = value; }
        public int Tempo_execucao { get => tempo_execucao; set => tempo_execucao = value; }

        public Processo(int pid, string name, int prio, int tempo)
        {
            this.pid = pid;
            this.name = name;
            this.prio = prio;
            this.tempo_execucao = tempo;
        }
        public bool Equals(Dados obj) {
            Processo aux = (Processo)(obj);
            if (this.pid == aux.pid) return true;
            else return false;
        }
        public int CompareTo(Dados obj)
        {
            Processo aux = (Processo)(obj);
            if (aux.prio > this.prio) return 1;
            else if (aux.prio == this.prio) return 0;
            else return -1;
        }
    }
}
