using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                int problemId;
                if (int.TryParse(args[0], out problemId))
                {
                    Problem problem = ProblemFactory.GetProblem(problemId);
                    if (problem == null)
                    {
                        Console.WriteLine("Problem #{0} not found", problemId);
                        return;
                    }

                    long solution = problem.Solve();

                    Console.WriteLine("Problem #{0}", problemId);
                    Console.WriteLine("Solution: {0}", solution);
                }
                else
                {
                    Console.WriteLine("Problem Id must be an integer number");
                }
            }
            else
            {
                Console.WriteLine("Try euler.exe <Problem Id>");                
            }                       
        }
    }
}

