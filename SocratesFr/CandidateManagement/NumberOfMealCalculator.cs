using System;

namespace SocratesFr.CandidateManagement
{
    public class NumberOfMealCalculator
    {
        private DateTimeOffset arrivalTime;
        private DateTimeOffset departureTime;

        public NumberOfMealCalculator(DateTimeOffset arrivalDate, DateTimeOffset departureDate)
        {
            this.arrivalTime = arrivalDate;
            this.departureTime = departureDate;
        }

        public int NumberOfMealTaken()
        {
            if (arrivalTime.DayOfWeek == DayOfWeek.Thursday && departureTime.DayOfWeek == DayOfWeek.Sunday && departureTime.Hour > 12)
                return 6;
            return 5;
        }
    }
}