
import org.junit.Test;

import static org.assertj.core.api.Assertions.*;


/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculatorShould {

    @Test
    public void giveSingleRoomPrice() throws Exception {
        int price = PriceCalculator.calculatePrice(Room.SINGLE);
        assertThat(price).isEqualTo(610);
    }

    @Test
    public void giveDoubleRoomPrice() throws Exception {
        int price = PriceCalculator.calculatePrice(Room.DOUBLE);

        assertThat(price).isEqualTo(510);
    }

    @Test
    public void giveTripleRoomPrice() throws Exception {
        int price = PriceCalculator.calculatePrice(Room.TRIPLE);

        assertThat(price).isEqualTo(410);
    }


}