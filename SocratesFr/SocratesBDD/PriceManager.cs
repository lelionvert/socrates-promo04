using System;
using System.Collections.Generic;

namespace SocratesFr.SocratesBDD
{
    public class PriceManager
    {
        private Dictionary<string, double> productPriceDictionnary = new Dictionary<string, double>()
        {
            {"SINGLE", 370 }
        };
        public double GetProductPrice(string productKey)
        {
            return 370;
        }
    }
}