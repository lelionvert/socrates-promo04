namespace SocratesFr.CandidateManagement
{
    public class Package
    {
        private Room room;
        private int mealsNumber;

        public enum Room
        {
            SINGLE = 0,
            DOUBLE,
            TRIPLE
        }

        public Package(Room roomType, int mealsNumber)
        {
            this.room = roomType;
            this.mealsNumber = mealsNumber;
            Price = 610;
        }

        public object Price { get; private set; }
    }
}