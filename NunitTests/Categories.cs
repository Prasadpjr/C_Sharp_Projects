using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_CSharp.NunitTests
{
    
    internal class Categories
    {
        [Test, Order(0), Category("Regression")]
        public void login()
        {
            Console.WriteLine("user logged in");
        }

        [Test, Order(1), Category("Smoke")]
        public void search()
        {
            Console.WriteLine("user searched the product");
        }

        [Test, Order(2), Category("Regression")]
        public void selectproduct()
        {
            Console.WriteLine("user selected the product");
        }

        [Test, Order(3), Category("Smoke")]
        public void addToCart()
        {
            Console.WriteLine("product added to cart successfully");
        }
    }
}
