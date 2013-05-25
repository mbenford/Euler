using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
    public class Problem_014 : Problem
    {
        public override Solution Solve()
        {
            int longestchain = 0;
            int result = 0;
            
            for (int i = 1000000; i > 0; i--)
            {
                IEnumerable<long> sequence = Toolbox.GetHailstoneSequence(i);
                int sequenceCount = sequence.Count();
                if (sequenceCount > longestchain)
                {
                    result = i;
                    longestchain = sequenceCount;
                }
            }

            return new Solution(result);
        }
    }
}
