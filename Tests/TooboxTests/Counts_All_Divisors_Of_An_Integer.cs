using FluentAssertions;
using Xunit;
using Xunit.Extensions;

namespace Euler.Tests.TooboxTests
{    
    public class Counts_All_Divisors_Of_An_Integer
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(4, 3)]
        [InlineData(6, 4)]
        [InlineData(24, 8)]
        [InlineData(48, 10)]
        [InlineData(48, 10)]
        public void Returns_The_Number_Of_Divisors_Of_A_Number(long number, int divisors)
        {
            Toolbox.GetTheNumberOfDivisors(number).Should().Be(divisors);
        }
    }
}
