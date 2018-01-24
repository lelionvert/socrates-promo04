import java.util.Calendar;
import java.util.Date;

/**
 * Created by lenovo_3 on 23/01/2018.
 */
public class Stay {

    public Stay(Date date) {
    }

    public boolean checkinBefore(Date date) {
        Calendar cal = Calendar.getInstance();
        cal.clear();
        cal.set(2018,Calendar.JANUARY,25,22,0);
        if(date.compareTo(cal.getTime()) == 0) return false;
        return true;
    }
}
