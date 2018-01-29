package fr.lacombe.socratesfr;

import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.List;

import static org.junit.Assert.*;

public class MealDataShould {
    @Test
    public void calculateNumberOfDietMealsWithOneVegetarianMealOnThursday() {
        List<Diet> diets = new ArrayList<>();
        diets.add(Diet.VEGETARIAN);
        Meal tuesdayDinner = Meal.THURSDAY_DINNER;
        MealData mealData = new MealData();
        int numberOfVegetarianMeals= mealData.calculateNumberOfVegetarianMeals(diets, tuesdayDinner);
        assertEquals(1, numberOfVegetarianMeals);
    }

    @Test
    public void calculateNumberOfDietMealsWithTwoVegetarianMealsOnThursday() {
        List<Diet> diets = new ArrayList<>();
        diets.add(Diet.VEGETARIAN);
        diets.add(Diet.VEGETARIAN);
        Meal tuesdayDinner = Meal.THURSDAY_DINNER;
        MealData mealData = new MealData();
        int numberOfVegetarianMeals= mealData.calculateNumberOfVegetarianMeals(diets, tuesdayDinner);
        assertEquals(2, numberOfVegetarianMeals);
    }

    @Test
    public void calculateNumberOfDietMealsWithOneVegetarianMealOutOfTwoMealsOnThursday() {
        List<Diet> diets = new ArrayList<>();
        diets.add(Diet.VEGETARIAN);
        diets.add(Diet.VEGAN);
        Meal tuesdayDinner = Meal.THURSDAY_DINNER;
        MealData mealData = new MealData();
        int numberOfVegetarianMeals= mealData.calculateNumberOfVegetarianMeals(diets, tuesdayDinner);
        assertEquals(1, numberOfVegetarianMeals);
    }

}