using System;
using NUnit.Framework;
using SocratesFr;

namespace SocratesFrTest
{
    internal class Meals
    {
        private Diets diets;

        public int Count(DateTime mealTime, Diet diet)
        {
            if(diets!= null) return diets.CountBy(diet);
            return 0;
        }

        public void Add(Diets diets, DateTime mealTime)
        {
            this.diets = diets;
        }
    }
}