using NFluent;
using NUnit.Framework;
using SocratesFr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SocratesFr;

namespace SocratesFrTest
{
    public class DietCalculatorTest
    {
        [Test]
        public void When_No_Vegetarian_Participant_Return_0()
        {
            Diets diets = new Diets();
            Check.That(diets.CountVegetarian()).IsEqualTo(0);
        }
    }

    
        
}
