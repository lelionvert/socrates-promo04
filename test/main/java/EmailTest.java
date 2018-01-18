import org.assertj.core.util.Lists;
import org.junit.Test;

import java.util.List;

import static org.assertj.core.api.Assertions.assertThat;
import static org.junit.Assert.*;

/**
 * Created by lenovo_3 on 18/01/2018.
 */
public class EmailTest {
    @Test
    public void haveValidEmail() {
        List<String> something = Lists.newArrayList("houssam@gmail.com", "a@mail.com", "rien.quelquechose@re.com");
        assertThat(something).allMatch(c ->new Email(c).hasValidEmail());
    }

    @Test
    public void haveInvalidEmail() {
        List<String> something = Lists.newArrayList("something", "", "rien@blabla @re.com");
        assertThat(something).allMatch(c -> !(new Email(c).hasValidEmail()));
    }

}