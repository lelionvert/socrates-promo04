/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculator {
    public int calculatePrice(String choice) {
        if ("triple".equals(choice))
            return 410;
        if ("double".equals(choice))
            return 510;
        return 610;
    }
}
