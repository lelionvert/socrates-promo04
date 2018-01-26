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
        public void Calculate_With_Empty_List()
        {
            ColdMealCalculator coldMealCalculator = new ColdMealCalculator();
            Check.That(coldMealCalculator.Calculate(new List<DateTime>())).IsEqualTo(0);
        }

        [Test]
        public void Calculate_With_One_Check_In_In_Range()
        {
            ColdMealCalculator coldMealCalculator = new ColdMealCalculator();
            Check.That(coldMealCalculator.Calculate(new List<DateTime>(){ new DateTime(2018, 1, 25, 22, 0, 0) })).IsEqualTo(1);
        }

    }
}
