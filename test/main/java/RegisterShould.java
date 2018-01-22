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

    @Test
    public void AddingSeveralCandidates() throws InvalidEmailException {
        Candidates candidates = new Candidates();
        Register service = new Register(candidates);
        service.addCandidate("regis.dubois@socrates.com", "regis");
        service.addCandidate("fanny.dubois@crafts.com", "fanny");
        service.addCandidate("emilie.dupuis@testing.fr", "emilie");

        Candidates threeCandidates = new Candidates();
        Candidate regis = new Candidate(Email.create("regis.dubois@socrates.com"), "regis");
        Candidate fanny = new Candidate(Email.create("fanny.dubois@crafts.com"), "fanny");
        Candidate emilie = new Candidate(Email.create("emilie.dupuis@testing.fr"), "emilie");
        threeCandidates.add(regis);
        threeCandidates.add(fanny);
        threeCandidates.add(emilie);

        Assertions.assertThat(candidates).isEqualTo(threeCandidates);
    }
}
