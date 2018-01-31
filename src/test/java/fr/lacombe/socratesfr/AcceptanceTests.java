package fr.lacombe.socratesfr;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

import java.util.HashMap;
import java.util.Map;

public class AcceptanceTests {

    @Test
    public void CountingCoversByDietAcceptanceTest() {
        MealChoices mealChoices = new MealChoices();

        mealChoices.add(new MealChoice(Meal.THURSDAY_DINNER, Diet.PESCATARIAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_DINNER, Diet.VEGAN));
        mealChoices.add(new MealChoice(Meal.SATURDAY_LUNCH, Diet.DEFAULT));
        mealChoices.add(new MealChoice(Meal.SATURDAY_DINNER, Diet.VEGAN));
        mealChoices.add(new MealChoice(Meal.SUNDAY_LUNCH, Diet.VEGETARIAN));

        mealChoices.add(new MealChoice(Meal.THURSDAY_DINNER, Diet.DEFAULT));
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_DINNER, Diet.VEGAN));
        mealChoices.add(new MealChoice(Meal.SATURDAY_LUNCH, Diet.VEGAN));
        mealChoices.add(new MealChoice(Meal.SATURDAY_DINNER, Diet.PESCATARIAN));

        mealChoices.add(new MealChoice(Meal.THURSDAY_DINNER, Diet.VEGAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_DINNER, Diet.PESCATARIAN));
        mealChoices.add(new MealChoice(Meal.SATURDAY_LUNCH, Diet.DEFAULT));
        mealChoices.add(new MealChoice(Meal.SATURDAY_DINNER, Diet.VEGAN));
        mealChoices.add(new MealChoice(Meal.SUNDAY_LUNCH, Diet.DEFAULT));

        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.PESCATARIAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_DINNER, Diet.VEGAN));
        mealChoices.add(new MealChoice(Meal.SATURDAY_LUNCH, Diet.DEFAULT));
        mealChoices.add(new MealChoice(Meal.SATURDAY_DINNER, Diet.VEGAN));
        mealChoices.add(new MealChoice(Meal.SUNDAY_LUNCH, Diet.VEGETARIAN));

        mealChoices.add(new MealChoice(Meal.FRIDAY_LUNCH, Diet.VEGETARIAN));
        mealChoices.add(new MealChoice(Meal.FRIDAY_DINNER, Diet.DEFAULT));
        mealChoices.add(new MealChoice(Meal.SATURDAY_LUNCH, Diet.DEFAULT));
        mealChoices.add(new MealChoice(Meal.SATURDAY_DINNER, Diet.DEFAULT));
        mealChoices.add(new MealChoice(Meal.SUNDAY_LUNCH, Diet.DEFAULT));

        Assertions.assertEquals(1,mealChoices.calculateNumberOfCovers(Meal.THURSDAY_DINNER,Diet.PESCATARIAN));
        Assertions.assertEquals(2,mealChoices.calculateNumberOfCovers(Meal.FRIDAY_LUNCH,Diet.VEGAN));
        Assertions.assertEquals(1,mealChoices.calculateNumberOfCovers(Meal.FRIDAY_DINNER,Diet.DEFAULT));
        Assertions.assertEquals(0,mealChoices.calculateNumberOfCovers(Meal.SATURDAY_LUNCH,Diet.VEGETARIAN));
        Assertions.assertEquals(3,mealChoices.calculateNumberOfCovers(Meal.SATURDAY_DINNER,Diet.VEGAN));
        Assertions.assertEquals(2,mealChoices.calculateNumberOfCovers(Meal.SUNDAY_LUNCH,Diet.VEGETARIAN));

    }
}
