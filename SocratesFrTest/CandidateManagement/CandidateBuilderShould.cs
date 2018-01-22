using System;
using NFluent;
using NUnit.Framework;
using SocratesFr.CandidateManagement;

namespace SocratesFrTest.CandidateManagement
{
    public class CandidateBuilderShould
    {
        [Test]
        public void NotCreateCandidateWhenNoInput()
        {
            var candidateBuilder = new Candidate.Builder();
            Check.ThatCode(() => candidateBuilder.Create()).Throws<NullReferenceException>();
        }

        [Test]
        public void NotCreateCandidateWhenInvalidEmail()
        {
            var candidateBuilder = new Candidate.Builder();
            candidateBuilder.Name = "toto";
            candidateBuilder.Email = "toto";
            Check.ThatCode(() => candidateBuilder.Create()).Throws<Email.InvalidEmailException>();
        }
    }
}
