using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
    public class Problem2 : Problem
    {
        public override long Solve()
        {
            return UtilityBelt.FibonacciSequence()
                .TakeWhile(x => x <= 4000000)
                .Where(x => x % 2 == 0)
                .Sum();                       
        }
    }
}
