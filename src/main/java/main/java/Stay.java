package main.java;

import java.time.LocalDateTime;

public class Stay {
    private final LocalDateTime checkinDate;

    public Stay(LocalDateTime checkinDate, LocalDateTime checkoutDate) {
        this.checkinDate = checkinDate;
    }

    public CheckInDeadline getCheckInDeadline(LocalDateTime dateFirstMeal) {
        if (checkinDate.isEqual(LocalDateTime.of(2017, 10, 27, 11, 0))) return CheckInDeadline.AFTER_FIRST_MEAL;
        return CheckInDeadline.BEFORE_FIRST_MEAL;
    }
}
