using NFluent;
using NUnit.Framework;
using SocratesFr;

namespace SocratesFrTest
{
    public class CoversCalculatorTest
    {
        [Test]
        public void Various_Diets_Should_Gives_Two_Vegan_Covers()
        {
            Diets diets = new Diets();
            diets.Add(Diet.VEGAN);
            diets.Add(Diet.VEGAN);
            diets.Add((Diet.VEGETARIAN));
            diets.Add(Diet.DEFAULT);
            diets.Add(Diet.PESCATARIAN);
            Check.That(diets.CountBy(Diet.VEGAN)).IsEqualTo(2);
        }

        
    }

    
        
}
