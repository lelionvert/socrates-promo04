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

        public PriceCalculator(Accommodation accommodation, DateTimeOffset arrivalDate, DateTimeOffset departureDate)
        {
            this.accomodation = accommodation;
            this.mealCalculator = new NumberOfMealCalculator(arrivalDate, departureDate);
            int nbmealsNotTaken = mealCalculator.NumberOfMealNotTaken();
            switch (accomodation)
            {
                case Accommodation.SINGLE:
                    Price = CalculatePriceWithoutNMeal(610, nbmealsNotTaken);
                    break;
                case Accommodation.DOUBLE:
                    Price = CalculatePriceWithoutNMeal(510, nbmealsNotTaken);
                    break;
                case Accommodation.TRIPLE:
                    Price = CalculatePriceWithoutNMeal(410, nbmealsNotTaken);
                    break;
                case Accommodation.NO_ACCOMODATION:
                    Price = CalculatePriceWithoutNMeal(240, nbmealsNotTaken);
                    break;
                default:
                    throw new InvalidEnumArgumentException("Please select one of the four room price.");
            }
        }

        private int CalculatePriceWithoutNMeal(int roomPrice, int nMeal)
        {
            return roomPrice - (nMeal * 40);
        }

        public object Price { get; private set; }
    }
}