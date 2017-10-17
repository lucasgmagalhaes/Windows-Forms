using System.Diagnostics;

namespace Leitor_De_Processos.Main
{
    class ProcessManager
    {
        private Lista processBackup;
        /// <summary>
        /// Lista com processos de cada prioridade 1,2,3,4,5
        /// </summary>
        private Lista[] listas_categoria;
        /// <summary>
        /// lista de processos em execução
        /// </summary>
        private int in_execution;
        /// <summary>
        /// Lista de processos finalizados
        /// </summary>
        private Lista finished;
        /// <summary>
        /// Define o processo a a ser executado
        /// </summary>
        private Processo to_run;
        private Fila escalonamento_log;
        /// <summary>
        /// Total de Processos em Espera 
        /// </summary>
        private int _TPE;
        /// <summary>
        /// Total de Processos na Lista
        /// </summary>
        private int _TPLIST;
        /// <summary>
        /// Total de Processos Finalizados
        /// </summary>
        private int _TPF;
        /// <summary>
        /// Armazena o tempo de processamento total
        /// </summary>
        private Stopwatch _Count_Time;
        /// <summary>
        /// Define a velocidde de processamento
        /// </summary>
        private int speed;
        /// <summary>
        /// Guarda o processo que recebeu acrescimo ou decréscimo de prioridade
        /// </summary>
        private Processo toUP;

        internal Lista[] Listas_categoria { get => listas_categoria; set => listas_categoria = value; }
        internal int In_execution { get => in_execution; set => in_execution = value; }
        internal Processo To_run { get => to_run; set => to_run = value; }
        internal Lista Finished { get => finished; set => finished = value; }
        internal Fila Escalonamento_log { get => escalonamento_log; }
        internal int TPE { get => _TPE; set => _TPE = value; }
        internal int TPLIST { get => _TPLIST; set => _TPLIST = value; }
        internal int TPF { get => _TPF; set => _TPF = value; }
        internal Stopwatch Count_Time { get => _Count_Time; }
        internal int Speed { get => speed; set => speed = value; }
        internal Processo ToUP { get => toUP; set => toUP = value; }

        public ProcessManager()
        {
            this.listas_categoria = new Lista[5] { new Encadeada(), new Encadeada(), new Encadeada(), new Encadeada(), new Encadeada() };
            this.Finished = new Encadeada();
            this.escalonamento_log = new Fila();
            this.TPE = 0;
            this._TPF = 0;
            this._TPLIST = 0;
            this._Count_Time = new Stopwatch();
            this.speed = 10;
            processBackup = new Encadeada();
        }
        public Lista GetBackup()
        {
            return processBackup;
        }
        public int TotalCount()
        {
            int count = 0;
            foreach (Lista lis in Listas_categoria) count += lis.Count();
            return count;
        }
        /// <summary>
        /// retorna qual lista deve ser executada
        /// </summary>
        /// <returns></returns>
        public int WhatShouldIRun()
        {
            for (int i = 4; i >= 0; i--)
            {
                if (Listas_categoria[i] != null)
                {
                    if (Listas_categoria[i].Count() > 0) return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Insere o processo na lista correta
        /// </summary>
        /// <param name="auxs"></param>
        /// <param name="toadd"></param>
        public void SetProcessToRightLine(Processo toadd)
        {
            switch (toadd.Prio)
            {
                case 1:
                    Listas_categoria[0].Add(toadd);
                    break;
                case 2:
                    Listas_categoria[1].Add(toadd);
                    break;
                case 3:
                    Listas_categoria[2].Add(toadd);
                    break;
                case 4:
                    Listas_categoria[3].Add(toadd);
                    break;
                case 5:
                    Listas_categoria[4].Add(toadd);
                    break;
            }
            Processo newother = toadd;
            processBackup.Add(newother);
        }
        /// <summary>
        /// Limpa todas as listas auxiliares
        /// </summary>
        public void ClearAuxs()
        {
            foreach (Lista lis in Listas_categoria) if (lis != null) lis.Clear();
        }
        public void RunCicle()
        {
            if (In_execution != -1)
            {
                To_run = (Processo)(Listas_categoria[In_execution].Primeiro());
                To_run.Ciclos_executados++;
                To_run.CiclosInCategoria++;
                if (To_run.Ciclos_executados < To_run.Ciclo)
                {
                    Listas_categoria[In_execution].RemoveFirst();
                    Escalonador();
                }
                else
                {
                    Finished.Add(To_run);
                    _TPF++;
                    Listas_categoria[In_execution].RemoveFirst();
                    In_execution = WhatShouldIRun();
                }
            }
        }
        /// <summary>
        /// Gerencia a prioridade do processo
        /// </summary>
        public void Escalonador()
        {
            ProcessLog log;
            Lista next;
            if (Escalonamento_log.Primeiro() == null) escalonamento_log = new Fila();
            if (To_run.Prio > 1)
            {
                next = Listas_categoria[To_run.Prio - 2];
                if (To_run.CiclosInCategoria > 7)
                {
                    To_run.CiclosInCategoria = 0;
                    next.Add(To_run);
                    log = new ProcessLog(To_run.Prio, To_run.Prio - 1, To_run);
                    To_run.DecreasePriority();
                    Escalonamento_log.Add(log);
                }
                else if (next.Count() > 0)
                {
                    Listas_categoria[In_execution].Add(To_run);
                    if (Listas_categoria[In_execution].Count() > 0)
                    {
                        if (Listas_categoria[In_execution].CompareMinElement(next.MenorElemento()) == -1)
                        {
                            Processo send = (Processo)(next.Remover(next.MenorElemento()));
                            Listas_categoria[In_execution].Add(send);
                            log = new ProcessLog(To_run.Prio - 1, To_run.Prio, send);
                            send.IncreasePriority();
                            Escalonamento_log.Add(log);
                            ToUP = send;
                        }
                    }
                    else
                    {
                        Processo aux = (Processo)(next.MenorElemento());
                        if (To_run.T_total_execucao > aux.T_total_execucao)
                        {
                            Processo send = (Processo)(next.Remover(next.MenorElemento()));
                            Listas_categoria[In_execution].Add(send);
                            log = new ProcessLog(To_run.Prio - 1, To_run.Prio, send);
                            send.IncreasePriority();
                            Escalonamento_log.Add(log);
                            ToUP = send;
                        }
                    }
                }
                else Listas_categoria[In_execution].Add(To_run);
            }
            else Listas_categoria[In_execution].Add(To_run);
        }
    }
}
