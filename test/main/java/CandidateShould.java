import org.junit.Test;

import static org.assertj.core.api.Assertions.assertThat;

public class CandidateShould {
    @Test
    public void beEqual() {
        Candidate candidate1 = new Candidate("e@ma.il", "firstname");
        Candidate candidate2 = new Candidate("e@ma.il", "firstname");
        boolean isEqual = candidate1.equals(candidate2);
        assertThat(isEqual).isTrue();
    }

    @Test
    public void notBeEqual() {
        Candidate candidate1 = new Candidate("e@ma.il", "firstname");
        Candidate candidate2 = new Candidate("e@ma.il", "other");
        boolean isEqual = candidate1.equals(candidate2);
        assertThat(isEqual).isFalse();
    }
}
