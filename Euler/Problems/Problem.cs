using System;
using System.Text.RegularExpressions;

namespace Euler.Problems
{
    public abstract class Problem
    {
        public abstract Solution Solve();
        public virtual int Id
        {
            get
            {
                string typeName = this.GetType().Name;
                var pattern = "^Problem_(?<id>[0-9]+)$";
                Match match = Regex.Match(typeName, pattern);
                return Convert.ToInt32(match.Groups["id"].Value);
            }
        }
    }
}
