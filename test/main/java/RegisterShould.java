import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

/**
 * Created by lenovo_3 on 17/01/2018.
 */
public class RegisterShould {
    @Test
    public void addCandidate() throws InvalidEmailException {
        Candidate candidate = new Candidate(Email.create("p@gmail.com"), "alex");
        Register register = new Register();
        assertThat(register.add(candidate)).isTrue();
    }

    @Test
    public void emptyCollection() {
        Register register = new Register();
        Iterable<Candidate> candidateCollection = register.createAlphabeticallySortedListOfCandidates();
        assertThat(candidateCollection).isEmpty();
    }

    @Test
    public void haveTheAddedCandidate() throws InvalidEmailException {
        Candidate candidate = new Candidate(Email.create("p@gmail.com"), "alex");
        Register register = new Register();
        register.add(candidate);
        Iterable<Candidate> candidateCollection = register.createAlphabeticallySortedListOfCandidates();
        assertThat(candidateCollection).isNotEmpty().containsExactly(candidate);
    }

    @Test
    public void notReaddCandidateAlreadyAdded() throws InvalidEmailException {
        Candidate candidate = new Candidate(Email.create("p@gmail.com"), "alex");
        Candidate candidate2 = new Candidate(Email.create("p@gmail.com"), "alex");
        Register register = new Register();
        register.add(candidate);
        boolean candidateAdded = register.add(candidate2);
        assertThat(candidateAdded).isFalse();
        Iterable<Candidate> candidateCollection = register.createAlphabeticallySortedListOfCandidates();
        assertThat(candidateCollection).isNotEmpty().containsExactly(candidate);
    }

    @Test
    public void notReaddCandidateAlreadyAddedWithDifferentFirstname() throws InvalidEmailException {
        Candidate candidate = new Candidate(Email.create("p@gmail.com"), "alex");
        Candidate candidate2 = new Candidate(Email.create("p@gmail.com"), "paul");
        Register register = new Register();
        register.add(candidate);
        boolean candidateAdded = register.add(candidate2);
        assertThat(candidateAdded).isFalse();
        Iterable<Candidate> candidateCollection = register.createAlphabeticallySortedListOfCandidates();
        assertThat(candidateCollection).isNotEmpty().containsExactly(new Candidate(Email.create("p@gmail.com"), "alex"));
    }

    @Test
    public void returnOrdredCandidatesByFirstname() throws InvalidEmailException {
        Candidate candidateA = new Candidate(Email.create("p@gmail.com"), "alex");
        Candidate candidateZ = new Candidate(Email.create("z@gmail.com"), "z");
        Candidate candidateN = new Candidate(Email.create("n@gmail.com"), "n");
        Register register = new Register();
        register.add(candidateA);
        register.add(candidateZ);
        register.add(candidateN);
        Iterable<Candidate> candidateCollection = register.createAlphabeticallySortedListOfCandidates();
        assertThat(candidateCollection).containsSequence(candidateA, candidateN, candidateZ);
    }

}
