using System.Collections.Generic;
using NFluent;
using NUnit.Framework;
using SocratesFr.PriceCalculation;

namespace SocratesFrTest.PriceCalculation
{
    public class PriceManagerTest
    {
        [Test]
        public void Get_Accomodation_Single_Price()
        {
            PriceManager priceManager = new PriceManager();

            var price = priceManager.GetProductPrice(Product.SINGLE);

            Check.That(price).IsEqualTo(370);
        }

        [Test]
        public void Get_Accomodation_Double_Price()
        {
            PriceManager priceManager = new PriceManager();

            var price = priceManager.GetProductPrice(Product.DOUBLE);

            Check.That(price).IsEqualTo(270);
        }

        [Test]
        public void Ask_Wrong_Product_Key()
        {
            PriceManager priceManager = new PriceManager();

            Check.ThatCode(() => priceManager.GetProductPrice((Product)int.MaxValue)).Throws<KeyNotFoundException>();
        }
    }
}
