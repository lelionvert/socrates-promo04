using NFluent;
using NUnit.Framework;
using SocratesFr.CandidateManagement;

namespace SocratesFrTest.CandidateManagement
{
    public class CandidateTest
    {
        [Test]
        public void HasSameEmail_Two_Candidates_Should_Be_The_Same_When_They_Have_The_Same_Email()
        {
            var candidateOne = new Candidate.Builder
            {
                Name = "Toto",
                Email = "toto@gmail.com"
            }.Create();
            var candidateTwo = new Candidate.Builder
            {
                Name = "Titi",
                Email = "toto@gmail.com"
            }.Create();
            Check.That(candidateOne.HasSameEmail(candidateTwo)).IsTrue();
        }

        [Test]
        public void HasSameEmail_Two_Candidates_Should_Be_Different_When_They_Have_Not_The_Same_Email()
        {
            var candidateOne = new Candidate.Builder
            {
                Name = "Toto",
                Email = "toto@gmail.com"
            }.Create();
            var candidateTwo = new Candidate.Builder
            {
                Name = "Titi",
                Email = "titi@gmail.com"
            }.Create();
            Check.That(candidateOne.HasSameEmail(candidateTwo)).IsFalse();
        }
    }
}
