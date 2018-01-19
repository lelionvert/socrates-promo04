using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SocratesFr.CandidateManagement
{
    public class CandidateBuilder
    {
        public static Candidate Create(string name, string email)
        {
            return new Candidate(name, Email.EmailBuilder(email)); 
        }
    }
}
