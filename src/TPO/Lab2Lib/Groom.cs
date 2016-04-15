using System;

namespace Lab2Lib
{
    public interface IGroom
    {
        Bride Bride { get; set; }
        void SayBride(string phrase);
        void ChangeSex();
    }

    public class Groom : Person, IGroom
    {
        private Bride _bride;

        public Groom(string name, int age, int mood, Bride bride = null) : base(name, age, mood)
        {
            Bride = bride;
        }

        public Bride Bride
        {
            get { return _bride; }
            set
            {
                if (_bride != null)
                    throw new Exception("Noooooo!!!");
                _bride = value;
            }
        }

        public void SayBride(string phrase)
        {
            if (Bride == null)
                throw new Exception("Bride not found!");
            Bride.Listen(phrase);
            if (Bride.Mood < 0)
                Mood = 0;
        }

        public void ChangeSex()
        {
            throw new Exception("No! You can't! You are MAN!");
        }
    }
}