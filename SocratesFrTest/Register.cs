using System;
using System.Collections.Generic;
using System.Linq;

namespace SocratesFrTest
{
    public class Register
    {
        private List<Candidate> listCandidates= new List<Candidate>();
       
        public List<Candidate> GetListOfCandidates()
        {
            return listCandidates.OrderBy(item => item.Name).ToList();
        }

        public void AddCandidate(Candidate candidate)
        {
            if (listCandidates.Any(item => item.Mail.Equals(candidate.Mail)))
                return;
            listCandidates.Add(candidate);
        }
    }
}