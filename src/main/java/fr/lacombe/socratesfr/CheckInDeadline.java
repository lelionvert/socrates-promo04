package fr.lacombe.socratesfr;

public enum CheckInDeadline {
    BEFORE_FIRST_MEAL(0),
    AFTER_FIRST_MEAL(1);

    private final int mealsNotTaken;

    CheckInDeadline(int mealsNotTaken) {
        this.mealsNotTaken = mealsNotTaken;
    }

    public int getMealsNotTaken() {
        return mealsNotTaken;
    }
}
