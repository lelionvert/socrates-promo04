using NFluent;
using NUnit.Framework;
using SocratesFr.CandidateManagement;
using static SocratesFrTest.CandidateManagement.CandidateCreator;

namespace SocratesFrTest.CandidateManagement
{
    public class RegisterTest
    {
        [Test]
        public void Candidates_List_Should_Return_An_Empty_List()
        {
            var register = new Register();
            var listCandidates = register.GetCandidatesOrderedByName();
            Check.That(listCandidates).IsEmpty();
        }

        [Test]
        public void Add_Null_Candidate_Should_Do_Nothing()
        {
            var register = new Register();
            register.AddCandidate(null);
            Check.That(register).Equals(new Register());
        }

        [Test]
        public void Add_Candidate_Should_Return_The_Candidate()
        {
            var register = new Register();
            var candidate = Create(CANDIDATE_ID.REGIS);
            register.AddCandidate(candidate);
            var listCandidates = register.GetCandidatesOrderedByName();
            Check.That(listCandidates).ContainsExactly(candidate);
        }

        [Test]
        public void Add_One_Candidate_Twice_Should_Add_It_Only_Once()
        {
            var register = new Register();
            var candidateRegis = Create(CANDIDATE_ID.REGIS);
            var candidateFanny = Create(CANDIDATE_ID.FANNY_WITH_REGIS_EMAIL);
            register.AddCandidate(candidateRegis);
            register.AddCandidate(candidateFanny);
            var registerWithOneEmail = new Register();
            registerWithOneEmail.AddCandidate(candidateRegis);
            Check.That(register).Equals(registerWithOneEmail);
        }

        [Test]
        public void List_Of_Candidate_Should_Return_Sorted_List()
        {
            var register = new Register();
            var candidateRegis = Create(CANDIDATE_ID.REGIS);
            var candidateFanny = Create(CANDIDATE_ID.FANNY);
            var candidateEmilie = Create(CANDIDATE_ID.EMILIE);
            register.AddCandidate(candidateRegis);
            register.AddCandidate(candidateFanny);
            register.AddCandidate(candidateEmilie);
            var listCandidates = register.GetCandidatesOrderedByName();
            Check.That(listCandidates).ContainsExactly(candidateEmilie, candidateFanny, candidateRegis);        
        }
    }
}
