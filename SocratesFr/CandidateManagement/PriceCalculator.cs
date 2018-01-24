using System;
using System.ComponentModel;

namespace SocratesFr.CandidateManagement{
    public class PriceCalculator
    {
        private Accommodation accomodation;
        private NumberOfMealCalculator mealCalculator;

        public enum Accommodation
        {
            SINGLE = 0,
            DOUBLE,
            TRIPLE,
            NO_ACCOMODATION
        }

        private const int ACCOMMODATION_SINGLE_PRICE = 370;
        private const int ACCOMMODATION_DOUBLE_PRICE = 270;
        private const int ACCOMMODATION_TRIPLE_PRICE = 170;
        private const int NO_ACCOMMODATION_PRICE = 0;

        public PriceCalculator(Accommodation accommodation, DateTimeOffset checkin, DateTimeOffset checkout)
        {
            this.accomodation = accommodation;
            this.mealCalculator = new NumberOfMealCalculator(checkin, checkout);
            int nbMealsTaken = mealCalculator.NumberOfMealTaken();
            switch (accomodation)
            {
                case Accommodation.SINGLE:
                    Price = CalculatePriceWithNMeal(ACCOMMODATION_SINGLE_PRICE, nbMealsTaken);
                    break;
                case Accommodation.DOUBLE:
                    Price = CalculatePriceWithNMeal(ACCOMMODATION_DOUBLE_PRICE, nbMealsTaken);
                    break;
                case Accommodation.TRIPLE:
                    Price = CalculatePriceWithNMeal(ACCOMMODATION_TRIPLE_PRICE, nbMealsTaken);
                    break;
                case Accommodation.NO_ACCOMODATION:
                    Price = CalculatePriceWithNMeal(NO_ACCOMMODATION_PRICE, nbMealsTaken);
                    break;
                default:
                    throw new InvalidEnumArgumentException("Please select one of the four room price.");
            }
        }

        private int CalculatePriceWithNMeal(int roomPrice, int nMeal)
        {
            return roomPrice + (nMeal * 40);
        }

        public double Price { get; private set; }
    }
}