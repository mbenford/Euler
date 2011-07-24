using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Tools;

namespace ProjectEuler.Problems
{
    public class Problem3 : Problem
    {
        public override Solution Solve()
        {                                  
            long value = Toolbox.Factorize(600851475143)                
                .Max();

            return new Solution(value);
        }
    }
}
