using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspectInjector.Broker;
using NUnit.Framework.Interfaces;
namespace TestEGdecbatch.DataDrivenTesting

{
internal class TestParUsingExcel

    {

        [Test, TestCaseSource("GetTestdata")]

        public void LoginTest(String username, string password)
        {
            Console.WriteLine(username + " : " + password);
        }


        public static IEnumerable<TestCaseData> GetTestdata()
        {
            var columns = new List<string> { "username", "password" };
            return TestProject_CSharp.Utilities.ExcelRead.GetTestDataFromExcel("C:\\Users\\ppooj\\source\\repos\\TestProject_CSharp\\TestProject_CSharp\\Testdata.xlsx", "login", columns);
        }
    }
        
}
