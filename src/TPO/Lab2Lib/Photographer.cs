using System.Linq;
using System.Text;

namespace Lab2Lib
{
    public interface IPhotographer
    {
        void TakePhoto(params Person[] persons);
        byte[] GetPhoto(int moneyInRub);
    }

    public class Photographer : Person, IPhotographer
    {
        private byte[] _photo = null;

        public Photographer(string name, int age, int mood) : base(name, age, mood)
        {
        }

        public void TakePhoto(params Person[] persons)
        {
            var photoTitle = persons.Aggregate("This is super-duper photo with ", (a, b) => $"{a}, {b.Name}");
            _photo = Encoding.UTF8.GetBytes(photoTitle);
        }

        public byte[] GetPhoto(int moneyInRub)
        {
            if (moneyInRub < 5000)
            {
                Mood = -100;
                return null;
            }
            Mood += moneyInRub/100;
            return _photo;
        }
    }
}