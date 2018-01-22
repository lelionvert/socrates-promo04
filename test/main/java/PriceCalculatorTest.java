
import org.assertj.core.api.Assertions;
import org.junit.Test;


/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculatorTest {

    @Test
    public void SingleRoom() throws Exception {
        PriceCalculator priceCalculator = new PriceCalculator();
        int price = priceCalculator.calculatePrice();

        Assertions.assertThat(price).isEqualTo(610);
    }
}