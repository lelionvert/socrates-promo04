using System;

namespace SocratesFrTest.CandidateManagement
{
    public class Mail
    {
        private string value;

        public Mail(string value)
        {
            this.value = value;
        }

        public string GetValue()
        {
            return value;
        }
    }
}