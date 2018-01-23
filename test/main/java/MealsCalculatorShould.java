import org.junit.Test;

import java.text.ParseException;
import java.text.SimpleDateFormat;
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

    @Test
    public void giveMaxMealNumber() {
        Calendar checkin = createCalendar("25/01/2018:2 PM");
        Calendar checkout = createCalendar("28/01/2018:2 PM");
        int mealsNumber = MealsCalculator.calculate(checkin,checkout);
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
}