/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculator {
    public static int calculatePrice(Accommodation accommodation, int mealsNumber) {
        if(5==mealsNumber) return accommodation.price() + 200;
        return accommodation.price() + 240;
    }
}
