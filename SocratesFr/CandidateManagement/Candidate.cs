using System.Collections.Generic;

namespace SocratesFr.CandidateManagement
{
    public class Candidate
    {

        public string Name { get; }
        public Email Email { get; }

        public Candidate(string name, Email email)
        {
            Name = name;
            Email = email;
        }

        public bool HasSameEmail(Candidate candidate)
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

        public class Builder
        {
            public Candidate Create()
            {
                if (Email != null)
                {
                    CandidateManagement.Email.From(Email);
                }
                throw new System.NullReferenceException();
            }

            public string Email { get; set; }
            public string Name { get; set; }
        }
    }
}