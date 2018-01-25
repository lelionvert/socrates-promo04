import org.assertj.core.api.Assertions;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;

import java.time.LocalDateTime;

import static org.assertj.core.api.Assertions.*;

public class StayShould {

    @ParameterizedTest
    @CsvSource({"2018-01-25T20:00:00,2018-01-28T14:00:00,DOUBLE,510",
                "2018-01-25T22:00:00,2018-01-28T14:00:00,DOUBLE,470",
                "2018-01-25T22:00:00,2018-01-28T10:00:00,DOUBLE,430"})
    public void Rename(String formattedCheckin, String formattedCheckout, Accommodation room, int expectedPrice){
        Stay stay = new Stay();
        CheckTime checkin = CheckTime.parse(formattedCheckin);
        CheckTime checkout = CheckTime.parse(formattedCheckout);
        int price = stay.calculate(checkin,checkout,room);
        assertThat(price).isEqualTo(expectedPrice);

    }

}