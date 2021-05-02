using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit_Demo1;

namespace CalculatorTest
{
    [TestFixture]
    public class TestCalculator
    {
        string Name;
        [SetUp]
        public void SetUp()
        {
            Name = "CTS";
            Assert.AreEqual("CTS", Name);
        }

        [Test]
        [Repeat(2)]
        [MaxTime(200)]

        //[Test]
        public void AddMethodTest()
        {
            Calculator add = new Calculator();
            int result = add.Add(15, 65);
            Assert.AreEqual(80, result);
        }
        [Test]
        public void AddMethodTest2()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(-125, 65);
            Assert.AreEqual(-60, result);
        }
        //[Test]
        //[TestCase(125, 65, 60)]
        //[TestCase(65, 65, 0)]
        //[TestCase(25, 65, -40)]
        //public void SubtractMethodTest(int numA, int numB, int expected)
        //{
        //    int result = calculator.Subtract(numA, numB);
        //    Assert.AreEqual(expected, result);
        //}

        //[Test]
        //[Ignore("Don't run this test as duplicate")]
    }
}
