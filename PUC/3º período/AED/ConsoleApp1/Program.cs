using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int cont;
        private static void moveUmDisco(char inicio, char fim)
        {
            cont = cont + 1;
            Console.WriteLine(Convert.ToString("\n" + inicio + " " + fim) + " Numero Movimentos = " + cont);
        }
        private static void moverTorre(double n, char inicio, char fim, char temp)
        {
            if (n == 1)
            {
                moveUmDisco(inicio, fim);
            }
            else
            {
                moverTorre(n - 1, inicio, temp, fim);
                moveUmDisco(inicio, fim);
                moverTorre(n - 1, temp, fim, inicio);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com numero de discos");
            double numero = Convert.ToDouble(Console.ReadLine());
            cont = 0;

            moverTorre(numero, 'A', 'B', 'C');
            Console.WriteLine("\nEste é o Numero de Discos: " + numero);
            Console.WriteLine("\nNumero de Movimentos: " + cont);
            Console.ReadLine();
        }
    }
}
