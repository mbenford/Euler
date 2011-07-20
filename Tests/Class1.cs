using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace Tests
{
    [TestFixture]
    public class UtilityBelt_RangeTest
    {
        [Test]
        public void Returns_0_When_Taking_1()
        {
            var result = UtilityBelt.Range().Take(1);
            CollectionAssert.AreEqual(new int[1] { 0 }, result.ToList());
        }

        [Test]
        public void Returns_0_1_When_Taking_2()
        {
            var result = UtilityBelt.Range().Take(2);
            CollectionAssert.AreEqual(new int[2] { 0, 1 }, result.ToList());
        }

        [Test]
        public void Returns_0_1_2_When_Taking_3()
        {
            var result = UtilityBelt.Range().Take(3);
            CollectionAssert.AreEqual(new int[3] { 0, 1, 2 }, result.ToList());
        }

        [Test]
        public void Returns_0_1_2_3_When_Taking_4()
        {
            var result = UtilityBelt.Range().Take(4);
            CollectionAssert.AreEqual(new int[4] { 0, 1, 2, 3 }, result.ToList());
        }

        [Test]
        public void Returns_0_1_2_3_4_When_Taking_5()
        {
            var result = UtilityBelt.Range().Take(5);
            CollectionAssert.AreEqual(new int[5] { 0, 1, 2, 3, 4 }, result.ToList());
        }

        [Test]
        public void Returns_0_1_2_3_4_5_When_Taking_6()
        {
            var result = UtilityBelt.Range().Take(6);
            CollectionAssert.AreEqual(new int[6] { 0, 1, 2, 3, 4, 5 }, result.ToList());
        }

        [Test]
        public void Returns_0_1_2_3_4_5_6_When_Taking_7()
        {
            var result = UtilityBelt.Range().Take(7);
            CollectionAssert.AreEqual(new int[7] { 0, 1, 2, 3, 4, 5, 6 }, result.ToList());
        }

        [Test]
        public void Returns_0_1_2_3_4_5_6_7_When_Taking_8()
        {
            var result = UtilityBelt.Range().Take(8);
            CollectionAssert.AreEqual(new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 }, result.ToList());
        }

        [Test]
        public void Returns_0_1_2_3_4_5_6_7_8_When_Taking_9()
        {
            var result = UtilityBelt.Range().Take(9);
            CollectionAssert.AreEqual(new int[9] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, result.ToList());
        }

        [Test]
        public void Returns_0_1_2_3_4_5_6_7_8_9_When_Taking_10()
        {
            var result = UtilityBelt.Range().Take(10);
            CollectionAssert.AreEqual(new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, result.ToList());
        }
    }
}
