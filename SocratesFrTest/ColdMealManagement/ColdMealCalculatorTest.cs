using System;
using System.Collections.Generic;
using NFluent;
using NUnit.Framework;
using SocratesFr.ColdMealManagement;

namespace SocratesFrTest.ColdMealManagement
{
    public class ColdMealCalculatorTest
    {
        private readonly Kitchen kitchen = new Kitchen(new DateTime(2018, 1, 25, 21, 0, 0), new DateTime(2018, 1, 26, 0, 0, 0));

        private List<DateTime> CheckInsGenerator(params DateTime[] checkins)
        {
            return new List<DateTime>(checkins);
        }

        [Test]
        public void Calculate_With_Empty_List()
        {
            ColdMealCalculator coldMealCalculator = new ColdMealCalculator(kitchen);
            Check.That(coldMealCalculator.Calculate(CheckInsGenerator())).IsEqualTo(0);
        }

        [Test]
        public void Calculate_With_One_Check_In_In_Range()
        {
            ColdMealCalculator coldMealCalculator = new ColdMealCalculator(kitchen);
            Check.That(coldMealCalculator.Calculate(CheckInsGenerator(new DateTime(2018, 1, 25, 22, 0, 0)))).IsEqualTo(1);
        }

        [Test]
        public void Calculate_With_Null_Check_Ins()
        {
            ColdMealCalculator coldMealCalculator = new ColdMealCalculator(kitchen);
            Check.That(coldMealCalculator.Calculate(null)).IsEqualTo(0);
        }

        [Test]
        public void Calculate_With_Two_Check_Ins_In_Range()
        {
            ColdMealCalculator coldMealCalculator = new ColdMealCalculator(kitchen);
            Check.That(coldMealCalculator.Calculate(CheckInsGenerator(new DateTime(2018, 1, 25, 22, 0, 0), new DateTime(2018, 1, 26, 0, 0, 0)))).IsEqualTo(2);
        }

        [Test]
        public void Calculate_With_Two_Check_Ins_In_Range_And_One_Out_Of_Range()
        {
            ColdMealCalculator coldMealCalculator = new ColdMealCalculator(kitchen);
            Check.That(coldMealCalculator.Calculate(CheckInsGenerator(new DateTime(2018, 1, 25, 22, 0, 0), new DateTime(2018, 1, 26, 0, 0, 0), new DateTime(2018, 1, 25, 21, 0, 0)))).IsEqualTo(2);
        }
    }
}
