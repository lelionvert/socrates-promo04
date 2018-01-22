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
    public void AddingSeveralCandidates() throws Exception, InvalidEmailException {
        Candidates candidates = new Candidates();
        Register service = new Register(candidates);
        service.addCandidate("regis.dubois@socrates.com", "regis");
        service.addCandidate("fanny.dubois@crafts.com", "fanny");
        service.addCandidate("emilie.dupuis@testing.fr", "emilie");

        Candidates threeCandidates = new Candidates();
        Candidate candidate = new Candidate(Email.create("regis.dubois@socrates.com"), "regis");
        Candidate candidate2 = new Candidate(Email.create("fanny.dubois@crafts.com"), "fanny");
        Candidate candidate3 = new Candidate(Email.create("emilie.dupuis@testing.fr"), "emilie");
        threeCandidates.add(candidate);
        threeCandidates.add(candidate2);
        threeCandidates.add(candidate3);

        Assertions.assertThat(candidates).isEqualTo(threeCandidates);
    }
}
