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
            Problem problem = new Problem_001();
            Solution solution = problem.Solve();

            Assert.IsTrue(233168 == solution.Value);
        }

        [Test]
        public void Check_If_Solution_For_Problem_2_Remains_Correct()
        {
            Problem problem = new Problem_002();
            Solution solution = problem.Solve();

            Assert.IsTrue(4613732 == solution.Value);
        }

        [Test]
        public void Check_If_Solution_For_Problem_3_Remains_Correct()
        {
            Problem problem = new Problem_003();
            Solution solution = problem.Solve();

            Assert.IsTrue(6857 == solution.Value);
        }

        [Test]
        public void Check_If_Solution_For_Problem_4_Remains_Correct()
        {
            Problem problem = new Problem_004();
            Solution solution = problem.Solve();

            Assert.IsTrue(906609 == solution.Value);
        }

        [Test]
        public void Check_If_Solution_For_Problem_5_Remains_Correct()
        {
            Problem problem = new Problem_005();
            Solution solution = problem.Solve();

            Assert.IsTrue(232792560 == solution.Value);
        }

        [Test]
        public void Check_If_Solution_For_Problem_6_Remains_Correct()
        {
            Problem problem = new Problem_006();
            Solution solution = problem.Solve();

            Assert.IsTrue(25164150 == solution.Value);
        }

        [Test]
        public void Check_If_Solution_For_Problem_7_Remains_Correct()
        {
            Problem problem = new Problem_007();
            Solution solution = problem.Solve();

            Assert.IsTrue(104743 == solution.Value);
        }

        [Test]
        public void Check_If_Solution_For_Problem_8_Remains_Correct()
        {
            Problem problem = new Problem_008();
            Solution solution = problem.Solve();

            Assert.IsTrue(40824 == solution.Value);
        }

    }
}
