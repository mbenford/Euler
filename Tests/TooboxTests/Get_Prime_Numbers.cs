using System.Collections.Generic;
using Xunit;

namespace ProjectEuler.Tests.ToolboxTests
{
    public class Get_Prime_Numbers
    {
        [Fact]
        public void Returns_2_When_Passing_2()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(2);
            Assert.Equal<long>(new long[] { 2 }, primes);
        }

        [Fact]
        public void Returns_2_3_When_Passing_3()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(3);
            Assert.Equal<long>(new long[] { 2, 3 }, primes);
        }

        [Fact]
        public void Returns_2_3_When_Passing_4()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(4);
            Assert.Equal<long>(new long[] { 2, 3 }, primes);
        }

        [Fact]
        public void Returns_2_3_5_When_Passing_5()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(5);
            Assert.Equal<long>(new long[] { 2, 3, 5 }, primes);
        }

        [Fact]
        public void Returns_2_3_5_When_Passing_6()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(6);
            Assert.Equal<long>(new long[] { 2, 3, 5 }, primes);
        }

        [Fact]
        public void Returns_2_3_5_7_When_Passing_7()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(7);
            Assert.Equal<long>(new long[] { 2, 3, 5, 7 }, primes);
        }

        [Fact]
        public void Returns_2_3_5_7_When_Passing_8()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(8);
            Assert.Equal<long>(new long[] { 2, 3, 5, 7 }, primes);
        }

        [Fact]
        public void Returns_2_3_5_7_When_Passing_9()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(9);
            Assert.Equal<long>(new long[] { 2, 3, 5, 7 }, primes);
        }

        [Fact]
        public void Returns_2_3_5_7_When_Passing_10()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(10);
            Assert.Equal<long>(new long[] { 2, 3, 5, 7 }, primes);
        }

        [Fact]
        public void Returns_2_3_5_7_11_When_Passing_11()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(11);
            Assert.Equal<long>(new long[] { 2, 3, 5, 7, 11 }, primes);
        }

        [Fact]
        public void Returns_2_3_5_7_11_When_Passing_12()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(12);
            Assert.Equal<long>(new long[] { 2, 3, 5, 7, 11 }, primes);
        }

        [Fact]
        public void Returns_2_3_5_7_11_13_When_Passing_13()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(13);
            Assert.Equal<long>(new long[] { 2, 3, 5, 7, 11, 13 }, primes);
        }

        [Fact]
        public void Returns_2_3_5_7_11_13_When_Passing_14()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(14);
            Assert.Equal<long>(new long[] { 2, 3, 5, 7, 11, 13 }, primes);
        }

        [Fact]
        public void Returns_2_3_5_7_11_13_When_Passing_15()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(15);
            Assert.Equal<long>(new long[] { 2, 3, 5, 7, 11, 13 }, primes);
        }

        [Fact]
        public void Returns_2_3_5_7_11_13_When_Passing_16()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(16);
            Assert.Equal<long>(new long[] { 2, 3, 5, 7, 11, 13 }, primes);
        }

        [Fact]
        public void Returns_2_3_5_7_11_13_17_When_Passing_17()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(17);
            Assert.Equal<long>(new long[] { 2, 3, 5, 7, 11, 13, 17 }, primes);
        }

        [Fact]
        public void Returns_2_3_5_7_11_13_17_When_Passing_18()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(18);
            Assert.Equal<long>(new long[] { 2, 3, 5, 7, 11, 13, 17 }, primes);
        }

        [Fact]
        public void Returns_2_3_5_7_11_13_17_19_When_Passing_19()
        {
            IEnumerable<long> primes = Toolbox.GetPrimeNumbers(19);
            Assert.Equal<long>(new long[] { 2, 3, 5, 7, 11, 13, 17, 19 }, primes);
        }

    }
}
