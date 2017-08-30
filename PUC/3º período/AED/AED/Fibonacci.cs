using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
namespace AED
{
    class Fibonacci
    {
        public int val;
        public double iterativo_resul;
        public double recursivo_resul;

        public static List<int> VALS = new List<int>();
        public static int[] AUTOVALS = new int[] { 5,10,20,40,50,53};

        public static long FibonacciIterativo(long val)
        {
            long n1 = 0, n2 = 0, n3 = 0;
            for (int i = 0; i < val; i++)
            {
                if (val == 0 || val == 1)
                {
                    n1 = n2 = n3 = 1;
                }
                else
                {
                    n3 = n2 + n1;
                    n1 = n2;
                    n2 = n3;
                }
            }
            return n3;
        }

        public static long FibonacciRecursivo(long val)
        {
            if (val == 0 || val == 1)
            {
                return 1;
            }
            else
            {
                return FibonacciRecursivo(val - 1) + FibonacciRecursivo(val - 2);
            }
        }
    }
}
