using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler.Tools;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Get_Greatest_Common_Divisor
    {
        [Test]
        public void Returns_1_When_Passing_2_3()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(2, 3);
            Assert.AreEqual(1, gcd);
        }
        
        [Test]
        public void Returns_2_When_Passing_2_4()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(2, 4);
            Assert.AreEqual(2, gcd);
        }

        [Test]
        public void Returns_3_When_Passing_3_6()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(3, 6);
            Assert.AreEqual(3, gcd);
        }

        [Test]
        public void Returns_2_When_Passing_2_8()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(2, 8);
            Assert.AreEqual(2, gcd);
        }

        [Test]
        public void Returns_4_When_Passing_4_8()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(4, 8);
            Assert.AreEqual(4, gcd);
        }

        [Test]
        public void Returns_4_When_Passing_12_32()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(12, 32);
            Assert.AreEqual(4, gcd);
        }

        [Test]
        public void Returns_4_When_Passing_12_24_32()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(12, 24, 32);
            Assert.AreEqual(4, gcd);
        }

        [Test]
        public void Returns_3_When_Passing_9_12_39()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(9, 12, 39);
            Assert.AreEqual(3, gcd);
        }

        [Test]
        public void Returns_1_When_Passing_9_12_35()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(9, 12, 35);
            Assert.AreEqual(1, gcd);
        }
    }
}
