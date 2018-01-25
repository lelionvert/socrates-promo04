package fr.lacombe.socratesfr;

import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;

import java.time.LocalDateTime;

import static org.assertj.core.api.Assertions.*;

public class StayCalculatorShould {

    @ParameterizedTest
    @CsvSource({"2018-01-25T20:00:00,2018-01-28T14:00:00,DOUBLE,510",
                "2018-01-25T22:00:00,2018-01-28T14:00:00,DOUBLE,470",
                "2018-01-25T22:00:00,2018-01-28T10:00:00,DOUBLE,430",
                "2018-01-25T20:00:00,2018-01-28T10:00:00,DOUBLE,470"})
    public void givePrice(String formattedCheckin, String formattedCheckout, Accommodation room, int expectedPrice){
        PriceCalculator priceCalculator = new PriceCalculator(40);
        StayCalculator stayCalculator = new StayCalculator(new MealsCalculator(LocalDateTime.parse("2018-01-25T21:00:00"),
                                                 LocalDateTime.parse("2018-01-28T12:00:00"),
                                                 4), priceCalculator);
        CheckTime checkin = CheckTime.parse(formattedCheckin);
        CheckTime checkout = CheckTime.parse(formattedCheckout);
        int price = stayCalculator.calculate(new Stay(checkin, checkout, room));
        assertThat(price).isEqualTo(expectedPrice);

    }

}