using System;
using System.ComponentModel;
using SocratesFr.CandidateManagement;
using SocratesFr.SocratesBDD;

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

            var totalPrice = CalculatePriceWithNMeal(accommodationPrice, nbMealsTaken);


            return totalPrice;
        }

        private double CalculatePriceWithNMeal(double accommodationPrice, int nMeal)
        {
            double mealPrice = priceManager.GetProductPrice(Product.MEAL);
            return accommodationPrice + (nMeal * mealPrice);
        }

        public double Price { get; private set; }
    }
}