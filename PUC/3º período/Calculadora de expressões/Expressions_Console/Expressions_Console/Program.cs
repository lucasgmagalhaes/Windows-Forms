using System;
using System.Text;
using Expressions_Console.Package;
namespace Expressions_Console
{
    class Program
    { 
        static void Main(string[] args)
        {
            StringBuilder expression = new StringBuilder();
            Pilha operations = new Pilha();

            Console.WriteLine("CALCULADORA DE EXPRESSÕES - POLONESA REVERSA");
            Console.Write(">");
            string msg = Console.ReadLine();
            Console.WriteLine(Polonesa_Reversa.GetExpressionFormated(msg));
            Console.WriteLine(Polonesa_Reversa.ExpressionCalculate(msg));
            Console.ReadLine();
        }
    }
}
