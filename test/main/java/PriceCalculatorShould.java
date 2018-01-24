
import main.java.Checkin;
import main.java.Checkout;
import main.java.MinimumMealException;
import org.junit.Test;

import static org.assertj.core.api.Assertions.*;


/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculatorShould {
    @Test
    public void computeCompletePrice() {
        double price = PriceCalculator.calculatePrice(Accommodation.DOUBLE, Checkin.BEFORE_FIRST_MEAL, Checkout.AFTER_LAST_MEAL);
        assertThat(price).isEqualTo(510);
    }

    @Test
    public void computePriceWithoutFirstMeal() {
        double price = PriceCalculator.calculatePrice(Accommodation.TRIPLE, Checkin.AFTER_FIRST_MEAL, Checkout.AFTER_LAST_MEAL);
        assertThat(price).isEqualTo(370);
    }

    @Test
    public void computePriceWithoutLastMeal() {
        double price = PriceCalculator.calculatePrice(Accommodation.NONE, Checkin.BEFORE_FIRST_MEAL, Checkout.BEFORE_LAST_MEAL);
        assertThat(price).isEqualTo(200);
    }

    @Test
    public void computePriceWithoutFirstAndLastMeal() {
        double price = PriceCalculator.calculatePrice(Accommodation.SINGLE, Checkin.AFTER_FIRST_MEAL, Checkout.BEFORE_LAST_MEAL);
        assertThat(price).isEqualTo(530);
    }
}