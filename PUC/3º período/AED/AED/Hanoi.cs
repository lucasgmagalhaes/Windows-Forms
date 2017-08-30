using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AED
{
     class Hanoi
    {
        public int discos;
        public int moves;
        public double tempo;

        private static string display = "";
        private static int icount = 0;
        public static List<int> VAL = new List<int>();
        public static int[] AUTOVALS = new int[] { 2,4,8,16,24,32 };
        public static int GetHesult()
        {
            int aux = icount;
            icount = 0;
            return aux;
        }
        public static void BuildHanoi(Stack<int>[] all, int orig, int aux, int dest, int disk)
        {
            if (disk == 1)
            {
                all[dest].Push(all[orig].Pop());
                icount++;
            }
            else
            {
                BuildHanoi(all, orig, dest, aux, disk - 1);
                all[dest].Push(all[orig].Pop());
                icount++;
                BuildHanoi(all, aux, orig, dest, disk - 1);
            }          
        }
    }
}
