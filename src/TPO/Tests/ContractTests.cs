using System;
using Lab2Lib;
using NUnit.Framework;

namespace Tests
{
    public class ContractTests
    {
        private Groom Groom { get; set; }
        private Bride Bride { get; set; }
        private Contract Contract { get; set; }

        [SetUp]
        public void Setup()
        {
            Groom = new Groom("Name", 25, 100);
            Bride = new Bride("Name", 18, 100);
            Contract = new Contract(Groom, Bride, DateTime.Parse("16.04.2016"));
        }

        [Test]
        public void Proporties_Test()
        {
            Assert.AreEqual(Contract.Groom, Groom);
            Assert.AreEqual(Contract.Bride, Bride);
            Assert.AreEqual(Contract.Date, DateTime.Parse("16.04.2016"));
        }

        [Test]
        public void ContractWithNullGroom_Test()
        {
            Assert.Catch(() => new Contract(null, Bride, DateTime.Now));
        }

        [Test]
        public void ContractWithNullBride_Test()
        {
            Assert.Catch(() => new Contract(Groom, null, DateTime.Now));
        }

        [Test]
        public void GroomHasMistress_Test()
        {
            var mistress = new Bride("Name", 15, 150);
            var groom = new Groom("Name", 25, 50, mistress);
            var bride = new Bride("Name", 18, 50);
            Assert.Catch(() => new Contract(groom, bride, DateTime.Now));
        }
    }
}