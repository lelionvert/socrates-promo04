/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculator {
    private static final int mealPrice = 40;

    public static int calculatePrice(Accommodation accommodation) {
        return calculatePrice(accommodation, 0);
    }

    public static int calculatePrice(Accommodation accommodation, int mealsNotTaken) {
        if (mealsNotTaken == 1)
            return accommodation.price() - mealPrice;
        return accommodation.price();
    }
}
