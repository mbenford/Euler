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
            if (Toolbox.IsPrime(number))
                yield return number;
            else
            {
                long divisor = 2;
                while (number > 1)
                {
                    if (number % divisor == 0)
                    {
                        yield return divisor;
                        number /= divisor;
                    }
                    else
                        divisor = ++divisor % 2 == 0 ? ++divisor : divisor;
                }
            }
        }

        public static bool IsPrime(long number)
        {
            bool isPrime = true;

            int max = (int)Math.Truncate(Math.Sqrt(number));
            for (int i = 2; i <= max; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
        
        public static bool IsPalindromic(long number)
        {
            Func<long, long> Reverse = (x) => 
            {
                long result = 0;
                while (number > 0)
                {
                    result = result * 10 + number % 10;
                    number /= 10;
                }

                return result;
            };

            return number == Reverse(number);
        }
    }
}
