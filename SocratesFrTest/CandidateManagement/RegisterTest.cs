using NFluent;
using NUnit.Framework;
using SocratesFr.CandidateManagement;

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
        public void Add_Candidate_Should_Return_The_Candidate()
        {
            var register = new Register();
            var candidate = new Candidate("Toto", Email.From("toto@gmail.com"));
            register.AddCandidate(candidate);
            var listCandidates = register.GetCandidatesOrderedByName();
            Check.That(listCandidates).ContainsExactly(candidate);
        }

        [Test]
        public void Add_One_Candidate_Twice_Should_Add_It_Only_Once()
        {
            var register = new Register();
            var candidateOne = new Candidate("Toto", Email.From("toto@gmail.com"));
            var candidateTwo = new Candidate("Titi", Email.From("toto@gmail.com"));
            register.AddCandidate(candidateOne);
            register.AddCandidate(candidateTwo);
            var listCandidates = register.GetCandidatesOrderedByName();
            Check.That(listCandidates).ContainsExactly(candidateOne);
            Check.That(listCandidates).HasSize(1);
        }

        [Test]
        public void List_Of_Candidate_Should_Return_Sorted_List()
        {
            var register = new Register();
            var candidateOne = new Candidate("Toto", Email.From("toto@gmail.com"));
            var candidateTwo = new Candidate("Titi", Email.From("titi@gmail.com"));
            var candidateThree = new Candidate("Tati", Email.From("tati@gmail.com"));
            register.AddCandidate(candidateOne);
            register.AddCandidate(candidateTwo);
            register.AddCandidate(candidateThree);
            var listCandidates = register.GetCandidatesOrderedByName();
            Check.That(listCandidates).ContainsExactly(candidateThree, candidateTwo, candidateOne);        
        }
    }
}
