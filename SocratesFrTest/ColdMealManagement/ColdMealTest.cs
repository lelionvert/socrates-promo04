using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using NUnit.Framework;
using SocratesFr.ColdMealManagement;

namespace SocratesFrTest.ColdMealManagement
{
    public class ColdMealTest
    {

        [Test]
        public void Meal_Is_Cold_When_Check_In_At_22()
        {
            ColdMeal coldMeal = new ColdMeal();
            bool isCold = coldMeal.IsCold(new DateTime(2018,1,25,22,0,0));
            Check.That(isCold).IsTrue();
        }

        [TestCase(26,1,0)]
        [TestCase(25,19,0)]
        public void Meal_Is_Not_Cold_When_Check_In_At_1(int day, int hour, int minute)
        {
            Check.That(new ColdMeal().IsCold(new DateTime(2018, 1, day, hour, minute, 0))).IsFalse();
        }
    }
}
