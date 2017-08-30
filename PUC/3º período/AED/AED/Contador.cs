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

        public static double Stop()
        {
            count.Stop();
            double get = count.Elapsed.TotalMilliseconds;
            count.Reset();
            return get;
        }
    }
}
