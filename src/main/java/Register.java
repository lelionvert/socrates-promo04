import java.util.*;

/**
 * Created by lenovo_3 on 17/01/2018.
 */
public class Register {

    private final Collection<Candidate> candidateCollection = new ArrayList<>();

    public boolean addCandidate(Candidate candidate) {
        if (candidateCollection.stream().anyMatch(candidate::sameEmail)) return false;
        return candidateCollection.add(candidate);
    }

    public Iterable<Candidate> getCandidateCollection() {
        ArrayList<Candidate> candidates = new ArrayList<>(candidateCollection);
        candidates.sort(Comparator.comparing(Candidate::getFirstname));
        return candidates;
    }
}
