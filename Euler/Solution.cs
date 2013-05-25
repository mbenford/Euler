using System.Numerics;

namespace Euler
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
