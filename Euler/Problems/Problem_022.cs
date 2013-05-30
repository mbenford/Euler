using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    public class Problem_022 : Problem
    {        
        public override Solution Solve()
        {
            string filename = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Data\\Problem22.txt");
            long sum = File.ReadAllText(filename)
                           .Replace("\"", "")
                           .Split(',')
                           .OrderBy(name => name)
                           .Select((name, index) => (long)GetAlphabeticalValue(name) * (index + 1))
                           .Sum();

            return new Solution(sum);
        }

        private int GetAlphabeticalValue(string name)
        {
            return name.ToCharArray().Select(c => c - 'A' + 1).Sum();
        }
    }
}
