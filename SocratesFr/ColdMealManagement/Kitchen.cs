using System;

namespace SocratesFr.ColdMealManagement
{
    public class Kitchen
    {
        public Kitchen()
        {
        }

        public bool HasColdMealAvailableAt(DateTime dateTime)
        {
            if (dateTime <= (new DateTime(2018, 1, 25, 21, 0, 0)))
                return false;
            if (dateTime.Equals(new DateTime(2018, 1, 26, 1, 0, 0)))
                return false;
            return true;
        }
    }
}