import java.util.*;

/**
 * Created by lenovo_3 on 17/01/2018.
 */
public class Register {

    private final List<Candidate> candidateCollection = new ArrayList<>();

    public boolean addCandidate(Candidate candidate) {
        if (!candidate.getEmail().hasValidEmail()) {
            System.out.println(candidate.getEmail() + " " + "is invalid");
            return false;
        }
        if (candidateCollection.stream().anyMatch(candidate::sameEmail)) return false;
        return candidateCollection.add(candidate);
    }

    public Iterable<Candidate> getCandidateCollection() {
        ArrayList<Candidate> candidates = new ArrayList<>(candidateCollection);
        candidates.sort(Comparator.comparing(Candidate::getFirstname));
        return candidates;
    }
}
