package fr.lacombe.socratesfr;

import java.util.List;

public class MealChoices {

    public static int calculateNumberOfVegetarianMeals(List<Diet> diets, Meal tuesdayDinner){
        return (int) diets.stream().filter(Diet.VEGETARIAN::equals).count();
    }

    public int calculateNumberOfCovers(Diet vegetarian, Meal fridayLunch) {
        return 0;
    }
}
