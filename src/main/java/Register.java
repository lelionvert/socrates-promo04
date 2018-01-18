import java.util.*;

/**
 * Created by lenovo_3 on 17/01/2018.
 */
public class Register {

    private final List<Candidate> candidateCollection = new ArrayList<>();

    public boolean addCandidate(Candidate candidate) {
        if (candidateCollection.contains(candidate)) return false;
        return candidateCollection.add(candidate);
    }

    public Collection<Candidate> getCandidateCollection() {
        return candidateCollection;
    }


    public Collection<Candidate> getOrderedCandidateByFirstname() {
        ArrayList<Candidate> candidates = new ArrayList<>(candidateCollection);
        candidates.sort(Comparator.comparing(Candidate::getFirstname));
        return candidates;
    }
}
