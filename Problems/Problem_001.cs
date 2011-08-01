using System;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem_001 : Problem
    {
        public override Solution Solve()
        {
            long value = Enumerable.Range(1, 999)                
                .Where(x => x % 3 == 0 || x % 5 == 0)
                .Sum();

            return new Solution(value);
        }
    }
}
