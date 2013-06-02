using System.Linq;

namespace Euler.Problems
{
    public class Problem_021 : Problem
    {
        public override Solution Solve()
        {
            var sumsOfDivisors = from i in Enumerable.Range(1, 10000)
                                 select new { Number = (long)i, SumOfDivisors = Toolbox.GetProperDivisors(i).Sum() };

            var amicableNumbers = from a in sumsOfDivisors
                                  join b in sumsOfDivisors on new { x = a.Number, y = a.SumOfDivisors } equals
                                                              new { x = b.SumOfDivisors, y = b.Number }
                                  where a.Number != b.Number
                                  select a.Number;

            return new Solution(amicableNumbers.Sum());
        }
    }
}
