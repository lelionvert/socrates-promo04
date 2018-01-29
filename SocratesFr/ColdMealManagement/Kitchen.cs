using System;

namespace SocratesFr.ColdMealManagement
{
    public class Kitchen : IKitchen
    {
        private readonly DateTime coldMealBegin;
        private readonly DateTime coldMealEnd;

        public Kitchen(DateTime coldMealBegin, DateTime coldMealEnd)
        {
            this.coldMealBegin = coldMealBegin;
            this.coldMealEnd = coldMealEnd;
        }

        public bool HasColdMealAvailableAt(DateTime dateTime)
        {
            return dateTime > coldMealBegin && dateTime <= coldMealEnd;
        }
    }
}