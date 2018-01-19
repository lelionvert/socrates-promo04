import java.util.*;

/**
 * Created by lenovo_3 on 17/01/2018.
 */
public class Register {

    private final Collection<Candidate> candidates = new ArrayList<>();

    public boolean addCandidate(Candidate candidate) {
        if (candidates.stream().anyMatch(candidate::sameEmail)) return false;
        return candidates.add(candidate);
    }

    public Iterable<Candidate> getCandidates() {
        ArrayList<Candidate> candidates = new ArrayList<>(this.candidates);
        candidates.sort(Comparator.comparing(Candidate::getFirstname));
        return candidates;
    }
}
