package fr.lacombe.socratesfr;

import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.List;

import static org.junit.Assert.*;

public class MealDataShould {
    @Test
    public void calculateNumberOfDietMealsWithOneVegetarianMealOnTuesday() {
        Diet diet= Diet.VEGETARIAN;
        Meal tuesdayDinner = Meal.THURSDAY_DINNER;
        MealData mealData = new MealData();
        int numberOfVegetarianMeals= mealData.calculateNumberOfVegetarianMeals(diet, tuesdayDinner);
        assertEquals(1, numberOfVegetarianMeals);
    }

    @Test
    public void toto() {
        List<Diet> diets = new ArrayList<>();
        diets.add(Diet.VEGETARIAN);
        diets.add(Diet.VEGETARIAN);
        Meal tuesdayDinner = Meal.THURSDAY_DINNER;
        MealData mealData = new MealData();
        int numberOfVegetarianMeals= mealData.calculateNumberOfVegetarianMeals(diets, tuesdayDinner);
        assertEquals(2, numberOfVegetarianMeals);
    }

}