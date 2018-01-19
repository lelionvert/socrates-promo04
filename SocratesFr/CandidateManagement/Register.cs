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
            if (_candidates.Any(item => item.HasSameEmail(candidate)))
                return;
            _candidates.Add(candidate);
        }
    }
}