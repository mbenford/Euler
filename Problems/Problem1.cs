using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
    public class Problem1 : Problem
    {
        public override long Solve()
        {
            return UtilityBelt.Range()
                .Take(1000)
                .Where(x => x % 3 == 0 || x % 5 == 0)
                .Sum();
        }
    }
}
