package fr.lacombe.socratesfr;

/**
 * Created by lenovo_3 on 17/01/2018.
 */
public class Candidate implements Comparable<Candidate> {
    private final Email email;
    private final String firstName;

    public Candidate(Email email, String firstName) {
        this.email = email;
        this.firstName = firstName;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        Candidate candidate = (Candidate) o;

        if (!email.equals(candidate.email)) return false;
        return firstName != null ? firstName.equals(candidate.firstName) : candidate.firstName == null;
    }

    @Override
    public int hashCode() {
        int result = email != null ? email.hashCode() : 0;
        result = 31 * result + (firstName != null ? firstName.hashCode() : 0);
        return result;
    }

    @Override
    public String toString() {
        return "fr.lacombe.socratesfr.Candidate{" +
                "firstName='" + firstName + '\'' +
                '}';
    }

    public boolean sameEmail(Candidate candidate) {
        return email.equals(candidate.email);
    }


    @Override
    public int compareTo(Candidate o) {
        return firstName.compareTo(o.firstName);

    }
}
