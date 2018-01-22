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
            var candidate = new Candidate.Builder
            {
                Name = "Toto",
                Email = "toto@gmail.com"
            }.Create();
            register.AddCandidate(candidate);
            var listCandidates = register.GetCandidatesOrderedByName();
            Check.That(listCandidates).ContainsExactly(candidate);
        }

        [Test]
        public void Add_One_Candidate_Twice_Should_Add_It_Only_Once()
        {
            var register = new Register();
            var candidateOne = new Candidate.Builder
            {
                Name = "Toto",
                Email = "toto@gmail.com"
            }.Create();
            var candidateTwo = new Candidate.Builder
            {
                Name = "Titi",
                Email = "toto@gmail.com"
            }.Create();
            register.AddCandidate(candidateOne);
            register.AddCandidate(candidateTwo);
            var registerWithOneEmail = new Register();
            registerWithOneEmail.AddCandidate(candidateOne);
            Check.That(register).Equals(registerWithOneEmail);
        }

        [Test]
        public void List_Of_Candidate_Should_Return_Sorted_List()
        {
            var register = new Register();
            var candidateOne = new Candidate.Builder
            {
                Name = "Toto",
                Email = "toto@gmail.com"
            }.Create();
            var candidateTwo = new Candidate.Builder
            {
                Name = "Titi",
                Email = "titi@gmail.com"
            }.Create();
            var candidateThree = new Candidate.Builder
            {
                Name = "Tati",
                Email = "tati@gmail.com"
            }.Create();
            register.AddCandidate(candidateOne);
            register.AddCandidate(candidateTwo);
            register.AddCandidate(candidateThree);
            var listCandidates = register.GetCandidatesOrderedByName();
            Check.That(listCandidates).ContainsExactly(candidateThree, candidateTwo, candidateOne);        
        }
    }
}
