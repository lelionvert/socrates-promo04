using SocratesFr.CandidateManagement;
using SocratesFr.PresentationConsole;
using SocratesFr.PriceCalculation;
using System;
using System.Linq;

namespace SocratesFr
{
    public class SocratesFrConsoleRunner
    {
        private Register register = new Register();
        private UserInput userInput = new UserInput();
        private bool loop = true;

        private void DisplayMainActions()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("Press number for action selection:");
            Console.WriteLine("1- Register new Candidate");
            Console.WriteLine("2- Display all Candidates");
            Console.WriteLine("3- Select Accomodation for Candidates");
            Console.WriteLine("********************************************");
        }

        public void Run()
        {
            do
            {
                DisplayMainActions();
                string input = Console.ReadLine();
                var action = userInput.GetInputType(input);
                DispatchActions(action);
            } while (loop);
        }

        private void DispatchActions(InputType action)
        {
            switch(action)
            {
                case (InputType.AddCandidat):
                    AddCandidate();
                    break;
                case (InputType.Quit):
                    loop = false;
                    break;
                case (InputType.DisplayAllCandidates):
                    DisplayAllCandidates();
                    break;
                case (InputType.SelectAccommodation):
                    SelectAccommodation();
                    break;
                default:
                    break;
            }
        }

        private void AddCandidate()
        {
            Console.WriteLine("$> Enter candidate name");
            string name = Console.ReadLine();
            Console.WriteLine("$> Enter candidate email");
            string email = Console.ReadLine();
            try
            {
                register.AddCandidate(name, email);
                Console.WriteLine("$> Candidate added with success.");
            }
            catch (InvalidEmailException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void DisplayAllCandidates()
        {
            var candidates = register.GetCandidates();
            if (candidates.Count == 0)
            {
                Console.WriteLine("$> No candidates added.");
            }
            else
            {
                foreach (var candidate in candidates)
                {
                    Console.WriteLine(candidate.ToString());
                }
            }
        }

        private void SelectAccommodation()
        {
            Console.WriteLine("$> Enter candidate email");
            string stringEmail = Console.ReadLine();
            Email email;
            try
            {
                email = Email.Builder(stringEmail);               
            }
            catch (InvalidEmailException exception)
            {
                Console.WriteLine("$> This candidate email doesn't exist.");
                return;
            }
            Console.WriteLine("$> Enter candidate accommodation s/d/t (single/double/triple)");
            string accommodation = Console.ReadLine();
            var candidates = register.GetCandidates();

            candidates.Where(c => c.Email.Equals(email))
                    .ToList()
                    .First().accommodation = userInput.GetAccommodation(accommodation);
            Console.WriteLine("$> Change accommodation with success");
        }
    }
}
