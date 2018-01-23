package main.java;

public enum Checkin {
    BEFORE_FIRST_MEAL(0),
    AFTER_FIRST_MEAL(1);

    private final int mealsNotTaken;

    Checkin(int mealsNotTaken) {
        this.mealsNotTaken = mealsNotTaken;
    }
}
