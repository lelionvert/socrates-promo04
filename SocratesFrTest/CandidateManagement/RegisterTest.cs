﻿using NFluent;
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
            Register register = new Register();
            string userEmail = "regis.dubois@socrates.com";
            string userName = "regis";
            register.AddCandidate(userName, userEmail);

            List<Candidate> listCandidates = register.GetCandidates();

            Check.That(listCandidates).ContainsExactly(CandidateBuilder.Create(userName, userEmail));
        }

        private Register CreateTestRegister(params (string, string)[] tuples)
        {
            Register register = new Register();
            foreach (var tuple in tuples)
            {
                register.AddCandidate(CandidateBuilder.Create(tuple.Item1, tuple.Item2));
            }
            return (register);
        }

        private List<Candidate> CreateTestList(params (string, string)[] tuples)
        {
            List<Candidate> candidates = new List<Candidate>();
            foreach (var tuple in tuples)
            {
                candidates.Add(CandidateBuilder.Create(tuple.Item1, tuple.Item2));
            }
            return (candidates);
        }
    }
}
