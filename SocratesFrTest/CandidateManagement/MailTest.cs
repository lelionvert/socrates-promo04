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

        [TestCase("Koala@gmail.com")]
        public void Mail_HasValidMail_Should_Return_True(string stringMail)
        {
            Mail mail = buildTotoWithMail(stringMail);
            Check.That(mail.HasValidMail()).IsTrue();
        }

        [TestCase("Koala")]
        public void Mail_HasValidMail_Should_Return_false(string stringMail)
        {
            Mail mail = buildTotoWithMail(stringMail);
            Check.That(mail.HasValidMail()).IsFalse();
        }

        private Mail buildTotoWithMail(string mail)
        {
            return new Mail(mail);
        }

    }
}
