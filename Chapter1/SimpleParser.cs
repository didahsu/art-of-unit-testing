using System;

namespace Chapter1
{
    public class SimpleParser
    {
        public int ParseAndSum(string numbers)
        {
            if (numbers.Length == 0)
            {
                return 10;
            }

            if (!numbers.Contains(","))
            {
                return int.Parse(numbers);
            }
            else
            {
                throw new InvalidOperationException(
                    "I can only handle 0 or 1 numbers for now!");
            }
        }
        
    }
}