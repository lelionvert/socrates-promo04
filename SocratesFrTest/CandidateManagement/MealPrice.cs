using System;

namespace SocratesFr.CandidateManagement
{
    public class MealPrice
    {
        private DateTimeOffset arrivalTime;
        private DateTimeOffset departureTime;

        public MealPrice(DateTimeOffset arrivalDate, DateTimeOffset departureDate)
        {
            this.arrivalTime = arrivalDate;
            this.departureTime = departureDate;
        }

        public int NumberOfMealNotTaken()
        {
            return 1;
        }
    }
}