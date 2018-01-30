package fr.lacombe.socratesfr;

import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.List;

import static org.junit.Assert.*;

public class MealChoicesShould {
    @Test
    public void calculateNumberOfDietMealsWithOneVegetarianMealOnThursday() {
        List<Diet> diets = new ArrayList<>();
        diets.add(Diet.VEGETARIAN);
        Meal thursdayDinner = Meal.THURSDAY_DINNER;
        MealChoices mealChoices = new MealChoices();
        int numberOfVegetarianMeals= mealChoices.calculateNumberOfVegetarianMeals(diets, thursdayDinner);
        assertEquals(1, numberOfVegetarianMeals);
    }

    @Test
    public void calculateNumberOfDietMealsWithTwoVegetarianMealsOnThursday() {
        List<Diet> diets = new ArrayList<>();
        diets.add(Diet.VEGETARIAN);
        diets.add(Diet.VEGETARIAN);
        Meal thursdayDinner = Meal.THURSDAY_DINNER;
        MealChoices mealChoices = new MealChoices();
        int numberOfVegetarianMeals= mealChoices.calculateNumberOfVegetarianMeals(diets, thursdayDinner);
        assertEquals(2, numberOfVegetarianMeals);
    }

    @Test
    public void calculateNumberOfDietMealsWithOneVegetarianMealOutOfTwoMealsOnThursday() {
        List<Diet> diets = new ArrayList<>();
        diets.add(Diet.VEGETARIAN);
        diets.add(Diet.VEGAN);
        Meal thursdayDinner = Meal.THURSDAY_DINNER;
        MealChoices mealChoices = new MealChoices();
        int numberOfVegetarianMeals= mealChoices.calculateNumberOfVegetarianMeals(diets, thursdayDinner);
        assertEquals(1, numberOfVegetarianMeals);
    }

    @Test
    public void giveZeroCoversWhenNoDietChoiceHasBeenMadeForFridayLunch() {
        MealChoices mealChoices = new MealChoices();
        int numberOfVegetarianMeals= mealChoices.calculateNumberOfCovers(Diet.VEGETARIAN, Meal.FRIDAY_LUNCH);
        assertEquals(0, numberOfVegetarianMeals);
    }



}