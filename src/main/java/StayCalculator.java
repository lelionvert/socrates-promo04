import java.time.LocalDateTime;

public class StayCalculator {

    MealsCalculator mealsCalculator;

    public StayCalculator(MealsCalculator mealsCalculator) {
        this.mealsCalculator = mealsCalculator;
    }

    public int calculate(CheckTime checkin, CheckTime checkout, Accommodation room) {
        int mealsNumber = mealsCalculator.calculate(checkin, checkout);
            return PriceCalculator.calculatePrice(room,mealsNumber);
    }
}
