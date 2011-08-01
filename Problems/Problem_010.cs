using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Tools;
using System.Numerics;

namespace ProjectEuler.Problems
{
    public class Problem_010 : Problem
    {
        public override Solution Solve()
        {
            long sum = Toolbox.GetPrimeNumbers(2000000).Sum();

            return new Solution(sum);
        }
    }
}
