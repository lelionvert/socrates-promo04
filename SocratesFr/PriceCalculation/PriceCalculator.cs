using System;
using System.ComponentModel;
using SocratesFr.CandidateManagement;
using SocratesFr.SocratesBDD;

namespace SocratesFr.PriceCalculation{
    public class PriceCalculator
    {
        private NumberOfMealCalculator mealCalculator;
        private PriceManager priceManager;
        private string MEAL_PRODUCT_KEY = "MEAL";

        public enum Accommodation
        {
            SINGLE = 0,
            DOUBLE,
            TRIPLE,
            NO_ACCOMMODATION
        }

        public PriceCalculator()
        {            
            this.priceManager = new PriceManager();
            this.mealCalculator = new NumberOfMealCalculator(new MealPlanningManager());
        }
      
        public double CalculatePrice(Accommodation accommodation, DateTimeOffset checkin, DateTimeOffset checkout)
        {
            int nbMealsTaken = mealCalculator.NumberOfMealTaken(checkin, checkout);
            
            var totalPrice = CalculatePriceWithNMeal(priceManager.GetProductPrice(accommodation.ToString()), nbMealsTaken);
                   

            return totalPrice;
        }

        private double CalculatePriceWithNMeal(double roomPrice, int nMeal)
        {
            double mealPrice = priceManager.GetProductPrice(MEAL_PRODUCT_KEY);
            return roomPrice + (nMeal * mealPrice);
        }

        public double Price { get; private set; }
    }
}