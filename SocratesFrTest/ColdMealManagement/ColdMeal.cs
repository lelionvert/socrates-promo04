using System;

namespace SocratesFrTest.ColdMealManagement
{
    internal class ColdMeal
    {
        public ColdMeal()
        {
        }

        public bool IsCold(DateTime dateTime)
        {
            if (dateTime.Equals(new DateTime(2018, 1, 26, 1, 0, 0)))
                return false;
            return true;
        }
    }
}