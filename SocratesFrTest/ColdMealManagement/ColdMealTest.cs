using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using NUnit.Framework;

namespace SocratesFrTest.ColdMealManagement
{
    public class ColdMealTest
    {

        [Test]
        public void When_Check_In_At_22()
        {
            ColdMeal coldMeal = new ColdMeal();
            bool isCold = coldMeal.IsCold(new DateTime(2018,1,25,22,0,0));
            Check.That(isCold).IsTrue();
        }
    }
}
