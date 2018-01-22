using System.Text.RegularExpressions;

namespace SocratesFr.CandidateManagement
{
    public class EmailValidator
    {
        public static bool IsValid(string address)
        {
            const string format = "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            return Regex.IsMatch(address, format);
        }
    }
}