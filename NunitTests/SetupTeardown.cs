using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_CSharp.NunitTests
{
    internal class SetupTeardown
    {
        [SetUp]//multiple setups are allowed
        public void launchBrowser()
        {
            Console.WriteLine("browser launched succesffully");
        }

        [TearDown]//multiple teardowns are allowed
        public void closeBrowser()
        {
            Console.WriteLine("browser closed succesffully");
        }
        

        [Test, Order(1)]
        public void search()
        {
            Console.WriteLine("user searched the product");
        }

        [Test, Order(2)]
        public void selectproduct()
        {
            Console.WriteLine("user selected the product");
        }

        [Test, Order(3)]
        public void addToCart()
        {
            Console.WriteLine("product added to cart successfully");
        }
    }
}
