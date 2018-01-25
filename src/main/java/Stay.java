import java.time.LocalDateTime;

public class Stay {
    public int calculate(CheckTime checkin, CheckTime checkout, Accommodation room) {
        int price = 510;
        if(checkout.isBefore(LocalDateTime.parse("2018-01-28T12:00:00"))) price-=40;
        if(!checkin.isBefore(LocalDateTime.parse("2018-01-25T21:00:00"))) price-=40;
            return price;
    }
}
