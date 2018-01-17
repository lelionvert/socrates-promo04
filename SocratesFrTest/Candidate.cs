namespace SocratesFrTest
{
    public class Candidate
    {
        
        public Candidate(string v1, string v2)
        {
            this.Name = v1;
            this.Mail = v2;
        }

        public string Name { get; }
        public string Mail { get; }
    }
}