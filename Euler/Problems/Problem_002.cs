using System.Linq;
using System.Numerics;

namespace Euler.Problems
{
    public class Problem_002 : Problem
    {
        public override Solution Solve()
        {
            BigInteger value = Toolbox.FibonacciSequence()
                                      .TakeWhile(x => x <= 4000000)
                                      .Where(x => x % 2 == 0)
                                      .Aggregate(BigInteger.Add);

            return new Solution(value);
        }
    }
}
