import java.util.*;

/**
 * Created by lenovo_3 on 17/01/2018.
 */
public class Register {

    private final Set<Candidate> candidateCollection = new HashSet<Candidate>();

    public boolean addCandidate(Candidate candidate) {
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
