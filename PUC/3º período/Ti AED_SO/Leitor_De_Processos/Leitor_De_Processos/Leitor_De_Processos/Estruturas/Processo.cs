using System;
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
        private double t_total_execucao;
        private int ciclosInCategoria;
        /// <summary>
        /// Tempo total de execução do processo
        /// </summary>
        private double t_total_executado;
        public int Pid { get => pid; }
        public string Name { get => name; }
        public int Prio { get => prio; }
        public float Tempo_por_ciclo { get => tempo_por_ciclo; }
        public int Ciclo { get => ciclo; set => ciclo = value; }
        public int Ciclos_executados
        {
            get => ciclos_executados;
            set
            {
                if (value > this.ciclos_executados)
                {
                    this.ciclos_executados = value;
                    this.t_total_executado += this.tempo_por_ciclo;
                    this.t_total_executado = Math.Round(this.t_total_executado, 2);
                }
            }
        }
        public double T_total_executado { get => t_total_executado; }
        public double T_total_execucao { get => t_total_execucao; }
        public int CiclosInCategoria { get => ciclosInCategoria; set => ciclosInCategoria = value; }

        public Processo(int pid, string name, int prio, float tempoT, int cic)
        {
            this.pid = pid;
            this.name = name;
            this.prio = prio;
            this.tempo_por_ciclo = tempoT;
            this.ciclo = cic;
            this.ciclos_executados = 0;
            this.t_total_execucao = Math.Round(this.Ciclo * this.Tempo_por_ciclo, 2);
            this.ciclosInCategoria = 0;
        }
        public void IncreasePriority()
        {
            this.prio++;
        }
        public void DecreasePriority()
        {
            this.prio--;
        }
        /// <summary>
        /// Informa se os processo possuem o mesmo ID
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Equals(Dados obj)
        {
            Processo aux = (Processo)(obj);
            if (this.Pid == aux.Pid) return true;
            else return false;
        }
        /// <summary>
        /// Informa se os processo possuem o mesmo ID
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Equals(int PID)
        {
            if (this.Pid == PID) return true;
            else return false;
        }
        /// <summary>
        /// Informa se os processos em comparação possuem a mesma prioridade
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(Dados obj)
        {
            Processo aux = (Processo)(obj);
            if (aux.Prio > this.Prio) return 1;
            else if (aux.Prio == this.Prio) return 0;
            else return -1;
        }
        public void ResetProcesso()
        {
            this.ciclosInCategoria = this.ciclos_executados = 0;
        }
        /// <summary>
        /// Informa se os processos em comparação possuem a mesma quantidade de 
        /// tempo necessária para concluir a execução do processo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTTotalExecucao(Dados obj)
        {
            Processo aux = (Processo)(obj);
            if (aux.T_total_execucao > this.T_total_execucao) return 1;
            else if (aux.T_total_execucao == this.T_total_execucao) return 0;
            else return -1;
        }
    }
}
