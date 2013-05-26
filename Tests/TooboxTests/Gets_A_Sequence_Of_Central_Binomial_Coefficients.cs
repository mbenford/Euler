using FluentAssertions;
using Xunit;

namespace Euler.Tests.TooboxTests
{
    public class Gets_A_Sequence_Of_Central_Binomial_Coefficients
    {
        [Fact]
        public void Returns_1_When_Passing_0()
        {
            Toolbox.GetCentralBinomialCoefficient(0).Should().Be(1);
        }

        [Fact]
        public void Returns_2_When_Passing_1()
        {
            Toolbox.GetCentralBinomialCoefficient(1).Should().Be(2);
        }

        [Fact]
        public void Returns_6_When_Passing_2()
        {
            Toolbox.GetCentralBinomialCoefficient(2).Should().Be(6);
        }

        [Fact]
        public void Returns_20_When_Passing_3()
        {
            Toolbox.GetCentralBinomialCoefficient(3).Should().Be(20);
        }

        [Fact]
        public void Returns_70_When_Passing_4()
        {
            Toolbox.GetCentralBinomialCoefficient(4).Should().Be(70);
        }

        [Fact]
        public void Returns_252_When_Passing_5()
        {
            Toolbox.GetCentralBinomialCoefficient(5).Should().Be(252);
        }
    }
}
