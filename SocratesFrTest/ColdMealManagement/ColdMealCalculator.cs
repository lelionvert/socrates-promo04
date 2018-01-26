using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace SocratesFrTest.ColdMealManagement
{
    public class ColdMealCalculator
    {
        public int Calculate(IList<DateTime> checkIns )
        {
            if (checkIns == null || checkIns.Count == 0)
                return 0;
            return checkIns.Count;
        }
    }
}