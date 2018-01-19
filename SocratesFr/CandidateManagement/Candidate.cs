using System;
using System.Collections.Generic;

namespace SocratesFr.CandidateManagement
{
    public class Candidate
    {
        
        public Candidate(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }

        public string Name { get; }
        public string Email { get; }

        public override bool Equals(object obj)
        {
            return obj is Candidate candidate &&
                   Name == candidate.Name &&
                   Email == candidate.Email;
        }

        public override int GetHashCode()
        {
            var hashCode = 1938941508;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            return hashCode;
        }

        public bool HasSameMail(Candidate candidate)
        {
            return Email.Equals(candidate.Email);
        }
    }
}