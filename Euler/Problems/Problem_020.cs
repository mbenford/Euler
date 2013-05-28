using System.Linq;
using System.Numerics;

namespace Euler.Problems
{
    public class Problem_020 : Problem
    {
        public override Solution Solve()
        {
            BigInteger veryLargeNumber = Toolbox.Factorial(100);
            int sum = Toolbox.GetDigitsOf(veryLargeNumber).Sum();

            return new Solution(sum);
        }
    }
}
