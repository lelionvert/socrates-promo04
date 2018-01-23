using System;
using System.ComponentModel;

namespace SocratesFr.CandidateManagement{
    public class PriceCalculator
    {
        private Accomodation accomodation;
        private NumberOfMealCalculator mealCalculator;

        public enum Accomodation
        {
            SINGLE = 0,
            DOUBLE,
            TRIPLE,
            NO_ACCOMODATION
        }

        public PriceCalculator(Accomodation room, DateTimeOffset arrivalDate, DateTimeOffset departureDate)
        {
            this.accomodation = room;
            this.mealCalculator = new NumberOfMealCalculator(arrivalDate, departureDate);
            int nbmealsNotTaken = mealCalculator.NumberOfMealNotTaken();
            switch (accomodation)
            {
                case Accomodation.SINGLE:
                    Price = CalculatePriceWithoutNMeal(610, nbmealsNotTaken);
                    break;
                case Accomodation.DOUBLE:
                    Price = CalculatePriceWithoutNMeal(510, nbmealsNotTaken);
                    break;
                case Accomodation.TRIPLE:
                    Price = CalculatePriceWithoutNMeal(410, nbmealsNotTaken);
                    break;
                case Accomodation.NO_ACCOMODATION:
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