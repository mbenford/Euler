using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

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
                while (x > 0)
                {
                    result = result * 10 + x % 10;
                    x /= 10;
                }

                return result;
            };

            return number == Reverse(number);
        }

        public static long GetLeastCommonMultiple(IEnumerable<long> numbers)
        {
            return GetLeastCommonMultiple(numbers.ToArray());
        }
        
        public static long GetLeastCommonMultiple(params long[] numbers)
        {
            return numbers.Aggregate((a, b) => GetLCM(a, b));
        }

        private static long GetLCM(long a, long b)
        {
            return (a * b) / GetGCD(a, b);
        }

        public static long GetGreatestCommonDivisor(IEnumerable<long> numbers)
        {
            return GetGreatestCommonDivisor(numbers.ToArray());
        }

        public static long GetGreatestCommonDivisor(params long[] numbers)
        {
            return numbers.Aggregate((a, b) => GetGCD(a, b));
        }

        private static long GetGCD(long a, long b)
        {            
            long min = Math.Min(a, b);
            long max = Math.Max(a, b);
            if (min == 0) return max;

            return GetGCD(b, a % b);
        }
        
        public static IEnumerable<int> GetPrimes(int limit)
        {
            BitArray numbers = new BitArray(limit - 1, true);

            Func<int, int> GetNext = (n) =>
            {                
                for (int i = n + 1; i <= limit; i++)
                {
                    if (numbers[i - 2]) return i;
                }

                return 0;
            };

            int number = 2;
            while (number != 0)
            {
                for (int i = number * 2; i <= limit; i += number)
                {
                    numbers[i - 2] = false;
                }
                number = GetNext(number);
            }
                                                           
            var primes = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]) primes.Add(i + 2);
            }
                                 
            return primes;
        }
    }
}
