
import org.junit.Test;

import static org.assertj.core.api.Assertions.*;


/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculatorShould {

    @Test
    public void giveSingleRoomPriceWithSixMeals() throws Exception {
        int price = PriceCalculator.calculatePrice(Accommodation.SINGLE, 6);
        assertThat(price).isEqualTo(610);
    }

    @Test
    public void giveDoubleRoomPriceWithSixMeals() throws Exception {
        int price = PriceCalculator.calculatePrice(Accommodation.DOUBLE, 6);

        assertThat(price).isEqualTo(510);
    }

    @Test
    public void giveTripleRoomPriceWithSixMeals() throws Exception {
        int price = PriceCalculator.calculatePrice(Accommodation.TRIPLE, 6);

        assertThat(price).isEqualTo(410);
    }

    @Test
    public void giveSixMealsPrice() throws Exception {
        int price = PriceCalculator.calculatePrice(Accommodation.NONE, 6);
        assertThat(price).isEqualTo(240);
    }

    @Test
    public void giveSingleRoomWithFiveMeals() throws Exception {
        int price = PriceCalculator.calculatePrice(Accommodation.SINGLE,5);
        assertThat(price).isEqualTo(570);
    }
}