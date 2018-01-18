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
        public void Equals_Same_Mail_Should_Return_True()
        {
            Mail mail = new Mail("toto@gmail.com");
            Check.That(mail.GetValue().Equals("toto@gmail.com")).IsTrue();
        }

    }
}
