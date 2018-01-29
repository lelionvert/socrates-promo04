using NFluent;
using NUnit.Framework;
using SocratesFr;

namespace SocratesFrTest
{
    public class DietCalculatorTest
    {
        [Test]
        public void No_Vegetarian_Diet_To_Prepare()
        {
            Diets diets = new Diets();
            var countVegetarian = diets.CountVegetarian();
            Check.That(countVegetarian).IsEqualTo(0);
        }

        [Test]
        public void One_Vegetarian_Diet()
        {
            Diets diets = new Diets();
            diets.Add(Diet.VEGETARIAN);
            var countVegetarian = diets.CountVegetarian();
            Check.That(countVegetarian).IsEqualTo(1);
        }

        [Test]
        public void One__Diet()
        {
            Diets diets = new Diets();
            diets.Add(Diet.VEGAN);
            var countVegetarian = diets.countVegan();
            Check.That(countVegetarian).IsEqualTo(1);
        }

        
    }

    
        
}
