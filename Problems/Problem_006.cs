using System;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem_006 : Problem
    {
        public override Solution Solve()
        {
            long sumOfTheSquares = Enumerable.Range(1, 100)
                .Select(a => a * a)
                .Sum();

            long squareOfTheSum = Enumerable.Range(1, 100).Sum();
            squareOfTheSum *= squareOfTheSum;

            return new Solution(squareOfTheSum - sumOfTheSquares);
        }
    }
}
