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
            Email email = Email.Builder("koala@gmail.com");
            Email mail2 = Email.Builder("koala@gmail.com");
            Check.That(email.Equals(mail2)).IsTrue();
        }

        [TestCase("Koala")]
        [TestCase("@")]
        [TestCase("@.fr")]
        public void IsInvalidEmail_Should_Refused_Invalid_Email(string stringMail)
        {
            Check.ThatCode(() => Email.Builder(stringMail)).Throws<InvalidEmailException>();

        }

    }
}
