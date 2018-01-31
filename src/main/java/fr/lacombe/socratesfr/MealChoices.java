package fr.lacombe.socratesfr;

import java.util.ArrayList;
import java.util.List;

public class MealChoices {

    public MealChoices() {
        this.choices = new ArrayList<>();
    }

    private List<MealChoice> choices;

    public void add(MealChoice mealChoice) {
        choices.add(mealChoice);
    }

    public int calculateNumberOfCovers(Meal meal, Diet diet) {
        return (int)choices.stream().filter(p-> p.getMeal() == meal)
                                    .filter(p-> p.getDiet() == diet).count();
    }
}
