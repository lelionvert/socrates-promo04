package fr.lacombe.socratesfr;

public class Stay {
    private final CheckTime checkin;
    private final CheckTime checkout;
    private final Accommodation room;

    public Stay(CheckTime checkin, CheckTime checkout, Accommodation room) {
        this.checkin = checkin;
        this.checkout = checkout;
        this.room = room;
    }

    public CheckTime getCheckin() {
        return checkin;
    }

    public CheckTime getCheckout() {
        return checkout;
    }

    public Accommodation getRoom() {
        return room;
    }
}
