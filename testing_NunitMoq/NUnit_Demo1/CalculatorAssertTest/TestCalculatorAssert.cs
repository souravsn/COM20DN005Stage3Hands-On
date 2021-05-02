//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CalculatorAssertTest
//{
//    public class TestCalculatorAssert
//    {
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit_Demo1;

namespace CalculatorAssertTest
{
    class TestCalculatorAssert
    {
        string Name;
        Calculator calculator;
        [SetUp]
        public void SetUp()
        {
            Name = "CTS";
            calculator = new Calculator();
        }

        [Test]
        [TestCase(10, 20, 30)]
        public void AddMethodTest(int numA, int numB, int expected)
        {
            int result = calculator.Add(numA, numB);
            // Assert.True(expected==result);
            Assert.IsTrue(expected == result);
            Assert.IsFalse(expected > result);
        }

        [Test]
        [TestCase(15, 35, 50)]
        public void AddContraintTest(int num1, int num2, int expected)
        {
            int result = calculator.Add(num1, num2);
            //Assert.That(Name, Is.EqualTo("Cognizant Technology Solutions"));
            //Assert.That(result, Is.GreaterThan(0));
            //Assert.That(result, Is.GreaterThanOrEqualTo(80));
            //Assert.That(result, Is.LessThan(100));
            Assert.That(result, Is.LessThanOrEqualTo(1000));
        }
    }
}