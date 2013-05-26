using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Numerics;

namespace Euler
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

        public static IEnumerable<long> GetPrimeNumbers(int limit)
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

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]) yield return i + 2;
            }
        }

        public static int[,] GenerateGridFromString(string value, int rows, int cols)
        {
            string[] values = value.Split(' ');

            int[,] grid = new int[rows, cols];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = Convert.ToInt32(values[index++]);
                }
            }

            return grid;
        }

        public static IEnumerable<long> TriangleNumbersSequence()
        {
            long i = 1;
            long x = 0;
            while (true)
            {
                x += i++;
                yield return x;
            }
        }

        public static int GetTheNumberOfDivisors(long number)
        {
            if (number == 1) return 1;

            return Toolbox.Factorize(number)
                .GroupBy(x => x)
                .Select(factor => factor.Count() + 1)
                .Aggregate((factor1, factor2) => factor1 * factor2);
        }

        public static IEnumerable<long> GetHailstoneSequence(int start)
        {
            long number = start * 2;

            while (number != 1)
            {
                if (number % 2 == 0)
                    number /= 2;
                else
                    number = number * 3 + 1;

                yield return number;
            }
        }

        public static BigInteger Factorial(int number)
        {
            if (number > 1)
                return Factorial(1, number);
            
            return 1;
        }

        private static BigInteger Factorial(int number, int length)
        {
            if (length > 1)
            {
                int l = length / 2;
                return Factorial(number, l) * Factorial(number + l, length - l);
            }

            return number;
        }

        public static BigInteger GetCentralBinomialCoefficient(int index)
        {
            return Factorial(index * 2) / BigInteger.Pow(Factorial(index), 2); 
        }
    }
}
