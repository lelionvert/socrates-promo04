package main.java;

import org.junit.Test;

import java.time.LocalDateTime;

import static org.assertj.core.api.AssertionsForClassTypes.assertThat;

public class StayShould {
    @Test
    public void getCheckInDeadlineWhenCheckInIsBeforeFirstMeal() {
        LocalDateTime checkinDate = LocalDateTime.of(2017, 10, 26, 15, 0);
        LocalDateTime checkoutDate = LocalDateTime.of(2017, 10, 29, 15, 0);
        LocalDateTime dateFirstMeal = LocalDateTime.of(2017, 10, 29, 19, 0);
        Stay stay = new Stay(checkinDate, checkoutDate);
        CheckInDeadline checkInDeadline = stay.getCheckInDeadline(dateFirstMeal);
        assertThat(checkInDeadline).isEqualTo(CheckInDeadline.BEFORE_FIRST_MEAL);
    }
}
