using System;
using System.Collections.Generic;
using System.Text;

namespace SocratesFr.CandidateManagement
{
    public class Mail
    {
        public static readonly Mail Invalid = new Mail(null);

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

            return Invalid;
        }

        private Mail(string mail)
        {
            _mail = mail;
        }
    }
}
