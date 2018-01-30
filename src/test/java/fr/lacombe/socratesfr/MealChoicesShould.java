package fr.lacombe.socratesfr;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

public class MealChoicesShould {
    @Test
    public void giveZeroCoversWhenNoDietChoiceForFridayLunch() {
        MealChoices mealChoices = new MealChoices();
        int numberOfVegetarianMeals = mealChoices.calculateNumberOfCovers(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN);
        assertEquals(0, numberOfVegetarianMeals);
    }

    @Test
    public void giveOneCoverWhenOneVegetarianDietForFridayLunch() {
        MealChoices mealChoices = new MealChoices();
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN));
        int numberOfVegetarianMeals = mealChoices.calculateNumberOfCovers(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN);
        assertEquals(1, numberOfVegetarianMeals);
    }

    @Test
    public void giveOneVeganCoverWhenTwoVegetarianDietsAndOneVeganDietForFridayLunch() {
        MealChoices mealChoices = new MealChoices();
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGAN));
        int numberOfVeganMeals = mealChoices.calculateNumberOfCovers(Meal.FRIDAY_LUNCH, Diet.VEGAN);
        assertEquals(1, numberOfVeganMeals);
    }

    @Test
    public void giveOneCoverWhenOneVegetarianDietAndOneVeganDietForFridayLunch() {
        MealChoices mealChoices = new MealChoices();
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGAN));
        int numberOfVegetarianMeals = mealChoices.calculateNumberOfCovers(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN);
        assertEquals(1, numberOfVegetarianMeals);
    }

    @Test
    public void giveOneCoverWhenTwoVegetarianDietAndOneVeganDietForFridayLunch() {
        MealChoices mealChoices = new MealChoices();
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGAN));
        int numberOfVegetarianMeals = mealChoices.calculateNumberOfCovers(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN);
        assertEquals(2, numberOfVegetarianMeals);
    }

    @Test
    public void giveTwoVegetarianCoversForFridayLunchWhenAlsoOneVegetarianForThursdayDinner() {
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