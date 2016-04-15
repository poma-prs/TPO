using Lab2Lib;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class PhotographerTests
    {
        private Photographer Photographer { get; set; }

        [SetUp]
        public void SetUp()
        {
            Photographer = new Photographer("Name", 40, 50);
        }

        [Test]
        public void Proporties_Test()
        {
            Assert.AreEqual(Photographer.Mood, 50);
            Assert.AreEqual(Photographer.Age, 40);
            Assert.AreEqual(Photographer.Name, "Name");
        }

        [Test]
        public void GetPhotoWith50Rub_Test()
        {
            var photo = Photographer.GetPhoto(50);
            Assert.AreEqual(photo, null);
            Assert.AreEqual(Photographer.Mood, -100);
        }

        [Test]
        public void GetPhotoWith5000Rub_Test()
        {
            Photographer.TakePhoto(Photographer); // selfie
            var photo = Photographer.GetPhoto(5000);
            Assert.AreNotEqual(photo, null);
            Assert.AreEqual(Photographer.Mood, 100);
        }

        [Test]
        public void GetPhoto_WithoutTakePhoto_Test()
        {
            var photo = Photographer.GetPhoto(5000);
            Assert.AreEqual(photo, null);
        }
    }
}