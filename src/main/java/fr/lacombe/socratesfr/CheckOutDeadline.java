package fr.lacombe.socratesfr;

public enum CheckOutDeadline {
    AFTER_LAST_MEAL(0),
    BEFORE_LAST_MEAL(1);

    private final int mealsNotTaken;

    CheckOutDeadline(int mealsNotTaken) {
        this.mealsNotTaken = mealsNotTaken;
    }

    public int getMealsNotTaken() {
        return mealsNotTaken;
    }
}
