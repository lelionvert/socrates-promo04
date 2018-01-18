/**
 * Created by lenovo_3 on 17/01/2018.
 */
public class Candidate {
    private final String email;
    private final String firstname;

    public Candidate(String email, String firstname) {
        this.email = email;
        this.firstname = firstname;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        Candidate candidate = (Candidate) o;

        if (email != null ? !email.equals(candidate.email) : candidate.email != null) return false;
        return firstname != null ? firstname.equals(candidate.firstname) : candidate.firstname == null;
    }

    @Override
    public int hashCode() {
        int result = email != null ? email.hashCode() : 0;
        result = 31 * result + (firstname != null ? firstname.hashCode() : 0);
        return result;
    }

    @Override
    public String toString() {
        return "Candidate{" +
                "firstname='" + firstname + '\'' +
                '}';
    }

    public String getFirstname() {
        return firstname;
    }

    public boolean sameEmail(Candidate candidate) {
        return email.equals(candidate.email);
    }
}
