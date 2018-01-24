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
        mealsCalculator = new MealsCalculator(firstMeal, lastMeal, 4);
    }

    @Test
    public void giveMaxMealNumber() {
        CheckTime checkin = CheckTime.parse("2018-01-25T14:00:00");
        CheckTime checkout = CheckTime.parse("2018-01-28T14:00:00");
        int mealsNumber = mealsCalculator.calculate(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(6);
    }

    @Test
    public void giveMealsNumberWithoutThursdayDinner(){
        CheckTime checkin = CheckTime.parse("2018-01-25T14:00:00");
        CheckTime checkout = CheckTime.parse("2018-01-28T10:00:00");
        int mealsNumber = mealsCalculator.calculate(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(5);
    }

    @Test
    public void giveMealsNumberWithtoutThursdayDinnerAndSundayLunch(){
        CheckTime checkin = CheckTime.parse("2018-01-26T10:00:00");
        CheckTime checkout = CheckTime.parse("2018-01-28T10:00:00");
        int mealsNumber = mealsCalculator.calculate(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(4);
    }

    @Test
    public void giveMealsNumberWhenCheckinAfterThursdayDinner(){
        CheckTime checkin = CheckTime.parse("2018-01-25T22:00:00");
        CheckTime checkout = CheckTime.parse("2018-01-28T14:00:00");
        int mealsNumber = mealsCalculator.calculate(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(5);
    }
}