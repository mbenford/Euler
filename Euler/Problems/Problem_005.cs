using System;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem_005 : Problem
    {
        public override Solution Solve()
        {
            var divisors = Enumerable.Range(2, 19).Select(x => (long)x);
            var lcm = Toolbox.GetLeastCommonMultiple(divisors);
            
            return new Solution(lcm);
        }
    }
}
