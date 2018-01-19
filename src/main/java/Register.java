import java.util.*;

/**
 * Created by lenovo_3 on 17/01/2018.
 */
public class Register {

    private final Collection<Candidate> candidates = new ArrayList<>();

    public boolean add(Candidate candidate) {
        if (candidates.stream().anyMatch(candidate::sameEmail)) return false;
        return candidates.add(candidate);
    }

    public Iterable<Candidate> createAlphabeticallySortedListOfCandidates() {
        ArrayList<Candidate> candidates = new ArrayList<>(this.candidates);
        Collections.sort(candidates);
        return candidates;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        Register register = (Register) o;

        return candidates != null ? candidates.equals(register.candidates) : register.candidates == null;
    }

    @Override
    public int hashCode() {
        return candidates != null ? candidates.hashCode() : 0;
    }
}
