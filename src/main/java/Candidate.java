/**
 * Created by lenovo_3 on 17/01/2018.
 */
public class Candidate implements Comparable{
    private final String email;
    private final String firstName;

    public Candidate(String email, String firstName) {
        this.email = email;
        this.firstName = firstName;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        Candidate candidate = (Candidate) o;

        return email != null ? email.equals(candidate.email) : candidate.email == null;
    }

    @Override
    public int hashCode() {
        return email != null ? email.hashCode() : 0;
    }


    public int compareTo(Object o) {
        Candidate candidate = (Candidate) o;
        return firstName.compareTo(candidate.firstName);
    }

    @Override
    public String toString() {
        return "Candidate{" +
                "firstName='" + firstName + '\'' +
                '}';
    }
}
