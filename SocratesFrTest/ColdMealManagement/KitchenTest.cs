using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using NUnit.Framework;
using SocratesFr.ColdMealManagement;

namespace SocratesFrTest.ColdMealManagement
{
    public class KitchenTest
    {

        [Test]
        public void Meal_Is_Cold_When_Check_In_At_22()
        {
            Kitchen kitchen = new Kitchen();
            bool isCold = kitchen.HasColdMealAvailableAt(new DateTime(2018, 1, 25, 22, 0, 0));
            Check.That(isCold).IsTrue();
        }

        [TestCase(26, 1, 0)]
        [TestCase(25, 19, 0)]
        public void Meal_Is_Not_Cold_When_Check_In_At_1(int day, int hour, int minute)
        {
            Check.That(new Kitchen().HasColdMealAvailableAt(new DateTime(2018, 1, day, hour, minute, 0))).IsFalse();
        }
    }
}
