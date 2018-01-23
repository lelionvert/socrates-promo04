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

        public Room(RoomType room)
        {
            this.roomType = room;

            switch (roomType)
            {
                case RoomType.SINGLE:
                    Price = 610;
                    break;
                case RoomType.DOUBLE:
                    Price = 510;
                    break;
                case RoomType.TRIPLE:
                    Price = 410;
                    break;
                case RoomType.NO_ACCOMODATION:
                    Price = 240;
                    break;
                default:
                    throw new InvalidEnumArgumentException("Please select one of the four room price.");
            }
        }

        public Room(RoomType room, DayOfWeek arrivalDay, DayOfWeek departureDay) : this(room)
        {
            this.roomType = room;
            this.arrivalDay = arrivalDay;
            this.departureDay = departureDay;

            int nbmealsNotTaken = 0;
            if (this.arrivalDay == DayOfWeek.Friday && this.departureDay == DayOfWeek.Sunday)
                nbmealsNotTaken = 1;
            switch (roomType)
            {
                case RoomType.SINGLE:
                    Price = 610 - (nbmealsNotTaken * 40);
                    break;
            }
        }

        public object Price { get; private set; }
    }
}