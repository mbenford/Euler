using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler.Tools;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Check_If_a_Number_Is_Prime
    {
        [Test]
        public void Returns_True_When_Passing_2()
        {
            Assert.IsTrue(Toolbox.IsPrime(2));
        }

        [Test]
        public void Returns_True_When_Passing_3()
        {
            Assert.IsTrue(Toolbox.IsPrime(3));
        }

        [Test]
        public void Returns_False_When_Passing_4()
        {
            Assert.IsFalse(Toolbox.IsPrime(4));
        }

        [Test]
        public void Returns_True_When_Passing_5()
        {
            Assert.IsTrue(Toolbox.IsPrime(5));
        }

        [Test]
        public void Returns_False_When_Passing_6()
        {
            Assert.IsFalse(Toolbox.IsPrime(6));
        }

        [Test]
        public void Returns_True_When_Passing_7()
        {
            Assert.IsTrue(Toolbox.IsPrime(7));
        }

        [Test]
        public void Returns_False_When_Passing_8()
        {
            Assert.IsFalse(Toolbox.IsPrime(8));
        }

        [Test]
        public void Returns_False_When_Passing_9()
        {
            Assert.IsFalse(Toolbox.IsPrime(9));
        }

        [Test]
        public void Returns_True_When_Passing_29()
        {
            Assert.IsTrue(Toolbox.IsPrime(29));
        }

        [Test]
        public void Returns_True_When_Passing_13()
        {
            Assert.IsTrue(Toolbox.IsPrime(13));
        }

        [Test]
        public void Returns_True_When_Passing_19()
        {
            Assert.IsTrue(Toolbox.IsPrime(19));
        }
    }
}
