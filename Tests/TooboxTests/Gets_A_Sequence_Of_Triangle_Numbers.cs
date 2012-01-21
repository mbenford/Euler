using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler.Tools;

namespace ProjectEuler.Tests.TooboxTests
{
    [TestFixture]
    public class Gets_A_Sequence_Of_Triangle_Numbers
    {
        [Test]
        public void Returns_1_When_Taking_1()
        {
            IEnumerable<long> sequence = Toolbox.GetTriangleNumbersSequence().Take(1);
            CollectionAssert.AreEqual(new long[] { 1 }, sequence.ToList());
        }
                
        [Test]
        public void Returns_1_3_When_Taking_2()
        {
            IEnumerable<long> sequence = Toolbox.GetTriangleNumbersSequence().Take(2);
            CollectionAssert.AreEqual(new long[] { 1, 3 }, sequence.ToList());
        }

        [Test]
        public void Returns_1_3_6_When_Taking_3()
        {
            IEnumerable<long> sequence = Toolbox.GetTriangleNumbersSequence().Take(3);
            CollectionAssert.AreEqual(new long[] { 1, 3, 6 }, sequence.ToList());
        }

        [Test]
        public void Returns_1_3_6_10_When_Taking_4()
        {
            IEnumerable<long> sequence = Toolbox.GetTriangleNumbersSequence().Take(4);
            CollectionAssert.AreEqual(new long[] { 1, 3, 6, 10 }, sequence.ToList());
        }

        [Test]
        public void Returns_1_3_6_10_15_When_Taking_5()
        {
            IEnumerable<long> sequence = Toolbox.GetTriangleNumbersSequence().Take(5);
            CollectionAssert.AreEqual(new long[] { 1, 3, 6, 10, 15 }, sequence.ToList());
        }

        [Test]
        public void Returns_1_3_6_10_15_21_When_Taking_6()
        {
            IEnumerable<long> sequence = Toolbox.GetTriangleNumbersSequence().Take(6);
            CollectionAssert.AreEqual(new long[] { 1, 3, 6, 10, 15, 21 }, sequence.ToList());
        }

        [Test]
        public void Returns_1_3_6_10_15_21_28_When_Taking_7()
        {
            IEnumerable<long> sequence = Toolbox.GetTriangleNumbersSequence().Take(7);
            CollectionAssert.AreEqual(new long[] { 1, 3, 6, 10, 15, 21, 28 }, sequence.ToList());
        }
    }
}
