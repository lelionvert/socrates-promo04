namespace SocratesFr.CandidateManagement
{
    public class Room
    {
        private RoomType roomType;

        public enum RoomType
        {
            SINGLE = 0,
            DOUBLE,
            TRIPLE
        }

        public Room(RoomType room)
        {
            this.roomType = room;
            if (room == RoomType.SINGLE)
                Price = 610;
            else if(room == RoomType.DOUBLE)
                Price = 510;
            else
            {
                Price = 410;
            }
        }

        public object Price { get; private set; }
    }
}