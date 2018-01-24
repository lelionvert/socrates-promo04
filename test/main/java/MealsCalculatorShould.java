import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.LocalDateTime;
import java.util.Calendar;

import static org.assertj.core.api.Assertions.assertThat;

/**
 * Created by lenovo_3 on 23/01/2018.
 */
public class MealsCalculatorShould {

    private Calendar createCalendar(String date){
        SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy:h a");
        Calendar calendar = Calendar.getInstance();
        try {
            calendar.setTime(sdf.parse(date));
        } catch (ParseException e) {
            e.printStackTrace();
        }
        return calendar;
    }

    private MealsCalculator mealsCalculator;

    @BeforeEach
    void setUp() {
        LocalDateTime firstMeal = LocalDateTime.parse("2018-01-25T21:00:00");
        LocalDateTime lastMeal = LocalDateTime.parse("2018-01-28T12:00:00");
        mealsCalculator = new MealsCalculator(firstMeal, lastMeal, 4);
    }

    @Test
    public void giveMaxMealNumber() {
        Calendar checkin = createCalendar("25/01/2018:2 PM");
        Calendar checkout = createCalendar("28/01/2018:2 PM");
        int mealsNumber = MealsCalculator.calculate(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(MealsCalculator.MAX_MEALS_NUMBER);
    }

    @Test
    public void giveMaxMealNumber2() {
        CheckTime checkin = CheckTime.parse("2018-01-25T14:00:00");
        CheckTime checkout = CheckTime.parse("2018-01-28T14:00:00");
        int mealsNumber = mealsCalculator.calculate(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(MealsCalculator.MAX_MEALS_NUMBER);
    }

    @Test
    public void giveMealsNumberWithoutThursdayDinner(){
        Calendar checkin = createCalendar("26/01/2018:10 AM");
        Calendar checkout = createCalendar("28/01/2018:2 PM");
        int mealsNumber = MealsCalculator.calculate(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(MealsCalculator.MAX_MEALS_NUMBER-1);
    }

    @Test
    public void giveMealsNumberWithtoutThursdayDinnerAndSundayLunch(){
        Calendar checkin = createCalendar("26/01/2018:10 AM");
        Calendar checkout = createCalendar("28/01/2018:10 AM");
        int mealsNumber = MealsCalculator.calculate(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(MealsCalculator.MAX_MEALS_NUMBER-2);
    }

    @Test
    public void giveMealsNumberWhenCheckinAfterThursdayDinner(){
        Calendar checkin = createCalendar("25/01/2018:10 PM");
        Calendar checkout = createCalendar("28/01/2018:2 PM");
        int mealsNumber = MealsCalculator.calculate(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(MealsCalculator.MAX_MEALS_NUMBER-1);
    }

    @Test
    public void giveMealsNumberWhenCheckinAfterThursdayDinner2(){
        CheckTime checkin = CheckTime.parse("2018-01-25T22:00:00");
        CheckTime checkout = CheckTime.parse("2018-01-28T14:00:00");
        int mealsNumber = mealsCalculator.calculate(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(MealsCalculator.MAX_MEALS_NUMBER-1);
    }
}