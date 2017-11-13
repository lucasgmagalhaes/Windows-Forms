using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_de_expressoes
{
    static class Key
    {
        public static string Get(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1: return "1";
                case Keys.NumPad2: return "2";
                case Keys.NumPad3: return "3";
                case Keys.NumPad4: return "4";
                case Keys.NumPad5: return "5";
                case Keys.NumPad6: return "6";
                case Keys.NumPad7: return "7";
                case Keys.NumPad8: return "8";
                case Keys.NumPad9: return "9";
                case Keys.NumPad0: return "0";
                case Keys.Decimal: return ",";
                case Keys.Add: return "+";
                case Keys.Subtract: return "-";
                case Keys.Divide: return "/";
                case Keys.Multiply: return "*";
                case Keys.D9:
                    if (e.Modifiers == Keys.Shift) return "(";
                    break;             
                case Keys.D0:
                    if (e.Modifiers == Keys.Shift) return ")";
                    break;
                case Keys.Oem7:
                    if (e.Modifiers == Keys.Shift) return "^";
                    break;
            }
            return null;
        }
    }
}
