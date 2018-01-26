using System;
using System.Collections.Generic;
using System.ComponentModel;
using NFluent;
using NUnit.Framework;
using SocratesFr.CandidateManagement;
using SocratesFr.PriceCalculation;

namespace SocratesFrTest.PriceCalculation
{
    public class PriceCalculatorTests
    {
        [Test]
        public void Get_Price_For_Single_Room()
        {
            var priceCalculator = new PriceCalculator();
            double price = priceCalculator.CalculatePrice(Product.SINGLE, CreateDateTimeOffset(25, 9), CreateDateTimeOffset(28, 18));
            Check.That(price).Equals(610);
        }

        [Test]
        public void Get_Price_For_Double_Room()
        {
            var priceCalculator = new PriceCalculator();
            double price = priceCalculator.CalculatePrice(Product.DOUBLE, CreateDateTimeOffset(25, 9), CreateDateTimeOffset(28, 18));
            Check.That(price).Equals(510);
        }

        [Test]
        public void Get_Price_For_Triple_Room()
        {
            var priceCalculator = new PriceCalculator();
            double price = priceCalculator.CalculatePrice(Product.TRIPLE, CreateDateTimeOffset(25, 9), CreateDateTimeOffset(28, 18));
            Check.That(price).Equals(410);
        }

        [Test]
        public void Get_Price_For_No_Accomodation_Room()
        {
            var priceCalculator = new PriceCalculator();
            double price = priceCalculator.CalculatePrice(Product.NO_ACCOMMODATION, CreateDateTimeOffset(25, 9), CreateDateTimeOffset(28, 18));
            Check.That(price).Equals(240);
        }

        [Test]
        public void Get_Price_For_Unknown_Selection()
        {
            var priceCalculator = new PriceCalculator();            
            Check.ThatCode<double>(() => priceCalculator.CalculatePrice((Product)int.MaxValue, CreateDateTimeOffset(25, 9), CreateDateTimeOffset(28, 18))).Throws<KeyNotFoundException>();
        }

        [Test]
        public void Get_Price_For_Single_Room_Without_One_Meal_Checkin_Friday_Chekout_Sunday()
        {
            var priceCalculator = new PriceCalculator();
            double price = priceCalculator.CalculatePrice(Product.SINGLE, CreateDateTimeOffset(26, 9), CreateDateTimeOffset(28, 18));
            Check.That(price).Equals(570);
        }

        [Test]
        public void Get_Price_For_Double_Room_Without_One_Meal_Checkin_Friday_Chekout_Sunday()
        {
            var priceCalculator = new PriceCalculator();
            double price = priceCalculator.CalculatePrice(Product.DOUBLE, CreateDateTimeOffset(26, 9), CreateDateTimeOffset(28, 18));
            Check.That(price).Equals(470);
        }

        [Test]
        public void Get_Price_For_Triple_Room_Without_One_Meal_Checkin_Friday_Chekout_Sunday()
        {
            var priceCalculator = new PriceCalculator();
            double price = priceCalculator.CalculatePrice(Product.TRIPLE, CreateDateTimeOffset(26, 9), CreateDateTimeOffset(28, 18));
            Check.That(price).Equals(370);
        }

        [Test]
        public void Get_Price_For_No_Accomodation_Room_Without_One_Meal_Checkin_Friday_Chekout_Sunday()
        {
            var priceCalculator = new PriceCalculator();
            double price = priceCalculator.CalculatePrice(Product.NO_ACCOMMODATION, CreateDateTimeOffset(26, 9), CreateDateTimeOffset(28, 18));
            Check.That(price).Equals(200);
        }

        private DateTimeOffset CreateDateTimeOffset(int day, int hour)
        {
            return new DateTimeOffset(new DateTime(2018, 01, day, hour, 0, 0));
        }
    }
}
