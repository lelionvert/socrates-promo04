using System;
using System.Collections.Generic;
using System.Linq;

namespace SocratesFrTest
{
    public class Register
    {
        private List<Candidate> candidates= new List<Candidate>();
       
        public List<Candidate> GetCandidates()
        {
            return candidates.OrderBy(item => item.Name).ToList();
        }

        public void AddCandidate(Candidate candidate)
        {
            if (candidates.Any(item => item.Mail.Equals(candidate.Mail)))
                return;
            candidates.Add(candidate);
        }
    }
}