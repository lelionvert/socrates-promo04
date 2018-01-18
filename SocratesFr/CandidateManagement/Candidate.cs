using System;
using System.Collections.Generic;

namespace SocratesFr.CandidateManagement
{
    public class Candidate
    {
        
        public Candidate(string name, string mail)
        {
            this.Name = name;
            this.Mail = mail;
        }

        public string Name { get; }
        public string Mail { get; }

        public override bool Equals(object obj)
        {
            var candidate = obj as Candidate;
            return candidate != null &&
                   Name == candidate.Name &&
                   Mail == candidate.Mail;
        }

        public override int GetHashCode()
        {
            var hashCode = 1938941508;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Mail);
            return hashCode;
        }

        public bool HasSameMail(Candidate candidate)
        {
            return Mail.Equals(candidate.Mail);
        }
    }
}