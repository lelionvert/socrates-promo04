package fr.lacombe.socratesfr;

import java.util.*;

/**
 * Created by lenovo_3 on 17/01/2018.
 */
public class CandidateCollection {

    private final Collection<Candidate> candidates = new HashSet<>();

    public boolean add(Candidate candidate) {
        if (candidates.stream().anyMatch(candidate::sameEmail)) return false;
        return candidates.add(candidate);
    }

    public List<Candidate> createAlphabeticallySortedListOfCandidates() {
        ArrayList<Candidate> candidates = new ArrayList<>(this.candidates);
        Collections.sort(candidates);
        return candidates;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        CandidateCollection that = (CandidateCollection) o;

        return candidates.equals(that.candidates);
    }

    @Override
    public int hashCode() {
        return candidates.hashCode();
    }

    @Override
    public String toString() {
        return "fr.lacombe.socratesfr.CandidateCollection{" +
                "candidates=" + candidates +
                '}';
    }
}
