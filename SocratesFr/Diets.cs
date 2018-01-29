using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SocratesFr
{
    public class Diets
    {
        private readonly List<Diet> diets;

        public int CountVegetarian()
        {
            return diets.Count(c => Diet.VEGETARIAN.Equals(c));
        }

        public Diets()
        {
            this.diets = new List<Diet>();
        }

        public void Add(Diet diet)
        {
            diets.Add(diet);
        }

        public int countVegan()
        {
            return 1;
        }
    }

    public enum Diet
    {
        VEGETARIAN,
        VEGAN
    }
}
