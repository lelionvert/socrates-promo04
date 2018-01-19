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
            var candidateOne = new Candidate("Toto", Email.From("toto@gmail.com"));
            var candidateTwo = new Candidate("Titi", Email.From("toto@gmail.com"));
            Check.That(candidateOne.HasSameEmail(candidateTwo)).IsTrue();
        }

        [Test]
        public void HasSameEmail_Two_Candidates_Should_Be_Different_When_They_Have_Not_The_Same_Email()
        {
            var candidateOne = new Candidate("Toto", Email.From("toto@gmail.com"));
            var candidateTwo = new Candidate("Titi", Email.From("titi@gmail.com"));
            Check.That(candidateOne.HasSameEmail(candidateTwo)).IsFalse();
        }
    }
}
