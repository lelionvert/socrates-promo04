import org.assertj.core.api.Assertions;
import org.junit.Assert;
import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

public class CandidateRegisterTest {

    @Test
    public void retrieveEmptyList(){
        CandidateRegister candidateRegister = new CandidateRegister();
        List<Candidate> candidateList = candidateRegister.retrieveAll();
        Assert.assertTrue(candidateList.isEmpty());
    }

    @Test
    public void retrieveCandidateInList(){
        Candidate candidate = new Candidate("candidat", "candidat@gmail.com");
        List<Candidate> candidateList = new ArrayList<Candidate>();
        candidateList.add(candidate);
        CandidateRegister candidateRegister = new CandidateRegister(candidateList);
        List<Candidate> retrievedCandidateList = candidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(candidate);
    }

    @Test
    public void retriveTwoCandidatesInList(){
        Candidate candidate = new Candidate("candidat", "candidat@gmail.com");
        Candidate candidate2 = new Candidate("candidat2", "candidat2@gmail.com");
        List<Candidate> candidateList = new ArrayList<Candidate>();
        candidateList.add(candidate);
        candidateList.add(candidate2);
        CandidateRegister candidateRegister = new CandidateRegister(candidateList);
        List<Candidate> retrievedCandidateList = candidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(candidate, candidate2);
    }
}
