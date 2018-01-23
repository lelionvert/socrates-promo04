package main.java;

public enum Checkin {
    THURSDAY(0),
    FRIDAY(1);

    private final int mealsNotTaken;

    Checkin(int mealsNotTaken) {
        this.mealsNotTaken = mealsNotTaken;
    }
}
