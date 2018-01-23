import org.assertj.core.api.Assertions;
import org.junit.Test;

import java.util.Calendar;
import java.util.Date;

import static org.assertj.core.api.Assertions.*;

/**
 * Created by lenovo_3 on 23/01/2018.
 */
public class MealsCalculatorShould {

    private Calendar createCalendar(int day, int hour, int am_pm) {
        Calendar calendar = Calendar.getInstance();
        calendar.set(Calendar.DAY_OF_WEEK, day);
        calendar.set(Calendar.HOUR, hour);
        calendar.set(Calendar.AM_PM, am_pm);
        return calendar;
    }

    @Test
    public void giveMealNumberWhenCheckinThursdayAndCheckoutSundayAt2PM() {
        Calendar checkin = createCalendar(Calendar.THURSDAY,2,Calendar.PM);
        Calendar checkout = createCalendar(Calendar.SUNDAY,2,Calendar.PM);
        int mealsNumber = MealsCalculator.calculate(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(6);
    }

    @Test
    public void giveMealNumberWhenCheckinFridayAt10AMAndCheckoutSundayAt2PM() throws Exception {
        Calendar checkin = createCalendar(Calendar.FRIDAY,10,Calendar.AM);
        Calendar checkout = createCalendar(Calendar.SUNDAY,2,Calendar.PM);
        int mealsNumber = MealsCalculator.calculate(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(5);
    }
}