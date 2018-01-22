namespace SocratesFr.CandidateManagement
{
    public class Room
    {
        private RoomType roomType;
        private int mealsNumber;

        public enum RoomType
        {
            SINGLE = 0,
            DOUBLE,
            TRIPLE
        }

        public Room(RoomType room, int mealsNumber)
        {
            this.roomType = room;
            this.mealsNumber = mealsNumber;
            if (room == RoomType.SINGLE)
                Price = 610;
            else
                Price = 510;
        }

        public object Price { get; private set; }
    }
}