using System.Linq;
using System.Numerics;

namespace Euler.Problems
{
    public class Problem_016 : Problem
    {
        public override Solution Solve()
        {
            BigInteger veryBigNumber = BigInteger.Pow(2, 1000);
            long sumOfDigits = Toolbox.GetDigitsOf(veryBigNumber).Sum();

            return new Solution(sumOfDigits);
        }
    }
}
