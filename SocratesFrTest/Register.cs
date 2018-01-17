using System;
using System.Collections.Generic;

namespace SocratesFrTest
{
    public class Register
    {
        private List<Candidate> listCandidates= new List<Candidate>();
       
        public List<Candidate> GetListOfCandidates()
        {
            return listCandidates;
        }

        public void AddCandidate(Candidate candidate)
        {
            listCandidates.Add(candidate);
        }
    }
}