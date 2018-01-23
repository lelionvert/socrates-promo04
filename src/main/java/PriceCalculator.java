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
        if (checkin == Checkin.AFTER_FIRST_MEAL && checkout == Checkout.BEFORE_LAST_MEAL)
            return 530;
        if (checkin == Checkin.AFTER_FIRST_MEAL)
            return 370;
        if (checkout == Checkout.BEFORE_LAST_MEAL)
            return 200;
        return 510;
    }
}
