import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

class CandidateRegister {

    private List<Candidate> candidateList;

    public CandidateRegister() {
        candidateList = new ArrayList<>();
    }

    public CandidateRegister(List<Candidate> candidateList) {
        this.candidateList = candidateList;
    }

    public List<Candidate> retrieveAll() {
        candidateList.sort(Comparator.comparing(Candidate::getName));
        return candidateList;
    }

    public void addCandidate(Candidate candidate) {

        if(candidateList.stream().anyMatch(x -> candidate.isDuplicate(x))) {
            return;
        }
        candidateList.add(candidate);
    }
}
