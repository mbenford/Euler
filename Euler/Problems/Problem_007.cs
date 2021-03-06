﻿using System.Linq;

namespace Euler.Problems
{
    public class Problem_007 : Problem
    {
        public override Solution Solve()
        {
            var prime = Toolbox.GetPrimeNumbers(1000000).ElementAt(10000);

            return new Solution(prime);
        }
    }
}
