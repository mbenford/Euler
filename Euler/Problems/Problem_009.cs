namespace Euler.Problems
{
    public class Problem_009 : Problem
    {
        public override Solution Solve()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int sum = 0; 
            
            int i = 1;
            int j = i + 1;
            while (sum != 1000)
            {
                a = (j * j) - (i * i);
                b = 2 * i * j;
                c = (j * j) + (i * i);

                sum = a + b + c;

                if (sum > 1000)
                {
                    i++;
                    j = i;
                }
                
                j++;
            }

            return new Solution(a * b * c);
        }
    }
}
