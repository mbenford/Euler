using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Tools;
using Xunit;

namespace ProjectEuler.Tests.ToolboxTests
{
    public class Generate_Numeric_Grid_From_A_String
    {
        private int[,] grid;
        
        public Generate_Numeric_Grid_From_A_String()
        {
            // Arrange
            string value =
                "01 02 03 " +
                "04 05 06 " +
                "07 08 09";

            // Act
            grid = Toolbox.GenerateGridFromString(value, 3, 3);
        }

        [Fact]
        public void Element_0x0_Should_Be_1()
        {
            Assert.Equal(1, grid[0,0]);
        }

        [Fact]
        public void Element_0x1_Should_Be_2()
        {
            Assert.Equal(2, grid[0, 1]);
        }

        [Fact]
        public void Element_0x2_Should_Be_3()
        {
            Assert.Equal(3, grid[0, 2]);
        }

        [Fact]
        public void Element_1x0_Should_Be_4()
        {
            Assert.Equal(4, grid[1, 0]);
        }

        [Fact]
        public void Element_1x1_Should_Be_5()
        {
            Assert.Equal(5, grid[1, 1]);
        }

        [Fact]
        public void Element_1x2_Should_Be_6()
        {
            Assert.Equal(6, grid[1, 2]);
        }

        [Fact]
        public void Element_2x0_Should_Be_7()
        {
            Assert.Equal(7, grid[2, 0]);
        }

        [Fact]
        public void Element_2x1_Should_Be_8()
        {
            Assert.Equal(8, grid[2, 1]);
        }

        [Fact]
        public void Element_2x2_Should_Be_9()
        {
            Assert.Equal(9, grid[2, 2]);
        }
    }
}
