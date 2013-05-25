using System.Linq;

namespace Euler.Problems
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
