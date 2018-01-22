﻿using System;
using System.Collections.Generic;
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
    }
}
