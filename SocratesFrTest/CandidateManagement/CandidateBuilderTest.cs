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
    }
}
