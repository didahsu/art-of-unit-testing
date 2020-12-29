using System;
using System.Reflection;

namespace Chapter1
{
    public class SimpleParserTests
    {
        public static void TestReturnsZeroWhenEmptyString()
        {
            var testName = MethodBase.GetCurrentMethod().Name;
            try
            {
                var p = new SimpleParser();
                var result = p.ParseAndSum(string.Empty);
                if (result != 0)
                {
                    /*
                    Console.WriteLine(
                        @"
                        ***SimpleParserTests.TestReturnsZeroWhenEmptyString:
                        -------
                        Parse and sum should have returned 0 on an empty string");
                    */
                    TestUtil.ShowProblem(testName, "Parse and sum should have returned 0 on an empty string");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}