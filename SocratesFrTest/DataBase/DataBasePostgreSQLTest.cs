using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using NUnit.Framework;
using SocratesFr.DataBase;

namespace SocratesFrTest.DataBase
{
    public class DataBasePostgreSQLTest
    {
        [Test]
        public void InsertNewCandidatInBase()
        {
            DataBasePostgreSQL dataBase = new DataBasePostgreSQL();
            int result = dataBase.InsertIntoCandidat("mytest", "mytest@test.fr");
            Check.That(result).IsPositiveOrZero();
        }
    }
}
