using System.Text.RegularExpressions;

namespace SocratesFr.CandidateManagement
{
    public class EmailValidator
    {
        private const string EMAIL_FORMAT = "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";

        public static bool IsValid(string address)
        {
            return !string.IsNullOrEmpty(address) && Regex.IsMatch(address, EMAIL_FORMAT);
        }
    }
}