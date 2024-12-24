using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_CSharp.NunitTests
{
    internal class IgnoreTest
    {
        [Test, Order(0)]
        public void login()
        {
            Console.WriteLine("user logged in");
        }

        [Test, Order(1)]
        public void search()
        {
            Console.WriteLine("user searched the product");
        }

        [Test, Order(2)]
        [Ignore("This test is currently ignored due to a known issue.")]
        public void selectproduct()
        {
            Console.WriteLine("user selected the product");
        }

        [Test, Order(3), Ignore("This test is currently ignored due to a known issue.")]
        public void addToCart()
        {
            Console.WriteLine("product added to cart successfully");
        }
    }
}
