using FluentAssertions;
using Xunit.Extensions;

namespace Euler.Tests.TooboxTests
{
    public class Check_If_a_Number_Is_Prime
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(7, true)]
        [InlineData(8, false)]
        [InlineData(9, false)]
        [InlineData(29, true)]
        [InlineData(13, true)]
        [InlineData(19, true)]
        [InlineData(19, true)]
        [InlineData(21, false)]
        public void Checks_If_A_Number_Is_Prime(long number, bool expected)
        {
            Toolbox.IsPrime(number).Should().Be(expected);
        }
    }
}
