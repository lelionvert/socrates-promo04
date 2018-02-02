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
        [SetUp]
        public void EraseMytest()
        {
            DataBasePostgreSQL dataBase = new DataBasePostgreSQL();
            dataBase.EraseCandidat("mytest@test.fr");
        }

        [Test]
        public void InsertNewCandidatInBase()
        {
            DataBasePostgreSQL dataBase = new DataBasePostgreSQL();
            int result = dataBase.InsertIntoCandidat("myInsert", "mytest@test.fr");
            Check.That(result).IsPositiveOrZero();
        }

        [Test]
        public void EraseCandidatInBase()
        {
            DataBasePostgreSQL dataBase = new DataBasePostgreSQL();
            dataBase.InsertIntoCandidat("myErase", "mytest@test.fr");
            int result = dataBase.EraseCandidat("mytest@test.fr");
            Check.That(result).IsEqualTo(1);
        }
    }
}
