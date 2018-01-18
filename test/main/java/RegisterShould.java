import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

/**
 * Created by lenovo_3 on 17/01/2018.
 */
public class RegisterShould {
    @Test
    public void addCandidate() {
        Candidate candidate = new Candidate(new Email("p@gmail.com"), "alex");
        Register register = new Register();
        assertThat(register.addCandidate(candidate)).isTrue();
    }

    @Test
    public void emptyCollection() {
        Register register = new Register();
        Iterable<Candidate> candidateCollection = register.getCandidateCollection();
        assertThat(candidateCollection).isEmpty();
    }

    @Test
    public void haveTheAddedCandidate() {
        Candidate candidate = new Candidate(new Email("p@gmail.com"), "alex");
        Register register = new Register();
        register.addCandidate(candidate);
        Iterable<Candidate> candidateCollection = register.getCandidateCollection();
        assertThat(candidateCollection).isNotEmpty().containsExactly(candidate);
    }

    @Test
    public void notReaddCandidateAlreadyAdded() {
        Candidate candidate = new Candidate(new Email("p@gmail.com"), "alex");
        Candidate candidate2 = new Candidate(new Email("p@gmail.com"), "alex");
        Register register = new Register();
        register.addCandidate(candidate);
        boolean candidateAdded = register.addCandidate(candidate2);
        assertThat(candidateAdded).isFalse();
        Iterable<Candidate> candidateCollection = register.getCandidateCollection();
        assertThat(candidateCollection).isNotEmpty().containsExactly(candidate);
    }

    @Test
    public void notReaddCandidateAlreadyAddedWithDifferentFirstname() {
        Candidate candidate = new Candidate(new Email("p@gmail.com"), "alex");
        Candidate candidate2 = new Candidate(new Email("p@gmail.com"), "paul");
        Register register = new Register();
        register.addCandidate(candidate);
        boolean candidateAdded = register.addCandidate(candidate2);
        assertThat(candidateAdded).isFalse();
        Iterable<Candidate> candidateCollection = register.getCandidateCollection();
        assertThat(candidateCollection).isNotEmpty().containsExactly(new Candidate(new Email("p@gmail.com"), "alex"));
    }

    @Test
    public void returnOrdredCandidatesByFirstname() {
        Candidate candidateA = new Candidate(new Email("p@gmail.com"), "alex");
        Candidate candidateZ = new Candidate(new Email("z@gmail.com"), "z");
        Candidate candidateN = new Candidate(new Email("n@gmail.com"), "n");
        Register register = new Register();
        register.addCandidate(candidateA);
        register.addCandidate(candidateZ);
        register.addCandidate(candidateN);
        Iterable<Candidate> candidateCollection = register.getCandidateCollection();
        assertThat(candidateCollection).containsSequence(candidateA, candidateN, candidateZ);
    }


}
