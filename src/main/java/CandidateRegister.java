import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Optional;

class CandidateRegister {

    private List<Candidate> candidateList;

    public CandidateRegister() {
        candidateList = new ArrayList<Candidate>();
    }

    public CandidateRegister(List<Candidate> candidateList) {
        this.candidateList = candidateList;
    }

    public List<Candidate> retrieveAll() {
        candidateList.sort((o1, o2) -> o1.getName().compareTo(o2.getName()));
        return candidateList;
    }

    public void addCandidate(Candidate candidate) {

        if(candidateList.stream()
                .filter(x -> candidate.getEmail().equals(x.getEmail()))
                .findAny().isPresent()) {
            return;
        }
        candidateList.add(candidate);
    }
}
