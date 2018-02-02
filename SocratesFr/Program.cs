using System;
using SocratesFr.DataBase;

namespace SocratesFrCandidateManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert name :");
            string name = Console.ReadLine();
            Console.WriteLine("Insert email :");
            string email = Console.ReadLine();
            DataBasePostgreSQL db = new DataBasePostgreSQL();
            db.InsertIntoCandidat(name, email);
        }
    }
}
