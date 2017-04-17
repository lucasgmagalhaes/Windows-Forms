using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas
{
    class Microondas
    {
        private bool porta; // true representa aberta e false fechada
        private bool status; // true representa ativado e false desativado (iniciando aquecimento)
        private bool energia; // false = desligado <=> true = ligado
        private int minutos;
        private int segundos;
        private int potencia; // 1 a 10

        public string MinutoAjustado()
        {
            if (this.minutos < 10) return "0" + this.minutos;
            else return this.minutos.ToString();
        }
        public string SegundoAjustado()
        {
            if (this.segundos < 10) return "0" + this.segundos;
            else return this.segundos.ToString();
        }

        public Microondas()
        {
            this.porta = false;
            this.status = false;
            this.energia = false;
            this.minutos = 0;
            this.segundos = 0;
            this.potencia = 1;
        }

        public bool StatusPorta()
        {
            return this.porta;
        }

        public bool Status()
        {
            return this.status;
        }

        public string Potencia()
        {
            string rep;

            if (this.energia == false) return rep = "";
            return rep = "" + this.potencia;
        }

        public void SetTime(int val)
        {
            if (this.energia == true && this.status == false)
            {
                    this.minutos = ((this.minutos % 10) * 10) + this.segundos / 10;
                    this.segundos = ((this.segundos % 10) * 10) + val;
            }
        }
        public bool ON_OFF()
        {
            return this.energia;
        }
        public void Ligar()
        {
           this.energia = true;
        }

        public void Desligar()
        {
            this.energia = false;
            this.status = false;
            this.minutos = 0;
            this.segundos = 0;
        }

        /// <summary>
        /// Iniciar processo de aquecimento do alimento
        /// </summary>
        public void Ativar()
        {
            if (this.energia == true)
                if (this.porta == false) this.status = true;
        }

        /// <summary>
        /// Parar o processo de aquecimento do alimento
        /// </summary>
        public void Desativar()
        {
            this.status = false;
        }

        public void AumentarP()
        {
            if (this.energia == true)
                if (this.potencia != 10)
                    this.potencia++;        
        }

        public void DiminuirP()
        {
            if (this.energia == true)
                if (this.potencia != 1)
                    this.potencia--;
        }

        public void AbrirPorta()
        {
            if (this.status == false) this.porta = true;
        }

        public void FecharPorta()
        {
            this.porta = false;
        }

        public string Tempo()
        {
            string temp;
            if (this.energia == false) return temp = "";

            if (this.minutos < 10) temp = "0" + this.minutos;
            else temp = "" + this.minutos;

            if (this.segundos < 10) temp = temp + ":0" + this.segundos;
            else temp = temp + ":" + this.segundos;

            if(this.status == true)
            {
                if (temp == "00:00") this.status = false;
            }

            return temp;
        }

        public bool Start()
        {
            if (this.energia == true)

                if (this.porta == false)
                {
                    if (this.segundos == 0)
                    {
                        if (this.minutos > 0)
                        {
                            this.minutos--;
                            this.segundos = 59;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else this.segundos--;
                }
            return false;
        }
    }
}
