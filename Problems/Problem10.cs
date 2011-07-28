using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Tools;

namespace ProjectEuler.Problems
{
    public class Problem10 : Problem
    {
        public override Solution Solve()
        {
            long sum = Toolbox.GetPrimeNumbers(2000000).Sum();

            return new Solution(sum);
        }
    }
}
