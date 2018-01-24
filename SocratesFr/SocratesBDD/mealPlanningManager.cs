using System;
using System.Collections.Generic;

namespace SocratesFr.SocratesBDD
{
    public class MealPlanningManager
    {
        private Dictionary<string, int> mealOrganisationDictionnary = new Dictionary<string, int>()
        {
            {"MEAL_MANDATORY", 4 },
            {"HOUR_OF_AFTERNOON_MEAL", 12 },
            {"HOUR_OF_NIGHT_MEAL", 21 },
            {"DAY_BEGIN_SOCRATES", (int)DayOfWeek.Thursday},
            {"DAY_END_SOCRATES", (int)DayOfWeek.Sunday}
        };

        private const int MEAL_MANDATORY = 4;    

        public int GetMealOrganisation(string organisationKey)
        {
            if (mealOrganisationDictionnary.ContainsKey(organisationKey))
                return mealOrganisationDictionnary[organisationKey];
            return -1;
        }

        public int GetMealMandatory()
        {
            return MEAL_MANDATORY;
        }

        public DateTimeOffset GetFirstMeal()
        {
            return new DateTimeOffset(new DateTime(2018, 01, 25, 21, 0, 0));
        }

        public (DateTimeOffset endSocrates, TimeSpan afternoonMeal) GetSocratesEndDate()
        {
            return (new DateTimeOffset(new DateTime(2018, 01, 25, 9, 0, 0)), new TimeSpan(12, 0, 0));
        }
    }
}