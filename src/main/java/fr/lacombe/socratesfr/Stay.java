package fr.lacombe.socratesfr;

import java.time.LocalDateTime;

public class Stay {
    private final LocalDateTime checkInDate;
    private final LocalDateTime checkOutDate;

    public Stay(LocalDateTime checkInDate, LocalDateTime checkOutDate) {
        this.checkInDate = checkInDate;
        this.checkOutDate = checkOutDate;
    }

    public CheckInDeadline getCheckInDeadline(LocalDateTime dateFirstMeal) {
        return checkInDate.isBefore(dateFirstMeal) ? CheckInDeadline.BEFORE_FIRST_MEAL : CheckInDeadline.AFTER_FIRST_MEAL;
    }

    public CheckOutDeadline getCheckOutDeadline(LocalDateTime dateLastMeal) {
        return checkOutDate.isBefore(dateLastMeal) ? CheckOutDeadline.BEFORE_LAST_MEAL : CheckOutDeadline.AFTER_LAST_MEAL;
    }
}
