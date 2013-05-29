using System;
using System.Linq;
using System.Numerics;

namespace Euler.Problems
{
    public class Problem_025 : Problem
    {
        public override Solution Solve()
        {
            int index = Toolbox.FibonacciSequence()
                               .TakeWhile(x => (int)BigInteger.Log10(x) + 1 < 1000)
                               .Count();

            return new Solution(index + 1);
        }
    }
}

