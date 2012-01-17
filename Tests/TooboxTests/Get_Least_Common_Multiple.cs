using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler.Tools;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Get_Least_Common_Multiple
    {
        [Test]
        public void Returns_2_When_Passing_2_2()
        {
            long lcm = Toolbox.GetLeastCommonMultiple(2, 2);
            Assert.AreEqual(2, lcm);
        }
        
        [Test]
        public void Returns_6_When_Passing_2_3()
        {
            long lcm = Toolbox.GetLeastCommonMultiple(2, 3);
            Assert.AreEqual(6, lcm);
        }

        [Test]
        public void Returns_10_When_Passing_2_5()
        {
            long lcm = Toolbox.GetLeastCommonMultiple(2, 5);
            Assert.AreEqual(10, lcm);
        }

        [Test]
        public void Returns_14_When_Passing_2_7()
        {
            long lcm = Toolbox.GetLeastCommonMultiple(2, 7);
            Assert.AreEqual(14, lcm);
        }

        [Test]
        public void Returns_15_When_Passing_3_5()
        {
            long lcm = Toolbox.GetLeastCommonMultiple(3, 5);
            Assert.AreEqual(15, lcm);
        }

        [Test]
        public void Returns_30_When_Passing_2_3_5()
        {
            long lcm = Toolbox.GetLeastCommonMultiple(2, 3, 5);
            Assert.AreEqual(30, lcm);
        }

        [Test]
        public void Returns_210_When_Passing_2_3_5_7()
        {
            long lcm = Toolbox.GetLeastCommonMultiple(2, 3, 5, 7);
            Assert.AreEqual(210, lcm);
        }

        [Test]
        public void Returns_4_When_Passing_2_4()
        {
            long lcm = Toolbox.GetLeastCommonMultiple(2, 4);
            Assert.AreEqual(4, lcm);
        }

    }
}
