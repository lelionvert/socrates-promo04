import main.java.Checkin;
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

    public double calculatePrice(Accommodation accommodation, Checkin checkin, Checkout checkout) {
        int mealsNotTaken = checkin.getMealsNotTaken() + checkout.getMealsNotTaken();
        return accommodation.price() - mealsNotTaken * mealPrice;
    }
}
