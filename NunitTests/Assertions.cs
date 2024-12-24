using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_CSharp.NunitTests
{
    internal class Assertions
    {
        [Test]
        public void asserstions()
        {
            String name1 = "Prasad";
            String name2 = "Ganesh";

            if (name1 == name2)
            {
                Console.WriteLine("Text matching");
            }
            else
            {
                Console.WriteLine("Names are not equal");
            }
            Assert.AreNotEqual(name1, name2);
            Assert.AreEqual(name1, name2);
            Assert.AreSame(name1, name2);
            Assert.AreNotSame(name1, name2);

         //Assert That
          Assert.That(name1.Equals(name2));
            Assert.That(!name1.Equals(name2));
            Assert.That(name1 == name2);

        //empty assertions
            Assert.IsEmpty(name1);
            Assert.IsNotEmpty(name2);
            Assert.IsNotNull(name1);
            Assert.IsTrue(name1.Equals(name2));
            Assert.IsFalse(name2.Equals(name1));
         
         // substring
                Assert.That(name1, Does.Contain("pra").IgnoreCase);
                   
         // collection contraints

            int[] array = new int[] { 1, 4, 3, 8, 5, 6 };

            Assert.NotNull(array);
            Assert.That(array, Is.All.GreaterThan(0));
            Assert.IsEmpty(array);
            Assert.That(array, Is.Ordered.Ascending);
            int age = 17;
            if (age < 18)
            {
                throw new AssertionException("User is not eligible for voting");
            }
        }
    }
}
