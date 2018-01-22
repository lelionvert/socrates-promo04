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
        public void Candidate_Cant_Be_Created_With_Invalid_Email()
        {
            Check.ThatCode(() => CandidateBuilder.Create("toto", "toto@gmail")).Throws<InvalidEmailException>();
        }

        [Test]
        public void Valid_Candidate_Should_Be_Created()
        {
            Check.That(CandidateBuilder.Create("toto", "toto@gmail.fr")
                .Equals(new Candidate("toto", Email.Builder("toto@gmail.fr"))));
        }
    }
}
