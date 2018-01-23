package main.java;

public enum Checkin {
    THURSDAY(0);

    private final int mealsNotTaken;

    Checkin(int mealsNotTaken) {
        this.mealsNotTaken = mealsNotTaken;
    }
}
