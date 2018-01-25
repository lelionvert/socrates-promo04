package fr.lacombe.socratesfr;

import org.assertj.core.api.Assertions;
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
        assertThat(something).allMatch(Email::isValid);
    }

    @Test
    public void haveInvalidEmail() {
        List<String> something = Lists.newArrayList("something", "", "rien@blabla @re.com");
        assertThat(something).noneMatch(Email::isValid);
    }

    @Test
    public void createWhenValidInput() throws InvalidEmailException {
        Email email = Email.create("houssam@gmail.com");
        assertThat(email).isEqualTo(Email.create("houssam@gmail.com"));
    }

    @Test(expected = InvalidEmailException.class)
    public void notCreateWhenInvalidInput() throws InvalidEmailException {
        Email.create("houssam@gma@il.com");
    }
}