package fr.lacombe.socratesfr;

/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculator {
    public static int calculatePrice(Accommodation accommodation, int mealsNumber) {
        return accommodation.price() + mealsNumber * 40;
    }
}
