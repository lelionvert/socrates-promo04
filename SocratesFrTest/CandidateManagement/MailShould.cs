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
        
        [TestCase("blabla")]
        [TestCase("bla@bla")]
        [TestCase("@bla")]
        [TestCase("toto.bla")]
        [TestCase("to@to@bla.com")]
        public void FailWhenMailIsInvalid(string mail)
        {
            Check.ThatCode(() => Mail.From(mail)).Throws<Mail.InvalidMailException>();
        }
    }
}
