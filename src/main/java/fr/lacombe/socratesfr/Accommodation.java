package fr.lacombe.socratesfr;

/**
 * Created by lenovo_3 on 22/01/2018.
 */
public enum Accommodation {
    SINGLE(610),
    DOUBLE(510),
    TRIPLE(410),
    NONE(240);

    private final double price;

    Accommodation(double price) {
        this.price = price;
    }

    public double price() {
        return price;
    }
}
