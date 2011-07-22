using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Tools
{
    public static class Toolbox
    {
        public static IEnumerable<long> FibonacciSequence()
        {
            long x = 0;
            long y = 1;

            while (true)
            {
                long sum = x + y;
                x = y;
                y = sum;
                yield return y;
            }
        }
        
        public static IEnumerable<long> Factorize(long number)
        {
            var factors = new List<long>();

            if (Toolbox.IsPrime(number))
                factors.Add(number);
            else
            {
                long divisor = 2;
                long quotient = number;
                while (quotient > 1)
                {
                    if (quotient % divisor == 0)
                    {
                        factors.Add(divisor);
                        quotient /= divisor;
                    }
                    else
                        divisor++;
                }
            }

            return factors;
        }

        public static bool IsPrime(long number)
        {
            bool isPrime;

            if (number > 2 && number % 2 == 0)
                isPrime = false;
            else
            {
                isPrime = true;
                int max = (int)Math.Truncate(Math.Sqrt(number));
                for (int i = 2; i <= max; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            return isPrime;
        }
    }
}
