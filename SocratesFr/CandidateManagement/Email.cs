using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;

namespace SocratesFr.CandidateManagement
{
    public class Email
    {
        public string MailAddress { get; }
        private static readonly Regex emailRegex = new Regex(@"^([a-z0-9]+(?:[._-][a-z0-9]+)*)@([a-z0-9]+(?:[.-][a-z0-9]+)*\.[a-z]{2,})$");

        public static bool Validate(string email)
        {
            return emailRegex.IsMatch(email);
        }

        public static Email From(string email)
        {
            if (Validate(email))
            {
                return new Email(email);
            }

            throw new InvalidEmailException(email);
        }

        private Email(string email)
        {
            MailAddress = email;
        }

        public class InvalidEmailException : Exception
        {
            public InvalidEmailException(string message) : base($"This email is invalid : {message}")
            {
            }
        }
    }
}
