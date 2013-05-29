using System.Linq;
using System.Numerics;
using FluentAssertions;
using Xunit;
using Xunit.Extensions;

namespace Euler.Tests.TooboxTests
{
    public class Gets_The_Fibonacci_Sequence
    {
        [Theory]
        [InlineData(1, new[] { 1 })]
        [InlineData(2, new[] { 1, 1 })]
        [InlineData(3, new[] { 1, 1, 2 })]
        [InlineData(4, new[] { 1, 1, 2, 3 })]
        [InlineData(5, new[] { 1, 1, 2, 3, 5 })]
        [InlineData(6, new[] { 1, 1, 2, 3, 5, 8 })]
        [InlineData(7, new[] { 1, 1, 2, 3, 5, 8, 13 })]
        [InlineData(8, new[] { 1, 1, 2, 3, 5, 8, 13, 21 })]
        [InlineData(9, new[] { 1, 1, 2, 3, 5, 8, 13, 21, 34 })]
        [InlineData(10, new[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 })]
        public void Generates_The_Fibonacci_Sequence(int count, int[] expected)
        {            
            Toolbox.FibonacciSequence().Take(count).ShouldBeEquivalentTo(expected.Select(x => new BigInteger(x)));
        }
    }
}
