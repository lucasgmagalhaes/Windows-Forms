using System.Collections.Generic;
using System.Linq;

namespace BulletWorld.Class
{
    /// <summary>
    /// Solicita ao DataBase uma lista com informações sobre clientes
    /// </summary>
    public static class Ranking
    {
        /// <summary>
        /// retorna uma lista com o ranking solicidado. Sendo os valores: 
        /// 1 - Geral |
        /// 2 - BulletBill |
        /// 3 - CheepCheep |
        /// 4 - CrazyBlooper |
        /// 5 - LeftMario |
        /// </summary>
        /// <param name="x">número referente à qual ranking será carregado</param>
        /// <returns></returns>
        public static List<Player> Type(int v)
        {
            List<Player> filter;
            switch (v)
            {
                case 1:
                    filter = DataBase.LoadUsersData();
                    break;
                case 2:
                    filter = DataBase.LoadBulletBillData();
                    break;
                case 3:
                    filter = DataBase.LoadChepData();
                    break;
                case 4:
                    filter = DataBase.LoadCrazyData();
                    break;
                case 5:
                    filter = DataBase.LoadLeftData();
                    break;
                default:
                    filter = new List<Player>();
                    break;
            }
            for (int x = 0; x < filter.Count(); x++)
            {
                if (filter[x].Points == 0) filter.Remove(filter[x]);
            }
            return filter.OrderByDescending(i => i.Points).ToList();
        }
    }
}
