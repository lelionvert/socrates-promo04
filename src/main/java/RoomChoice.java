/**
 * Created by lenovo_3 on 22/01/2018.
 */
public enum RoomChoice {
    SINGLE(610),
    DOUBLE(510),
    TRIPLE(410);

    private final int price;

    RoomChoice(int price) {
        this.price = price;
    }

    public int roomPrice() {
        return price;
    }
}
