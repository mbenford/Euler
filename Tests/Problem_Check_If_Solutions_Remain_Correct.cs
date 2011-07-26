using System;
using NUnit.Framework;
using ProjectEuler.Problems;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem_Check_If_Solutions_Remain_Correct
    {
        [Test]
        public void Check_If_Solution_For_Problem_1_Remains_Correct()
        {
            Problem problem = new Problem1();
            Solution solution = problem.Solve();

            Assert.AreEqual(233168, solution.Value);
        }

        [Test]
        public void Check_If_Solution_For_Problem_2_Remains_Correct()
        {
            Problem problem = new Problem2();
            Solution solution = problem.Solve();

            Assert.AreEqual(4613732, solution.Value);
        }

        [Test]
        public void Check_If_Solution_For_Problem_3_Remains_Correct()
        {
            Problem problem = new Problem3();
            Solution solution = problem.Solve();

            Assert.AreEqual(6857, solution.Value);
        }

        [Test]
        public void Check_If_Solution_For_Problem_4_Remains_Correct()
        {
            Problem problem = new Problem4();
            Solution solution = problem.Solve();

            Assert.AreEqual(906609, solution.Value);
        }

        [Test]
        public void Check_If_Solution_For_Problem_5_Remains_Correct()
        {
            Problem problem = new Problem5();
            Solution solution = problem.Solve();

            Assert.AreEqual(232792560, solution.Value);
        }

        [Test]
        public void Check_If_Solution_For_Problem_6_Remains_Correct()
        {
            Problem problem = new Problem6();
            Solution solution = problem.Solve();

            Assert.AreEqual(25164150, solution.Value);
        }

        [Test]
        public void Check_If_Solution_For_Problem_7_Remains_Correct()
        {
            Problem problem = new Problem7();
            Solution solution = problem.Solve();

            Assert.AreEqual(104743, solution.Value);
        }

        [Test]
        public void Check_If_Solution_For_Problem_8_Remains_Correct()
        {
            Problem problem = new Problem8();
            Solution solution = problem.Solve();

            Assert.AreEqual(40824, solution.Value);
        }

    }
}
