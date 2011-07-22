using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
    public sealed class Solution
    {
        public Solution(long value)
        {
            Value = value;
        }

        public long Value { get; private set; }
    }
}
