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
            double roomPrice = priceManager.GetProductPrice(accommodation);

            var totalPrice = CalculatePriceWithNMeal(roomPrice, nbMealsTaken);


            return totalPrice;
        }

        private double CalculatePriceWithNMeal(double roomPrice, int nMeal)
        {
            double mealPrice = priceManager.GetProductPrice(Product.MEAL);
            return roomPrice + (nMeal * mealPrice);
        }

        public double Price { get; private set; }
    }
}