using System.Collections.Generic;
using System.Linq;

namespace SocratesFr.CandidateManagement
{
    public class Register
    {
        private readonly IList<Candidate> _candidates = new List<Candidate>();
       
        public IList<Candidate> GetCandidatesOrderedByName()
        {
            return _candidates.OrderBy(item => item.Name).ToList();
        }

        public void AddCandidate(Candidate candidate)
        {
            if (candidate == null || _candidates.Any(item => item.HasSameEmail(candidate)))
                return;
            _candidates.Add(candidate);
        }

        public override bool Equals(object obj)
        {
            return obj is Register register &&
                   _candidates.SequenceEqual(register._candidates);
        }

        public override int GetHashCode()
        {
            return -1213228956 + EqualityComparer<IList<Candidate>>.Default.GetHashCode(_candidates);
        }
    }
}