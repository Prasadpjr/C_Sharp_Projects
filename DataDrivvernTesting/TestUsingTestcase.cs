using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_CSharp.DataDrivvernTesting
{
    internal class TestUsingTestcase
    {
        [TestCase(1,2,3)]//for methods at classlevel TestFixtures
        [TestCase(4,5,6)]
        [TestCase(7,8,9)]
        public void test(int a,int b,int c)
        {
           Assert.That(a, Is.EqualTo(b));
        }
    }
}
