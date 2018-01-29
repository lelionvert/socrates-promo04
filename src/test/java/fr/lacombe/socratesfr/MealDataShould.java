package fr.lacombe.socratesfr;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.*;

public class MealDataTest {
    @Test
    public void name() {
        Diet diet= Diet.VEGETARIAN;
        Meal tuesdayDinner = Meal.TUESDAY_DINNER;
        MealData mealData = new MealData();
        int numberOfVegetarianMeals= mealData.calculateNumberOfVegetarianMeals(diet, tuesdayDinner);
        assertEquals(1, numberOfVegetarianMeals);
    }
}