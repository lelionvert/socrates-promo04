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
        public void Calculate_With_No_Check_In()
        {
            IKitchen stubAvailableColdMeal = new StubAvailableColdMeal();
            ColdMealCalculator coldMealCalculator = new ColdMealCalculator(stubAvailableColdMeal);
            Check.That(coldMealCalculator.Calculate(CheckInsGenerator())).IsEqualTo(0);
        }

        [Test]
        public void Calculate_With_One_Check_In_In_Range()
        {
            IKitchen stubAvailableColdMeal = new StubAvailableColdMeal();
            ColdMealCalculator coldMealCalculator = new ColdMealCalculator(stubAvailableColdMeal);
            Check.That(coldMealCalculator.Calculate(CheckInsGenerator(new DateTime(2018, 1, 25, 22, 0, 0))))
                .IsEqualTo(1);
        }

        [Test]
        public void Calculate_With_Two_Check_Ins_In_Range()
        {
            IKitchen stubAvailableColdMeal = new StubAvailableColdMeal();
            ColdMealCalculator coldMealCalculator = new ColdMealCalculator(stubAvailableColdMeal);
            Check.That(coldMealCalculator.Calculate(CheckInsGenerator(new DateTime(2018, 1, 25, 22, 0, 0), new DateTime(2018, 1, 26, 0, 0, 0)))).IsEqualTo(2);
        }

        [Test]
        public void Calculate_With_Two_Check_Ins_In_Range_And_One_Out_Of_Range()
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

    public class StubAvailableColdMeal : IKitchen
    {
        public bool HasColdMealAvailableAt(DateTime dateTime)
        {
            return true;
        }
    }


}
