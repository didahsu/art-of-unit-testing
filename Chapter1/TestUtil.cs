using System;
using System.Reflection;

namespace Chapter1
{
    public class TestUtil
    {
        public static void ShowProblem(string test, string message)
        {
            var msg = string.Format(@"
            ---{0}---
                    {1}
            ------------------------
            ", test, message);
            Console.WriteLine(msg);
        }
    }
}