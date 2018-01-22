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

        public static Email Builder(string address)
        {
            if (EmailValidator.IsValid(address) == false)
                throw new InvalidEmailException("Invalid email address.");
            return new Email(address);            
        }

        protected bool Equals(Email other)
        {
            return string.Equals(Address, other.Address);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Email) obj);
        }

        public override int GetHashCode()
        {
            return (Address != null ? Address.GetHashCode() : 0);
        }
    }
}