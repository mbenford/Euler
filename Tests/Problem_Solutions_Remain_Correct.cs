using System;
using NUnit.Framework;
using ProjectEuler.Problems;
using System.Numerics;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem_Solutions_Remain_Correct
    {
        [Test]
        public void Solution_For_Problem_1_Remains_Correct()
        {
            Check(1, 233168);
        }

        [Test]
        public void Solution_For_Problem_2_Remains_Correct()
        {
            Check(2, 4613732);
        }

        [Test]
        public void Solution_For_Problem_3_Remains_Correct()
        {
            Check(3, 6857);
        }

        [Test]
        public void Solution_For_Problem_4_Remains_Correct()
        {
            Check(4, 906609);
        }

        [Test]
        public void Solution_For_Problem_5_Remains_Correct()
        {
            Check(5, 232792560);
        }

        [Test]
        public void Solution_For_Problem_6_Remains_Correct()
        {
            Check(6, 25164150);
        }

        [Test]
        public void Solution_For_Problem_7_Remains_Correct()
        {
            Check(7, 104743);
        }

        [Test]
        public void Solution_For_Problem_8_Remains_Correct()
        {
            Check(8, 40824);
        }

        [Test]
        public void Solution_For_Problem_9_Remains_Correct()
        {
            Check(9, 31875000);
        }

        [Test]
        public void Solution_For_Problem_10_Remains_Correct()
        {
            Check(10, 142913828922);
        }

        [Test]
        public void Solution_For_Problem_11_Remains_Correct()
        {
            Check(11, 70600674);
        }

        [Test]
        public void Solution_For_Problem_12_Remains_Correct()
        {
            Check(12, 76576500);
        }

        [Test]
        public void Solution_For_Problem_13_Remains_Correct()
        {
            Check(13, 5537376230);
        }

        [Test]
        public void Solution_For_Problem_14_Remains_Correct()
        {
            Check(14, 837799);
        }

        private void Check(int problemId, BigInteger expectedValue)
        {
            Solution solution = GetSolution(problemId);
            Assert.IsTrue(expectedValue == solution.Value);
        }

        private Solution GetSolution(int problemId)
        {
            Problem problem = ProblemFactory.GetProblem(problemId);
            return problem.Solve();
        }
    }
}
