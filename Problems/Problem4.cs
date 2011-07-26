using System;
using System.Linq;
using ProjectEuler.Tools;

namespace ProjectEuler.Problems
{
    public class Problem4 : Problem
    {
        public override Solution Solve()
        {
            var numbers = from x in Enumerable.Range(100, 899)
                          from y in Enumerable.Range(100, 899)
                          select x * y;

            long value = numbers
                .Where(x => Toolbox.IsPalindromic(x))
                .Max();

            return new Solution(value);
        }
    }
}
