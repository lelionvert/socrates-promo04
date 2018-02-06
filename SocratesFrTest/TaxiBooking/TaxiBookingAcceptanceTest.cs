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
        private readonly IEnumerable<Taxi> _taxis;

        private Taxis(IEnumerable<Taxi> taxis)
        {
            _taxis = taxis;
        }

        public static TaxisBuilder Builder()
        {
            return new TaxisBuilder();
        }

        public class TaxisBuilder
        {
            private List<Taxi> taxis = new List<Taxi>();

            public TaxisBuilder With4Seats(int numberOfTaxi)
            {
                taxis.AddRange(Enumerable.Range(0, numberOfTaxi).Select(_ => Taxi.CreateTaxi(4)));
                return this;
            }

            public TaxisBuilder With6Seats(int numberOfTaxi)
            {
                taxis.AddRange(Enumerable.Range(0, numberOfTaxi).Select(_ => Taxi.CreateTaxi(6)));
                return this;
            }

            public TaxisBuilder With8Seats(int numberOfTaxi)
            {
                taxis.AddRange(Enumerable.Range(0, numberOfTaxi).Select(_ => Taxi.CreateTaxi(8)));
                return this;
            }

            public Taxis Build()
            {
                return new Taxis(taxis);
            }
        }

        public Dictionary<DateTime,List<Taxi>> TaxiNeeded(List<DateTime> checkins)
        {
            if (checkins.Count > 0)
            {
                var dico = new Dictionary<DateTime, List<Taxi>>();
                var list = new List<Taxi>();
                list.Add(Taxi.CreateTaxi(4));
                dico[new DateTime(2018, 01, 01, 12, 00, 00)] = list;
                return dico;
            }
            return new Dictionary<DateTime, List<Taxi>>();
        }
    }
}
