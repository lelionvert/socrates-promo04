using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SocratesFr
{
    public class Diets
    {
        private readonly List<Diet> diets;

        public int CountBy(Diet diet)
        {
            return diets.Count(c => diet.Equals(c));
        }

        public Diets()
        {
            this.diets = new List<Diet>();
        }

        public void Add(Diet diet)
        {
            diets.Add(diet);
        }

        public int CountFor(DateTime mealTime)
        {
            return 0;
        }
    }

    public enum Diet
    {
        VEGETARIAN,
        VEGAN,
        PESCATARIAN,
        DEFAULT
    }
}
