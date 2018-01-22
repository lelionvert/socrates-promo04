using System;
using System.Collections.Generic;
using System.Text;
using SocratesFr.CandidateManagement;

namespace SocratesFrTest.CandidateManagement
{
    public class CandidateCreator
    {
        private const string REGIS_EMAIL = "regis.dubois@socrates.com";
        
        public enum CANDIDATE_ID
        {
            REGIS,
            FANNY,
            EMILIE,
            FANNY_WITH_REGIS_EMAIL,
        }

        private static readonly IDictionary<CANDIDATE_ID, ValueTuple<string, string>> _candidatesDictionnary =
            new Dictionary<CANDIDATE_ID, ValueTuple<string ,string>>()
            {
                {CANDIDATE_ID.REGIS, ("Regis",REGIS_EMAIL)},
                {CANDIDATE_ID.FANNY, ("Fanny","fanny.dubois@crafts.com")},
                {CANDIDATE_ID.EMILIE, ("Emilie","emilie.dupuis@testing.fr")},
                {CANDIDATE_ID.FANNY_WITH_REGIS_EMAIL, ("Fanny", REGIS_EMAIL)},
            };

        public static Candidate Create(CANDIDATE_ID id)
        {
            (string name, string email) = _candidatesDictionnary[id];
            return new Candidate.Builder
            {
                Name = name,
                Email = email
            }.Create();
        }
    }
}
