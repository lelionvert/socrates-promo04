import org.assertj.core.util.Lists;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Nested;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.function.Executable;

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

    @Test
    public void notCreateWhenInvalidInput() throws InvalidEmailException {
        Assertions.assertThrows(InvalidEmailException.class, () -> Email.create("houssam@gma@il.com"));
    }
}