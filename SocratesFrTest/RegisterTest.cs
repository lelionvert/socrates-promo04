using NFluent;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace SocratesFrTest
{
    public class RegisterTest
    {
        [Test]
        public void CandidatesListShouldReturnIsEmpty()
        {
            Register register = new Register();
            List<Candidate> listCandidates = register.GetListOfCandidates();
            Check.That(listCandidates).IsEmpty();
        }

        [Test]
        public void AddCandidateShouldReturnTheCandidate()
        {
            Register register = new Register();
            Candidate candidate = new Candidate("Toto", "toto@gmail.com");
            register.AddCandidate(candidate);
            List<Candidate> listCandidates = register.GetListOfCandidates();
            Check.That(listCandidates[0].Name).IsEqualTo(candidate.Name);
            Check.That(listCandidates[0].Mail).IsEqualTo(candidate.Mail);
        }

        [Test]
        public void AddOneCandidateTwiceShouldReturnTheFirstCandidate()
        {
            Register register = new Register();
            Candidate candidateOne = new Candidate("Toto", "toto@gmail.com");
            Candidate candidateTwo = new Candidate("Titi", "toto@gmail.com");
            register.AddCandidate(candidateOne);
            register.AddCandidate(candidateTwo);
            List<Candidate> listCandidates = register.GetListOfCandidates();
            Check.That(listCandidates[0].Name).IsEqualTo(candidateOne.Name);
            Check.That(listCandidates[0].Mail).IsEqualTo(candidateOne.Mail);
            Check.That(listCandidates.Count).IsEqualTo(1);
        }

        [Test]
        public void ListOfCandidateShouldReturnSortedList()
        {
            Register register = new Register();
            Candidate candidateOne = new Candidate("Toto", "toto@gmail.com");
            Candidate candidateTwo = new Candidate("Titi", "titi@gmail.com");
            Candidate candidateThree = new Candidate("Tati", "tati@gmail.com");
            register.AddCandidate(candidateOne);
            register.AddCandidate(candidateTwo);
            register.AddCandidate(candidateThree);
            List<Candidate> listCandidates = register.GetListOfCandidates();
            Check.That(listCandidates[0].Name).IsEqualTo(candidateThree.Name);
            Check.That(listCandidates[1].Name).IsEqualTo(candidateTwo.Name);
            Check.That(listCandidates[2].Name).IsEqualTo(candidateOne.Name);            
        }
    }
}
