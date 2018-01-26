using System;
using System.ComponentModel;
using SocratesFr.CandidateManagement;

namespace SocratesFr.PriceCalculation{
    public class PriceCalculator
    {
        private NumberOfMealCalculator mealCalculator;
        private PriceManager priceManager;

        public PriceCalculator()
        {            
            this.priceManager = new PriceManager();
            this.mealCalculator = new NumberOfMealCalculator(new MealPlanningManager());
        }
      
        public double CalculatePrice(Accommodation accommodation, DateTimeOffset checkin, DateTimeOffset checkout)
        {
            int nbMealsTaken = mealCalculator.NumberOfMealTaken(checkin, checkout);
            double accommodationPrice = priceManager.GetAccommodationPrice(accommodation);
            double mealPrice = priceManager.MealPrice;

            var totalPrice = accommodationPrice + (nbMealsTaken * mealPrice); ;


            return totalPrice;
        }
    }
}