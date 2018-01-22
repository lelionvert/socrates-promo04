/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class Register {

    private final Candidates candidates;

    public Register(Candidates candidates) {
        this.candidates = candidates;
    }

    public void addCandidate(String emailInput, String firstname) throws InvalidEmailException {
        Email email = Email.create(emailInput);
        Candidate candidate = new Candidate(email, firstname);
        candidates.add(candidate);
    }
}
