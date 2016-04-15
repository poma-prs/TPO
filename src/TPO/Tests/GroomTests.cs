using Lab2Lib;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GroomTests
    {
        private Groom GroomWithoutBride { get; set; }
        private Groom GroomWithBride { get; set; }

        [SetUp]
        public void SetUp()
        {
            GroomWithoutBride = new Groom("Name", 25, 50);
            GroomWithBride = new Groom("Name", 25, 100, new Bride("Name", 18, 100));
        }

        [Test]
        public void GroomProporties_Test()
        {
            Assert.AreEqual(GroomWithoutBride.Bride, null);
            Assert.AreEqual(GroomWithoutBride.Age, 25);
            Assert.AreEqual(GroomWithoutBride.Mood, 50);
            Assert.AreEqual(GroomWithoutBride.Name, "Name");

            Assert.AreNotEqual(GroomWithBride.Bride, null);
        }

        [Test]
        public void GroomWentToLeft_Test()
        {
            GroomWithoutBride.Bride = new Bride("Lusy", 24, 50);
            var mistress = new Bride("Name", 18, 90);
            Assert.Catch(() => GroomWithoutBride.Bride = mistress);
        }

        [Test]
        public void GroomWithoutBrideSay_Test()
        {
            Assert.Catch(() => GroomWithoutBride.SayBride("Bla Bla"));
        }

        [Test]
        public void GroomWithBrideSay_Test()
        {
            Assert.DoesNotThrow(() => GroomWithBride.SayBride("Bla Bla"));
            Assert.AreEqual(GroomWithBride.Mood, 100);
        }

        [Test]
        public void GroomSayToNegativeBride_Test()
        {
            GroomWithoutBride.Bride = new Bride("Name", 18, -100);
            GroomWithoutBride.SayBride("Bla Bla Bla");
            Assert.AreEqual(GroomWithoutBride.Mood, 0);
        }

        [Test]
        public void ChangeSex_Test()
        {
            Assert.Catch(() => GroomWithBride.ChangeSex());
            Assert.Catch(() => GroomWithoutBride.ChangeSex());
        }
    }
}