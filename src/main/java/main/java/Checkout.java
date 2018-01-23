package main.java;

public enum Checkout {
    SUNDAY(0);

    private final int mealsNotTaken;

    Checkout(int mealsNotTaken) {
        this.mealsNotTaken = mealsNotTaken;
    }
}
