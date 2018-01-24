import org.assertj.core.api.Assertions;
import org.junit.Test;

import static org.assertj.core.api.Assertions.*;

/**
 * Created by lenovo_3 on 23/01/2018.
 */
public class StayShould {

    @Test
    public void beginBeforeDinnerHour() throws Exception {
        Stay stay = new Stay();
        boolean isBefore = stay.checkinBefore(21);
        assertThat(isBefore).isTrue();

    }

    @Test
    public void beginAfterDinnerHour() throws Exception {
        Stay stay = new Stay();
        boolean isBefore = stay.checkinBefore(22);
        assertThat(isBefore).isFalse();

    }

    @Test
    public void beginMorning() throws Exception {
        Stay stay = new Stay();
        boolean isBefore = stay.checkinBefore(23);
        assertThat(isBefore).isFalse();

    }
}