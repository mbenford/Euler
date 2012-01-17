using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler.Tools;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Generate_Numeric_Grid_From_A_String
    {
        private int[,] grid;

        [TestFixtureSetUp]
        public void InitializeAllTests()
        {
            // Arrange
            string value =
                "01 02 03 " +
                "04 05 06 " +
                "07 08 09";

            // Act
            grid = Toolbox.GenerateGridFromString(value, 3, 3);
        }

        [Test]
        public void Element_0x0_Should_Be_1()
        {
            Assert.AreEqual(1, grid[0,0]);
        }

        [Test]
        public void Element_0x1_Should_Be_2()
        {
            Assert.AreEqual(2, grid[0, 1]);
        }

        [Test]
        public void Element_0x2_Should_Be_3()
        {
            Assert.AreEqual(3, grid[0, 2]);
        }

        [Test]
        public void Element_1x0_Should_Be_4()
        {
            Assert.AreEqual(4, grid[1, 0]);
        }

        [Test]
        public void Element_1x1_Should_Be_5()
        {
            Assert.AreEqual(5, grid[1, 1]);
        }

        [Test]
        public void Element_1x2_Should_Be_6()
        {
            Assert.AreEqual(6, grid[1, 2]);
        }

        [Test]
        public void Element_2x0_Should_Be_7()
        {
            Assert.AreEqual(7, grid[2, 0]);
        }

        [Test]
        public void Element_2x1_Should_Be_8()
        {
            Assert.AreEqual(8, grid[2, 1]);
        }

        [Test]
        public void Element_2x2_Should_Be_9()
        {
            Assert.AreEqual(9, grid[2, 2]);
        }
    }
}
