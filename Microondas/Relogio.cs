using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
/// <summary>
/// Variável segundo foi declarada como float para não causar conflito de Construidor duplo. 
/// Tendo em vista que tanto para declarar o contrutor de apenas hora como o de data, ambos
/// utilizam de 3 parâmetros.
/// </summary>
namespace Aula3
{
    class Relogio
    {
        private static int[] dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int hora;
        public int Hora
        {
            get
            {
                return hora;
            }

            set
            {
                hora = value;
            }
        }

        private int minuto;
        public int Minuto
        {
            get
            {
                return minuto;
            }

            set
            {
                minuto = value;
            }
        }

        private float seg;
        public float Seg
        {
            get
            {
                return seg;
            }

            set
            {
                seg = value;
            }
        }

        private int dia;
        public int Dia
        {
            get
            {
                return dia;
            }

            set
            {
                dia = value;
            }
        }

        private int mes;
        public int Mes
        {
            get
            {
                return mes;
            }

            set
            {
                mes = value;
            }
        }

        private int ano;
        public int Ano
        {
            get
            {
                return ano;
            }

            set
            {
                ano = value;
            }
        }

        /// <summary>
        /// Valor mínimo do relógio 00:00:00 01/01/2000
        /// </summary>
        public Relogio()
        {
            this.hora = 0;
            this.minuto = 0;
            this.Seg = 0;

            this.dia = 1;
            this.mes = 1;
            this.ano = 2000;
        }

        /// <summary>
        /// Entrada apenas da hora hh:MM:ss
        /// </summary>
        /// <param name="h">Hora</param>
        /// <param name="m">Minutos</param>
        public Relogio(int h, int m, float s)
        {
            this.hora = h;
            this.minuto = m;
            this.Seg = s;

            this.dia = 1;
            this.mes = 1;
            this.ano = 2000;
        }

        public string HoraAjustada()
        {
            if (this.hora < 10) return "0" + this.hora;
            else return this.hora.ToString();
        }

        public string MinutoAjustado()
        {
            if (this.minuto < 10) return "0" + this.minuto;
            else return this.minuto.ToString();
        }

        public string SegundoAjustado()
        {
            if (this.seg < 10) return "0" + this.seg;
            else return this.seg.ToString();
        }


        /// <summary>
        /// Entrada de data/hora completa hh:MM dd/MM/yyyy
        /// </summary>
        /// <param name="h">hora</param>
        /// <param name="min">Minuto</param>
        /// <param name="d">Dia</param>
        /// <param name="m">Mês</param>
        /// <param name="a">Ano</param>
        public Relogio(int h, int min, float s, int d, int m, int a)
        {
            this.hora = h;
            this.minuto = min;
            this.Seg = s;

            this.dia = d;
            this.mes = m;
            this.ano = a;
        }

        private bool Validar(int h, int min, float s, int d, int m, int a)
        {
            if ((m < 1 || m > 12) || (a < 1) || (d < 1) || (h < 0 || h > 24) || (m < 0 || m > 60))
            {
                return false;
            }
            else
            {
                if (a % 4 == 0)
                {
                    if (m == 2)
                    {
                        if (d > 29) return false;
                    }
                    else
                    {
                        if (d > dias[m - 1]) return false;
                    }
                }
                else
                {
                    if (d > dias[m - 1]) return false;
                }
            }
            return true;
        }

        private void Init(int h, int min, float s, int d, int m, int a)
        {
            if (Validar(h, min, s, d, m, a) == true)
            {
                this.hora = h;
                this.minuto = min;
                this.seg = s;

                this.dia = d;
                this.Mes = m;
                this.Ano = a;
            }
            else
            {
                this.hora = -1;
                this.minuto = -1;
                this.minuto = -1;
                this.dia = -1;
                this.Mes = -1;
                this.Ano = -1;
            }
        }

        public void Reset()
        {
            this.hora = 0;
            this.minuto = 0;
            this.Seg = 0;

            this.dia = 1;
            this.mes = 1;
            this.ano = 2000;
        }

        public string HoraComSeg()
        {
            string retur;
            if (this.hora < 10) retur = "0" + this.hora;
            else retur = this.hora.ToString();
            if (this.minuto < 10) retur += ":0" + this.minuto;
            else retur = ":" + this.minuto;
            if (this.seg < 10) retur += ":0" + this.seg;
            else retur += ":" + this.seg;

            return retur;
        }

        public string HoraSemSeg()
        {
            string retur;
            if (this.hora < 10) retur = "0" + this.hora;
            else retur = this.hora.ToString();
            if (this.minuto < 10) retur += ":0" + this.minuto;
            else retur = ":" + this.minuto;

            return retur;
        }

        /// <summary>
        /// Na aplicação da definição da hora é verificado se os valores inseridos são validos.
        /// Verifique o valor de qualquer varíavel passada por parâmetro após o uso do do método para certificar-se
        /// de que o valor passado é válido.
        /// Caso seja, o valor da Hora, Minuto, ou Segundo, não será igual a -1.
        /// </summary>
        /// <param name="h">Hora</param>
        /// <param name="min">Minuto</param>
        /// <param name="s">Segundo</param>
        public void SetHora(int h, int min, float s)
        {
            Init(h, min, s, this.dia, this.mes, this.ano);
        }

        /// <summary>
        /// Na aplicação da definição da hora é verificado se os valores inseridos são validos.
        /// Verifique o valor de qualquer varíavel passada por parâmetro após o uso do do método para certificar-se
        /// de que o valor passado é válido.
        /// Caso seja, o valor do Dia, Mês, ou Ano, não será igual a -1.
        /// </summary>
        /// <param name="d">Dia</param>
        /// <param name="m">Mês</param>
        /// <param name="a">Ano</param>
        public void SetData(int d, int m, int a)
        {
            Init(this.hora, this.minuto, this.Seg, d, m, a);
        }

        public void SetRelogio(int h, int min, float s, int d, int m, int a)
        {
            Init(h, min, s, d, m, a);
        }

        public void TimerClock()
        {
            this.Seg++;
                if (this.Seg > 59)
                {
                    this.Seg = 0;
                    this.minuto++;

                    if (this.minuto > 59)
                    {
                        this.minuto = 0;
                        this.hora++;
                        if (this.hora > 23)
                        {
                            this.hora = 0;
                            this.dia++;
                            if (this.ano % 4 != 0) // ver se o não é bisexto
                            {
                                if (this.dia > dias[this.mes - 1])
                                {
                                    this.dia = 1;
                                    this.mes++;
                                    if (this.mes > 12)
                                    {
                                        this.mes = 1;
                                        this.ano++;
                                    }
                                    else this.mes++;
                                }
                                else this.dia++;
                            }
                            else
                            {
                                if (this.mes == 2)
                                {
                                    if (this.dia > 29)
                                    {
                                        this.dia = 1;
                                        this.mes++;
                                        if (this.mes > 12)
                                        {
                                            this.mes = 1;
                                            this.ano++;
                                        }
                                        else this.mes++;
                                    }
                                    else this.dia++;
                                }
                                else
                                {
                                    if (this.dia > dias[mes - 1])
                                    {
                                        this.dia = 1;
                                        this.mes++;

                                        if (this.mes > 12)
                                        {
                                            this.mes = 1;
                                            this.ano++;
                                        }
                                        else this.mes++;
                                    }
                                    else this.dia++;
                                }
                            }
                        }
                    }
                }            
            }
        }
    }

