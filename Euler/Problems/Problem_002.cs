using System.Linq;

namespace Euler.Problems
{
    public class Problem_002 : Problem
    {
        public override Solution Solve()
        {
            long value = Toolbox.FibonacciSequence()
                .TakeWhile(x => x <= 4000000)
                .Where(x => x % 2 == 0)
                .Sum();

            return new Solution(value);
        }
    }
}
