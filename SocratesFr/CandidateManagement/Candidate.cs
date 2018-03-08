using SocratesFr.PriceCalculation;
using System;
using System.Collections.Generic;

namespace SocratesFr.CandidateManagement
{
    public class Candidate
    {
        
        public Candidate(string name, Email email)
        {
            this.Name = name;
            this.Email = email;
            this.accommodation = Accommodation.NO_ACCOMMODATION;
        }
        
        public string Name { get; }
        public Email Email { get; }
        public Accommodation accommodation { get; set; }

        protected bool Equals(Candidate other)
        {
            return string.Equals(Name, other.Name) && Equals(Email, other.Email);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Candidate) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ (Email != null ? Email.GetHashCode() : 0);
            }
        }

        public bool HasSameEmail(Candidate candidate)
        {
            return Email.Equals(candidate.Email);
        }

        public override string ToString()
        {
            return $"{Name} - {Email.ToString()} - {accommodation.ToString()}";
        }
    }
}