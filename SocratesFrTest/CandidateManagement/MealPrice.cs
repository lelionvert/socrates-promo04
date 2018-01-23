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
            if (arrivalTime.DayOfWeek == DayOfWeek.Thursday && departureTime.DayOfWeek == DayOfWeek.Sunday && departureTime.Hour > 12)
                return 0;
            return 1;
        }
    }
}