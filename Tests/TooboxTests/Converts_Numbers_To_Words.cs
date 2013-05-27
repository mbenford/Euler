using FluentAssertions;
using Xunit.Extensions;

namespace Euler.Tests.TooboxTests
{
    public class Converts_Numbers_To_Words
    {
        [Theory]
        [InlineData(0, "zero")]
        [InlineData(1, "one")]
        [InlineData(2, "two")]
        [InlineData(3, "three")]
        [InlineData(4, "four")]
        [InlineData(5, "five")]
        [InlineData(6, "six")]
        [InlineData(7, "seven")]
        [InlineData(8, "eight")]
        [InlineData(9, "nine")]
        [InlineData(10, "ten")]
        [InlineData(11, "eleven")]
        [InlineData(12, "twelve")]
        [InlineData(13, "thirteen")]
        [InlineData(14, "fourteen")]
        [InlineData(15, "fifteen")]
        [InlineData(16, "sixteen")]
        [InlineData(17, "seventeen")]
        [InlineData(18, "eighteen")]
        [InlineData(19, "nineteen")]        
        public void Converts_A_Number_Between_1_and_19_To_Words(int number, string words)
        {
            Toolbox.ConvertNumberToWords(number).Should().Be(words);
        }

        [Theory]
        [InlineData(20, "twenty")]
        [InlineData(21, "twenty-one")]
        [InlineData(30, "thirty")]
        [InlineData(32, "thirty-two")]
        [InlineData(40, "forty")]
        [InlineData(43, "forty-three")]        
        [InlineData(50, "fifty")]
        [InlineData(54, "fifty-four")]
        [InlineData(60, "sixty")]
        [InlineData(65, "sixty-five")]
        [InlineData(70, "seventy")]
        [InlineData(76, "seventy-six")]
        [InlineData(80, "eighty")]
        [InlineData(87, "eighty-seven")]
        [InlineData(90, "ninety")]
        [InlineData(98, "ninety-eight")]
        [InlineData(99, "ninety-nine")]
        public void Converts_A_Number_Between_21_and_99_To_Words(int number, string words)
        {
            Toolbox.ConvertNumberToWords(number).Should().Be(words);
        }

        [Theory]
        [InlineData(100, "one hundred")]
        [InlineData(101, "one hundred and one")]
        [InlineData(200, "two hundred")]
        [InlineData(210, "two hundred and ten")]
        [InlineData(300, "three hundred")]
        [InlineData(321, "three hundred and twenty-one")]
        [InlineData(400, "four hundred")]
        [InlineData(432, "four hundred and thirty-two")]
        [InlineData(500, "five hundred")]
        [InlineData(543, "five hundred and forty-three")]
        [InlineData(600, "six hundred")]
        [InlineData(654, "six hundred and fifty-four")]
        [InlineData(700, "seven hundred")]
        [InlineData(765, "seven hundred and sixty-five")]
        [InlineData(800, "eight hundred")]
        [InlineData(876, "eight hundred and seventy-six")]
        [InlineData(900, "nine hundred")]
        [InlineData(987, "nine hundred and eighty-seven")]
        [InlineData(999, "nine hundred and ninety-nine")]
        public void Converts_A_Number_Between_100_and_999_To_Words(int number, string words)
        {
            Toolbox.ConvertNumberToWords(number).Should().Be(words);
        }

        [Theory]
        [InlineData(1000, "one thousand")]
        [InlineData(2001, "two thousand and one")]
        [InlineData(3105, "three thousand and one hundred and five")]
        [InlineData(4223, "four thousand and two hundred and twenty-three")]
        [InlineData(5362, "five thousand and three hundred and sixty-two")]
        [InlineData(6439, "six thousand and four hundred and thirty-nine")]
        [InlineData(13462, "thirteen thousand and four hundred and sixty-two")]
        [InlineData(54147, "fifty-four thousand and one hundred and forty-seven")]
        [InlineData(167123, "one hundred and sixty-seven thousand and one hundred and twenty-three")]
        [InlineData(999999, "nine hundred and ninety-nine thousand and nine hundred and ninety-nine")]
        public void Converts_A_Number_Between_1000_And_999999_To_Words(int number, string words)
        {
            Toolbox.ConvertNumberToWords(number).Should().Be(words);
        }
    }
}
