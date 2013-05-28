using FluentAssertions;
using Xunit;
using Xunit.Extensions;

namespace Euler.Tests.TooboxTests
{
    public class Check_If_a_Number_Is_Palindromic
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, true)]
        [InlineData(5, true)]
        [InlineData(10, false)]
        [InlineData(11, true)]
        [InlineData(12, false)]
        [InlineData(99, true)]
        [InlineData(121, true)]
        [InlineData(122, false)]
        [InlineData(123454321, true)]
        [InlineData(123454322, false)]
        public void Checks_If_A_Number_Is_Palindromic(int number, bool expected)
        {
            Toolbox.IsPalindromic(number).Should().Be(expected);
        }        
    }
}
