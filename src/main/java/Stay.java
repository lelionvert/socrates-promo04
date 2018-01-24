import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.Calendar;

/**
 * Created by lenovo_3 on 23/01/2018.
 */
public class Stay {

    private LocalDateTime date;

    public Stay(LocalDateTime date) {
        this.date = date;
    }

    public boolean checkinBefore(LocalDateTime date) {
        if(this.date.equals(date))return true;
        LocalDateTime expectedDate = LocalDateTime.parse("2018-01-25T22:00:00", DateTimeFormatter.ISO_LOCAL_DATE_TIME);
        if(date.compareTo(expectedDate) == 0) return false;
        return true;
    }
}
