import java.util.Calendar;

/**
 * Created by lenovo_3 on 23/01/2018.
 */
public class MealsCalculator {
    private static final int DINNER_HOUR = 21;
    private static final int LUNCH_HOUR = 12;


    public static int calculate(Calendar checkin, Calendar checkout) {
        int mealsNumber = 6;
        if(checkin.get(Calendar.HOUR_OF_DAY) > DINNER_HOUR){
            mealsNumber--;
        }
        if(checkout.get(Calendar.HOUR_OF_DAY) < LUNCH_HOUR){
            mealsNumber--;
        }
        if(checkout.get(Calendar.AM_PM) == Calendar.AM) return 4;
        if (checkin.get(Calendar.DAY_OF_WEEK) == Calendar.FRIDAY) {
            return 5;
        }
        return mealsNumber;
    }
}
