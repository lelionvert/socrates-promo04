using NFluent;
using NUnit.Framework;
using SocratesFr.PresentationConsole;
using SocratesFr.PriceCalculation;
using System;
using System.Text;

namespace SocratesFrTest.PresentationConsole
{
    public class UserInputShould
    {
        [Test]
        public void Give_Action_To_Quit_Program()
        {
            UserInput userInput = new UserInput();

            var action = userInput.GetInputType("exit");

            Check.That(action).IsEqualTo(InputType.Quit);
        }

        [Test]
        public void Give_Action_To_Add_Candidat()
        {
            UserInput userInput = new UserInput();

            var action = userInput.GetInputType("1");

            Check.That(action).IsEqualTo(InputType.AddCandidat);
        }

        [Test]
        public void Give_Action_To_Display_All_Candidates()
        {
            UserInput userInput = new UserInput();

            var action = userInput.GetInputType("2");

            Check.That(action).IsEqualTo(InputType.DisplayAllCandidates);
        }

        [Test]
        public void Give_No_Action_With_Invalid_Input()
        {
            UserInput userInput = new UserInput();

            var action = userInput.GetInputType("toto");

            Check.That(action).IsEqualTo(InputType.None);
        }

        [Test]
        public void Give_Single_Accommodation()
        {
            UserInput userInput = new UserInput();

            var action = userInput.GetAccommodation("s");

            Check.That(action).IsEqualTo(Accommodation.SINGLE);
        }
    }
}
