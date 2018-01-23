using System;
using System.ComponentModel;

namespace SocratesFr.CandidateManagement
{
    public class Room
    {
        private RoomType roomType;
        private DayOfWeek arrivalDay;
        private DayOfWeek departureDay;


        public enum RoomType
        {
            SINGLE = 0,
            DOUBLE,
            TRIPLE,
            NO_ACCOMODATION
        }

        public Room(RoomType room, DayOfWeek arrivalDay, DayOfWeek departureDay)
        {
            this.roomType = room;
            this.arrivalDay = arrivalDay;
            this.departureDay = departureDay;

            int nbmealsNotTaken = GetNumberOfMealsNotTaken();
            switch (roomType)
            {
                case RoomType.SINGLE:
                    Price = CalculatePriceWithoutNMeal(610, nbmealsNotTaken);
                    break;
                case RoomType.DOUBLE:
                    Price = CalculatePriceWithoutNMeal(510, nbmealsNotTaken);
                    break;
                case RoomType.TRIPLE:
                    Price = CalculatePriceWithoutNMeal(410, nbmealsNotTaken);
                    break;
                case RoomType.NO_ACCOMODATION:
                    Price = CalculatePriceWithoutNMeal(240, nbmealsNotTaken);
                    break;
                default:
                    throw new InvalidEnumArgumentException("Please select one of the four room price.");
            }
        }

        private int GetNumberOfMealsNotTaken()
        {
            if (this.arrivalDay == DayOfWeek.Friday && this.departureDay == DayOfWeek.Sunday)
                return 1;
            return 0;
        }

        private int CalculatePriceWithoutNMeal(int roomPrice, int nMeal)
        {
            return roomPrice - (nMeal * 40);
        }

        public object Price { get; private set; }
    }
}