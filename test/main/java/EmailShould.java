import org.assertj.core.util.Lists;
import org.junit.Test;

import java.util.List;

import static org.assertj.core.api.Assertions.assertThat;

/**
 * Created by lenovo_3 on 18/01/2018.
 */
public class EmailShould {
    @Test
    public void haveValidEmail() {
        List<String> something = Lists.newArrayList("houssam@gmail.com", "a@mail.com", "rien.quelquechose@re.com");
        assertThat(something).allMatch(c ->new Email(c).isValid());
    }

    @Test
    public void haveInvalidEmail() {
        List<String> something = Lists.newArrayList("something", "", "rien@blabla @re.com");
        assertThat(something).noneMatch(c -> new Email(c).isValid());
    }

    @Test
    public void createValidEmail(){
        Email email = Email.createEmail("houssam@gmail.com");
        assertThat(email).isNotNull();
        assertThat(email.getEmail()).isEqualTo("houssam@gmail.com");
    }

}