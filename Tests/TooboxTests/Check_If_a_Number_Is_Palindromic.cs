using System;
using NUnit.Framework;
using ProjectEuler.Tools;

namespace ProjectEuler.Tests.TooboxTests
{
    [TestFixture]
    public class Check_If_a_Number_Is_Palindromic
    {
        [Test]
        public void Returns_True_When_Passing_1()
        {
            Assert.IsTrue(Toolbox.IsPalindromic(1));
        }

        [Test]
        public void Returns_True_When_Passing_2()
        {
            Assert.IsTrue(Toolbox.IsPalindromic(2));
        }

        [Test]
        public void Returns_True_When_Passing_3()
        {
            Assert.IsTrue(Toolbox.IsPalindromic(3));
        }

        [Test]
        public void Returns_True_When_Passing_4()
        {
            Assert.IsTrue(Toolbox.IsPalindromic(4));
        }

        [Test]
        public void Returns_True_When_Passing_5()
        {
            Assert.IsTrue(Toolbox.IsPalindromic(5));
        }

        [Test]
        public void Returns_True_When_Passing_6()
        {
            Assert.IsTrue(Toolbox.IsPalindromic(6));
        }

        [Test]
        public void Returns_True_When_Passing_7()
        {
            Assert.IsTrue(Toolbox.IsPalindromic(7));
        }

        [Test]
        public void Returns_True_When_Passing_8()
        {
            Assert.IsTrue(Toolbox.IsPalindromic(8));
        }

        [Test]
        public void Returns_True_When_Passing_9()
        {
            Assert.IsTrue(Toolbox.IsPalindromic(9));
        }

        [Test]
        public void Returns_False_When_Passing_10()
        {
            Assert.IsFalse(Toolbox.IsPalindromic(10));
        }

        [Test]
        public void Returns_True_When_Passing_11()
        {
            Assert.IsTrue(Toolbox.IsPalindromic(11));
        }

        [Test]
        public void Returns_False_When_Passing_12()
        {
            Assert.IsFalse(Toolbox.IsPalindromic(12));
        }

        [Test]
        public void Returns_False_When_Passing_13()
        {
            Assert.IsFalse(Toolbox.IsPalindromic(13));
        }

        [Test]
        public void Returns_True_When_Passing_99()
        {
            Assert.IsTrue(Toolbox.IsPalindromic(99));
        }

        [Test]
        public void Returns_False_When_Passing_100()
        {
            Assert.IsFalse(Toolbox.IsPalindromic(100));
        }

        [Test]
        public void Returns_True_When_Passing_121()
        {
            Assert.IsTrue(Toolbox.IsPalindromic(121));
        }

        [Test]
        public void Returns_False_When_Passing_120()
        {
            Assert.IsFalse(Toolbox.IsPalindromic(120));
        }

        [Test]
        public void Returns_True_When_Passing_98789()
        {
            Assert.IsTrue(Toolbox.IsPalindromic(98789));
        }

        [Test]
        public void Returns_True_When_Passing_123454321()
        {
            Assert.IsTrue(Toolbox.IsPalindromic(123454321));
        }

        [Test]
        public void Returns_False_When_Passing_123454322()
        {
            Assert.IsFalse(Toolbox.IsPalindromic(123454322));
        }

    }
}
