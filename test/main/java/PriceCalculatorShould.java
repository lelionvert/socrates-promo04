
import org.junit.Test;

import static org.assertj.core.api.Assertions.*;


/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculatorShould {

    @Test
    public void giveSingleRoomPrice() throws Exception {
        PriceCalculator priceCalculator = new PriceCalculator();
        int price = priceCalculator.calculatePrice("single");

        assertThat(price).isEqualTo(610);
    }

    @Test
    public void giveDoubleRoomPrice() throws Exception {
        PriceCalculator priceCalculator = new PriceCalculator();
        int price = priceCalculator.calculatePrice("double");

        assertThat(price).isEqualTo(510);
    }

    @Test
    public void giveTripleRoomPrice() throws Exception {
        PriceCalculator priceCalculator = new PriceCalculator();
        int price = priceCalculator.calculatePrice("triple");

        assertThat(price).isEqualTo(410);
    }


}