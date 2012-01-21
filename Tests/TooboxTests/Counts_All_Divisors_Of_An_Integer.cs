using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ProjectEuler.Tools;

namespace ProjectEuler.Tests.TooboxTests
{    
    [TestFixture]
    public class Counts_All_Divisors_Of_An_Integer
    {
        [Test]
        public void Returns_1_When_Passing_1()
        {
            // Act
            int result = Toolbox.GetTheNumberOfDivisors(1);

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Returns_2_When_Passing_2()
        {
            // Act
            var result = Toolbox.GetTheNumberOfDivisors(2);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Returns_3_When_Passing_4()
        {
            // Act
            var result = Toolbox.GetTheNumberOfDivisors(4);

            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Returns_4_When_Passing_6()
        {
            // Act
            var result = Toolbox.GetTheNumberOfDivisors(6);

            // Assert
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Returns_8_When_Passing_24()
        {
            // Act
            var result = Toolbox.GetTheNumberOfDivisors(24);

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Returns_10_When_Passing_48()
        {
            // Act
            var result = Toolbox.GetTheNumberOfDivisors(48);

            // Assert
            Assert.AreEqual(10, result);
        }
    }
}
