
import org.assertj.core.api.Assertions;
import org.junit.Test;


/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculatorTest {

    @Test
    public void SingleRoom() throws Exception {
        PriceCalculator priceCalculator = new PriceCalculator();
        int price = priceCalculator.calculatePrice("single");

        Assertions.assertThat(price).isEqualTo(610);
    }

    @Test
    public void DoubleRoom() throws Exception {
        PriceCalculator priceCalculator = new PriceCalculator();
        int price = priceCalculator.calculatePrice("double");

        Assertions.assertThat(price).isEqualTo(510);
    }
}