package fr.lacombe.socratesfr;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;

import static org.assertj.core.api.Assertions.assertThat;

public class MealsCalculatorShould {

    private MealsCalculator mealsCalculator;

    @BeforeEach
    void setUp() {
        LocalDateTime firstMeal = LocalDateTime.parse("2018-01-25T21:00:00");
        LocalDateTime lastMeal = LocalDateTime.parse("2018-01-28T12:00:00");
        mealsCalculator = new MealsCalculator(firstMeal, lastMeal);
    }

    @Test
    public void giveMinMealNotTakenNumber() {
        CheckTime checkin = CheckTime.parse("2018-01-25T14:00:00");
        CheckTime checkout = CheckTime.parse("2018-01-28T14:00:00");
        int mealsNumber = mealsCalculator.numberMealsNotTaken(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(0);
    }

    @Test
    public void giveMealsNotTakenNumberWithoutThursdayDinner(){
        CheckTime checkin = CheckTime.parse("2018-01-25T14:00:00");
        CheckTime checkout = CheckTime.parse("2018-01-28T10:00:00");
        int mealsNumber = mealsCalculator.numberMealsNotTaken(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(1);
    }

    @Test
    public void giveMealsNotTakenNumberWithtoutThursdayDinnerAndSundayLunch(){
        CheckTime checkin = CheckTime.parse("2018-01-26T10:00:00");
        CheckTime checkout = CheckTime.parse("2018-01-28T10:00:00");
        int mealsNumber = mealsCalculator.numberMealsNotTaken(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(2);
    }

    @Test
    public void giveMealsNotTakenNumberWhenCheckinAfterThursdayDinner(){
        CheckTime checkin = CheckTime.parse("2018-01-25T22:00:00");
        CheckTime checkout = CheckTime.parse("2018-01-28T14:00:00");
        int mealsNumber = mealsCalculator.numberMealsNotTaken(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(1);
    }
}