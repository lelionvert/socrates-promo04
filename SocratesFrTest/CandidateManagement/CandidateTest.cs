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
        public void Compare_Two_Same_Candidates_Should_Return_True()
        {
            Candidate candidateOne = new Candidate("Toto", "toto@gmail.com");
            Candidate candidateTwo = new Candidate("Titi", "toto@gmail.com");
            Check.That(candidateOne.Equals(candidateTwo)).IsTrue();
        }
    }
}
