package fr.lacombe.socratesfr;

public class StayCalculator {

    MealsCalculator mealsCalculator;

    public StayCalculator(MealsCalculator mealsCalculator) {
        this.mealsCalculator = mealsCalculator;
    }

    public int calculate(Stay stay) {
        int mealsNumber = mealsCalculator.calculate(stay.getCheckin(), stay.getCheckout());
            return PriceCalculator.calculatePrice(stay.getRoom(),mealsNumber);
    }


}
