using NFluent;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace SocratesFrTest
{
    public class RegisterTest
    {
        [Test]
        public void CandidatesListShouldReturnIsEmpty()
        {
            Register register = new Register();
            List<Candidate> listCandidates = register.GetListOfCandidates();
            Check.That(listCandidates).IsEmpty();
        }

        [Test]
        public void AddCandidateShouldReturnTheCandidate()
        {
            Register register = new Register();
            Candidate candidate = new Candidate("Toto", "toto@gmail.com");
            register.AddCandidate(candidate);
            List<Candidate> listCandidates = register.GetListOfCandidates();
            Check.That(listCandidates[0].Name).IsEqualTo(candidate.Name);
            Check.That(listCandidates[0].Mail).IsEqualTo(candidate.Mail);
        }
    }
}
