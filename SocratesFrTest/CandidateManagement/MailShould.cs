using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using NUnit.Framework;
using SocratesFr.CandidateManagement;

namespace SocratesFrTest.CandidateManagement
{
    class MailShould
    {
        [Test]
        public void FailWhenMailIsEmpty()
        {
            Check.That(Mail.From("")).Equals(Mail.Invalid);
        }
    }
}
