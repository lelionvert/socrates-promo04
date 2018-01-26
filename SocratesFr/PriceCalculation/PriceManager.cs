using System.Collections.Generic;

namespace SocratesFr.PriceCalculation
{
    public class PriceManager
    {
        private Dictionary<Product, double> productPriceDictionary = new Dictionary<Product, double>()
        {
            {Product.SINGLE, 370 },
            {Product.DOUBLE, 270 },
            {Product.TRIPLE, 170 },
            {Product.NO_ACCOMMODATION, 0 },
            {Product.MEAL, 40 }
        };
       
        public double GetProductPrice(Product productKey)
        {
            if (productPriceDictionary.ContainsKey(productKey))
                return productPriceDictionary[productKey];
            throw new KeyNotFoundException();
        }
    }

    public enum Product
    {
        SINGLE = 0,
        DOUBLE,
        TRIPLE,
        NO_ACCOMMODATION,
        MEAL
    }

}