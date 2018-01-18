import org.assertj.core.api.Assertions;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

public class CandidateRegisterTest {

    private CandidateRegister initializedCandidateRegister;
    public static final Candidate CANDIDATE = new Candidate("carole", "carole@gmail.com");
    public static final Candidate CANDIDATE2 = new Candidate("gabriel", "gabriel@gmail.com");
    public static final Candidate CANDIDATE_SAME_MAIL = new Candidate("anthony", "carole@gmail.com");

    @Before
    public void setUp() throws Exception {
        List<Candidate> candidateList = new ArrayList<Candidate>();
        candidateList.add(CANDIDATE);
        initializedCandidateRegister = new CandidateRegister(candidateList);
    }

    @Test
    public void retrieveEmptyList(){
        CandidateRegister candidateRegister = new CandidateRegister();
        List<Candidate> candidateList = candidateRegister.retrieveAll();
        Assert.assertTrue(candidateList.isEmpty());
    }

    @Test
    public void retrieveCandidateInList(){
        List<Candidate> retrievedCandidateList = initializedCandidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CANDIDATE);
    }

    @Test
    public void retrieveTwoCandidatesInList(){
        List<Candidate> candidateList = new ArrayList<Candidate>();
        candidateList.add(CANDIDATE);
        candidateList.add(CANDIDATE2);
        CandidateRegister candidateRegister = new CandidateRegister(candidateList);
        List<Candidate> retrievedCandidateList = candidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CANDIDATE, CANDIDATE2);
    }

    @Test
    public void addCandidateToEmptyList(){
        CandidateRegister candidateRegister = new CandidateRegister();
        candidateRegister.addCandidate(CANDIDATE);
        List<Candidate> retrievedCandidateList = candidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CANDIDATE);
    }

    @Test
    public void addCandidateToNonEmptyList(){
        initializedCandidateRegister.addCandidate(CANDIDATE2);
        List<Candidate> retrievedCandidateList = initializedCandidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CANDIDATE, CANDIDATE2);
    }

    @Test
    public void addCandidateWithSameMail(){
        initializedCandidateRegister.addCandidate(CANDIDATE_SAME_MAIL);
        List<Candidate> retrievedCandidateList = initializedCandidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CANDIDATE);
    }

}
