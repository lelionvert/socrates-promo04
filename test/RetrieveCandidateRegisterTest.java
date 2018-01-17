import org.junit.Assert;
import org.junit.Test;

import java.util.List;

public class RetrieveCandidateRegisterTest {

    @Test
    public void emptyList(){
        CandidateRegister candidateRegister = new CandidateRegister();
        List<Candidate> candidateList = candidateRegister.retrieve();
        Assert.assertTrue(candidateList.isEmpty());
    }
}
