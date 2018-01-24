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
            double totalPrice = 0;
            int nbMealsTaken = mealCalculator.NumberOfMealTaken(checkin, checkout);
            switch (accommodation)
            {
                case Accommodation.SINGLE:
                    totalPrice = CalculatePriceWithNMeal(priceManager.GetProductPrice(Accommodation.SINGLE.ToString()), nbMealsTaken);
                    break;
                case Accommodation.DOUBLE:
                    totalPrice = CalculatePriceWithNMeal(priceManager.GetProductPrice(Accommodation.DOUBLE.ToString()), nbMealsTaken);
                    break;
                case Accommodation.TRIPLE:
                    totalPrice = CalculatePriceWithNMeal(priceManager.GetProductPrice(Accommodation.TRIPLE.ToString()), nbMealsTaken);
                    break;
                case Accommodation.NO_ACCOMMODATION:
                    totalPrice = CalculatePriceWithNMeal(priceManager.GetProductPrice(Accommodation.NO_ACCOMMODATION.ToString()), nbMealsTaken);
                    break;
                default:
                    throw new InvalidEnumArgumentException("Please select one of the four room price.");
            }

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