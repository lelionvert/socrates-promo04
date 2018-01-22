using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NFluent;
using SocratesFr.CandidateManagement;

namespace SocratesFrTest.CandidateManagement
{
    public class PackageTests
    {
        [Test]
        public void Get_Price_For_Single_Room_Full_Package()
        {
            var package = new Package(Package.Room.SINGLE, 6);
            Check.That(package.Price).Equals(610);
        }
    }
}
