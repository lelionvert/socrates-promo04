import java.util.HashSet;
import java.util.Set;

/**
 * Created by lenovo_3 on 17/01/2018.
 */
public class Register {

    private final Set<Candidate> candidateCollection = new HashSet<Candidate>();

    public boolean addCandidate(Candidate candidate) {
        return candidateCollection.add(candidate);
    }

    public Set<Candidate> getCandidateCollection() {
        return candidateCollection;
    }
}
