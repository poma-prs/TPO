using Lab2Lib;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class BrideTests
    {
        private Bride Bride { get; set; }

        [SetUp]
        public void SetUp()
        {
            Bride = new Bride("Name", 18, 50);
        }

        [Test]
        public void BrideProporties_Test()
        {
            Assert.AreEqual(Bride.Name, "Name");
            Assert.AreEqual(Bride.Age, 18);
            Assert.AreEqual(Bride.Mood, 50);
        }

        [Test]
        public void SayILoveYou_Test()
        {
            Bride.Listen("I love you!");
            Assert.AreEqual(Bride.Mood, 100);
        }

        [Test]
        public void SayYouLookNice_Test()
        {
            Bride.Listen("You look nice!");
            Assert.AreEqual(Bride.Mood, 60);
        }

        [Test]
        public void SayYouLookBad_Test()
        {
            Bride.Listen("Oh! You look bad...");
            Assert.AreEqual(Bride.Mood, -50);
        }

        [Test]
        public void SayLetsGetMarried_Test()
        {
            Bride.Listen("Let's get married!");
            Assert.AreEqual(Bride.Mood, 100550);
        }

        [Test]
        public void SayLetsGetMarried_WithNegativeMood_Test()
        {
            var negativeBride = new Bride("Name", 18, -100);
            negativeBride.Listen("Let's get married!");
            Assert.AreEqual(negativeBride.Mood, -200);
        }

        [Test]
        public void SayBlaBla_Test()
        {
            Bride.Listen("Bla Bla Bla");
            Assert.AreEqual(Bride.Mood, 50);
        }
    }
}