
import main.java.Checkin;
import main.java.Checkout;
import main.java.MinimumMealException;
import org.junit.Test;

import static org.assertj.core.api.Assertions.*;


/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculatorShould {
    private PriceCalculator priceCalculator = new PriceCalculator();

    @Test
    public void computeCompletePrice() {
        double price = priceCalculator.calculatePrice(Accommodation.DOUBLE, Checkin.BEFORE_FIRST_MEAL, Checkout.AFTER_LAST_MEAL);
        assertThat(price).isEqualTo(510);
    }

    @Test
    public void computePriceWithoutFirstMeal() {
        double price = priceCalculator.calculatePrice(Accommodation.TRIPLE, Checkin.AFTER_FIRST_MEAL, Checkout.AFTER_LAST_MEAL);
        assertThat(price).isEqualTo(370);
    }

    @Test
    public void computePriceWithoutLastMeal() {
        double price = priceCalculator.calculatePrice(Accommodation.NONE, Checkin.BEFORE_FIRST_MEAL, Checkout.BEFORE_LAST_MEAL);
        assertThat(price).isEqualTo(200);
    }

    @Test
    public void computePriceWithoutFirstAndLastMeal() {
        double price = priceCalculator.calculatePrice(Accommodation.SINGLE, Checkin.AFTER_FIRST_MEAL, Checkout.BEFORE_LAST_MEAL);
        assertThat(price).isEqualTo(530);
    }

    @Test
    public void computePriceWithCustomMealPrice() {
        PriceCalculator priceCalculator = new PriceCalculator(30);
        double price = priceCalculator.calculatePrice(Accommodation.SINGLE, Checkin.AFTER_FIRST_MEAL, Checkout.BEFORE_LAST_MEAL);
        assertThat(price).isEqualTo(550);
    }
}