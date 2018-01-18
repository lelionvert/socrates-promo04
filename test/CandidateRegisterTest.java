import org.assertj.core.api.Assertions;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

public class CandidateRegisterTest {

    private CandidateRegister initializedCandidateRegister;
    public static final Candidate CAROLE = new Candidate("carole", "carole@gmail.com");
    public static final Candidate GABRIEL = new Candidate("gabriel", "gabriel@gmail.com");
    public static final Candidate ANTHONY_SAME_EMAIL_AS_CAROLE = new Candidate("anthony", "carole@gmail.com");

    @Before
    public void setUp() throws Exception {
        List<Candidate> candidateList = new ArrayList<Candidate>();
        candidateList.add(CAROLE);
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
        Assertions.assertThat(retrievedCandidateList).containsExactly(CAROLE);
    }

    @Test
    public void retrieveTwoCandidatesInList(){
        List<Candidate> candidateList = new ArrayList<Candidate>();
        candidateList.add(CAROLE);
        candidateList.add(GABRIEL);
        CandidateRegister candidateRegister = new CandidateRegister(candidateList);
        List<Candidate> retrievedCandidateList = candidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CAROLE, GABRIEL);
    }

    @Test
    public void addCandidateToEmptyList(){
        CandidateRegister candidateRegister = new CandidateRegister();
        candidateRegister.addCandidate(CAROLE);
        List<Candidate> retrievedCandidateList = candidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CAROLE);
    }

    @Test
    public void addCandidateToNonEmptyList(){
        initializedCandidateRegister.addCandidate(GABRIEL);
        List<Candidate> retrievedCandidateList = initializedCandidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CAROLE, GABRIEL);
    }

    @Test
    public void addCandidateWithSameEmail(){
        initializedCandidateRegister.addCandidate(ANTHONY_SAME_EMAIL_AS_CAROLE);
        List<Candidate> retrievedCandidateList = initializedCandidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CAROLE);
    }

    @Test
    public void retrieveSortedCandidateList(){
        initializedCandidateRegister.addCandidate(GABRIEL);
        Candidate anthony = new Candidate("anthony", "anthony@gmail.com");
        initializedCandidateRegister.addCandidate(anthony);
        List<Candidate> retrievedCandidateList = initializedCandidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsSequence(anthony, CAROLE, GABRIEL);
    }




}
