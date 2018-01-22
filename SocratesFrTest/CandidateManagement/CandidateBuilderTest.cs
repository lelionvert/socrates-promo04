using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using NUnit.Framework;
using SocratesFr.CandidateManagement;

namespace SocratesFrTest.CandidateManagement
{
    public class CandidateBuilderTest
    {
        [Test]
        public void Invalid_Candidate_Should_Return_Error_Message()
        {
            Check.ThatCode(() => CandidateBuilder.Create("toto", "toto@gmail")).Throws<ArgumentException>();
        }

        [Test]
        public void Valid_Candidate_Should_Be_Created()
        {
            Check.That(CandidateBuilder.Create("toto", "toto@gmail.fr")
                .Equals(new Candidate("toto", Email.Builder("toto@gmail.fr"))));
        }
    }
}
