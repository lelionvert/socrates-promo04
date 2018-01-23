using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using NUnit.Framework;
using NFluent;
using SocratesFr.CandidateManagement;

namespace SocratesFrTest.CandidateManagement
{
    public class RoomTests
    {
        [Test]
        public void Get_Price_For_Single_Room()
        {
            var package = new Room(Room.RoomType.SINGLE);
            Check.That(package.Price).Equals(610);
        }

        [Test]
        public void Get_Price_For_Double_Room()
        {
            var package = new Room(Room.RoomType.DOUBLE);
            Check.That(package.Price).Equals(510);
        }

        [Test]
        public void Get_Price_For_Triple_Room()
        {
            var package = new Room(Room.RoomType.TRIPLE);
            Check.That(package.Price).Equals(410);
        }

        [Test]
        public void Get_Price_For_No_Accomodation_Room()
        {
            var package = new Room(Room.RoomType.NO_ACCOMODATION);
            Check.That(package.Price).Equals(240);
        }

        [Test]
        public void Get_Price_For_Unknown_Selection()
        {
            var package = 
            Check.ThatCode(() => new Room((Room.RoomType)int.MaxValue)).Throws<InvalidEnumArgumentException>();
        }

        [Test]
        public void Get_Price_For_Single_Room_Without_One_Meal_Checkin_Friday_Chekout_Sunday()
        {
            var package = new Room(Room.RoomType.SINGLE, DayOfWeek.Friday, DayOfWeek.Sunday);
            Check.That(package.Price).Equals(570);
        }
    }
}
