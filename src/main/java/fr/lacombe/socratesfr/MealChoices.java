package fr.lacombe.socratesfr;

import java.util.List;

public class MealChoices {

    private int numberOfCovers = 0;

    public static int calculateNumberOfVegetarianMeals(List<Diet> diets, Meal tuesdayDinner){
        return (int) diets.stream().filter(Diet.VEGETARIAN::equals).count();
    }

    public int calculateNumberOfCovers(Diet diet, Meal meal) {
        return numberOfCovers;
    }

    public void add(Diet diet, Meal meal) {
        numberOfCovers=1;
    }
}
