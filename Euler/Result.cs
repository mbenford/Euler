using System;

namespace Euler
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
