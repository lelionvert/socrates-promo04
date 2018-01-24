package main.java;

import org.junit.Test;

import java.time.LocalDateTime;

import static org.assertj.core.api.AssertionsForClassTypes.assertThat;

public class StayShould {
    @Test
    public void getCheckInDeadlineWhenCheckInIsBeforeFirstMeal() {
        LocalDateTime checkInDate = LocalDateTime.of(2017, 10, 26, 15, 0);
        LocalDateTime checkoutDate = LocalDateTime.of(2017, 10, 29, 15, 0);
        LocalDateTime dateFirstMeal = LocalDateTime.of(2017, 10, 26, 19, 0);
        Stay stay = new Stay(checkInDate, checkoutDate);
        CheckInDeadline checkInDeadline = stay.getCheckInDeadline(dateFirstMeal);
        assertThat(checkInDeadline).isEqualTo(CheckInDeadline.BEFORE_FIRST_MEAL);
    }

    @Test
    public void getCheckInDeadlineWhenCheckInIsAfterFirstMeal() {
        LocalDateTime checkInDate = LocalDateTime.of(2017, 10, 27, 11, 0);
        LocalDateTime checkoutDate = LocalDateTime.of(2017, 10, 29, 15, 0);
        LocalDateTime dateFirstMeal = LocalDateTime.of(2017, 10, 26, 19, 0);
        Stay stay = new Stay(checkInDate, checkoutDate);
        CheckInDeadline checkInDeadline = stay.getCheckInDeadline(dateFirstMeal);
        assertThat(checkInDeadline).isEqualTo(CheckInDeadline.AFTER_FIRST_MEAL);
    }
}
