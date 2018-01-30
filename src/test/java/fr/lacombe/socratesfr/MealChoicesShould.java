package fr.lacombe.socratesfr;

import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.List;

import static org.junit.Assert.assertEquals;

public class MealChoicesShould {
    @Test
    public void calculateNumberOfDietMealsWithOneVegetarianMealOnThursday() {
        List<Diet> diets = new ArrayList<>();
        diets.add(Diet.VEGETARIAN);
        Meal thursdayDinner = Meal.THURSDAY_DINNER;
        MealChoices mealChoices = new MealChoices();
        int numberOfVegetarianMeals = mealChoices.calculateNumberOfVegetarianMeals(diets, thursdayDinner);
        assertEquals(1, numberOfVegetarianMeals);
    }

    @Test
    public void calculateNumberOfDietMealsWithTwoVegetarianMealsOnThursday() {
        List<Diet> diets = new ArrayList<>();
        diets.add(Diet.VEGETARIAN);
        diets.add(Diet.VEGETARIAN);
        Meal thursdayDinner = Meal.THURSDAY_DINNER;
        MealChoices mealChoices = new MealChoices();
        int numberOfVegetarianMeals = mealChoices.calculateNumberOfVegetarianMeals(diets, thursdayDinner);
        assertEquals(2, numberOfVegetarianMeals);
    }

    @Test
    public void calculateNumberOfDietMealsWithOneVegetarianMealOutOfTwoMealsOnThursday() {
        List<Diet> diets = new ArrayList<>();
        diets.add(Diet.VEGETARIAN);
        diets.add(Diet.VEGAN);
        Meal thursdayDinner = Meal.THURSDAY_DINNER;
        MealChoices mealChoices = new MealChoices();
        int numberOfVegetarianMeals = mealChoices.calculateNumberOfVegetarianMeals(diets, thursdayDinner);
        assertEquals(1, numberOfVegetarianMeals);
    }

    @Test
    public void giveZeroCoversWhenNoDietChoiceForFridayLunch() {
        MealChoices mealChoices = new MealChoices();
        int numberOfVegetarianMeals = mealChoices.calculateNumberOfCovers(Diet.VEGETARIAN, Meal.FRIDAY_LUNCH);
        assertEquals(0, numberOfVegetarianMeals);
    }

    @Test
    public void giveOneCoverWhenOneVegetarianDietForFridayLunch() {
        MealChoices mealChoices = new MealChoices();
        mealChoices.add(Diet.VEGETARIAN, Meal.FRIDAY_LUNCH);
        int numberOfVegetarianMeals = mealChoices.calculateNumberOfCovers(Diet.VEGETARIAN, Meal.FRIDAY_LUNCH);
        assertEquals(1, numberOfVegetarianMeals);
    }

    @Test
    public void giveOneVeganCoverWhenTwoVegetarianDietsAndOneVeganDietForFridayLunch() {
        MealChoices mealChoices = new MealChoices();
        mealChoices.add(Diet.VEGETARIAN, Meal.FRIDAY_LUNCH);
        mealChoices.add(Diet.VEGETARIAN, Meal.FRIDAY_LUNCH);
        mealChoices.add(Diet.VEGAN, Meal.FRIDAY_LUNCH);
        int numberOfVeganMeals = mealChoices.calculateNumberOfCovers(Diet.VEGAN, Meal.FRIDAY_LUNCH);
        assertEquals(1, numberOfVeganMeals);
    }

    @Test
    public void giveOneCoverWhenOneVegetarianDietAndOneVeganDietForFridayLunch() {
        MealChoices mealChoices = new MealChoices();
        mealChoices.add(Diet.VEGETARIAN, Meal.FRIDAY_LUNCH);
        mealChoices.add(Diet.VEGAN, Meal.FRIDAY_LUNCH);
        int numberOfVegetarianMeals = mealChoices.calculateNumberOfCovers(Diet.VEGETARIAN, Meal.FRIDAY_LUNCH);
        assertEquals(1, numberOfVegetarianMeals);
    }

    @Test
    public void giveOneCoverWhenTwoVegetarianDietAndOneVeganDietForFridayLunch() {
        MealChoices mealChoices = new MealChoices();
        mealChoices.add(Diet.VEGETARIAN, Meal.FRIDAY_LUNCH);
        mealChoices.add(Diet.VEGETARIAN, Meal.FRIDAY_LUNCH);
        mealChoices.add(Diet.VEGAN, Meal.FRIDAY_LUNCH);
        int numberOfVegetarianMeals = mealChoices.calculateNumberOfCovers(Diet.VEGETARIAN, Meal.FRIDAY_LUNCH);
        assertEquals(2, numberOfVegetarianMeals);
    }

    @Test
    public void giveTwoVegetarianCoversForFridayLunchWhenAlsoOneVegetarianForThursdayDinner() {
        MealChoices mealChoices = new MealChoices();
        mealChoices.add(Diet.VEGETARIAN, Meal.FRIDAY_LUNCH);
        mealChoices.add(Diet.VEGETARIAN, Meal.FRIDAY_LUNCH);
        mealChoices.add(Diet.VEGETARIAN, Meal.THURSDAY_DINNER);
        mealChoices.add(Diet.VEGAN, Meal.FRIDAY_LUNCH);
        int numberOfVegetarianMeals = mealChoices.calculateNumberOfCovers(Diet.VEGETARIAN, Meal.FRIDAY_LUNCH);
        assertEquals(2, numberOfVegetarianMeals);
    }

    @Test
    public void giveOneVegetarianCoverForThursdayDinnerWhenMultipleMealChoices() {
        MealChoices mealChoices = new MealChoices();
        mealChoices.add(Diet.VEGETARIAN, Meal.FRIDAY_LUNCH);
        mealChoices.add(Diet.VEGETARIAN, Meal.FRIDAY_LUNCH);
        mealChoices.add(Diet.VEGETARIAN, Meal.THURSDAY_DINNER);
        mealChoices.add(Diet.VEGAN, Meal.FRIDAY_LUNCH);
        int numberOfVegetarianMeals = mealChoices.calculateNumberOfCovers(Diet.VEGETARIAN, Meal.THURSDAY_DINNER);
        assertEquals(1, numberOfVegetarianMeals);
    }



}