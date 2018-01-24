using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using NUnit.Framework;
using SocratesFr.SocratesBDD;

namespace SocratesFrTest.SocratesBDD
{
    public class PriceManagerTest
    {
        [Test]
        public void Get_Accomodation_Single_Price()
        {
            PriceManager priceManager = new PriceManager();

            var price = priceManager.GetProductPrice("SINGLE");

            Check.That(price).IsEqualTo(370);
        }
    }
}
