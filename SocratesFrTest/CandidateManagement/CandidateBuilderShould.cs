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
            var candidateBuilder = new Candidate.Builder
            {
                Name = "toto",
                Email = "toto"
            };
            Check.ThatCode(() => candidateBuilder.Create()).Throws<Email.InvalidEmailException>();
        }

        [Test]
        public void CreateACandidate()
        {
            var candidateBuilder1 = new Candidate.Builder
            {
                Name = "toto",
                Email = "toto@gmail.com"
            };
            var candidate1 = candidateBuilder1.Create();
            var candidateBuilder2 = new Candidate.Builder
            {
                Name = "toto",
                Email = "toto@gmail.com"
            };
            var candidate2 = candidateBuilder2.Create();
            Check.That(candidate1).Equals(candidate2);
            Check.That(candidate1.Name).Equals("toto");
            Check.That(candidate1.Email.Address).Equals("toto@gmail.com");
        }
    }
}
