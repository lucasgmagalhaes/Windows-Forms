using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AED
{
    static class Hanoi
    {
        private static string display = "";
        private static int icount = 0;

        public static int GetHesult()
        {
            int aux = icount;
            icount = 0;
            return aux;
        }
        private static void HanoiDisplay(Stack<int>[] all, TextBox HanoiDisplayTEXT)
        {
            HanoiDisplayTEXT.Clear();
            foreach (int n in all[0])
            {
                display += "\n" + n;
                foreach (int n2 in all[1])
                {
                    display += "   " + n2;
                    foreach (int n3 in all[2])
                    {
                        display += "   " + n3;
                    }
                }
            }
            HanoiDisplayTEXT.Text = display;
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
