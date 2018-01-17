import org.junit.Assert;
import org.junit.Test;

/**
 * Created by lenovo_3 on 17/01/2018.
 */
public class RegisterTest {
    @Test
    public void addCandidate(){
        Candidate candidate = new Candidate("p@gmail.com", "alex");
        Register register = new Register();
        Assert.assertTrue(register.add(candidate));
    }
}
