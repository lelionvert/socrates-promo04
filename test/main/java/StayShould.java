import org.assertj.core.api.Assertions;
import org.junit.Test;

import java.text.ParseException;
import java.text.SimpleDateFormat;
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
        Date date = createDate("25/01/2018:18");
        Stay stay = new Stay(date);
        Date dinnerDate = createDate("25/01/2018:21");
        boolean isBefore = stay.checkinBefore(dinnerDate);
        assertThat(isBefore).isTrue();

    }

    @Test
    public void beginAfterDinnerHour() throws Exception {
        Date date = createDate("25/01/2018:22");
        Stay stay = new Stay(date);
        Date dinnerDate = createDate("25/01/2018:21");
        boolean isBefore = stay.checkinBefore(dinnerDate);
        assertThat(isBefore).isFalse();
    }

/*    @Test
    public void beginMorning() throws Exception {
        Stay stay = new Stay();
        boolean isBefore = stay.checkinBefore(23);
        assertThat(isBefore).isFalse();

    }*/
}