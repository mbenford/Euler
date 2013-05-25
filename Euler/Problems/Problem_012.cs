namespace Euler.Problems
{
    public class Problem_012 : Problem
    {
        public override Solution Solve()
        {
            long result = 0;            

            foreach (long number in Toolbox.TriangleNumbersSequence())
            {
                if (Toolbox.GetTheNumberOfDivisors(number) > 500)
                {
                    result = number;
                    break;
                }
            }

            return new Solution(result); ;
        }
    }
}
