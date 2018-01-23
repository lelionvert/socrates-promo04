import org.assertj.core.api.Assertions;
import org.junit.Test;

import java.util.Calendar;
import java.util.Date;

import static org.assertj.core.api.Assertions.*;

/**
 * Created by lenovo_3 on 23/01/2018.
 */
public class MealsCalculatorShould {

    @Test
    public void giveMealNumberWhenCheckinThursdayAndCheckoutSundayAfter14PM() {
        Calendar checkin = Calendar.getInstance();
        checkin.add(Calendar.THURSDAY,1);
        checkin.add(Calendar.HOUR_OF_DAY,14);
        Calendar checkout = Calendar.getInstance();
        checkout.add(Calendar.SUNDAY,1);
        checkout.add(Calendar.HOUR_OF_DAY,14);
        int mealsNumber = MealsCalculator.calculate(checkin,checkout);
        assertThat(mealsNumber).isEqualTo(6);
    }

    @Test
    public void giveMealNumberWhenCheckinFridayAndCheckoutSundayAfter2PM() throws Exception {
        Calendar checkin = Calendar.getInstance();
        checkin.set(Calendar.DAY_OF_WEEK,Calendar.FRIDAY);
        checkin.set(Calendar.HOUR,9);
        Calendar checkout = Calendar.getInstance();
        checkout.set(Calendar.DAY_OF_WEEK,Calendar.SUNDAY);
        checkout.set(Calendar.HOUR,14);
        int mealsNumber = MealsCalculator.calculate(checkin, checkout);
        assertThat(mealsNumber).isEqualTo(5);
    }
}