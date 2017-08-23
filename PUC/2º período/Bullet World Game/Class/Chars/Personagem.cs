using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComeBullet;

namespace BulletWorld.Class.Chars
{
    abstract class Personagem : GameObject
    {
        protected int vel;
        protected int dir;
        frmBulletWorld bulletWorld;

        public Personagem(frmBulletWorld bulletWorld)
        {
            this.bulletWorld = bulletWorld;
            setDirecao(2);
            setPos(200, 200);
            setBox(this.bulletWorld);
        }

        public virtual void setVelocidade(int vel)//Máx = 50 / Min = 5 | Vel increases 5
        {
            if (vel < 1)
            { this.vel = 5; }
            else if (vel > 10)
            { this.vel = 50; }
            else
            { this.vel = vel * 5; }
        }

        /// <summary>
        ///  Método que verifica se o personagem está dentro dos limites do Form.
        ///  true = Dentro do form || False = bateu no limite (Morreu)
        /// </summary>
        /// <returns></returns>
        public bool verificaLimites()//Limites form
        {
            if (getX() >= this.bulletWorld.Width || getY() >= this.bulletWorld.Height || getX() == 0 || getY() == 0)
            { return false; }
            else
            { return true; }
        }

        public void teleporte() // Não há necessidade de ser virtual
        {
            setPos(this.bulletWorld.aleat.Next() % this.bulletWorld.Width, this.bulletWorld.aleat.Next() % this.bulletWorld.Height);
        }
        /// <Metodo para mover os personagens>
        /// Cada personagem se moverá de um uma forma
        /// Wario e Wizard se moverão de formas diferentes
        /// </summary>
        public virtual void mover()
        {
            switch (dir)
            {
                case 1://Cima
                    setPos(getX(), (getY() - vel));
                    break;

                case 2://Direita
                    setPos((getX() + vel), this.getY());
                    break;

                case 3: //Baixo
                    setPos(this.getX(), (getY() + vel));
                    break;

                case 4://Esquerda
                    setPos((this.getX() - vel), this.getY());
                    break;
            }
        }
        public abstract void setDirecao(int dir);
    }
}
