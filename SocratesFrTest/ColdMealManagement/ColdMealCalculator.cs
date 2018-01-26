using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SocratesFr.ColdMealManagement;

namespace SocratesFrTest.ColdMealManagement
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
            if (checkIns == null)
                return 0;
            return checkIns.Count(checkIn => kitchen.HasColdMealAvailableAt(checkIn));
        }
    }
}