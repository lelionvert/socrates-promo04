using System;
using System.Collections.Generic;
using NFluent;
using NUnit.Framework;
using SocratesFr.ColdMealManagement;

namespace SocratesFrTest.ColdMealManagement
{
    public class ColdMealCalculatorTest
    {
        private List<DateTime> CheckInsGenerator(params DateTime[] checkins)
        {
            return new List<DateTime>(checkins);
        }

        [Test]
        public void Calculate_With_Available_And_Not_Available_Check_Ins()
        {
            IKitchen kitchenServesNoColdMealAt9Pm = new KitchenServesNoColdMealAt9pm();
            ColdMealCalculator coldMealCalculator = new ColdMealCalculator(kitchenServesNoColdMealAt9Pm);
            Check.That(coldMealCalculator.Calculate(CheckInsGenerator(new DateTime(2018, 1, 25, 22, 0, 0), new DateTime(2018, 1, 26, 0, 0, 0), new DateTime(2018, 1, 25, 21, 0, 0)))).IsEqualTo(2);
        }        
    }

    public class KitchenServesNoColdMealAt9pm : IKitchen
    {
        public bool HasColdMealAvailableAt(DateTime dateTime)
        {
            return new DateTime(2018, 1, 25, 21, 0, 0) != dateTime;
        }
    }

}
