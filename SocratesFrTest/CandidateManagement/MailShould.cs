using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using NUnit.Framework;
using SocratesFr.CandidateManagement;

namespace SocratesFrTest.CandidateManagement
{
    public class MailShould
    {
        [Test]
        public void FailWhenMailIsEmpty()
        {
            Check.ThatCode(() => Mail.From("")).Throws<Mail.InvalidMailException>();
        }
    }
}
