using FluentAssertions;
using Xunit.Extensions;

namespace Euler.Tests.TooboxTests
{
    public class Rotates_An_Integer
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(12, 21)]
        [InlineData(123, 312)]
        [InlineData(1234, 4123)]
        [InlineData(12345, 51234)]
        public void Returns_An_Integer_Rotated(int number, int expected)
        {
            Toolbox.RotateInteger(number).Should().Be(expected);
        }
    }
}
