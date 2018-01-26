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
      
        public double CalculatePrice(Product accommodation, DateTimeOffset checkin, DateTimeOffset checkout)
        {
            int nbMealsTaken = mealCalculator.NumberOfMealTaken(checkin, checkout);
            double accommodationPrice = priceManager.GetProductPrice(accommodation);
            double mealPrice = priceManager.GetProductPrice(Product.MEAL);

            var totalPrice = accommodationPrice + (nbMealsTaken * mealPrice); ;


            return totalPrice;
        }
    }
}