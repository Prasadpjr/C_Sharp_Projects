using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestProject_CSharp.Utilities
{
    public class Class1
    {
        [Test]
        public void testMethod()
        {
             var name = ConfigurationManager.AppSettings.Get("browser");
            var author = ConfigurationManager.AppSettings.Get("auth");

            Console.WriteLine($"Browser name is {name} and author name is {author}");
        }
    }
}