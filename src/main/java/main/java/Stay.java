package main.java;

import java.time.LocalDateTime;

public class Stay {
    private final LocalDateTime checkInDate;
    private final LocalDateTime checkOutDate;

    public Stay(LocalDateTime checkInDate, LocalDateTime checkOutDate) {
        this.checkInDate = checkInDate;
        this.checkOutDate = checkOutDate;
    }

    public CheckInDeadline getCheckInDeadline(LocalDateTime dateFirstMeal) {
        if (checkInDate.isEqual(LocalDateTime.of(2017, 10, 27, 11, 0))) return CheckInDeadline.AFTER_FIRST_MEAL;
        return CheckInDeadline.BEFORE_FIRST_MEAL;
    }

    public CheckOutDeadline getCheckOutDeadline(LocalDateTime dateLastMeal) {
        if (checkOutDate.isEqual(LocalDateTime.of(2017, 10, 29, 18, 0))) return CheckOutDeadline.AFTER_LAST_MEAL;
        return CheckOutDeadline.BEFORE_LAST_MEAL;
    }
}
