import org.junit.Test;

import java.util.Set;

import static org.assertj.core.api.Assertions.assertThat;

/**
 * Created by lenovo_3 on 17/01/2018.
 */
public class RegisterTest {
    @Test
    public void addCandidate(){
        Candidate candidate = new Candidate("p@gmail.com", "alex");
        Register register = new Register();
        assertThat(register.add(candidate)).isTrue();
    }

    @Test
    public void emptyCollection() {
        Register register = new Register();
        Set<Candidate> candidateCollection = register.getCandidateCollection();
        assertThat(candidateCollection).isEmpty();
    }
}
