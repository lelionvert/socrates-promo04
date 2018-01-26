using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using NUnit.Framework;

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

        [Test]
        public void Meal_Is_Not_Cold_When_Check_In_At_1()
        {
            Check.That(new ColdMeal().IsCold(new DateTime(2018, 1, 26, 1, 0, 0))).IsFalse();
        }
    }
}
