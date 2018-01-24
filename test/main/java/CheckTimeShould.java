import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;

import java.time.LocalDateTime;

import static org.assertj.core.api.Assertions.assertThat;

public class CheckTimeShould {

    @ParameterizedTest
    @CsvSource({"2018-01-25T18:00:00, 2018-01-25T21:00:00",
                "2018-01-25T22:00:00, 2018-01-25T22:00:00"})
    public void beginBefore(LocalDateTime dateTime, LocalDateTime dinnerDate) throws Exception {
        CheckTime checkTime = new CheckTime(dateTime);
        boolean isBefore = checkTime.isBefore(dinnerDate);
        assertThat(isBefore).isTrue();
    }

    @ParameterizedTest
    @CsvSource({"2018-01-25T23:00:00, 2018-01-25T22:00:00"})
    public void beginAfter(LocalDateTime dateTime, LocalDateTime dinnerDate) throws Exception {
        CheckTime checkTime = new CheckTime(dateTime);
        boolean isBefore = checkTime.isBefore(dinnerDate);
        assertThat(isBefore).isFalse();
    }

}