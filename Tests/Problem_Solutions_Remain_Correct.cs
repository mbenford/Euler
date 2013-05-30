using System.Numerics;
using Euler.Problems;
using FluentAssertions;
using Xunit;
using Xunit.Extensions;

namespace Euler.Tests
{
    public class Problem_Solutions_Remain_Correct
    {
        [Theory]
        [InlineData(1, 233168)]
        [InlineData(2, 4613732)]
        [InlineData(3, 6857)]
        [InlineData(4, 906609)]
        [InlineData(5, 232792560)]
        [InlineData(6, 25164150)]
        [InlineData(7, 104743)]
        [InlineData(8, 40824)]
        [InlineData(9, 31875000)]
        [InlineData(10, 142913828922)]
        [InlineData(11, 70600674)]
        [InlineData(12, 76576500)]
        [InlineData(13, 5537376230)]
        [InlineData(14, 837799)]
        [InlineData(15, 137846528820)]
        [InlineData(16, 1366)]
        [InlineData(17, 21124)]
        [InlineData(19, 171)]        
        [InlineData(20, 648)]
        [InlineData(22, 871198282)]        
        [InlineData(25, 4782)]        
        public void Checks_If_Solution_Remains_Correct(int problemId, long expectedValue)
        {
            // Arrange
            Problem problem = ProblemFactory.GetProblem(problemId);

            // Act
            Solution solution = problem.Solve();

            // Assert
            solution.Value.Should().Be(new BigInteger(expectedValue));
        }
    }
}
