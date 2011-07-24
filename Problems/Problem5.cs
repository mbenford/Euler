using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Tools;

namespace ProjectEuler.Problems
{
    public class Problem5 : Problem
    {
        public override Solution Solve()
        {
            var divisors = Enumerable.Range(2, 19).Cast<long>();
            var lcm = Toolbox.GetLeastCommonMultiple(divisors);
            
            return new Solution(lcm);
        }
    }
}
