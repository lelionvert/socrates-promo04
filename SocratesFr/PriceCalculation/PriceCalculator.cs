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
            NO_ACCOMODATION
        }
       
        private const int MEAL_MANDATORY = 4;
        private const int HOUR_OF_AFTERNOON_MEAL = 12;
        private const int HOURS_OF_NIGHT_MEAL = 21;
        private const DayOfWeek DAY_BEGIN_SOCRATES = DayOfWeek.Thursday;
        private const DayOfWeek DAY_END_SOCRATES = DayOfWeek.Sunday;

        public PriceCalculator()
        {
            this.mealCalculator = new NumberOfMealCalculator(MEAL_MANDATORY, HOUR_OF_AFTERNOON_MEAL, DAY_BEGIN_SOCRATES, DAY_END_SOCRATES, HOURS_OF_NIGHT_MEAL);
            this.priceManager = new PriceManager();
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
                case Accommodation.NO_ACCOMODATION:
                    totalPrice = CalculatePriceWithNMeal(priceManager.GetProductPrice(Accommodation.NO_ACCOMODATION.ToString()), nbMealsTaken);
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