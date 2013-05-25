using System.Linq;
using Xunit;

namespace Euler.Tests.TooboxTests
{
    public class Factorize_Integer_Numbers
    {
        [Fact]
        public void Returns_2_When_Factorizing_2()
        {
            var factors = Toolbox.Factorize(2);
            Assert.Equal<long>(new long[] { 2 }, factors.ToList());
        }

        [Fact]
        public void Returns_3_When_Factorizing_3()
        {
            var factors = Toolbox.Factorize(3);
            Assert.Equal<long>(new long[] { 3 }, factors.ToList());
        }

        [Fact]
        public void Returns_2_2_When_Factorizing_4()
        {
            var factors = Toolbox.Factorize(4);
            Assert.Equal<long>(new long[] { 2, 2 }, factors.ToList());
        }

        [Fact]
        public void Returns_5_When_Factorizing_5()
        {
            var factors = Toolbox.Factorize(5);
            Assert.Equal<long>(new long[] { 5 }, factors.ToList());
        }

        [Fact]
        public void Returns_2_3_When_Factorizing_6()
        {
            var factors = Toolbox.Factorize(6);
            Assert.Equal<long>(new long[] { 2, 3 }, factors.ToList());
        }

        [Fact]
        public void Returns_7_When_Factorizing_7()
        {
            var factors = Toolbox.Factorize(7);
            Assert.Equal<long>(new long[] { 7 }, factors.ToList());
        }

        [Fact]
        public void Returns_2_2_2_When_Factorizing_8()
        {
            var factors = Toolbox.Factorize(8);
            Assert.Equal<long>(new long[] { 2, 2, 2 }, factors.ToList());
        }

        [Fact]
        public void Returns_3_3_When_Factorizing_9()
        {
            var factors = Toolbox.Factorize(9);
            Assert.Equal<long>(new long[] { 3, 3 }, factors.ToList());
        }

        [Fact]
        public void Returns_2_5_When_Factorizing_10()
        {
            var factors = Toolbox.Factorize(10);
            Assert.Equal<long>(new long[] { 2, 5 }, factors.ToList());
        }

        [Fact]
        public void Returns_2_2_3_3_When_Factorizing_36()
        {
            var factors = Toolbox.Factorize(36);
            Assert.Equal<long>(new long[] { 2, 2, 3, 3 }, factors.ToList());
        }

        [Fact]
        public void Returns_2_2_2_2_3_3_5_When_Factorizing_720()
        {
            var factors = Toolbox.Factorize(720);
            Assert.Equal<long>(new long[] { 2, 2, 2, 2, 3, 3, 5 }, factors.ToList());
        }
    }
}
