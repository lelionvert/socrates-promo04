package fr.lacombe.socratesfr;

import java.time.LocalDateTime;

/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class PriceCalculator {
    private static final double DEFAULT_MEAL_PRICE = 40;
    private final double mealPrice;
    private final LocalDateTime dateFirstMeal;
    private final LocalDateTime dateLastMeal;

    public PriceCalculator(double mealPrice, LocalDateTime dateFirstMeal, LocalDateTime dateLastMeal) {
        this.mealPrice = mealPrice;
        this.dateFirstMeal = dateFirstMeal;
        this.dateLastMeal = dateLastMeal;
    }

    public PriceCalculator(LocalDateTime dateFirstMeal, LocalDateTime dateLastMeal) {
        this(DEFAULT_MEAL_PRICE, dateFirstMeal, dateLastMeal);
    }
    
    public double getPrice(Accommodation accommodation, LocalDateTime checkInDate, LocalDateTime checkOutDate) {
        Stay stay = new Stay(checkInDate, checkOutDate);
        CheckInDeadline checkInDeadline = stay.getCheckInDeadline(dateFirstMeal);
        CheckOutDeadline checkOutDeadline = stay.getCheckOutDeadline(dateLastMeal);
        int mealsNotTaken = checkInDeadline.getMealsNotTaken() + checkOutDeadline.getMealsNotTaken();
        return accommodation.price() - mealsNotTaken * mealPrice;
    }
}