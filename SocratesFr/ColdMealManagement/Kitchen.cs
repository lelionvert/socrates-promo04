using System;

namespace SocratesFr.ColdMealManagement
{
    public class Kitchen
    {
        private readonly DateTime _coldMealBegin;
        private readonly DateTime _coldMealEnd;

        public Kitchen() : this(new DateTime(2018, 1, 25, 21, 0, 0), new DateTime(2018, 1, 26, 0, 0, 0)) 
        {

        }

        public Kitchen(DateTime coldMealBegin, DateTime coldMealEnd)
        {
            _coldMealBegin = coldMealBegin;
            _coldMealEnd = coldMealEnd;
        }

        public bool HasColdMealAvailableAt(DateTime dateTime)
        {
            if (dateTime <= _coldMealBegin)
                return false;
            if (dateTime > _coldMealEnd)
                return false;
            return true;
        }
    }
}