package fr.lacombe.socratesfr;

import org.junit.Test;

import java.time.LocalDateTime;

import static org.assertj.core.api.Assertions.*;


/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculatorShould {
    public static final LocalDateTime DATE_FIRST_MEAL = LocalDateTime.of(2017, 10, 26, 19, 0);
    public static final LocalDateTime DATE_LAST_MEAL = LocalDateTime.of(2017, 10, 29, 12, 0);

    private PriceCalculator priceCalculator = new PriceCalculator(DATE_FIRST_MEAL, DATE_LAST_MEAL);

    @Test
    public void computeCompletePrice() {
        LocalDateTime checkInDate = LocalDateTime.of(2017, 10, 26, 15, 0);
        LocalDateTime checkOutDate = LocalDateTime.of(2017, 10, 29, 15, 0);
        double price = priceCalculator.getPrice(Accommodation.DOUBLE, checkInDate, checkOutDate);
        assertThat(price).isEqualTo(510);
    }

    @Test
    public void computePriceWithoutFirstMeal() {
        LocalDateTime checkInDate = LocalDateTime.of(2017, 10, 27, 11, 0);
        LocalDateTime checkOutDate = LocalDateTime.of(2017, 10, 29, 15, 0);
        double price = priceCalculator.getPrice(Accommodation.TRIPLE, checkInDate, checkOutDate);
        assertThat(price).isEqualTo(370);
    }

    @Test
    public void computePriceWithoutLastMeal() {
        LocalDateTime checkInDate = LocalDateTime.of(2017, 10, 27, 11, 0);
        LocalDateTime checkOutDate = LocalDateTime.of(2017, 10, 29, 18, 0);
        double price = priceCalculator.getPrice(Accommodation.NONE, checkInDate, checkOutDate);
        assertThat(price).isEqualTo(200);
    }

    @Test
    public void computePriceWithoutFirstAndLastMeal() {
        LocalDateTime checkInDate = LocalDateTime.of(2017, 10, 27, 11, 0);
        LocalDateTime checkOutDate = LocalDateTime.of(2017, 10, 29, 11, 0);
        double price = priceCalculator.getPrice(Accommodation.SINGLE, checkInDate, checkOutDate);
        assertThat(price).isEqualTo(530);
    }

    @Test
    public void computePriceWithCustomMealPrice() {
        PriceCalculator priceCalculator = new PriceCalculator(LocalDateTime.of(2017, 10, 26, 19, 0), LocalDateTime.of(2017, 10, 29, 12, 0), 30);
        LocalDateTime checkInDate = LocalDateTime.of(2017, 10, 27, 11, 0);
        LocalDateTime checkOutDate = LocalDateTime.of(2017, 10, 29, 11, 0);
        double price = priceCalculator.getPrice(Accommodation.SINGLE, checkInDate, checkOutDate);
        assertThat(price).isEqualTo(550);
    }

}