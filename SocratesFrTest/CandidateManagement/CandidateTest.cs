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
            Candidate candidateOne = new Candidate("Toto", "toto@gmail.com");
            Candidate candidateTwo = new Candidate("Titi", "toto@gmail.com");
            Check.That(candidateOne.Equals(candidateTwo)).IsFalse();
        }

        [Test]
        public void HasSameMail_Should_Return_True_When_Mail_Are_Same()
        {
            Candidate candidateOne = new Candidate("Toto", "toto@gmail.com");
            Candidate candidateTwo = new Candidate("Titi", "toto@gmail.com");
            Check.That(candidateOne.HasSameMail(candidateTwo)).IsTrue();
        }

        [Test]
        public void Equals_Should_Return_True_When_Two_Same_Candidates()
        {
            Candidate candidateOne = new Candidate("Toto", "toto@gmail.com");
            Check.That(candidateOne.Equals(new Candidate("Toto", "toto@gmail.com"))).IsTrue();
        }

        [Test]
        public void HasSameMail_Should_Return_False_When_Mail_Are_Different()
        {
            Candidate candidateOne = new Candidate("Toto", "toto@gmail.com");
            Candidate candidateTwo = new Candidate("Titi", "titi@gmail.com");
            Check.That(candidateOne.HasSameMail(candidateTwo)).IsFalse();
        }
    }
}
