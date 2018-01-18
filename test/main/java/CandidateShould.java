import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class CandidateShould {

    private Candidate createCandidateWithEmail(Email email){
        return new Candidate(email, "firstname");
    }


    @Test
    public void beEqual() {
        Candidate candidate1 = new Candidate(new Email("e@ma.il"), "firstname");
        Candidate candidate2 = new Candidate(new Email("e@ma.il"), "firstname");
        boolean isEqual = candidate1.equals(candidate2);
        assertThat(isEqual).isTrue();
    }

    @Test
    public void notBeEqual() {
        Candidate candidate1 = new Candidate(new Email("e@ma.il"), "firstname");
        Candidate candidate2 = new Candidate(new Email("e@ma.il"), "other");
        boolean isEqual = candidate1.equals(candidate2);
        assertThat(isEqual).isFalse();
    }

    @Test
    public void haveSameEmail() {
        Candidate candidate1 = createCandidateWithEmail(new Email("e@ma.il"));
        Candidate candidate2 = createCandidateWithEmail(new Email("e@ma.il"));
        boolean isEqual = candidate1.sameEmail(candidate2);
        assertThat(isEqual).isTrue();
    }

    @Test
    public void notHaveSameEmail() {
        Candidate candidate1 = createCandidateWithEmail(new Email("e@ma.il"));
        Candidate candidate2 = createCandidateWithEmail(new Email("a@ma.il"));
        boolean isEqual = candidate1.sameEmail(candidate2);
        assertThat(isEqual).isFalse();
    }


}
