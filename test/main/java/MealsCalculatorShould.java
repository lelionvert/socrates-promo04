import org.assertj.core.api.Assertions;
import org.junit.Before;
import org.junit.Test;
import sun.java2d.pipe.SpanShapeRenderer;

import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

import static org.junit.Assert.*;

/**
 * Created by lenovo_3 on 23/01/2018.
 */
public class MealsCalculatorShould {

    @Test
    public void giveMealNumberWhenCheckinThursdayAndCheckoutSundayAfter14PM() {
        Calendar c = Calendar.getInstance();
        c.add(Calendar.THURSDAY,1);
        c.add(Calendar.HOUR,14);
        Calendar c2 = Calendar.getInstance();
        c2.setTime(new Date());
        c2.add(Calendar.SUNDAY,1);
        c2.add(Calendar.HOUR_OF_DAY,14);
        int mealsNumber = MealsCalculator.calculate(c,c2);
        Assertions.assertThat(mealsNumber).isEqualTo(6);
    }
}