using System;
using System.Collections.Generic;
using System.Linq;

namespace SocratesFr.ColdMealManagement
{
    public class ColdMealCalculator
    {
        private readonly IKitchen kitchen;

        public ColdMealCalculator(IKitchen kitchen)
        {
            this.kitchen = kitchen;
        }
        
        public int Calculate(IList<DateTime> checkIns )
        {
            return checkIns?.Count(kitchen.HasColdMealAvailableAt) ?? 0;
        }
    }
}