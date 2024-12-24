using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_CSharp.DataDrivvernTesting
{
    internal class TestUsingTestcaseSource
    {
        [Test, TestCaseSource("getTestData")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + ":" + password);
        }

        public static IEnumerable<TestCaseData> getTestData(){
            yield return new TestCaseData("prasad","1234");
            yield return new TestCaseData("vivek", "4567");
            yield return new TestCaseData("nithin", "7654");
            yield return new TestCaseData("Rahul", "6756");
        }
    }
}
