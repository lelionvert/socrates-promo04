package fr.lacombe.socratesfr;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;


public class MealChoicesShould {
    @Test
    public void giveZeroCoversWhenNoMealChoice() {
        MealChoices mealChoices = new MealChoices();
        int numberOfVegetarianMeals = mealChoices.calculateNumberOfCovers(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN);
        assertEquals(0, numberOfVegetarianMeals);
    }

    @Test
    public void giveOneVeganCoverWhenTwoVegetarianDietsAndOneVeganDietForSameMeal() {
        MealChoices mealChoices = new MealChoices();
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGAN));
        int numberOfVeganMeals = mealChoices.calculateNumberOfCovers(Meal.FRIDAY_LUNCH, Diet.VEGAN);
        assertEquals(1, numberOfVeganMeals);
    }

    @Test
    public void giveTwoVegetarianCoversForFridayLunchWhenMealChoicesForOtherMeal() {
        MealChoices mealChoices = new MealChoices();
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN));
        mealChoices.add(new MealChoice(Meal.THURSDAY_DINNER, Diet.VEGETARIAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGAN));
        int numberOfVegetarianMeals = mealChoices.calculateNumberOfCovers(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN);
        assertEquals(2, numberOfVegetarianMeals);
    }

    @Test
    public void giveOneVegetarianCoverForThursdayDinnerWhenMultipleMealChoices() {
        MealChoices mealChoices = new MealChoices();
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN));
        mealChoices.add(new MealChoice(Meal.THURSDAY_DINNER, Diet.VEGETARIAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGAN));
        int numberOfVegetarianMeals = mealChoices.calculateNumberOfCovers(Meal.THURSDAY_DINNER, Diet.VEGETARIAN);
        assertEquals(1, numberOfVegetarianMeals);
    }
}