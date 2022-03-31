using NUnit.Framework;
using Practices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesTests
{
    /// <summary>
    /// Тестируем функции калькулятора
    /// </summary>
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(3, 5) == 8);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(9, 8) == 1);
        }

        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Miltiplication(3, 4) == 12);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Division(88, 22) == 4);
        }
    }
}
