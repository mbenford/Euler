using FluentAssertions;
using Xunit;

namespace Euler.Tests.TooboxTests
{
    public class Generate_Numeric_Grid_From_A_String
    {
        private int[,] result;
        
        public Generate_Numeric_Grid_From_A_String()
        {
            // Arrange
            string value =
                "01 02 03 " +
                "04 05 06 " +
                "07 08 09";

            // Act
            result = Toolbox.GenerateGridFromString(value, 3, 3);            
        }

        [Fact]
        public void Element_0x0_Should_Be_1()
        {
            result[0,0].Should().Be(1);
        }

        [Fact]
        public void Element_0x1_Should_Be_2()
        {
            result[0, 1].Should().Be(2);
        }

        [Fact]
        public void Element_0x2_Should_Be_3()
        {
            result[0, 2].Should().Be(3);
        }

        [Fact]
        public void Element_1x0_Should_Be_4()
        {
            result[1, 0].Should().Be(4);
        }

        [Fact]
        public void Element_1x1_Should_Be_5()
        {
            result[1, 1].Should().Be(5);
        }

        [Fact]
        public void Element_1x2_Should_Be_6()
        {
            result[1, 2].Should().Be(6);
        }

        [Fact]
        public void Element_2x0_Should_Be_7()
        {
            result[2, 0].Should().Be(7);
        }

        [Fact]
        public void Element_2x1_Should_Be_8()
        {
            result[2, 1].Should().Be(8);
        }

        [Fact]
        public void Element_2x2_Should_Be_9()
        {
            result[2, 2].Should().Be(9);
        }
    }
}
