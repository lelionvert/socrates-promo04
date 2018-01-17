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
    }
}
