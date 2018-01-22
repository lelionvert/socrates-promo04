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

        [Test]
        public void IsValid_Should_Not_Be_Valid_With_Null_Parameter()
        {
            Check.That(EmailValidator.IsValid(null)).IsFalse();
        }
    }
}