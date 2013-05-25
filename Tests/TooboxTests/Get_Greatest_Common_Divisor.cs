using Xunit;

namespace Euler.Tests.TooboxTests
{
    public class Get_Greatest_Common_Divisor
    {
        [Fact]
        public void Returns_1_When_Passing_2_3()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(2, 3);
            Assert.Equal(1, gcd);
        }
        
        [Fact]
        public void Returns_2_When_Passing_2_4()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(2, 4);
            Assert.Equal(2, gcd);
        }

        [Fact]
        public void Returns_3_When_Passing_3_6()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(3, 6);
            Assert.Equal(3, gcd);
        }

        [Fact]
        public void Returns_2_When_Passing_2_8()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(2, 8);
            Assert.Equal(2, gcd);
        }

        [Fact]
        public void Returns_4_When_Passing_4_8()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(4, 8);
            Assert.Equal(4, gcd);
        }

        [Fact]
        public void Returns_4_When_Passing_12_32()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(12, 32);
            Assert.Equal(4, gcd);
        }

        [Fact]
        public void Returns_4_When_Passing_12_24_32()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(12, 24, 32);
            Assert.Equal(4, gcd);
        }

        [Fact]
        public void Returns_3_When_Passing_9_12_39()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(9, 12, 39);
            Assert.Equal(3, gcd);
        }

        [Fact]
        public void Returns_1_When_Passing_9_12_35()
        {
            long gcd = Toolbox.GetGreatestCommonDivisor(9, 12, 35);
            Assert.Equal(1, gcd);
        }
    }
}
