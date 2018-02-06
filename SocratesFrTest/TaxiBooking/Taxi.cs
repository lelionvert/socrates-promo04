namespace SocratesFrTest.TaxiBooking
{
    public class Taxi
    {
        private int seats;

        public Taxi(int seats)
        {
            this.seats = seats;
        }

        public static Taxi CreateTaxi(int seats)
        {
            return new Taxi(seats);
        }

        public override bool Equals(object obj)
        {
            var taxi = obj as Taxi;
            return taxi != null &&
                   seats == taxi.seats;
        }

        public override int GetHashCode()
        {
            return -2114979927 + seats.GetHashCode();
        }
    }
}