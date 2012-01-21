using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler.Tools;

namespace ProjectEuler.Tests.TooboxTests
{
    [TestFixture]
    public class Gets_The_Hailstone_Sequence_For_A_Given_Start_Number
    {
        [Test]
        public void Returns_4_2_1_When_Passing_4()
        {
            // Act
            var sequence = Toolbox.GetHailstoneSequence(4);

            // Assert
            CollectionAssert.AreEqual(new int[] { 4, 2, 1 }, sequence.ToList());
        }

        [Test]
        public void Returns_13_40_20_10_5_16_8_4_2_1_When_Passing_13()
        {
            // Act
            var sequence = Toolbox.GetHailstoneSequence(13);

            // Assert
            CollectionAssert.AreEqual(new int[] { 13, 40, 20, 10, 5, 16, 8, 4, 2, 1 }, sequence.ToList());
        }
           
        [Test]
        public void Returns_6_3_10_5_16_8_4_2_1_When_Passing_6()
        {
            // Act
            var sequence = Toolbox.GetHailstoneSequence(6);

            // Assert
            CollectionAssert.AreEqual(new int[] { 6, 3, 10, 5, 16, 8, 4, 2, 1 }, sequence.ToList());
        }

        [Test]
        public void Returns_11_34_17_52_26_13_40_20_10_5_16_8_4_2_1_When_Passing_6()
        {
            // Act
            var sequence = Toolbox.GetHailstoneSequence(11);

            // Assert
            CollectionAssert.AreEqual(new int[] { 11, 34, 17, 52, 26, 13, 40, 20, 10, 5, 16, 8, 4, 2, 1 }, sequence.ToList());
        }
    }
}
