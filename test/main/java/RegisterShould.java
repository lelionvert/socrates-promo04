import org.junit.Test;

import java.util.Set;

import static org.assertj.core.api.Assertions.assertThat;

/**
 * Created by lenovo_3 on 17/01/2018.
 */
public class RegisterShould {
    @Test
    public void addCandidate() {
        Candidate candidate = new Candidate("p@gmail.com", "alex");
        Register register = new Register();
        assertThat(register.addCandidate(candidate)).isTrue();
    }

    @Test
    public void emptyCollection() {
        Register register = new Register();
        Set<Candidate> candidateCollection = register.getCandidateCollection();
        assertThat(candidateCollection).isEmpty();
    }

    @Test
    public void haveTheAddedCandidate() {
        Candidate candidate = new Candidate("p@gmail.com", "alex");
        Register register = new Register();
        register.addCandidate(candidate);
        Set<Candidate> candidateCollection = register.getCandidateCollection();
        assertThat(candidateCollection).isNotEmpty().containsExactly(candidate);
    }


}
