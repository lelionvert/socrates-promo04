import main.java.CheckInDeadline;
import main.java.Checkout;
import main.java.MinimumMealException;

/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculator {
    private static final double DEFAULT_MEAL_PRICE = 40;
    private final double mealPrice;

    public PriceCalculator(double mealPrice) {
        this.mealPrice = mealPrice;
    }

    public PriceCalculator() {
        this(DEFAULT_MEAL_PRICE);
    }

    public double calculatePrice(Accommodation accommodation, CheckInDeadline checkInDeadline, Checkout checkout) {
        int mealsNotTaken = checkInDeadline.getMealsNotTaken() + checkout.getMealsNotTaken();
        return accommodation.price() - mealsNotTaken * mealPrice;
    }
}
