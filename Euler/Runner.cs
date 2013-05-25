using System;
using ProjectEuler.Problems;
using System.Diagnostics;

namespace ProjectEuler
{
    public static class Runner
    {
        public static void SolveProblem(int problemId)
        {
            Problem problem = ProblemFactory.GetProblem(problemId);

            if (problem == null)
            {
                Console.WriteLine("Problem #{0} not found", problemId);
                return;
            }
                
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Solution solution = problem.Solve();
            stopWatch.Stop();

            var result = new Result(solution, stopWatch.Elapsed);

            DisplayResult(problem, result);                
        }

        private static void DisplayResult(Problem problem, Result result)
        {
            Console.WriteLine("Problem #{0}", problem.Id);
            Console.WriteLine("Solution: {0}\r\nTime taken: {1}s\r\n", result.Solution.Value, result.TimeTakenToSolve.TotalSeconds);
        }   
    }
}
