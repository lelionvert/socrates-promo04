using System;
using System.Collections.Generic;
using System.Text;
using SocratesFr;
using NUnit.Framework;
using NFluent;
using SocratesFr.CandidateManagement;

namespace SocratesFrTest.CandidateManagement
{
    public class EmailTest
    {
        [Test]
        public void Emails_Should_Be_Equals()
        {
            Email email = Email.EmailBuilder("koala@gmail.com");
            Email mail2 = Email.EmailBuilder("koala@gmail.com");
            Check.That(email.Equals(mail2)).IsTrue();
        }

        [TestCase("Koala@gmail.com")]
        [TestCase("KoalaBamboo@gmail.com")]
        public void IsInvalidEmail_Should_Allowed_Invalid_Email(string stringMail)
        {
            Check.That(Email.IsValidEmail(stringMail)).IsTrue();
        }

        [TestCase("Koala")]
        [TestCase("@")]
        [TestCase("@.fr")]
        public void IsInvalidEmail_Should_Refused_Invalid_Email(string stringMail)
        {
            Check.ThatCode(() => Email.EmailBuilder(stringMail)).Throws<ArgumentException>();

        }

    }
}
