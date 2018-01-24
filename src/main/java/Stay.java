import java.time.LocalDateTime;

/**
 * Created by lenovo_3 on 23/01/2018.
 */
public class Stay {

    private final LocalDateTime checkin;

    public Stay(LocalDateTime checkin) {
        this.checkin = checkin;
    }

    public boolean checkinBefore(LocalDateTime dateTime) {
        return !this.checkin.isAfter(dateTime);
    }
}
