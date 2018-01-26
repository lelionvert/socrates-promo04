package fr.lacombe.socratesfr;

import java.time.LocalDateTime;

public class MealsCalculator {
    private final LocalDateTime firstMeal;
    private final LocalDateTime lastMeal;
    private final int mandatoryMeals;

    public MealsCalculator(LocalDateTime firstMeal, LocalDateTime lastMeal, int mandatoryMeals) {
        this.firstMeal = firstMeal;
        this.lastMeal = lastMeal;
        this.mandatoryMeals = mandatoryMeals;
    }

    public int numberMealTotal(CheckTime checkin, CheckTime checkout){
        int mealsNumber = mandatoryMeals;
        if(checkin.isBefore(firstMeal)) mealsNumber++;
        if(!checkout.isBefore(lastMeal)) mealsNumber++;
        return mealsNumber;
    }

    public int numberMealsNotTaken(CheckTime checkin, CheckTime checkout){
        int mealsNotTaken = 0;
        if(!checkin.isBefore(firstMeal)) mealsNotTaken++;
        if(checkout.isBefore(lastMeal)) mealsNotTaken++;
        return mealsNotTaken;
    }
}
