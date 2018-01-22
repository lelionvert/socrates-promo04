/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class Register {

    private final Candidates candidates;

    public Register(Candidates candidates) {
        this.candidates = candidates;
    }

    public void addCandidate(String emailInput, String firstname) {
        Email email = null;
        try {
            email = Email.create(emailInput);
        } catch (InvalidEmailException e) {
            e.printStackTrace();
        }
        Candidate candidate = new Candidate(email, firstname);
        candidates.add(candidate);
    }
}
