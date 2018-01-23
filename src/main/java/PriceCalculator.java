import main.java.MinimumMealException;

/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculator {
    private static final double mealPrice = 40;

    public static double calculatePrice(Accommodation accommodation) {
        return calculatePrice(accommodation, 0);
    }

    public static double calculatePrice(Accommodation accommodation, int mealsNotTaken) {
        if (mealsNotTaken > 2){
            throw new MinimumMealException();
        }
        return accommodation.price() - mealsNotTaken * mealPrice;
    }
}
