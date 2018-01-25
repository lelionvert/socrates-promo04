package fr.lacombe.socratesfr;

import java.time.LocalDateTime;

/**
 * Created by lenovo_3 on 23/01/2018.
 */
public class CheckTime {

    private final LocalDateTime dateTime;

    public CheckTime(LocalDateTime dateTime) {
        this.dateTime = dateTime;
    }

    public boolean isBefore(LocalDateTime dateTime) {
        return !this.dateTime.isAfter(dateTime);
    }

    public static CheckTime parse(String formattedDate) {
        return new CheckTime(LocalDateTime.parse(formattedDate));
    }
}
