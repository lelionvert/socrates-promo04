using NFluent;
using NUnit.Framework;
using SocratesFr;

namespace SocratesFrTest
{
    public class CoversCalculatorTest
    {
        [Test]
        public void Two_Vegan_And_One_Vegetarian_Diet_Should_Gives_Two_Vegan_Covers()
        {
            Diets diets = new Diets();
            diets.Add(Diet.VEGAN);
            diets.Add(Diet.VEGAN);
            diets.Add((Diet.VEGETARIAN));
            Check.That(diets.CountBy(Diet.VEGAN)).IsEqualTo(2);
        }

        
    }

    
        
}
