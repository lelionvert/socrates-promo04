using System;

namespace SocratesFr.ColdMealManagement
{
    public class Kitchen
    {
        private readonly DateTime _coldMealBegin;
        private readonly DateTime _coldMealEnd;

        public Kitchen(DateTime coldMealBegin, DateTime coldMealEnd)
        {
            _coldMealBegin = coldMealBegin;
            _coldMealEnd = coldMealEnd;
        }

        public bool HasColdMealAvailableAt(DateTime dateTime)
        {
            return dateTime > _coldMealBegin && dateTime <= _coldMealEnd;
        }
    }
}