using System;

namespace SocratesFr.CandidateManagement
{
    public class Mail
    {
        private readonly string _mail;

        public static bool Validate(string v)
        {
            return false;
        }

        public static Mail From(string mail)
        {
            if (Validate(mail))
            {
                return new Mail(mail);
            }

            throw new InvalidMailException(mail);
        }

        private Mail(string mail)
        {
            _mail = mail;
        }

        public class InvalidMailException : Exception
        {
            public InvalidMailException(string message) : base(message)
            {
            }
        }
    }
}
