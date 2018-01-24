package main.java;

import java.time.LocalDateTime;

public class Stay {
    private final LocalDateTime checkinDate;

    public Stay(LocalDateTime checkinDate, LocalDateTime checkoutDate) {
        this.checkinDate = checkinDate;
    }

    public Checkin getCheckinDeadline(LocalDateTime dateFirstMeal) {
        return Checkin.BEFORE_FIRST_MEAL;
    }
}
