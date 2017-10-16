using System;
using System.Diagnostics;
using System.Threading;

namespace Leitor_De_Processos
{
    class ProcessManager
    {
        /// <summary>
        /// Lista com processos de cada prioridade 1,2,3,4,5
        /// </summary>
        private Lista[] listas_categoria;
        /// <summary>
        /// lista de processos em execução
        /// </summary>
        private Lista in_execution;
        /// <summary>
        /// Lista de processos finalizados
        /// </summary>
        private Lista finished;
        /// <summary>
        /// Define o processo a a ser executado
        /// </summary>
        private Processo to_run;
        private Lista escalonamento_log;
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
        private Stopwatch _Count_Time;
        private int speed;
        internal Lista[] Listas_categoria { get => listas_categoria; set => listas_categoria = value; }
        internal Lista In_execution { get => in_execution; set => in_execution = value; }
        internal Processo To_run { get => to_run; set => to_run = value; }
        internal Lista Finished { get => finished; set => finished = value; }
        internal Lista Escalonamento_log { get => escalonamento_log; }
        public int TPE { get => _TPE; set => _TPE = value; }
        public int TPLIST { get => _TPLIST; set => _TPLIST = value; }
        public int TPF { get => _TPF; set => _TPF = value; }
        public Stopwatch Count_Time { get => _Count_Time; }
        public int Speed { get => speed; set => speed = value; }

        public ProcessManager()
        {
            this.listas_categoria = new Lista[5] { new Encadeada(), new Encadeada(), new Encadeada(), new Encadeada(), new Encadeada() };
            this.finished = new Encadeada();
            this.escalonamento_log = new Encadeada();
            this._TPE = 0;
            this._TPF = 0;
            this._TPLIST = 0;
            this._Count_Time = new Stopwatch();
            this.speed = 10;
        }
        public int TotalCount()
        {
            int count = 0;
            foreach (Lista lis in listas_categoria) count += lis.Count();
            return count;
        }
        /// <summary>
        /// retorna qual lista deve ser executada
        /// </summary>
        /// <returns></returns>
        public Lista WhatShouldIRun()
        {
            for (int i = 4; i >= 0; i--)
            {
                if (listas_categoria[i] != null)
                {
                    if (listas_categoria[i].Count() > 0) return listas_categoria[i];
                }
            }
            return null;
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
                    listas_categoria[0].Add(toadd);
                    break;
                case 2:
                    listas_categoria[1].Add(toadd);
                    break;
                case 3:
                    listas_categoria[2].Add(toadd);
                    break;
                case 4:
                    listas_categoria[3].Add(toadd);
                    break;
                case 5:
                    listas_categoria[4].Add(toadd);
                    break;
            }
        }
        /// <summary>
        /// Limpa todas as listas auxiliares
        /// </summary>
        public void ClearAuxs()
        {
            foreach (Lista lis in listas_categoria) if (lis != null) lis.Clear();
        }
        public void RunCicle()
        {
            Lista local = In_execution;
            if (local != null)
            {
                if (local.Count() > 1)
                {
                    Dados aux = local.RemoveFirst();
                    To_run = (Processo)aux;
                    To_run.Ciclos_executados++;
                    if (To_run.Ciclo == To_run.Ciclos_executados)
                    {
                        finished.Add(to_run);
                    }
                    else local.Add(aux);
                }
                else
                {
                    To_run = (Processo)(local.Primeiro());
                    To_run.Ciclos_executados++;
                    if (To_run.Ciclo == To_run.Ciclos_executados)
                    {
                        local.RemoveFirst();
                        finished.Add(to_run);
                    }
                }
            }
        }
        /// <summary>
        /// Gerencia a prioridade do processo
        /// </summary>
        public void Escalonador()
        {
            ProcessLog log;
            Lista running = listas_categoria[to_run.Prio - 1];
            Lista next;
            if (to_run.Prio - 1 > 0)
            {
                next = listas_categoria[to_run.Prio - 2];

                if (to_run.Ciclos_executados < to_run.Ciclo)
                {
                    if (to_run.T_total_executado >= 7.5 && to_run.Prio - 2 >= 0)
                    {
                        Processo send = (Processo)(running.Remover(to_run));
                        send.DecreasePriority();
                        next.Add(to_run);
                        log = new ProcessLog(to_run.Prio, to_run.Prio - 1, to_run);
                        escalonamento_log.Add(log);
                    }
                    if (running.CompareMinElement(next.MenorElemento()) == -1)
                    {
                        Processo send = (Processo)(next.Remover(next.MenorElemento()));
                        send.IncreasePriority();
                        running.Add(send);
                        log = new ProcessLog(to_run.Prio - 1, to_run.Prio, to_run);
                        escalonamento_log.Add(log);
                    }
                    else in_execution.Add(to_run);
                }
                else finished.Add(to_run);
            }
        }
    }
}
