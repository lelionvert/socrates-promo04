using NFluent;
using NUnit.Framework;
using SocratesFr.CandidateManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework.Constraints;

namespace SocratesFrTest.CandidateManagement
{
    public class RegisterTest
    {
        [Test]
        public void Candidates_List_Should_Return_Is_Empty()
        {
            Register register = new Register();
            List<Candidate> listCandidates = register.GetCandidates();
            Check.That(listCandidates).IsEmpty();
        }

        [Test]
        public void Add_Candidate_Should_Return_The_Candidate()
        {
            Register register = new Register();
            Candidate candidate = new Candidate("Toto", Email.Builder("toto@gmail.com"));
            register.AddCandidate(candidate);
            List<Candidate> listCandidates = register.GetCandidates();
            Check.That(listCandidates).ContainsExactly(candidate);
        }

        [Test]
        public void Add_One_Candidate_Twice_Should_Return_The_First_Candidate()
        {
            Register register = new Register();
            Candidate candidateOne = new Candidate("Toto", Email.Builder("toto@gmail.com"));
            Candidate candidateTwo = new Candidate("Titi", Email.Builder("toto@gmail.com"));
            register.AddCandidate(candidateOne);
            register.AddCandidate(candidateTwo);
            List<Candidate> listCandidates = register.GetCandidates();
            Check.That(listCandidates).ContainsExactly(candidateOne);
            Check.That(listCandidates).HasSize(1);
        }

        [Test]
        public void List_Of_Candidate_Should_Return_Sorted_List()
        {
            Register register = CreateTestRegister(
                ("Toto", "toto@socrates.com"),
                ("Titi", "titi@socrates.com"),
                ("Tata", "tata@socrates.com"));

            List<Candidate> candidates = register.GetCandidates();

            List<Candidate> orderedCandidatesList = CreateTestList(
                ("Tata", "tata@socrates.com"),
                ("Titi", "titi@socrates.com"),
                ("Toto", "toto@socrates.com"));
            Check.That(candidates).Equals(orderedCandidatesList);
        }

        [Test]
        public void User_Add_Candidate_With_Name_And_Email()
        {
            Register register = CreateTestRegister(
                ("regis", "regis.dubois@socrates.com"));

            List<Candidate> listCandidates = register.GetCandidates();

            List<Candidate> orderedCandidatesList = CreateTestList(
                ("regis", "regis.dubois@socrates.com"));
            Check.That(listCandidates).Equals(orderedCandidatesList);
        }

        [Test]
        public void No_Duplication()
        {
            Register register = CreateTestRegister(
                ("regis", "regis.dubois@socrates.com"),
                ("fanny", "fanny.dubois@crafts.com"));
            List<Candidate> existingCandidates = register.GetCandidates();

            register.AddCandidate("fanny", "fanny.dubois@crafts.com");
            List<Candidate> candidates = register.GetCandidates();

            List<Candidate> candidatesOrdered = CreateTestList(
                ("fanny", "fanny.dubois@crafts.com"),
                ("regis", "regis.dubois@socrates.com"));
            Check.That(existingCandidates).Equals(candidatesOrdered);
            Check.That(candidates).Equals(candidatesOrdered);
        }

        private Register CreateTestRegister(params (string Name, string Email)[] tuples)
        {
            Register register = new Register();
            foreach (var tuple in tuples)
            {
                register.AddCandidate(CandidateBuilder.Create(tuple.Name, tuple.Email));
            }
            return (register);
        }

        private List<Candidate> CreateTestList(params (string Name, string Email)[] tuples)
        {
            List<Candidate> candidates = new List<Candidate>();
            foreach (var tuple in tuples)
            {
                candidates.Add(CandidateBuilder.Create(tuple.Name, tuple.Email));
            }
            return (candidates);
        }
    }
}
