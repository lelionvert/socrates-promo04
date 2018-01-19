using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;

namespace SocratesFr.CandidateManagement
{
    public class Mail
    {
        public string MailAddress { get; }

        public static bool Validate(string v)
        {
            Regex rgx = new Regex(@"^([a-z0-9]+(?:[._-][a-z0-9]+)*)@([a-z0-9]+(?:[.-][a-z0-9]+)*\.[a-z]{2,})$");
            return rgx.IsMatch(v);
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
            MailAddress = mail;
        }

        public class InvalidMailException : Exception
        {
            public InvalidMailException(string message) : base($"This mail is invalid : {message}")
            {
            }
        }
    }
}
