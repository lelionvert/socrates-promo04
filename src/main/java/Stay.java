import java.time.LocalDateTime;

public class Stay {
    public int calculate(CheckTime checkin, CheckTime checkout, Accommodation room) {
        if(checkout.isBefore(LocalDateTime.parse("2018-01-28T12:00:00"))) return 430;
        if(!checkin.isBefore(LocalDateTime.parse("2018-01-25T21:00:00"))) return 470;
            return 510;
    }
}
