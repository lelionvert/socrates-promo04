import org.assertj.core.api.Assertions;
import org.junit.Assert;
import org.junit.Test;

import static org.junit.Assert.*;

public class CandidateTest {
    public static final Candidate CAROLE = new Candidate("carole", "carole@gmail.com");
    public static final Candidate GABRIEL = new Candidate("gabriel", "gabriel@gmail.com");
    public static final Candidate ANTHONY = new Candidate("anthony", "anthony@gmail.com");
    public static final Candidate ANTHONY_SAME_EMAIL_AS_CAROLE = new Candidate("anthony", "carole@gmail.com");

    @Test
    public void identicalCandidates() throws Exception {
        Candidate carole2 = new Candidate("carole", "carole@gmail.com");
        Assert.assertEquals(CAROLE, carole2);
    }

    @Test
    public void differentCandidates() throws Exception {
        Assert.assertNotEquals(CAROLE, GABRIEL);
    }

}