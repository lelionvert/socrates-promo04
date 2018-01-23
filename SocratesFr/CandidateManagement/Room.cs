using System;

namespace SocratesFr.CandidateManagement
{
    public class Room
    {
        private RoomType roomType;

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
                    break;
            }
        }

        public object Price { get; private set; }
    }
}