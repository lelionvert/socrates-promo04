package fr.lacombe.socratesfr;

import java.util.List;

public class MealData {

    public static int calculateNumberOfVegetarianMeals(List<Diet> diets, Meal tuesdayDinner){
        return (int) diets.stream().filter(Diet.VEGETARIAN::equals).count();
    }
}
