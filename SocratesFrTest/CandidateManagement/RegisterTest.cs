using NFluent;
using NUnit.Framework;
using SocratesFr.CandidateManagement;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SocratesFrTest.CandidateManagement
{
    public class RegisterTest
    {
        [Test]
        public void Candidates_List_Should_Return_An_Empty_List()
        {
            Register register = new Register();
            List<Candidate> listCandidates = register.GetCandidates();
            Check.That(listCandidates).IsEmpty();
        }

        [Test]
        public void Add_Candidate_Should_Return_The_Candidate()
        {
            Register register = new Register();
            Candidate candidate = new Candidate("Toto", Email.From("toto@gmail.com"));
            register.AddCandidate(candidate);
            List<Candidate> listCandidates = register.GetCandidates();
            Check.That(listCandidates).ContainsExactly(candidate);
        }

        [Test]
        public void Add_One_Candidate_Twice_Should_Add_It_Only_Once()
        {
            Register register = new Register();
            Candidate candidateOne = new Candidate("Toto", Email.From("toto@gmail.com"));
            Candidate candidateTwo = new Candidate("Titi", Email.From("toto@gmail.com"));
            register.AddCandidate(candidateOne);
            register.AddCandidate(candidateTwo);
            List<Candidate> listCandidates = register.GetCandidates();
            Check.That(listCandidates).ContainsExactly(candidateOne);
            Check.That(listCandidates).HasSize(1);
        }

        [Test]
        public void List_Of_Candidate_Should_Return_Sorted_List()
        {
            Register register = new Register();
            Candidate candidateOne = new Candidate("Toto", Email.From("toto@gmail.com"));
            Candidate candidateTwo = new Candidate("Titi", Email.From("titi@gmail.com"));
            Candidate candidateThree = new Candidate("Tati", Email.From("tati@gmail.com"));
            register.AddCandidate(candidateOne);
            register.AddCandidate(candidateTwo);
            register.AddCandidate(candidateThree);
            List<Candidate> listCandidates = register.GetCandidates();
            Check.That(listCandidates).ContainsExactly(candidateThree, candidateTwo, candidateOne);        
        }
    }
}
