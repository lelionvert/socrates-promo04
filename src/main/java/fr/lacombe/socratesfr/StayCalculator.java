package fr.lacombe.socratesfr;

public class StayCalculator {

    private final MealsCalculator mealsCalculator;
    private final PriceCalculator priceCalculator;


    public StayCalculator(MealsCalculator mealsCalculator, PriceCalculator priceCalculator) {
        this.mealsCalculator = mealsCalculator;
        this.priceCalculator = priceCalculator;
    }

    public int calculate(Stay stay) {
        int mealsNumber = mealsCalculator.calculate(stay.getCheckin(), stay.getCheckout());
            return priceCalculator.calculate(stay.getRoom(),mealsNumber);
    }


}
