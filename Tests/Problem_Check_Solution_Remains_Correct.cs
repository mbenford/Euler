using System;
using NUnit.Framework;
using ProjectEuler.Problems;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem_Check_Solution_Remains_Correct
    {
        [Test]
        public void Check_Problem_1_Is_Correct()
        {
            Problem problem = new Problem1();
            Solution solution = problem.Solve();

            Assert.AreEqual(233168, solution.Value);
        }

        [Test]
        public void Check_Problem_2_Is_Correct()
        {
            Problem problem = new Problem2();
            Solution solution = problem.Solve();

            Assert.AreEqual(4613732, solution.Value);
        }

        [Test]
        public void Check_Problem_3_Is_Correct()
        {
            Problem problem = new Problem3();
            Solution solution = problem.Solve();

            Assert.AreEqual(6857, solution.Value);
        }

    }
}
