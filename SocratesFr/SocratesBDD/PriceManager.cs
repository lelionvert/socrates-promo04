using System;
using System.Collections.Generic;

namespace SocratesFr.SocratesBDD
{
    public class PriceManager
    {
        private Dictionary<string, double> productPriceDictionnary = new Dictionary<string, double>()
        {
            {"SINGLE", 370 },
            {"DOUBLE", 270 },
            {"TRIPLE", 170 },
            {"NO_ACCOMMODATION", 0 },
            {"MEAL", 40 }
        };
        public double GetProductPrice(string productKey)
        {
            if (productPriceDictionnary.ContainsKey(productKey))
                return productPriceDictionnary[productKey];
            else
            {
                return -1;
            }
        }
    }
}