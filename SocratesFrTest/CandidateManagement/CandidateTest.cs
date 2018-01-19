using NFluent;
using NUnit.Framework;
using SocratesFr.CandidateManagement;

namespace SocratesFrTest.CandidateManagement
{
    public class CandidateTest
    {
        [Test]
        public void Equals_Should_Return_False_When_Different_Candidates()
        {
            var candidateOne = new Candidate("Toto", Email.From("toto@gmail.com"));
            var candidateTwo = new Candidate("Titi", Email.From("toto@gmail.com"));
            Check.That(candidateOne.Equals(candidateTwo)).IsFalse();
        }

        [Test]
        public void Equals_Should_Return_True_When_Two_Same_Candidates()
        {
            var candidateOne = new Candidate("Toto", Email.From("toto@gmail.com"));
            Check.That(candidateOne.Equals(new Candidate("Toto", Email.From("toto@gmail.com")))).IsTrue();
        }

        [Test]
        public void HasSameEmail_Should_Return_True_When_Email_Are_Same()
        {
            var candidateOne = new Candidate("Toto", Email.From("toto@gmail.com"));
            var candidateTwo = new Candidate("Titi", Email.From("toto@gmail.com"));
            Check.That(candidateOne.HasSameEmail(candidateTwo)).IsTrue();
        }

        [Test]
        public void HasSameEmail_Should_Return_False_When_Email_Are_Different()
        {
            var candidateOne = new Candidate("Toto", Email.From("toto@gmail.com"));
            var candidateTwo = new Candidate("Titi", Email.From("titi@gmail.com"));
            Check.That(candidateOne.HasSameEmail(candidateTwo)).IsFalse();
        }

        [Test]
        public void GetHashCode_Should_Be_Equal()
        {
            var candidateOne = new Candidate("Toto", Email.From("toto@gmail.com"));
            var candidateTwo = new Candidate("Toto", Email.From("toto@gmail.com"));
            Check.That(candidateOne.GetHashCode()).IsEqualTo(candidateTwo.GetHashCode());
        }

        [Test]
        public void GetHashCode_Should_Not_Be_Equal()
        {
            var candidateOne = new Candidate("Toto", Email.From("toto@gmail.com"));
            var candidateTwo = new Candidate("Titi", Email.From("toto@gmail.com"));
            Check.That(candidateOne.GetHashCode()).IsNotEqualTo(candidateTwo.GetHashCode());
        }
    }
}
