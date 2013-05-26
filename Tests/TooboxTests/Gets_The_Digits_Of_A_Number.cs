using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using Xunit.Extensions;

namespace Euler.Tests.TooboxTests
{
    public class Gets_The_Digits_Of_A_Number
    {
        [Theory]
        [InlineData(1, new[] { 1 })]        
        [InlineData(12, new[] { 1, 2 })]
        [InlineData(123, new[] { 1, 2, 3 })]
        [InlineData(1234, new[] { 1, 2, 3, 4 })]
        public void Gets_The_Digits_Of(long number, int[] digits)
        {
            Toolbox.GetDigitsOf(number).ShouldBeEquivalentTo(digits);
        }
    }
}
