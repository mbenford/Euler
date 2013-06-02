using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit.Extensions;

namespace Euler.Tests.TooboxTests
{
    public class Gets_The_Proper_Divisors_Of_An_Integer
    {
        [Theory]
        [InlineData(2, new long[] {1})]
        [InlineData(4, new long[] {1, 2})]
        [InlineData(5, new long[] {1})]
        [InlineData(6, new long[] {1, 2, 3})]
        [InlineData(8, new long[] {1, 2, 4})]
        [InlineData(10, new long[] {1, 2, 5})]
        [InlineData(12, new long[] {1, 2, 3, 4, 6})]
        [InlineData(100, new long[] {1, 2, 4, 5, 10, 20, 25, 50})]
        public void Returns_The_Proper_Divisors_Of_An_Integer(long number, IEnumerable<long> divisors)
        {
            Toolbox.GetProperDivisors(number).Should().BeEquivalentTo(divisors);
        }
    }
}
