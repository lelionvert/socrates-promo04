import java.util.Calendar;

/**
 * Created by lenovo_3 on 23/01/2018.
 */
public class MealsCalculator {
    public static int calculate(Calendar c, Calendar c2) {
        if (c.get(Calendar.DAY_OF_WEEK) == Calendar.FRIDAY) {
            return 5;
        }
        return 6;
    }
}
