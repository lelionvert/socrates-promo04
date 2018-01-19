using System;
using System.Collections.Generic;
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

        public override bool Equals(object obj)
        {
            return obj is Email email &&
                   MailAddress == email.MailAddress;
        }

        public override int GetHashCode()
        {
            return 826360918 + EqualityComparer<string>.Default.GetHashCode(MailAddress);
        }

        public class InvalidEmailException : Exception
        {
            public InvalidEmailException(string message) : base($"This email is invalid : {message}")
            {
            }
        }
    }
}
