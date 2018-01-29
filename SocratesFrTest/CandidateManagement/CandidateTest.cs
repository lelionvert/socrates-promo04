using System;
using System.Collections.Generic;
using System.Text;
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
            Candidate candidateOne = new Candidate("Toto", Email.Builder("toto@gmail.com"));
            Candidate candidateTwo = new Candidate("Titi", Email.Builder("toto@gmail.com"));
            Check.That(candidateOne.Equals(candidateTwo)).IsFalse();
        }

        [Test]
        public void HasSameEmail_Should_Return_True_When_Email_Are_Same()
        {
            Candidate candidateOne = new Candidate("Toto", Email.Builder("toto@gmail.com"));
            Candidate candidateTwo = new Candidate("Titi", Email.Builder("toto@gmail.com"));
            Check.That(candidateOne.HasSameEmail(candidateTwo)).IsTrue();
        }

        [Test]
        public void Equals_Should_Return_True_When_Two_Same_Candidates()
        {
            Candidate candidateOne = new Candidate("Toto", Email.Builder("toto@gmail.com"));
            Check.That(candidateOne.Equals(new Candidate("Toto", Email.Builder("toto@gmail.com")))).IsTrue();
        }

        [Test]
        public void HasSameEmail_Should_Return_False_When_Email_Are_Different()
        {
            Candidate candidateOne = new Candidate("Toto", Email.Builder("toto@gmail.com"));
            Candidate candidateTwo = new Candidate("Titi", Email.Builder("titi@gmail.com"));
            Check.That(candidateOne.HasSameEmail(candidateTwo)).IsFalse();
        }

        [Test]
        public void GetHashCode_Should_Be_Equal()
        {
            Candidate candidateOne = new Candidate("Toto", Email.Builder("toto@gmail.com"));
            Candidate candidateTwo = new Candidate("Toto", Email.Builder("toto@gmail.com"));
            Check.That(candidateOne.GetHashCode()).IsEqualTo(candidateTwo.GetHashCode());
        }

        [Test]
        public void GetHashCode_Should_Not_Be_Equal()
        {
            Candidate candidateOne = new Candidate("Toto", Email.Builder("toto@gmail.com"));
            Candidate candidateTwo = new Candidate("Titi", Email.Builder("toto@gmail.com"));
            Check.That(candidateOne.GetHashCode()).IsNotEqualTo(candidateTwo.GetHashCode());
        }
    }
}
