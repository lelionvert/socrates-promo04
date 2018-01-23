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
            var package = new PriceCalculator(PriceCalculator.Accomodation.SINGLE, DayOfWeek.Thursday, DayOfWeek.Sunday);
            Check.That(package.Price).Equals(610);
        }

        [Test]
        public void Get_Price_For_Double_Room()
        {
            var package = new PriceCalculator(PriceCalculator.Accomodation.DOUBLE, DayOfWeek.Thursday, DayOfWeek.Sunday);
            Check.That(package.Price).Equals(510);
        }

        [Test]
        public void Get_Price_For_Triple_Room()
        {
            var package = new PriceCalculator(PriceCalculator.Accomodation.TRIPLE, DayOfWeek.Thursday, DayOfWeek.Sunday);
            Check.That(package.Price).Equals(410);
        }

        [Test]
        public void Get_Price_For_No_Accomodation_Room()
        {
            var package = new PriceCalculator(PriceCalculator.Accomodation.NO_ACCOMODATION, DayOfWeek.Thursday, DayOfWeek.Sunday);
            Check.That(package.Price).Equals(240);
        }

        [Test]
        public void Get_Price_For_Unknown_Selection()
        { 
            Check.ThatCode(() => new PriceCalculator((PriceCalculator.Accomodation)int.MaxValue, DayOfWeek.Thursday, DayOfWeek.Sunday)).Throws<InvalidEnumArgumentException>();
        }

        [Test]
        public void Get_Price_For_Single_Room_Without_One_Meal_Checkin_Friday_Chekout_Sunday()
        {
            var package = new PriceCalculator(PriceCalculator.Accomodation.SINGLE, DayOfWeek.Friday, DayOfWeek.Sunday);
            Check.That(package.Price).Equals(570);
        }

        [Test]
        public void Get_Price_For_Double_Room_Without_One_Meal_Checkin_Friday_Chekout_Sunday()
        {
            var package = new PriceCalculator(PriceCalculator.Accomodation.DOUBLE, DayOfWeek.Friday, DayOfWeek.Sunday);
            Check.That(package.Price).Equals(470);
        }

        [Test]
        public void Get_Price_For_Triple_Room_Without_One_Meal_Checkin_Friday_Chekout_Sunday()
        {
            var package = new PriceCalculator(PriceCalculator.Accomodation.TRIPLE, DayOfWeek.Friday, DayOfWeek.Sunday);
            Check.That(package.Price).Equals(370);
        }

        [Test]
        public void Get_Price_For_No_Accomodation_Room_Without_One_Meal_Checkin_Friday_Chekout_Sunday()
        {
            var package = new PriceCalculator(PriceCalculator.Accomodation.NO_ACCOMODATION, DayOfWeek.Friday, DayOfWeek.Sunday);
            Check.That(package.Price).Equals(200);
        }
    }
}
