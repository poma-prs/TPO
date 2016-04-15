using System;
using Lab2Lib;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class MarriageOfficeTests
    {
        private MarriageOffice Office { get; set; }

        [SetUp]
        public void Setup()
        {
            Office = new MarriageOffice();
        }

        [Test]
        public void Proporties_Test()
        {
            Assert.AreNotEqual(Office.Brides, null);
            Assert.AreNotEqual(Office.Grooms, null);
            Assert.AreNotEqual(Office.Contracts, null);

            Assert.AreEqual(Office.Brides.Count, 0);
            Assert.AreEqual(Office.Grooms.Count, 0);
            Assert.AreEqual(Office.Contracts.Count, 0);
        }

        [Test]
        public void AddContract_Test()
        {
            var groom = new Groom("Name", 25, 50);
            var bride = new Bride("Name", 25, 50);
            var contract = new Contract(groom, bride, DateTime.Now);
            Office.AddContract(contract);

            Assert.IsTrue(Office.Grooms.Contains(groom));
            Assert.IsTrue(Office.Brides.Contains(bride));
            Assert.IsTrue(Office.Contracts.Contains(contract));
        }
    }
}