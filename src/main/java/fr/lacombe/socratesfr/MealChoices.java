package fr.lacombe.socratesfr;

import java.util.List;

public class MealChoices {

    private int vegetarianCovers = 0;
    private int veganCovers;

    public static int calculateNumberOfVegetarianMeals(List<Diet> diets, Meal tuesdayDinner) {
        return (int) diets.stream().filter(Diet.VEGETARIAN::equals).count();
    }

    public int calculateNumberOfCovers(Diet diet, Meal meal) {
        if (diet == Diet.VEGAN) return veganCovers;
        return vegetarianCovers;
    }

    public void add(Diet diet, Meal meal) {
        if (diet == Diet.VEGETARIAN)
            vegetarianCovers++;
        else {
            veganCovers++;
        }
    }
}
