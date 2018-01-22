/**
 * Created by lenovo_3 on 22/01/2018.
 */
public enum Accommodation {
    SINGLE(610),
    DOUBLE(510),
    TRIPLE(410),
    NONE(240);

    private final int price;

    Accommodation(int price) {
        this.price = price;
    }

    public int price() {
        return price;
    }
}
