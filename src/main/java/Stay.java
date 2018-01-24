import java.time.LocalDateTime;

/**
 * Created by lenovo_3 on 23/01/2018.
 */
public class Stay {

    private final LocalDateTime date;

    public Stay(LocalDateTime date) {
        this.date = date;
    }

    public boolean checkinBefore(LocalDateTime date) {
        return !this.date.isAfter(date);
    }
}
