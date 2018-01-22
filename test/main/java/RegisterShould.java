import org.junit.Test;

import static org.assertj.core.api.Assertions.*;

/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class RegisterShould {

    @Test
    public void addCandidate() throws InvalidEmailException {
        Candidates candidates = new Candidates();
        Register service = new Register(candidates);
        service.addCandidate("regis.dubois@socrates.com", "regis");

        Candidates onlyOneCandidate = createCandidatesWith(candidate("regis.dubois@socrates.com", "regis"));
        assertThat(candidates).isEqualTo(onlyOneCandidate);
    }

    @Test
    public void addSeveralCandidates() throws InvalidEmailException {
        Candidates candidates = new Candidates();
        Register service = new Register(candidates);
        service.addCandidate("regis.dubois@socrates.com", "regis");
        service.addCandidate("fanny.dubois@crafts.com", "fanny");
        service.addCandidate("emilie.dupuis@testing.fr", "emilie");

        Candidates threeCandidates = createCandidatesWith(
                candidate("regis.dubois@socrates.com", "regis"),
                candidate("fanny.dubois@crafts.com", "fanny"),
                candidate("emilie.dupuis@testing.fr", "emilie"));

        assertThat(candidates).isEqualTo(threeCandidates);
    }

    @Test
    public void addSeveralCandidatesWithSeveralExisting() throws InvalidEmailException {
        Candidates candidates = new Candidates();
        String email = "regis.dubois@socrates.com";
        String regis = "regis";
        candidates.add(candidate(email, regis));
        candidates.add(candidate("fanny.dubois@crafts.com", "fanny"));
        Register service = new Register(candidates);
        service.addCandidate("jules.fournier@xp.com", "jules");

        Candidates threeCandidates = createCandidatesWith(
                candidate("regis.dubois@socrates.com", "regis"),
                candidate("fanny.dubois@crafts.com", "fanny"),
                candidate("jules.fournier@xp.com", "jules"));

        assertThat(candidates).isEqualTo(threeCandidates);
    }

    private Candidates createCandidatesWith(Candidate... all) throws InvalidEmailException {
        Candidates candidates = new Candidates();
        for(Candidate candidate: all) {
            candidates.add(candidate);
        }
        return candidates;
    }


    private Candidate candidate(String email, String firstname) throws InvalidEmailException {
        return new Candidate(Email.create(email), firstname);
    }
}
