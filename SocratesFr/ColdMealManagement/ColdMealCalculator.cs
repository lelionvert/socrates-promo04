using System;
using System.Collections.Generic;
using System.Linq;

namespace SocratesFr.ColdMealManagement
{
    public class ColdMealCalculator
    {
        private readonly Kitchen kitchen;

        public ColdMealCalculator(Kitchen kitchen)
        {
            this.kitchen = kitchen;
        }
        
        public int Calculate(IList<DateTime> checkIns )
        {
            return checkIns?.Count(kitchen.HasColdMealAvailableAt) ?? 0;
        }
    }
}