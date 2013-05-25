using Xunit;

namespace ProjectEuler.Tests.TooboxTests
{    
    public class Counts_All_Divisors_Of_An_Integer
    {
        [Fact]
        public void Returns_1_When_Passing_1()
        {
            // Act
            int result = Toolbox.GetTheNumberOfDivisors(1);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Returns_2_When_Passing_2()
        {
            // Act
            var result = Toolbox.GetTheNumberOfDivisors(2);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Returns_3_When_Passing_4()
        {
            // Act
            var result = Toolbox.GetTheNumberOfDivisors(4);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Returns_4_When_Passing_6()
        {
            // Act
            var result = Toolbox.GetTheNumberOfDivisors(6);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void Returns_8_When_Passing_24()
        {
            // Act
            var result = Toolbox.GetTheNumberOfDivisors(24);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Returns_10_When_Passing_48()
        {
            // Act
            var result = Toolbox.GetTheNumberOfDivisors(48);

            // Assert
            Assert.Equal(10, result);
        }
    }
}
