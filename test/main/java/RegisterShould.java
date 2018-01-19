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
    public void notSuccessfullyAddCandidateWithDuplicateEmail() throws InvalidEmailException {
        Candidate aCandidate = new Candidate(Email.create("p@gmail.com"), "alex");
        Candidate anotherCandidate = new Candidate(Email.create("p@gmail.com"), "alex");
        Register register = new Register();
        register.add(aCandidate);
        boolean addSuccesful = register.add(anotherCandidate);
        assertThat(addSuccesful).isFalse();
    }

    @Test
    public void notAddDuplicateCandidate() throws InvalidEmailException {
        Candidate aCandidate = new Candidate(Email.create("p@gmail.com"), "alex");
        Candidate anotherCandidate = new Candidate(Email.create("p@gmail.com"), "alex");
        Register register = new Register();
        register.add(aCandidate);
        register.add(anotherCandidate);
        Register expectedRegister = new Register();
        expectedRegister.add(aCandidate);
        assertThat(register).isEqualTo(expectedRegister);
    }

    @Test
    public void notSuccessfullyAddAnotherCandidatesWithDuplicateEmail() throws InvalidEmailException {
        Candidate aCandidate = new Candidate(Email.create("p@gmail.com"), "alex");
        Candidate anotherCandidate = new Candidate(Email.create("p@gmail.com"), "paul");
        Register register = new Register();
        register.add(aCandidate);
        boolean addSuccesful = register.add(anotherCandidate);
        assertThat(addSuccesful).isFalse();
    }

    @Test
    public void notAddAnotherCandidateWithDuplicateEmail() throws InvalidEmailException {
        Candidate aCandidate = new Candidate(Email.create("p@gmail.com"), "alex");
        Candidate anotherCandidate = new Candidate(Email.create("p@gmail.com"), "paul");
        Register register = new Register();
        register.add(aCandidate);
        register.add(anotherCandidate);
        Register expectedRegister = new Register();
        expectedRegister.add(aCandidate);
        assertThat(register).isEqualTo(expectedRegister);
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
