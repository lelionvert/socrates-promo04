package fr.lacombe.socratesfr;

import org.assertj.core.api.Assertions;
import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class RegisterShould {

    @Test
    public void addCandidate() throws InvalidEmailException {
        CandidateCollection candidateCollection = new CandidateCollection();
        Register service = new Register(candidateCollection);
        service.addCandidate("regis.dubois@socrates.com", "regis");

        CandidateCollection onlyOneCandidate = createCandidatesWith(candidate("regis.dubois@socrates.com", "regis"));
        assertThat(candidateCollection).isEqualTo(onlyOneCandidate);
    }

    @Test
    public void addSeveralCandidates() throws InvalidEmailException {
        CandidateCollection candidateCollection = new CandidateCollection();
        Register service = new Register(candidateCollection);
        service.addCandidate("regis.dubois@socrates.com", "regis");
        service.addCandidate("fanny.dubois@crafts.com", "fanny");
        service.addCandidate("emilie.dupuis@testing.fr", "emilie");

        CandidateCollection threeCandidateCollection = createCandidatesWith(
                candidate("regis.dubois@socrates.com", "regis"),
                candidate("fanny.dubois@crafts.com", "fanny"),
                candidate("emilie.dupuis@testing.fr", "emilie"));

        assertThat(candidateCollection).isEqualTo(threeCandidateCollection);
    }

    @Test
    public void addOneCandidatesWithSeveralExisting() throws InvalidEmailException {
        CandidateCollection candidateCollection = new CandidateCollection();
        String email = "regis.dubois@socrates.com";
        String regis = "regis";
        candidateCollection.add(candidate(email, regis));
        candidateCollection.add(candidate("fanny.dubois@crafts.com", "fanny"));
        Register service = new Register(candidateCollection);
        service.addCandidate("jules.fournier@xp.com", "jules");

        CandidateCollection threeCandidateCollection = createCandidatesWith(
                candidate("regis.dubois@socrates.com", "regis"),
                candidate("fanny.dubois@crafts.com", "fanny"),
                candidate("jules.fournier@xp.com", "jules"));

        assertThat(candidateCollection).isEqualTo(threeCandidateCollection);
    }

    @Test
    public void addSeveralCandidatesWithOneExisting() throws InvalidEmailException {
        CandidateCollection candidateCollection = new CandidateCollection();
        candidateCollection.add(candidate("regis.dubois@socrates.com", "regis"));
        Register service = new Register(candidateCollection);
        service.addCandidate("jules.fournier@xp.com", "jules");
        service.addCandidate("fanny.dubois@crafts.com", "fanny");

        CandidateCollection threeCandidateCollection = createCandidatesWith(
                candidate("jules.fournier@xp.com", "jules"),
                candidate("regis.dubois@socrates.com", "regis"),
                candidate("fanny.dubois@crafts.com", "fanny"));

        assertThat(candidateCollection).isEqualTo(threeCandidateCollection);
    }

    @Test
    public void ignoreDuplicateCandidate() throws InvalidEmailException {
        CandidateCollection candidateCollection = new CandidateCollection();
        candidateCollection.add(candidate("regis.dubois@socrates.com", "regis"));
        candidateCollection.add(candidate("fanny.dubois@crafts.com", "fanny"));
        Register service = new Register(candidateCollection);
        service.addCandidate("fanny.dubois@crafts.com", "fanny");

        CandidateCollection twoCandidateCollection = createCandidatesWith(
                candidate("regis.dubois@socrates.com", "regis"),
                candidate("fanny.dubois@crafts.com", "fanny"));

        assertThat(candidateCollection).isEqualTo(twoCandidateCollection);
    }

    @Test(expected = InvalidEmailException.class)
    public void addCandidatesWithInvalidEmail() throws InvalidEmailException {
        CandidateCollection candidateCollection = new CandidateCollection();
        Register register = new Register(candidateCollection);
        register.addCandidate("joe.dubois", "joe");
    }

    private CandidateCollection createCandidatesWith(Candidate... all) {
        CandidateCollection candidateCollection = new CandidateCollection();
        for (Candidate candidate : all) {
            candidateCollection.add(candidate);
        }
        return candidateCollection;
    }


    private Candidate candidate(String email, String firstName) throws InvalidEmailException {
        return new Candidate(Email.create(email), firstName);
    }
}
