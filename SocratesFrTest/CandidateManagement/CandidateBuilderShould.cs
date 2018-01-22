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
    }
}
