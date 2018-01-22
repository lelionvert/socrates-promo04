/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class Register {

    private final Candidates candidates;

    public Register(Candidates candidates) {
        this.candidates = candidates;
    }

    public void addCandidate(String emailInput, String firstName) throws InvalidEmailException {
        Email email = Email.create(emailInput);
        Candidate candidate = new Candidate(email, firstName);
        candidates.add(candidate);
    }
}
