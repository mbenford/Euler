using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public static  class UtilityBelt
    {
        public static IEnumerable<long> FibonacciSequence()
        {
            long x = 0;
            long y = 1;

            while (true)
            {
                long sum = x + y;
                x = y;
                y = sum;
                yield return y;
            }
        }

        public static IEnumerable<int> Range()
        {
            int i = 0;
            while (true) yield return i++;
        }

    }
}
