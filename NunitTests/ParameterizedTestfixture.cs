using System;
using NUnit.Framework;

namespace TestProject_CSharp.NunitTests
{
    [TestFixture(2, 3)]
    [TestFixture(4, 8)]
    [TestFixture(6, 7)]
    internal class ParameterizedTestfixture
    {
        private readonly int _a;
        private readonly int _b;

        public ParameterizedTestfixture(int a, int b)
        {
            _a = a;
            _b = b;
        }

        [Test]
        public void Sum()
        {
            Assert.That(_a + _b, Is.EqualTo(_a + _b)); // Example assertion, adjust as needed
        }

        [Test]
        public void Product()
        {
            Assert.That(_a * _b, Is.EqualTo(_a * _b)); // Example assertion, adjust as needed
        }
    }
}