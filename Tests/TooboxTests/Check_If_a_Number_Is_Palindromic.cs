using System;
using ProjectEuler.Tools;
using Xunit;

namespace ProjectEuler.Tests.TooboxTests
{
    public class Check_If_a_Number_Is_Palindromic
    {
        [Fact]
        public void Returns_True_When_Passing_1()
        {
            Assert.True(Toolbox.IsPalindromic(1));
        }

        [Fact]
        public void Returns_True_When_Passing_2()
        {
            Assert.True(Toolbox.IsPalindromic(2));
        }

        [Fact]
        public void Returns_True_When_Passing_3()
        {
            Assert.True(Toolbox.IsPalindromic(3));
        }

        [Fact]
        public void Returns_True_When_Passing_4()
        {
            Assert.True(Toolbox.IsPalindromic(4));
        }

        [Fact]
        public void Returns_True_When_Passing_5()
        {
            Assert.True(Toolbox.IsPalindromic(5));
        }

        [Fact]
        public void Returns_True_When_Passing_6()
        {
            Assert.True(Toolbox.IsPalindromic(6));
        }

        [Fact]
        public void Returns_True_When_Passing_7()
        {
            Assert.True(Toolbox.IsPalindromic(7));
        }

        [Fact]
        public void Returns_True_When_Passing_8()
        {
            Assert.True(Toolbox.IsPalindromic(8));
        }

        [Fact]
        public void Returns_True_When_Passing_9()
        {
            Assert.True(Toolbox.IsPalindromic(9));
        }

        [Fact]
        public void Returns_False_When_Passing_10()
        {
            Assert.False(Toolbox.IsPalindromic(10));
        }

        [Fact]
        public void Returns_True_When_Passing_11()
        {
            Assert.True(Toolbox.IsPalindromic(11));
        }

        [Fact]
        public void Returns_False_When_Passing_12()
        {
            Assert.False(Toolbox.IsPalindromic(12));
        }

        [Fact]
        public void Returns_False_When_Passing_13()
        {
            Assert.False(Toolbox.IsPalindromic(13));
        }

        [Fact]
        public void Returns_True_When_Passing_99()
        {
            Assert.True(Toolbox.IsPalindromic(99));
        }

        [Fact]
        public void Returns_False_When_Passing_100()
        {
            Assert.False(Toolbox.IsPalindromic(100));
        }

        [Fact]
        public void Returns_True_When_Passing_121()
        {
            Assert.True(Toolbox.IsPalindromic(121));
        }

        [Fact]
        public void Returns_False_When_Passing_120()
        {
            Assert.False(Toolbox.IsPalindromic(120));
        }

        [Fact]
        public void Returns_True_When_Passing_98789()
        {
            Assert.True(Toolbox.IsPalindromic(98789));
        }

        [Fact]
        public void Returns_True_When_Passing_123454321()
        {
            Assert.True(Toolbox.IsPalindromic(123454321));
        }

        [Fact]
        public void Returns_False_When_Passing_123454322()
        {
            Assert.False(Toolbox.IsPalindromic(123454322));
        }

    }
}
