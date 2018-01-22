using System.Runtime.ConstrainedExecution;
using NFluent;
using NUnit.Framework;
using SocratesFr.CandidateManagement;
using static SocratesFrTest.CandidateManagement.CandidateCreator;

namespace SocratesFrTest.CandidateManagement
{
    public class CandidateTest
    {
        private readonly Candidate candidateRegis = Create(CANDIDATE_ID.REGIS); 


        [Test]
        public void HasSameEmail_Two_Candidates_Should_Be_The_Same_When_They_Have_The_Same_Email()
        {
            var candidateFannyWithRegisEmail = Create(CANDIDATE_ID.FANNY_WITH_REGIS_EMAIL);
            Check.That(candidateRegis.HasSameEmail(candidateFannyWithRegisEmail)).IsTrue();
        }

        [Test]
        public void HasSameEmail_Two_Candidates_Should_Be_Different_When_They_Have_Not_The_Same_Email()
        {
            var candidateFanny = Create(CANDIDATE_ID.FANNY);
            Check.That(candidateRegis.HasSameEmail(candidateFanny)).IsFalse();
        }
    }
}
