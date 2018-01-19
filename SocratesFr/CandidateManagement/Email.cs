using System;
using System.Text.RegularExpressions;

namespace SocratesFr.CandidateManagement
{
    public class Email
    {
        private string Address { get; }

        private Email(string address)
        {
            this.Address = address;
        }

        public static Email EmailBuilder(string address)
        {
            Email email = new Email(address);
            if (email.IsValidMail())
                return email;
            throw new ArgumentException("Invalid email address.");
        }

        public override bool Equals(object obj)
        {
            Email email = obj as Email;
            return this != null &&
                   this.Address == email.Address;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool IsValidMail()
        {
            string format = "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            return Regex.IsMatch(Address, format);
        }
    }
}