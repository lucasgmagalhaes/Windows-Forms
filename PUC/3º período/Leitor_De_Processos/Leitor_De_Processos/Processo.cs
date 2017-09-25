using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitor_De_Processos
{
    class Processo : Dados
    {
        private int pid;
        private string name;
        private int prio;
        private float tempo_por_ciclo;
        private int ciclo;
        private int ciclos_executados;

        public int Pid { get => pid; set => pid = value; }
        public string Name { get => name; set => name = value; }
        public int Prio { get => prio; set => prio = value; }
        public float Tempo_por_ciclo { get => tempo_por_ciclo; set => tempo_por_ciclo = value; }
        public int Ciclo { get => ciclo; set => ciclo = value; }
        public int Ciclos_executados { get => ciclos_executados; set => ciclos_executados = value; }

        public Processo(int pid, string name, int prio, float tempoT, int cic)
        {
            this.pid = pid;
            this.name = name;
            this.prio = prio;
            this.tempo_por_ciclo = tempoT;
            this.ciclo = cic;
            this.ciclos_executados = 0;
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
