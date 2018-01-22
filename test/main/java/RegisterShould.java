import org.assertj.core.api.Assertions;
import org.junit.Test;

/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class RegisterShould {

    @Test
    public void addCandidate() throws InvalidEmailException {
        Candidates candidates = new Candidates();
        Register service = new Register(candidates);
        service.addCandidate("regis.dubois@socrates.com", "regis");

        Candidates onlyOneCandidate = new Candidates();
        Candidate candidate = new Candidate(Email.create("regis.dubois@socrates.com"), "regis");
        onlyOneCandidate.add(candidate);
        Assertions.assertThat(candidates).isEqualTo(onlyOneCandidate);
    }
}
