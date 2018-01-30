using System;
using NFluent;
using NUnit.Framework;
using SocratesFr;

namespace SocratesFrTest
{
    public class CoversCalculatorTest
    {
        [Test]
        public void Various_Diets_Should_Gives_Two_Vegan_Covers()
        {
            Diets diets = new Diets();
            DateTime lunchTime = new DateTime(2018, 1, 25, 12, 0, 0);
            diets.Add(new Meal(lunchTime,Diet.VEGAN));
            diets.Add(new Meal(lunchTime, Diet.VEGAN));
            diets.Add(new Meal(lunchTime, Diet.VEGETARIAN));
            diets.Add(new Meal(lunchTime, Diet.DEFAULT));
            diets.Add(new Meal(lunchTime, Diet.PESCATARIAN));
            Check.That(diets.CountBy(Diet.VEGAN)).IsEqualTo(2);
        }

        [Test]
        public void No_Diets_For_One_Date_Gives_No_Cover()
        {
            Diets diets = new Diets();
            Check.That(diets.CountFor(new DateTime(2018, 1, 25, 12, 0, 0))).IsEqualTo(0);
        }

        [Test]
        public void Various_Diet_Should_Gives_One_Cover_For_One_Date()
        {
            Diets diets = new Diets();
            Meal meal = new Meal(new DateTime(2018, 1, 25, 12, 0, 0), Diet.VEGAN);
            diets.Add(meal);
            Check.That(diets.CountFor(new DateTime(2018, 1, 25, 12, 0, 0))).IsEqualTo(1);
        }

        //[Test]
        //public void Various_Diet_For_Various_Dates_Should_Gives_One_diets()
        //{
        //    Diets diets = new Diets();
        //    Meal meal = new Meal(new DateTime(2018, 1, 25, 12, 0, 0), Diet.VEGAN);
        //    Meal meal2 = new Meal(new DateTime(2018, 1, 25, 19, 0, 0), Diet.VEGAN);
        //    diets.Add(meal);
        //    diets.Add(meal2);
        //    Check.That(diets.CountDietFor(new DateTime(2018, 1, 25, 19, 0, 0))).IsEqualTo(1);
        //}



        
    }

    
        
}
