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
            Diets diets = CreateDiets(new Meal(MealTime.FRIDAY_LUNCH, Diet.PESCATARIAN),
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

            Check.That(diets.CountDietFor(MealTime.FRIDAY_LUNCH,Diet.PESCATARIAN)).IsEqualTo(1);
            Check.That(diets.CountDietFor(MealTime.FRIDAY_LUNCH,Diet.VEGETARIAN)).IsEqualTo(3);
            Check.That(diets.CountDietFor(MealTime.FRIDAY_LUNCH,Diet.DEFAULT)).IsEqualTo(1);
            Check.That(diets.CountDietFor(MealTime.FRIDAY_LUNCH,Diet.VEGAN)).IsEqualTo(0);
            Check.That(diets.CountDietFor(MealTime.THURSDAY_EVENING,Diet.VEGETARIAN)).IsEqualTo(1);
            Check.That(diets.CountDietFor(MealTime.THURSDAY_EVENING,Diet.DEFAULT)).IsEqualTo(1);
            Check.That(diets.CountDietFor(MealTime.FRIDAY_EVENING, Diet.DEFAULT)).IsEqualTo(1);
            Check.That(diets.CountDietFor(MealTime.SATURDAY_LUNCH, Diet.DEFAULT)).IsEqualTo(1);
            Check.That(diets.CountDietFor(MealTime.SUNDAY_LUNCH, Diet.DEFAULT)).IsEqualTo(1);
            Check.That(diets.CountDietFor(MealTime.SUNDAY_LUNCH, Diet.VEGETARIAN)).IsEqualTo(2);
            Check.That(diets.CountDietFor(MealTime.FRIDAY_LUNCH, Diet.DEFAULT)).IsEqualTo(1);
            Check.That(diets.CountDietFor(MealTime.SATUDRAY_EVENING, Diet.DEFAULT)).IsEqualTo(1);

        }

        private Diets CreateDiets(params Meal[] meals)
        {
            Diets diets = new Diets();
            foreach (Meal meal in meals)
            {
                diets.Add(meal);
            }

            return diets;
        }
    }
}
