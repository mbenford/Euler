using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Tools;

namespace ProjectEuler.Problems
{
    public class Problem7 : Problem
    {
        public override Solution Solve()
        {
            int prime = Toolbox.GetPrimes(1000000).ElementAt(10000);

            return new Solution(prime);
        }
    }
}
