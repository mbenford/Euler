using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    public sealed class Result
    {
        public Result(Solution solution, TimeSpan timeTakenToSolve)
        {
            Solution = solution;
            TimeTakenToSolve = timeTakenToSolve;
        }

        public Solution Solution { get; private set; }
        public TimeSpan TimeTakenToSolve { get; private set; }
    }
}
