using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace AED
{
    class Contador
    {
        private static Stopwatch count = new Stopwatch();

        public static void Start()
        {
            count.Start();
        }

        public static string Stop()
        {
            count.Stop();
            return count.Elapsed.TotalMilliseconds.ToString();
        }
    }
}
