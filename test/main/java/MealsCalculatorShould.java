import org.assertj.core.api.Assertions;
import org.junit.Test;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

import static org.assertj.core.api.Assertions.*;

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
    public void giveMealNumberWhenCheckinThursdayAndCheckoutSundayAt2PM() {
        Calendar checkin = createCalendar("25/01/2018:2 PM");
        Calendar checkout = createCalendar("28/01/2018:2 PM");
        int mealsNumber = MealsCalculator.calculate(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(6);
    }

    @Test
    public void giveMealNumberWhenCheckinFridayAt10AMAndCheckoutSundayAt2PM(){
        Calendar checkin = createCalendar("26/01/2018:10 AM");
        Calendar checkout = createCalendar("28/01/2018:2 PM");
        int mealsNumber = MealsCalculator.calculate(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(5);
    }

    @Test
    public void giveMealNumberWhenCheckinFridayAt10AMAndCheckoutSundayAt10AM(){
        Calendar checkin = createCalendar("26/01/2018:2 PM");
        Calendar checkout = createCalendar("28/01/2018:10 AM");
        int mealsNumber = MealsCalculator.calculate(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(4);
    }

    @Test
    public void giveMealNumberWhenCheckinThursdayAt10PMAndCheckoutSundayAt2PM(){
        Calendar checkin = createCalendar("25/01/2018:10 PM");
        Calendar checkout = createCalendar("28/01/2018:2 PM");
        int mealsNumber = MealsCalculator.calculate(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(5);
    }
}