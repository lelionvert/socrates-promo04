package fr.lacombe.socratesfr;

/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculator {

    private final int mealsPrice;

    public PriceCalculator(int mealsPrice) {
        this.mealsPrice = mealsPrice;
    }

    public int calculate(Accommodation accommodation, int mealsNotTakenNumber) {
        return accommodation.price() - mealsNotTakenNumber * mealsPrice;
    }
}
