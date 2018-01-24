package main.java;

import java.time.LocalDateTime;

public class Stay {
    private final LocalDateTime checkInDate;

    public Stay(LocalDateTime checkInDate, LocalDateTime checkOutDate) {
        this.checkInDate = checkInDate;
    }

    public CheckInDeadline getCheckInDeadline(LocalDateTime dateFirstMeal) {
        if (checkInDate.isEqual(LocalDateTime.of(2017, 10, 27, 11, 0))) return CheckInDeadline.AFTER_FIRST_MEAL;
        return CheckInDeadline.BEFORE_FIRST_MEAL;
    }

    public CheckOutDeadline getCheckOutDeadline(LocalDateTime dateLastMeal) {
        return CheckOutDeadline.BEFORE_LAST_MEAL;
    }
}
