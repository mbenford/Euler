using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    public class Problem_019 : Problem
    {
        public override Solution Solve()
        {
            int sundayCount = 0;
            DateTime date = new DateTime(1901, 1, 1);
            while (date.Year < 2001)
            {
                if (date.DayOfWeek == DayOfWeek.Sunday)
                    sundayCount++;

                date = date.AddMonths(1);
            }

            return new Solution(sundayCount);
        }
    }
}
