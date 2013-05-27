using System.Linq;

namespace Euler.Problems
{
    public class Problem_017 : Problem
    {
        public override Solution Solve()
        {
            int count = Enumerable.Range(1, 1000)
                                  .Select(n => Toolbox.ConvertNumberToWords(n).Replace(" ", "").Replace("-", "").Length)
                                  .Sum();

            return new Solution(count);
        }
    }
}
