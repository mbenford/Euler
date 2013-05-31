using System.Linq;

namespace Euler.Problems
{
    public class Problem_035 : Problem
    {
        public override Solution Solve()
        {
            int count = Toolbox.GetPrimeNumbers(1000000)                               
                               .Count(IsCircularPrime);

            return new Solution(count);

        }

        private bool IsCircularPrime(long number)
        {
            long x = number;
            do
            {
                x = Toolbox.RotateInteger(x);
                if (!Toolbox.IsPrime(x)) return false;
            } while (x != number);

            return true;
        }
    }
}
