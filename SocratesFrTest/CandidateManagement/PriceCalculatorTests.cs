using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using NUnit.Framework;
using NFluent;
using SocratesFr.CandidateManagement;

namespace SocratesFrTest.CandidateManagement
{
    public class PriceCalculatorTests
    {
        [Test]
        public void Get_Price_For_Single_Room()
        {
            var priceCalculator = new PriceCalculator();
            int price = priceCalculator.CalculatePrice(PriceCalculator.Accommodation.SINGLE, CreateDateTimeOffset(25, 9), CreateDateTimeOffset(28, 18));
            Check.That(price).Equals(610);
        }

        [Test]
        public void Get_Price_For_Double_Room()
        {
            var package = new PriceCalculator(PriceCalculator.Accommodation.DOUBLE, CreateDateTimeOffset(25, 9), CreateDateTimeOffset(28, 18));
            Check.That(package.Price).Equals(510);
        }

        [Test]
        public void Get_Price_For_Triple_Room()
        {
            var package = new PriceCalculator(PriceCalculator.Accommodation.TRIPLE, CreateDateTimeOffset(25, 9), CreateDateTimeOffset(28, 18));
            Check.That(package.Price).Equals(410);
        }

        [Test]
        public void Get_Price_For_No_Accomodation_Room()
        {
            var package = new PriceCalculator(PriceCalculator.Accommodation.NO_ACCOMODATION, CreateDateTimeOffset(25, 9), CreateDateTimeOffset(28, 18));
            Check.That(package.Price).Equals(240);
        }

        [Test]
        public void Get_Price_For_Unknown_Selection()
        { 
            Check.ThatCode(() => new PriceCalculator((PriceCalculator.Accommodation)int.MaxValue, CreateDateTimeOffset(25, 9), CreateDateTimeOffset(28, 18))).Throws<InvalidEnumArgumentException>();
        }

        [Test]
        public void Get_Price_For_Single_Room_Without_One_Meal_Checkin_Friday_Chekout_Sunday()
        {
            var package = new PriceCalculator(PriceCalculator.Accommodation.SINGLE, CreateDateTimeOffset(26, 9), CreateDateTimeOffset(28, 18));
            Check.That(package.Price).Equals(570);
        }

        [Test]
        public void Get_Price_For_Double_Room_Without_One_Meal_Checkin_Friday_Chekout_Sunday()
        {
            var package = new PriceCalculator(PriceCalculator.Accommodation.DOUBLE, CreateDateTimeOffset(26, 9), CreateDateTimeOffset(28, 18));
            Check.That(package.Price).Equals(470);
        }

        [Test]
        public void Get_Price_For_Triple_Room_Without_One_Meal_Checkin_Friday_Chekout_Sunday()
        {
            var package = new PriceCalculator(PriceCalculator.Accommodation.TRIPLE, CreateDateTimeOffset(26, 9), CreateDateTimeOffset(28, 18));
            Check.That(package.Price).Equals(370);
        }

        [Test]
        public void Get_Price_For_No_Accomodation_Room_Without_One_Meal_Checkin_Friday_Chekout_Sunday()
        {
            var package = new PriceCalculator(PriceCalculator.Accommodation.NO_ACCOMODATION, CreateDateTimeOffset(26, 9), CreateDateTimeOffset(28, 18));
            Check.That(package.Price).Equals(200);
        }

        private DateTimeOffset CreateDateTimeOffset(int day, int hour)
        {
            return new DateTimeOffset(new DateTime(2018, 01, day, hour, 0, 0));
        }
    }
}
