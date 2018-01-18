using System;
using System.Collections.Generic;
using System.Text;
using SocratesFr;
using NUnit.Framework;
using NFluent;

namespace SocratesFrTest.CandidateManagement
{
    public class MailTest
    {
        [Test]
        public void Mails_Should_Be_Equals()
        {
            Mail mail = new Mail("koala");
            Mail mail2 = new Mail("koala");
            Check.That(mail.Equals(mail2)).IsTrue();
        }

    }
}
