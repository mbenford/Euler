using FluentAssertions;
using Xunit.Extensions;

namespace Euler.Tests.TooboxTests
{
    public class Factorize_Integer_Numbers
    {
        [Theory]
        [InlineData(2, new long[] { 2 })]
        [InlineData(3, new long[] { 3 })]
        [InlineData(4, new long[] { 2, 2 })]
        [InlineData(5, new long[] { 5 })]
        [InlineData(6, new long[] { 2, 3 })]
        [InlineData(7, new long[] { 7 })]
        [InlineData(8, new long[] { 2, 2, 2 })]
        [InlineData(9, new long[] { 3, 3 })]
        [InlineData(10, new long[] { 2, 5 })]
        [InlineData(36, new long[] { 2, 2, 3, 3 })]
        [InlineData(720, new long[] { 2, 2, 2, 2, 3, 3, 5 })]
        public void Returns_All_Factors_Of_A_Number(long number, long[] factors)
        {
            Toolbox.Factorize(number).ShouldBeEquivalentTo(factors);
        }
    }
}
