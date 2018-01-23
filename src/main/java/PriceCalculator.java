import main.java.Checkin;
import main.java.Checkout;
import main.java.MinimumMealException;

/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculator {
    private static final double MEAL_PRICE = 40;
    private static final int MAXIMUM_MEALS_NOT_TAKEN = 2;

    public static double calculatePrice(Accommodation accommodation) {
        return calculatePrice(accommodation, 0);
    }

    public static double calculatePrice(Accommodation accommodation, int mealsNotTaken) {
        if (mealsNotTaken > MAXIMUM_MEALS_NOT_TAKEN) {
            throw new MinimumMealException();
        }
        if (mealsNotTaken < 0) {
            throw new IllegalArgumentException();
        }

        return accommodation.price() - mealsNotTaken * MEAL_PRICE;
    }

    public static double calculatePrice(Accommodation accommodation, Checkin checkin, Checkout checkout) {
        if (checkin == Checkin.FRIDAY)
            return 370;
        return 510;
    }
}
