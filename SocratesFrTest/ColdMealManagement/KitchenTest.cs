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

        [TestCase(25, 22, 0)]
        public void Cold_Meal_Available_When_Check_In_Is_In_Range(int day, int hour, int minute)
        {
            Check.That(new Kitchen().HasColdMealAvailableAt(new DateTime(2018, 1, day, hour, minute, 0))).IsTrue();
        }

        [TestCase(26, 1, 0)]
        [TestCase(25, 21, 0)]
        [TestCase(25, 19, 0)]
        [TestCase(26, 0, 1)]
        public void No_Cold_Meal_Available_When_Check_In_Is_Out_Of_Range(int day, int hour, int minute)
        {
            Check.That(new Kitchen().HasColdMealAvailableAt(new DateTime(2018, 1, day, hour, minute, 0))).IsFalse();
        }
    }
}
