using System;
using System.Collections.Generic;

namespace SocratesFr.SocratesBDD
{
    public class MealPlanningManager
    {
        private Dictionary<string, int> mealOrganisationDictionnary = new Dictionary<string, int>()
        {
            {"MEAL_MANDATORY", 4 },
        };
        public int GetMealOrganisation(string organisationKey)
        {
            return 4;
        }
    }
}