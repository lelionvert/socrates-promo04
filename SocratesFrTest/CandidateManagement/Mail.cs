using System;
using System.Text.RegularExpressions;

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

        public override bool Equals(object obj)
        {
            Mail mail = obj as Mail;
            return this != null &&
                   this.value == mail.value;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool HasValidMail()
        {
            string format = "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            if (Regex.IsMatch(value, format))
            {
                return true;
            }
            return false;
        }
    }
}