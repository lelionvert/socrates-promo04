using SocratesFr.PriceCalculation;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SocratesFr.PresentationConsole
{
    public class UserInput
    {
        private Dictionary<string, InputType> actionToExecute = new Dictionary<string, InputType>()
        {
            { "exit", InputType.Quit},
            { "quit", InputType.Quit},
            { "e", InputType.Quit},
            { "1", InputType.AddCandidat},
            { "2", InputType.DisplayAllCandidates},
            { "3", InputType.SelectAccommodation}
        };

        private Dictionary<string, Accommodation> accommodations = new Dictionary<string, Accommodation>()
        {
            { "s", Accommodation.SINGLE},
            { "d", Accommodation.DOUBLE},
            { "t", Accommodation.TRIPLE}
        };

        public InputType GetInputType(string input)
        {
            if (actionToExecute.ContainsKey(input))
                return actionToExecute[input];
            return InputType.None;
        }

        public Accommodation GetAccommodation(string input)
        {
            if (accommodations.ContainsKey(input))
                return accommodations[input];
            return Accommodation.NO_ACCOMMODATION;
        }
    }
}