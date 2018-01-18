import org.assertj.core.util.Lists;
import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

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

    @Test
    public void haveSameEmail() {
        Candidate candidate1 = new Candidate("e@ma.il");
        Candidate candidate2 = new Candidate("e@ma.il");
        boolean isEqual = candidate1.sameEmail(candidate2);
        assertThat(isEqual).isTrue();
    }

    @Test
    public void notHaveSameEmail() {
        Candidate candidate1 = new Candidate("e@ma.il");
        Candidate candidate2 = new Candidate("a@ma.il");
        boolean isEqual = candidate1.sameEmail(candidate2);
        assertThat(isEqual).isFalse();
    }

    @Test
    public void haveValidEmail() {
        List<String> something = Lists.newArrayList("houssam@gmail.com", "a@mail.com", "rien.quelquechose@re.com");
        assertThat(something).allMatch(c ->new Candidate(c).hasValidEmail());
    }

    @Test
    public void haveInvalidEmail() {
        List<String> something = Lists.newArrayList("something", "", "rien@blabla @re.com");
        assertThat(something).allMatch(c -> !(new Candidate(c).hasValidEmail()));
    }

}
