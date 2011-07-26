using System;
using System.Linq;
using ProjectEuler.Tools;

namespace ProjectEuler.Problems
{
    public class Problem2 : Problem
    {
        public override Solution Solve()
        {
            long value = Toolbox.FibonacciSequence()
                .TakeWhile(x => x <= 4000000)
                .Where(x => x % 2 == 0)
                .Sum();

            return new Solution(value);
        }
    }
}
