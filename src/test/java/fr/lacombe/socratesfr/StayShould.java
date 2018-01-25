package fr.lacombe.socratesfr;

import fr.lacombe.socratesfr.CheckInDeadline;
import fr.lacombe.socratesfr.CheckOutDeadline;
import fr.lacombe.socratesfr.Stay;
import org.junit.Test;

import java.time.LocalDateTime;

import static org.assertj.core.api.AssertionsForClassTypes.assertThat;

public class StayShould {
    private LocalDateTime dateFirstMeal = LocalDateTime.of(2017, 10, 26, 19, 0);
    private LocalDateTime dateLastMeal = LocalDateTime.of(2017, 10, 29, 12, 0);

    @Test
    public void getCheckInDeadlineWhenCheckInIsBeforeFirstMeal() {
        LocalDateTime checkInDate = LocalDateTime.of(2017, 10, 26, 15, 0);
        LocalDateTime checkOutDate = LocalDateTime.of(2017, 10, 29, 15, 0);
        Stay stay = new Stay(checkInDate, checkOutDate);
        CheckInDeadline checkInDeadline = stay.getCheckInDeadline(dateFirstMeal);
        assertThat(checkInDeadline).isEqualTo(CheckInDeadline.BEFORE_FIRST_MEAL);
    }

    @Test
    public void getCheckInDeadlineWhenCheckInIsAfterFirstMeal() {
        LocalDateTime checkInDate = LocalDateTime.of(2017, 10, 27, 11, 0);
        LocalDateTime checkOutDate = LocalDateTime.of(2017, 10, 29, 15, 0);
        Stay stay = new Stay(checkInDate, checkOutDate);
        CheckInDeadline checkInDeadline = stay.getCheckInDeadline(dateFirstMeal);
        assertThat(checkInDeadline).isEqualTo(CheckInDeadline.AFTER_FIRST_MEAL);
    }

    @Test
    public void getCheckOutDeadlineWhenCheckOutIsBeforeLastMeal() {
        LocalDateTime checkInDate = LocalDateTime.of(2017, 10, 27, 11, 0);
        LocalDateTime checkOutDate = LocalDateTime.of(2017, 10, 29, 11, 0);
        Stay stay = new Stay(checkInDate, checkOutDate);
        CheckOutDeadline checkOut = stay.getCheckOutDeadline(dateLastMeal);
        assertThat(checkOut).isEqualTo(CheckOutDeadline.BEFORE_LAST_MEAL);
    }

    @Test
    public void getCheckOutDeadlineWhenCheckOutIsAfterLastMeal() {
        LocalDateTime checkInDate = LocalDateTime.of(2017, 10, 27, 11, 0);
        LocalDateTime checkOutDate = LocalDateTime.of(2017, 10, 29, 18, 0);
        Stay stay = new Stay(checkInDate, checkOutDate);
        CheckOutDeadline checkOut = stay.getCheckOutDeadline(dateLastMeal);
        assertThat(checkOut).isEqualTo(CheckOutDeadline.AFTER_LAST_MEAL);
    }
}
