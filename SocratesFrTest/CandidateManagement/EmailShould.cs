using NFluent;
using NUnit.Framework;
using SocratesFr.CandidateManagement;

namespace SocratesFrTest.CandidateManagement
{
    public class EmailShould
    {
        [TestCase("blabla")]
        [TestCase("")]
        [TestCase("bla@bla")]
        [TestCase("@bla")]
        [TestCase("toto.bla")]
        [TestCase("to@to@bla.com")]
        public void FailWhenEmailIsInvalid(string email)
        {
            Check.ThatCode(() => Email.From(email)).Throws<Email.InvalidEmailException>();
        }

        [TestCase("bla@bla.com")]
        [TestCase("bla-bla@bla.fr")]
        [TestCase("bla.bla@bla.org")]
        [TestCase("toto.bla@la-combe-du-lion-vert.fr")]
        public void PassWhenEmailIsValid(string email)
        {
            Check.That(Email.From(email).MailAddress).Equals(email);
        }
    }
}
