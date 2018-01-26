using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using NUnit.Framework;

namespace SocratesFrTest.ColdMealManagement
{
    public class ColdMealCalculatorTest
    {

        private List<DateTime> CheckInsGenerator(params DateTime[] checkins)
        {
            return new List<DateTime>(checkins);
        }

        [Test]
        public void Calculate_With_Empty_List()
        {
            ColdMealCalculator coldMealCalculator = new ColdMealCalculator();
            Check.That(coldMealCalculator.Calculate(CheckInsGenerator())).IsEqualTo(0);
        }

        [Test]
        public void Calculate_With_One_Check_In_In_Range()
        {
            ColdMealCalculator coldMealCalculator = new ColdMealCalculator();
            Check.That(coldMealCalculator.Calculate(CheckInsGenerator(new DateTime(2018, 1, 25, 22, 0, 0)))).IsEqualTo(1);
        }

        [Test]
        public void Calculate_With_Null_Check_Ins()
        {
            ColdMealCalculator coldMealCalculator = new ColdMealCalculator();
            Check.That(coldMealCalculator.Calculate(null)).IsEqualTo(0);
        }

        [Test]
        public void Calculate_With_Two_Check_Ins_In_Range()
        {
            ColdMealCalculator coldMealCalculator = new ColdMealCalculator();
            Check.That(coldMealCalculator.Calculate(CheckInsGenerator(new DateTime(2018, 1, 25, 22, 0, 0), new DateTime(2018, 1, 26, 0, 0, 0)))).IsEqualTo(2);
        }
    }
}
