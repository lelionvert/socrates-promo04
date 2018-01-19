import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class CandidateShould {

    private Candidate createCandidateWithEmail(Email email){
        return new Candidate(email, "firstname");
    }


    @Test
    public void beEqual() throws InvalidEmailException {
        Candidate candidate1 = new Candidate(Email.create("e@ma.il"), "firstname");
        Candidate candidate2 = new Candidate(Email.create("e@ma.il"), "firstname");
        boolean isEqual = candidate1.equals(candidate2);
        assertThat(isEqual).isTrue();
    }

    @Test
    public void notBeEqual() throws InvalidEmailException {
        Candidate candidate1 = new Candidate(Email.create("e@ma.il"), "firstname");
        Candidate candidate2 = new Candidate(Email.create("e@ma.il"), "other");
        boolean isEqual = candidate1.equals(candidate2);
        assertThat(isEqual).isFalse();
    }

    @Test
    public void haveSameEmail() throws InvalidEmailException {
        Candidate candidate1 = createCandidateWithEmail(Email.create("e@ma.il"));
        Candidate candidate2 = createCandidateWithEmail(Email.create("e@ma.il"));
        boolean isEqual = candidate1.sameEmail(candidate2);
        assertThat(isEqual).isTrue();
    }

    @Test
    public void notHaveSameEmail() throws InvalidEmailException {
        Candidate candidate1 = createCandidateWithEmail(Email.create("e@ma.il"));
        Candidate candidate2 = createCandidateWithEmail(Email.create("a@ma.il"));
        boolean isEqual = candidate1.sameEmail(candidate2);
        assertThat(isEqual).isFalse();
    }


}
