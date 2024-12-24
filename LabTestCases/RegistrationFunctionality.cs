using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestProject_CSharp.LabTestCases
{
    [Allure.NUnit.AllureNUnit]
    [TestFixture, Description("This is Sanity test suite")]
    internal class RegistrationFunctionality
    {
        //category,ignoretestcase, testfixture, ordering, report, assertions
        [Test, Order(0), Category("Logintest")]
        public void bankManagerLogin()
        {
            Console.WriteLine("Bank manger Logged in successfully");
        }

        [TestCase("Prasad","Poojary",554433)]
        [TestCase("Nithin", "Kumar", 675645)]
        [Order(3), Category("Registration")]
        public void addCustomer(String firstName, String Lastname, int postcode)
        {
            Console.WriteLine("The Given inputs are entered under Add customer i.e-->"+ firstName+"---"+ Lastname + "---" + postcode);
        }

        [TestCase("Prasad", "dollor")]
        [TestCase("Nithin", "Rupee")]
        [Test, Order(1), Category("Registration")]
        public void openAccount(String customer, String currency)
        {
            Console.WriteLine("The Given inputs are entered under open account i.e-->" + customer + "---" + currency);
        }

        [TestCase("Rashmi")]
        [Order(2), Category("Registration")]
        public void Customer(String searchname)
        {
            Console.WriteLine("The given customer name is searched i.e-->"+ searchname);
        }

        [TestCase("Ganesh")]
        [Order(4), Category("Other")]
        public void assertion1(String name)
        {
            Assert.That(name, Does.Contain("esh").IgnoreCase);

        }
        [TestCase("Rashmi")]
        [Order(5), Category("Other"), Ignore("This test is currently ignored due to a known issue.")]
        public void assertion2(String name)
        {
            Assert.That(name, Does.Contain("esh").IgnoreCase);


        }

    }
}
