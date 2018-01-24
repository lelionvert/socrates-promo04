import java.time.LocalDateTime;
import java.util.Calendar;

/**
 * Created by lenovo_3 on 23/01/2018.
 */
public class MealsCalculator {
    private static final int DINNER_HOUR = 21;
    private static final int LUNCH_HOUR = 12;
    public static final int MAX_MEALS_NUMBER = 6;
    private final LocalDateTime firstMeal;
    private final LocalDateTime lastMeal;
    private final int mandatoryMeals;

    public MealsCalculator(LocalDateTime firstMeal, LocalDateTime lastMeal, int mandatoryMeals) {
        this.firstMeal = firstMeal;
        this.lastMeal = lastMeal;
        this.mandatoryMeals = mandatoryMeals;
    }

    public static int calculate(Calendar checkin, Calendar checkout) {
        int mealsNumber = MAX_MEALS_NUMBER;
        if(checkin.get(Calendar.HOUR_OF_DAY) > DINNER_HOUR || checkin.get(Calendar.AM_PM) == Calendar.AM){
            mealsNumber--;
        }
        if(checkout.get(Calendar.HOUR_OF_DAY) < LUNCH_HOUR){
            mealsNumber--;
        }
        return mealsNumber;
    }

    public int calculate(CheckTime checkIn, CheckTime checkOut){
        if(checkIn.isBefore(firstMeal)) return 6;
        return 5;
    }
}
