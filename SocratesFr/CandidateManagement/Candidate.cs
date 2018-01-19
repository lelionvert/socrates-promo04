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
        }

        public string Name { get; }
        public Email Email { get; }

        public bool HasSameMail(Candidate candidate)
        {
            return Email.Equals(candidate.Email);
        }

        public override bool Equals(object obj)
        {
            return obj is Candidate candidate &&
                   Name == candidate.Name &&
                   EqualityComparer<Email>.Default.Equals(Email, candidate.Email);
        }

        public override int GetHashCode()
        {
            var hashCode = 1666616157;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<Email>.Default.GetHashCode(Email);
            return hashCode;
        }
    }
}