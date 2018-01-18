import org.assertj.core.api.Assertions;
import org.junit.Assert;
import org.junit.Test;

import static org.junit.Assert.*;

public class CandidateTest {

    @Test
    public void identicalCandidates() throws Exception {
        Candidate carole = new Candidate("carole", "carole@gmail.com");
        Candidate carole2 = new Candidate("carole", "carole@gmail.com");
        Assert.assertEquals(carole, carole2);
    }
}