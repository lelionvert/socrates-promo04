using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using NUnit.Framework;

namespace SocratesFrTest.ColdMealManagement
{
    public class ColdMealCalculatorTest
    {
        [Test]
        public void calculate_()
        {
            ColdMealCalculator coldMealCalculator = new ColdMealCalculator();
            Check.That(coldMealCalculator.Calculate()).IsEqualTo(0);
        }
    }
}
