using NFluent;
using NUnit.Framework;
using SocratesFr.CandidateManagement;

namespace SocratesFrTest.CandidateManagement
{
    public class EmailValidatorTest
    {
        [TestCase("Koala@gmail.com")]
        [TestCase("KoalaBamboo@gmail.com")]
        public void IsInvalidEmail_Should_Allowed_Invalid_Email(string stringMail)
        {
            Check.That(EmailValidator.IsValid(stringMail)).IsTrue();
        }
    }
}