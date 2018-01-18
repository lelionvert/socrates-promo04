import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by lenovo_3 on 18/01/2018.
 */
public class Email {
    private final String email;

    public Email(String email) {
        this.email = email;
    }
    public boolean hasValidEmail() {
        final Pattern VALID_EMAIL_ADDRESS_REGEX = Pattern.compile("^[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,6}$", Pattern.CASE_INSENSITIVE);
        Matcher matcher = VALID_EMAIL_ADDRESS_REGEX.matcher(email);
        return matcher.find();
    }
}
