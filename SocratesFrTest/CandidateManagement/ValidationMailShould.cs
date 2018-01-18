using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using NUnit.Framework;
using SocratesFr.CandidateManagement;

namespace SocratesFrTest.CandidateManagement
{
    class ValidationMailShould
    {
        [Test]
        public void FailWhenMailIsEmpty()
        {
            Check.That(ValidationMail.Validate("")).IsFalse();
        }
    }
}
