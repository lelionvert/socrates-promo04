import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

/**
 * Created by lenovo_3 on 17/01/2018.
 */
public class CandidateCollectionShould {
    @Test
    public void addCandidate() throws InvalidEmailException {
        Candidate candidate = new Candidate(Email.create("p@gmail.com"), "alex");
        CandidateCollection candidateCollection = new CandidateCollection();
        assertThat(candidateCollection.add(candidate)).isTrue();
    }

    @Test
    public void notSuccessfullyAddCandidateWithDuplicateEmail() throws InvalidEmailException {
        Candidate aCandidate = new Candidate(Email.create("p@gmail.com"), "alex");
        Candidate anotherCandidate = new Candidate(Email.create("p@gmail.com"), "alex");
        CandidateCollection candidateCollection = new CandidateCollection();
        candidateCollection.add(aCandidate);
        boolean addSuccesful = candidateCollection.add(anotherCandidate);
        assertThat(addSuccesful).isFalse();
    }

    @Test
    public void notAddDuplicateCandidate() throws InvalidEmailException {
        Candidate aCandidate = new Candidate(Email.create("p@gmail.com"), "alex");
        Candidate anotherCandidate = new Candidate(Email.create("p@gmail.com"), "alex");
        CandidateCollection candidateCollection = new CandidateCollection();
        candidateCollection.add(aCandidate);
        candidateCollection.add(anotherCandidate);
        CandidateCollection expectedCandidateCollection = new CandidateCollection();
        expectedCandidateCollection.add(aCandidate);
        assertThat(candidateCollection).isEqualTo(expectedCandidateCollection);
    }

    @Test
    public void notSuccessfullyAddAnotherCandidatesWithDuplicateEmail() throws InvalidEmailException {
        Candidate aCandidate = new Candidate(Email.create("p@gmail.com"), "alex");
        Candidate anotherCandidate = new Candidate(Email.create("p@gmail.com"), "paul");
        CandidateCollection candidateCollection = new CandidateCollection();
        candidateCollection.add(aCandidate);
        boolean addSuccesful = candidateCollection.add(anotherCandidate);
        assertThat(addSuccesful).isFalse();
    }

    @Test
    public void notAddAnotherCandidateWithDuplicateEmail() throws InvalidEmailException {
        Candidate aCandidate = new Candidate(Email.create("p@gmail.com"), "alex");
        Candidate anotherCandidate = new Candidate(Email.create("p@gmail.com"), "paul");
        CandidateCollection candidateCollection = new CandidateCollection();
        candidateCollection.add(aCandidate);
        candidateCollection.add(anotherCandidate);
        CandidateCollection expectedCandidateCollection = new CandidateCollection();
        expectedCandidateCollection.add(aCandidate);
        assertThat(candidateCollection).isEqualTo(expectedCandidateCollection);
    }

    @Test
    public void returnOrdredCandidatesByFirstName() throws InvalidEmailException {
        Candidate candidateA = new Candidate(Email.create("p@gmail.com"), "alex");
        Candidate candidateZ = new Candidate(Email.create("z@gmail.com"), "z");
        Candidate candidateN = new Candidate(Email.create("n@gmail.com"), "n");
        CandidateCollection candidates = new CandidateCollection();
        candidates.add(candidateA);
        candidates.add(candidateZ);
        candidates.add(candidateN);
        Iterable<Candidate> candidateCollection = candidates.createAlphabeticallySortedListOfCandidates();
        assertThat(candidateCollection).containsSequence(candidateA, candidateN, candidateZ);
    }

}
