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
        [TestCase("KoalaBamboo@gmail.com")]
        public void IsInvalidEmail_Should_Allowed_Invalid_Email(string stringMail)
        {
            Mail allowedEmail = new Mail(stringMail);
            Check.That(allowedEmail.IsValidMail()).IsTrue();
        }

        [TestCase("Koala")]
        [TestCase("@")]
        [TestCase("@.fr")]
        public void IsInvalidEmail_Should_Refused_Invalid_Email(string stringMail)
        {
            Mail invalidEmail = new Mail(stringMail);
            Check.That(invalidEmail.IsValidMail()).IsFalse();
        }

    }
}
