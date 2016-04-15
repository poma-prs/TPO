using System.Text;

namespace Lab2Lib
{
    public interface IPhotographer
    {
        void TakePhoto();
        byte[] GetPhoto(int moneyInRub);
    }

    public class Photographer : Person, IPhotographer
    {
        private byte[] _photo = null;

        public Photographer(string name, int age) : base(name, age)
        {
        }

        public void TakePhoto()
        {
            _photo = Encoding.UTF8.GetBytes("This is super-duper photo.");
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