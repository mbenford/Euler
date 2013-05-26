namespace Euler.Problems
{
    public class Problem_015 : Problem
    {
        public override Solution Solve()
        {
            return new Solution(Toolbox.GetCentralBinomialCoefficient(20));
        }
    }
}
