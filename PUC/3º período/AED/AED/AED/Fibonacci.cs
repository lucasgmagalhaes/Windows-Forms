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
        public static long FibonacciIterativo(long val)
        {
            Contador.Start();
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
            frmmain.SavarNoLog("FIBONACCI", "ITERATIVO", n3.ToString(), Contador.Stop());
            return n3;
        }

        private static long MaskFibonacciRecursivo(long val)
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

        public static long FibonacciRecursivo(long val)
        {
            Contador.Start();
            long result = MaskFibonacciRecursivo(val);
            frmmain.SavarNoLog("FIBONACCI", "RECURSIVO", result.ToString(), Contador.Stop());
            return result;
        }
    }
}
