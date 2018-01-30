package fr.lacombe.socratesfr;

import java.util.List;

public class MealChoices {

    private int vegetarianCovers = 0;
    private int vegeThursdayCovers;
    private int veganCovers;

    public static int calculateNumberOfVegetarianMeals(List<Diet> diets, Meal tuesdayDinner) {
        return (int) diets.stream().filter(Diet.VEGETARIAN::equals).count();
    }

    public int calculateNumberOfCovers(Diet diet, Meal meal) {
        if (diet == Diet.VEGAN) return veganCovers;
        if(meal == Meal.THURSDAY_DINNER) return vegeThursdayCovers;
        return vegetarianCovers;
    }

    public void add(Diet diet, Meal meal) {
        if ((meal == Meal.FRIDAY_LUNCH)&& (diet == Diet.VEGETARIAN))
            vegetarianCovers++;
        else if (meal == Meal.THURSDAY_DINNER){
            vegeThursdayCovers++;
        } else {
                veganCovers++;
        }
    }
}
