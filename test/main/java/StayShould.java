import org.assertj.core.api.Assertions;
import org.junit.Test;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.Calendar;
import java.util.Date;

import static org.assertj.core.api.Assertions.*;

/**
 * Created by lenovo_3 on 23/01/2018.
 */
public class StayShould {

    private Date createDate(String formattedDate){
        SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy:H");
        Date date = null;
        try {
            date = sdf.parse(formattedDate);
        } catch (ParseException e) {
            e.printStackTrace();
        }
        return date;
    }

    @Test
    public void beginBeforeDinnerHour() throws Exception {
        LocalDateTime date = LocalDateTime.parse("2018-01-25T18:00:00", DateTimeFormatter.ISO_LOCAL_DATE_TIME);
        Stay stay = new Stay(date);
        LocalDateTime dinnerDate = LocalDateTime.parse("2018-01-25T21:00:00", DateTimeFormatter.ISO_LOCAL_DATE_TIME);
        boolean isBefore = stay.checkinBefore(dinnerDate);
        assertThat(isBefore).isTrue();

    }

    @Test
    public void beginAfterDinnerHour() throws Exception {
        LocalDateTime date = LocalDateTime.parse("2018-01-25T23:00:00", DateTimeFormatter.ISO_LOCAL_DATE_TIME);
        Stay stay = new Stay(date);
        LocalDateTime dinnerDate = LocalDateTime.parse("2018-01-25T22:00:00", DateTimeFormatter.ISO_LOCAL_DATE_TIME);
        boolean isBefore = stay.checkinBefore(dinnerDate);
        assertThat(isBefore).isFalse();
    }

    @Test
    public void beginAtDinnerHour() throws Exception {
        LocalDateTime date = LocalDateTime.parse("2018-01-25T22:00:00", DateTimeFormatter.ISO_LOCAL_DATE_TIME);
        Stay stay = new Stay(date);
        LocalDateTime dinnerDate = LocalDateTime.parse("2018-01-25T22:00:00", DateTimeFormatter.ISO_LOCAL_DATE_TIME);
        boolean isBefore = stay.checkinBefore(dinnerDate);
        assertThat(isBefore).isTrue();
    }
}