package fr.lacombe.socratesfr;

/**
 * Created by lenovo_3 on 22/01/2018.
 */
public enum Accommodation {
    SINGLE(370),
    DOUBLE(270),
    TRIPLE(170),
    NONE(0);

    private final int price;

    Accommodation(int price) {
        this.price = price;
    }

    public int price() {
        return price;
    }
}
