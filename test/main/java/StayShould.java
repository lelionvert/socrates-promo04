import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;

import java.time.LocalDateTime;

import static org.assertj.core.api.Assertions.assertThat;

public class StayShould {

    @ParameterizedTest
    @CsvSource({"2018-01-25T18:00:00, 2018-01-25T21:00:00",
                "2018-01-25T22:00:00, 2018-01-25T22:00:00"})
    public void beginBeforeDinnerHour(LocalDateTime date, LocalDateTime dinnerDate) throws Exception {
        Stay stay = new Stay(date);
        boolean isBefore = stay.checkinBefore(dinnerDate);
        assertThat(isBefore).isTrue();
    }

    @ParameterizedTest
    @CsvSource({"2018-01-25T23:00:00, 2018-01-25T22:00:00"})
    public void beginAfterDinnerHour(LocalDateTime date, LocalDateTime dinnerDate) throws Exception {
        Stay stay = new Stay(date);
        boolean isBefore = stay.checkinBefore(dinnerDate);
        assertThat(isBefore).isFalse();
    }



}