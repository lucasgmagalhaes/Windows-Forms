using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletWorld.Class.Chars
{
    class Wario : Personagem
    {
        public Wario(frmBulletWorld bulletWorld) : base(bulletWorld)
        {
            setVelocidade(5);
        }
        /// <Método para movimentar o personagem>
        /// 1 = Cima
        /// 2 = Direita
        /// 3 = Baixo
        /// 4 = Esquerda
        /// </summary>
        /// <param name="dir">O evento de teclado irá ditar qual a direção</param>     
        public override void setDirecao(int dir)
        {
            this.dir = dir;
            switch (dir)
            {
                case 1:
                    setFigura(Properties.Resources.Wario1);
                    break;
                case 2:
                    setFigura(Properties.Resources.Wario2);
                    break;
                case 3:
                    setFigura(Properties.Resources.Wario3);
                    break;
                case 4:
                    setFigura(Properties.Resources.Wario4);
                    break;
            }
        }
    }
}
