using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler.Problems
{
    public sealed class Solution
    {
        public Solution(long value)
            : this(new BigInteger(value))
        {
        }

        public Solution(BigInteger value)
        {
            Value = value;
        }

        public BigInteger Value { get; private set; }
    }
}
