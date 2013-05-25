using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Euler.Tests.TooboxTests
{
    public class Gets_A_Sequence_Of_Triangle_Numbers
    {
        [Fact]
        public void Returns_1_When_Taking_1()
        {
            IEnumerable<long> sequence = Toolbox.TriangleNumbersSequence().Take(1);
            Assert.Equal<long>(new long[] { 1 }, sequence.ToList());
        }
                
        [Fact]
        public void Returns_1_3_When_Taking_2()
        {
            IEnumerable<long> sequence = Toolbox.TriangleNumbersSequence().Take(2);
            Assert.Equal<long>(new long[] { 1, 3 }, sequence.ToList());
        }

        [Fact]
        public void Returns_1_3_6_When_Taking_3()
        {
            IEnumerable<long> sequence = Toolbox.TriangleNumbersSequence().Take(3);
            Assert.Equal<long>(new long[] { 1, 3, 6 }, sequence.ToList());
        }

        [Fact]
        public void Returns_1_3_6_10_When_Taking_4()
        {
            IEnumerable<long> sequence = Toolbox.TriangleNumbersSequence().Take(4);
            Assert.Equal<long>(new long[] { 1, 3, 6, 10 }, sequence.ToList());
        }

        [Fact]
        public void Returns_1_3_6_10_15_When_Taking_5()
        {
            IEnumerable<long> sequence = Toolbox.TriangleNumbersSequence().Take(5);
            Assert.Equal<long>(new long[] { 1, 3, 6, 10, 15 }, sequence.ToList());
        }

        [Fact]
        public void Returns_1_3_6_10_15_21_When_Taking_6()
        {
            IEnumerable<long> sequence = Toolbox.TriangleNumbersSequence().Take(6);
            Assert.Equal<long>(new long[] { 1, 3, 6, 10, 15, 21 }, sequence.ToList());
        }

        [Fact]
        public void Returns_1_3_6_10_15_21_28_When_Taking_7()
        {
            IEnumerable<long> sequence = Toolbox.TriangleNumbersSequence().Take(7);
            Assert.Equal<long>(new long[] { 1, 3, 6, 10, 15, 21, 28 }, sequence.ToList());
        }
    }
}
