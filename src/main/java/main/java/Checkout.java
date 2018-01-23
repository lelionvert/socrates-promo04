package main.java;

public enum Checkout {
    AFTER_LAST_MEAL(0),
    BEFORE_LAST_MEAL(1);

    private final int mealsNotTaken;

    Checkout(int mealsNotTaken) {
        this.mealsNotTaken = mealsNotTaken;
    }
}
