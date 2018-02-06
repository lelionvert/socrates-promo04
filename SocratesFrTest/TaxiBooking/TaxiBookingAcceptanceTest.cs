using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFluent;
using NUnit.Framework;

namespace SocratesFrTest.TaxiBooking
{
    public class TaxiBookingAcceptanceTest
    {
        [Test]
        public void Taxi_Booking_Acceptance_Test_With_No_Checkin()
        {
            List<DateTime> checkins = new List<DateTime>();

            Taxis taxiBooking = Taxis.Builder()
                .With4Seats(12)
                .With6Seats(6)
                .With8Seats(1)
                .Build();
            var taxiNeeded = taxiBooking.TaxiNeeded(checkins);

            Check.That(taxiNeeded).IsEmpty();
        }

        [Test]
        public void Taxi_Booking_Acceptance_Test()
        {
            List<DateTime> checkins = new List<DateTime>()
            {
                CreateDateTime(12, 00),
                CreateDateTime(12, 00),
                CreateDateTime(12, 00),
            };

            Taxis taxis = CreateTaxis();
            var taxiNeeded = taxis.TaxiNeeded(checkins);

            Check.That(taxiNeeded).ContainsKey(CreateDateTime(12, 00));
            Check.That(taxiNeeded[CreateDateTime(12, 00)]).HasFirstElement();
            Check.That(taxiNeeded[CreateDateTime(12, 00)].First()).IsEqualTo(Taxi.CreateTaxi(4));
        }

        private static DateTime CreateDateTime(int hour, int minute)
        {
            return new DateTime(2018, 01, 01, hour, minute, 00);
        }

        private Taxis CreateTaxis()
        {
            return Taxis.Builder()
                .With4Seats(12)
                .With6Seats(6)
                .With8Seats(1)
                .Build();
        }
    }

    public class Taxis
    {

        public static TaxisBuilder Builder()
        {
            throw new NotImplementedException();
        }

        public class TaxisBuilder
        {
            public TaxisBuilder With4Seats(int numberOfTaxi)
            {
                throw new NotImplementedException();
            }

            public TaxisBuilder With6Seats(int numberOfTaxi)
            {
                throw new NotImplementedException();
            }
            public TaxisBuilder With8Seats(int numberOfTaxi)
            {
                throw new NotImplementedException();
            }

            public Taxis Build()
            {
                throw new NotImplementedException();
            }
        }

        public Dictionary<DateTime,List<Taxi>> TaxiNeeded(List<DateTime> checkins)
        {
            return new Dictionary<DateTime, List<Taxi>>();
        }
    }
}
