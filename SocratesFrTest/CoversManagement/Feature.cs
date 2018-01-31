using NFluent;
using NUnit.Framework;
using SocratesFr.DietManagement;

namespace SocratesFrTest.DietManagement
{
    public class Feature
    {
        [Test]
        public void Counting_Covers_By_Diets()
        {
            Covers covers = CreateCovers(new Meal(MealTime.FRIDAY_LUNCH, Diet.PESCATARIAN),
                                        new Meal(MealTime.FRIDAY_LUNCH, Diet.VEGETARIAN),
                                        new Meal(MealTime.FRIDAY_LUNCH, Diet.VEGETARIAN),
                                        new Meal(MealTime.FRIDAY_LUNCH, Diet.VEGETARIAN),
                                        new Meal(MealTime.THURSDAY_EVENING, Diet.VEGETARIAN),
                                        new Meal(MealTime.SATUDRAY_EVENING, Diet.DEFAULT),
                                        new Meal(MealTime.SUNDAY_LUNCH, Diet.VEGETARIAN),
                                        new Meal(MealTime.SUNDAY_LUNCH, Diet.VEGETARIAN),
                                        new Meal(MealTime.THURSDAY_EVENING, Diet.DEFAULT),
                                        new Meal(MealTime.FRIDAY_EVENING, Diet.DEFAULT),
                                        new Meal(MealTime.SATURDAY_LUNCH, Diet.DEFAULT),
                                        new Meal(MealTime.SUNDAY_LUNCH, Diet.DEFAULT),
                                        new Meal(MealTime.FRIDAY_LUNCH, Diet.DEFAULT));

            Check.That(covers.CountDietFor(MealTime.FRIDAY_LUNCH,Diet.PESCATARIAN)).IsEqualTo(1);
            Check.That(covers.CountDietFor(MealTime.FRIDAY_LUNCH,Diet.VEGETARIAN)).IsEqualTo(3);
            Check.That(covers.CountDietFor(MealTime.FRIDAY_LUNCH,Diet.DEFAULT)).IsEqualTo(1);
            Check.That(covers.CountDietFor(MealTime.FRIDAY_LUNCH,Diet.VEGAN)).IsEqualTo(0);
            Check.That(covers.CountDietFor(MealTime.THURSDAY_EVENING,Diet.VEGETARIAN)).IsEqualTo(1);
            Check.That(covers.CountDietFor(MealTime.THURSDAY_EVENING,Diet.DEFAULT)).IsEqualTo(1);
            Check.That(covers.CountDietFor(MealTime.FRIDAY_EVENING, Diet.DEFAULT)).IsEqualTo(1);
            Check.That(covers.CountDietFor(MealTime.SATURDAY_LUNCH, Diet.DEFAULT)).IsEqualTo(1);
            Check.That(covers.CountDietFor(MealTime.SUNDAY_LUNCH, Diet.DEFAULT)).IsEqualTo(1);
            Check.That(covers.CountDietFor(MealTime.SUNDAY_LUNCH, Diet.VEGETARIAN)).IsEqualTo(2);
            Check.That(covers.CountDietFor(MealTime.FRIDAY_LUNCH, Diet.DEFAULT)).IsEqualTo(1);
            Check.That(covers.CountDietFor(MealTime.SATUDRAY_EVENING, Diet.DEFAULT)).IsEqualTo(1);

        }

        private Covers CreateCovers(params Meal[] meals)
        {
            Covers diets = new Covers();
            foreach (Meal meal in meals)
            {
                diets.Add(meal);
            }

            return diets;
        }
    }
}
