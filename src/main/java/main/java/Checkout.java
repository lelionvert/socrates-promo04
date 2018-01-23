package main.java;

public enum Checkout {
    AFTER_LAST_MEAL(0);

    private final int mealsNotTaken;

    Checkout(int mealsNotTaken) {
        this.mealsNotTaken = mealsNotTaken;
    }
}
