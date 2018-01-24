import org.assertj.core.api.Assertions;
import org.junit.Test;

/**
 * Created by lenovo_3 on 23/01/2018.
 */
public class StayShould {

    @Test
    public void beginBeforeDinnerHour() throws Exception {
        boolean isBefore = Stay.checkinBefore(21);
        Assertions.assertThat(isBefore).isTrue();

    }

    @Test
    public void beginAfterDinnerHour() throws Exception {
        boolean isBefore = Stay.checkinBefore(22);
        Assertions.assertThat(isBefore).isFalse();

    }

    @Test
    public void beginMorning() throws Exception {
        boolean isBefore = Stay.checkinBefore(23);
        Assertions.assertThat(isBefore).isFalse();

    }
}