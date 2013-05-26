using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Euler.Tests.TooboxTests
{
    public class Gets_The_Factorial_Of_A_Number
    {
        [Fact]
        public void Returns_1_When_Passing_1()
        {
            Toolbox.Factorial(1).Should().Be(1);
        }

        [Fact]
        public void Returns_2_When_Passing_2()
        {
            Toolbox.Factorial(2).Should().Be(2);
        }

        [Fact]
        public void Returns_6_When_Passing_3()
        {
            Toolbox.Factorial(3).Should().Be(6);
        }

        [Fact]
        public void Returns_24_When_Passing_4()
        {
            Toolbox.Factorial(4).Should().Be(24);
        }

        [Fact]
        public void Returns_120_When_Passing_5()
        {
            Toolbox.Factorial(5).Should().Be(120);
        }

        [Fact]
        public void Returns_720_When_Passing_6()
        {
            Toolbox.Factorial(6).Should().Be(720);
        }

        [Fact]
        public void Returns_5040_When_Passing_7()
        {
            Toolbox.Factorial(7).Should().Be(5040);
        }

        [Fact]
        public void Returns_40320_When_Passing_8()
        {
            Toolbox.Factorial(8).Should().Be(40320);
        }

        [Fact]
        public void Returns_362880_When_Passing_9()
        {
            Toolbox.Factorial(9).Should().Be(362880);
        }

        [Fact]
        public void Returns_3628800_When_Passing_10()
        {
            Toolbox.Factorial(10).Should().Be(3628800);
        }

    }
}
