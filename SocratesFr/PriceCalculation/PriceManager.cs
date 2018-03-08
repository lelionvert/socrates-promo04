using System.Collections.Generic;

namespace SocratesFr.PriceCalculation
{
    public class PriceManager
    {
        private Dictionary<Accommodation, double> accommodationPriceDictionary = new Dictionary<Accommodation, double>()
        {
            {Accommodation.SINGLE, 370 },
            {Accommodation.DOUBLE, 270 },
            {Accommodation.TRIPLE, 170 },
            {Accommodation.NO_ACCOMMODATION, 0 },
        };

        private double mealPrice = 40;

        public double MealPrice { get => mealPrice; private set => mealPrice = value; }

        public double GetAccommodationPrice(Accommodation accommodationKey)
        {
            if (accommodationPriceDictionary.ContainsKey(accommodationKey))
                return accommodationPriceDictionary[accommodationKey];
            throw new KeyNotFoundException();
        }
    }

}