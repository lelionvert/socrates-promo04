using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using NUnit.Framework;
using SocratesFr;

namespace SocratesFrTest
{
    class MealsTest
    {
        [Test]
        public void No_Diets_For_One_Date_Should_Not_Gives_Covers()
        {
            Meals meals = new Meals();
            int count = meals.Count(new DateTime(2018, 1, 25, 12, 0, 0), Diet.VEGAN);
            Check.That(count).IsEqualTo(0);
        }

        [Test]
        public void One_Diets_For_One_Date_Should_Give_One_Vegan_Covers()
        {
            Meals meals = new Meals();
            DateTime mealTime = new DateTime(2018, 1, 25, 12, 0, 0);
            Diets diets = new Diets();
            diets.Add(Diet.VEGAN);
            meals.Add(diets,mealTime);
            int count = meals.Count(mealTime, Diet.VEGAN );
            Check.That(count).IsEqualTo(1);
        }
    }
}
