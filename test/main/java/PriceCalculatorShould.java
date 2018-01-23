
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
    public void giveSingleRoomPrice() throws Exception {
        double price = PriceCalculator.calculatePrice(Accommodation.SINGLE);
        assertThat(price).isEqualTo(610);
    }

    @Test
    public void giveDoubleRoomPrice() throws Exception {
        double price = PriceCalculator.calculatePrice(Accommodation.DOUBLE);

        assertThat(price).isEqualTo(510);
    }

    @Test
    public void giveTripleRoomPrice() throws Exception {
        double price = PriceCalculator.calculatePrice(Accommodation.TRIPLE);

        assertThat(price).isEqualTo(410);
    }

    @Test
    public void giveNoAccomodationPrice() throws Exception {
        double price = PriceCalculator.calculatePrice(Accommodation.NONE);
        assertThat(price).isEqualTo(240);
    }

    @Test
    public void giveSingleRoomPriceWithout1Meal() {
        double price = PriceCalculator.calculatePrice(Accommodation.SINGLE, 1);
        assertThat(price).isEqualTo(570);
    }

    @Test
    public void giveNoAccommodationPriceWithout2Meals() {
        double price = PriceCalculator.calculatePrice(Accommodation.NONE, 2);
        assertThat(price).isEqualTo(160);
    }

    @Test(expected = MinimumMealException.class)
    public void throwExceptionWhenMealsNotTakenIsAboveTheLimit() throws MinimumMealException {
        PriceCalculator.calculatePrice(Accommodation.NONE, 3);
    }

    @Test(expected = IllegalArgumentException.class)
    public void throwExceptionWhenMealsNotTakenIsNegative() throws IllegalArgumentException {
        PriceCalculator.calculatePrice(Accommodation.NONE, -2);
    }

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