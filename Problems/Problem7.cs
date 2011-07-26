using System;
using System.Linq;
using ProjectEuler.Tools;

namespace ProjectEuler.Problems
{
    public class Problem7 : Problem
    {
        public override Solution Solve()
        {
            int prime = Toolbox.GetPrimeNumbers(1000000).ElementAt(10000);

            return new Solution(prime);
        }
    }
}
