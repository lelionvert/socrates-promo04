import main.java.Checkin;
import main.java.Checkout;
import main.java.MinimumMealException;

/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculator {
    private static final double MEAL_PRICE = 40;

    public double calculatePrice(Accommodation accommodation, Checkin checkin, Checkout checkout) {
        int mealsNotTaken = checkin.getMealsNotTaken() + checkout.getMealsNotTaken();
        return accommodation.price() - mealsNotTaken * MEAL_PRICE;
    }
}
