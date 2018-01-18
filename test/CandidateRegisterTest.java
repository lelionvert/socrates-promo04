import org.assertj.core.api.Assertions;
import org.junit.Assert;
import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class CandidateRegisterTest {

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
        List<Candidate> retrievedCandidateList = initCandidateRegister(CandidateTest.CAROLE).retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CandidateTest.CAROLE);
    }

    @Test
    public void retrieveTwoCandidatesInList() {
        CandidateRegister candidateRegister = initCandidateRegister(CandidateTest.CAROLE, CandidateTest.GABRIEL);
        List<Candidate> retrievedCandidateList = candidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CandidateTest.CAROLE, CandidateTest.GABRIEL);
    }

    @Test
    public void addCandidateToEmptyList() {
        CandidateRegister candidateRegister = initCandidateRegister();
        candidateRegister.addCandidate(CandidateTest.CAROLE);
        List<Candidate> retrievedCandidateList = candidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CandidateTest.CAROLE);
    }

    @Test
    public void addCandidateToNonEmptyList() {
        CandidateRegister candidateRegister = initCandidateRegister(CandidateTest.CAROLE);
        candidateRegister.addCandidate(CandidateTest.GABRIEL);
        List<Candidate> retrievedCandidateList = candidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CandidateTest.CAROLE, CandidateTest.GABRIEL);
    }

    @Test
    public void addCandidateWithSameEmail() {
        CandidateRegister candidateRegister = initCandidateRegister(CandidateTest.CAROLE);
        candidateRegister.addCandidate(CandidateTest.ANTHONY_SAME_EMAIL_AS_CAROLE);
        List<Candidate> retrievedCandidateList = candidateRegister.retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsExactly(CandidateTest.CAROLE);
    }

    @Test
    public void retrieveSortedCandidateList() {
        List<Candidate> retrievedCandidateList = initCandidateRegister(CandidateTest.CAROLE, CandidateTest.GABRIEL, CandidateTest.ANTHONY).retrieveAll();
        Assertions.assertThat(retrievedCandidateList).containsSequence(CandidateTest.ANTHONY, CandidateTest.CAROLE, CandidateTest.GABRIEL);
    }


}
