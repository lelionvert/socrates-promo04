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

    public int calculate(CheckTime checkin, CheckTime checkout){
        int mealsNumber = mandatoryMeals;
        if(checkin.isBefore(firstMeal)) mealsNumber++;
        if(!checkout.isBefore(lastMeal)) mealsNumber++;
        return mealsNumber;
    }
}
