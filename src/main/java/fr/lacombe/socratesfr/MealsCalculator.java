package fr.lacombe.socratesfr;

import java.time.LocalDateTime;

public class MealsCalculator {
    private final LocalDateTime firstMeal;
    private final LocalDateTime lastMeal;

    public MealsCalculator(LocalDateTime firstMeal, LocalDateTime lastMeal) {
        this.firstMeal = firstMeal;
        this.lastMeal = lastMeal;
    }

    public int numberMealsNotTaken(CheckTime checkin, CheckTime checkout){
        int mealsNotTaken = 0;
        if(!checkin.isBefore(firstMeal)) mealsNotTaken++;
        if(checkout.isBefore(lastMeal)) mealsNotTaken++;
        return mealsNotTaken;
    }
}
