package main.java;

import org.junit.Test;

import java.time.LocalDateTime;

import static org.assertj.core.api.AssertionsForClassTypes.assertThat;

public class StayShould {
    @Test
    public void getTheCheckinDeadlineWhenTheCheckinIsBeforeTheFirstMealDeadline() {
        LocalDateTime checkinDate = LocalDateTime.of(2017, 10, 26, 15, 0);
        LocalDateTime checkoutDate = LocalDateTime.of(2017, 10, 29, 15, 0);
        LocalDateTime dateFirstMeal = LocalDateTime.of(2017, 10, 29, 19, 0);
        Stay stay = new Stay(checkinDate, checkoutDate);
        Checkin checkin = stay.getCheckinDeadline(dateFirstMeal);
        assertThat(checkin).isEqualTo(Checkin.BEFORE_FIRST_MEAL);
    }
}
