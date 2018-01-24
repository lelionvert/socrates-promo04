import java.util.Date;

/**
 * Created by lenovo_3 on 23/01/2018.
 */
public class Stay {

    Date checkin = new Date();

    public Stay(Date date) {
        checkin = date;
    }

    public boolean checkinBefore(Date date) {
        if(checkin.after(date))return false;
        return true;
    }
}
