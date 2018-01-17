import java.util.ArrayList;
import java.util.List;

class CandidateRegister {

    private List<Candidate> candidateList;

    public CandidateRegister() {
        candidateList = new ArrayList<Candidate>();
    }

    public CandidateRegister(List<Candidate> candidateList) {
        this.candidateList = candidateList;
    }

    public List<Candidate> retrieveAll() {
        return candidateList;
    }

    public void addCandidate(Candidate candidate) {
        candidateList.add(candidate);
    }
}
