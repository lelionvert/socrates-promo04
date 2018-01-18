import org.assertj.core.api.Assertions;
import org.junit.Assert;
import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class CandidateRegisterTest {

    public static final Candidate CAROLE = new Candidate("carole", "carole@gmail.com");
    public static final Candidate GABRIEL = new Candidate("gabriel", "gabriel@gmail.com");
    public static final Candidate ANTHONY = new Candidate("anthony", "anthony@gmail.com");
    public static final Candidate ANTHONY_SAME_EMAIL_AS_CAROLE = new Candidate("anthony", "carole@gmail.com");

    private CandidateRegister initCandidateRegister(Candidate... candidates) {
        List<Candidate> candidateList = new ArrayList<>();
        candidateList.addAll(Arrays.asList(candidates));
        return new CandidateRegister(candidateList);
    }

    @Test
    public void retrieveEmptyList() {
        CandidateRegister candidateRegister = initCandidateRegister();
        List<Candidate> candidateList = candidateRegister.retrieveAll();
        Assert.assertTrue(candidateList.isEmpty());
    }

    @Test
    public void retrieveCandidateInList() {
        List<Candidate> retrievedCandidateList = initCandidateRegister(CAROLE).retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CAROLE);
    }

    @Test
    public void retrieveTwoCandidatesInList() {
        CandidateRegister candidateRegister = initCandidateRegister(CAROLE, GABRIEL);
        List<Candidate> retrievedCandidateList = candidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CAROLE, GABRIEL);
    }

    @Test
    public void addCandidateToEmptyList() {
        CandidateRegister candidateRegister = initCandidateRegister();
        candidateRegister.addCandidate(CAROLE);
        List<Candidate> retrievedCandidateList = candidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CAROLE);
    }

    @Test
    public void addCandidateToNonEmptyList() {
        CandidateRegister candidateRegister = initCandidateRegister(CAROLE);
        candidateRegister.addCandidate(GABRIEL);
        List<Candidate> retrievedCandidateList = candidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CAROLE, GABRIEL);
    }

    @Test
    public void addCandidateWithSameEmail() {
        CandidateRegister candidateRegister = initCandidateRegister(CAROLE);
        candidateRegister.addCandidate(ANTHONY_SAME_EMAIL_AS_CAROLE);
        List<Candidate> retrievedCandidateList = candidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CAROLE);
    }

    @Test
    public void retrieveSortedCandidateList() {
        List<Candidate> retrievedCandidateList = initCandidateRegister(CAROLE, GABRIEL, ANTHONY).retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsSequence(ANTHONY, CAROLE, GABRIEL);
    }


}
