package fr.lacombe.socratesfr;

/**
 * Created by lenovo_3 on 22/01/2018.
 */
public class Register {

    private final CandidateCollection candidateCollection;

    public Register(CandidateCollection candidateCollection) {
        this.candidateCollection = candidateCollection;
    }

    public void addCandidate(String emailInput, String firstName) throws InvalidEmailException {
        Email email = Email.create(emailInput);
        Candidate candidate = new Candidate(email, firstName);
        candidateCollection.add(candidate);
    }
}
