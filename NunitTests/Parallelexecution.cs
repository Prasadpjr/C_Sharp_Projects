using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_CSharp.NunitTests
{
    [Parallelizable(ParallelScope.All)]
    internal class Parallelexecution
    {
        [Test]
        public void login()
        {
            Console.WriteLine("user logged in");
        }

        [Test]
        public void search()
        {
            Console.WriteLine("user searched the product");
        }

        [Test]
        public void selectproduct()
        {
            Console.WriteLine("user selected the product");
        }

        [Test]
        public void addToCart()
        {
            Console.WriteLine("product added to cart successfully");
        }
    }
}
