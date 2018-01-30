package fr.lacombe.socratesfr;

class MealChoice {

    private final Meal meal;
    private final Diet diet;

    public MealChoice(Meal meal, Diet diet) {
        this.meal = meal;
        this.diet = diet;
    }

    public Diet getDiet() {
        return diet;
    }

    public Meal getMeal() {
        return meal;
    }
}
