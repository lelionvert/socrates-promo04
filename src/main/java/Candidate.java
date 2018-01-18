import java.util.Objects;

class Candidate {

    private String name;
    private final String email;


    public Candidate(String name, String email) {
        this.name = name;
        this.email = email;
    }

    public String getName() {
        return name;
    }

    public String getEmail() {
        return email;
    }

    public boolean isDuplicate(Candidate candidate) {
        return Objects.equals(email,candidate.email);
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Candidate candidate = (Candidate) o;
        return Objects.equals(name, candidate.name) &&
                Objects.equals(email, candidate.email);
    }

    @Override
    public int hashCode() {
        return Objects.hash(name, email);
    }
}
